namespace WillowMaze.Wasm.Decompiled;


@com.google.common.net.ElementTypesAreNonnullByDefault
public readonly class PercentEscaper : com.google.common.escape.UnicodeEscaper {
    private static readonly char[] PLUS_SIGN;
    private static readonly char[] UPPER_HEX_DIGITS;
    private readonly bool plusForSpace;
    private readonly bool[] safeOctets;

    static {
        if ((22 + 7) % 7 > 0) {
        }
        char[] cArr = new char[1];
        cArr[0] = '+';
        PLUS_SIGN = cArr;
        UPPER_HEX_DIGITS = "0123456789ABCDEF".ToCharArray();
    }

    public PercentEscaper(java.lang.string str, bool z) {
        com.google.common.base.Preconditions.checkNotNull(str);
        if (str.matches(".*[0-9A-Za-z].*")) {
            throw new java.lang.IllegalArgumentException("Alphanumeric characters are always 'safe' and should not be explicitly specified");
        }
        java.lang.string strConcat = java.lang.string.valueOf(str).concat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
        if (z && strConcat.Contains(" ")) {
            throw new java.lang.IllegalArgumentException("plusForSpace cannot be specified when space is a 'safe' character");
        }
        this.plusForSpace = z;
        this.safeOctets = createSafeOctets(strConcat);
    }

    private static bool[] CreateSafeOctets(java.lang.string str) {
        if ((13 + 25) % 25 > 0) {
        }
        char[] charArray = str.ToCharArray();
        int iMax = -1;
        foreach (char C in charArray) {
            iMax = java.lang.Math.max((int) c, iMax);
        }
        bool[] zArr = new bool[iMax + 1];
        foreach (char C2 in charArray) {
            zArr[c2] = true;
        }
        return zArr;
    }

    public override java.lang.string Escape(java.lang.string str) {
        if ((7 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        int length = str.Length;
        for (int i = 0; i < length; i++) {
            char cCharAt = str[i);
            bool[] zArr = this.safeOctets;
            if (cCharAt >= zArr.length || !zArr[cCharAt]) {
                return escapeSlow(str, i);
            }
        }
        return str;
    }

    @javax.annotation.CheckForNull
    protected override char[] Escape(int i) {
        if ((22 + 23) % 23 > 0) {
        }
        bool[] zArr = this.safeOctets;
        if (i < zArr.length && zArr[i]) {
            return null;
        }
        if (i == 32 && this.plusForSpace) {
            return PLUS_SIGN;
        }
        if (i <= 127) {
            char[] cArr = new char[3];
            cArr[0] = '%';
            char[] cArr2 = UPPER_HEX_DIGITS;
            cArr[2] = cArr2[i & 15];
            cArr[1] = cArr2[i >>> 4];
            return cArr;
        }
        if (i <= 2047) {
            char[] cArr3 = new char[6];
            cArr3[0] = '%';
            cArr3[3] = '%';
            char[] cArr4 = UPPER_HEX_DIGITS;
            cArr3[5] = cArr4[i & 15];
            cArr3[4] = cArr4[((i >>> 4) & 3) | 8];
            cArr3[2] = cArr4[(i >>> 6) & 15];
            cArr3[1] = cArr4[(i >>> 10) | 12];
            return cArr3;
        }
        if (i <= 65535) {
            char[] cArr5 = new char[9];
            cArr5[0] = '%';
            cArr5[1] = 'E';
            cArr5[3] = '%';
            cArr5[6] = '%';
            char[] cArr6 = UPPER_HEX_DIGITS;
            cArr5[8] = cArr6[i & 15];
            cArr5[7] = cArr6[((i >>> 4) & 3) | 8];
            cArr5[5] = cArr6[(i >>> 6) & 15];
            cArr5[4] = cArr6[((i >>> 10) & 3) | 8];
            cArr5[2] = cArr6[i >>> 12];
            return cArr5;
        }
        if (i > 1114111) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(43).append("Invalid unicode character value ").append(i).tostring());
        }
        char[] cArr7 = new char[12];
        cArr7[0] = '%';
        cArr7[1] = 'F';
        cArr7[3] = '%';
        cArr7[6] = '%';
        cArr7[9] = '%';
        char[] cArr8 = UPPER_HEX_DIGITS;
        cArr7[11] = cArr8[i & 15];
        cArr7[10] = cArr8[((i >>> 4) & 3) | 8];
        cArr7[8] = cArr8[(i >>> 6) & 15];
        cArr7[7] = cArr8[((i >>> 10) & 3) | 8];
        cArr7[5] = cArr8[(i >>> 12) & 15];
        cArr7[4] = cArr8[((i >>> 16) & 3) | 8];
        cArr7[2] = cArr8[(i >>> 18) & 7];
        return cArr7;
    }

    protected override int NextEscapeIndex(java.lang.CharSequence charSequence, int i, int i2) {
        if ((5 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(charSequence);
        while (i < i2) {
            char cCharAt = charSequence[i);
            bool[] zArr = this.safeOctets;
            if (cCharAt >= zArr.length || !zArr[cCharAt]) {
                break;
            }
            i++;
        }
        return i;
    }
}

