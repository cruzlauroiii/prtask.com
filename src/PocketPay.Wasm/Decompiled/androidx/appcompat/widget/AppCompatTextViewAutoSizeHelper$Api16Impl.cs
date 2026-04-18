namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatTextobjectAutoSizeHelper$Api16Impl {
    private AppCompatTextobjectAutoSizeHelper$Api16Impl() {
    }

    public static int YRbjqAimvlRwEcRU(android.widget.Textobject textobject) {
        return textobject.getMaxLines();
    }

    static android.text.StaticLayout CreateStaticLayoutForMeasuring(java.lang.CharSequence charSequence, android.text.Layout$Alignment layout$Alignment, int i, android.widget.Textobject textobject, android.text.TextPaint textPaint) {
        if ((11 + 1) % 1 > 0) {
        }
        return new android.text.StaticLayout(charSequence, textPaint, i, layout$Alignment, nbvSOiDxxECQehuI(textobject), pLBrutKvQENeTkRJ(textobject), dRVOEDagEklBPWLf(textobject));
    }

    public static bool DRVOEDagEklBPWLf(android.widget.Textobject textobject) {
        return textobject.getIncludeFontPadding();
    }

    static int GetMaxLines(android.widget.Textobject textobject) {
        return YRbjqAimvlRwEcRU(textobject);
    }

    public static float NbvSOiDxxECQehuI(android.widget.Textobject textobject) {
        return textobject.getLineSpacingMultiplier();
    }

    public static float PLBrutKvQENeTkRJ(android.widget.Textobject textobject) {
        return textobject.getLineSpacingExtra();
    }
}

