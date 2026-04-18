param(
    [string]$PublishSourceDir = $(Join-Path (Split-Path $PSScriptRoot -Parent) "src\PrTask.Client\bin\Release\net11.0\wwwroot"),
    [switch]$SkipPush,
    [switch]$PingOnly,
    [switch]$SkipIndexNow = $true
)

$ErrorActionPreference = "Stop"

$SourceTreeRoot = Split-Path $PSScriptRoot -Parent
$SourceTreeSentinelFile = "PrTask.sln"
$SourceTreeSentinelDir = "src"
$NoJekyllFileName = ".nojekyll"
$CnameFileName = "CNAME"
$GitAttributesContent = "* -text"
$DeployCommitMessage = "Deploy: restructured paths, SEO route pages, SRI fixed"
$ClientProject = Join-Path $SourceTreeRoot "src\PrTask.Client\PrTask.Client.csproj"
$PublicBranchTempDir = Join-Path $SourceTreeRoot "deploy-public-tmp"
$OriginUrl = "https://github.com/cruzlauroiii/prtask.com.git"
$IndexNowKey = "1aabd823ab3244959fd9b25f844a0525"
$IndexNowHost = "prtask.com"
$GitHubRepo = "cruzlauroiii/prtask.com"

function Assert-NotSourceTree([string]$TargetDir) {
    if (Test-Path (Join-Path $TargetDir $SourceTreeSentinelFile)) {
        throw "SAFETY: refusing to delete source tree (found $SourceTreeSentinelFile in $TargetDir)"
    }
    if (Test-Path (Join-Path $TargetDir $SourceTreeSentinelDir)) {
        throw "SAFETY: refusing to delete source tree (found $SourceTreeSentinelDir in $TargetDir)"
    }
}

function Assert-IsPublicWorktree([string]$TargetDir) {
    $NormalizedTarget = [System.IO.Path]::GetFullPath($TargetDir)
    $NormalizedSourceRoot = [System.IO.Path]::GetFullPath($SourceTreeRoot)
    if ($NormalizedTarget -eq $NormalizedSourceRoot) {
        throw "SAFETY: refusing to operate on source tree root ($NormalizedTarget)"
    }
}

function Clear-Directory([string]$TargetDir) {
    Assert-NotSourceTree $TargetDir
    if (Test-Path $TargetDir) {
        Get-ChildItem $TargetDir -Force | Remove-Item -Recurse -Force
    }
}

function Initialize-TempPublicRepo([string]$TempDir) {
    if (Test-Path $TempDir) {
        Clear-Directory $TempDir
    }
    else {
        New-Item -ItemType Directory -Path $TempDir -Force | Out-Null
    }
    Push-Location $TempDir
    try {
        git init | Out-Null
        git checkout --orphan Public | Out-Null
        git remote add origin $OriginUrl | Out-Null
    }
    finally {
        Pop-Location
    }
}

function Copy-PublishOutput([string]$Source, [string]$Destination) {
    if (-not (Test-Path $Source)) {
        throw "Publish source directory not found: $Source"
    }
    Copy-Item "$Source\*" $Destination -Recurse -Force
}

function Copy-SitemapFile([string]$TargetDir) {
    $SitemapPath = Join-Path $SourceTreeRoot "src\PrTask.Client\wwwroot\sitemap.xml"
    if (Test-Path $SitemapPath) {
        Copy-Item -Path $SitemapPath -Destination (Join-Path $TargetDir "sitemap.xml") -Force
    }
}

function Copy-RobotsFile([string]$TargetDir) {
    $RobotsPath = Join-Path $SourceTreeRoot "robots.txt"
    if (Test-Path $RobotsPath) {
        Copy-Item -Path $RobotsPath -Destination (Join-Path $TargetDir "robots.txt") -Force
    }
}

function Remove-CnameFile([string]$TargetDir) {
    $CnamePath = Join-Path $TargetDir $CnameFileName
    if (Test-Path $CnamePath) {
        Remove-Item $CnamePath -Force
    }
}

function New-NoJekyllFile([string]$TargetDir) {
    New-Item -ItemType File -Path (Join-Path $TargetDir $NoJekyllFileName) -Force | Out-Null
}

function New-GitAttributesFile([string]$TargetDir) {
    [System.IO.File]::WriteAllText((Join-Path $TargetDir ".gitattributes"), $GitAttributesContent)
}

function New-IndexNowKeyFile([string]$TargetDir) {
    [System.IO.File]::WriteAllText((Join-Path $TargetDir "$IndexNowKey.txt"), $IndexNowKey)
}

function Get-SitemapUrls([string]$TargetDir) {
    $SitemapPath = Join-Path $TargetDir "sitemap.xml"
    if (-not (Test-Path $SitemapPath)) { return @() }
    [xml]$Xml = Get-Content $SitemapPath -Raw
    $Ns = New-Object System.Xml.XmlNamespaceManager($Xml.NameTable)
    $Ns.AddNamespace("s", "http://www.sitemaps.org/schemas/sitemap/0.9")
    $Urls = $Xml.SelectNodes("//s:loc", $Ns) | ForEach-Object { $_.InnerText }
    return $Urls
}

