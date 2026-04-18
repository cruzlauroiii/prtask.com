try {
    $R = Invoke-WebRequest -Uri 'http://192.168.100.103:8769/logs' -TimeoutSec 5 -UseBasicParsing
    Write-Output $R.Content
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}
