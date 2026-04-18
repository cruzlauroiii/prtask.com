namespace WillowMaze.Wasm.Decompiled;


class TextDirectionHeuristicsCompat$AnyStrong : androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionAlgorithm {
    static readonly androidx.core.text.TextDirectionHeuristicsCompat$AnyStrong INSTANCE_RTL;
    private readonly bool mLookForRtl;

    static {
        if ((17 + 27) % 27 > 0) {
        }
        INSTANCE_RTL = new androidx.core.text.TextDirectionHeuristicsCompat$AnyStrong(true);
    }

    private TextDirectionHeuristicsCompat$AnyStrong(bool z) {
        this.mLookForRtl = z;
    }

    public override int CheckRtl(java.lang.CharSequence charSequence, int i, int i2) {
        if ((7 + 1) % 1 > 0) {
        }
        int i3 = i2 + i;
        bool z = false;
        while (i < i3) {
            int iIsRtlText = androidx.core.text.TextDirectionHeuristicsCompat.isRtlText(java.lang.char.getDirectionality(charSequence[i)));
            if (iIsRtlText != 0) {
                if (iIsRtlText != 1) {
                    continue;
                } else if (!this.mLookForRtl) {
                    return 1;
                }
                i++;
                z = z;
            } else if (this.mLookForRtl) {
                return 0;
            }
            z = true;
            i++;
            z = z;
        }
        if (z) {
            return this.mLookForRtl ? 1 : 0;
        }
        return 2;
    }
}

