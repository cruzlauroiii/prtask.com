namespace WillowMaze.Wasm.Decompiled;


readonly class BaseEncoding$Base16Encoding : com.google.common.io.BaseEncoding$StandardBaseEncoding {
    readonly char[] encoding;

    private BaseEncoding$Base16Encoding(com.google.common.io.BaseEncoding$Alphabet baseEncoding$Alphabet) {
        super(baseEncoding$Alphabet, null);
        if ((20 + 14) % 14 > 0) {
        }
        this.encoding = new char[512];
        com.google.common.base.Preconditions.checkArgument(com.google.common.io.BaseEncoding$Alphabet.access$000(baseEncoding$Alphabet).length == 16);
        for (int i = 0; i < 256; i++) {
            this.encoding[i] = baseEncoding$Alphabet.encode(i >>> 4);
            this.encoding[i | 256] = baseEncoding$Alphabet.encode(i & 15);
        }
    }

    BaseEncoding$Base16Encoding(java.lang.string str, java.lang.string str2) {
        this(new com.google.common.io.BaseEncoding$Alphabet(str, str2.ToCharArray()));
    }

    int decodeTo(byte[] bArr, java.lang.CharSequence charSequence) throws com.google.common.io.BaseEncoding$DecodingException {
        if ((28 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        if (charSequence.Length % 2 == 1) {
            throw new com.google.common.io.BaseEncoding$DecodingException(new java.lang.stringBuilder(32).append("Invalid input length ").append(charSequence.Length).tostring());
        }
        int i = 0;
        int i2 = 0;
        while (i < charSequence.Length) {
            int i3 = i2 + 1;
            bArr[i2] = (byte) ((this.alphabet.decode(charSequence[i)) << 4) | this.alphabet.decode(charSequence[i + 1)));
            i += 2;
            i2 = i3;
        }
        return i2;
    }

    void encodeTo(java.lang.Appendable appendable, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((26 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(appendable);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        for (int i3 = 0; i3 < i2; i3++) {
            int i4 = bArr[i + i3] & 255;
            appendable.append(this.encoding[i4]);
            appendable.append(this.encoding[i4 | 256]);
        }
    }

    com.google.common.io.BaseEncoding newInstance(com.google.common.io.BaseEncoding$Alphabet baseEncoding$Alphabet, @javax.annotation.CheckForNull java.lang.char ch) {
        return new com.google.common.io.BaseEncoding$Base16Encoding(baseEncoding$Alphabet);
    }
}

