$Base = 'https://mobilecashier.ru'
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'

$Body = @{
    userId = '34c9c05b-4de8-4edf-9bfa-0efdb09d8a94'
    deviceUuid = 'a29e8f74-e57b-46cf-80a9-a5dff92f49a2'
    mid = '177397344332991'
    tid = 'SFT07056'
} | ConvertTo-Json

$Headers = @{
    'Authorization' = "Bearer $Jwt"
    'Content-Type' = 'application/json'
    'AndroidId' = 'e14ceab085867eab'
    'platform' = 'Android'
    'versionName' = '1.0.30'
    'versionCode' = '110304'
}

Write-Output "=== POST /api/v2/device/ (authDevice) ==="
Write-Output "Body: $Body"
try {
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method POST -Body $Body -Headers $Headers -TimeoutSec 30 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    Write-Output "Response: $($R.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}

# Also try on /api/v2/device/auth path
Write-Output "`n=== POST /api/v2/device/auth ==="
try {
    $R2 = Invoke-WebRequest -Uri "$Base/api/v2/device/auth" -Method POST -Body $Body -Headers $Headers -TimeoutSec 30 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R2.StatusCode)"
    Write-Output "Response: $($R2.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}

# Also try on /api/v2/device without trailing slash
Write-Output "`n=== POST /api/v2/device ==="
try {
    $R3 = Invoke-WebRequest -Uri "$Base/api/v2/device" -Method POST -Body $Body -Headers $Headers -TimeoutSec 30 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R3.StatusCode)"
    Write-Output "Response: $($R3.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}
