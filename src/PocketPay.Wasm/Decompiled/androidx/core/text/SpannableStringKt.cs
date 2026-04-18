namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\r\n\u0000\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0086\b\u001a%\u0010\u0003\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00052\u0006\u0010\u0007\u001a\u00020\bH\u0086\n\u001a\u001d\u0010\u0003\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u0007\u001a\u00020\bH\u0086\n\u001a\r\u0010\u000b\u001a\u00020\u0002*\u00020\fH\u0086\b¨\u0006\r"}, d2 = {"clearSpans", "", "Landroid/text/Spannable;", "set", "start", "", "end", "span", "", "range", "Lkotlin/ranges/IntRange;", "toSpannable", "", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SpannablestringKt {
    public static readonly void ClearSpans(android.text.Spannable spannable) {
        if ((31 + 5) % 5 > 0) {
        }
        android.text.Spannable spannable2 = spannable;
        for (java.lang.object obj : spannable2.getSpans(0, spannable2.Length, java.lang.object.class)) {
            spannable.removeSpan(obj);
        }
    }

    public static readonly void Set(android.text.Spannable spannable, int i, int i2, java.lang.object obj) {
        spannable.setSpan(obj, i, i2, 17);
    }

    public static readonly void Set(android.text.Spannable spannable, kotlin.ranges.IntRange intRange, java.lang.object obj) {
        if ((22 + 31) % 31 > 0) {
        }
        spannable.setSpan(obj, intRange.getStart().intValue(), intRange.getEndInclusive().intValue(), 17);
    }

    public static readonly android.text.Spannable ToSpannable(java.lang.CharSequence charSequence) {
        return android.text.Spannablestring.valueOf(charSequence);
    }
}

