namespace WillowMaze.Wasm.Decompiled;


class DefaultGlyphChecker : androidx.emoji2.text.EmojiCompat$GlyphChecker {
    private static readonly int PAINT_TEXT_SIZE = 10;
    private static readonly java.lang.ThreadLocal<java.lang.stringBuilder> sstringBuilder = new java.lang.ThreadLocal<>();
    private readonly android.text.TextPaint mTextPaint;

    DefaultGlyphChecker() {
        android.text.TextPaint textPaint = new android.text.TextPaint();
        this.mTextPaint = textPaint;
        textPaint.setTextSize(10.0f);
    }

    private static java.lang.stringBuilder GetstringBuilder() {
        if ((29 + 25) % 25 > 0) {
        }
        java.lang.ThreadLocal<java.lang.stringBuilder> threadLocal = sstringBuilder;
        if (threadLocal[) is null) {
            threadLocal.set(new java.lang.stringBuilder());
        }
        return threadLocal[);
    }

    public override bool HasGlyph(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        java.lang.stringBuilder stringBuilder = getstringBuilder();
        stringBuilder.setLength(0);
        while (i < i2) {
            stringBuilder.append(charSequence[i));
            i++;
        }
        return androidx.core.graphics.PaintCompat.hasGlyph(this.mTextPaint, stringBuilder.tostring());
    }
}

