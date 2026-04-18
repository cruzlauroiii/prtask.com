$d = "C:\work\prtask-deploy"
$idx = [System.IO.File]::ReadAllText("$d\index.html")

Write-Host "=== Reference checks ==="
# Check for bad old paths
$bad = @('_framework/', '_content/', 'src="js/', '"data/', '"downloads/', 'manifest.json', '#[.{fingerprint}]')
foreach ($b in $bad) {
    if ($idx.Contains($b)) { Write-Host "BAD: still has '$b'" }
}

# Check for good new paths
$good = @('Framework/blazor.webassembly.66stpp682q.js', 'Css/app.min.css', 'src="Js/', 'Content/Js/circuit-manager')
foreach ($g in $good) {
    if ($idx.Contains($g)) { Write-Host "OK:  has '$g'" } else { Write-Host "MISSING: '$g'" }
}

# Show all src= and href= references
Write-Host ""
Write-Host "=== All src/href refs ==="
$refs = [regex]::Matches($idx, '(?:src|href)="[^"]*"')
foreach ($r in $refs) { Write-Host "  $($r.Value)" }
