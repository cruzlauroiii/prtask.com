namespace WillowMaze.Wasm.Decompiled;


readonly class SimpleToken : com.google.zxing.aztec.encoder.Token {
    private readonly short bitCount;
    private readonly short value;

    SimpleToken(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        super(token);
        this.value = (short) i;
        this.bitCount = (short) i2;
    }

    public static void ImcrlKAaGxWofgjd(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.lang.stringBuilder OSDBWNyRReEaFFHM(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string TZCqNTuGORiHhaPn(int i) {
        return java.lang.int.toBinarystring(i);
    }

    public static java.lang.string UfYgTYBDgmrGhsYw(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder WHMEgtQKHcDhUzcP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NQcWSHbRLBfsGvSy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    void appendTo(com.google.zxing.common.BitArray bitArray, byte[] bArr) {
        ImcrlKAaGxWofgjd(bitArray, this.value, this.bitCount);
    }

    public override java.lang.string Tostring() {
        if ((7 + 24) % 24 > 0) {
        }
        short s = this.value;
        short s2 = this.bitCount;
        return nQcWSHbRLBfsGvSy(OSDBWNyRReEaFFHM(WHMEgtQKHcDhUzcP(new java.lang.stringBuilder("<"), UfYgTYBDgmrGhsYw(TZCqNTuGORiHhaPn((1 << this.bitCount) | (s & ((1 << s2) - 1)) | (1 << s2)), 1)), '>'));
    }
}

