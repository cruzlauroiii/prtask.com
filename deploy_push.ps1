$ErrorActionPreference = "Continue"

$SourceTreeRoot = "C:\work\prtask.com"
$DeployDir = "C:\work\prtask-deploy"
$PublishDir = "C:\work\prtask.com\publish\web\wwwroot"
$SourceTreeSentinelFile = "PrTask.sln"
$SourceTreeSentinelDir = "src"
$GitExcludeList = @(".git", ".gitattributes")

Remove-Item $DeployDir -Recurse -Force -ErrorAction SilentlyContinue
git clone https://github.com/cruzlauroiii/prtask.com.git $DeployDir --branch Public --depth 1

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

Get-ChildItem $DeployDir -Exclude $GitExcludeList | Remove-Item -Recurse -Force
Copy-Item "$PublishDir\*" "$DeployDir\" -Recurse -Force

Push-Location $DeployDir
try {
    git add -A
    git commit -m "Fix: remove Loading placeholder, show real pre-rendered content"
    git push
}
finally {
    Pop-Location
}
