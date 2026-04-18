# Read mitmproxy captured flows via its API
try {
    $R = Invoke-WebRequest -Uri 'http://127.0.0.1:8889/flows' -TimeoutSec 5 -UseBasicParsing
    $Flows = $R.Content | ConvertFrom-Json
    Write-Output "Total flows: $($Flows.Count)"
    foreach ($F in $Flows) {
        $Url = $F.request.pretty_url
        $Method = $F.request.method
        Write-Output "$Method $Url"

        # Check for merchant key header
        foreach ($H in $F.request.headers) {
            if ($H[0] -match 'merchant|api-key|authorization') {
                Write-Output "  HEADER: $($H[0]): $($H[1])"
            }
        }
    }
} catch {
    Write-Output "Error: $($_.Exception.Message)"
}
