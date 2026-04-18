$Base = 'http://192.168.100.103:8769'
(Invoke-WebRequest -Uri "$Base/devopt/on" -TimeoutSec 5 -UseBasicParsing).Content
(Invoke-WebRequest -Uri "$Base/wifidebug/on" -TimeoutSec 5 -UseBasicParsing).Content
Write-Output "Waiting for ADB..."
Start-Sleep -Seconds 3
