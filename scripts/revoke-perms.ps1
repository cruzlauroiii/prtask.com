$Device = '192.168.100.103:35205'
$Pkg = 'com.prtask.pocketpay.companion'
$Perms = @('ACCESS_FINE_LOCATION','ACCESS_COARSE_LOCATION','ACCESS_BACKGROUND_LOCATION','CAMERA','RECORD_AUDIO','READ_PHONE_STATE','BLUETOOTH_CONNECT','BLUETOOTH_SCAN','NEARBY_WIFI_DEVICES','POST_NOTIFICATIONS')
foreach ($P in $Perms) {
    $R = adb -s $Device shell pm revoke $Pkg "android.permission.$P" 2>&1
    Write-Output "Revoke $P : $R"
}
adb -s $Device shell settings put secure enabled_accessibility_services "''"
adb -s $Device shell settings put secure accessibility_enabled 0
Write-Output 'Done'
