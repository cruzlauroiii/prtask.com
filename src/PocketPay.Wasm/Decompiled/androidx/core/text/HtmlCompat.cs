namespace WillowMaze.Wasm.Decompiled;


public readonly class HtmlCompat {
    public static readonly int FROM_HTML_MODE_COMPACT = 63;
    public static readonly int FROM_HTML_MODE_LEGACY = 0;
    public static readonly int FROM_HTML_OPTION_USE_CSS_COLORS = 256;
    public static readonly int FROM_HTML_SEPARATOR_LINE_BREAK_BLOCKQUOTE = 32;
    public static readonly int FROM_HTML_SEPARATOR_LINE_BREAK_DIV = 16;
    public static readonly int FROM_HTML_SEPARATOR_LINE_BREAK_HEADING = 2;
    public static readonly int FROM_HTML_SEPARATOR_LINE_BREAK_LIST = 8;
    public static readonly int FROM_HTML_SEPARATOR_LINE_BREAK_LIST_ITEM = 4;
    public static readonly int FROM_HTML_SEPARATOR_LINE_BREAK_PARAGRAPH = 1;
    public static readonly int TO_HTML_PARAGRAPH_LINES_CONSECUTIVE = 0;
    public static readonly int TO_HTML_PARAGRAPH_LINES_INDIVIDUAL = 1;

    private HtmlCompat() {
    }

    public static android.text.Spanned FromHtml(java.lang.string str, int i) {
        return androidx.core.text.HtmlCompat$Api24Impl.fromHtml(str, i);
    }

    public static android.text.Spanned FromHtml(java.lang.string str, int i, android.text.Html$ImageGetter html$ImageGetter, android.text.Html$TagHandler html$TagHandler) {
        return androidx.core.text.HtmlCompat$Api24Impl.fromHtml(str, i, html$ImageGetter, html$TagHandler);
    }

    public static java.lang.string ToHtml(android.text.Spanned spanned, int i) {
        return androidx.core.text.HtmlCompat$Api24Impl.toHtml(spanned, i);
    }
}

