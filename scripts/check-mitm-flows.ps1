$Content = Get-Content 'C:\work\prtask.com\mitmproxy-flows.txt' -Raw
Write-Output "Total size: $($Content.Length) bytes"
Write-Output ""

# Search for merchant key
if ($Content -match 'x-merchant-api-key') {
    Write-Output "=== FOUND x-merchant-api-key ==="
    $Lines = $Content -split "`n"
    foreach ($L in $Lines) {
        if ($L -match 'x-merchant-api-key') {
            Write-Output $L.Trim()
        }
    }
} else {
    Write-Output "x-merchant-api-key NOT found yet"
}

# Search for mobilecashier
if ($Content -match 'mobilecashier') {
    Write-Output "`n=== FOUND mobilecashier ==="
    $Lines = $Content -split "`n"
    foreach ($L in $Lines) {
        if ($L -match 'mobilecashier') {
            Write-Output $L.Trim()
        }
    }
} else {
    Write-Output "mobilecashier NOT found yet"
}

# Show all unique hosts
Write-Output "`n=== Captured hosts ==="
$Lines = $Content -split "`n"
foreach ($L in $Lines) {
    if ($L -match '^\s*(GET|POST|PUT|DELETE|PATCH|HEAD)\s+https?://') {
        $T = $L.Trim()
        if ($T.Length -gt 120) { $T = $T.Substring(0, 120) }
        Write-Output $T
    }
}
