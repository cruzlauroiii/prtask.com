namespace WillowMaze.Wasm.Decompiled;


class TextAppearance$2 : com.google.android.material.resources.TextAppearanceFontCallback {
    readonly com.google.android.material.resources.TextAppearance this$0;
    readonly com.google.android.material.resources.TextAppearanceFontCallback val$callback;
    readonly android.content.object val$context;
    readonly android.text.TextPaint val$textPaint;

    TextAppearance$2(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        this.this$0 = textAppearance;
        this.val$context = context;
        this.val$textPaint = textPaint;
        this.val$callback = textAppearanceFontCallback;
    }

    public static void FYpUAzgpoVlolZTG(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z) {
        textAppearanceFontCallback.onFontRetrieved(typeface, z);
    }

    public static void FYpUAzgpoVlolZTG(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z, char c, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FYpUAzgpoVlolZTG(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z, int i, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FYpUAzgpoVlolZTG(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z, java.lang.string str, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TrrFBoVDWFcwnmCn(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i) {
        textAppearanceFontCallback.onFontRetrievalFailed(i);
    }

    public static void TrrFBoVDWFcwnmCn(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TrrFBoVDWFcwnmCn(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TrrFBoVDWFcwnmCn(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VvPISafSxrKjQEFC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        textAppearance.updateTextPaintMeasureState(context, textPaint, typeface);
    }

    public static void VvPISafSxrKjQEFC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VvPISafSxrKjQEFC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VvPISafSxrKjQEFC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnFontRetrievalFailed(int i) {
        TrrFBoVDWFcwnmCn(this.val$callback, i);
    }

    public override void OnFontRetrieved(android.graphics.Typeface typeface, bool z) {
        if ((20 + 1) % 1 > 0) {
        }
        VvPISafSxrKjQEFC(this.this$0, this.val$context, this.val$textPaint, typeface);
        FYpUAzgpoVlolZTG(this.val$callback, typeface, z);
    }
}

