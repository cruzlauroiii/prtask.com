try {
    $R = Invoke-WebRequest -Uri 'http://192.168.100.103:8769/adbinfo' -TimeoutSec 5 -UseBasicParsing
    Write-Output "ADB Info: $($R.Content)"
} catch {
    Write-Output "Can't reach companion"
}
