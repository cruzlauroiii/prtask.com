$Base = 'https://mobilecashier.ru'
$Headers = @{
    'Content-Type' = 'application/json'
    'x-merchant-api-key' = 'test123'
}

Write-Output "=== POST /api/v2/device/ with dummy key ==="
try {
    $Body = '{"device_id":"e14ceab085867eab"}'
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method POST -Body $Body -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    Write-Output "Body: $($R.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}

Write-Output "`n=== POST /api/v2/device/ without key ==="
try {
    $Body = '{"device_id":"e14ceab085867eab"}'
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method POST -Body $Body -ContentType 'application/json' -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    Write-Output "Body: $($R.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}

Write-Output "`n=== GET /api/v2/market/ with dummy key ==="
try {
    $R = Invoke-WebRequest -Uri "$Base/api/v2/market/" -Method GET -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    Write-Output "Body: $($R.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}
