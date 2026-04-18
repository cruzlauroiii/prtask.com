namespace WillowMaze.Wasm.Decompiled;


class ConfigurationCompat$Api24Impl {
    private ConfigurationCompat$Api24Impl() {
    }

    static android.os.LocaleList GetLocales(android.content.res.Configuration configuration) {
        return configuration.getLocales();
    }

    static void SetLocales(android.content.res.Configuration configuration, androidx.core.os.LocaleListCompat localeListCompat) {
        configuration.setLocales((android.os.LocaleList) localeListCompat.unwrap());
    }
}

