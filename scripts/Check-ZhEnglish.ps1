param([string]$Wwwroot)

if (-not $Wwwroot) { $Wwwroot = "C:\work\prtask.com\src\PrTask.Client\bin\Release\net11.0\wwwroot" }

$EnPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.resx"
$ZhPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"
[xml]$En = Get-Content $EnPath -Encoding UTF8
[xml]$Zh = Get-Content $ZhPath -Encoding UTF8

$EnMap = @{}
foreach ($d in $En.root.data) { $EnMap[$d.name] = $d.value }
$ZhMap = @{}
foreach ($d in $Zh.root.data) { $ZhMap[$d.name] = $d.value }

$TechnicalWhitelist = @(
    'macOS', 'GitHub', 'Google', 'Okta', 'Maya', 'GCash', 'MAUI', 'Blazor',
    'APK', 'EXE', 'DMG', 'x64', 'ARM', 'GDPR', 'CCPA', 'DMCA', 'PCI', 'DSS', 'AMLA', 'AMLC', 'AML',
    'VAT', 'BIR', 'IRS', 'DAC7', 'OIDC', 'PKCE', 'OAuth', 'API', 'URL', 'CDN', 'RAM',
    'UTC', 'GMT', 'PDF', 'CSV', 'JSON', 'XML', 'HTTP', 'HTTPS', 'SQL', 'NoSQL', 'SDK', 'IDE',
    'prtask.com', 'prtask-session', 'prtask-csrf', 'prtask-cookie-consent', 'prtask-language', 'prtask-theme',
    '_ga', '_gid', '_gat', 'fbp', 'fbc', 'RA', 'W-9', 'W-8BEN',
    'Cloudflare', 'Stripe', 'PayPal', 'Maya Business', 'Didit', 'GrabPay', 'QR Ph',
    'legal@prtask.com', 'support@prtask.com', 'abuse@prtask.com', 'privacy@prtask.com',
    'accessibility@prtask.com', 'compliance@prtask.com', 'dmca@prtask.com', 'dpo@prtask.com',
    'security@prtask.com', 'ico.org.uk'
)

function IsEnglishOnly([string]$Text) {
    $t = $Text.Trim()
    if ($t.Length -eq 0) { return $false }
    if ($t -match '[^\x00-\x7F]') { return $false }
    if ($t -match '^https?://') { return $false }
    if ($t -match '^[\w.+-]+@[\w.-]+\.\w+$') { return $false }
    if ($t -match '^[\d\s\.\,\-\+\$\%\/\(\)\[\]\#\:\;\!\?]+$') { return $false }
    if ($TechnicalWhitelist -contains $t) { return $false }
    return $t -match '[A-Za-z]{2,}'
}

function HasMeaningfulEnglish([string]$Text) {
    $t = $Text.Trim()
    if ($t.Length -eq 0) { return $false }
    if ($t -match '^https?://') { return $false }
    if ($t -match '^[\w.+-]+@[\w.-]+\.\w+$') { return $false }
    $Words = [regex]::Matches($t, '\b[A-Za-z]{3,}\b') | ForEach-Object { $_.Value }
    return $Words.Count -ge 2
}

$MissingKeys = [System.Collections.Generic.List[string]]::new()
foreach ($Key in $EnMap.Keys) {
    $EnVal = $EnMap[$Key]
    if (-not $ZhMap.ContainsKey($Key) -or $ZhMap[$Key] -eq $EnVal) {
        if (HasMeaningfulEnglish $EnVal) {
            $MissingKeys.Add("  $Key = $EnVal")
        }
    }
}

