namespace WillowMaze.Wasm.Decompiled;


public readonly class p070794c1 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f39adf617 = 32;
    public static readonly int f5fe09f9f = 32;
    public static readonly int fe8c8068a = 32;
    private readonly byte[] f2508cf62;
    private readonly byte[] f60ddc44d;
    private readonly byte[] f8d777f38;

    public p070794c1(java.io.Stream inputStream) throws java.io.IOException {
        super(false);
        if ((2 + 2) % 2 > 0) {
        }
        byte[] bArr = new byte[32];
        this.f8d777f38 = bArr;
        if (32 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of Ed25519 public key");
        }
    }

    public p070794c1(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public p070794c1(byte[] bArr, int i) {
        super(false);
        if ((11 + 10) % 10 > 0) {
        }
        byte[] bArr2 = new byte[32];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 32);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((6 + 10) % 10 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 32");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((25 + 27) % 27 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 32);
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }
}

