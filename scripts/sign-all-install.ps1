$Java = 'C:\Program Files\Eclipse Adoptium\jre-21.0.10.7-hotspot\bin\java.exe'
$Signer = 'C:\work\apktools\uber-apk-signer.jar'

# Copy splits to a temp dir and sign all together
$TempDir = 'C:\work\pocketpay-apk\to-sign'
if (Test-Path $TempDir) { Remove-Item $TempDir -Recurse -Force }
New-Item -ItemType Directory -Path $TempDir | Out-Null

Copy-Item 'C:\work\pocketpay-apk\base-patched.apk' "$TempDir\base.apk"
Copy-Item 'C:\work\pocketpay-apk\split_config.arm64_v8a.apk' "$TempDir\"
Copy-Item 'C:\work\pocketpay-apk\split_config.en.apk' "$TempDir\"
Copy-Item 'C:\work\pocketpay-apk\split_config.xxhdpi.apk' "$TempDir\"

Write-Output "=== Signing all APKs ==="
& $Java -jar $Signer -a $TempDir --allowResign 2>&1 | Select-Object -Last 5

Write-Output "`n=== Signed files ==="
$Signed = Get-ChildItem $TempDir -Filter '*debugSigned*'
foreach ($S in $Signed) { Write-Output "$($S.Name) ($([Math]::Round($S.Length / 1MB, 1)) MB)" }

Write-Output "`n=== Installing ==="
$SignedApks = $Signed | ForEach-Object { $_.FullName }
$Args = @('-s', '192.168.100.103:43619', 'install-multiple') + $SignedApks
& adb @Args 2>&1
