$Base = 'https://mobilecashier.ru'
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'
$Headers = @{ 'Authorization' = "Bearer $Jwt"; 'Content-Type' = 'application/json' }

$Paths = @(
    'POST /api/v2/device/auth',
    'POST /api/v2/device/register',
    'POST /api/v2/device/info',
    'GET /api/v2/device/info',
    'POST /api/v2/market/order',
    'POST /api/v2/market/transaction',
    'POST /api/v2/market/payment',
    'POST /api/v2/market/authorize',
    'GET /api/v2/market/order',
    'GET /api/v1/device/',
    'GET /api/v1/market/',
    'GET /api/v3/device/',
    'GET /api/v3/market/',
    'GET /mobile-cashier/device/info',
    'POST /mobile-cashier/device/info'
)

foreach ($P in $Paths) {
    $Parts = $P.Split(' ', 2)
    $Method = $Parts[0]
    $Path = $Parts[1]
    try {
        if ($Method -eq 'POST') {
            $R = Invoke-WebRequest -Uri "$Base$Path" -Method POST -Body '{}' -Headers $Headers -TimeoutSec 5 -UseBasicParsing -SkipHttpErrorCheck
        } else {
            $R = Invoke-WebRequest -Uri "$Base$Path" -Method GET -Headers $Headers -TimeoutSec 5 -UseBasicParsing -SkipHttpErrorCheck
        }
        Write-Output "$Method $Path : $($R.StatusCode)"
        if ($R.StatusCode -ne 404) {
            $Content = $R.Content
            if ($Content.Length -gt 200) { $Content = $Content.Substring(0, 200) }
            Write-Output "  Body: $Content"
        }
    } catch {
        Write-Output "$Method $Path : ERROR $($_.Exception.Message)"
    }
}
