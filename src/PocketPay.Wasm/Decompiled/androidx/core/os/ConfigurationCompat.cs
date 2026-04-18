namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigurationCompat {
    private ConfigurationCompat() {
    }

    public static androidx.core.os.LocaleListCompat GetLocales(android.content.res.Configuration configuration) {
        return androidx.core.os.LocaleListCompat.wrap(androidx.core.os.ConfigurationCompat$Api24Impl.getLocales(configuration));
    }

    public static void SetLocales(android.content.res.Configuration configuration, androidx.core.os.LocaleListCompat localeListCompat) {
        androidx.core.os.ConfigurationCompat$Api24Impl.setLocales(configuration, localeListCompat);
    }
}

