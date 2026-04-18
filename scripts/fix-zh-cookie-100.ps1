$Path = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"
[xml]$Resx = Get-Content $Path -Encoding UTF8

$Updates = @{
    'HomeDeveloperPayoutValue' = '百分之百'
}

$ExistingKeys = @{}
foreach ($d in $Resx.root.data) {
    $ExistingKeys[$d.name] = $true
    if ($Updates.ContainsKey($d.name)) {
        $d.value = $Updates[$d.name]
    }
}

foreach ($Key in $Updates.Keys) {
    if (-not $ExistingKeys.ContainsKey($Key)) {
        $DataNode = $Resx.CreateElement('data')
        $DataNode.SetAttribute('name', $Key)
        $DataNode.SetAttribute('xml:space', 'preserve')
        $ValNode = $Resx.CreateElement('value')
        $ValNode.InnerText = $Updates[$Key]
        $DataNode.AppendChild($ValNode) | Out-Null
        $Resx.root.AppendChild($DataNode) | Out-Null
    }
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($Path, $Settings)
$Resx.Save($Writer)
$Writer.Flush()
$Writer.Dispose()
Write-Host 'Done'
