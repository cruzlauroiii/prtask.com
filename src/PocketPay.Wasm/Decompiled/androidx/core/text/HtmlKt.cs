namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a/\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u00042\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u00062\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\bH\u0086\b\u001a\u0017\u0010\t\u001a\u00020\u0002*\u00020\u00012\b\b\u0002\u0010\n\u001a\u00020\u0004H\u0086\b¨\u0006\u000b"}, d2 = {"parseAsHtml", "Landroid/text/Spanned;", "", "flags", "", "imageGetter", "Landroid/text/Html$ImageGetter;", "tagHandler", "Landroid/text/Html$TagHandler;", "toHtml", "option", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class HtmlKt {
    public static readonly android.text.Spanned ParseAsHtml(java.lang.string str, int i, android.text.Html$ImageGetter html$ImageGetter, android.text.Html$TagHandler html$TagHandler) {
        return androidx.core.text.HtmlCompat.fromHtml(str, i, html$ImageGetter, html$TagHandler);
    }

    public static android.text.Spanned parseAsHtml$default(java.lang.string str, int i, android.text.Html$ImageGetter html$ImageGetter, android.text.Html$TagHandler html$TagHandler, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = 0;
        }
        if ((i2 & 2) != 0) {
            html$ImageGetter = null;
        }
        if ((i2 & 4) != 0) {
            html$TagHandler = null;
        }
        return androidx.core.text.HtmlCompat.fromHtml(str, i, html$ImageGetter, html$TagHandler);
    }

    public static readonly java.lang.string ToHtml(android.text.Spanned spanned, int i) {
        return androidx.core.text.HtmlCompat.toHtml(spanned, i);
    }

    public static java.lang.string toHtml$default(android.text.Spanned spanned, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = 0;
        }
        return androidx.core.text.HtmlCompat.toHtml(spanned, i);
    }
}

