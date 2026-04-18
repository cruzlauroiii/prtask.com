Start-Sleep -Seconds 5
try {
    $r = Invoke-WebRequest -Uri 'https://cruzlauroiii.github.io/prtask.com/' -UseBasicParsing -MaximumRedirection 0 -ErrorAction Stop
    Write-Host "StatusCode: $($r.StatusCode)"
    Write-Host "Content-Type: $($r.Headers['Content-Type'])"
    $len = [Math]::Min(500, $r.Content.Length)
    Write-Host "First 500 chars:"
    Write-Host $r.Content.Substring(0, $len)
} catch {
    $ex = $_.Exception
    if ($ex.Response) {
        Write-Host "StatusCode: $($ex.Response.StatusCode.value__)"
        Write-Host "Location: $($ex.Response.Headers.Location)"
    } else {
        Write-Host "Error: $($ex.Message)"
    }
}
