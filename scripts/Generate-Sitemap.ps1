param(
    [Parameter(Mandatory = $true)]
    [string]$Wwwroot,
    [string]$BaseUrl = "",
    [string]$RobotsFile,
    [string]$OutputFile,
    [string]$SourceFile,
    [switch]$UpdateSource
)

function Resolve-RelativePath($BaseDir, $Target) {
    $BasePath = (Resolve-Path $BaseDir).ProviderPath
    if (-not $BasePath.EndsWith("\")) {
        $BasePath += "\"
    }

    $TargetPath = (Resolve-Path $Target).ProviderPath
    $BaseUri = New-Object System.Uri($BasePath)
    $TargetUri = New-Object System.Uri($TargetPath)
    $Relative = $BaseUri.MakeRelativeUri($TargetUri).ToString()
    return [System.Uri]::UnescapeDataString($Relative)
}

$NormalizedWwwroot = (Resolve-Path $Wwwroot).ProviderPath
if (-not $OutputFile) {
    $OutputFile = Join-Path $NormalizedWwwroot "sitemap.xml"
}

if (-not $BaseUrl -and -not $RobotsFile) {
    $RobotsFile = Join-Path $NormalizedWwwroot "robots.txt"
}

if (-not $BaseUrl -and $RobotsFile -and (Test-Path $RobotsFile)) {
    $Line = Get-Content $RobotsFile | Select-String -Pattern "^\s*Sitemap:\s*(\S+)" | Select-Object -First 1
    if ($Line) {
        $Match = [regex]::Match($Line.Line, "^\s*Sitemap:\s*(\S+)")
        if ($Match.Success) {
            $Candidate = $Match.Groups[1].Value
            if ($Candidate -match '^https?://') {
                if ($Candidate.EndsWith("/sitemap.xml")) {
                    $BaseUrl = $Candidate.Substring(0, $Candidate.Length - "/sitemap.xml".Length)
                }
                else {
                    $BaseUrl = $Candidate.TrimEnd("/")
                }
            }
        }
    }
}

if ($BaseUrl -and $BaseUrl.EndsWith("/")) {
    $BaseUrl = $BaseUrl.TrimEnd("/")
}

if (-not $BaseUrl) {
    $BaseUrl = "https://prtask.com"
}

$DirExclusions = @("_content", "_framework")
$HashPattern = "\.[a-z0-9]{6,}\.html$"
$Pages = Get-ChildItem -Path $NormalizedWwwroot -Recurse -File -Filter "*.html"

$Paths = New-Object System.Collections.Generic.List[string]

foreach ($Page in $Pages) {
    try {
        $Relative = Resolve-RelativePath -BaseDir $NormalizedWwwroot -Target $Page.FullName
    }
    catch {
        continue
    }

    foreach ($Exclude in $DirExclusions) {
        if ($Relative -match "^$Exclude" -or $Relative -match "/$Exclude" -or $Relative -match "\\$Exclude") {
            continue 2
        }
    }

    if ($Relative -match $HashPattern) {
        continue
    }

    if ($Relative.ToLower().EndsWith("404.html")) {
        continue
    }

    $UrlPath = "/" + ($Relative -replace "\\", "/")
    $UrlPath = $UrlPath -replace "\.html$", ""
    if ($UrlPath -like "*/index") {
        $UrlPath = $UrlPath.Substring(0, $UrlPath.Length - 6)
    }

    if ($UrlPath -eq "" -or $UrlPath -eq "/index") {
        $UrlPath = "/"
    }

    if (-not $Paths.Contains($UrlPath)) {
        $Paths.Add($UrlPath) | Out-Null
    }
}

$OrderedPaths = $Paths | Sort-Object -Unique
if ($OrderedPaths.Count -gt 0 -and $OrderedPaths[0] -ne "/") {
    if ($OrderedPaths -contains "/") {
        $OrderedPaths = @("/") + ($OrderedPaths | Where-Object { $_ -ne "/" })
    }
}

function Format-Location($Path, $Base) {
    if ($Base) {
        return "$Base$Path"
    }

    if ($Path -eq "/") {
        return "./"
    }

    $Trimmed = $Path.TrimStart("/")
    return "./$Trimmed"
}

$Lines = @()
$Lines += '<?xml version="1.0" encoding="UTF-8"?>'
$Lines += '<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">'

foreach ($Path in $OrderedPaths) {
    $Location = Format-Location -Path $Path -Base $BaseUrl
    $Lines += "    <url><loc>$Location</loc></url>"
}

$Lines += "</urlset>"

$Directory = Split-Path $OutputFile
if (-not (Test-Path $Directory)) {
    New-Item -ItemType Directory -Path $Directory -Force | Out-Null
}

Set-Content -Path $OutputFile -Value $Lines -Encoding UTF8

if ($UpdateSource -and $SourceFile) {
    Copy-Item -Path $OutputFile -Destination $SourceFile -Force
}
