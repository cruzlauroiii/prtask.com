$Base = 'https://mobilecashier.ru'
# JWT captured from OkHttp logcat
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'

Write-Output "=== POST /api/v2/device/ with JWT ==="
try {
    $Body = '{"device_id":"e14ceab085867eab"}'
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/" -Method POST -Body $Body -ContentType 'application/json' -Headers @{ 'Authorization' = "Bearer $Jwt" } -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    Write-Output "Body: $($R.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}

Write-Output "`n=== GET /api/v2/market/ with JWT ==="
try {
    $R = Invoke-WebRequest -Uri "$Base/api/v2/market/" -Method GET -Headers @{ 'Authorization' = "Bearer $Jwt" } -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "Status: $($R.StatusCode)"
    Write-Output "Body: $($R.Content)"
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}
