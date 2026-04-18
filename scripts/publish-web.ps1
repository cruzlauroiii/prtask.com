$ErrorActionPreference = 'Stop'
$SolutionRoot = Split-Path -Parent (Split-Path -Parent $PSScriptRoot)
$ClientProject = Join-Path $SolutionRoot 'src/PrTask.Client/PrTask.Client.csproj'
$PrerenderProject = Join-Path $SolutionRoot 'src/PrTask.Prerender/PrTask.Prerender.csproj'
$FingerprintProject = Join-Path $SolutionRoot 'src/PrTask.Fingerprint/PrTask.Fingerprint.csproj'
$PublishOutputDir = Join-Path $SolutionRoot 'publish-output'
$SourceTreeSentinelFile = "PrTask.sln"
$SourceTreeSentinelDir = "src"

if (Test-Path $PublishOutputDir) {
    if (Test-Path (Join-Path $PublishOutputDir $SourceTreeSentinelFile)) {
        throw "SAFETY: refusing to delete source tree (found $SourceTreeSentinelFile in $PublishOutputDir)"
    }
    if (Test-Path (Join-Path $PublishOutputDir $SourceTreeSentinelDir)) {
        throw "SAFETY: refusing to delete source tree (found $SourceTreeSentinelDir in $PublishOutputDir)"
    }
    Remove-Item -Path $PublishOutputDir -Recurse -Force
}

Write-Output "Publishing PrTask.Client..."
dotnet publish $ClientProject -c Release -o $PublishOutputDir

$WwwrootDir = Join-Path $PublishOutputDir 'wwwroot'
if (-not (Test-Path $WwwrootDir)) {
    Write-Error "wwwroot not found at $WwwrootDir"
    exit 1
}

Write-Output "Pre-rendering locale pages..."
dotnet run --project $PrerenderProject -c Release --roll-forward Major -- $WwwrootDir
if ($LASTEXITCODE -ne 0) {
    Write-Error "Prerender failed with exit code $LASTEXITCODE"
    exit 1
}

Write-Output "Fingerprinting HTML..."
dotnet run --project $FingerprintProject -c Release -- $PublishOutputDir
if ($LASTEXITCODE -ne 0) {
    Write-Error "Fingerprint failed with exit code $LASTEXITCODE"
    exit 1
}

# Deploy to Cloudflare Pages via wrangler
$secrets = Get-Content (Join-Path ([Environment]::GetFolderPath('ApplicationData')) 'Microsoft\UserSecrets\prtask-server-secrets\secrets.json') | ConvertFrom-Json
$env:CLOUDFLARE_API_KEY = $secrets.'Cloudflare:GlobalApiKey'
$env:CLOUDFLARE_EMAIL = $secrets.'Cloudflare:Email'
$env:CLOUDFLARE_ACCOUNT_ID = $secrets.'Cloudflare:AccountId'
$env:CI = 'true'

$sw = [System.Diagnostics.Stopwatch]::StartNew()
& npx.cmd wrangler pages deploy $WwwrootDir --project-name=prtask --commit-dirty=true 2>&1
$sw.Stop()
Write-Output "Deploy took: $($sw.Elapsed.TotalSeconds) seconds"
Write-Output "Exit code: $LASTEXITCODE"
