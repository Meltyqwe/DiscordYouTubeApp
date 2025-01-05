using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Discord_YouTube_App
{
    public partial class DiscordYoutubeApp : MaterialForm
    {
        private Process process;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenu;

        public DiscordYoutubeApp()
        {
            InitializeComponent();
            contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Открыть", null, OpenApp);
            contextMenu.Items.Add("Закрыть", null, CloseApp);
            string iconPath = Path.Combine(Application.StartupPath, "dsico.ico");
            notifyIcon = new NotifyIcon
            {
                Icon = new Icon(iconPath),
                Visible = false,
                Text = "Discord YouTube App",
                ContextMenuStrip = contextMenu
            };

            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue800,
                Primary.Blue500, Accent.Orange700,
                TextShade.WHITE);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string listGeneralPath = Path.Combine(appPath, "list-general.txt");
            string quicFilePath = Path.Combine(appPath, "quic_initial_www_google_com.bin");
            string tlsFilePath = Path.Combine(appPath, "tls_clienthello_www_google_com.bin");
            string binPath = Path.Combine(appPath, "winws.exe");

            if (btnStart.Text == "Запустить")
            {
                if (!File.Exists(listGeneralPath) ||
                    !File.Exists(quicFilePath) ||
                    !File.Exists(tlsFilePath) ||
                    !File.Exists(binPath))
                {
                    Log("Ошибка: Один или несколько необходимых файлов отсутствуют.");
                    return;
                }
                string arguments = $@"--wf-tcp=80,443 --wf-udp=443,50000-65535 " +
                                   $@"--filter-udp=443 --hostlist=""{listGeneralPath}"" " +
                                   $@"--dpi-desync=fake --dpi-desync-udplen-increment=10 --dpi-desync-repeats=6 " +
                                   $@"--dpi-desync-udplen-pattern=0xDEADBEEF --dpi-desync-fake-quic=""{quicFilePath}"" --new " +
                                   $@"--filter-udp=50000-65535 --dpi-desync=fake,tamper --dpi-desync-any-protocol " +
                                   $@"--dpi-desync-fake-quic=""{quicFilePath}"" --new " +
                                   $@"--filter-tcp=80 --hostlist=""{listGeneralPath}"" --dpi-desync=fake,split2 --dpi-desync-autottl=2 --dpi-desync-fooling=md5sig --new " +
                                   $@"--filter-tcp=443 --hostlist=""{listGeneralPath}"" --dpi-desync=fake,split2 --dpi-desync-autottl=2 --dpi-desync-fooling=md5sig --dpi-desync-fake-tls=""{tlsFilePath}""";
                process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = binPath,
                        Arguments = arguments,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                };
                try
                {
                    process.Start();
                    Log("Скрипт запущен.");
                    btnStart.Text = "Остановить";
                }
                catch (Exception ex)
                {
                    Log($"Ошибка запуска: {ex.Message}");
                }
            }
            else if (btnStart.Text == "Остановить")
            {
                StopProcess();
            }
        }

        private void StopProcess()
        {
            if (process != null && !process.HasExited)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                    Log("Скрипт остановлен.");
                }
                catch (Exception ex)
                {
                    Log($"Ошибка при остановке процесса: {ex.Message}");
                }
            }
            else
            {
                Log("Скрипт остановлен.");
            }

            btnStart.Text = "Запустить";
        }

        private void Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000, "Приложение свернуто", "Приложение работает в системном трее.", ToolTipIcon.Info);
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void OpenApp(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000, "Приложение свернуто", "Приложение работает в системном трее.", ToolTipIcon.Info);
            }
        }
    }
}
