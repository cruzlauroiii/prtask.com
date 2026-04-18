try {
    $R = Invoke-WebRequest -Uri 'http://192.168.100.103:8769/status' -TimeoutSec 5 -UseBasicParsing
    Write-Output $R.Content
} catch {
    Write-Output "Offline: $($_.Exception.Message)"
}
