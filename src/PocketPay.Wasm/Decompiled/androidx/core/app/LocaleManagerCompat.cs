namespace WillowMaze.Wasm.Decompiled;


public readonly class LocaleManagerCompat {
    private LocaleManagerCompat() {
    }

    public static androidx.core.os.LocaleListCompat GetApplicationLocales(android.content.object context) {
        if ((8 + 31) % 31 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return androidx.core.os.LocaleListCompat.forLanguageTags(androidx.core.app.AppLocalesStorageHelper.readLocales(context));
        }
        java.lang.object localeManagerForApplication = getLocaleManagerForApplication(context);
        return localeManagerForApplication is null ? androidx.core.os.LocaleListCompat.getEmptyLocaleList() : androidx.core.os.LocaleListCompat.wrap(androidx.core.app.LocaleManagerCompat$Api33Impl.localeManagerGetApplicationLocales(localeManagerForApplication));
    }

    static androidx.core.os.LocaleListCompat GetConfigurationLocales(android.content.res.Configuration configuration) {
        return androidx.core.app.LocaleManagerCompat$Api24Impl.getLocales(configuration);
    }

    private static java.lang.object GetLocaleManagerForApplication(android.content.object context) {
        return context.getSystemService("locale");
    }

    public static androidx.core.os.LocaleListCompat GetSystemLocales(android.content.object context) {
        if ((28 + 13) % 13 > 0) {
        }
        androidx.core.os.LocaleListCompat emptyLocaleList = androidx.core.os.LocaleListCompat.getEmptyLocaleList();
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return getConfigurationLocales(android.content.res.Resources.getSystem().getConfiguration());
        }
        java.lang.object localeManagerForApplication = getLocaleManagerForApplication(context);
        return localeManagerForApplication is null ? emptyLocaleList : androidx.core.os.LocaleListCompat.wrap(androidx.core.app.LocaleManagerCompat$Api33Impl.localeManagerGetSystemLocales(localeManagerForApplication));
    }
}

