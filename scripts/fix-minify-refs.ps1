param()

$indexPath = 'C:\work\prtask.com\publish\web\wwwroot\index.html'
$html = [System.IO.File]::ReadAllText($indexPath)

Write-Host "Original size: $($html.Length) bytes"

# Replace JS references with minified versions
$html = $html.Replace('src="js/opfs-store.js"', 'src="js/opfs-store.min.js"')
$html = $html.Replace('src="js/git-sync.js"', 'src="js/git-sync.min.js"')
$html = $html.Replace('src="js/indexeddb-sync.js"', 'src="js/indexeddb-sync.min.js"')
$html = $html.Replace('src="js/sw-update.js"', 'src="js/sw-update.min.js"')
$html = $html.Replace('src="_content/PrTask.SharedUI/js/circuit-manager.js"', 'src="_content/PrTask.SharedUI/js/circuit-manager.min.js"')

[System.IO.File]::WriteAllText($indexPath, $html)

Write-Host "Updated size: $($html.Length) bytes"

# Verify
if ($html.Contains('opfs-store.min.js')) { Write-Host 'OK: opfs-store.min.js' }
if ($html.Contains('git-sync.min.js')) { Write-Host 'OK: git-sync.min.js' }
if ($html.Contains('indexeddb-sync.min.js')) { Write-Host 'OK: indexeddb-sync.min.js' }
if ($html.Contains('sw-update.min.js')) { Write-Host 'OK: sw-update.min.js' }
if ($html.Contains('circuit-manager.min.js')) { Write-Host 'OK: circuit-manager.min.js' }

# Check for any remaining unminified JS refs (excluding framework)
if ($html.Contains('opfs-store.js"') -and -not $html.Contains('opfs-store.min.js')) { Write-Host 'WARN: still has unminified opfs-store.js' }
