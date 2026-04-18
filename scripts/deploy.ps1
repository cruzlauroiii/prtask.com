param()

$ErrorActionPreference = "Stop"

$SourceTreeRoot = "C:\work\prtask.com"
$DeployDir = "C:\work\prtask-deploy"
$PublishDir = "C:\work\prtask.com\publish\web\wwwroot"
$SourceTreeSentinelFile = "PrTask.sln"
$SourceTreeSentinelDir = "src"
$GitExcludeList = @(".git", ".gitattributes")
$CnameFileName = "CNAME"
$NoJekyllFileName = ".nojekyll"

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

Write-Host "Removing old content..."
Get-ChildItem $DeployDir -Exclude $GitExcludeList | Remove-Item -Recurse -Force

Write-Host "Copying new content..."
Copy-Item "$PublishDir\*" $DeployDir -Recurse -Force

Write-Host "Adding .nojekyll..."
New-Item -ItemType File -Path "$DeployDir\$NoJekyllFileName" -Force | Out-Null

Write-Host "Removing CNAME if present..."
$CnamePath = Join-Path $DeployDir $CnameFileName
if (Test-Path $CnamePath) { Remove-Item $CnamePath -Force }

Write-Host "Copying index.html to 404.html..."
Copy-Item "$DeployDir\index.html" "$DeployDir\404.html" -Force

Write-Host "Staging changes..."
Push-Location $DeployDir
try {
    git add -A

    Write-Host "Committing..."
    git commit -m "Deploy: minified frontend assets (JS/CSS/HTML/SW)"

    Write-Host "Pushing..."
    git push 2>&1
}
finally {
    Pop-Location
}

Write-Host "Done!"
