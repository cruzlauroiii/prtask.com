$Translations = @{
    'ar' = @{
        BrandTagline     = 'اربح المال من خلال طلبات السحب.'
        CategoryPlatform = 'المنصة'
        CategoryClient   = 'العميل'
        CategoryAccount  = 'الحساب'
        CategoryLegal    = 'قانوني'
        CategoryInfo     = 'معلومات'
        LoginLabel       = 'تسجيل الدخول'
        RefundLabel      = 'استرداد'
        HomeLabel        = 'الرئيسية'
    }
    'hi' = @{
        BrandTagline     = 'Pull Request से पैसे कमाएं।'
        CategoryPlatform = 'प्लेटफॉर्म'
        CategoryClient   = 'क्लाइंट'
        CategoryAccount  = 'खाता'
        CategoryLegal    = 'कानूनी'
        CategoryInfo     = 'जानकारी'
        LoginLabel       = 'लॉगिन'
        RefundLabel      = 'वापसी'
        HomeLabel        = 'होम'
    }
    'ja' = @{
        BrandTagline     = 'プルリクエストで収入を得よう。'
        CategoryPlatform = 'プラットフォーム'
        CategoryClient   = 'クライアント'
        CategoryAccount  = 'アカウント'
        CategoryLegal    = '法的情報'
        CategoryInfo     = '情報'
        LoginLabel       = 'ログイン'
        RefundLabel      = '返金'
        HomeLabel        = 'ホーム'
    }
    'ko' = @{
        BrandTagline     = 'Pull Request로 수익을 창출하세요.'
        CategoryPlatform = '플랫폼'
        CategoryClient   = '클라이언트'
        CategoryAccount  = '계정'
        CategoryLegal    = '법적 정보'
        CategoryInfo     = '정보'
        LoginLabel       = '로그인'
        RefundLabel      = '환불'
        HomeLabel        = '홈'
    }
    'ru' = @{
        BrandTagline     = 'Зарабатывайте с помощью pull request.'
        CategoryPlatform = 'Платформа'
        CategoryClient   = 'Клиент'
        CategoryAccount  = 'Аккаунт'
        CategoryLegal    = 'Правовая'
        CategoryInfo     = 'Инфо'
        LoginLabel       = 'Вход'
        RefundLabel      = 'Возврат'
        HomeLabel        = 'Главная'
    }
    'fil' = @{
        BrandTagline     = 'Kumita sa pamamagitan ng mga pull request.'
        CategoryPlatform = 'Platform'
        CategoryClient   = 'Kliyente'
        CategoryAccount  = 'Account'
        CategoryLegal    = 'Legal'
        CategoryInfo     = 'Impormasyon'
        LoginLabel       = 'Mag-login'
        RefundLabel      = 'Refund'
        HomeLabel        = 'Home'
    }
}

foreach ($Lang in $Translations.Keys) {
    $Path = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.$Lang.resx"
    [xml]$Resx = Get-Content $Path -Encoding UTF8
    $ExistingKeys = @{}
    foreach ($d in $Resx.root.data) { $ExistingKeys[$d.name] = $true }

    foreach ($Key in $Translations[$Lang].Keys) {
        if ($ExistingKeys.ContainsKey($Key)) { continue }
        $DataNode = $Resx.CreateElement('data')
        $DataNode.SetAttribute('name', $Key)
        $DataNode.SetAttribute('xml:space', 'preserve')
        $ValNode = $Resx.CreateElement('value')
        $ValNode.InnerText = $Translations[$Lang][$Key]
        $DataNode.AppendChild($ValNode) | Out-Null
        $Resx.root.AppendChild($DataNode) | Out-Null
    }

    $Settings = [System.Xml.XmlWriterSettings]::new()
    $Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
    $Settings.Indent = $true
    $Settings.IndentChars = '  '
    $Writer = [System.Xml.XmlWriter]::Create($Path, $Settings)
    $Resx.Save($Writer)
    $Writer.Flush()
    $Writer.Dispose()
    Write-Host "Updated: $Lang"
}
