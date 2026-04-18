$Serial = '192.168.100.103:43619'

# Check if we can access PocketPay data dir
Write-Output "=== PocketPay data dir ==="
adb -s $Serial shell ls -la /data/data/com.gcash.business.pocketpay/ 2>&1

Write-Output "`n=== Try su ==="
adb -s $Serial shell su -c "cat /data/data/com.gcash.business.pocketpay/shared_prefs/*.xml" 2>&1 | Select-Object -First 5

Write-Output "`n=== Check external storage ==="
adb -s $Serial shell ls -la /sdcard/Android/data/com.gcash.business.pocketpay/ 2>&1

Write-Output "`n=== Check app backup ==="
adb -s $Serial shell bmgr list transports 2>&1

Write-Output "`n=== Try content provider query ==="
adb -s $Serial shell content query --uri "content://com.gcash.business.pocketpay" 2>&1

Write-Output "`n=== Check KeyStore entries ==="
adb -s $Serial shell "dumpsys activity providers 2>&1 | grep -i pocketpay" 2>&1

Write-Output "`n=== Network stats for PocketPay ==="
adb -s $Serial shell "dumpsys netstats | grep -A5 pocketpay" 2>&1 | Select-Object -First 10

Write-Output "`n=== Try reading via backup ==="
adb -s $Serial backup -noapk com.gcash.business.pocketpay -f C:\work\prtask.com\pocketpay-backup.ab 2>&1
