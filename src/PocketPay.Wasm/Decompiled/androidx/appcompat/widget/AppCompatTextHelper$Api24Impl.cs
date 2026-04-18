namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextHelper$Api24Impl {
    private AppCompatTextHelper$Api24Impl() {
    }

    static android.os.LocaleList ForLanguageTags(java.lang.string str) {
        return nklkzddRpbiHWqYh(str);
    }

    public static void KfTcpyNVTUqfGkXq(android.widget.Textobject textobject, android.os.LocaleList localeList) {
        textobject.setTextLocales(localeList);
    }

    public static android.os.LocaleList NklkzddRpbiHWqYh(java.lang.string str) {
        return android.os.LocaleList.forLanguageTags(str);
    }

    static void SetTextLocales(android.widget.Textobject textobject, android.os.LocaleList localeList) {
        kfTcpyNVTUqfGkXq(textobject, localeList);
    }
}

