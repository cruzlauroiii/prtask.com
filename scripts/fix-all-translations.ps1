[Console]::OutputEncoding = [System.Text.Encoding]::UTF8
$ResxDir = "C:\work\prtask.com\src\PrTask.SharedUI\Resources"

function UpdateResx {
    param([string]$Lang, [hashtable]$Changes)
    $File = "$ResxDir\SharedResource.$Lang.resx"
    $Xml = [xml][System.IO.File]::ReadAllText($File, [System.Text.Encoding]::UTF8)
    $Modified = $false
    foreach ($Node in $Xml.root.data) {
        if ($Changes.ContainsKey($Node.name)) {
            $NewVal = $Changes[$Node.name]
            if ($Node.value -ne $NewVal) {
                $Node.value = $NewVal
                $Modified = $true
                Write-Host "  [$Lang] $($Node.name) updated"
            }
        }
    }
    if ($Modified) {
        $Settings = [System.Xml.XmlWriterSettings]::new()
        $Settings.Indent = $true
        $Settings.Encoding = [System.Text.Encoding]::UTF8
        $Writer = [System.Xml.XmlWriter]::Create($File, $Settings)
        $Xml.Save($Writer)
        $Writer.Close()
    }
}

function ReplaceInResx {
    param([string]$Lang, [string]$Pattern, [string]$Replacement)
    $File = "$ResxDir\SharedResource.$Lang.resx"
    $Xml = [xml][System.IO.File]::ReadAllText($File, [System.Text.Encoding]::UTF8)
    $Modified = $false
    foreach ($Node in $Xml.root.data) {
        $NewVal = [regex]::Replace($Node.value, $Pattern, $Replacement)
        if ($NewVal -ne $Node.value) {
            Write-Host "  [$Lang] $($Node.name): USD replaced"
            $Node.value = $NewVal
            $Modified = $true
        }
    }
    if ($Modified) {
        $Settings = [System.Xml.XmlWriterSettings]::new()
        $Settings.Indent = $true
        $Settings.Encoding = [System.Text.Encoding]::UTF8
        $Writer = [System.Xml.XmlWriter]::Create($File, $Settings)
        $Xml.Save($Writer)
        $Writer.Close()
    }
}

Write-Host "=== Fixing zh.resx ==="
UpdateResx "zh" @{
    "CreateTaskBountyLabel" = "赏金金额 (美元)"
    "PricingFaqAnswer3" = "所有交易均以美元计价。"
    "TermsPaymentDescription" = "当客户批准拉取请求时，系统通过其注册的付款方式自动收取悬赏金金额。悬赏金全额随后支付给开发者。所有交易以美元计价。平台不收取任何费用。"
    "PricingFaqCurrencyAnswer" = "所有交易均以美元进行。"
    "DownloadIosHeading" = "苹果系统"
}

