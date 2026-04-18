$Output = adb -s 192.168.100.103:43619 logcat -d 2>&1
foreach ($L in $Output) {
    if ($L -match 'merchant|apikey|api.key|registry_key|integration_key|x-merchant' -and $L -notmatch 'HoneySpace|launcher|SurfaceFlinger') {
        $T = $L.Trim()
        if ($T.Length -gt 200) { $T = $T.Substring(0, 200) }
        Write-Output $T
    }
}
