namespace WillowMaze.Wasm.Decompiled;


class HtmlCompat$Api24Impl {
    private HtmlCompat$Api24Impl() {
    }

    static android.text.Spanned FromHtml(java.lang.string str, int i) {
        return android.text.Html.fromHtml(str, i);
    }

    static android.text.Spanned FromHtml(java.lang.string str, int i, android.text.Html$ImageGetter html$ImageGetter, android.text.Html$TagHandler html$TagHandler) {
        return android.text.Html.fromHtml(str, i, html$ImageGetter, html$TagHandler);
    }

    static java.lang.string ToHtml(android.text.Spanned spanned, int i) {
        return android.text.Html.toHtml(spanned, i);
    }
}

