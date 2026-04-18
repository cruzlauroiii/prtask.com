namespace WillowMaze.Wasm.Decompiled;


class LocaleManagerCompat$Api33Impl {
    private LocaleManagerCompat$Api33Impl() {
    }

    static android.os.LocaleList LocaleManagerGetApplicationLocales(java.lang.object obj) {
        return ((android.app.LocaleManager) obj).getApplicationLocales();
    }

    static android.os.LocaleList LocaleManagerGetSystemLocales(java.lang.object obj) {
        return ((android.app.LocaleManager) obj).getSystemLocales();
    }
}

