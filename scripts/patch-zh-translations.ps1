param([string]$ResxPath, [string]$JsonPath)

$Updates = Get-Content $JsonPath -Encoding UTF8 | ConvertFrom-Json
[xml]$Resx = Get-Content $ResxPath -Encoding UTF8

foreach ($node in $Resx.root.data) {
    $val = $Updates.PSObject.Properties[$node.name]
    if ($val) {
        $node.value = $val.Value
    }
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($ResxPath, $Settings)
$Resx.Save($Writer)
$Writer.Flush()
$Writer.Dispose()
Write-Host "Updated: $ResxPath"
