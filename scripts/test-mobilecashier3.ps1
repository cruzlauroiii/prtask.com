$Base = 'https://mobilecashier.ru'
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDY2MDAyMywicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.RfaniJFxmY0hhcoU-pGOz2OkfdAemAVFLLSbCTUptuAWDpnhABoBa0aDfFgTU5KVbJBk2Jck23nYtZoiQD_D-w'
$DeviceId = 'e14ceab085867eab'
$PasswordHash = '75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5'
$Login = '639568564236'
$DeviceToken = 'b84a6501-c81e-4e95-a148-77b12670102b'

# Try each value as x-merchant-api-key
$Keys = @(
    @{ Name = 'password hash'; Value = $PasswordHash },
    @{ Name = 'login/phone'; Value = $Login },
    @{ Name = 'device token'; Value = $DeviceToken },
    @{ Name = 'android_id'; Value = $DeviceId },
    @{ Name = 'JWT sub'; Value = '639568564236' }
)

foreach ($K in $Keys) {
    $Headers = @{
        'Authorization' = "Bearer $Jwt"
        'x-merchant-api-key' = $K.Value
        'AndroidId' = $DeviceId
        'Content-Type' = 'application/json'
    }
    $R = Invoke-WebRequest -Uri "$Base/api/v2/device/info" -Method GET -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
    Write-Output "$($K.Name): $($R.StatusCode) $($R.Content.Substring(0, [Math]::Min(100, $R.Content.Length)))"
}
