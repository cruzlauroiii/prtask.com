param(
    [switch]$DryRun
)
$ErrorActionPreference = 'Stop'
$DotnetRoot = 'C:\work\dotnet'
$Timestamp = Get-Date -Format 'yyyy-MM-dd HH:mm:ss'

function Write-Step($Message) {
    Write-Host "[$((Get-Date).ToString('HH:mm:ss'))] $Message" -ForegroundColor Cyan
}

if (-not (Test-Path $DotnetRoot)) {
    Write-Step "Cloning dotnet VMR..."
    git clone https://github.com/dotnet/dotnet.git $DotnetRoot
}

Set-Location $DotnetRoot
Write-Step "Pulling latest dotnet source..."
git pull --recurse-submodules
$CommitHash = git rev-parse HEAD
Write-Step "dotnet commit: $CommitHash"

Write-Step "Building .NET SDK from source..."
if (-not $DryRun) {
    if (Test-Path "$DotnetRoot\build.cmd") {
        & "$DotnetRoot\build.cmd" -c Release
    } elseif (Test-Path "$DotnetRoot\eng\build.cmd") {
        & "$DotnetRoot\eng\build.cmd" -c Release
    } else {
        throw "No build script found in $DotnetRoot"
    }
}

$ArtifactsDir = Get-ChildItem -Path "$DotnetRoot\artifacts\bin" -Directory -Filter "dotnet-sdk-*" -ErrorAction SilentlyContinue | Select-Object -First 1
if (-not $ArtifactsDir -and (Test-Path "$DotnetRoot\.dotnet")) {
    $ArtifactsDir = Get-Item "$DotnetRoot\.dotnet"
}

if ($ArtifactsDir) {
    Write-Step "Built SDK found at: $($ArtifactsDir.FullName)"
    $Env:DOTNET_ROOT = $ArtifactsDir.FullName
    $Env:PATH = "$($ArtifactsDir.FullName);$Env:PATH"

    $Version = & "$($ArtifactsDir.FullName)\dotnet.exe" --version
    Write-Step "Installed dotnet version: $Version"
} else {
    Write-Warning "Could not locate built SDK artifacts"
}

Write-Step "dotnet from source build complete. Commit: $CommitHash"