Write-Host "=== Expanding KYC in all languages ==="
UpdateResx "ar" @{
    "SettingsKycHeading" = "اعرف عميلك - التحقق من الهوية"
    "SettingsKycSubmitButton" = "إرسال التحقق من الهوية"
}
UpdateResx "de" @{
    "SettingsKycHeading" = "Kenne-deinen-Kunden - Identitaetsverifizierung"
    "SettingsKycSubmitButton" = "Identitaetsverifizierung einreichen"
    "HowItWorksWorkflow2Heading" = "Kenne-deinen-Kunden-Verifizierung"
    "HowItWorksWorkflow2LinkText" = "Einstellungen - Kunden-Verifizierung"
}
UpdateResx "es" @{
    "SettingsKycHeading" = "Conozca a su cliente - Verificacion de identidad"
    "SettingsKycSubmitButton" = "Enviar verificacion de identidad"
}
UpdateResx "fil" @{
    "SettingsKycHeading" = "Kilalanin ang Iyong Kliyente - Pag-verify ng Pagkakakilanlan"
    "SettingsKycSubmitButton" = "Isumite ang Verification ng Pagkakakilanlan"
    "HowItWorksWorkflow2Heading" = "Kilalanin ang Iyong Kliyente - Pag-verify ng Pagkakakilanlan"
    "HowItWorksWorkflow2LinkText" = "Settings - Kilalanin ang Kliyente"
    "SettingsKycDocumentIdLabel" = "Numero ng Document Identification"
    "SettingsKycNationalIdLabel" = "National Identification"
}
UpdateResx "fr" @{
    "SettingsKycHeading" = "Connaissez votre client - Verification d'identite"
    "SettingsKycSubmitButton" = "Soumettre la verification d'identite"
}
UpdateResx "hi" @{
    "SettingsKycHeading" = "अपने ग्राहक को जानें - पहचान सत्यापन"
    "SettingsKycSubmitButton" = "पहचान सत्यापन जमा करें"
}
UpdateResx "id" @{
    "SettingsKycHeading" = "Kenali Pelanggan Anda - Verifikasi Identitas"
    "SettingsKycSubmitButton" = "Kirim Verifikasi Identitas"
}
UpdateResx "it" @{
    "SettingsKycHeading" = "Conosci il tuo cliente - Verifica dell identita"
    "SettingsKycSubmitButton" = "Invia verifica identita"
}
UpdateResx "ja" @{
    "SettingsKycHeading" = "顧客確認 - 本人確認"
    "SettingsKycSubmitButton" = "本人確認を送信"
}
UpdateResx "ko" @{
    "SettingsKycHeading" = "고객 확인 - 신원 확인"
    "SettingsKycSubmitButton" = "신원 확인 제출"
}
UpdateResx "nl" @{
    "SettingsKycHeading" = "Ken uw klant - Identiteitsverificatie"
    "SettingsKycSubmitButton" = "Identiteitsverificatie indienen"
}
UpdateResx "pt" @{
    "SettingsKycHeading" = "Conheca seu cliente - Verificacao de identidade"
    "SettingsKycSubmitButton" = "Enviar verificacao de identidade"
}
UpdateResx "ru" @{
    "SettingsKycHeading" = "Знай своего клиента - Верификация личности"
    "SettingsKycSubmitButton" = "Отправить верификацию личности"
}
UpdateResx "tr" @{
    "SettingsKycHeading" = "Musterinizi Taniyin - Kimlik Dogrulama"
    "SettingsKycSubmitButton" = "Kimlik Dogrulamayi Gonder"
}

Write-Host "=== Expanding USD in all languages ==="
ReplaceInResx "ar" '\(USD\)' '(دولار أمريكي)'
ReplaceInResx "de" '\(USD\)' '(US-Dollar)'
ReplaceInResx "es" '\(USD\)' '(Dolar estadounidense)'
ReplaceInResx "fil" '\(USD\)' '(Dolyar ng US)'
ReplaceInResx "fr" '\(USD\)' '(Dollar americain)'
ReplaceInResx "hi" '\(USD\)' '(अमेरिकी डॉलर)'
ReplaceInResx "id" '\(USD\)' '(Dolar AS)'
ReplaceInResx "it" '\(USD\)' '(Dollaro americano)'
ReplaceInResx "ja" '\(USD\)' '(米ドル)'
ReplaceInResx "ko" '\(USD\)' '(미국 달러)'
ReplaceInResx "nl" '\(USD\)' '(Amerikaanse dollar)'
ReplaceInResx "pt" '\(USD\)' '(Dolar americano)'
ReplaceInResx "ru" '\(USD\)' '(Доллар США)'
ReplaceInResx "tr" '\(USD\)' '(ABD Dolari)'

