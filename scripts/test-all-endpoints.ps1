$Base = 'http://192.168.100.103:8769'
$Endpoints = @('/status', '/logs', '/token', '/events', '/nfc', '/headers', '/adbinfo')

foreach ($E in $Endpoints) {
    try {
        $R = Invoke-WebRequest -Uri "$Base$E" -TimeoutSec 5 -UseBasicParsing
        $Content = $R.Content
        if ($Content.Length -gt 200) { $Content = $Content.Substring(0, 200) + '...' }
        Write-Output "$E : $Content"
    } catch {
        Write-Output "$E : ERROR $($_.Exception.Message)"
    }
}
