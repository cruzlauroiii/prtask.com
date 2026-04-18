$ToolsDir = 'C:\work\apktools'
New-Item -ItemType Directory -Path $ToolsDir -Force | Out-Null

# Find Java
$JavaPaths = @(
    'C:\Program Files\Eclipse Adoptium\jre-21*\bin\java.exe',
    'C:\Program Files\Eclipse Adoptium\jdk-21*\bin\java.exe'
)
$Java = $null
foreach ($P in $JavaPaths) {
    $Found = Get-ChildItem $P -ErrorAction SilentlyContinue | Select-Object -First 1
    if ($Found) { $Java = $Found.FullName; break }
}
if (-not $Java) {
    # Try refreshing PATH
    $Env:PATH = [System.Environment]::GetEnvironmentVariable('PATH', 'Machine') + ';' + [System.Environment]::GetEnvironmentVariable('PATH', 'User')
    $Java = Get-Command java -ErrorAction SilentlyContinue | Select-Object -ExpandProperty Source
}
Write-Output "Java: $Java"

# Download apktool
$ApktoolUrl = 'https://github.com/iBotPeaches/Apktool/releases/download/v2.11.1/apktool_2.11.1.jar'
$ApktoolJar = "$ToolsDir\apktool.jar"
if (-not (Test-Path $ApktoolJar)) {
    Write-Output "Downloading apktool..."
    Invoke-WebRequest -Uri $ApktoolUrl -OutFile $ApktoolJar -UseBasicParsing
}
Write-Output "Apktool: $ApktoolJar"

# Download uber-apk-signer
$SignerUrl = 'https://github.com/nickolay-georgiev/uber-apk-signer/releases/download/v1.3.0/uber-apk-signer-1.3.0.jar'
$SignerJar = "$ToolsDir\uber-apk-signer.jar"
if (-not (Test-Path $SignerJar)) {
    Write-Output "Downloading uber-apk-signer..."
    try {
        Invoke-WebRequest -Uri $SignerUrl -OutFile $SignerJar -UseBasicParsing
    } catch {
        # Try patrickfav fork
        $SignerUrl2 = 'https://github.com/nickolay-georgiev/uber-apk-signer/releases/download/v1.3.0/uber-apk-signer-1.3.0.jar'
        Write-Output "Trying alternate URL..."
    }
}
Write-Output "Signer: $SignerJar"

# Test Java
if ($Java) {
    & $Java -version 2>&1
}
