$ToolsDir = 'C:\work\apktools'
$JadxZip = "$ToolsDir\jadx.zip"
$JadxDir = "$ToolsDir\jadx"

if (-not (Test-Path $JadxDir)) {
    Write-Output "Downloading jadx..."
    $Url = 'https://github.com/skylot/jadx/releases/download/v1.5.1/jadx-1.5.1.zip'
    Invoke-WebRequest -Uri $Url -OutFile $JadxZip -UseBasicParsing
    Write-Output "Extracting..."
    Expand-Archive -Path $JadxZip -DestinationPath $JadxDir -Force
    Remove-Item $JadxZip
}

$JadxBat = Get-ChildItem "$JadxDir" -Filter 'jadx.bat' -Recurse | Select-Object -First 1
if ($JadxBat) {
    Write-Output "jadx found: $($JadxBat.FullName)"
    & $JadxBat.FullName --version 2>&1
} else {
    $JadxJar = Get-ChildItem "$JadxDir" -Filter 'jadx*.jar' -Recurse | Select-Object -First 1
    if ($JadxJar) {
        Write-Output "jadx jar: $($JadxJar.FullName)"
    } else {
        Write-Output "jadx NOT found"
        Get-ChildItem $JadxDir -Recurse | Select-Object FullName | Select-Object -First 20
    }
}
