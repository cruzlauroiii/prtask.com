# Try mitmdump instead - save flows to file
# First check if any flows exist via the web interface
try {
    $R = Invoke-WebRequest -Uri 'http://127.0.0.1:8889/flows' -TimeoutSec 5 -UseBasicParsing -Headers @{ 'Accept' = 'application/json' }
    Write-Output "Status: $($R.StatusCode)"
    Write-Output $R.Content.Substring(0, [Math]::Min(500, $R.Content.Length))
} catch {
    Write-Output "Web API: $($_.Exception.Message)"
}

# Kill mitmweb and restart as mitmdump writing to file
Write-Output "`nSwitching to mitmdump with file output..."
Stop-Process -Name mitmweb -Force -ErrorAction SilentlyContinue
Start-Sleep -Seconds 2

$MitmDump = 'C:\Users\user\AppData\Local\Packages\PythonSoftwareFoundation.Python.3.13_qbz5n2kfra8p0\LocalCache\local-packages\Python313\Scripts\mitmdump.exe'
$LogFile = 'C:\work\prtask.com\mitmproxy-flows.txt'

# Start mitmdump logging all headers to file
Start-Process -FilePath $MitmDump -ArgumentList '--listen-port','8888','--set','flow_detail=2','-w','C:\work\prtask.com\mitmproxy-flows.bin' -WindowStyle Hidden -RedirectStandardOutput $LogFile -RedirectStandardError 'C:\work\prtask.com\mitmproxy-err.txt' -PassThru | Select-Object Id

Write-Output "mitmdump started, logging to $LogFile"
Write-Output "Phone proxy: 192.168.100.160:8888"
