$Lines = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match '8ab32d795ee04431') {
        Write-Output $L.Trim()
    }
}
