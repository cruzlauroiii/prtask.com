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

$Idx = "$DeployDir\index.html"

Copy-Item $Idx "$DeployDir\404.html" -Force
Write-Host "Created 404.html"

$Pages = @('Dashboard', 'Tasks', 'Settings', 'Login', 'Leaderboard', 'HowItWorks', 'Pricing', 'About', 'Download', 'Sprints', 'Boards')
foreach ($P in $Pages) {
    Copy-Item $Idx "$DeployDir\$P.html" -Force
    Write-Host "Created $P.html"
}

New-Item -ItemType Directory -Path "$DeployDir\Legal" -Force | Out-Null
$LegalPages = @('Terms', 'Privacy', 'CookiePolicy', 'AcceptableUse', 'Refund', 'Licenses', 'Accessibility', 'Dmca')
foreach ($P in $LegalPages) {
    Copy-Item $Idx "$DeployDir\Legal\$P.html" -Force
    Write-Host "Created Legal/$P.html"
}

New-Item -ItemType Directory -Path "$DeployDir\Tasks" -Force | Out-Null
Copy-Item $Idx "$DeployDir\Tasks\index.html" -Force
Write-Host "Created Tasks/index.html"

New-Item -ItemType Directory -Path "$DeployDir\Users" -Force | Out-Null
Copy-Item $Idx "$DeployDir\Users\index.html" -Force
Write-Host "Created Users/index.html"

Write-Host ""
Write-Host "=== SEO pages done ==="

$SwaPath = "$DeployDir\service-worker-assets.js"
$SwaContent = [System.IO.File]::ReadAllText($SwaPath)
$StartIdx = $SwaContent.IndexOf('{')
$Json = $SwaContent.Substring($StartIdx).TrimEnd(';', ' ', "`r", "`n")
$Manifest = ConvertFrom-Json $Json

$Sha256 = [System.Security.Cryptography.SHA256]::Create()
$Updated = 0

foreach ($Asset in $Manifest.assets) {
    $FilePath = Join-Path $DeployDir $Asset.url
    if (Test-Path $FilePath) {
        $FileBytes = [System.IO.File]::ReadAllBytes($FilePath)
        $Hash = $Sha256.ComputeHash($FileBytes)
        $B64 = [Convert]::ToBase64String($Hash)
        $Actual = "sha256-$B64"
        if ($Actual -ne $Asset.hash) {
            $Asset.hash = $Actual
            $Updated++
        }
    } else {
        Write-Host "WARNING: missing asset: $($Asset.url)"
    }
}

$NewJson = ConvertTo-Json $Manifest -Depth 10
[System.IO.File]::WriteAllText($SwaPath, "self.assetsManifest = $NewJson;")
Write-Host "Updated $Updated SRI hashes"

$AllHtml = Get-ChildItem $DeployDir -Recurse -Include '*.html'
$AllJs = Get-ChildItem $DeployDir -Recurse -Include '*.js' | Where-Object { $_.Name -ne 'service-worker-assets.js' -and -not ($_.FullName -match 'Framework') }
$Problems = 0
foreach ($F in ($AllHtml + $AllJs)) {
    $C = [System.IO.File]::ReadAllText($F.FullName)
    if ($C.Contains('_framework/')) { Write-Host "STALE _framework/ in $($F.Name)"; $Problems++ }
    if ($C.Contains('_content/')) { Write-Host "STALE _content/ in $($F.Name)"; $Problems++ }
}
if ($Problems -eq 0) { Write-Host "No stale references found" }

Write-Host ""
Write-Host "=== Git commit and push ==="
Push-Location $DeployDir
try {
    git add -A
    $Status = git status --short
    Write-Host "$($Status.Count) files changed"
    git commit -m "Deploy: restructured paths (Framework/, Css/, Content/, Js/), SEO route pages, minified, SRI fixed"
    git push
}
finally {
    Pop-Location
}

Write-Host ""
Write-Host "=== Final structure ==="
Get-ChildItem $DeployDir -Exclude '.git','.gitattributes' | ForEach-Object {
    if ($_.PSIsContainer) {
        Write-Host "  $($_.Name)/"
        Get-ChildItem $_.FullName -File | ForEach-Object { Write-Host "    $($_.Name)" }
    } else {
        Write-Host "  $($_.Name)"
    }
}
