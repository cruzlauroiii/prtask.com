if (Test-Path 'C:\work\pocketpay-apk-v2\jadx-output\sources') {
    $Count = (Get-ChildItem 'C:\work\pocketpay-apk-v2\jadx-output\sources' -Recurse -Filter '*.java' | Measure-Object).Count
    Write-Output "jadx: $Count Java files"
    Get-ChildItem 'C:\work\pocketpay-apk-v2\jadx-output\sources' -Directory | Select-Object -First 10 | ForEach-Object { Write-Output "  $($_.Name)" }
} else {
    Write-Output "jadx output not ready"
    if (Test-Path 'C:\work\pocketpay-apk-v2\jadx-output') {
        Get-ChildItem 'C:\work\pocketpay-apk-v2\jadx-output' | Select-Object Name
    }
}
