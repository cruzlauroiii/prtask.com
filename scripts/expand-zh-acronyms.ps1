# expand-zh-acronyms.ps1
# Expands English acronyms in SharedResource.zh.resx to Chinese equivalents

$ResxPath = 'C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx'

$Xml = [xml][System.IO.File]::ReadAllText($ResxPath, [System.Text.Encoding]::UTF8)

# Build ordered list of acronyms for Step A (parenthetical removal)
# Compound/multi-word first, then longer individual ones
$AcronymList = @(
    'CCPA/CPRA',
    'HTTPS/TLS',
    'PCI DSS',
    'AMLD6',
    'AMLC',
    'PIPEDA',
    'CCPA',
    'CPRA',
    'POPIA',
    'DPDP',
    'DMCA',
    'GDPR',
    'APPI',
    'APPs',
    'LGPD',
    'NIRC',
    'OAIC',
    'OIDC',
    'PDPC',
    'PDPA',
    'PECR',
    'PIPA',
    'PIPC',
    'PIPL',
    'PKCE',
    'ANPD',
    'WCAG',
    'CSRF',
    'HTTPS',
    'HTML',
    'AML',
    'ADA',
    'ADR',
    'BIR',
    'CAC',
    'CDN',
    'CSS',
    'CVV',
    'DAC7',
    'DDoS',
    'DPA',
    'DPO',
    'DSA',
    'DSS',
    'DTI',
    'EAA',
    'EEA',
    'GPC',
    'ICO',
    'IRS',
    'MIT',
    'NPC',
    'OPC',
    'PCI',
    'PPC',
    'SCCs',
    'AI',
    'API',
    'IP',
    'UI',
    'URL',
    'UTC',
    'XP',
    'RA'
)

# Expansion map
$Expansions = [ordered]@{
    'CCPA/CPRA'   = '加州消费者隐私法/加州隐私权法'
    'HTTPS/TLS'   = '超文本传输安全协议/传输层安全'
    'PCI DSS'     = '支付卡行业数据安全标准'
    'AMLD6'       = '第六反洗钱指令'
    'AMLC'        = '反洗钱委员会'
    'PIPEDA'      = '加拿大个人信息保护和电子文件法'
    'CCPA'        = '加州消费者隐私法'
    'CPRA'        = '加州隐私权法'
    'POPIA'       = '南非个人信息保护法'
    'DPDP'        = '数字个人数据保护法'
    'DMCA'        = '数字千年版权法'
    'GDPR'        = '通用数据保护条例'
    'APPI'        = '个人信息保护法'
    'APPs'        = '澳大利亚隐私原则'
    'LGPD'        = '巴西通用数据保护法'
    'NIRC'        = '菲律宾国家税收法典'
    'OAIC'        = '澳大利亚信息专员办公室'
    'OIDC'        = '开放身份连接'
    'PDPC'        = '个人数据保护委员会'
    'PDPA'        = '个人数据保护法'
    'PECR'        = '英国隐私和电子通信条例'
    'PIPA'        = '个人信息保护法'
    'PIPC'        = '个人信息保护委员会'
    'PIPL'        = '个人信息保护法'
    'PKCE'        = '代码交换证明密钥'
    'ANPD'        = '巴西国家数据保护局'
    'WCAG'        = '网页内容无障碍指南'
    'CSRF'        = '跨站请求伪造防护'
    'HTTPS'       = '超文本传输安全协议'
    'HTML'        = '超文本标记语言'
    'AML'         = '反洗钱'
    'ADA'         = '美国残疾人法案'
    'ADR'         = '替代性争议解决'
    'BIR'         = '菲律宾国内税务局'
    'CAC'         = '国家互联网信息办公室'
    'CDN'         = '内容分发网络'
    'CSS'         = '层叠样式表'
    'CVV'         = '卡片验证码'
    'DAC7'        = '数字平台数据申报指令'
    'DDoS'        = '分布式拒绝服务'
    'DPA'         = '数据保护机构'
    'DPO'         = '数据保护官'
    'DSA'         = '数字服务法'
    'DSS'         = '数据安全标准'
    'DTI'         = '菲律宾贸工部'
    'EAA'         = '欧洲无障碍法案'
    'EEA'         = '欧洲经济区'
    'GPC'         = '全球隐私控制'
    'ICO'         = '英国信息专员办公室'
    'IRS'         = '美国国税局'
    'MIT'         = '麻省理工'
    'NPC'         = '国家隐私委员会'
    'OPC'         = '加拿大隐私专员办公室'
    'PCI'         = '支付卡行业'
    'PPC'         = '个人信息保护委员会'
    'SCCs'        = '欧盟标准合同条款'
    'AI'          = '人工智能'
    'API'         = '应用程序接口'
    'IP'          = '互联网协议'
    'UI'          = '用户界面'
    'URL'         = '网址'
    'UTC'         = '协调世界时'
    'XP'          = '经验值'
}

$ModifiedCount = 0

foreach ($Node in $Xml.root.data) {
    $ValueNode = $Node.SelectSingleNode('value')
    if ($null -eq $ValueNode) { continue }

    $Original = $ValueNode.InnerText
    $Text = $Original

    # Step A: Global pass - remove parenthetical forms （ACRONYM） and (ACRONYM)
    # for all acronyms in our list
    foreach ($Acronym in $AcronymList) {
        $EscapedAcronym = [regex]::Escape($Acronym)
        # Remove （ACRONYM） or (ACRONYM) forms
        $Text = [regex]::Replace($Text, "[（(]${EscapedAcronym}[）)]", '')
    }

    # Step B: Replace remaining standalone occurrences

    # Special case: RA NNNN (e.g. RA 10173 → 第10173号共和国法案)
    $Text = [regex]::Replace($Text, '(?<![A-Za-z\d])RA\s+(\d+)(?![A-Za-z\d])', '第$1号共和国法案')

    # W-9/W-8BEN compound (keep form names but add context)
    $Text = [regex]::Replace($Text, '(?<![A-Za-z\d])W-9/W-8BEN(?![A-Za-z\d])', 'W-9/W-8BEN税务表格')

    # Apply all expansions in order
    foreach ($Pair in $Expansions.GetEnumerator()) {
        $Acronym = $Pair.Key
        $Chinese = $Pair.Value
        $EscapedAcronym = [regex]::Escape($Acronym)
        $Text = [regex]::Replace($Text, "(?<![A-Za-z\d])${EscapedAcronym}(?![A-Za-z\d])", $Chinese)
    }

    # Handle remaining bare RA
    $Text = [regex]::Replace($Text, '(?<![A-Za-z\d])RA(?![A-Za-z\d])', '菲律宾共和国法案')

    if ($Text -ne $Original) {
        $ValueNode.InnerText = $Text
        $ModifiedCount++
        Write-Host "Modified: $($Node.name)"
        Write-Host "  Before: $Original"
        Write-Host "  After:  $Text"
        Write-Host ''
    }
}

# Save with UTF-8 encoding and indentation
$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)  # No BOM
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Settings.NewLineChars = "`n"

$Writer = [System.Xml.XmlWriter]::Create($ResxPath, $Settings)
try {
    $Xml.Save($Writer)
} finally {
    $Writer.Close()
}

Write-Host "Done. Modified $ModifiedCount key(s)."
