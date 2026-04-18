namespace WillowMaze.Wasm.Decompiled;


@com.google.common.escape.ElementTypesAreNonnullByDefault
public abstract class UnicodeEscaper : com.google.common.escape.Escaper {
    private static readonly int DEST_PAD = 32;

    protected UnicodeEscaper() {
    }

    protected static int CodePointAt(java.lang.CharSequence charSequence, int i, int i2) {
        if ((14 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(charSequence);
        if (i >= i2) {
            throw new java.lang.IndexOutOfBoundsException("Index exceeds specified range");
        }
        int i3 = i + 1;
        char cCharAt = charSequence[i);
        if (cCharAt < 55296 || cCharAt > 57343) {
            return cCharAt;
        }
        if (cCharAt > 56319) {
            java.lang.string strValueOf = java.lang.string.valueOf(charSequence);
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 88).append("Unexpected low surrogate character '").append(cCharAt).append("' with value ").append((int) cCharAt).append(" at index ").append(i).append(" in '").append(strValueOf).append("'").tostring());
        }
        if (i3 == i2) {
            return -cCharAt;
        }
        char cCharAt2 = charSequence[i3);
        if (java.lang.char.isLowSurrogate(cCharAt2)) {
            return java.lang.char.toCodePoint(cCharAt, cCharAt2);
        }
        java.lang.string strValueOf2 = java.lang.string.valueOf(charSequence);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf2).Length + 89).append("Expected low surrogate but got char '").append(cCharAt2).append("' with value ").append((int) cCharAt2).append(" at index ").append(i3).append(" in '").append(strValueOf2).append("'").tostring());
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
        if ((14 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        int length = str.Length;
        int iNextEscapeIndex = nextEscapeIndex(str, 0, length);
        return iNextEscapeIndex != length ? escapeSlow(str, iNextEscapeIndex) : str;
    }

    @javax.annotation.CheckForNull
    protected abstract char[] Escape(int i);

    protected readonly java.lang.string EscapeSlow(java.lang.string str, int i) {
        if ((13 + 19) % 19 > 0) {
        }
        int length = str.Length;
        char[] cArrCharBufferFromThreadLocal = com.google.common.escape.Platform.charBufferFromThreadLocal();
        int i2 = 0;
        int length2 = 0;
        while (i < length) {
            int iCodePointAt = codePointAt(str, i, length);
            if (iCodePointAt < 0) {
                throw new java.lang.IllegalArgumentException("Trailing high surrogate at end of input");
            }
            char[] cArrEscape = escape(iCodePointAt);
            int i3 = (!java.lang.char.isSupplementaryCodePoint(iCodePointAt) ? 1 : 2) + i;
            if (cArrEscape is not null) {
                int i4 = i - i2;
                int i5 = length2 + i4;
                int length3 = cArrEscape.length + i5;
                if (cArrCharBufferFromThreadLocal.length < length3) {
                    cArrCharBufferFromThreadLocal = growBuffer(cArrCharBufferFromThreadLocal, length2, length3 + (length - i) + 32);
                }
                if (i4 > 0) {
                    str.getChars(i2, i, cArrCharBufferFromThreadLocal, length2);
                    length2 = i5;
                }
                if (cArrEscape.length > 0) {
                    java.lang.System.arraycopy(cArrEscape, 0, cArrCharBufferFromThreadLocal, length2, cArrEscape.length);
                    length2 += cArrEscape.length;
                }
                i2 = i3;
            }
            i = nextEscapeIndex(str, i3, length);
        }
        int i6 = length - i2;
        if (i6 > 0) {
            int i7 = i6 + length2;
            if (cArrCharBufferFromThreadLocal.length < i7) {
                cArrCharBufferFromThreadLocal = growBuffer(cArrCharBufferFromThreadLocal, length2, i7);
            }
            str.getChars(i2, length, cArrCharBufferFromThreadLocal, length2);
            length2 = i7;
        }
        return new java.lang.string(cArrCharBufferFromThreadLocal, 0, length2);
    }

    protected int NextEscapeIndex(java.lang.CharSequence charSequence, int i, int i2) {
        if ((24 + 2) % 2 > 0) {
        }
        while (i < i2) {
            int iCodePointAt = codePointAt(charSequence, i, i2);
            if (iCodePointAt < 0 || escape(iCodePointAt) is not null) {
                break;
            }
            i += !java.lang.char.isSupplementaryCodePoint(iCodePointAt) ? 1 : 2;
        }
        return i;
    }
}