$AbbrevPatterns = @(
    @{ Pattern = '(?<![A-Za-z\d])PR(?![A-Za-z\d])';          Label = 'PR → 拉取请求' },
    @{ Pattern = '(?<![A-Za-z\d])PRs(?![A-Za-z\d])';         Label = 'PRs → 拉取请求' },
    @{ Pattern = '(?<![A-Za-z\d])ID(?![A-Za-z\d])';          Label = 'ID → 编号' },
    @{ Pattern = '(?<![A-Za-z\d])Epic(?![A-Za-z\d])';        Label = 'Epic → 史诗' },
    @{ Pattern = '(?<![A-Za-z\d])Feature(?![A-Za-z\d])';     Label = 'Feature → 功能' },
    @{ Pattern = '(?<![A-Za-z\d])Story(?![A-Za-z\d])';       Label = 'Story → 用户故事' },
    @{ Pattern = '(?<![A-Za-z\d])Task(?![A-Za-z\d])';        Label = 'Task → 任务' },
    @{ Pattern = '(?<![A-Za-z\d])Bug(?![A-Za-z\d])';         Label = 'Bug → 漏洞' },
    @{ Pattern = '(?<![A-Za-z\d])Trivial(?![A-Za-z\d])';     Label = 'Trivial → 极简' },
    @{ Pattern = '(?<![A-Za-z\d])Simple(?![A-Za-z\d])';      Label = 'Simple → 简单' },
    @{ Pattern = '(?<![A-Za-z\d])Medium(?![A-Za-z\d])';      Label = 'Medium → 中等' },
    @{ Pattern = '(?<![A-Za-z\d])Complex(?![A-Za-z\d])';     Label = 'Complex → 复杂' },
    @{ Pattern = '(?<![A-Za-z\d])Expert(?![A-Za-z\d])';      Label = 'Expert → 专家' },
    @{ Pattern = '(?<![A-Za-z\d])SSO(?![A-Za-z\d])';         Label = 'SSO → 单点登录' },
    @{ Pattern = '(?<![A-Za-z\d])2FA(?![A-Za-z\d])';         Label = '2FA → 双因素认证' },
    @{ Pattern = '(?<![A-Za-z\d])iPhone(?![A-Za-z\d])';      Label = 'iPhone → 苹果手机' },
    @{ Pattern = '(?<![A-Za-z\d])Fedora(?![A-Za-z\d])';      Label = 'Fedora → 软呢帽' },
    @{ Pattern = '(?<![A-Za-z\d])Microsoft(?![A-Za-z\d])';   Label = 'Microsoft → 微软' },
    @{ Pattern = '(?<![A-Za-z\d])Azure(?![A-Za-z\d])';       Label = 'Azure → 蔚蓝' },
    @{ Pattern = '(?<![A-Za-z\d])Linux(?![A-Za-z\d])';       Label = 'Linux → 利纳克斯' },
    @{ Pattern = '(?<![A-Za-z\d])fork(?![A-Za-z\d])';        Label = 'fork → 分叉' },
    @{ Pattern = '(?<![A-Za-z\d])American(?![A-Za-z\d])';    Label = 'American → 美国' },
    @{ Pattern = '(?<![A-Za-z\d])Express(?![A-Za-z\d])';     Label = 'Express → 运通' },
    @{ Pattern = '(?<![A-Za-z\d])Visa(?![A-Za-z\d])';        Label = 'Visa → 维萨' },
    @{ Pattern = '(?<![A-Za-z\d])Mastercard(?![A-Za-z\d])';  Label = 'Mastercard → 万事达' },
    @{ Pattern = '(?<![A-Za-z\d])WebSocket(?![A-Za-z\d])';   Label = 'WebSocket → 网络套接字' },
    @{ Pattern = '(?<![A-Za-z\d])JavaScript(?![A-Za-z\d])';  Label = 'JavaScript → 爪哇脚本' },
    @{ Pattern = '(?<![A-Za-z\d])Python(?![A-Za-z\d])';      Label = 'Python → 蟒蛇' },
    @{ Pattern = '(?<![A-Za-z\d])DevOps(?![A-Za-z\d])';      Label = 'DevOps → 开发运维' },
    @{ Pattern = '(?<![A-Za-z\d])iOS(?![A-Za-z\d])';         Label = 'iOS → 苹果系统' },
    @{ Pattern = '(?<![A-Za-z\d])Ubuntu(?![A-Za-z\d])';      Label = 'Ubuntu → 乌班图' },
    @{ Pattern = '(?<![A-Za-z\d])Mac(?![A-Za-z\d])';         Label = 'Mac → 苹果电脑' },
    @{ Pattern = '(?<![A-Za-z\d])USD(?![A-Za-z\d])';         Label = 'USD → 美元' },
    @{ Pattern = '(?<![A-Za-z\d])Withdrawal(?![A-Za-z\d])';  Label = 'Withdrawal → 撤回' },
    @{ Pattern = '(?<![A-Za-z\d])KYC(?![A-Za-z\d@])';        Label = 'KYC → 了解您的客户' },
    @{ Pattern = '(?<![A-Za-z\d])Connect(?![A-Za-z\d])';     Label = 'Connect → 连接' },
    @{ Pattern = '(?<![A-Za-z\d])security(?![A-Za-z\d@])';   Label = 'security → 安全' }
)
$PrViolations = [System.Collections.Generic.List[string]]::new()
foreach ($Key in $ZhMap.Keys) {
    $ZhVal = $ZhMap[$Key]
    foreach ($Ab in $AbbrevPatterns) {
        if ($ZhVal -cmatch $Ab.Pattern) {
            $Preview = $ZhVal.Substring(0, [Math]::Min(80, $ZhVal.Length))
            $PrViolations.Add("  [$($Ab.Label)] $Key = $Preview")
            break
        }
    }
}

