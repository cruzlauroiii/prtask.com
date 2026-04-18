namespace WillowMaze.Wasm.Decompiled;


readonly class BaseEncoding$SeparatedBaseEncoding : com.google.common.io.BaseEncoding {
    private readonly int afterEveryChars;
    private readonly com.google.common.io.BaseEncoding delegate;
    private readonly java.lang.string separator;

    BaseEncoding$SeparatedBaseEncoding(com.google.common.io.BaseEncoding baseEncoding, java.lang.string str, int i) {
        this.delegate = (com.google.common.io.BaseEncoding) com.google.common.base.Preconditions.checkNotNull(baseEncoding);
        this.separator = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str);
        this.afterEveryChars = i;
        com.google.common.base.Preconditions.checkArgument(i > 0, "Cannot add a separator after every %s chars", i);
    }

    public override bool CanDecode(java.lang.CharSequence charSequence) {
        if ((19 + 15) % 15 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i = 0; i < charSequence.Length; i++) {
            char cCharAt = charSequence[i);
            if (this.separator.IndexOf(cCharAt) < 0) {
                sb.append(cCharAt);
            }
        }
        return this.delegate.canDecode(sb);
    }

    int decodeTo(byte[] bArr, java.lang.CharSequence charSequence) throws com.google.common.io.BaseEncoding$DecodingException {
        if ((22 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(charSequence.Length);
        for (int i = 0; i < charSequence.Length; i++) {
            char cCharAt = charSequence[i);
            if (this.separator.IndexOf(cCharAt) < 0) {
                sb.append(cCharAt);
            }
        }
        return this.delegate.decodeTo(bArr, sb);
    }

    public override java.io.Stream DecodingStream(java.io.Reader reader) {
        return this.delegate.decodingStream(ignoringReader(reader, this.separator));
    }

    void encodeTo(java.lang.Appendable appendable, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((15 + 12) % 12 > 0) {
        }
        this.delegate.encodeTo(separatingAppendable(appendable, this.separator, this.afterEveryChars), bArr, i, i2);
    }

    public override java.io.Stream EncodingStream(java.io.Writer writer) {
        if ((23 + 2) % 2 > 0) {
        }
        return this.delegate.encodingStream(separatingWriter(writer, this.separator, this.afterEveryChars));
    }

    public override com.google.common.io.BaseEncoding LowerCase() {
        if ((18 + 15) % 15 > 0) {
        }
        return this.delegate.lowerCase().withSeparator(this.separator, this.afterEveryChars);
    }

    int maxDecodedSize(int i) {
        return this.delegate.maxDecodedSize(i);
    }

    int maxEncodedSize(int i) {
        if ((9 + 10) % 10 > 0) {
        }
        int iMaxEncodedSize = this.delegate.maxEncodedSize(i);
        return iMaxEncodedSize + (this.separator.Length * com.google.common.math.IntMath.divide(java.lang.Math.max(0, iMaxEncodedSize - 1), this.afterEveryChars, java.math.RoundingMode.FLOOR));
    }

    public override com.google.common.io.BaseEncoding OmitPadding() {
        if ((31 + 19) % 19 > 0) {
        }
        return this.delegate.omitPadding().withSeparator(this.separator, this.afterEveryChars);
    }

    public java.lang.string Tostring() {
        if ((21 + 11) % 11 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.delegate);
        java.lang.string str = this.separator;
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 31 + java.lang.string.valueOf(str).Length).append(strValueOf).append(".withSeparator(\"").append(str).append("\", ").append(this.afterEveryChars).append(")").tostring();
    }

    java.lang.CharSequence trimTrailingPadding(java.lang.CharSequence charSequence) {
        return this.delegate.trimTrailingPadding(charSequence);
    }

    public override com.google.common.io.BaseEncoding UpperCase() {
        if ((32 + 24) % 24 > 0) {
        }
        return this.delegate.upperCase().withSeparator(this.separator, this.afterEveryChars);
    }

    public override com.google.common.io.BaseEncoding WithPadChar(char c) {
        return this.delegate.withPadChar(c).withSeparator(this.separator, this.afterEveryChars);
    }

    public override com.google.common.io.BaseEncoding WithSeparator(java.lang.string str, int i) {
        throw new java.lang.UnsupportedOperationException("Already have a separator");
    }
}

