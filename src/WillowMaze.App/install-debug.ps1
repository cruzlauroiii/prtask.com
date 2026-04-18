param(
    [string]$Device = "192.168.100.175:46661"
)

$ErrorActionPreference = "Stop"

$project = Join-Path $PSScriptRoot "WillowMaze.App.csproj"
$apk = Join-Path $PSScriptRoot "bin\Debug\net11.0-android36.0\com.willowmaze.app-Signed.apk"
$packageId = "com.willowmaze.app"
$launchActivity = "crc64ea0d2a8b03c149e0.MainActivity"

adb connect $Device | Out-Null

dotnet build $project -c Debug -f net11.0-android36.0 -p:AndroidPackageFormats=apk

if (-not (Test-Path $apk)) {
    throw "APK not found: $apk"
}

adb -s $Device uninstall $packageId | Out-Null
adb -s $Device install --no-streaming $apk
adb -s $Device shell am start -n "$packageId/$launchActivity" | Out-Null

Write-Host "Installed and launched $packageId on $Device"
