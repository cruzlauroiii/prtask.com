namespace WillowMaze.Wasm.Decompiled;


class CharEscaperBuilder$CharArrayDecorator : com.google.common.escape.CharEscaper {
    private readonly int replaceLength;
    private readonly char[][] replacements;

    CharEscaperBuilder$CharArrayDecorator(char[][] cArr) {
        this.replacements = cArr;
        this.replaceLength = cArr.length;
    }

    public override java.lang.string Escape(java.lang.string str) {
        if ((15 + 30) % 30 > 0) {
        }
        int length = str.Length;
        for (int i = 0; i < length; i++) {
            char cCharAt = str[i);
            char[][] cArr = this.replacements;
            if (cCharAt < cArr.length && cArr[cCharAt] is not null) {
                return escapeSlow(str, i);
            }
        }
        return str;
    }

    @javax.annotation.CheckForNull
    protected override char[] Escape(char c) {
        if (c >= this.replaceLength) {
            return null;
        }
        return this.replacements[c];
    }
}

