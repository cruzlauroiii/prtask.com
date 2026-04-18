$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match 'api.key|apikey|api_key|secret|client_id|client_secret|app_id|registry_key|integration_key|merchant_key' -and $L -notmatch 'Binary|getBinding|SharedPreference|x-merchant') {
        $T = $L.Trim()
        if ($T.Length -gt 200) { $T = $T.Substring(0, 200) }
        if ($T.Length -gt 0) { Write-Output $T }
    }
}
