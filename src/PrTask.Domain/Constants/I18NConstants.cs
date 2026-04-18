using System.Collections.Frozen;

namespace PrTask.Domain.Constants;
public static class I18NConstants
{
    public const string LanguageCodeEnglish = "en";
    public const string LanguageCodeEnglishUpper = "EN";
    public const string LanguageCodeChinese = "zh";
    public const string LanguageCodeJapanese = "ja";
    public const string LanguageCodeGerman = "de";
    public const string LanguageCodeHindi = "hi";
    public const string LanguageCodeFrench = "fr";
    public const string LanguageCodePortuguese = "pt";
    public const string LanguageCodeItalian = "it";
    public const string LanguageCodeRussian = "ru";
    public const string LanguageCodeKorean = "ko";
    public const string LanguageCodeSpanish = "es";
    public const string LanguageCodeIndonesian = "id";
    public const string LanguageCodeDutch = "nl";
    public const string LanguageCodeTurkish = "tr";
    public const string LanguageCodeFilipino = "fil";
    public const string LanguageCodeArabic = "ar";
    public const string LabelEnglish = "EN English";
    public const string LabelChinese = "CN \u4e2d\u6587";
    public const string LabelJapanese = "JP \u65e5\u672c\u8a9e";
    public const string LabelGerman = "DE Deutsch";
    public const string LabelHindi = "IN \u0939\u093f\u0928\u094d\u0926\u0940";
    public const string LabelFrench = "FR Fran\u00e7ais";
    public const string LabelPortuguese = "BR Portugu\u00eas";
    public const string LabelItalian = "IT Italiano";
    public const string LabelRussian = "RU \u0420\u0443\u0441\u0441\u043a\u0438\u0439";
    public const string LabelKorean = "KR \ud55c\uad6d\uc5b4";
    public const string LabelSpanish = "ES Espa\u00f1ol";
    public const string LabelIndonesian = "ID Bahasa";
    public const string LabelDutch = "NL Nederlands";
    public const string LabelTurkish = "TR T\u00fcrk\u00e7e";
    public const string LabelFilipino = "PH Filipino";
    public const string LabelArabic = "SA \u0627\u0644\u0639\u0631\u0628\u064a\u0629";
    public const string LocalStorageKey = "prtask-language";
    public const string JsGetLanguage = "prtaskGetLanguage";
    public const string JsSetLanguage = "prtaskSetLanguage";
    public const string ResourcesPath = "";
    public const int LanguageCount = 16;
    public const string NavLabelPlatform = "Platform";
    public const string NavLabelClient = "Client";
    public const string NavLabelAccount = "Account";
    public const string NavLabelInfo = "Info";
    public const string NavLabelLegal = "Legal";
    public const string NavLabelLanguage = "Language";
    public const string NavLabelTheme = "Theme";
    public const string NavLabelLight = "Light";
    public const string NavLabelDark = "Dark";
    public const string NavLabelSystem = "System";
    public static readonly (string Code, string Label)[] AllLanguages =
    [
        (LanguageCodeEnglish, LabelEnglish),
        (LanguageCodeChinese, LabelChinese),
        (LanguageCodeSpanish, LabelSpanish),
        (LanguageCodeJapanese, LabelJapanese),
        (LanguageCodeGerman, LabelGerman),
        (LanguageCodeFrench, LabelFrench),
        (LanguageCodePortuguese, LabelPortuguese),
        (LanguageCodeHindi, LabelHindi),
        (LanguageCodeKorean, LabelKorean),
        (LanguageCodeItalian, LabelItalian),
        (LanguageCodeRussian, LabelRussian),
        (LanguageCodeIndonesian, LabelIndonesian),
        (LanguageCodeDutch, LabelDutch),
        (LanguageCodeTurkish, LabelTurkish),
        (LanguageCodeFilipino, LabelFilipino),
        (LanguageCodeArabic, LabelArabic),
    ];
    public static readonly FrozenDictionary<string, string[]> NavLabels = new Dictionary<string, string[]>(StringComparer.Ordinal)
    {
        [LanguageCodeEnglish] = [NavLabelPlatform, NavLabelClient, NavLabelAccount, NavLabelInfo, NavLabelLegal, NavLabelLanguage, NavLabelTheme, NavLabelLight, NavLabelDark, NavLabelSystem],
        [LanguageCodeChinese] = ["\u5e73\u53f0", "\u5ba2\u6237", "\u8d26\u6237", "\u4fe1\u606f", "\u6cd5\u5f8b", "\u8bed\u8a00", "\u4e3b\u9898", "\u6d45\u8272", "\u6df1\u8272", "\u7cfb\u7edf"],
        [LanguageCodeSpanish] = ["Plataforma", "Cliente", "Cuenta", "Info", "Legal", "Idioma", "Tema", "Claro", "Oscuro", "Sistema"],
        [LanguageCodeJapanese] = ["\u30d7\u30e9\u30c3\u30c8\u30d5\u30a9\u30fc\u30e0", "\u30af\u30e9\u30a4\u30a2\u30f3\u30c8", "\u30a2\u30ab\u30a6\u30f3\u30c8", "\u60c5\u5831", "\u6cd5\u7684", "\u8a00\u8a9e", "\u30c6\u30fc\u30de", "\u30e9\u30a4\u30c8", "\u30c0\u30fc\u30af", "\u30b7\u30b9\u30c6\u30e0"],
        [LanguageCodeGerman] = ["Plattform", "Kunde", "Konto", "Info", "Rechtliches", "Sprache", "Design", "Hell", "Dunkel", "System"],
        [LanguageCodeFrench] = ["Plateforme", "Client", "Compte", "Info", "L\u00e9gal", "Langue", "Th\u00e8me", "Clair", "Sombre", "Syst\u00e8me"],
        [LanguageCodePortuguese] = ["Plataforma", "Cliente", "Conta", "Info", "Legal", "Idioma", "Tema", "Claro", "Escuro", "Sistema"],
        [LanguageCodeHindi] = ["\u092a\u094d\u0932\u0947\u091f\u092b\u093c\u0949\u0930\u094d\u092e", "\u0915\u094d\u0932\u093e\u0907\u0902\u091f", "\u0916\u093e\u0924\u093e", "\u091c\u093e\u0928\u0915\u093e\u0930\u0940", "\u0915\u093e\u0928\u0942\u0928\u0940", "\u092d\u093e\u0937\u093e", "\u0925\u0940\u092e", "\u0939\u0932\u094d\u0915\u093e", "\u0917\u0939\u0930\u093e", "\u0938\u093f\u0938\u094d\u091f\u092e"],
        [LanguageCodeKorean] = ["\ud50c\ub7ab\ud3fc", "\ud074\ub77c\uc774\uc5b8\ud2b8", "\uacc4\uc815", "\uc815\ubcf4", "\ubc95\ub960", "\uc5b8\uc5b4", "\ud14c\ub9c8", "\ub77c\uc774\ud2b8", "\ub2e4\ud06c", "\uc2dc\uc2a4\ud15c"],
        [LanguageCodeItalian] = ["Piattaforma", "Cliente", "Account", "Info", "Legale", "Lingua", "Tema", "Chiaro", "Scuro", "Sistema"],
        [LanguageCodeRussian] = ["\u041f\u043b\u0430\u0442\u0444\u043e\u0440\u043c\u0430", "\u041a\u043b\u0438\u0435\u043d\u0442", "\u0410\u043a\u043a\u0430\u0443\u043d\u0442", "\u0418\u043d\u0444\u043e", "\u041f\u0440\u0430\u0432\u043e\u0432\u043e\u0435", "\u042f\u0437\u044b\u043a", "\u0422\u0435\u043c\u0430", "\u0421\u0432\u0435\u0442\u043b\u0430\u044f", "\u0422\u0451\u043c\u043d\u0430\u044f", "\u0421\u0438\u0441\u0442\u0435\u043c\u0430"],
        [LanguageCodeIndonesian] = ["Platform", "Klien", "Akun", "Info", "Hukum", "Bahasa", "Tema", "Terang", "Gelap", "Sistem"],
        [LanguageCodeDutch] = ["Platform", "Klant", "Account", "Info", "Juridisch", "Taal", "Thema", "Licht", "Donker", "Systeem"],
        [LanguageCodeTurkish] = ["Platform", "M\u00fc\u015fteri", "Hesap", "Bilgi", "Yasal", "Dil", "Tema", "A\u00e7\u0131k", "Koyu", "Sistem"],
        [LanguageCodeFilipino] = ["Platform", "Kliyente", "Account", "Impormasyon", "Legal", "Wika", "Tema", "Maliwanag", "Madilim", "Sistema"],
        [LanguageCodeArabic] = ["\u0627\u0644\u0645\u0646\u0635\u0629", "\u0627\u0644\u0639\u0645\u064a\u0644", "\u0627\u0644\u062d\u0633\u0627\u0628", "\u0645\u0639\u0644\u0648\u0645\u0627\u062a", "\u0642\u0627\u0646\u0648\u0646\u064a", "\u0627\u0644\u0644\u063a\u0629", "\u0627\u0644\u0633\u0645\u0629", "\u0641\u0627\u062a\u062d", "\u062f\u0627\u0643\u0646", "\u0627\u0644\u0646\u0638\u0627\u0645"],
    }.ToFrozenDictionary(StringComparer.Ordinal);
    public const string FooterCopyrightEnglish = "&copy; 2026 PrTask. All rights reserved.";
    public static readonly FrozenDictionary<string, string> FooterCopyrightTexts = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        [LanguageCodeChinese] = "\u00a9 \u4e8c\u96f6\u4e8c\u516d \u62c9\u53d6\u8bf7\u6c42\u4efb\u52a1. \u4fdd\u7559\u6240\u6709\u6743\u5229\u3002",
        [LanguageCodeSpanish] = "\u00a9 2026 PrTask. Todos los derechos reservados.",
        [LanguageCodeJapanese] = "\u00a9 2026 PrTask. \u7121\u65ad\u8ee2\u8f09\u7981\u6b62\u3002",
        [LanguageCodeGerman] = "\u00a9 2026 PrTask. Alle Rechte vorbehalten.",
        [LanguageCodeFrench] = "\u00a9 2026 PrTask. Tous droits r\u00e9serv\u00e9s.",
        [LanguageCodePortuguese] = "\u00a9 2026 PrTask. Todos os direitos reservados.",
        [LanguageCodeHindi] = "\u00a9 2026 PrTask. \u0938\u0930\u094d\u0935\u093e\u0927\u093f\u0915\u093e\u0930 \u0938\u0941\u0930\u0915\u094d\u0937\u093f\u0924\u0964",
        [LanguageCodeKorean] = "\u00a9 2026 PrTask. \ubaa8\ub4e0 \uad8c\ub9ac \ubcf4\uc720.",
        [LanguageCodeItalian] = "\u00a9 2026 PrTask. Tutti i diritti riservati.",
        [LanguageCodeRussian] = "\u00a9 2026 PrTask. \u0412\u0441\u0435 \u043f\u0440\u0430\u0432\u0430 \u0437\u0430\u0449\u0438\u0449\u0435\u043d\u044b.",
        [LanguageCodeIndonesian] = "\u00a9 2026 PrTask. Hak cipta dilindungi.",
        [LanguageCodeDutch] = "\u00a9 2026 PrTask. Alle rechten voorbehouden.",
        [LanguageCodeTurkish] = "\u00a9 2026 PrTask. T\u00fcm haklar\u0131 sakl\u0131d\u0131r.",
        [LanguageCodeFilipino] = "\u00a9 2026 PrTask. Lahat ng karapatan ay nakalaan.",
        [LanguageCodeArabic] = "\u00a9 2026 PrTask. \u062c\u0645\u064a\u0639 \u0627\u0644\u062d\u0642\u0648\u0642 \u0645\u062d\u0641\u0648\u0638\u0629.",
    }.ToFrozenDictionary(StringComparer.Ordinal);
    public static readonly string[] NavLinkEnglish =
    [
        "Tasks", "Dashboard", "Leaderboard", "Sprints", "Boards",
        "Create Task", "Payments", "Repository",
        "Login", "Settings", "Download",
        "About", "How It Works", "Pricing",
        "Terms", "Privacy", "Refund", "Acceptable Use", "Cookie Policy", "Licenses", "Accessibility", "DMCA",
    ];
    public static readonly FrozenDictionary<string, string[]> NavLinkLabels = new Dictionary<string, string[]>(StringComparer.Ordinal)
    {
        [LanguageCodeChinese] = ["\u4efb\u52a1", "\u4eea\u8868\u76d8", "\u6392\u884c\u699c", "\u51b2\u523a", "\u770b\u677f", "\u521b\u5efa\u4efb\u52a1", "\u4ed8\u6b3e", "\u4ed3\u5e93", "\u767b\u5f55", "\u8bbe\u7f6e", "\u4e0b\u8f7d", "\u5173\u4e8e", "\u8fd0\u4f5c\u65b9\u5f0f", "\u4ef7\u683c", "\u6761\u6b3e", "\u9690\u79c1", "\u9000\u6b3e", "\u53ef\u63a5\u53d7\u4f7f\u7528\u653f\u7b56", "\u6570\u636e\u5b58\u50a8\u653f\u7b56", "\u8bb8\u53ef\u8bc1", "\u65e0\u969c\u788d\u8bbf\u95ee", "\u7248\u6743\u7533\u8bc9"],
        [LanguageCodeSpanish] = ["Tareas", "Panel", "Clasificaci\u00f3n", "Sprints", "Tableros", "Crear tarea", "Pagos", "Repositorio", "Iniciar sesi\u00f3n", "Configuraci\u00f3n", "Descargar", "Acerca de", "C\u00f3mo funciona", "Precios", "T\u00e9rminos", "Privacidad", "Reembolso", "Uso aceptable", "Pol\u00edtica de cookies", "Licencias", "Accesibilidad", "DMCA"],
        [LanguageCodeJapanese] = ["\u30bf\u30b9\u30af", "\u30c0\u30c3\u30b7\u30e5\u30dc\u30fc\u30c9", "\u30ea\u30fc\u30c0\u30fc\u30dc\u30fc\u30c9", "\u30b9\u30d7\u30ea\u30f3\u30c8", "\u30dc\u30fc\u30c9", "\u30bf\u30b9\u30af\u4f5c\u6210", "\u652f\u6255\u3044", "\u30ea\u30dd\u30b8\u30c8\u30ea", "\u30ed\u30b0\u30a4\u30f3", "\u8a2d\u5b9a", "\u30c0\u30a6\u30f3\u30ed\u30fc\u30c9", "\u6982\u8981", "\u4ed5\u7d44\u307f", "\u6599\u91d1", "\u5229\u7528\u898f\u7d04", "\u30d7\u30e9\u30a4\u30d0\u30b7\u30fc", "\u8fd4\u91d1", "\u5229\u7528\u898f\u5b9a", "Cookie\u30dd\u30ea\u30b7\u30fc", "\u30e9\u30a4\u30bb\u30f3\u30b9", "\u30a2\u30af\u30bb\u30b7\u30d3\u30ea\u30c6\u30a3", "DMCA"],
        [LanguageCodeGerman] = ["Aufgaben", "Dashboard", "Rangliste", "Sprints", "Boards", "Aufgabe erstellen", "Zahlungen", "Repository", "Anmelden", "Einstellungen", "Herunterladen", "\u00dcber uns", "So funktioniert es", "Preise", "AGB", "Datenschutz", "R\u00fcckerstattung", "Nutzungsrichtlinien", "Cookie-Richtlinie", "Lizenzen", "Barrierefreiheit", "DMCA"],
        [LanguageCodeFrench] = ["T\u00e2ches", "Tableau de bord", "Classement", "Sprints", "Tableaux", "Cr\u00e9er une t\u00e2che", "Paiements", "D\u00e9p\u00f4t", "Connexion", "Param\u00e8tres", "T\u00e9l\u00e9charger", "\u00c0 propos", "Comment \u00e7a marche", "Tarifs", "Conditions", "Confidentialit\u00e9", "Remboursement", "Utilisation acceptable", "Politique de cookies", "Licences", "Accessibilit\u00e9", "DMCA"],
        [LanguageCodePortuguese] = ["Tarefas", "Painel", "Ranking", "Sprints", "Quadros", "Criar tarefa", "Pagamentos", "Reposit\u00f3rio", "Entrar", "Configura\u00e7\u00f5es", "Download", "Sobre", "Como funciona", "Pre\u00e7os", "Termos", "Privacidade", "Reembolso", "Uso aceit\u00e1vel", "Pol\u00edtica de Cookies", "Licen\u00e7as", "Acessibilidade", "DMCA"],
        [LanguageCodeHindi] = ["\u0915\u093e\u0930\u094d\u092f", "\u0921\u0948\u0936\u092c\u094b\u0930\u094d\u0921", "\u0932\u0940\u0921\u0930\u092c\u094b\u0930\u094d\u0921", "\u0938\u094d\u092a\u094d\u0930\u093f\u0902\u091f", "\u092c\u094b\u0930\u094d\u0921", "\u0915\u093e\u0930\u094d\u092f \u092c\u0928\u093e\u090f\u0901", "\u092d\u0941\u0917\u0924\u093e\u0928", "\u0930\u093f\u092a\u0949\u091c\u093f\u091f\u0930\u0940", "\u0932\u0949\u0917\u0907\u0928", "\u0938\u0947\u091f\u093f\u0902\u0917\u094d\u0938", "\u0921\u093e\u0909\u0928\u0932\u094b\u0921", "\u0939\u092e\u093e\u0930\u0947 \u092c\u093e\u0930\u0947 \u092e\u0947\u0902", "\u092f\u0939 \u0915\u0948\u0938\u0947 \u0915\u093e\u092e \u0915\u0930\u0924\u093e \u0939\u0948", "\u092e\u0942\u0932\u094d\u092f \u0928\u093f\u0930\u094d\u0927\u093e\u0930\u0923", "\u0936\u0930\u094d\u0924\u0947\u0902", "\u0917\u094b\u092a\u0928\u0940\u092f\u0924\u093e", "\u0930\u093f\u092b\u093c\u0902\u0921", "\u0938\u094d\u0935\u0940\u0915\u093e\u0930\u094d\u092f \u0909\u092a\u092f\u094b\u0917", "\u0915\u0941\u0915\u0940 \u0928\u0940\u0924\u093f", "\u0932\u093e\u0907\u0938\u0947\u0902\u0938", "\u090f\u0915\u094d\u0938\u0947\u0938\u093f\u092c\u093f\u0932\u093f\u091f\u0940", "DMCA"],
        [LanguageCodeKorean] = ["\uc791\uc5c5", "\ub300\uc2dc\ubcf4\ub4dc", "\ub9ac\ub354\ubcf4\ub4dc", "\uc2a4\ud504\ub9b0\ud2b8", "\ubcf4\ub4dc", "\uc791\uc5c5 \ub9cc\ub4e4\uae30", "\uacb0\uc81c", "\uc800\uc7a5\uc18c", "\ub85c\uadf8\uc778", "\uc124\uc815", "\ub2e4\uc6b4\ub85c\ub4dc", "\uc18c\uac1c", "\uc774\uc6a9 \ubc29\ubc95", "\uc694\uae08\uc81c", "\uc774\uc6a9\uc57d\uad00", "\uac1c\uc778\uc815\ubcf4 \ubcf4\ud638", "\ud658\ubd88", "\uc774\uc6a9 \uaddc\uc815", "\ucfe0\ud0a4 \uc815\ucc45", "\ub77c\uc774\uc120\uc2a4", "\uc811\uadfc\uc131", "DMCA"],
        [LanguageCodeItalian] = ["Attivit\u00e0", "Dashboard", "Classifica", "Sprint", "Bacheche", "Crea attivit\u00e0", "Pagamenti", "Repository", "Accedi", "Impostazioni", "Download", "Chi siamo", "Come funziona", "Prezzi", "Termini", "Privacy", "Rimborso", "Uso accettabile", "Politica sui cookie", "Licenze", "Accessibilit\u00e0", "DMCA"],
        [LanguageCodeRussian] = ["\u0417\u0430\u0434\u0430\u0447\u0438", "\u041f\u0430\u043d\u0435\u043b\u044c \u0443\u043f\u0440\u0430\u0432\u043b\u0435\u043d\u0438\u044f", "\u0420\u0435\u0439\u0442\u0438\u043d\u0433", "\u0421\u043f\u0440\u0438\u043d\u0442\u044b", "\u0414\u043e\u0441\u043a\u0438", "\u0421\u043e\u0437\u0434\u0430\u0442\u044c \u0437\u0430\u0434\u0430\u0447\u0443", "\u041f\u043b\u0430\u0442\u0435\u0436\u0438", "\u0420\u0435\u043f\u043e\u0437\u0438\u0442\u043e\u0440\u0438\u0439", "\u0412\u043e\u0439\u0442\u0438", "\u041d\u0430\u0441\u0442\u0440\u043e\u0439\u043a\u0438", "\u0421\u043a\u0430\u0447\u0430\u0442\u044c", "\u041e \u043d\u0430\u0441", "\u041a\u0430\u043a \u044d\u0442\u043e \u0440\u0430\u0431\u043e\u0442\u0430\u0435\u0442", "\u0426\u0435\u043d\u044b", "\u0423\u0441\u043b\u043e\u0432\u0438\u044f", "\u041a\u043e\u043d\u0444\u0438\u0434\u0435\u043d\u0446\u0438\u0430\u043b\u044c\u043d\u043e\u0441\u0442\u044c", "\u0412\u043e\u0437\u0432\u0440\u0430\u0442", "\u0414\u043e\u043f\u0443\u0441\u0442\u0438\u043c\u043e\u0435 \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u043d\u0438\u0435", "\u041f\u043e\u043b\u0438\u0442\u0438\u043a\u0430 cookie", "\u041b\u0438\u0446\u0435\u043d\u0437\u0438\u0438", "\u0414\u043e\u0441\u0442\u0443\u043f\u043d\u043e\u0441\u0442\u044c", "DMCA"],
        [LanguageCodeIndonesian] = ["Tugas", "Dasbor", "Papan Peringkat", "Sprint", "Papan", "Buat Tugas", "Pembayaran", "Repositori", "Masuk", "Pengaturan", "Unduh", "Tentang", "Cara Kerja", "Harga", "Ketentuan", "Privasi", "Pengembalian", "Penggunaan yang Dapat Diterima", "Kebijakan Cookie", "Lisensi", "Aksesibilitas", "DMCA"],
        [LanguageCodeDutch] = ["Taken", "Dashboard", "Klassement", "Sprints", "Borden", "Taak aanmaken", "Betalingen", "Repository", "Inloggen", "Instellingen", "Downloaden", "Over ons", "Hoe het werkt", "Prijzen", "Voorwaarden", "Privacy", "Restitutie", "Acceptabel gebruik", "Cookiebeleid", "Licenties", "Toegankelijkheid", "DMCA"],
        [LanguageCodeTurkish] = ["G\u00f6revler", "Kontrol Paneli", "S\u0131ralama", "Sprint'ler", "Panolar", "G\u00f6rev Olu\u015ftur", "\u00d6demeler", "Depo", "Giri\u015f", "Ayarlar", "\u0130ndir", "Hakk\u0131nda", "Nas\u0131l \u00c7al\u0131\u015f\u0131r", "Fiyatland\u0131rma", "\u015eartlar", "Gizlilik", "\u0130ade", "Kabul Edilebilir Kullan\u0131m", "\u00c7erez Politikas\u0131", "Lisanslar", "Eri\u015filebilirlik", "DMCA"],
        [LanguageCodeFilipino] = ["Mga Gawain", "Dashboard", "Leaderboard", "Mga Sprint", "Mga Board", "Gumawa ng Gawain", "Mga Bayad", "Repositoryo", "Mag-sign In", "Mga Setting", "I-download", "Tungkol", "Paano Gumagana", "Presyo", "Mga Tuntunin", "Privacy", "Refund", "Katanggap-tanggap na Paggamit", "Patakaran sa Cookie", "Mga Lisensya", "Accessibility", "DMCA"],
        [LanguageCodeArabic] = ["\u0627\u0644\u0645\u0647\u0627\u0645", "\u0644\u0648\u062d\u0629 \u0627\u0644\u062a\u062d\u0643\u0645", "\u0644\u0648\u062d\u0629 \u0627\u0644\u0645\u062a\u0635\u062f\u0631\u064a\u0646", "\u0627\u0644\u0633\u0628\u0631\u0646\u062a\u0627\u062a", "\u0627\u0644\u0644\u0648\u062d\u0627\u062a", "\u0625\u0646\u0634\u0627\u0621 \u0645\u0647\u0645\u0629", "\u0627\u0644\u0645\u062f\u0641\u0648\u0639\u0627\u062a", "\u0627\u0644\u0645\u0633\u062a\u0648\u062f\u0639", "\u062a\u0633\u062c\u064a\u0644 \u0627\u0644\u062f\u062e\u0648\u0644", "\u0627\u0644\u0625\u0639\u062f\u0627\u062f\u0627\u062a", "\u062a\u0646\u0632\u064a\u0644", "\u062d\u0648\u0644", "\u0643\u064a\u0641 \u064a\u0639\u0645\u0644", "\u0627\u0644\u0623\u0633\u0639\u0627\u0631", "\u0627\u0644\u0634\u0631\u0648\u0637", "\u0627\u0644\u062e\u0635\u0648\u0635\u064a\u0629", "\u0627\u0633\u062a\u0631\u062f\u0627\u062f", "\u0627\u0644\u0627\u0633\u062a\u062e\u062f\u0627\u0645 \u0627\u0644\u0645\u0642\u0628\u0648\u0644", "\u0633\u064a\u0627\u0633\u0629 \u0645\u0644\u0641\u0627\u062a \u062a\u0639\u0631\u064a\u0641 \u0627\u0644\u0627\u0631\u062a\u0628\u0627\u0637", "\u0627\u0644\u062a\u0631\u0627\u062e\u064a\u0635", "\u0625\u0645\u0643\u0627\u0646\u064a\u0629 \u0627\u0644\u0648\u0635\u0648\u0644", "DMCA"],
    }.ToFrozenDictionary(StringComparer.Ordinal);
    public const string BrandNameEnglish = "PrTask";
    public static readonly FrozenDictionary<string, (string From, string To)[]> LocalizedHtmlStrings = new Dictionary<string, (string, string)[]>(StringComparer.Ordinal)
    {
        [LanguageCodeChinese] =
        [
            ("English", "\u82f1\u8bed"),
            ("Deutsch", "\u5fb7\u8bed"),
            ("Italiano", "\u610f\u5927\u5229\u8bed"),
            ("Bahasa", "\u5370\u5ea6\u5c3c\u897f\u4e9a\u8bed"),
            ("Nederlands", "\u8377\u5170\u8bed"),
            ("Filipino", "\u83f2\u5f8b\u5bbe\u8bed"),
            ("PrTask", "\u62c9\u53d6\u8bf7\u6c42\u4efb\u52a1"),
            ("Not connected", "\u672a\u8fde\u63a5"),
            ("Not verified", "\u672a\u9a8c\u8bc1"),
            ("Connected", "\u5df2\u8fde\u63a5"),
        ],
    }.ToFrozenDictionary(StringComparer.Ordinal);
    public static readonly FrozenDictionary<string, string> LocalizedBrandNames = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        [LanguageCodeChinese] = "\u62c9\u53d6\u8bf7\u6c42\u4efb\u52a1",
        [LanguageCodeJapanese] = "\u30d7\u30eb\u30ea\u30af\u30a8\u30b9\u30c8\u30bf\u30b9\u30af",
        [LanguageCodeKorean] = "\ud480 \ub9ac\ud018\uc2a4\ud2b8 \ud0dc\uc2a4\ud06c",
        [LanguageCodeArabic] = "\u0645\u0647\u0645\u0629 \u0637\u0644\u0628 \u0627\u0644\u0633\u062d\u0628",
        [LanguageCodeHindi] = "\u092a\u0941\u0644 \u0930\u093f\u0915\u094d\u0935\u0947\u0938\u094d\u091f \u091f\u093e\u0938\u094d\u0915",
        [LanguageCodeRussian] = "\u0417\u0430\u0434\u0430\u0447\u0430 \u041f\u0443\u043b \u0420\u0438\u043a\u0432\u0435\u0441\u0442",
    }.ToFrozenDictionary(StringComparer.Ordinal);
    public static readonly FrozenDictionary<string, string> PageTitles = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        [LanguageCodeChinese] = "\u62c9\u53d6\u8bf7\u6c42\u4efb\u52a1 - \u901a\u8fc7\u62c9\u53d6\u8bf7\u6c42\u8d5a\u94b1",
        [LanguageCodeSpanish] = "PrTask - Gana dinero con Pull Requests",
        [LanguageCodeJapanese] = "PrTask - \u30d7\u30eb\u30ea\u30af\u30a8\u30b9\u30c8\u3067\u304a\u91d1\u3092\u7a3c\u3054\u3046",
        [LanguageCodeGerman] = "PrTask - Geld verdienen mit Pull Requests",
        [LanguageCodeFrench] = "PrTask - Gagnez de l\u2019argent avec les Pull Requests",
        [LanguageCodePortuguese] = "PrTask - Ganhe dinheiro com Pull Requests",
        [LanguageCodeHindi] = "PrTask - \u092a\u0941\u0932 \u0930\u093f\u0915\u094d\u0935\u0947\u0938\u094d\u091f \u0938\u0947 \u092a\u0948\u0938\u0947 \u0915\u092e\u093e\u090f\u0902",
        [LanguageCodeKorean] = "PrTask - \ud480 \ub9ac\ud018\uc2a4\ud2b8\ub85c \uc218\uc775 \ucc3d\ucd9c",
        [LanguageCodeItalian] = "PrTask - Guadagna con le Pull Request",
        [LanguageCodeRussian] = "PrTask - \u0417\u0430\u0440\u0430\u0431\u0430\u0442\u044b\u0432\u0430\u0439\u0442\u0435 \u0441 \u043f\u0443\u043b \u0440\u0438\u043a\u0432\u0435\u0441\u0442",
        [LanguageCodeIndonesian] = "PrTask - Hasilkan Uang dengan Pull Request",
        [LanguageCodeDutch] = "PrTask - Verdien geld met Pull Requests",
        [LanguageCodeTurkish] = "PrTask - Pull Request ile Para Kazan\u0131n",
        [LanguageCodeFilipino] = "PrTask - Kumita sa Pull Requests",
        [LanguageCodeArabic] = "PrTask - \u0627\u0643\u0633\u0628 \u0627\u0644\u0645\u0627\u0644 \u0639\u0628\u0631 \u0637\u0644\u0628\u0627\u062a \u0627\u0644\u0633\u062d\u0628",
    }.ToFrozenDictionary(StringComparer.Ordinal);
    public static readonly FrozenDictionary<string, string> PageDescriptions = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        [LanguageCodeChinese] = "\u901a\u8fc7\u63d0\u4ea4\u62c9\u53d6\u8bf7\u6c42\u8d5a\u53d6\u6536\u5165\u3002\u6d4f\u89c8\u4efb\u52a1\uff0c\u63d0\u4ea4\u62c9\u53d6\u8bf7\u6c42\uff0c\u6839\u636e\u590d\u6742\u5ea6\u83b7\u5f97\u62a5\u916c\u3002",
        [LanguageCodeSpanish] = "Gana dinero enviando pull requests. Busca tareas, env\u00eda PRs y cobra seg\u00fan la complejidad.",
        [LanguageCodeJapanese] = "\u30d7\u30eb\u30ea\u30af\u30a8\u30b9\u30c8\u3092\u9001\u4fe1\u3057\u3066\u304a\u91d1\u3092\u7a3c\u3069\u3046\u3002\u30bf\u30b9\u30af\u3092\u95b2\u89a7\u3057\u3001PR \u3092\u63d0\u51fa\u3057\u3001\u8907\u96d1\u3055\u306b\u5fdc\u3058\u3066\u5831\u916c\u3092\u53d7\u3051\u53d6\u308b\u3002",
        [LanguageCodeGerman] = "Verdiene Geld durch das Einreichen von Pull Requests. Durchsuche Aufgaben, reiche PRs ein und werde nach Komplexit\u00e4t bezahlt.",
        [LanguageCodeFrench] = "Gagnez de l\u2019argent en soumettant des pull requests. Parcourez les t\u00e2ches, soumettez des PRs et soyez pay\u00e9 selon la complexit\u00e9.",
        [LanguageCodePortuguese] = "Ganhe dinheiro enviando pull requests. Navegue pelas tarefas, envie PRs e seja pago pela complexidade.",
        [LanguageCodeHindi] = "\u092a\u0941\u0932 \u0930\u093f\u0915\u094d\u0935\u0947\u0938\u094d\u091f \u0938\u092c\u092e\u093f\u091f \u0915\u0930\u0915\u0947 \u092a\u0948\u0938\u0947 \u0915\u092e\u093e\u090f\u0902\u0964 \u0915\u093e\u0930\u094d\u092f \u0926\u0947\u0916\u0947\u0902\u002c PR \u0938\u092c\u092e\u093f\u091f \u0915\u0930\u0947\u0902 \u0914\u0930 \u091c\u091f\u093f\u0932\u0924\u093e \u0915\u0947 \u0906\u0927\u093e\u0930 \u092a\u0930 \u092d\u0941\u0917\u0924\u093e\u0928 \u092a\u093e\u090f\u0902\u0964",
        [LanguageCodeKorean] = "\ud480 \ub9ac\ud018\uc2a4\ud2b8\ub97c \uc81c\ucd9c\ud558\uc5ec \uc218\uc775\uc744 \ucc3d\ucd9c\ud558\uc138\uc694. \uc791\uc5c5\uc744 \ud0d0\uc0c9\ud558\uace0 PR\uc744 \uc81c\ucd9c\ud558\uc5ec \ubcf5\uc7a1\ub3c4\uc5d0 \ub530\ub77c \ubcf4\uc218\ub97c \ubc1b\uc73c\uc138\uc694.",
        [LanguageCodeItalian] = "Guadagna inviando pull request. Sfoglia le attivit\u00e0, invia PR e ricevi pagamenti in base alla complessit\u00e0.",
        [LanguageCodeRussian] = "\u0417\u0430\u0440\u0430\u0431\u0430\u0442\u044b\u0432\u0430\u0439\u0442\u0435\u002c \u043e\u0442\u043f\u0440\u0430\u0432\u043b\u044f\u044f \u043f\u0443\u043b \u0440\u0438\u043a\u0432\u0435\u0441\u0442. \u041f\u0440\u043e\u0441\u043c\u0430\u0442\u0440\u0438\u0432\u0430\u0439\u0442\u0435 \u0437\u0430\u0434\u0430\u0447\u0438\u002c \u043e\u0442\u043f\u0440\u0430\u0432\u043b\u044f\u0439\u0442\u0435 PR \u0438 \u043f\u043e\u043b\u0443\u0447\u0430\u0439\u0442\u0435 \u043e\u043f\u043b\u0430\u0442\u0443 \u0432 \u0437\u0430\u0432\u0438\u0441\u0438\u043c\u043e\u0441\u0442\u0438 \u043e\u0442 \u0441\u043b\u043e\u0436\u043d\u043e\u0441\u0442\u0438.",
        [LanguageCodeIndonesian] = "Hasilkan uang dengan mengirimkan pull request. Jelajahi tugas, kirim PR, dan dibayar berdasarkan kompleksitas.",
        [LanguageCodeDutch] = "Verdien geld door pull requests in te dienen. Bekijk taken, dien PRs in en word betaald op basis van complexiteit.",
        [LanguageCodeTurkish] = "Pull request g\u00f6ndererek para kazan\u0131n. G\u00f6revlere g\u00f6z at\u0131n, PR g\u00f6nderin ve karma\u015f\u0131kl\u0131\u011fa g\u00f6re \u00f6deme al\u0131n.",
        [LanguageCodeFilipino] = "Kumita sa pamamagitan ng pagsusumite ng mga pull request. I-browse ang mga gawain, magsumite ng PRs, at bayarang batay sa kumplikado.",
        [LanguageCodeArabic] = "\u0627\u0643\u0633\u0628 \u0627\u0644\u0645\u0627\u0644 \u0628\u062a\u0642\u062f\u064a\u0645 \u0637\u0644\u0628\u0627\u062a \u0627\u0644\u0633\u062d\u0628. \u062a\u0635\u0641\u062d \u0627\u0644\u0645\u0647\u0627\u0645\u060c \u0642\u062f\u0651\u0645 \u0637\u0644\u0628\u0627\u062a PR\u060c \u0648\u0627\u062d\u0635\u0644 \u0639\u0644\u0649 \u0623\u062c\u0631\u0643 \u0628\u0646\u0627\u0621\u064b \u0639\u0644\u0649 \u0627\u0644\u062a\u0639\u0642\u064a\u062f.",
    }.ToFrozenDictionary(StringComparer.Ordinal);
}
