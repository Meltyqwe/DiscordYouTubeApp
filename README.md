# Discord YouTube App

**Note**

Этот репозиторий является некоммерческой сборкой оригинальных репозиториев. В нем используются оригинальные бинарники, которые вы можете проверить с помощью хэшей. Поскольку проект является open-source, вы всегда можете собрать эти бинарники самостоятельно и не беспокоиться о безопасности.

Использованные оригинальные репозитории:
- [Flowseal/zapret-discord-youtube](https://github.com/Flowseal/zapret-discord-youtube)
- [bol-van/zapret](https://github.com/bol-van/zapret)
- [bol-van/zapret-win-bundle](https://github.com/bol-van/zapret-win-bundle)

**Caution**

Многие антивирусные программы в настоящее время могут сигнализировать о HackTool/RiskTool и WinDivert — это нормальное поведение, так как программа изменяет сетевые пакеты. Что с этим делать? Собрать бинарники самостоятельно из исходного кода, довериться уже собранным или не использовать программу вообще.

Приложение для обеспечения стабильного доступа к Discord и YouTube, обходя блокировки и ограничения в сети.

---

## Описание

Discord YouTube App позволяет пользователям обходить сетевые блокировки, обеспечивая стабильный доступ к Discord и YouTube. Приложение использует технологии маршрутизации и подмены сетевых пакетов.

---

## Разработка

Этот проект был разработан с использованием технологий и идей из различных open-source репозиториев. Особую благодарность хочу выразить [ChatGPT](https://openai.com/chatgpt) за значительный вклад в разработку приложения. ChatGPT помогал мне в написании и оптимизации кода, а также в решении различных технических задач. Я очень благодарен за его помощь, так как она позволила ускорить процесс разработки и улучшить функциональность приложения.

---

## Особенности
- Использует [WinDivert](https://github.com/basil00/WinDivert) для маршрутизации сетевого трафика и подмены пакетов.
- Основано на [zapret-discord](https://github.com/Flowseal/zapret-discord-youtube) и [zapret](https://github.com/bol-van/zapret).
- Графический интерфейс, разработанный на базе Windows Forms, с использованием [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) для современного дизайна.
- Поддержка управления процессом обхода блокировок: запуск, остановка и мониторинг через лог.
- Работает в системном трее, минимизируя вмешательство в рабочий процесс.
- **Проверено на работоспособность:** Последняя проверка — **05 января 2025 года**.

---

## Как использовать

1. Запустить приложение от имени АДМИНИСТРАТОРА
2. После запуска приложения нажмите кнопку **"Запустить"**, чтобы активировать обход блокировок.  
3. Для остановки работы скрипта нажмите кнопку **"Остановить"**.  
4. Чтобы минимизировать приложение в трей, нажмите кнопку закрытия окна. Чтобы вернуть приложение, дважды щелкните по его значку в трее.

---

## Установка

1. Скачайте последний релиз [здесь](https://github.com/Meltyqwe/DiscordYouTubeApp/releases/tag/1.1).
2. Убедитесь, что у вас есть права администратора.
3. Запустите приложение **от имени администратора**.
4. Наслаждайтесь беспрепятственным доступом к Discord и YouTube!

---

## Лицензия

Проект лицензируется под [MIT License](https://github.com/Meltyqwe/DiscordYouTubeApp/blob/main/License).

---

## Благодарности

- [Flowseal/zapret-discord-youtube](https://github.com/Flowseal/zapret-discord-youtube) за основу для реализации обхода блокировок.
- [WinDivert](https://github.com/basil00/WinDivert) за инструмент для маршрутизации трафика.
- [bol-van/zapret](https://github.com/bol-van/zapret) за технические идеи и подходы.
- [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) за предоставление удобной библиотеки для создания современного дизайна.
- [ChatGPT](https://openai.com/chatgpt) за помощь в разработке и реализации проекта.

---

## Примечания

- Все файлы сторонних разработчиков (скрипты, двоичные файлы и библиотеки) остаются неизменными.
- Убедитесь, что вы запускаете приложение с правами администратора для обеспечения надлежащей функциональности.

---

  ## Хэшы файлов

- **winws.exe** SHA256 hash: `28604CD5B40E42DEF61986E39D59B94F48CD40B615ED711DB799A8E89C856EDD`
- **WinDivert64.sys** SHA256 hash: `8DA085332782708D8767BCACE5327A6EC7283C17CFB85E40B03CD2323A90DDC2`
- **WinDivert.dll** SHA256 hash: `C1E060EE19444A259B2162F8AF0F3FE8C4428A1C6F694DCE20DE194AC8D7D9A2`
- **tls_clienthello_www_google_com.bin** SHA256 hash: `E5938780152169F720383F80EABB309E9477369B83B5EC40CC137C397F862CDE`
- **quic_initial_www_google_com.bin** SHA256 hash: `F4589C57749F956BB30538197A521D7005F8B0A8723B4707E72405E51DDAC50A`
- **cygwin1.dll** SHA256 hash: `712C39A069541AFA69CFCBE01B422BD67B4201EEE7E94CC1327D4ED8B4FA2167`

--- 

# Discord YouTube App (English)

**Note**

This repository is a non-commercial compilation of the original repositories. It uses original binaries that you can verify using hashes. Since the project is open-source, you can always build these binaries yourself and not worry about security.

Used original repositories:
- [Flowseal/zapret-discord-youtube](https://github.com/Flowseal/zapret-discord-youtube)
- [bol-van/zapret](https://github.com/bol-van/zapret)

**Caution**

Many antivirus programs can currently signal HackTool/RiskTool and WinDivert — this is normal behavior, as the program modifies network packets. What should I do about it? Assemble the binaries yourself from the source code, trust those already assembled, or not use the program at all.


An application designed to ensure stable access to Discord and YouTube by bypassing network restrictions and blocks.

---

## Features
- Uses [WinDivert](https://github.com/basil00/WinDivert) for routing network traffic and packet spoofing.
- Based on [zapret-discord](https://github.com/Flowseal/zapret-discord-youtube) and [zapret](https://github.com/bol-van/zapret).
- Graphical interface developed based on Windows Forms, using [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) for modern design.
- Support for managing the process of bypassing locks: start, stop and monitoring via the log.
- Works in the system tray, minimizing interference in the workflow.
- **Tested for operability:** The last check is **January 05, 2025**.

---

## Development

This project was developed using technologies and ideas from various open-source repositories. Special thanks to [ChatGPT](https://openai.com/chatgpt) for the significant contribution to the development of the application. ChatGPT assisted me in writing and optimizing the code, as well as in solving various technical problems. I am very grateful for its help, as it allowed me to accelerate the development process and improve the application's functionality.

---

## How to Use

1. Run the application as an ADMINISTRATOR
2. After launching the application, click **"Run"** to activate lock bypass.
3. To stop the script, click **"Stop it"**.  
4. To minimize the application in the tray, click the close window button. To return the app, double-click on its tray icon.

---

## Installation

1. Download the latest release [here](https://github.com/Meltyqwe/DiscordYouTubeApp/releases/tag/1.1).
2. Make sure you have administrator privileges.
3. Run the application **as administrator**.
4. Enjoy uninterrupted access to Discord and YouTube!

---

## License

The project is licensed under the [MIT License](https://github.com/Meltyqwe/DiscordYouTubeApp/blob/main/License).

---

## Acknowledgments

- [Flowseal/zapret-discord-youtube](https://github.com/Flowseal/zapret-discord-youtube) for providing the foundation for bypassing network blocks.
- [WinDivert](https://github.com/basil00/WinDivert) for packet routing tools.
- [bol-van/zapret](https://github.com/bol-van/zapret) for technical insights and approaches.
- [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) for the modern UI library.
- [ChatGPT](https://openai.com/chatgpt) for assistance in developing and implementing the project.

---

## Notes

- All third-party developer files (scripts, binaries, and libraries) remain unaltered.
- Ensure that you run the application with administrative privileges for proper functionality.

  ---

  ## File Hashes

- **winws.exe** SHA256 hash: `28604CD5B40E42DEF61986E39D59B94F48CD40B615ED711DB799A8E89C856EDD`
- **WinDivert64.sys** SHA256 hash: `8DA085332782708D8767BCACE5327A6EC7283C17CFB85E40B03CD2323A90DDC2`
- **WinDivert.dll** SHA256 hash: `C1E060EE19444A259B2162F8AF0F3FE8C4428A1C6F694DCE20DE194AC8D7D9A2`
- **tls_clienthello_www_google_com.bin** SHA256 hash: `E5938780152169F720383F80EABB309E9477369B83B5EC40CC137C397F862CDE`
- **quic_initial_www_google_com.bin** SHA256 hash: `F4589C57749F956BB30538197A521D7005F8B0A8723B4707E72405E51DDAC50A`
- **cygwin1.dll** SHA256 hash: `712C39A069541AFA69CFCBE01B422BD67B4201EEE7E94CC1327D4ED8B4FA2167`


