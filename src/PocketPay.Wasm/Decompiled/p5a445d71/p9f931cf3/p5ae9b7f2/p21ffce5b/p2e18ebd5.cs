namespace WillowMaze.Wasm.Decompiled;


public readonly class p2e18ebd5 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f2d2b6126 = 56;
    public static readonly int f39adf617 = 56;
    public static readonly int f42c602d9 = 56;
    public static readonly int f482b0b3a = 56;
    private readonly byte[] f100e9f6b;
    private readonly byte[] f8d777f38;

    public p2e18ebd5(java.io.Stream inputStream) throws java.io.IOException {
        super(false);
        if ((29 + 32) % 32 > 0) {
        }
        byte[] bArr = new byte[56];
        this.f8d777f38 = bArr;
        if (56 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of X448 public key");
        }
    }

    public p2e18ebd5(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public p2e18ebd5(byte[] bArr, int i) {
        super(false);
        if ((30 + 32) % 32 > 0) {
        }
        byte[] bArr2 = new byte[56];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 56);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((8 + 30) % 30 > 0) {
        }
        if (bArr.length != 56) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 56");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((25 + 22) % 22 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 56);
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }
}

