$Base = 'https://mobilecashier.ru'
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'
$DeviceId = 'e14ceab085867eab'
$UserId = '34c9c05b-4de8-4edf-9bfa-0efdb09d8a94'
$AndroidId = $DeviceId

$Headers = @{ 'Authorization' = "Bearer $Jwt" }

Write-Output "=== /api/v2/device/info with query params ==="
$Url = "$Base/api/v2/device/info?deviceId=$DeviceId&userId=$UserId"
$R = Invoke-WebRequest -Uri $Url -Method GET -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R.StatusCode)"
Write-Output "Body: $($R.Content)"

Write-Output "`n=== /api/v3/market/ with AndroidId header ==="
$Headers2 = @{ 'Authorization' = "Bearer $Jwt"; 'AndroidId' = $AndroidId }
$R2 = Invoke-WebRequest -Uri "$Base/api/v3/market/" -Method GET -Headers $Headers2 -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R2.StatusCode)"
Write-Output "Body: $($R2.Content)"

Write-Output "`n=== /api/v2/device/info with AndroidId header ==="
$Headers3 = @{ 'Authorization' = "Bearer $Jwt"; 'AndroidId' = $AndroidId }
$R3 = Invoke-WebRequest -Uri "$Base/api/v2/device/info" -Method GET -Headers $Headers3 -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R3.StatusCode)"
Write-Output "Body: $($R3.Content)"
