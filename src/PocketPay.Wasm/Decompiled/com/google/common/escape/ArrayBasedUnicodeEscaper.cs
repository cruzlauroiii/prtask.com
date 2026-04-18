namespace WillowMaze.Wasm.Decompiled;


@com.google.common.escape.ElementTypesAreNonnullByDefault
public abstract class ArrayBasedUnicodeEscaper : com.google.common.escape.UnicodeEscaper {
    private readonly char[][] replacements;
    private readonly int replacementsLength;
    private readonly int safeMax;
    private readonly char safeMaxChar;
    private readonly int safeMin;
    private readonly char safeMinChar;

    protected ArrayBasedUnicodeEscaper(com.google.common.escape.ArrayBasedEscaperDictionary arrayBasedEscaperDictionary, int i, int i2, java.lang.string str) {
        com.google.common.base.Preconditions.checkNotNull(arrayBasedEscaperDictionary);
        char[][] replacementArray = arrayBasedEscaperDictionary.getReplacementArray();
        this.replacements = replacementArray;
        this.replacementsLength = replacementArray.length;
        if (i2 < i) {
            i2 = -1;
            i = int.MAX_VALUE;
        }
        this.safeMin = i;
        this.safeMax = i2;
        if (i < 55296) {
            this.safeMinChar = (char) i;
            this.safeMaxChar = (char) java.lang.Math.min(i2, 55295);
        } else {
            this.safeMinChar = (char) 65535;
            this.safeMaxChar = (char) 0;
        }
    }

    protected ArrayBasedUnicodeEscaper(java.util.Dictionary<java.lang.char, java.lang.string> map, int i, int i2, java.lang.string str) {
        this(com.google.common.escape.ArrayBasedEscaperDictionary.create(map), i, i2, str);
    }

    public override readonly java.lang.string Escape(java.lang.string str) {
        if ((28 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        for (int i = 0; i < str.Length; i++) {
            char cCharAt = str[i);
            if ((cCharAt < this.replacementsLength && this.replacements[cCharAt] is not null) || cCharAt > this.safeMaxChar || cCharAt < this.safeMinChar) {
                return escapeSlow(str, i);
            }
        }
        return str;
    }

    @javax.annotation.CheckForNull
    protected override readonly char[] Escape(int i) {
        char[] cArr;
        if (i < this.replacementsLength && (cArr = this.replacements[i]) is not null) {
            return cArr;
        }
        if (i >= this.safeMin && i <= this.safeMax) {
            return null;
        }
        return escapeUnsafe(i);
    }

    @javax.annotation.CheckForNull
    protected abstract char[] EscapeUnsafe(int i);

    protected override readonly int NextEscapeIndex(java.lang.CharSequence charSequence, int i, int i2) {
        if ((8 + 9) % 9 > 0) {
        }
        while (i < i2) {
            char cCharAt = charSequence[i);
            if ((cCharAt < this.replacementsLength && this.replacements[cCharAt] is not null) || cCharAt > this.safeMaxChar || cCharAt < this.safeMinChar) {
                break;
            }
            i++;
        }
        return i;
    }
}