function Invoke-IndexNow([string]$TargetDir) {
    $Urls = Get-SitemapUrls $TargetDir
    if (-not $Urls -or $Urls.Count -eq 0) {
        Write-Host "IndexNow: no URLs found in sitemap"
        return
    }
    $Body = @{
        host        = $IndexNowHost
        key         = $IndexNowKey
        keyLocation = "https://$IndexNowHost/$IndexNowKey.txt"
        urlList     = @($Urls)
    } | ConvertTo-Json -Depth 3
    $Endpoints = @(
        "https://api.indexnow.org/indexnow"
        "https://www.bing.com/indexnow"
        "https://yandex.com/indexnow"
        "https://searchadvisor.naver.com/indexnow"
    )
    Write-Host "IndexNow: submitting $($Urls.Count) URLs..."
    foreach ($Endpoint in $Endpoints) {
        try {
            $Response = Invoke-RestMethod -Uri $Endpoint -Method Post -ContentType "application/json; charset=utf-8" -Body $Body -ErrorAction Stop
            Write-Host "  $Endpoint -> OK"
        }
        catch {
            $Code = $_.Exception.Response.StatusCode.value__
            if ($Code -eq 200 -or $Code -eq 202) {
                Write-Host "  $Endpoint -> $Code Accepted"
            }
            else {
                Write-Host "  $Endpoint -> FAILED ($($_.Exception.Message))"
            }
        }
    }
}

function Invoke-GoogleSitemapPing {
    $SitemapUrl = "https://$IndexNowHost/sitemap.xml"
    Write-Host "Google: pinging sitemap via Search Console API..."
    try {
        $Uri = "https://www.google.com/ping?sitemap=$([System.Uri]::EscapeDataString($SitemapUrl))"
        Invoke-WebRequest -Uri $Uri -UseBasicParsing -ErrorAction Stop | Out-Null
        Write-Host "  Google ping -> OK"
    }
    catch {
        Write-Host "  Google ping -> $($_.Exception.Message) (use Search Console for reliable submission)"
    }
}

function Invoke-GitCommitAndPush([string]$TargetDir) {
    Push-Location $TargetDir
    try {
        git add -A
        $Status = git status --short
        if (-not $Status) {
            Write-Host "No changes to commit"
            return
        }
        git commit -m $DeployCommitMessage
        if (-not $SkipPush) {
            git push --force origin HEAD:Public
        }
    }
    finally {
        Pop-Location
    }
}

if ($PingOnly) {
    Write-Host "=== Ping search engines only ==="
    $SitemapDir = Split-Path (Join-Path $SourceTreeRoot "src\PrTask.Client\wwwroot\sitemap.xml")
    Invoke-IndexNow $SitemapDir
    Invoke-GoogleSitemapPing
    Write-Host "=== Ping complete ==="
    return
}

Write-Host "=== Deploy-Public ==="
Write-Host "Source: $PublishSourceDir"
Write-Host "Target: $PublicBranchTempDir"

Write-Host "[0] Regenerating client static HTML..."
dotnet build $ClientProject -c Release

Write-Host "[1] Initializing temp Public repo..."
Initialize-TempPublicRepo $PublicBranchTempDir

Write-Host "[2] Writing .gitattributes..."
New-GitAttributesFile $PublicBranchTempDir

Write-Host "[3] Copying publish output..."
Copy-PublishOutput $PublishSourceDir $PublicBranchTempDir

Write-Host "[3.1] Copying robots.txt"
Copy-RobotsFile $PublicBranchTempDir

Write-Host "[3.2] Copying sitemap.xml"
Copy-SitemapFile $PublicBranchTempDir

Write-Host "[4] Removing CNAME..."
Remove-CnameFile $PublicBranchTempDir

Write-Host "[5] Creating .nojekyll..."
New-NoJekyllFile $PublicBranchTempDir

Write-Host "[5.1] Creating IndexNow key file..."
New-IndexNowKeyFile $PublicBranchTempDir

Write-Host "[6] Committing and pushing..."
Invoke-GitCommitAndPush $PublicBranchTempDir


if (-not $SkipPush) {
    Write-Host "[6.1] Waiting for GitHub Actions deployment to complete..."
    Start-Sleep -Seconds 5
    $Deadline = (Get-Date).AddMinutes(10)
    $ActiveRun = $null
    while ((Get-Date) -lt $Deadline) {
        $RunsJson = gh run list --repo $GitHubRepo --limit 5 --json databaseId,status 2>$null
        if ($RunsJson) {
            $Runs = $RunsJson | ConvertFrom-Json
            $ActiveRun = $Runs | Where-Object { $_.status -ne 'completed' } | Select-Object -First 1
            if (-not $ActiveRun) { break }
            Write-Host "  Workflow status: $($ActiveRun.status) - waiting..."
        }
        Start-Sleep -Seconds 5
    }
    if ($ActiveRun) {
        Write-Host "  WARNING: workflow did not complete within timeout"
    } else {
        Write-Host "  Workflow completed."
    }
    Write-Host "[6.2] Deleting all GitHub Actions workflow runs..."
    $AllRunsJson = gh run list --repo $GitHubRepo --limit 100 --json databaseId 2>$null
    if ($AllRunsJson) {
        $AllIds = ($AllRunsJson | ConvertFrom-Json).databaseId
        foreach ($RunId in $AllIds) {
            gh run delete $RunId --repo $GitHubRepo 2>$null | Out-Null
        }
        Write-Host "  Deleted $($AllIds.Count) workflow run(s)."
    }
}

if (-not $SkipPush -and -not $SkipIndexNow) {
    Write-Host "[7] Pinging search engines..."
    Invoke-IndexNow $PublicBranchTempDir
    Invoke-GoogleSitemapPing
}

Write-Host "=== Deploy-Public complete ==="
