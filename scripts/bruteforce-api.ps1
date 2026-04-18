$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w'
$Body = '{"userId":"34c9c05b-4de8-4edf-9bfa-0efdb09d8a94","deviceUuid":"a29e8f74-e57b-46cf-80a9-a5dff92f49a2","mid":"177397344332991","tid":"SFT07056"}'
$Headers = @{
    'Authorization' = "Bearer $Jwt"
    'Content-Type' = 'application/json'
    'AndroidId' = 'e14ceab085867eab'
    'x-merchant-api-key' = '75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5'
}

$Bases = @('https://mobilecashier.ru')
$Paths = @(
    '/api/v2/device/authDevice',
    '/api/v2/device/auth/device',
    '/api/v2/device/token',
    '/api/v2/device/activate',
    '/api/v2/device/session',
    '/api/v2/device/login',
    '/api/v3/device/',
    '/api/v3/device/auth',
    '/api/v3/device/authDevice',
    '/api/v3/device/token',
    '/api/v3/device/register',
    '/api/v3/device/activate',
    '/api/v3/market/order',
    '/api/v3/market/payment',
    '/api/v3/market/transaction',
    '/api/v3/market/auth',
    '/mobile-cashier/api/v2/device/',
    '/mobile-cashier/device/',
    '/mobile-cashier/device/auth',
    '/toph/api/v2/device/',
    '/toph/device/auth',
    '/api/v2/toph/device/',
    '/api/v2/toph/auth'
)

foreach ($P in $Paths) {
    try {
        $R = Invoke-WebRequest -Uri "https://mobilecashier.ru$P" -Method POST -Body $Body -Headers $Headers -TimeoutSec 5 -UseBasicParsing -SkipHttpErrorCheck
        $Status = $R.StatusCode
        if ($Status -ne 404) {
            $C = $R.Content
            if ($C.Length -gt 150) { $C = $C.Substring(0, 150) }
            Write-Output "POST $P : $Status $C"
        }
    } catch {
        Write-Output "POST $P : TIMEOUT"
    }
}
