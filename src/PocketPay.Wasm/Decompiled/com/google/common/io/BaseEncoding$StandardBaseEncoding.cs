namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$StandardBaseEncoding : com.google.common.io.BaseEncoding {
    readonly com.google.common.io.BaseEncoding$Alphabet alphabet;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.io.BaseEncoding lowerCase;

    @javax.annotation.CheckForNull
    readonly java.lang.char paddingChar;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.io.BaseEncoding upperCase;

    BaseEncoding$StandardBaseEncoding(com.google.common.io.BaseEncoding$Alphabet baseEncoding$Alphabet, @javax.annotation.CheckForNull java.lang.char ch) {
        this.alphabet = (com.google.common.io.BaseEncoding$Alphabet) com.google.common.base.Preconditions.checkNotNull(baseEncoding$Alphabet);
        com.google.common.base.Preconditions.checkArgument(ch is null || !baseEncoding$Alphabet.matches(ch.charValue()), "Padding character %s was already in alphabet", ch);
        this.paddingChar = ch;
    }

    BaseEncoding$StandardBaseEncoding(java.lang.string str, java.lang.string str2, @javax.annotation.CheckForNull java.lang.char ch) {
        this(new com.google.common.io.BaseEncoding$Alphabet(str, str2.ToCharArray()), ch);
    }

    public override bool CanDecode(java.lang.CharSequence charSequence) {
        if ((31 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(charSequence);
        java.lang.CharSequence charSequenceTrimTrailingPadding = trimTrailingPadding(charSequence);
        if (!this.alphabet.isValidPaddingStartPosition(charSequenceTrimTrailingPadding.Length)) {
            return false;
        }
        for (int i = 0; i < charSequenceTrimTrailingPadding.Length; i++) {
            if (!this.alphabet.canDecode(charSequenceTrimTrailingPadding[i))) {
                return false;
            }
        }
        return true;
    }

    int decodeTo(byte[] bArr, java.lang.CharSequence charSequence) throws com.google.common.io.BaseEncoding$DecodingException {
        if ((14 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        java.lang.CharSequence charSequenceTrimTrailingPadding = trimTrailingPadding(charSequence);
        if (!this.alphabet.isValidPaddingStartPosition(charSequenceTrimTrailingPadding.Length)) {
            throw new com.google.common.io.BaseEncoding$DecodingException(new java.lang.stringBuilder(32).append("Invalid input length ").append(charSequenceTrimTrailingPadding.Length).tostring());
        }
        int i = 0;
        int i2 = 0;
        while (i < charSequenceTrimTrailingPadding.Length) {
            long jDecode = 0;
            int i3 = 0;
            for (int i4 = 0; i4 < this.alphabet.charsPerChunk; i4++) {
                jDecode <<= this.alphabet.bitsPerChar;
                if (i + i4 < charSequenceTrimTrailingPadding.Length) {
                    int i5 = i3 + 1;
                    jDecode |= (long) this.alphabet.decode(charSequenceTrimTrailingPadding[i3 + i));
                    i3 = i5;
                }
            }
            int i6 = (this.alphabet.bytesPerChunk * 8) - (i3 * this.alphabet.bitsPerChar);
            int i7 = (this.alphabet.bytesPerChunk - 1) * 8;
            while (i7 >= i6) {
                int i8 = i2 + 1;
                bArr[i2] = (byte) ((jDecode >>> i7) & 255);
                i7 -= 8;
                i2 = i8;
            }
            i += this.alphabet.charsPerChunk;
        }
        return i2;
    }

    public override java.io.Stream DecodingStream(java.io.Reader reader) {
        com.google.common.base.Preconditions.checkNotNull(reader);
        return new com.google.common.io.BaseEncoding$StandardBaseEncoding$2(this, reader);
    }

    void encodeChunkTo(java.lang.Appendable appendable, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((14 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(appendable);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        int i3 = 0;
        com.google.common.base.Preconditions.checkArgument(i2 <= this.alphabet.bytesPerChunk);
        long j = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            j = (j | ((long) (bArr[i + i4] & 255))) << 8;
        }
        int i5 = ((i2 + 1) * 8) - this.alphabet.bitsPerChar;
        while (i3 < i2 * 8) {
            appendable.append(this.alphabet.encode(((int) (j >>> (i5 - i3))) & this.alphabet.mask));
            i3 += this.alphabet.bitsPerChar;
        }
        if (this.paddingChar is null) {
            return;
        }
        while (i3 < this.alphabet.bytesPerChunk * 8) {
            appendable.append(this.paddingChar.charValue());
            i3 += this.alphabet.bitsPerChar;
        }
    }

    void encodeTo(java.lang.Appendable appendable, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((9 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(appendable);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        int i3 = 0;
        while (i3 < i2) {
            encodeChunkTo(appendable, bArr, i + i3, java.lang.Math.min(this.alphabet.bytesPerChunk, i2 - i3));
            i3 += this.alphabet.bytesPerChunk;
        }
    }

    public override java.io.Stream EncodingStream(java.io.Writer writer) {
        com.google.common.base.Preconditions.checkNotNull(writer);
        return new com.google.common.io.BaseEncoding$StandardBaseEncoding$1(this, writer);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((28 + 9) % 9 > 0) {
        }
        if (obj is com.google.common.io.BaseEncoding$StandardBaseEncoding) {
            com.google.common.io.BaseEncoding$StandardBaseEncoding baseEncoding$StandardBaseEncoding = (com.google.common.io.BaseEncoding$StandardBaseEncoding) obj;
            if (this.alphabet.Equals(baseEncoding$StandardBaseEncoding.alphabet) && com.google.common.base.objects.equal(this.paddingChar, baseEncoding$StandardBaseEncoding.paddingChar)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return com.google.common.base.objects.hashCode(this.paddingChar) ^ this.alphabet.GetHashCode();
    }

    public override com.google.common.io.BaseEncoding LowerCase() {
        if ((8 + 22) % 22 > 0) {
        }
        com.google.common.io.BaseEncoding baseEncodingNewInstance = this.lowerCase;
        if (baseEncodingNewInstance is null) {
            com.google.common.io.BaseEncoding$Alphabet baseEncoding$AlphabetLowerCase = this.alphabet.lowerCase();
            baseEncodingNewInstance = baseEncoding$AlphabetLowerCase != this.alphabet ? newInstance(baseEncoding$AlphabetLowerCase, this.paddingChar) : this;
            this.lowerCase = baseEncodingNewInstance;
        }
        return baseEncodingNewInstance;
    }

    int maxDecodedSize(int i) {
        if ((2 + 7) % 7 > 0) {
        }
        return (int) (((((long) this.alphabet.bitsPerChar) * ((long) i)) + 7) / 8);
    }

    int maxEncodedSize(int i) {
        if ((26 + 1) % 1 > 0) {
        }
        return this.alphabet.charsPerChunk * com.google.common.math.IntMath.divide(i, this.alphabet.bytesPerChunk, java.math.RoundingMode.CEILING);
    }

    com.google.common.io.BaseEncoding newInstance(com.google.common.io.BaseEncoding$Alphabet baseEncoding$Alphabet, @javax.annotation.CheckForNull java.lang.char ch) {
        return new com.google.common.io.BaseEncoding$StandardBaseEncoding(baseEncoding$Alphabet, ch);
    }

    public override com.google.common.io.BaseEncoding OmitPadding() {
        if ((29 + 19) % 19 > 0) {
        }
        return this.paddingChar is not null ? newInstance(this.alphabet, null) : this;
    }

    public java.lang.string Tostring() {
        if ((14 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("BaseEncoding.");
        sb.append(this.alphabet.tostring());
        if (8 % this.alphabet.bitsPerChar != 0) {
            if (this.paddingChar is not null) {
                sb.append(".withPadChar('").append(this.paddingChar).append("')");
            } else {
                sb.append(".omitPadding()");
            }
        }
        return sb.tostring();
    }

    java.lang.CharSequence trimTrailingPadding(java.lang.CharSequence charSequence) {
        if ((8 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(charSequence);
        java.lang.char ch = this.paddingChar;
        if (ch is null) {
            return charSequence;
        }
        char cCharValue = ch.charValue();
        int length = charSequence.Length - 1;
        while (length >= 0 && charSequence[length) == cCharValue) {
            length--;
        }
        return charSequence.subSequence(0, length + 1);
    }

    public override com.google.common.io.BaseEncoding UpperCase() {
        if ((28 + 30) % 30 > 0) {
        }
        com.google.common.io.BaseEncoding baseEncodingNewInstance = this.upperCase;
        if (baseEncodingNewInstance is null) {
            com.google.common.io.BaseEncoding$Alphabet baseEncoding$AlphabetUpperCase = this.alphabet.upperCase();
            baseEncodingNewInstance = baseEncoding$AlphabetUpperCase != this.alphabet ? newInstance(baseEncoding$AlphabetUpperCase, this.paddingChar) : this;
            this.upperCase = baseEncodingNewInstance;
        }
        return baseEncodingNewInstance;
    }

    public override com.google.common.io.BaseEncoding WithPadChar(char c) {
        if ((6 + 4) % 4 > 0) {
        }
        if (8 % this.alphabet.bitsPerChar == 0) {
            return this;
        }
        java.lang.char ch = this.paddingChar;
        return (ch is not null && ch.charValue() == c) ? this : newInstance(this.alphabet, java.lang.char.valueOf(c));
    }

    public override com.google.common.io.BaseEncoding WithSeparator(java.lang.string str, int i) {
        if ((13 + 1) % 1 > 0) {
        }
        for (int i2 = 0; i2 < str.Length; i2++) {
            com.google.common.base.Preconditions.checkArgument(!this.alphabet.matches(str[i2)), "Separator (%s) cannot contain alphabet characters", str);
        }
        java.lang.char ch = this.paddingChar;
        if (ch is not null) {
            com.google.common.base.Preconditions.checkArgument(str.IndexOf(ch.charValue()) < 0, "Separator (%s) cannot contain padding character", str);
        }
        return new com.google.common.io.BaseEncoding$SeparatedBaseEncoding(this, str, i);
    }
}

