$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w'
$Headers = @{
    'Authorization' = "Bearer $Jwt"
    'Content-Type' = 'application/json'
    'AndroidId' = 'e14ceab085867eab'
}
$Body = '{"user_id":"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94","phone":"639568564236","fio":"","inn":"","region_id":0}'

Write-Output "=== mobilecashier.ru/api/v2/device/order/toph ==="
$R = Invoke-WebRequest -Uri 'https://mobilecashier.ru/api/v2/device/order/toph' -Method POST -Body $Body -Headers $Headers -TimeoutSec 15 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R.StatusCode)"
Write-Output "Body: $($R.Content)"

Write-Output ""
Write-Output "=== mobilecashier.ru/api/v2/market/order/toph ==="
$R2 = Invoke-WebRequest -Uri 'https://mobilecashier.ru/api/v2/market/order/toph' -Method POST -Body $Body -Headers $Headers -TimeoutSec 15 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R2.StatusCode)"
Write-Output "Body: $($R2.Content)"

Write-Output ""
Write-Output "=== mobilecashier.ru/api/v3/market/order/toph ==="
$R3 = Invoke-WebRequest -Uri 'https://mobilecashier.ru/api/v3/market/order/toph' -Method POST -Body $Body -Headers $Headers -TimeoutSec 15 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R3.StatusCode)"
Write-Output "Body: $($R3.Content)"
