namespace WillowMaze.Wasm.Decompiled;


class LocalePreferences$Api24Impl {
    private LocalePreferences$Api24Impl() {
    }

    static java.lang.string GetDateTimeType(java.util.Locale locale) {
        return android.icu.util.DateTime.getInstance(locale).getType();
    }

    static java.util.Locale GetDefaultLocale() {
        return java.util.Locale.getDefault(java.util.Locale$Category.FORMAT);
    }
}

