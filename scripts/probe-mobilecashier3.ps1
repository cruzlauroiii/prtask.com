$Base = 'https://mobilecashier.ru'
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'
$DeviceId = 'e14ceab085867eab'
$UserId = '34c9c05b-4de8-4edf-9bfa-0efdb09d8a94'
$StoreId = 'fc0f2f09-7b94-4140-b5f3-9fc589d7fa18'
$DeviceUuid = 'a29e8f74-e57b-46cf-80a9-a5dff92f49a2'

$BaseHeaders = @{
    'Authorization' = "Bearer $Jwt"
    'AndroidId' = $DeviceId
    'Content-Type' = 'application/json'
    'platform' = 'Android'
    'versionName' = '1.0.30'
    'versionCode' = '110304'
}

# Probe v3 market paths
$Paths = @(
    'GET /api/v3/market/order',
    'GET /api/v3/market/orders',
    'GET /api/v3/market/transaction',
    'GET /api/v3/market/device',
    'GET /api/v3/market/devices',
    'GET /api/v3/market/store',
    'GET /api/v3/market/stores',
    'GET /api/v3/market/payment',
    'POST /api/v3/market/order',
    'POST /api/v3/market/transaction',
    'POST /api/v3/market/payment',
    'POST /api/v3/market/device/register',
    'POST /api/v3/market/device/auth',
    "GET /api/v2/device/info?userId=$UserId&deviceId=$DeviceId",
    "GET /api/v2/device/info?userId=$UserId",
    "GET /api/v2/device/info?deviceId=$DeviceId"
)

foreach ($P in $Paths) {
    $Parts = $P.Split(' ', 2)
    $Method = $Parts[0]
    $Path = $Parts[1]
    try {
        if ($Method -eq 'POST') {
            $R = Invoke-WebRequest -Uri "$Base$Path" -Method POST -Body '{}' -Headers $BaseHeaders -TimeoutSec 5 -UseBasicParsing -SkipHttpErrorCheck
        } else {
            $R = Invoke-WebRequest -Uri "$Base$Path" -Method GET -Headers $BaseHeaders -TimeoutSec 5 -UseBasicParsing -SkipHttpErrorCheck
        }
        $Status = $R.StatusCode
        if ($Status -ne 404) {
            $Content = $R.Content
            if ($Content.Length -gt 300) { $Content = $Content.Substring(0, 300) }
            Write-Output "$Method $Path : $Status"
            Write-Output "  $Content"
        }
    } catch {
        Write-Output "$Method $Path : ERROR"
    }
}
