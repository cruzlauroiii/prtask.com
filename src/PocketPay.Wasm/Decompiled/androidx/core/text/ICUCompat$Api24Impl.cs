namespace WillowMaze.Wasm.Decompiled;


class ICUCompat$Api24Impl {
    private ICUCompat$Api24Impl() {
    }

    static android.icu.util.ULocale AddLikelySubtags(java.lang.object obj) {
        return android.icu.util.ULocale.addLikelySubtags((android.icu.util.ULocale) obj);
    }

    static android.icu.util.ULocale ForLocale(java.util.Locale locale) {
        return android.icu.util.ULocale.forLocale(locale);
    }

    static java.lang.string GetScript(java.lang.object obj) {
        return ((android.icu.util.ULocale) obj).getScript();
    }
}

