# Publish PrTask.Maui as Android APK
# Outputs signed APK and copies to Client wwwroot/downloads/
$ErrorActionPreference = 'Stop'
$SolutionRoot = Split-Path -Parent (Split-Path -Parent $PSScriptRoot)
$MauiProject = Join-Path $SolutionRoot 'src/PrTask.Maui/PrTask.Maui.csproj'
$DownloadsDir = Join-Path $SolutionRoot 'src/PrTask.Client/wwwroot/downloads'

Write-Output "Publishing PrTask.Maui Android APK..."
dotnet publish $MauiProject -c Release -f net10.0-android36.0

$PublishDir = Join-Path $SolutionRoot 'src/PrTask.Maui/bin/Release/net10.0-android36.0/publish'
$ApkPath = Join-Path $PublishDir 'com.prtask.app-Signed.apk'
if (Test-Path $ApkPath) {
    if (-not (Test-Path $DownloadsDir)) {
        New-Item -ItemType Directory -Path $DownloadsDir -Force | Out-Null
    }
    Copy-Item $ApkPath (Join-Path $DownloadsDir 'com.prtask.app-Signed.apk') -Force
    Write-Output "APK copied to $DownloadsDir"
} else {
    Write-Error "Signed APK not found at $ApkPath"
}
