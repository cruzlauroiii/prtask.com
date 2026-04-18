$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match 'https?://' -or $L -match 'mobilecashier' -or $L -match 'psr-it' -or $L -match 'gateway' -or $L -match 'acquir' -or $L -match 'authorize' -or $L -match 'terminal.*url') {
        $T = $L.Trim()
        if ($T.Length -gt 150) { $T = $T.Substring(0, 150) }
        Write-Output $T
    }
}
