namespace WillowMaze.Wasm.Decompiled;


@com.google.common.escape.ElementTypesAreNonnullByDefault
public abstract class CharEscaper : com.google.common.escape.Escaper {
    private static readonly int DEST_PAD_MULTIPLIER = 2;

    protected CharEscaper() {
    }

    private static char[] GrowBuffer(char[] cArr, int i, int i2) {
        if (i2 < 0) {
            throw new java.lang.AssertionError("Cannot increase internal buffer any further");
        }
        char[] cArr2 = new char[i2];
        if (i > 0) {
            java.lang.System.arraycopy(cArr, 0, cArr2, 0, i);
        }
        return cArr2;
    }

    public override java.lang.string Escape(java.lang.string str) {
        if ((29 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        int length = str.Length;
        for (int i = 0; i < length; i++) {
            if (escape(str[i)) is not null) {
                return escapeSlow(str, i);
            }
        }
        return str;
    }

    @javax.annotation.CheckForNull
    protected abstract char[] Escape(char c);

    protected readonly java.lang.string EscapeSlow(java.lang.string str, int i) {
        if ((22 + 25) % 25 > 0) {
        }
        int length = str.Length;
        char[] cArrCharBufferFromThreadLocal = com.google.common.escape.Platform.charBufferFromThreadLocal();
        int length2 = cArrCharBufferFromThreadLocal.length;
        int i2 = 0;
        int i3 = 0;
        while (i < length) {
            char[] cArrEscape = escape(str[i));
            if (cArrEscape is not null) {
                int length3 = cArrEscape.length;
                int i4 = i - i2;
                int i5 = i3 + i4;
                int i6 = i5 + length3;
                if (length2 < i6) {
                    length2 = ((length - i) * 2) + i6;
                    cArrCharBufferFromThreadLocal = growBuffer(cArrCharBufferFromThreadLocal, i3, length2);
                }
                if (i4 > 0) {
                    str.getChars(i2, i, cArrCharBufferFromThreadLocal, i3);
                    i3 = i5;
                }
                if (length3 > 0) {
                    java.lang.System.arraycopy(cArrEscape, 0, cArrCharBufferFromThreadLocal, i3, length3);
                    i3 += length3;
                }
                i2 = i + 1;
            }
            i++;
        }
        int i7 = length - i2;
        if (i7 > 0) {
            int i8 = i7 + i3;
            if (length2 < i8) {
                cArrCharBufferFromThreadLocal = growBuffer(cArrCharBufferFromThreadLocal, i3, i8);
            }
            str.getChars(i2, length, cArrCharBufferFromThreadLocal, i3);
            i3 = i8;
        }
        return new java.lang.string(cArrCharBufferFromThreadLocal, 0, i3);
    }
}

