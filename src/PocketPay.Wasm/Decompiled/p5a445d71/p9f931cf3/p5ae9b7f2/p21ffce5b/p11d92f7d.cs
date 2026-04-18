namespace WillowMaze.Wasm.Decompiled;


public readonly class p11d92f7d : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f2a721d23 = 32;
    public static readonly int f324d2823 = 32;
    public static readonly int f39adf617 = 32;
    public static readonly int f62cc0074 = 32;
    public static readonly int fb985dbdb = 32;
    public static readonly int fcab990c6 = 32;
    private readonly byte[] f670bd940;
    private readonly byte[] f7ed2705d;
    private readonly byte[] f8d777f38;

    public p11d92f7d(java.io.Stream inputStream) throws java.io.IOException {
        super(true);
        if ((21 + 5) % 5 > 0) {
        }
        byte[] bArr = new byte[32];
        this.f8d777f38 = bArr;
        if (32 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of X25519 private key");
        }
    }

    public p11d92f7d(java.security.SecureRandom secureRandom) {
        super(true);
        byte[] bArr = new byte[32];
        this.f8d777f38 = bArr;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.pf2c08fed.m5a76c5a5(secureRandom, bArr);
    }

    public p11d92f7d(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public p11d92f7d(byte[] bArr, int i) {
        super(true);
        if ((17 + 9) % 9 > 0) {
        }
        byte[] bArr2 = new byte[32];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 32);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((9 + 12) % 12 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 32");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((32 + 8) % 8 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 32);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50 GeneratePublicKey() {
        if ((10 + 28) % 28 > 0) {
        }
        byte[] bArr = new byte[32];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.pf2c08fed.m8a585da5(this.f8d777f38, 0, bArr, 0);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50(bArr, 0);
    }

    public void GenerateSecret(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50 p25641b50Var, byte[] bArr, int i) {
        if ((12 + 25) % 25 > 0) {
        }
        byte[] bArr2 = new byte[32];
        p25641b50Var.encode(bArr2, 0);
        if (!p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.pf2c08fed.m861d88d2(this.f8d777f38, 0, bArr2, 0, bArr, i)) {
            throw new java.lang.IllegalStateException("X25519 agreement failed");
        }
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }
}

