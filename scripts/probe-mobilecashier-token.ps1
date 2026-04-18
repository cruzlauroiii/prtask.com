$Base = 'https://mobilecashier.ru'
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'
$DeviceToken = 'b84a6501-c81e-4e95-a148-77b12670102b'
$DeviceId = 'e14ceab085867eab'
$DeviceUuid = 'a29e8f74-e57b-46cf-80a9-a5dff92f49a2'

# Try device token as x-merchant-api-key
Write-Output "=== With device token as x-merchant-api-key ==="
$Headers = @{
    'Authorization' = "Bearer $Jwt"
    'x-merchant-api-key' = $DeviceToken
    'AndroidId' = $DeviceId
    'Content-Type' = 'application/json'
}
$R = Invoke-WebRequest -Uri "$Base/api/v2/device/info" -Method GET -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "GET /api/v2/device/info: $($R.StatusCode) $($R.Content)"

Write-Output "`n=== v3 market with device token ==="
$R2 = Invoke-WebRequest -Uri "$Base/api/v3/market/" -Method GET -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "GET /api/v3/market/: $($R2.StatusCode) $($R2.Content)"

# Try device token as Authorization instead of JWT
Write-Output "`n=== With device token as Authorization ==="
$Headers2 = @{
    'Authorization' = $DeviceToken
    'AndroidId' = $DeviceId
    'Content-Type' = 'application/json'
}
$R3 = Invoke-WebRequest -Uri "$Base/api/v2/device/info" -Method GET -Headers $Headers2 -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "GET /api/v2/device/info: $($R3.StatusCode) $($R3.Content)"

# Try POST to device/info with body
Write-Output "`n=== POST body to device endpoint ==="
$Body = @{
    deviceId = $DeviceId
    userId = '34c9c05b-4de8-4edf-9bfa-0efdb09d8a94'
    deviceUuid = $DeviceUuid
    token = $DeviceToken
} | ConvertTo-Json
$Headers3 = @{
    'Authorization' = "Bearer $Jwt"
    'x-merchant-api-key' = $DeviceToken
    'AndroidId' = $DeviceId
    'Content-Type' = 'application/json'
}
$R4 = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method POST -Body $Body -Headers $Headers3 -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "POST /api/v2/device/: $($R4.StatusCode)"
$C4 = $R4.Content
if ($C4.Length -gt 500) { $C4 = $C4.Substring(0, 500) }
Write-Output "  $C4"
