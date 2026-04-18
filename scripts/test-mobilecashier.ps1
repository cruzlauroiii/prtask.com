# Test mobilecashier endpoints
$Headers = @{ 'Content-Type' = 'application/json' }

Write-Output "=== Testing mobilecashier.ru device API ==="
try {
    $R = Invoke-WebRequest -Uri 'https://mobilecashier.ru/api/v2/device/' -Method GET -TimeoutSec 10 -UseBasicParsing -Headers $Headers
    Write-Output "GET: $($R.StatusCode) $($R.Content.Substring(0, [Math]::Min(500, $R.Content.Length)))"
} catch {
    Write-Output "GET: $($_.Exception.Response.StatusCode) $($_.Exception.Message)"
}

Write-Output ""
Write-Output "=== Testing mobilecashier.psr-it.com market API ==="
try {
    $R = Invoke-WebRequest -Uri 'https://mobilecashier.psr-it.com/api/v2/market/' -Method GET -TimeoutSec 10 -UseBasicParsing -Headers $Headers
    Write-Output "GET: $($R.StatusCode) $($R.Content.Substring(0, [Math]::Min(500, $R.Content.Length)))"
} catch {
    Write-Output "GET: $($_.Exception.Response.StatusCode) $($_.Exception.Message)"
}
