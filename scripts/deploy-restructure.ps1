$ErrorActionPreference = "Stop"

$SourceTreeRoot = "C:\work\prtask.com"
$DeployDir = "C:\work\prtask-deploy"
$PublishDir = "C:\work\prtask.com\publish\web\wwwroot"
$SourceTreeSentinelFile = "PrTask.sln"
$SourceTreeSentinelDir = "src"
$GitExcludeList = @(".git", ".gitattributes")
$CnameFileName = "CNAME"
$NoJekyllFileName = ".nojekyll"
$GitAttributesContent = "* -text"
$SwAssetsSrc = "C:\work\prtask.com\src\PrTask.Client\obj\Release\net10.0\service-worker\service-worker-assets.js.publish"

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
Write-Host "[1] Cleaned deploy dir"

[System.IO.File]::WriteAllText("$DeployDir\.gitattributes", $GitAttributesContent)
Write-Host "[2] .gitattributes"

Copy-Item "$PublishDir\*" $DeployDir -Recurse -Force
Write-Host "[3] Copied build output"

Get-ChildItem $DeployDir -Recurse -Include '*.br','*.gz' | Remove-Item -Force
$CnamePath = Join-Path $DeployDir $CnameFileName
if (Test-Path $CnamePath) { Remove-Item $CnamePath -Force }
Write-Host "[4] Removed .br/.gz/CNAME"

if (Test-Path "$DeployDir\_framework") {
    Rename-Item "$DeployDir\_framework" "$DeployDir\Framework" -Force
    Write-Host "[5] _framework -> Framework"
}

New-Item -ItemType Directory -Path "$DeployDir\Css" -Force | Out-Null
Copy-Item "$DeployDir\_content\PrTask.SharedUI\css\*" "$DeployDir\Css\" -Force
Write-Host "[6a] _content CSS -> Css/"

New-Item -ItemType Directory -Path "$DeployDir\Content" -Force | Out-Null
New-Item -ItemType Directory -Path "$DeployDir\Content\Js" -Force | Out-Null
Copy-Item "$DeployDir\_content\PrTask.SharedUI\js\*" "$DeployDir\Content\Js\" -Force
Write-Host "[6b] _content JS -> Content/Js/"

$BundleScp = Get-ChildItem "$DeployDir\_content\PrTask.SharedUI" -Filter "PrTask.SharedUI.*.bundle.scp.css" | Select-Object -First 1
if ($BundleScp) {
    Copy-Item $BundleScp.FullName "$DeployDir\Content\" -Force
    Write-Host "[6c] bundle.scp.css -> Content/"
}

Remove-Item "$DeployDir\_content" -Recurse -Force
Write-Host "[6d] Removed _content/"

foreach ($Pair in @(@{O='js';N='Js'}, @{O='data';N='Data'}, @{O='downloads';N='Downloads'})) {
    $OldPath = Join-Path $DeployDir $Pair.O
    if (Test-Path $OldPath) {
        $TmpPath = "${OldPath}_tmp"
        Rename-Item $OldPath $TmpPath -Force
        Rename-Item $TmpPath (Join-Path $DeployDir $Pair.N) -Force
        Write-Host "[7] $($Pair.O) -> $($Pair.N)"
    }
}

foreach ($F in @('manifest.json')) {
    $FilePath = Join-Path $DeployDir $F
    if (Test-Path $FilePath) { Remove-Item $FilePath -Force; Write-Host "[8] Deleted $F" }
}

New-Item -ItemType File -Path "$DeployDir\$NoJekyllFileName" -Force | Out-Null
Write-Host "[9] .nojekyll"

$BlazorFile = Get-ChildItem "$DeployDir\Framework" -Filter "blazor.webassembly*.js" | Where-Object { $_.Name -notmatch '\.(br|gz)$' -and $_.Name -ne 'blazor.webassembly.js' } | Select-Object -First 1
$Idx = [System.IO.File]::ReadAllText("$DeployDir\index.html")
if ($BlazorFile) {
    $Fingerprint = ($BlazorFile.Name -replace '^blazor\.webassembly\.','') -replace '\.js$',''
    $Idx = $Idx.Replace('blazor.webassembly.js', "blazor.webassembly.$Fingerprint.js")
    Write-Host "[10] Blazor fingerprint: $Fingerprint"
} else {
    $BlazorFile = Get-ChildItem "$DeployDir\Framework" -Filter "blazor.webassembly.js" | Select-Object -First 1
    Write-Host "[10] No fingerprint (using blazor.webassembly.js directly)"
}

