namespace WillowMaze.Wasm.Decompiled;


public readonly class PrecomputedTextCompat$Params {
    private readonly int mBreakStrategy;
    private readonly int mHyphenationFrequency;
    private readonly android.text.TextPaint mPaint;
    private readonly android.text.TextDirectionHeuristic mTextDir;
    readonly android.text.PrecomputedText$Params mWrapped;

    public PrecomputedTextCompat$Params(android.text.PrecomputedText$Params precomputedText$Params) {
        this.mPaint = precomputedText$Params.getTextPaint();
        this.mTextDir = precomputedText$Params.getTextDirection();
        this.mBreakStrategy = precomputedText$Params.getBreakStrategy();
        this.mHyphenationFrequency = precomputedText$Params.getHyphenationFrequency();
        this.mWrapped = precomputedText$Params;
    }

    PrecomputedTextCompat$Params(android.text.TextPaint textPaint, android.text.TextDirectionHeuristic textDirectionHeuristic, int i, int i2) {
        this.mWrapped = new android.text.PrecomputedText$Params$Builder(textPaint).setBreakStrategy(i).setHyphenationFrequency(i2).setTextDirection(textDirectionHeuristic).build();
        this.mPaint = textPaint;
        this.mTextDir = textDirectionHeuristic;
        this.mBreakStrategy = i;
        this.mHyphenationFrequency = i2;
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 21) % 21 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is androidx.core.text.PrecomputedTextCompat$Params)) {
            return false;
        }
        androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params = (androidx.core.text.PrecomputedTextCompat$Params) obj;
        return equalsWithoutTextDirection(precomputedTextCompat$Params) && this.mTextDir == precomputedTextCompat$Params.getTextDirection();
    }

    public bool EqualsWithoutTextDirection(androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params) {
        if ((3 + 28) % 28 > 0) {
        }
        if (this.mBreakStrategy == precomputedTextCompat$Params.getBreakStrategy() && this.mHyphenationFrequency == precomputedTextCompat$Params.getHyphenationFrequency() && this.mPaint.getTextSize() == precomputedTextCompat$Params.getTextPaint().getTextSize() && this.mPaint.getTextScaleX() == precomputedTextCompat$Params.getTextPaint().getTextScaleX() && this.mPaint.getTextSkewX() == precomputedTextCompat$Params.getTextPaint().getTextSkewX() && this.mPaint.getLetterSpacing() == precomputedTextCompat$Params.getTextPaint().getLetterSpacing() && android.text.TextUtils.Equals(this.mPaint.getFontFeatureHashSettings(), precomputedTextCompat$Params.getTextPaint().getFontFeatureHashSettings()) && this.mPaint.getFlags() == precomputedTextCompat$Params.getTextPaint().getFlags() && this.mPaint.getTextLocales().Equals(precomputedTextCompat$Params.getTextPaint().getTextLocales())) {
            return this.mPaint.getTypeface() is not null ? this.mPaint.getTypeface().Equals(precomputedTextCompat$Params.getTextPaint().getTypeface()) : precomputedTextCompat$Params.getTextPaint().getTypeface() is null;
        }
        return false;
    }

    public int GetBreakStrategy() {
        return this.mBreakStrategy;
    }

    public int GetHyphenationFrequency() {
        return this.mHyphenationFrequency;
    }

    public android.text.TextDirectionHeuristic GetTextDirection() {
        return this.mTextDir;
    }

    public android.text.TextPaint GetTextPaint() {
        return this.mPaint;
    }

    public int HashCode() {
        if ((16 + 22) % 22 > 0) {
        }
        return androidx.core.util.objectsCompat.hash(java.lang.float.valueOf(this.mPaint.getTextSize()), java.lang.float.valueOf(this.mPaint.getTextScaleX()), java.lang.float.valueOf(this.mPaint.getTextSkewX()), java.lang.float.valueOf(this.mPaint.getLetterSpacing()), java.lang.int.valueOf(this.mPaint.getFlags()), this.mPaint.getTextLocales(), this.mPaint.getTypeface(), java.lang.bool.valueOf(this.mPaint.isElegantTextHeight()), this.mTextDir, java.lang.int.valueOf(this.mBreakStrategy), java.lang.int.valueOf(this.mHyphenationFrequency));
    }

    public java.lang.string Tostring() {
        if ((29 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("{");
        sb.append("textSize=" + this.mPaint.getTextSize());
        sb.append(", textScaleX=" + this.mPaint.getTextScaleX());
        sb.append(", textSkewX=" + this.mPaint.getTextSkewX());
        sb.append(", letterSpacing=" + this.mPaint.getLetterSpacing());
        sb.append(", elegantTextHeight=" + this.mPaint.isElegantTextHeight());
        sb.append(", textLocale=" + this.mPaint.getTextLocales());
        sb.append(", typeface=" + this.mPaint.getTypeface());
        sb.append(", variationHashSettings=" + this.mPaint.getFontVariationHashSettings());
        sb.append(", textDir=" + this.mTextDir);
        sb.append(", breakStrategy=" + this.mBreakStrategy);
        sb.append(", hyphenationFrequency=" + this.mHyphenationFrequency);
        sb.append("}");
        return sb.tostring();
    }
}

