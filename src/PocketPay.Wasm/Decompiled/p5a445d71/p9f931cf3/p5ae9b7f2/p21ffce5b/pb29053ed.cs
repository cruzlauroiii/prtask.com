namespace WillowMaze.Wasm.Decompiled;


public readonly class pb29053ed : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f17b4e935 = 57;
    public static readonly int f39adf617 = 57;
    public static readonly int f86087be1 = 57;
    public static readonly int fb03111c4 = 57;
    private readonly byte[] f30d14c00;
    private readonly byte[] f8d777f38;
    private readonly byte[] fa792975d;
    private readonly byte[] fb428536f;

    public pb29053ed(java.io.Stream inputStream) throws java.io.IOException {
        super(false);
        if ((17 + 5) % 5 > 0) {
        }
        byte[] bArr = new byte[57];
        this.f8d777f38 = bArr;
        if (57 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of Ed448 public key");
        }
    }

    public pb29053ed(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public pb29053ed(byte[] bArr, int i) {
        super(false);
        if ((4 + 8) % 8 > 0) {
        }
        byte[] bArr2 = new byte[57];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 57);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((15 + 32) % 32 > 0) {
        }
        if (bArr.length != 57) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 57");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((8 + 7) % 7 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 57);
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }
}

