$ErrorActionPreference = "Stop"

$SourceTreeRoot = "C:\work\prtask.com"
$DeployDir = "C:\work\prtask-deploy"
$SourceTreeSentinelFile = "PrTask.sln"
$SourceTreeSentinelDir = "src"

if (Test-Path (Join-Path $DeployDir $SourceTreeSentinelFile)) {
    throw "SAFETY: refusing to delete source tree (found $SourceTreeSentinelFile in $DeployDir)"
}
if (Test-Path (Join-Path $DeployDir $SourceTreeSentinelDir)) {
    throw "SAFETY: refusing to delete source tree (found $SourceTreeSentinelDir in $DeployDir)"
}
$NormalizedDeploy = [System.IO.Path]::GetFullPath($DeployDir)
$NormalizedRoot = [System.IO.Path]::GetFullPath($SourceTreeRoot)
if ($NormalizedDeploy -eq $NormalizedRoot) {
    throw "SAFETY: refusing to operate on source tree root ($NormalizedDeploy)"
}

Write-Host "=== Content/ directory ==="
if (Test-Path "$DeployDir\Content") {
    Get-ChildItem "$DeployDir\Content" -Recurse -File | ForEach-Object {
        $Rel = $_.FullName.Replace("$DeployDir\Content\", "")
        Write-Host "  Content/$Rel"
    }
} else {
    Write-Host "  Content/ does NOT exist"
}

Write-Host ""
Write-Host "=== Js/ directory ==="
Get-ChildItem "$DeployDir\Js" -File | ForEach-Object { Write-Host "  Js/$($_.Name)" }

if (Test-Path "$DeployDir\_headers") {
    Remove-Item "$DeployDir\_headers" -Force
    Write-Host ""
    Write-Host "Removed _headers"
}

$Idx = [System.IO.File]::ReadAllText("$DeployDir\index.html")
$CmMatch = [regex]::Match($Idx, '[^"]*circuit-manager[^"]*')
Write-Host ""
Write-Host "index.html circuit-manager ref: $($CmMatch.Value)"

if (-not (Test-Path "$DeployDir\Content\Js")) {
    New-Item -ItemType Directory -Path "$DeployDir\Content\Js" -Force | Out-Null
}
Copy-Item "$DeployDir\Js\circuit-manager.js" "$DeployDir\Content\Js\circuit-manager.js" -Force
Copy-Item "$DeployDir\Js\circuit-manager.min.js" "$DeployDir\Content\Js\circuit-manager.min.js" -Force
Write-Host "Copied circuit-manager to Content/Js/"

$BundleScp = Get-ChildItem "$DeployDir\Css" -Filter "PrTask.SharedUI.*.bundle.scp.css" -ErrorAction SilentlyContinue | Select-Object -First 1
if ($BundleScp -and -not (Test-Path "$DeployDir\Content\$($BundleScp.Name)")) {
    Copy-Item $BundleScp.FullName "$DeployDir\Content\" -Force
    Write-Host "Copied bundle.scp.css to Content/"
}

Write-Host ""
Write-Host "=== Verify ==="
$Check = [System.IO.File]::ReadAllText("$DeployDir\index.html")
if ($Check.Contains('_framework/')) { Write-Host "BAD: _framework/" } else { Write-Host "OK: no _framework/" }
if ($Check.Contains('_content/')) { Write-Host "BAD: _content/" } else { Write-Host "OK: no _content/" }
if ($Check.Contains('manifest.json')) { Write-Host "BAD: manifest.json" } else { Write-Host "OK: no manifest.json" }
if (Test-Path "$DeployDir\manifest.json") { Write-Host "BAD: manifest.json file exists" } else { Write-Host "OK: no manifest.json file" }
if (Test-Path "$DeployDir\appsettings.json") { Write-Host "BAD: appsettings.json file exists" } else { Write-Host "OK: no appsettings.json file" }

Push-Location $DeployDir
try {
    git add -A
    $Status = git status --short
    if ($Status) {
        Write-Host ""
        Write-Host "=== Committing fixups ==="
        $Status | ForEach-Object { Write-Host "  $_" }
        git commit -m "Fix: add Content/Js/ circuit-manager, remove _headers"
        git push
    } else {
        Write-Host ""
        Write-Host "No changes to commit"
    }
}
finally {
    Pop-Location
}
