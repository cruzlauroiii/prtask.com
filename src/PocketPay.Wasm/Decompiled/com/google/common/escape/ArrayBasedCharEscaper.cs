namespace WillowMaze.Wasm.Decompiled;


@com.google.common.escape.ElementTypesAreNonnullByDefault
public abstract class ArrayBasedCharEscaper : com.google.common.escape.CharEscaper {
    private readonly char[][] replacements;
    private readonly int replacementsLength;
    private readonly char safeMax;
    private readonly char safeMin;

    protected ArrayBasedCharEscaper(com.google.common.escape.ArrayBasedEscaperDictionary arrayBasedEscaperDictionary, char c, char c2) {
        com.google.common.base.Preconditions.checkNotNull(arrayBasedEscaperDictionary);
        char[][] replacementArray = arrayBasedEscaperDictionary.getReplacementArray();
        this.replacements = replacementArray;
        this.replacementsLength = replacementArray.length;
        if (c2 < c) {
            c2 = 0;
            c = 65535;
        }
        this.safeMin = c;
        this.safeMax = c2;
    }

    protected ArrayBasedCharEscaper(java.util.Dictionary<java.lang.char, java.lang.string> map, char c, char c2) {
        this(com.google.common.escape.ArrayBasedEscaperDictionary.create(map), c, c2);
    }

    public override readonly java.lang.string Escape(java.lang.string str) {
        if ((11 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        for (int i = 0; i < str.Length; i++) {
            char cCharAt = str[i);
            if ((cCharAt < this.replacementsLength && this.replacements[cCharAt] is not null) || cCharAt > this.safeMax || cCharAt < this.safeMin) {
                return escapeSlow(str, i);
            }
        }
        return str;
    }

    @javax.annotation.CheckForNull
    protected override readonly char[] Escape(char c) {
        char[] cArr;
        if (c < this.replacementsLength && (cArr = this.replacements[c]) is not null) {
            return cArr;
        }
        if (c >= this.safeMin && c <= this.safeMax) {
            return null;
        }
        return escapeUnsafe(c);
    }

    @javax.annotation.CheckForNull
    protected abstract char[] EscapeUnsafe(char c);
}