$ZhDir = Join-Path $Wwwroot "zh"
$HtmlViolations = [System.Collections.Generic.List[string]]::new()
if (Test-Path $ZhDir) {
    foreach ($HtmlFile in (Get-ChildItem $ZhDir -Filter "*.html" -Recurse)) {
        if ($HtmlFile.Name -notmatch '\.[0-9a-f]{10,}\.') { continue }
        $Content = [System.Net.WebUtility]::HtmlDecode((Get-Content $HtmlFile.FullName -Raw -Encoding UTF8))
        $NoScript = [regex]::Replace($Content, '(?si)<script[^>]*>.*?</script>', '')
        $NoStyle  = [regex]::Replace($NoScript, '(?si)<style[^>]*>.*?</style>', '')
        $Texts = [regex]::Matches($NoStyle, '(?<=>)([^<]+)(?=<)') |
            ForEach-Object { $_.Groups[1].Value.Trim() } | Where-Object { $_ -ne '' }
        foreach ($Text in $Texts) {
            if (IsEnglishOnly $Text) {
                $HtmlViolations.Add("  [$($HtmlFile.Name)] $Text")
            }
        }
    }
}

$Failed = $false

if ($PrViolations.Count -gt 0) {
    Write-Host ""
    Write-Host "ERROR: Untranslated PR abbreviation in zh resx ($($PrViolations.Count)) — replace PR with 拉取请求:"
    $PrViolations | ForEach-Object { Write-Host $_ }
    $Failed = $true
}

if ($MissingKeys.Count -gt 0) {
    Write-Host ""
    Write-Host "ERROR: Untranslated zh resx keys ($($MissingKeys.Count)):"
    $MissingKeys | ForEach-Object { Write-Host $_ }
    $Failed = $true
}

if ($HtmlViolations.Count -gt 0) {
    Write-Host ""
    Write-Host "ERROR: English text in zh HTML ($($HtmlViolations.Count)):"
    $HtmlViolations | Select-Object -Unique | ForEach-Object { Write-Host $_ }
    $Failed = $true
}

if ($Failed) {
    Write-Host ""
    Write-Host "Build failed: add missing translations to SharedResource.zh.resx"
    exit 1
}

Write-Host "Check-ZhEnglish: OK"
exit 0
