$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match 'toph|Toph|TOPH|mobilecashier|order|device.*api|auth.*device|token|Bearer|Content-Type|application/json|receipt|payment|transaction|cashier|merchant|terminal|emv|cryptogram|arqc|stan|referen' -and $L -notmatch 'Binary|file match') {
        $T = $L.Trim()
        if ($T.Length -gt 200) { $T = $T.Substring(0, 200) }
        if ($T.Length -gt 0) { Write-Output $T }
    }
}
