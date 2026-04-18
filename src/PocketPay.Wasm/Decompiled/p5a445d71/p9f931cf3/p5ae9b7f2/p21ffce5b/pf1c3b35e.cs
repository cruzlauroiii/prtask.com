namespace WillowMaze.Wasm.Decompiled;


public readonly class pf1c3b35e : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f1d8947d4 = 57;
    public static readonly int f27e5e2b6 = 114;
    public static readonly int f39adf617 = 57;
    public static readonly int fb101f58b = 57;
    public static readonly int fba2f5352 = 114;
    public static readonly int fd178e040 = 114;
    public static readonly int ff2c2078e = 114;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f06ea897c;
    private readonly byte[] f22149ec7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f2b2b8b4b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f3dcbf7aa;
    private readonly byte[] f69fa3d0b;
    private readonly byte[] f6a5c48a6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f6c732121;
    private readonly byte[] f8d777f38;
    private readonly byte[] fd1ea6e9c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed fd78f957a;

    public pf1c3b35e(java.io.Stream inputStream) throws java.io.IOException {
        super(true);
        if ((29 + 29) % 29 > 0) {
        }
        byte[] bArr = new byte[57];
        this.f8d777f38 = bArr;
        if (57 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of Ed448 private key");
        }
    }

    public pf1c3b35e(java.security.SecureRandom secureRandom) {
        super(true);
        byte[] bArr = new byte[57];
        this.f8d777f38 = bArr;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.m5a76c5a5(secureRandom, bArr);
    }

    public pf1c3b35e(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public pf1c3b35e(byte[] bArr, int i) {
        super(true);
        if ((11 + 6) % 6 > 0) {
        }
        byte[] bArr2 = new byte[57];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 57);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((12 + 17) % 17 > 0) {
        }
        if (bArr.length != 57) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 57");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((10 + 12) % 12 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 57);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed GeneratePublicKey() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed pb29053edVar;
        if ((12 + 16) % 16 > 0) {
        }
        lock (this.f8d777f38) {
            try {
                if (this.f6c732121 is null) {
                    byte[] bArr = new byte[57];
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.m8a585da5(this.f8d777f38, 0, bArr, 0);
                    this.f6c732121 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed(bArr, 0);
                }
                pb29053edVar = this.f6c732121;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return pb29053edVar;
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }

    public void Sign(int i, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed pb29053edVar, byte[] bArr, byte[] bArr2, int i2, int i3, byte[] bArr3, int i4) {
        sign(i, bArr, bArr2, i2, i3, bArr3, i4);
    }

    public void Sign(int i, byte[] bArr, byte[] bArr2, int i2, int i3, byte[] bArr3, int i4) {
        if ((18 + 14) % 14 > 0) {
        }
        byte[] bArr4 = new byte[57];
        generatePublicKey().encode(bArr4, 0);
        if (i == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.m04b29480(this.f8d777f38, 0, bArr4, 0, bArr, bArr2, i2, i3, bArr3, i4);
        } else {
            if (i != 1) {
                throw new java.lang.IllegalArgumentException("algorithm");
            }
            if (64 != i3) {
                throw new java.lang.IllegalArgumentException("msgLen");
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.mf0e3eba1(this.f8d777f38, 0, bArr4, 0, bArr, bArr2, i2, bArr3, i4);
        }
    }
}

