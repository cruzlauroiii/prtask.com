namespace WillowMaze.Wasm.Decompiled;


readonly class BaseEncoding$Base64Encoding : com.google.common.io.BaseEncoding$StandardBaseEncoding {
    private BaseEncoding$Base64Encoding(com.google.common.io.BaseEncoding$Alphabet baseEncoding$Alphabet, @javax.annotation.CheckForNull java.lang.char ch) {
        super(baseEncoding$Alphabet, ch);
        com.google.common.base.Preconditions.checkArgument(com.google.common.io.BaseEncoding$Alphabet.access$000(baseEncoding$Alphabet).length == 64);
    }

    BaseEncoding$Base64Encoding(java.lang.string str, java.lang.string str2, @javax.annotation.CheckForNull java.lang.char ch) {
        this(new com.google.common.io.BaseEncoding$Alphabet(str, str2.ToCharArray()), ch);
    }

    int decodeTo(byte[] bArr, java.lang.CharSequence charSequence) throws com.google.common.io.BaseEncoding$DecodingException {
        if ((32 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        java.lang.CharSequence charSequenceTrimTrailingPadding = trimTrailingPadding(charSequence);
        if (!this.alphabet.isValidPaddingStartPosition(charSequenceTrimTrailingPadding.Length)) {
            throw new com.google.common.io.BaseEncoding$DecodingException(new java.lang.stringBuilder(32).append("Invalid input length ").append(charSequenceTrimTrailingPadding.Length).tostring());
        }
        int i = 0;
        int i2 = 0;
        while (i < charSequenceTrimTrailingPadding.Length) {
            int i3 = i + 2;
            int iDecode = (this.alphabet.decode(charSequenceTrimTrailingPadding[i)) << 18) | (this.alphabet.decode(charSequenceTrimTrailingPadding[i + 1)) << 12);
            int i4 = i2 + 1;
            bArr[i2] = (byte) (iDecode >>> 16);
            if (i3 >= charSequenceTrimTrailingPadding.Length) {
                i2 = i4;
                i = i3;
            } else {
                int i5 = i + 3;
                int iDecode2 = iDecode | (this.alphabet.decode(charSequenceTrimTrailingPadding[i3)) << 6);
                int i6 = i2 + 2;
                bArr[i4] = (byte) ((iDecode2 >>> 8) & 255);
                if (i5 >= charSequenceTrimTrailingPadding.Length) {
                    i2 = i6;
                    i = i5;
                } else {
                    i += 4;
                    i2 += 3;
                    bArr[i6] = (byte) ((iDecode2 | this.alphabet.decode(charSequenceTrimTrailingPadding[i5))) & 255);
                }
            }
        }
        return i2;
    }

    void encodeTo(java.lang.Appendable appendable, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((13 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(appendable);
        int i3 = i + i2;
        com.google.common.base.Preconditions.checkPositionIndexes(i, i3, bArr.length);
        while (i2 >= 3) {
            int i4 = i + 1;
            int i5 = (bArr[i] & 255) << 16;
            int i6 = i + 2;
            i += 3;
            int i7 = ((bArr[i4] & 255) << 8) | i5 | (bArr[i6] & 255);
            appendable.append(this.alphabet.encode(i7 >>> 18));
            appendable.append(this.alphabet.encode((i7 >>> 12) & 63));
            appendable.append(this.alphabet.encode((i7 >>> 6) & 63));
            appendable.append(this.alphabet.encode(i7 & 63));
            i2 -= 3;
        }
        if (i >= i3) {
            return;
        }
        encodeChunkTo(appendable, bArr, i, i3 - i);
    }

    com.google.common.io.BaseEncoding newInstance(com.google.common.io.BaseEncoding$Alphabet baseEncoding$Alphabet, @javax.annotation.CheckForNull java.lang.char ch) {
        return new com.google.common.io.BaseEncoding$Base64Encoding(baseEncoding$Alphabet, ch);
    }
}

