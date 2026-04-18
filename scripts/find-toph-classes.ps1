$Lines = Get-Content 'C:\work\prtask.com\docs\pocketpay-softpos-decompiled.md' -Encoding UTF8
foreach ($L in $Lines) {
    if ($L -match 'toph|order.*api|device.*api|mobilecashier|merchant.*api|integration.*registry') {
        $T = $L.Trim()
        if ($T.Length -gt 200) { $T = $T.Substring(0, 200) }
        if ($T.Length -gt 0) { Write-Output $T }
    }
}
Write-Output "---"
Write-Output "Searching decryptstring-reversed.md for class names..."
$Lines2 = Get-Content 'C:\work\prtask.com\docs\decryptstring-reversed.md' -Encoding UTF8
foreach ($L in $Lines2) {
    if ($L -match '### .*(toph|order|device.*api|mobilecashier)') {
        Write-Output $L.Trim()
    }
}
