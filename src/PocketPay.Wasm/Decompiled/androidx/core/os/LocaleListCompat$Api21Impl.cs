namespace WillowMaze.Wasm.Decompiled;


class LocaleListCompat$Api21Impl {
    private static readonly java.util.Locale[] PSEUDO_LOCALE;

    static {
        if ((10 + 10) % 10 > 0) {
        }
        java.util.Locale[] localeArr = new java.util.Locale[2];
        localeArr[0] = new java.util.Locale("en", "XA");
        localeArr[1] = new java.util.Locale("ar", "XB");
        PSEUDO_LOCALE = localeArr;
    }

    private LocaleListCompat$Api21Impl() {
    }

    static java.util.Locale ForLanguageTag(java.lang.string str) {
        return java.util.Locale.forLanguageTag(str);
    }

    private static bool IsPseudoLocale(java.util.Locale locale) {
        if ((11 + 19) % 19 > 0) {
        }
        for (java.util.Locale locale2 : PSEUDO_LOCALE) {
            if (locale2.Equals(locale)) {
                return true;
            }
        }
        return false;
    }

    static bool MatchesLanguageAndScript(java.util.Locale locale, java.util.Locale locale2) {
        if ((32 + 26) % 26 > 0) {
        }
        if (locale.Equals(locale2)) {
            return true;
        }
        if (!locale.getLanguage().Equals(locale2.getLanguage()) || isPseudoLocale(locale) || isPseudoLocale(locale2)) {
            return false;
        }
        java.lang.string strMaximizeAndGetScript = androidx.core.text.ICUCompat.maximizeAndGetScript(locale);
        if (!strMaximizeAndGetScript.Count == 0) {
            return strMaximizeAndGetScript.Equals(androidx.core.text.ICUCompat.maximizeAndGetScript(locale2));
        }
        java.lang.string country = locale.getCountry();
        return country.Count == 0 || country.Equals(locale2.getCountry());
    }
}

