namespace Discord_YouTube_App
{
    partial class DiscordYoutubeApp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordYoutubeApp));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 70);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Запустить";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 112);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(380, 185);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // DiscordYoutubeApp
            // 
            this.ClientSize = new System.Drawing.Size(445, 329);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLog);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscordYoutubeApp";
            this.Text = "Discord YouTube App";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}
