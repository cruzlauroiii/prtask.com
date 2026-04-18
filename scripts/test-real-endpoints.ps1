$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w'
$Headers = @{
    'Authorization' = "Bearer $Jwt"
    'Content-Type' = 'application/json'
    'AndroidId' = 'e14ceab085867eab'
}
$AuthBody = '{"userId":"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94","deviceUuid":"a29e8f74-e57b-46cf-80a9-a5dff92f49a2","mid":"177397344332991","tid":"SFT07056"}'

Write-Output "=== POST /api/v2/device/status/toph (authDevice) ==="
$R = Invoke-WebRequest -Uri 'https://mobilecashier.ru/api/v2/device/status/toph' -Method POST -Body $AuthBody -Headers $Headers -TimeoutSec 15 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R.StatusCode)"
$C = $R.Content
if ($C.Length -gt 500) { $C = $C.Substring(0, 500) }
Write-Output "Body: $C"

Write-Output ""
Write-Output "=== POST /api/v2/device/order/toph (sendOrder) ==="
$OrderBody = '{"userId":"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94","phone":"639568564236","fio":"","inn":"","regionId":0}'
$R2 = Invoke-WebRequest -Uri 'https://mobilecashier.ru/api/v2/device/order/toph' -Method POST -Body $OrderBody -Headers $Headers -TimeoutSec 15 -UseBasicParsing -SkipHttpErrorCheck
Write-Output "Status: $($R2.StatusCode)"
$C2 = $R2.Content
if ($C2.Length -gt 500) { $C2 = $C2.Substring(0, 500) }
Write-Output "Body: $C2"
