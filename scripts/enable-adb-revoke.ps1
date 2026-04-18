# Enable wifi debug via companion HTTP, connect ADB, revoke permissions
$Base = 'http://192.168.100.103:8769'
(Invoke-WebRequest -Uri "$Base/devopt/on" -TimeoutSec 5 -UseBasicParsing).Content
(Invoke-WebRequest -Uri "$Base/wifidebug/on" -TimeoutSec 5 -UseBasicParsing).Content
Start-Sleep -Seconds 3
