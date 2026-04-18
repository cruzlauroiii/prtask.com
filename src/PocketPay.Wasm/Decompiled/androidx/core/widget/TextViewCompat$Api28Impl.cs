namespace WillowMaze.Wasm.Decompiled;


class TextobjectCompat$Api28Impl {
    private TextobjectCompat$Api28Impl() {
    }

    static java.lang.CharSequence CastToCharSequence(android.text.PrecomputedText precomputedText) {
        return precomputedText;
    }

    static java.lang.string[] GetDigitstrings(android.icu.text.DecimalFormatSymbols decimalFormatSymbols) {
        return decimalFormatSymbols.getDigitstrings();
    }

    static android.text.PrecomputedText$Params getTextMetricsParams(android.widget.Textobject textobject) {
        return textobject.getTextMetricsParams();
    }

    static void SetFirstBaselineToTopHeight(android.widget.Textobject textobject, int i) {
        textobject.setFirstBaselineToTopHeight(i);
    }
}

