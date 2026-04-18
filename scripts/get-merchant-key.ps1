# Try to read merchant API key from PocketPay's shared preferences via companion HTTP
try {
    $Base = 'http://192.168.100.103:8769'
    $Status = (Invoke-WebRequest -Uri "$Base/status" -TimeoutSec 5 -UseBasicParsing).Content
    Write-Output "Companion: $Status"
} catch {
    Write-Output "Companion offline"
    exit
}

# Check if ADB is available
$Devices = adb devices 2>&1
Write-Output "ADB: $Devices"

# Try to read PocketPay shared prefs via ADB
foreach ($D in (adb devices 2>&1 | Select-String 'device$')) {
    $Serial = ($D -split '\t')[0]
    Write-Output "Device: $Serial"

    # Try reading shared prefs
    $Prefs = adb -s $Serial shell run-as com.gcash.business.pocketpay cat shared_prefs/*.xml 2>&1
    if ($Prefs -match 'integration_registry_key|merchant.*api.*key|x-merchant') {
        Write-Output "Found merchant key in prefs!"
        Write-Output $Prefs
    } else {
        Write-Output "Can't read PocketPay prefs (expected - different app UID)"
    }

    # Try reading via content provider or dumpsys
    $DumpSys = adb -s $Serial shell dumpsys package com.gcash.business.pocketpay 2>&1 | Select-String 'sharedUserId|dataDir'
    Write-Output "PocketPay info: $DumpSys"
}