$Idx = $Idx.Replace('_framework/', 'Framework/')
$Idx = $Idx.Replace('_content/PrTask.SharedUI/css/', 'Css/')
$Idx = $Idx.Replace('_content/PrTask.SharedUI/js/', 'Content/Js/')
$Idx = $Idx.Replace('_content/PrTask.SharedUI/', 'Content/')
$Idx = $Idx.Replace('src="js/', 'src="Js/')
$Idx = $Idx.Replace("src='js/", "src='Js/")
$Idx = $Idx.Replace('"data/', '"Data/')
$Idx = $Idx.Replace('"downloads/', '"Downloads/')
$Idx = $Idx.Replace('<link rel="manifest" href="manifest.json" />', '')
$Idx = $Idx.Replace('<link rel="manifest" href="manifest.json">', '')
$Idx = $Idx.Replace('<base href="/">', '<base href="/prtask.com/">')
$Idx = $Idx.Replace('<base href="/" />', '<base href="/prtask.com/" />')
$CssPreload = '<link rel="preload" href="_content/PrTask.SharedUI/css/app.min.css" as="style">'
$JsPreload1 = '<link rel="preload" href="Js/prtask-core.js" as="script">'
$JsPreload2 = '<link rel="preload" href="_framework/blazor.webassembly.js" as="script">'
$Idx = $Idx.Replace('<link rel="stylesheet" href="Css/app.min.css">', "$CssPreload$JsPreload1$JsPreload2" + '<link rel="stylesheet" href="Css/app.min.css">')
[System.IO.File]::WriteAllText("$DeployDir\index.html", $Idx)
Write-Host "[11] Fixed all refs in index.html (base href + preloads)"

$SwPub = [System.IO.File]::ReadAllText("$DeployDir\service-worker.published.js")
$SwPub = $SwPub.Replace('_framework/', 'Framework/')
$SwPub = $SwPub.Replace('_content/', 'Content/')
$SwPub = $SwPub.Replace("importScripts('service-worker-assets.js');", '')
Write-Host "[12] Fixed service-worker.published.js"

if ($BlazorFile -and $BlazorFile.FullName) {
    $BlazorContent = [System.IO.File]::ReadAllText($BlazorFile.FullName)
    $BlazorContent = $BlazorContent.Replace('_framework/', 'Framework/')
    [System.IO.File]::WriteAllText($BlazorFile.FullName, $BlazorContent)
    Write-Host "[14] Fixed refs in $($BlazorFile.Name)"
} else {
    Write-Host "[14] SKIP: blazor.webassembly.js not found"
}

$SwaContent = [System.IO.File]::ReadAllText($SwAssetsSrc)
$SwaContent = $SwaContent.Replace('_framework/', 'Framework/')
$SwaContent = $SwaContent.Replace('_content/PrTask.SharedUI/css/', 'Css/')
$SwaContent = $SwaContent.Replace('_content/PrTask.SharedUI/js/', 'Content/Js/')
$SwaContent = $SwaContent.Replace('_content/PrTask.SharedUI/', 'Content/')
$SwaContent = $SwaContent.Replace('"js/', '"Js/')
$SwaContent = $SwaContent.Replace('"data/', '"Data/')
$SwaContent = $SwaContent.Replace('"downloads/', '"Downloads/')
[System.IO.File]::WriteAllText("$DeployDir\service-worker-assets.js", $SwaContent)
Write-Host "[15] Created service-worker-assets.js with fixed paths"

Add-Type -AssemblyName System.Drawing
$Bmp = New-Object System.Drawing.Bitmap(192, 192)
$Graphics = [System.Drawing.Graphics]::FromImage($Bmp)
$Graphics.SmoothingMode = [System.Drawing.Drawing2D.SmoothingMode]::AntiAlias
$BgBrush = New-Object System.Drawing.SolidBrush([System.Drawing.Color]::FromArgb(255, 26, 26, 46))
$Graphics.FillRectangle($BgBrush, 0, 0, 192, 192)
$Font = New-Object System.Drawing.Font("Arial", 72, [System.Drawing.FontStyle]::Bold)
$TextBrush = New-Object System.Drawing.SolidBrush([System.Drawing.Color]::White)
$Sf = New-Object System.Drawing.StringFormat
$Sf.Alignment = [System.Drawing.StringAlignment]::Center
$Sf.LineAlignment = [System.Drawing.StringAlignment]::Center
$Rect = New-Object System.Drawing.RectangleF(0, 0, 192, 192)
$Graphics.DrawString("PR", $Font, $TextBrush, $Rect, $Sf)
$Graphics.Dispose()
$Bmp.Save("$DeployDir\icon-192.png", [System.Drawing.Imaging.ImageFormat]::Png)
$Bmp.Dispose()
Write-Host "[16] Created icon-192.png"

if (Test-Path "$DeployDir\_headers") { Remove-Item "$DeployDir\_headers" -Force; Write-Host "[16b] Deleted _headers" }

Write-Host ""
Write-Host "=== Structure ready ==="
Get-ChildItem $DeployDir -Exclude $GitExcludeList | ForEach-Object { Write-Host "  $($_.Name) $(if($_.PSIsContainer){'(dir)'})" }
