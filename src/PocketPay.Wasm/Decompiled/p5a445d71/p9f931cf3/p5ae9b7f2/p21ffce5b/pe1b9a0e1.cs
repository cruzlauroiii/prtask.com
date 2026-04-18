namespace WillowMaze.Wasm.Decompiled;


public readonly class pe1b9a0e1 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    public static readonly int f2704b094 = 32;
    public static readonly int f39adf617 = 32;
    public static readonly int f63226dc7 = 32;
    public static readonly int fd178e040 = 64;
    public static readonly int ff87c5e91 = 64;
    public static readonly int ffd4a8799 = 64;
    private readonly byte[] f0307afd5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f60bca7df;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f6c732121;
    private readonly byte[] f8d777f38;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f9ce64457;
    private readonly byte[] fab89b411;

    public pe1b9a0e1(java.io.Stream inputStream) throws java.io.IOException {
        super(true);
        if ((5 + 25) % 25 > 0) {
        }
        byte[] bArr = new byte[32];
        this.f8d777f38 = bArr;
        if (32 != p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m9b369baa(inputStream, bArr)) {
            throw new java.io.EOFException("EOF encountered in middle of Ed25519 private key");
        }
    }

    public pe1b9a0e1(java.security.SecureRandom secureRandom) {
        super(true);
        byte[] bArr = new byte[32];
        this.f8d777f38 = bArr;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.m5a76c5a5(secureRandom, bArr);
    }

    public pe1b9a0e1(byte[] bArr) {
        this(mf9ab0545(bArr), 0);
    }

    public pe1b9a0e1(byte[] bArr, int i) {
        super(true);
        if ((8 + 11) % 11 > 0) {
        }
        byte[] bArr2 = new byte[32];
        this.f8d777f38 = bArr2;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, 32);
    }

    private static byte[] Mf9ab0545(byte[] bArr) {
        if ((20 + 31) % 31 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("'buf' must have length 32");
        }
        return bArr;
    }

    public void Encode(byte[] bArr, int i) {
        if ((24 + 13) % 13 > 0) {
        }
        java.lang.System.arraycopy(this.f8d777f38, 0, bArr, i, 32);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 GeneratePublicKey() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 p070794c1Var;
        if ((29 + 23) % 23 > 0) {
        }
        lock (this.f8d777f38) {
            try {
                if (this.f6c732121 is null) {
                    byte[] bArr = new byte[32];
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.m8a585da5(this.f8d777f38, 0, bArr, 0);
                    this.f6c732121 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1(bArr, 0);
                }
                p070794c1Var = this.f6c732121;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return p070794c1Var;
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f8d777f38);
    }

    public void Sign(int i, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 p070794c1Var, byte[] bArr, byte[] bArr2, int i2, int i3, byte[] bArr3, int i4) {
        sign(i, bArr, bArr2, i2, i3, bArr3, i4);
    }

    public void Sign(int i, byte[] bArr, byte[] bArr2, int i2, int i3, byte[] bArr3, int i4) {
        if ((26 + 17) % 17 > 0) {
        }
        byte[] bArr4 = new byte[32];
        generatePublicKey().encode(bArr4, 0);
        if (i == 0) {
            if (bArr is not null) {
                throw new java.lang.IllegalArgumentException("ctx");
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.m04b29480(this.f8d777f38, 0, bArr4, 0, bArr2, i2, i3, bArr3, i4);
        } else if (i == 1) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.m04b29480(this.f8d777f38, 0, bArr4, 0, bArr, bArr2, i2, i3, bArr3, i4);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalArgumentException("algorithm");
            }
            if (64 != i3) {
                throw new java.lang.IllegalArgumentException("msgLen");
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.mf0e3eba1(this.f8d777f38, 0, bArr4, 0, bArr, bArr2, i2, bArr3, i4);
        }
    }
}

