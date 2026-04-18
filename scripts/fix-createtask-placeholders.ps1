$EnPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.resx"
[xml]$En = Get-Content $EnPath -Encoding UTF8

$EnUpdates = @{
    'CreateTaskTitlePlaceholder'       = 'Fix authentication bug in user service'
    'CreateTaskDescriptionPlaceholder' = 'Describe the task in detail...'
}

$EnExisting = @{}
foreach ($d in $En.root.data) { $EnExisting[$d.name] = $true }
foreach ($Key in $EnUpdates.Keys) {
    if (-not $EnExisting.ContainsKey($Key)) {
        $DataNode = $En.CreateElement('data')
        $DataNode.SetAttribute('name', $Key)
        $DataNode.SetAttribute('xml:space', 'preserve')
        $ValNode = $En.CreateElement('value')
        $ValNode.InnerText = $EnUpdates[$Key]
        $DataNode.AppendChild($ValNode) | Out-Null
        $En.root.AppendChild($DataNode) | Out-Null
    }
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($EnPath, $Settings)
$En.Save($Writer); $Writer.Flush(); $Writer.Dispose()

$ZhPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"
[xml]$Zh = Get-Content $ZhPath -Encoding UTF8

$ZhUpdates = @{
    'CreateTaskTitlePlaceholder'       = '修复用户服务中的身份验证错误'
    'CreateTaskDescriptionPlaceholder' = '详细描述任务...'
}

$ZhExisting = @{}
foreach ($d in $Zh.root.data) { $ZhExisting[$d.name] = $true }
foreach ($Key in $ZhUpdates.Keys) {
    if (-not $ZhExisting.ContainsKey($Key)) {
        $DataNode = $Zh.CreateElement('data')
        $DataNode.SetAttribute('name', $Key)
        $DataNode.SetAttribute('xml:space', 'preserve')
        $ValNode = $Zh.CreateElement('value')
        $ValNode.InnerText = $ZhUpdates[$Key]
        $DataNode.AppendChild($ValNode) | Out-Null
        $Zh.root.AppendChild($DataNode) | Out-Null
    }
}

$Writer2 = [System.Xml.XmlWriter]::Create($ZhPath, $Settings)
$Zh.Save($Writer2); $Writer2.Flush(); $Writer2.Dispose()
Write-Host 'Done'
