# Search ALL decrypted strings for anything that looks like an API key
# API keys are typically 32-64 chars, alphanumeric with dashes
$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
$KeyPattern = '^[A-Za-z0-9\-_]{20,64}$'

Write-Output "=== Searching for API key-like strings ==="
foreach ($L in $Lines) {
    # Look for decrypted values in table rows
    if ($L -match '\| `([^`]+)` \|$') {
        $Val = $Matches[1]
        if ($Val -match $KeyPattern -and $Val -notmatch 'TRANSACTION|PAYMENT|MERCHANT|AMOUNT|ERROR|emv\.|paymentsystem|getBinding|settings|receipt|toph|expand|AElig') {
            Write-Output "Possible key: $Val"
        }
    }
}

Write-Output "`n=== Searching for BuildConfig fields ==="
foreach ($L in $Lines) {
    if ($L -match 'BuildConfig\.' -and $L -notmatch 'chauthai|com\.d\.c') {
        $T = $L.Trim()
        if ($T.Length -gt 0) { Write-Output $T }
    }
}