Write-Host "=== Expanding iOS in non-zh languages ==="
UpdateResx "ar" @{
    "DownloadIosHeading" = "نظام تشغيل آيفون"
    "DownloadIosRequirements" = "نظام iOS 15 أو أعلى، 50 ميغابايت من المساحة المتاحة"
}
UpdateResx "de" @{
    "DownloadIosHeading" = "iPhone-Betriebssystem"
    "DownloadIosRequirements" = "iPhone OS 15 oder hoeher, 50 MB verfuegbarer Speicher"
}
UpdateResx "es" @{
    "DownloadIosHeading" = "Sistema operativo iPhone"
    "DownloadIosRequirements" = "iPhone OS 15 o superior, 50 MB de almacenamiento disponible"
}
UpdateResx "fil" @{
    "DownloadIosHeading" = "iPhone Operating System"
    "DownloadIosRequirements" = "iPhone OS 15 o mas bago, 50 MB na available na storage"
}
UpdateResx "fr" @{
    "DownloadIosHeading" = "Systeme d'exploitation iPhone"
    "DownloadIosRequirements" = "iPhone OS 15 ou superieur, 50 Mo d'espace disponible"
}
UpdateResx "hi" @{
    "DownloadIosHeading" = "आईफोन ऑपरेटिंग सिस्टम"
    "DownloadIosRequirements" = "आईफोन OS 15 या उससे अधिक, 50 MB उपलब्ध स्टोरेज"
}
UpdateResx "id" @{
    "DownloadIosHeading" = "Sistem Operasi iPhone"
    "DownloadIosRequirements" = "iPhone OS 15 atau lebih tinggi, 50 MB penyimpanan tersedia"
}
UpdateResx "it" @{
    "DownloadIosHeading" = "Sistema operativo iPhone"
    "DownloadIosRequirements" = "iPhone OS 15 o superiore, 50 MB di spazio disponibile"
}
UpdateResx "ja" @{
    "DownloadIosHeading" = "iPhoneオペレーティングシステム"
    "DownloadIosRequirements" = "iPhone OS 15以上、利用可能なストレージ50 MB"
}
UpdateResx "ko" @{
    "DownloadIosHeading" = "아이폰 운영 체제"
    "DownloadIosRequirements" = "아이폰 OS 15 이상, 50MB 이상의 여유 공간"
}
UpdateResx "nl" @{
    "DownloadIosHeading" = "iPhone-besturingssysteem"
    "DownloadIosRequirements" = "iPhone OS 15 of hoger, 50 MB beschikbare opslag"
}
UpdateResx "pt" @{
    "DownloadIosHeading" = "Sistema operacional iPhone"
    "DownloadIosRequirements" = "iPhone OS 15 ou superior, 50 MB de armazenamento disponivel"
}
UpdateResx "ru" @{
    "DownloadIosHeading" = "Операционная система iPhone"
    "DownloadIosRequirements" = "iPhone OS 15 или выше, 50 МБ свободного места"
}
UpdateResx "tr" @{
    "DownloadIosHeading" = "iPhone Isletim Sistemi"
    "DownloadIosRequirements" = "iPhone OS 15 veya uzeri, 50 MB kullanilabilir depolama"
}

Write-Host "=== Expanding ID in non-zh languages ==="
UpdateResx "ar" @{ "SubmitPrUserIdLabel" = "معرّف المستخدم الخاص بك" }
UpdateResx "de" @{
    "SubmitPrUserIdLabel" = "Ihre Benutzerkennung"
    "SettingsKycDocumentIdLabel" = "Dokumenten-Identifikationsnummer"
}
UpdateResx "es" @{ "SubmitPrUserIdLabel" = "Tu identificacion de usuario" }
UpdateResx "fil" @{ "SubmitPrUserIdLabel" = "Ang Iyong User Identification" }
UpdateResx "fr" @{ "SubmitPrUserIdLabel" = "Votre identifiant utilisateur" }
UpdateResx "hi" @{ "SubmitPrUserIdLabel" = "आपकी उपयोगकर्ता पहचान संख्या" }
UpdateResx "id" @{ "SubmitPrUserIdLabel" = "Identifikasi Pengguna Anda" }
UpdateResx "it" @{ "SubmitPrUserIdLabel" = "Il tuo identificativo utente" }
UpdateResx "ja" @{ "SubmitPrUserIdLabel" = "ユーザー識別番号" }
UpdateResx "ko" @{ "SubmitPrUserIdLabel" = "사용자 식별 번호" }
UpdateResx "nl" @{ "SubmitPrUserIdLabel" = "Uw gebruikersidentificatie" }
UpdateResx "pt" @{ "SubmitPrUserIdLabel" = "Sua identificacao de usuario" }
UpdateResx "ru" @{ "SubmitPrUserIdLabel" = "Ваш идентификатор пользователя" }
UpdateResx "tr" @{ "SubmitPrUserIdLabel" = "Kullanici Kimliginiz" }

Write-Host "=== Adding USD pattern to Check-ZhEnglish.ps1 ==="
$CheckFile = "C:\work\prtask.com\scripts\Check-ZhEnglish.ps1"
$CheckContent = [System.IO.File]::ReadAllText($CheckFile, [System.Text.Encoding]::UTF8)
if ($CheckContent -notmatch "\\bUSD\\b") {
    $OldLine = "    @{ Pattern = '\bWithdrawal\b';"
    $NewLine = "    @{ Pattern = '\bUSD\b';          Label = 'USD -> 美元' }," + "`n" + "    @{ Pattern = '\bWithdrawal\b';"
    $NewContent = $CheckContent.Replace($OldLine, $NewLine)
    [System.IO.File]::WriteAllText($CheckFile, $NewContent, [System.Text.Encoding]::UTF8)
    Write-Host "  Added USD pattern"
} else {
    Write-Host "  USD pattern already present"
}

Write-Host "=== All done ==="
