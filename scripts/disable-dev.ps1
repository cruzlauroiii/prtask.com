$Base = 'http://192.168.100.103:8769'
(Invoke-WebRequest -Uri "$Base/wifidebug/off" -TimeoutSec 5 -UseBasicParsing).Content
(Invoke-WebRequest -Uri "$Base/devopt/off" -TimeoutSec 5 -UseBasicParsing).Content
