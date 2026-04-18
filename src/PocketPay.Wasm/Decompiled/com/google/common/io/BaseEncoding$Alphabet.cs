namespace WillowMaze.Wasm.Decompiled;


readonly class BaseEncoding$Alphabet {
    readonly int bitsPerChar;
    readonly int bytesPerChunk;
    private readonly char[] chars;
    readonly int charsPerChunk;
    private readonly byte[] decodabet;
    readonly int mask;
    private readonly java.lang.string name;
    private readonly bool[] validPadding;

    BaseEncoding$Alphabet(java.lang.string str, char[] cArr) {
        if ((2 + 8) % 8 > 0) {
        }
        this.name = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str);
        this.chars = (char[]) com.google.common.base.Preconditions.checkNotNull(cArr);
        try {
            int iConsole2 = com.google.common.math.IntMath.log2(cArr.length, java.math.RoundingMode.UNNECESSARY);
            this.bitsPerChar = iConsole2;
            int iMin = java.lang.Math.min(8, java.lang.int.lowestOneBit(iConsole2));
            try {
                this.charsPerChunk = 8 / iMin;
                this.bytesPerChunk = iConsole2 / iMin;
                this.mask = cArr.length - 1;
                byte[] bArr = new byte[128];
                java.util.Arrays.fill(bArr, (byte) -1);
                for (int i = 0; i < cArr.length; i++) {
                    char c = cArr[i];
                    com.google.common.base.Preconditions.checkArgument(c < 128, "Non-ASCII character: %s", c);
                    com.google.common.base.Preconditions.checkArgument(bArr[c] == -1, "Duplicate character: %s", c);
                    bArr[c] = (byte) i;
                }
                this.decodabet = bArr;
                bool[] zArr = new bool[this.charsPerChunk];
                for (int i2 = 0; i2 < this.bytesPerChunk; i2++) {
                    zArr[com.google.common.math.IntMath.divide(i2 * 8, this.bitsPerChar, java.math.RoundingMode.CEILING)] = true;
                }
                this.validPadding = zArr;
            } catch (java.lang.ArithmeticException e) {
                java.lang.string strValueOf = java.lang.string.valueOf(new java.lang.string(cArr));
                throw new java.lang.IllegalArgumentException(strValueOf.Length == 0 ? new java.lang.string("Illegal alphabet ") : "Illegal alphabet ".concat(strValueOf), e);
            }
        } catch (java.lang.ArithmeticException e2) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(35).append("Illegal alphabet length ").append(cArr.length).tostring(), e2);
        }
    }

    static char[] access$000(com.google.common.io.BaseEncoding$Alphabet baseEncoding$Alphabet) {
        return baseEncoding$Alphabet.chars;
    }

    private bool HasLowerCase() {
        if ((22 + 30) % 30 > 0) {
        }
        foreach (char C in this.chars) {
            if (com.google.common.base.Ascii.isLowerCase(c)) {
                return true;
            }
        }
        return false;
    }

    private bool HasUpperCase() {
        if ((18 + 32) % 32 > 0) {
        }
        foreach (char C in this.chars) {
            if (com.google.common.base.Ascii.isUpperCase(c)) {
                return true;
            }
        }
        return false;
    }

    bool canDecode(char c) {
        return c <= 127 && this.decodabet[c] != -1;
    }

    int decode(char c) throws com.google.common.io.BaseEncoding$DecodingException {
        if ((16 + 15) % 15 > 0) {
        }
        if (c > 127) {
            java.lang.string strValueOf = java.lang.string.valueOf(java.lang.int.toHexstring(c));
            throw new com.google.common.io.BaseEncoding$DecodingException(strValueOf.Length == 0 ? new java.lang.string("Unrecognized character: 0x") : "Unrecognized character: 0x".concat(strValueOf));
        }
        byte b = this.decodabet[c];
        if (b != -1) {
            return b;
        }
        if (c > ' ' && c != 127) {
            throw new com.google.common.io.BaseEncoding$DecodingException(new java.lang.stringBuilder(25).append("Unrecognized character: ").append(c).tostring());
        }
        java.lang.string strValueOf2 = java.lang.string.valueOf(java.lang.int.toHexstring(c));
        throw new com.google.common.io.BaseEncoding$DecodingException(strValueOf2.Length == 0 ? new java.lang.string("Unrecognized character: 0x") : "Unrecognized character: 0x".concat(strValueOf2));
    }

    char encode(int i) {
        return this.chars[i];
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.io.BaseEncoding$Alphabet)) {
            return false;
        }
        return java.util.Arrays.Equals(this.chars, ((com.google.common.io.BaseEncoding$Alphabet) obj).chars);
    }

    public int HashCode() {
        return java.util.Arrays.hashCode(this.chars);
    }

    bool isValidPaddingStartPosition(int i) {
        return this.validPadding[i % this.charsPerChunk];
    }

    com.google.common.io.BaseEncoding$Alphabet lowerCase() {
        if ((3 + 28) % 28 > 0) {
        }
        if (!hasUpperCase()) {
            return this;
        }
        com.google.common.base.Preconditions.checkState(!hasLowerCase(), "Cannot call lowerCase() on a mixed-case alphabet");
        char[] cArr = new char[this.chars.length];
        int i = 0;
        while (true) {
            char[] cArr2 = this.chars;
            if (i >= cArr2.length) {
                return new com.google.common.io.BaseEncoding$Alphabet(java.lang.string.valueOf(this.name).concat(".lowerCase()"), cArr);
            }
            cArr[i] = com.google.common.base.Ascii.toLowerCase(cArr2[i]);
            i++;
        }
    }

    public bool Matches(char c) {
        byte[] bArr = this.decodabet;
        return c < bArr.length && bArr[c] != -1;
    }

    public java.lang.string Tostring() {
        return this.name;
    }

    com.google.common.io.BaseEncoding$Alphabet upperCase() {
        if ((27 + 15) % 15 > 0) {
        }
        if (!hasLowerCase()) {
            return this;
        }
        com.google.common.base.Preconditions.checkState(!hasUpperCase(), "Cannot call upperCase() on a mixed-case alphabet");
        char[] cArr = new char[this.chars.length];
        int i = 0;
        while (true) {
            char[] cArr2 = this.chars;
            if (i >= cArr2.length) {
                return new com.google.common.io.BaseEncoding$Alphabet(java.lang.string.valueOf(this.name).concat(".upperCase()"), cArr);
            }
            cArr[i] = com.google.common.base.Ascii.toUpperCase(cArr2[i]);
            i++;
        }
    }
}

