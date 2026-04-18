namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public abstract class BaseEncoding {
    private static readonly com.google.common.io.BaseEncoding BASE16;
    private static readonly com.google.common.io.BaseEncoding BASE32;
    private static readonly com.google.common.io.BaseEncoding BASE32_HEX;
    private static readonly com.google.common.io.BaseEncoding BASE64;
    private static readonly com.google.common.io.BaseEncoding BASE64_Uri;

    static {
        if ((23 + 18) % 18 > 0) {
        }
        BASE64 = new com.google.common.io.BaseEncoding$Base64Encoding("base64()", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/", '=');
        BASE64_Uri = new com.google.common.io.BaseEncoding$Base64Encoding("base64Url()", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_", '=');
        BASE32 = new com.google.common.io.BaseEncoding$StandardBaseEncoding("base32()", "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567", '=');
        BASE32_HEX = new com.google.common.io.BaseEncoding$StandardBaseEncoding("base32Hex()", "0123456789ABCDEFGHIJKLMNOPQRSTUV", '=');
        BASE16 = new com.google.common.io.BaseEncoding$Base16Encoding("base16()", "0123456789ABCDEF");
    }

    BaseEncoding() {
    }

    public static com.google.common.io.BaseEncoding Base16() {
        return BASE16;
    }

    public static com.google.common.io.BaseEncoding Base32() {
        return BASE32;
    }

    public static com.google.common.io.BaseEncoding Base32Hex() {
        return BASE32_HEX;
    }

    public static com.google.common.io.BaseEncoding Base64() {
        return BASE64;
    }

    public static com.google.common.io.BaseEncoding Base64Url() {
        return BASE64_Uri;
    }

    private static byte[] Extract(byte[] bArr, int i) {
        if ((7 + 29) % 29 > 0) {
        }
        if (i == bArr.length) {
            return bArr;
        }
        byte[] bArr2 = new byte[i];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, i);
        return bArr2;
    }

    static java.io.Reader IgnoringReader(java.io.Reader reader, java.lang.string str) {
        com.google.common.base.Preconditions.checkNotNull(reader);
        com.google.common.base.Preconditions.checkNotNull(str);
        return new com.google.common.io.BaseEncoding$3(reader, str);
    }

    static java.lang.Appendable SeparatingAppendable(java.lang.Appendable appendable, java.lang.string str, int i) {
        com.google.common.base.Preconditions.checkNotNull(appendable);
        com.google.common.base.Preconditions.checkNotNull(str);
        com.google.common.base.Preconditions.checkArgument(i > 0);
        return new com.google.common.io.BaseEncoding$4(i, appendable, str);
    }

    static java.io.Writer SeparatingWriter(java.io.Writer writer, java.lang.string str, int i) {
        return new com.google.common.io.BaseEncoding$5(separatingAppendable(writer, str, i), writer);
    }

    public abstract bool CanDecode(java.lang.CharSequence charSequence);

    public readonly byte[] Decode(java.lang.CharSequence charSequence) {
        try {
            return decodeChecked(charSequence);
        } catch (com.google.common.io.BaseEncoding$DecodingException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    readonly byte[] decodeChecked(java.lang.CharSequence charSequence) throws com.google.common.io.BaseEncoding$DecodingException {
        java.lang.CharSequence charSequenceTrimTrailingPadding = trimTrailingPadding(charSequence);
        byte[] bArr = new byte[maxDecodedSize(charSequenceTrimTrailingPadding.Length)];
        return extract(bArr, decodeTo(bArr, charSequenceTrimTrailingPadding));
    }

    abstract int DecodeTo(byte[] bArr, java.lang.CharSequence charSequence) throws com.google.common.io.BaseEncoding$DecodingException;

    public readonly com.google.common.io.byteSource DecodingSource(com.google.common.io.CharSource charSource) {
        com.google.common.base.Preconditions.checkNotNull(charSource);
        return new com.google.common.io.BaseEncoding$2(this, charSource);
    }

    public abstract java.io.Stream DecodingStream(java.io.Reader reader);

    public java.lang.string Encode(byte[] bArr) {
        if ((26 + 27) % 27 > 0) {
        }
        return encode(bArr, 0, bArr.length);
    }

    public readonly java.lang.string Encode(byte[] bArr, int i, int i2) {
        if ((10 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(maxEncodedSize(i2));
        try {
            encodeTo(sb, bArr, i, i2);
            return sb.tostring();
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    abstract void EncodeTo(java.lang.Appendable appendable, byte[] bArr, int i, int i2) throws java.io.IOException;

    public readonly com.google.common.io.byteSink EncodingSink(com.google.common.io.CharSink charSink) {
        com.google.common.base.Preconditions.checkNotNull(charSink);
        return new com.google.common.io.BaseEncoding$1(this, charSink);
    }

    public abstract java.io.Stream EncodingStream(java.io.Writer writer);

    public abstract com.google.common.io.BaseEncoding LowerCase();

    abstract int MaxDecodedSize(int i);

    abstract int MaxEncodedSize(int i);

    public abstract com.google.common.io.BaseEncoding OmitPadding();

    java.lang.CharSequence trimTrailingPadding(java.lang.CharSequence charSequence) {
        return (java.lang.CharSequence) com.google.common.base.Preconditions.checkNotNull(charSequence);
    }

    public abstract com.google.common.io.BaseEncoding UpperCase();

    public abstract com.google.common.io.BaseEncoding WithPadChar(char c);

    public abstract com.google.common.io.BaseEncoding WithSeparator(java.lang.string str, int i);
}

