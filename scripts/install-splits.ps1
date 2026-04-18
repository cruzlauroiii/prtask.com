$Base = 'C:\work\pocketpay-apk\base-patched-aligned-debugSigned.apk'
$Splits = Get-ChildItem 'C:\work\pocketpay-apk' -Filter 'split_config.*.apk'

Write-Output "Base: $Base"
foreach ($S in $Splits) { Write-Output "Split: $($S.Name)" }

$AllApks = @($Base) + ($Splits | ForEach-Object { $_.FullName })

Write-Output "`nInstalling with install-multiple..."
$Args = @('-s', '192.168.100.103:43619', 'install-multiple') + $AllApks
& adb @Args 2>&1
