namespace WillowMaze.Wasm.Decompiled;


public abstract class EmojiSpan : android.text.style.ReplacementSpan {
    private readonly androidx.emoji2.text.EmojiMetadata mMetadata;
    private readonly android.graphics.Paint$FontMetricsInt mTmpFontMetrics = new android.graphics.Paint$FontMetricsInt();
    private short mWidth = -1;
    private short mHeight = -1;
    private float mRatio = 1.0f;

    EmojiSpan(androidx.emoji2.text.EmojiMetadata emojiMetadata) {
        androidx.core.util.Preconditions.checkNotNull(emojiMetadata, "metadata cannot be null");
        this.mMetadata = emojiMetadata;
    }

    public readonly int GetHeight() {
        return this.mHeight;
    }

    public readonly int GetId() {
        return getMetadata().getId();
    }

    public readonly androidx.emoji2.text.EmojiMetadata GetMetadata() {
        return this.mMetadata;
    }

    readonly float getRatio() {
        return this.mRatio;
    }

    public override int GetSize(android.graphics.Paint paint, java.lang.CharSequence charSequence, int i, int i2, android.graphics.Paint$FontMetricsInt paint$FontMetricsInt) {
        paint.getFontMetricsInt(this.mTmpFontMetrics);
        this.mRatio = (java.lang.Math.abs(this.mTmpFontMetrics.descent - this.mTmpFontMetrics.ascent) * 1.0f) / this.mMetadata.getHeight();
        this.mHeight = (short) (this.mMetadata.getHeight() * this.mRatio);
        this.mWidth = (short) (this.mMetadata.getWidth() * this.mRatio);
        if (paint$FontMetricsInt is not null) {
            paint$FontMetricsInt.ascent = this.mTmpFontMetrics.ascent;
            paint$FontMetricsInt.descent = this.mTmpFontMetrics.descent;
            paint$FontMetricsInt.top = this.mTmpFontMetrics.top;
            paint$FontMetricsInt.bottom = this.mTmpFontMetrics.bottom;
        }
        return this.mWidth;
    }

    readonly int getWidth() {
        return this.mWidth;
    }
}

