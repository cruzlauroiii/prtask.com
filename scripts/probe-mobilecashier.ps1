# Probe mobilecashier.ru with various approaches
$Base = 'https://mobilecashier.ru'

# Try with dummy merchant key
$Headers = @{
    'Content-Type' = 'application/json'
    'x-merchant-api-key' = 'test123'
}

Write-Output "=== POST /api/v2/device/ with dummy key ==="
try {
    $Body = '{"device_id":"e14ceab085867eab"}'
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method POST -Body $Body -Headers $Headers -TimeoutSec 10 -UseBasicParsing
    Write-Output "Response: $($R.StatusCode) $($R.Content)"
} catch {
    $Ex = $_.Exception
    if ($Ex.Response) {
        $Stream = $Ex.Response.GetResponseStream()
        $Reader = New-Object System.IO.StreamReader($Stream)
        $Body = $Reader.ReadToEnd()
        Write-Output "Status: $($Ex.Response.StatusCode)"
        Write-Output "Body: $Body"
    } else {
        Write-Output "Error: $($Ex.Message)"
    }
}

Write-Output "`n=== GET /api/v2/device/ with dummy key ==="
try {
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method GET -Headers $Headers -TimeoutSec 10 -UseBasicParsing
    Write-Output "Response: $($R.StatusCode) $($R.Content)"
} catch {
    $Ex = $_.Exception
    if ($Ex.Response) {
        $Stream = $Ex.Response.GetResponseStream()
        $Reader = New-Object System.IO.StreamReader($Stream)
        $Body = $Reader.ReadToEnd()
        Write-Output "Status: $($Ex.Response.StatusCode)"
        Write-Output "Body: $Body"
    } else {
        Write-Output "Error: $($Ex.Message)"
    }
}
