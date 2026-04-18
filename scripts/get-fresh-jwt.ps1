# Try to get a fresh JWT from pulsar.psr-it.com
# We know the authorize endpoint from captured traffic
$Base = 'https://pulsar.psr-it.com'

# The authorize call from captured traffic used SHA-256 hashed password
# Let's try with the device info we have
$DeviceId = 'e14ceab085867eab'
$UserId = '34c9c05b-4de8-4edf-9bfa-0efdb09d8a94'

# Try GET on authorize to see what it expects
Write-Output "=== GET /api/v3/authorize ==="
try {
    $R = Invoke-WebRequest -Uri "$Base/api/v3/authorize" -Method GET -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    $Body = $R.Content
    if ($Body.Length -gt 300) { $Body = $Body.Substring(0, 300) }
    Write-Output "Body: $Body"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}

# Try POST with empty body
Write-Output "`n=== POST /api/v3/authorize (empty) ==="
try {
    $R = Invoke-WebRequest -Uri "$Base/api/v3/authorize" -Method POST -Body '{}' -ContentType 'application/json' -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    $Body = $R.Content
    if ($Body.Length -gt 300) { $Body = $Body.Substring(0, 300) }
    Write-Output "Body: $Body"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}

# Try with device headers like PocketPay sends
Write-Output "`n=== POST /api/v3/authorize (with headers) ==="
try {
    $Headers = @{
        'platform' = 'Android'
        'versionName' = '1.0.30'
        'versionCode' = '110304'
    }
    $R = Invoke-WebRequest -Uri "$Base/api/v3/authorize" -Method POST -Body '{}' -ContentType 'application/json' -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    $Body = $R.Content
    if ($Body.Length -gt 500) { $Body = $Body.Substring(0, 500) }
    Write-Output "Body: $Body"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}
