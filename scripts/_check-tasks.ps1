$C = Get-Content 'C:\work\prtask.com\publish\web\wwwroot\Tasks.html' -Raw
$patterns = @('PRERENDERING-BEGIN', 'PRERENDERING-END', 'HEADOUTLET', '127.0.0.1', '__internal_preventDefault')
foreach ($p in $patterns) {
    $idx = $C.IndexOf($p)
    if ($idx -ge 0) {
        $start = [Math]::Max(0, $idx - 40)
        $len = [Math]::Min(120, $C.Length - $start)
        Write-Output "FOUND '$p' at index $idx"
        Write-Output "  Context: ...$($C.Substring($start, $len))..."
    } else {
        Write-Output "NOT_FOUND '$p'"
    }
}
