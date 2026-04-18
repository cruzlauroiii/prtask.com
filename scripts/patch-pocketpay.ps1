$Java = 'C:\Program Files\Eclipse Adoptium\jre-21.0.10.7-hotspot\bin\java.exe'
$Apktool = 'C:\work\apktools\apktool.jar'
$ApkPath = 'C:\work\pocketpay-apk\base.apk'
$OutputDir = 'C:\work\pocketpay-apk\decompiled'
$PatchedApk = 'C:\work\pocketpay-apk\base-patched.apk'

# Step 1: Decompile with apktool
Write-Output "=== Step 1: Decompile ==="
if (Test-Path $OutputDir) { Remove-Item $OutputDir -Recurse -Force }
& $Java -jar $Apktool d $ApkPath -o $OutputDir -f 2>&1 | Select-Object -Last 5
Write-Output ""

# Step 2: Patch network_security_config.xml to trust user CAs
Write-Output "=== Step 2: Patch network_security_config.xml ==="
$NetSecPath = "$OutputDir\res\xml\network_security_config.xml"
if (Test-Path $NetSecPath) {
    $Original = Get-Content $NetSecPath -Raw
    Write-Output "Original:"
    Write-Output $Original

    # Replace with version that trusts user CAs
    $Patched = @'
<?xml version="1.0" encoding="utf-8"?>
<network-security-config>
    <base-config cleartextTrafficPermitted="true">
        <trust-anchors>
            <certificates src="system" />
            <certificates src="user" />
        </trust-anchors>
    </base-config>
</network-security-config>
'@
    Set-Content -Path $NetSecPath -Value $Patched
    Write-Output "`nPatched:"
    Write-Output $Patched
} else {
    Write-Output "network_security_config.xml not found!"
}

# Step 3: Rebuild APK
Write-Output "`n=== Step 3: Rebuild ==="
& $Java -jar $Apktool b $OutputDir -o $PatchedApk 2>&1 | Select-Object -Last 10
Write-Output ""

if (Test-Path $PatchedApk) {
    $Size = (Get-Item $PatchedApk).Length / 1MB
    Write-Output "Patched APK: $PatchedApk ($([Math]::Round($Size, 1)) MB)"
} else {
    Write-Output "BUILD FAILED"
}
