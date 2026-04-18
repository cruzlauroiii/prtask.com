# Test with different paths and methods
$Base = 'https://mobilecashier.ru'

# Try common API discovery paths
$Paths = @(
    '/api/v2/device/',
    '/api/v2/device/info',
    '/api/v2/device/register',
    '/api/v2/market/',
    '/api/v2/market/order',
    '/api/v2/',
    '/api/',
    '/'
)

foreach ($P in $Paths) {
    try {
        $R = Invoke-WebRequest -Uri "$Base$P" -Method GET -TimeoutSec 5 -UseBasicParsing -ErrorAction SilentlyContinue
        Write-Output "GET $P : $($R.StatusCode)"
    } catch {
        $Code = $_.Exception.Response.StatusCode
        Write-Output "GET $P : $Code"
    }
}

# Try POST to device endpoint
try {
    $Body = '{"device_id":"e14ceab085867eab"}'
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method POST -Body $Body -ContentType 'application/json' -TimeoutSec 5 -UseBasicParsing
    Write-Output "POST /api/v2/device/ : $($R.StatusCode) $($R.Content)"
} catch {
    $Code = $_.Exception.Response.StatusCode
    Write-Output "POST /api/v2/device/ : $Code"
}
