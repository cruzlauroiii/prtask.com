$ZhPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"
[xml]$Zh = Get-Content $ZhPath -Encoding UTF8

$Fixes = @{
    'DmcaLabel'                = 'DMCA'
    'SettingsCardCvcLabel'     = 'CVC'
    'SettingsConnectedGitHub'  = 'GitHub'
    'SettingsConnectedGoogle'  = 'Google'
    'SettingsConnectedMicrosoft' = 'Microsoft'
    'SettingsConnectedOkta'    = 'Okta'
    'SettingsGatewayGcashLabel'  = 'GCash'
    'SettingsGatewayGrabPayLabel' = 'GrabPay'
    'SettingsGatewayMayaLabel'   = 'Maya'
    'SettingsPayoutPaypalOption' = 'PayPal'
    'DownloadLinuxHeading'     = 'Linux'
    'DownloadMacHeading'       = 'macOS'
}

foreach ($d in $Zh.root.data) {
    if ($Fixes.ContainsKey($d.name)) { $d.value = $Fixes[$d.name] }
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($ZhPath, $Settings)
$Zh.Save($Writer); $Writer.Flush(); $Writer.Dispose()
Write-Host "Done"
