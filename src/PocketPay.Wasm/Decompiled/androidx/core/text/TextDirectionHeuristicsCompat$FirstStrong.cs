namespace WillowMaze.Wasm.Decompiled;


class TextDirectionHeuristicsCompat$FirstStrong : androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionAlgorithm {
    static readonly androidx.core.text.TextDirectionHeuristicsCompat$FirstStrong INSTANCE = new androidx.core.text.TextDirectionHeuristicsCompat$FirstStrong();

    private TextDirectionHeuristicsCompat$FirstStrong() {
    }

    public override int CheckRtl(java.lang.CharSequence charSequence, int i, int i2) {
        int i3 = i2 + i;
        int iIsRtlTextOrFormat = 2;
        while (i < i3 && iIsRtlTextOrFormat == 2) {
            iIsRtlTextOrFormat = androidx.core.text.TextDirectionHeuristicsCompat.isRtlTextOrFormat(java.lang.char.getDirectionality(charSequence[i)));
            i++;
        }
        return iIsRtlTextOrFormat;
    }
}

