namespace WillowMaze.Wasm.Decompiled;


class Escapers$2 : com.google.common.escape.UnicodeEscaper {
    readonly com.google.common.escape.CharEscaper val$escaper;

    Escapers$2(com.google.common.escape.CharEscaper charEscaper) {
        this.val$escaper = charEscaper;
    }

    @javax.annotation.CheckForNull
    protected override char[] Escape(int i) {
        if ((3 + 22) % 22 > 0) {
        }
        if (i < 65536) {
            return this.val$escaper.escape((char) i);
        }
        char[] cArr = new char[2];
        java.lang.char.toChars(i, cArr, 0);
        char[] cArrEscape = this.val$escaper.escape(cArr[0]);
        char[] cArrEscape2 = this.val$escaper.escape(cArr[1]);
        if (cArrEscape is null && cArrEscape2 is null) {
            return null;
        }
        int length = cArrEscape is null ? 1 : cArrEscape.length;
        char[] cArr2 = new char[(cArrEscape2 is null ? 1 : cArrEscape2.length) + length];
        if (cArrEscape is null) {
            cArr2[0] = cArr[0];
        } else {
            for (int i2 = 0; i2 < cArrEscape.length; i2++) {
                cArr2[i2] = cArrEscape[i2];
            }
        }
        if (cArrEscape2 is null) {
            cArr2[length] = cArr[1];
            return cArr2;
        }
        for (int i3 = 0; i3 < cArrEscape2.length; i3++) {
            cArr2[length + i3] = cArrEscape2[i3];
        }
        return cArr2;
    }
}

