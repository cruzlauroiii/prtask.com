namespace WillowMaze.Wasm.Decompiled;


public readonly class p62f08e75 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f0be23cac = 56;
    public static readonly int f0cf92c60 = 56;
    public static readonly int f39adf617 = 56;
    public static readonly int fb985dbdb = 56;
    private readonly byte[] f8d777f38;
    private readonly byte[] fa034466d;

    public p62f08e75(java.io.Stream inputStream) throws java.io.IOException {
        super(true);
        if ((29 + 17) % 17 > 0) {
        }
        byte[] bArr = new byte[56];
        this.f8d777f38 = bArr;
        if (56 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of X448 private key");
        }
    }

    public p62f08e75(java.security.SecureRandom secureRandom) {
        super(true);
        byte[] bArr = new byte[56];
        this.f8d777f38 = bArr;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a.m5a76c5a5(secureRandom, bArr);
    }

    public p62f08e75(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public p62f08e75(byte[] bArr, int i) {
        super(true);
        if ((28 + 3) % 3 > 0) {
        }
        byte[] bArr2 = new byte[56];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 56);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((23 + 7) % 7 > 0) {
        }
        if (bArr.length != 56) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 56");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((24 + 8) % 8 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 56);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5 GeneratePublicKey() {
        if ((9 + 27) % 27 > 0) {
        }
        byte[] bArr = new byte[56];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a.m8a585da5(this.f8d777f38, 0, bArr, 0);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5(bArr, 0);
    }

    public void GenerateSecret(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5 p2e18ebd5Var, byte[] bArr, int i) {
        if ((26 + 10) % 10 > 0) {
        }
        byte[] bArr2 = new byte[56];
        p2e18ebd5Var.encode(bArr2, 0);
        if (!p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a.m861d88d2(this.f8d777f38, 0, bArr2, 0, bArr, i)) {
            throw new java.lang.IllegalStateException("X448 agreement failed");
        }
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }
}

