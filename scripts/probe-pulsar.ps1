$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'
$UserId = '34c9c05b-4de8-4edf-9bfa-0efdb09d8a94'
$DeviceId = 'e14ceab085867eab'
$StoreId = 'fc0f2f09-7b94-4140-b5f3-9fc589d7fa18'

$Headers = @{
    'Authorization' = "Bearer $Jwt"
    'platform' = 'Android'
    'versionName' = '1.0.30'
    'versionCode' = '110304'
}

# These are endpoints we know work from OkHttp captures
$Paths = @(
    "GET https://pulsar.psr-it.com/mobile-cashier/device/info?userId=$UserId&deviceId=$DeviceId",
    "GET https://pulsar.psr-it.com/api/v2/market/user/$UserId/stores?userRole=BUSINESS",
    "GET https://pulsar.psr-it.com/api/v2/market/user/$UserId/devices",
    "GET https://pulsar.psr-it.com/api/v2/market/user/$UserId/roles/bfe4b768-e13f-4069-9cbb-4662ab4b4d38"
)

foreach ($P in $Paths) {
    $Parts = $P.Split(' ', 2)
    $Method = $Parts[0]
    $Url = $Parts[1]
    try {
        $R = Invoke-WebRequest -Uri $Url -Method $Method -Headers $Headers -TimeoutSec 10 -UseBasicParsing -SkipHttpErrorCheck
        $Content = $R.Content
        if ($Content.Length -gt 500) { $Content = $Content.Substring(0, 500) }
        Write-Output "$Method $(($Url -split '\?')[0]) : $($R.StatusCode)"
        Write-Output "  $Content"
        Write-Output ""
    } catch {
        Write-Output "$Method $Url : ERROR $($_.Exception.Message)"
    }
}
