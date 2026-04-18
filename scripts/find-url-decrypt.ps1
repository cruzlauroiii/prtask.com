$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match 'fe4e28c7b126') {
        Write-Output $L.Trim()
    }
}
