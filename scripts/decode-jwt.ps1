# Decode JWT to check expiry
$Jwt = 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJzZWN1cmUtYXBpIiwiYXVkIjoic2VjdXJlLWFwcCIsInN1YiI6IjYzOTU2ODU2NDIzNiIsImV4cCI6MTc3NDYyMTgzNCwicm9sIjpbeyJhdXRob3JpdHkiOiJLQVNTIn1dfQ.T8aUNGBNIxXMwlXJX0Q3oRg7V4JyxuYMpGBUetnyWVSQBJvI2zSCC6CrcEXf8sUo52I__Y-S1XiW5yI5lPqQEA'

$Parts = $Jwt.Split('.')
$Payload = $Parts[1]
# Fix base64url padding
$Payload = $Payload.Replace('-', '+').Replace('_', '/')
switch ($Payload.Length % 4) {
    2 { $Payload += '==' }
    3 { $Payload += '=' }
}
$Json = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($Payload))
Write-Output "JWT Payload: $Json"

$Obj = $Json | ConvertFrom-Json
$Exp = [DateTimeOffset]::FromUnixTimeSeconds($Obj.exp)
$Now = [DateTimeOffset]::UtcNow
Write-Output "Expires: $Exp UTC"
Write-Output "Now: $Now UTC"
Write-Output "Expired: $($Now -gt $Exp)"
Write-Output "Hours ago: $(($Now - $Exp).TotalHours.ToString('F1'))"
