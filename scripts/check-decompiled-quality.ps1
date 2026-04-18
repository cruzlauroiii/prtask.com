$Files = Get-ChildItem 'C:\work\prtask.com\src\PocketPay.Wasm\Decompiled' -Recurse -Filter '*.cs'
$TotalFiles = $Files.Count
$WithBodies = 0
$StubOnly = 0

foreach ($F in $Files | Get-Random -Count 20) {
    $Content = Get-Content $F.FullName -Raw
    if ($Content -match 'return default!;' -and $Content -notmatch '\{[^}]*[a-zA-Z]+\s*=[^}]*\}') {
        $StubOnly++
    } else {
        $WithBodies++
    }
}

Write-Output "Total C# files: $TotalFiles"
Write-Output "Sample: $WithBodies with real bodies, $StubOnly stubs (out of 20 sampled)"

# Show a real file
$RealFile = $Files | Where-Object { $_.Length -gt 3000 -and $_.Name -match 'Receipt|Payment|Sell' } | Select-Object -First 1
if ($RealFile) {
    Write-Output "`n=== $($RealFile.Name) ($($RealFile.Length) bytes) ==="
    Get-Content $RealFile.FullName -TotalCount 30
}
