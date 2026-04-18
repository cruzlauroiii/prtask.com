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

Get-ChildItem $DeployDir -Recurse -Include '*.js' | Where-Object {
    -not ($_.FullName -match 'Framework') -and
    -not ($_.Name -eq 'service-worker-assets.js')
} | ForEach-Object {
    Write-Host "JS: $($_.Name)"
    & terser $_.FullName -o $_.FullName -c -m 2>&1 | Out-Null
}

Get-ChildItem $DeployDir -Recurse -Include '*.css' | ForEach-Object {
    Write-Host "CSS: $($_.Name)"
    & csso $_.FullName -o $_.FullName 2>&1 | Out-Null
}

Get-ChildItem "$DeployDir\*.html" | ForEach-Object {
    Write-Host "HTML: $($_.Name)"
    & html-minifier-terser --collapse-whitespace --remove-comments --minify-css true --minify-js true $_.FullName -o $_.FullName 2>&1 | Out-Null
}

Write-Host "Minification complete"
