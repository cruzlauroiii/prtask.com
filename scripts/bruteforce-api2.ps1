$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w'
$Headers = @{
    'Authorization' = "Bearer $Jwt"
    'AndroidId' = 'e14ceab085867eab'
    'x-merchant-api-key' = '75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5'
}

$UserId = '34c9c05b-4de8-4edf-9bfa-0efdb09d8a94'
$DeviceUuid = 'a29e8f74-e57b-46cf-80a9-a5dff92f49a2'
$Mid = '177397344332991'
$Tid = 'SFT07056'

$Queries = @(
    "/api/v2/device/info?userId=$UserId&deviceUuid=$DeviceUuid&mid=$Mid&tid=$Tid",
    "/api/v2/device/info?userId=$UserId&deviceUuid=$DeviceUuid",
    "/api/v2/device/info?mid=$Mid&tid=$Tid",
    "/api/v2/device/info?userId=$UserId&mid=$Mid&tid=$Tid",
    "/api/v2/device/auth?userId=$UserId&deviceUuid=$DeviceUuid&mid=$Mid&tid=$Tid",
    "/api/v2/device/token?userId=$UserId&deviceUuid=$DeviceUuid&mid=$Mid&tid=$Tid",
    "/api/v3/market/order?userId=$UserId&mid=$Mid&tid=$Tid"
)

foreach ($Q in $Queries) {
    try {
        $R = Invoke-WebRequest -Uri "https://mobilecashier.ru$Q" -Method GET -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
        $C = $R.Content
        if ($C.Length -gt 200) { $C = $C.Substring(0, 200) }
        Write-Output "GET $($Q.Split('?')[0]) : $($R.StatusCode) $C"
    } catch {
        Write-Output "GET $($Q.Split('?')[0]) : TIMEOUT"
    }
}
