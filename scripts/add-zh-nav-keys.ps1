$ResxPath = 'C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx'
[xml]$Zh = Get-Content $ResxPath -Encoding UTF8
$ZhMap = @{}
foreach ($d in $Zh.root.data) { $ZhMap[$d.name] = $true }

$NewKeys = [ordered]@{
    'BrandTagline'     = '通过 Pull Request 赚取收入。'
    'CategoryPlatform' = '平台'
    'CategoryClient'   = '客户'
    'CategoryAccount'  = '账户'
    'CategoryLegal'    = '法律'
    'CategoryInfo'     = '信息'
    'LoginLabel'       = '登录'
    'RefundLabel'      = '退款'
    'HomeLabel'        = '首页'
}

foreach ($Key in $NewKeys.Keys) {
    if ($ZhMap.ContainsKey($Key)) {
        Write-Host "Skipping existing: $Key"
        continue
    }
    $DataNode = $Zh.CreateElement('data')
    $DataNode.SetAttribute('name', $Key)
    $DataNode.SetAttribute('xml:space', 'preserve')
    $ValNode = $Zh.CreateElement('value')
    $ValNode.InnerText = $NewKeys[$Key]
    $DataNode.AppendChild($ValNode) | Out-Null
    $Zh.root.AppendChild($DataNode) | Out-Null
    Write-Host "Added: $Key"
}

# Fix FooterCopyrightText with correct © symbol
foreach ($d in $Zh.root.data) {
    if ($d.name -eq 'FooterCopyrightText') {
        $d.value = [char]0x00A9 + ' 2026 PrTask. 版权所有。'
        Write-Host 'Fixed: FooterCopyrightText'
        break
    }
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($ResxPath, $Settings)
$Zh.Save($Writer)
$Writer.Flush()
$Writer.Dispose()
Write-Host 'Done.'
