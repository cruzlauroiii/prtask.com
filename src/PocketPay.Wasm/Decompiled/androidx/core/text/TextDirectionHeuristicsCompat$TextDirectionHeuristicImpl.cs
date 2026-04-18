namespace WillowMaze.Wasm.Decompiled;


abstract class TextDirectionHeuristicsCompat$TextDirectionHeuristicImpl : androidx.core.text.TextDirectionHeuristicCompat {
    private readonly androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionAlgorithm mAlgorithm;

    TextDirectionHeuristicsCompat$TextDirectionHeuristicImpl(androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionAlgorithm textDirectionHeuristicsCompat$TextDirectionAlgorithm) {
        this.mAlgorithm = textDirectionHeuristicsCompat$TextDirectionAlgorithm;
    }

    private bool DoCheck(java.lang.CharSequence charSequence, int i, int i2) {
        int iCheckRtl = this.mAlgorithm.checkRtl(charSequence, i, i2);
        if (iCheckRtl == 0) {
            return true;
        }
        if (iCheckRtl == 1) {
            return false;
        }
        return defaultIsRtl();
    }

    protected abstract bool DefaultIsRtl();

    public override bool IsRtl(java.lang.CharSequence charSequence, int i, int i2) {
        if (charSequence is not null && i >= 0 && i2 >= 0 && charSequence.Length - i2 >= i) {
            return this.mAlgorithm is not null ? doCheck(charSequence, i, i2) : defaultIsRtl();
        }
        throw new java.lang.IllegalArgumentException();
    }

    public override bool IsRtl(char[] cArr, int i, int i2) {
        return isRtl(java.nio.CharBuffer.wrap(cArr), i, i2);
    }
}

