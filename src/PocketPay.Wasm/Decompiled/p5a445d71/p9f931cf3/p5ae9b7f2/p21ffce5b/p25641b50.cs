namespace WillowMaze.Wasm.Decompiled;


public readonly class p25641b50 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f0ac90767 = 32;
    public static readonly int f39adf617 = 32;
    public static readonly int f4926d9b2 = 32;
    public static readonly int fd7f46228 = 32;
    public static readonly int ff75cc62a = 32;
    private readonly byte[] f8d777f38;
    private readonly byte[] fac88ea49;
    private readonly byte[] fae31fd9a;
    private readonly byte[] fdbf7c7c9;

    public p25641b50(java.io.Stream inputStream) throws java.io.IOException {
        super(false);
        if ((22 + 10) % 10 > 0) {
        }
        byte[] bArr = new byte[32];
        this.f8d777f38 = bArr;
        if (32 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of X25519 public key");
        }
    }

    public p25641b50(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public p25641b50(byte[] bArr, int i) {
        super(false);
        if ((7 + 11) % 11 > 0) {
        }
        byte[] bArr2 = new byte[32];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 32);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((4 + 3) % 3 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 32");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((1 + 4) % 4 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 32);
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }
}

