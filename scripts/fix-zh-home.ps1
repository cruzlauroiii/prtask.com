$Path = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"
[xml]$Resx = Get-Content $Path -Encoding UTF8

$Updates = @{
    'HomeHeroHeading'           = '拉取请求任务 — 通过拉取请求赚钱'
    'HomeHeroSubtitle'          = '浏览任务，提交拉取请求，根据复杂度获得报酬。攀登排行榜。'
    'HomeSubmitPrHeading'       = '提交您的拉取请求'
    'HomeSubmitPrDescription'   = '提交公开的拉取请求。多个开发者可以提交拉取请求，客户选择最佳方案。'
    'HomeGetPaidDescription'    = '当客户批准您的拉取请求时，系统会自动向其收费，您将通过首选的支付方式获得报酬。'
    'HomeDescriptionHeading'    = '拉取请求任务 是什么——面向拉取请求赏金的开发者市场'
    'HomeDescriptionParagraph1' = '拉取请求任务 是一个开发者市场，连接有软件开发需求的客户与通过拉取请求完成任务的技术开发者。平台采用赏金模式运营：客户发布附带金钱奖励的任务，开发者通过提交高质量、通过审查的代码来获得赏金。拉取请求任务上的每项任务都绑定到真实的 GitHub 仓库，确保所有贡献透明可验证，并直接集成到生产代码库中。'
    'HomeDescriptionParagraph2' = '与传统自由职业平台不同，拉取请求任务专注于基于拉取请求的工作模式。开发者可以浏览开放任务，以拉取请求的形式提交解决方案，一旦代码被任务发布者审批合并，即可自动收款。审查流程遵循标准的 GitHub 工作流，对任何参与过开源贡献或团队开发的开发者来说都非常熟悉。赏金涵盖从小型 bug 修复到复杂功能实现的广泛范围，各技术水平的开发者均有机会获得收入。'
    'HomeDescriptionParagraph3' = '拉取请求任务对开发者零抽佣——每笔赏金全额到账。客户在创建任务时设定赏金金额，拉取请求获批后自动完成支付。平台支持多种支付方式，包括信用卡、GCash、GrabPay、Maya、银行转账及 QR Ph 支付。无论您是寻找副业收入的独立开发者，还是为特定任务寻找专业人才的企业，拉取请求任务都提供从任务创建到赏金发放的流畅工作流。'
    'BrandName'                 = '拉取请求任务'
}

foreach ($Node in $Resx.root.data) {
    if ($Updates.ContainsKey($Node.name)) {
        $Node.value = $Updates[$Node.name]
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
