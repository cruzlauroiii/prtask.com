try {
    $r = Invoke-WebRequest -Uri 'https://127.0.0.1:64913' -SkipCertificateCheck -TimeoutSec 10 -UseBasicParsing
    Write-Output "STATUS: $($r.StatusCode)"
    Write-Output "LENGTH: $($r.Content.Length)"
    Write-Output "---CONTENT---"
    Write-Output $r.Content.Substring(0, [Math]::Min(3000, $r.Content.Length))
} catch {
    Write-Output "ERROR: $($_.Exception.Message)"
}
