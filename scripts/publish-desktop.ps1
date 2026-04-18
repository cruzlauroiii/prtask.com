# Publish PrTask.Desktop as self-contained Windows EXE
# Outputs to publish-output/desktop/ and copies the EXE to Client wwwroot/downloads/
$ErrorActionPreference = 'Stop'
$SolutionRoot = Split-Path -Parent (Split-Path -Parent $PSScriptRoot)
$DesktopProject = Join-Path $SolutionRoot 'src/PrTask.Desktop/PrTask.Desktop.csproj'
$PublishDir = Join-Path $SolutionRoot 'publish-output/desktop'
$DownloadsDir = Join-Path $SolutionRoot 'src/PrTask.Client/wwwroot/downloads'

Write-Output "Publishing PrTask.Desktop..."
dotnet publish $DesktopProject -c Release -r win-x64 --self-contained true -o $PublishDir

$ExePath = Join-Path $PublishDir 'PrTask.exe'
if (Test-Path $ExePath) {
    if (-not (Test-Path $DownloadsDir)) {
        New-Item -ItemType Directory -Path $DownloadsDir -Force | Out-Null
    }
    Copy-Item $ExePath (Join-Path $DownloadsDir 'PrTask.exe') -Force
    Write-Output "PrTask.exe copied to $DownloadsDir"
} else {
    Write-Error "PrTask.exe not found at $ExePath"
}
