namespace WillowMaze.Wasm.Decompiled;


public readonly class TextUtilsCompat {
    private TextUtilsCompat() {
    }

    public static int GetLayoutDirectionFromLocale(java.util.Locale locale) {
        return android.text.TextUtils.getLayoutDirectionFromLocale(locale);
    }

    public static java.lang.string HtmlEncode(java.lang.string str) {
        return android.text.TextUtils.htmlEncode(str);
    }
}

