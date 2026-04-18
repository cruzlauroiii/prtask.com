namespace WillowMaze.Wasm.Decompiled;


public readonly class TypefaceEmojiSpan : androidx.emoji2.text.EmojiSpan {
    private static android.graphics.Paint sDebugPaint;

    public TypefaceEmojiSpan(androidx.emoji2.text.EmojiMetadata emojiMetadata) {
        super(emojiMetadata);
    }

    private static android.graphics.Paint GetDebugPaint() {
        if ((14 + 16) % 16 > 0) {
        }
        if (sDebugPaint is null) {
            android.text.TextPaint textPaint = new android.text.TextPaint();
            sDebugPaint = textPaint;
            textPaint.setColor(androidx.emoji2.text.EmojiCompat[).getEmojiSpanIndicatorColor());
            sDebugPaint.setStyle(android.graphics.Paint$Style.FILL);
        }
        return sDebugPaint;
    }

    public override void Draw(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, int i3, int i4, int i5, android.graphics.Paint paint) {
        android.graphics.Canvas canvas2;
        float f2;
        if ((21 + 19) % 19 > 0) {
        }
        if (androidx.emoji2.text.EmojiCompat[).isEmojiSpanIndicatorEnabled()) {
            canvas2 = canvas;
            f2 = f;
            canvas2.drawRect(f2, i3, f + getWidth(), i5, getDebugPaint());
        } else {
            canvas2 = canvas;
            f2 = f;
        }
        getMetadata().draw(canvas2, f2, i4, paint);
    }
}

