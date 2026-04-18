param(
    [string]$PublishDir = "publish-output",
    [string]$BaseHref = "/"
)

$ErrorActionPreference = "Stop"
$WwwRoot = Join-Path $PublishDir "wwwroot"
$EndpointsFile = Join-Path $PublishDir "PrTask.Client.staticwebassets.endpoints.json"

if (-not (Test-Path $EndpointsFile)) {
    Write-Error "Endpoints file not found: $EndpointsFile"
    exit 1
}

$Json = Get-Content $EndpointsFile -Raw | ConvertFrom-Json
$Endpoints = $Json.Endpoints

$HtmlMap = @{}
foreach ($Ep in $Endpoints) {
    if ($Ep.Route -eq $Ep.AssetFile) { continue }
    if ($Ep.Route -match '\.(gz|br)$') { continue }
    if ($Ep.Route -match '\.html$') {
        $HtmlMap[$Ep.AssetFile] = $Ep.Route
    }
}

Write-Host "Found $($HtmlMap.Count) fingerprinted HTML mappings from endpoints"

$LangCodes = @("zh","es","ja","de","fr","pt","hi","ko","it","ru","id","nl","tr","ar")
$LangHtmlCount = 0
foreach ($LangCode in $LangCodes) {
    $LangDir = Join-Path $WwwRoot $LangCode
    if (-not (Test-Path $LangDir)) { continue }
    $LangFiles = Get-ChildItem $LangDir -Recurse -Filter "*.html"
    foreach ($LangFile in $LangFiles) {
        $RelPath = $LangFile.FullName.Substring($WwwRoot.Length + 1).Replace("\", "/")
        if ($HtmlMap.ContainsKey($RelPath)) { continue }
        $Sha = [System.Security.Cryptography.SHA256]::Create()
        $FileBytes = [System.IO.File]::ReadAllBytes($LangFile.FullName)
        $HashBytes = $Sha.ComputeHash($FileBytes)
        $Sha.Dispose()
        $HashStr = [Convert]::ToBase64String($HashBytes).Substring(0, 10).ToLowerInvariant() -replace '[^a-z0-9]', ''
        $BaseName = [System.IO.Path]::GetFileNameWithoutExtension($RelPath)
        $DirPart = [System.IO.Path]::GetDirectoryName($RelPath).Replace("\", "/")
        $FingerprintedName = if ($DirPart) { "$DirPart/$BaseName.$HashStr.html" } else { "$BaseName.$HashStr.html" }
        $HtmlMap[$RelPath] = $FingerprintedName
        $LangHtmlCount++
    }
}

Write-Host "Found $LangHtmlCount language HTML files to fingerprint"

$RouteToFingerprint = @{}
foreach ($Pair in $HtmlMap.GetEnumerator()) {
    $CleanName = $Pair.Key -replace '\.html$', ''
    $RouteToFingerprint[$CleanName] = $Pair.Value
}

function Rewrite-Links {
    param([string]$Html, [hashtable]$Map)
    $Result = $Html
    foreach ($Pair in $Map.GetEnumerator()) {
        $Clean = $Pair.Key
        $Fingerprinted = $Pair.Value
        $EscClean = [regex]::Escape($Clean)
        $Result = $Result -replace "href=""$EscClean""", "href=""$Fingerprinted"""
        $Result = $Result -replace "href=""/$EscClean""", "href=""$Fingerprinted"""
        $Result = $Result -replace "href=""$EscClean#", "href=""$Fingerprinted#"
        $Result = $Result -replace "href=""/$EscClean#", "href=""$Fingerprinted#"
        $Result = $Result -replace "href=""\.\/$EscClean""", "href=""./$Fingerprinted"""
        $Result = $Result -replace "href=""\.\/$EscClean#", "href=""./$Fingerprinted#"
        if ($Clean -eq "index") {
            $Result = $Result -replace '(<a[^>]*?)href="\./"', "`$1href=""$Fingerprinted"""
            $Result = $Result -replace '(<a[^>]*?)href="/"', "`$1href=""$Fingerprinted"""
        }
        $LangMatch = [regex]::Match($Clean, '^([a-z]{2})/index$')
        if ($LangMatch.Success) {
            $LangSlash = $LangMatch.Groups[1].Value + "/"
            $EscLangSlash = [regex]::Escape($LangSlash)
            $Result = $Result -replace "href=""$EscLangSlash""", "href=""$Fingerprinted"""
            $Result = $Result -replace "href=""\.\/$EscLangSlash""", "href=""./$Fingerprinted"""
        }
    }
    return $Result
}

foreach ($Pair in $HtmlMap.GetEnumerator()) {
    $CleanPath = Join-Path $WwwRoot $Pair.Key
    $FingerprintedPath = Join-Path $WwwRoot $Pair.Value

    if (-not (Test-Path $CleanPath)) {
        Write-Warning "Clean file not found: $CleanPath"
        continue
    }

    $Content = Get-Content $CleanPath -Raw -Encoding UTF8
    $Rewritten = Rewrite-Links -Html $Content -Map $RouteToFingerprint
    $ParentDir = Split-Path $FingerprintedPath -Parent
    if (-not (Test-Path $ParentDir)) {
        New-Item -ItemType Directory -Path $ParentDir -Force | Out-Null
    }
    Set-Content -Path $FingerprintedPath -Value $Rewritten -Encoding UTF8 -NoNewline

    $CleanName = $Pair.Key
    $FingerprintedName = $Pair.Value
    $RelTarget = if ($CleanName -match '/') {
        $Depth = ($CleanName.Split('/').Length - 1)
        $Prefix = "../" * $Depth
        "$Prefix$FingerprintedName"
    } else {
        $FingerprintedName
    }
    $RedirectStub = @"
<!DOCTYPE html><html><head><meta charset="utf-8"/><meta http-equiv="refresh" content="0;url=$RelTarget"/><link rel="canonical" href="$RelTarget"/><style>html,body{margin:0;background:#1a1a2e}</style></head><body></body></html>
"@
    Set-Content -Path $CleanPath -Value $RedirectStub -Encoding UTF8 -NoNewline

    Write-Host "  $CleanName -> $FingerprintedName"
}

Write-Host "Fingerprinting complete: $($HtmlMap.Count) HTML files processed"
