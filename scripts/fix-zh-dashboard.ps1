$Path = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"
[xml]$Resx = Get-Content $Path -Encoding UTF8

$Updates = @{
    'DashboardActiveTasksValue'   = '零'
    'DashboardUsersValue'         = '零'
    'DashboardTotalBountiesValue' = '$零'
    'DashboardPrsValue'           = '零'
    'DashboardPageDescription'    = '追踪您的开源拉取请求、已获赏金及开发者成就。提交拉取请求赚取收入——浏览任务、认领工作，代码获批后即可收款。'
    'DashboardDescriptionHeading' = '您的拉取请求任务控制台——平台概览与活动追踪'
    'DashboardDescriptionParagraph1' = '控制台提供拉取请求任务平台活动的集中概览。您可以一目了然地查看平台上的活跃任务总数、注册用户数量、所有开放任务的赏金池总额以及已提交的拉取请求数量。这些统计数据为您提供市场健康状况的实时快照，帮助您了解当前的活跃程度和可用机会。'
    'DashboardDescriptionParagraph2' = '对于开发者，控制台是评估当前可用工作概况的起点。当有活跃任务时，它们会直接显示在控制台上，并附有查看详情和开始工作的快速链接。对于客户，控制台可查看您所创建任务的状态，包括任何待审查的拉取请求。最近的拉取请求版块展示平台上的最新提交，让您随时掌握进行中的开发动态。'
    'DashboardDescriptionParagraph3' = '控制台随新任务创建、拉取请求提交及赏金发放而动态更新。如果您是希望发布新工作的客户，可从控制台直接导航至任务创建表单。如果您是寻找机会的开发者，这些统计数据有助于衡量需求与竞争情况。随着平台的成长，控制台将继续作为您的指挥中心，追踪拉取请求任务活动的各个方面，从收入与提交记录到任务管理和团队协作。'
}

$ExistingKeys = @{}
foreach ($d in $Resx.root.data) {
    $ExistingKeys[$d.name] = $true
    if ($Updates.ContainsKey($d.name)) { $d.value = $Updates[$d.name] }
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
