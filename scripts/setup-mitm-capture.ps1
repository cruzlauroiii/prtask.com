# Get PC IP on the same network as phone
$PcIp = (Get-NetIPAddress -AddressFamily IPv4 | Where-Object { $_.IPAddress -like '192.168.137.*' } | Select-Object -First 1).IPAddress
if (-not $PcIp) {
    $PcIp = (Get-NetIPAddress -AddressFamily IPv4 | Where-Object { $_.IPAddress -notlike '127.*' -and $_.IPAddress -notlike '169.*' } | Select-Object -First 1).IPAddress
}
Write-Output "PC IP: $PcIp"

# Kill old mitmproxy
Stop-Process -Name mitmdump -Force -ErrorAction SilentlyContinue
Stop-Process -Name mitmweb -Force -ErrorAction SilentlyContinue
Start-Sleep -Seconds 2

# Start mitmdump
$MitmDump = 'C:\Users\user\AppData\Local\Packages\PythonSoftwareFoundation.Python.3.13_qbz5n2kfra8p0\LocalCache\local-packages\Python313\Scripts\mitmdump.exe'
Start-Process -FilePath $MitmDump -ArgumentList '--listen-port','8888','--set','flow_detail=3' -WindowStyle Hidden -RedirectStandardOutput 'C:\work\prtask.com\mitmproxy-flows.txt' -RedirectStandardError 'C:\work\prtask.com\mitmproxy-err.txt' -PassThru | Select-Object Id

Start-Sleep -Seconds 3

# Set proxy on phone
adb -s 192.168.137.148:45841 shell settings put global http_proxy "${PcIp}:8888" 2>&1

Write-Output "Proxy set to ${PcIp}:8888"
Write-Output "Open Chrome on phone and go to: http://mitm.it"
