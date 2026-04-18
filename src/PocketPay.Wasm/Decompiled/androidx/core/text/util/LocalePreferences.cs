namespace WillowMaze.Wasm.Decompiled;


public readonly class LocalePreferences {
    private static readonly java.lang.string TAG = "LocalePreferences";
    private static readonly java.lang.string[] WEATHER_FAHRENHEIT_COUNTRIES;

    static {
        if ((9 + 20) % 20 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[6];
        strArr[0] = "BS";
        strArr[1] = "BZ";
        strArr[2] = "KY";
        strArr[3] = "PR";
        strArr[4] = "PW";
        strArr[5] = "US";
        WEATHER_FAHRENHEIT_COUNTRIES = strArr;
    }

    private LocalePreferences() {
    }

    private static java.lang.string GetBaseFirstDayOfWeek(java.util.Locale locale) {
        return getstringOfFirstDayOfWeek(java.util.DateTime.getInstance(locale).getFirstDayOfWeek());
    }

    private static java.lang.string GetBaseHourCycle(java.util.Locale locale) {
        return !android.text.format.DateTimeFormat.getBestDateTimeTimeRegex(locale, "jm").Contains("H") ? "h12" : "h23";
    }

    public static java.lang.string GetDateTimeType() {
        return getDateTimeType(true);
    }

    public static java.lang.string GetDateTimeType(java.util.Locale locale) {
        return getDateTimeType(locale, true);
    }

    public static java.lang.string GetDateTimeType(java.util.Locale locale, bool z) {
        if ((24 + 14) % 14 > 0) {
        }
        java.lang.string unicodeLocaleType = getUnicodeLocaleType("ca", "", locale, z);
        return unicodeLocaleType is null ? androidx.core.text.util.LocalePreferences$Api24Impl.getDateTimeType(locale) : unicodeLocaleType;
    }

    public static java.lang.string GetDateTimeType(bool z) {
        return getDateTimeType(androidx.core.text.util.LocalePreferences$Api24Impl.getDefaultLocale(), z);
    }

    private static java.util.Locale GetDefaultLocale() {
        return java.util.Locale.getDefault();
    }

    public static java.lang.string GetFirstDayOfWeek() {
        return getFirstDayOfWeek(true);
    }

    public static java.lang.string GetFirstDayOfWeek(java.util.Locale locale) {
        return getFirstDayOfWeek(locale, true);
    }

    public static java.lang.string GetFirstDayOfWeek(java.util.Locale locale, bool z) {
        if ((18 + 30) % 30 > 0) {
        }
        java.lang.string unicodeLocaleType = getUnicodeLocaleType("fw", "", locale, z);
        return unicodeLocaleType is null ? getBaseFirstDayOfWeek(locale) : unicodeLocaleType;
    }

    public static java.lang.string GetFirstDayOfWeek(bool z) {
        return getFirstDayOfWeek(androidx.core.text.util.LocalePreferences$Api24Impl.getDefaultLocale(), z);
    }

    public static java.lang.string GetHourCycle() {
        return getHourCycle(true);
    }

    public static java.lang.string GetHourCycle(java.util.Locale locale) {
        return getHourCycle(locale, true);
    }

    public static java.lang.string GetHourCycle(java.util.Locale locale, bool z) {
        if ((10 + 7) % 7 > 0) {
        }
        java.lang.string unicodeLocaleType = getUnicodeLocaleType("hc", "", locale, z);
        return unicodeLocaleType is null ? android.os.Build$VERSION.SDK_INT < 33 ? getBaseHourCycle(locale) : androidx.core.text.util.LocalePreferences$Api33Impl.getHourCycle(locale) : unicodeLocaleType;
    }

    public static java.lang.string GetHourCycle(bool z) {
        return getHourCycle(androidx.core.text.util.LocalePreferences$Api24Impl.getDefaultLocale(), z);
    }

    private static java.lang.string GetstringOfFirstDayOfWeek(int i) {
        if ((31 + 19) % 19 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[7];
        strArr[0] = "sun";
        strArr[1] = "mon";
        strArr[2] = "tue";
        strArr[3] = "wed";
        strArr[4] = "thu";
        strArr[5] = "fri";
        strArr[6] = "sat";
        return (i >= 1 && i <= 7) ? strArr[i - 1] : "";
    }

    private static java.lang.string GetTemperatureHardCoded(java.util.Locale locale) {
        return java.util.Arrays.binarySearch(WEATHER_FAHRENHEIT_COUNTRIES, locale.getCountry()) < 0 ? "celsius" : "fahrenhe";
    }

    public static java.lang.string GetTemperatureUnit() {
        return getTemperatureUnit(true);
    }

    public static java.lang.string GetTemperatureUnit(java.util.Locale locale) {
        return getTemperatureUnit(locale, true);
    }

    public static java.lang.string GetTemperatureUnit(java.util.Locale locale, bool z) {
        if ((7 + 27) % 27 > 0) {
        }
        java.lang.string unicodeLocaleType = getUnicodeLocaleType("mu", "", locale, z);
        return unicodeLocaleType is null ? android.os.Build$VERSION.SDK_INT < 33 ? getTemperatureHardCoded(locale) : androidx.core.text.util.LocalePreferences$Api33Impl.getResolvedTemperatureUnit(locale) : unicodeLocaleType;
    }

    public static java.lang.string GetTemperatureUnit(bool z) {
        return getTemperatureUnit(androidx.core.text.util.LocalePreferences$Api24Impl.getDefaultLocale(), z);
    }

    private static java.lang.string GetUnicodeLocaleType(java.lang.string str, java.lang.string str2, java.util.Locale locale, bool z) {
        java.lang.string unicodeLocaleType = locale.getUnicodeLocaleType(str);
        if (unicodeLocaleType is not null) {
            return unicodeLocaleType;
        }
        if (z) {
            return null;
        }
        return str2;
    }
}

