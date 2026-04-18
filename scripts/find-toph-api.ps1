$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match 'provideToph|TophOrder|TophAuth|TophDevice|OrderApi|DeviceApi|toph.*api|api.*toph|request_body|response_body|merchant.*key|api.*key|integration.*key|registry.*key' -and $L -notmatch 'Binary') {
        $T = $L.Trim()
        if ($T.Length -gt 200) { $T = $T.Substring(0, 200) }
        if ($T.Length -gt 0) { Write-Output $T }
    }
}
