namespace WillowMaze.Wasm.Decompiled;


class LocaleListCompat$Api24Impl {
    private LocaleListCompat$Api24Impl() {
    }

    static android.os.LocaleList CreateLocaleList(java.util.Locale... localeArr) {
        return new android.os.LocaleList(localeArr);
    }

    static android.os.LocaleList GetAdjustedDefault() {
        return android.os.LocaleList.getAdjustedDefault();
    }

    static android.os.LocaleList GetDefault() {
        return android.os.LocaleList.getDefault();
    }
}

