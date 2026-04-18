$Java = 'C:\Program Files\Eclipse Adoptium\jre-21.0.10.7-hotspot\bin\java.exe'
$Signer = 'C:\work\apktools\uber-apk-signer.jar'
$PatchedApk = 'C:\work\pocketpay-apk\base-patched.apk'

# Step 1: Sign
Write-Output "=== Signing APK ==="
& $Java -jar $Signer -a $PatchedApk --allowResign 2>&1 | Select-Object -Last 5

# Find signed APK
$SignedApk = Get-ChildItem 'C:\work\pocketpay-apk' -Filter '*signed*' | Select-Object -First 1
if ($SignedApk) {
    Write-Output "Signed: $($SignedApk.FullName) ($([Math]::Round($SignedApk.Length / 1MB, 1)) MB)"
} else {
    # uber-apk-signer outputs to same dir with -aligned-debugSigned suffix
    $SignedApk = Get-ChildItem 'C:\work\pocketpay-apk' -Filter '*debug*' | Select-Object -First 1
    if ($SignedApk) {
        Write-Output "Signed: $($SignedApk.FullName)"
    } else {
        Write-Output "Signing FAILED — no signed APK found"
        Get-ChildItem 'C:\work\pocketpay-apk' -Filter '*.apk' | Select-Object Name, Length
        exit 1
    }
}

# Step 2: Uninstall original PocketPay
Write-Output "`n=== Uninstalling original PocketPay ==="
adb -s 192.168.100.103:43619 uninstall com.gcash.business.pocketpay 2>&1

# Step 3: Install patched
Write-Output "`n=== Installing patched APK ==="
adb -s 192.168.100.103:43619 install $SignedApk.FullName 2>&1
