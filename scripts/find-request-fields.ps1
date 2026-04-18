$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match 'device_id|device_uuid|deviceId|deviceImei|device_token|device_name|device_model|os_version|app_version|merchant_id|terminal_id|terminalId|merchantId|stan|auth_code|authCode|reference_number|referenceNumber|response_code|responseCode|card_number|pan|track2|expiry|emv_data|icc_data|cryptogram|arqc|amount|currency|transaction_type|payment_type|topRefUuid' -and $L -notmatch 'Binary|getBinding') {
        $T = $L.Trim()
        if ($T.Length -gt 150) { $T = $T.Substring(0, 150) }
        if ($T.Length -gt 0) { Write-Output $T }
    }
}
