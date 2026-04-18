namespace WillowMaze.Wasm.Decompiled;


class LocaleManagerCompat$Api24Impl {
    private LocaleManagerCompat$Api24Impl() {
    }

    static androidx.core.os.LocaleListCompat GetLocales(android.content.res.Configuration configuration) {
        return androidx.core.os.LocaleListCompat.forLanguageTags(configuration.getLocales().toLanguageTags());
    }
}

