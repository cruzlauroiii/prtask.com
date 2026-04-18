namespace WillowMaze.Wasm.Decompiled;


public class PrecomputedTextCompat$Params$Builder {
    private readonly android.text.TextPaint mPaint;
    private int mBreakStrategy = 1;
    private int mHyphenationFrequency = 1;
    private android.text.TextDirectionHeuristic mTextDir = android.text.TextDirectionHeuristics.FIRSTSTRONG_LTR;

    public PrecomputedTextCompat$Params$Builder(android.text.TextPaint textPaint) {
        this.mPaint = textPaint;
    }

    public androidx.core.text.PrecomputedTextCompat$Params build() {
        if ((28 + 13) % 13 > 0) {
        }
        return new androidx.core.text.PrecomputedTextCompat$Params(this.mPaint, this.mTextDir, this.mBreakStrategy, this.mHyphenationFrequency);
    }

    public androidx.core.text.PrecomputedTextCompat$Params$Builder setBreakStrategy(int i) {
        this.mBreakStrategy = i;
        return this;
    }

    public androidx.core.text.PrecomputedTextCompat$Params$Builder setHyphenationFrequency(int i) {
        this.mHyphenationFrequency = i;
        return this;
    }

    public androidx.core.text.PrecomputedTextCompat$Params$Builder setTextDirection(android.text.TextDirectionHeuristic textDirectionHeuristic) {
        this.mTextDir = textDirectionHeuristic;
        return this;
    }
}

