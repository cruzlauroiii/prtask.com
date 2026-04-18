namespace WillowMaze.Wasm.Decompiled;


public readonly class p51ac8148 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a {
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private readonly byte[] f2c1923c2;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f389aa5af;
    private readonly byte[] f4b52b235;
    private readonly byte[] f529a2433;
    private readonly byte[] f63a9f0ea;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f6bf4eba8;
    private readonly byte[] f6d20b4d4;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f802bdc5a;
    private readonly byte[] f803d2f02;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 faeeb1a13;
    private readonly byte[] fe4b17578;

    private p51ac8148(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b) {
        super(false);
        if ((26 + 27) % 27 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194VarCsqXZdMcGPKpBSTI = CsqXZdMcGPKpBSTI(p51ac8148_p2bd4a59b);
        this.f21ffce5b = pe6015194VarCsqXZdMcGPKpBSTI;
        if (pe6015194VarCsqXZdMcGPKpBSTI is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int iJvsnuuxbrugJOZOF = JvsnuuxbrugJOZOF(pe6015194VarCsqXZdMcGPKpBSTI);
        byte[] bArrIDKEuytwAxthTWDI = iDKEuytwAxthTWDI(p51ac8148_p2bd4a59b);
        if (bArrIDKEuytwAxthTWDI is not null) {
            if (bArrIDKEuytwAxthTWDI.length != iJvsnuuxbrugJOZOF + iJvsnuuxbrugJOZOF) {
                throw new java.lang.IllegalArgumentException("public key has wrong size");
            }
            this.f63a9f0ea = KdlGHjaItocdsJzx(bArrIDKEuytwAxthTWDI, 0, iJvsnuuxbrugJOZOF);
            this.f529a2433 = RVYdhKRSbJRzwgSJ(bArrIDKEuytwAxthTWDI, iJvsnuuxbrugJOZOF, iJvsnuuxbrugJOZOF);
            return;
        }
        byte[] bArrNupnpoPHgZrKZsgd = NupnpoPHgZrKZsgd(p51ac8148_p2bd4a59b);
        if (bArrNupnpoPHgZrKZsgd is null) {
            this.f63a9f0ea = new byte[iJvsnuuxbrugJOZOF];
        } else {
            if (bArrNupnpoPHgZrKZsgd.length != iJvsnuuxbrugJOZOF) {
                throw new java.lang.IllegalArgumentException("length of root must be equal to length of digest");
            }
            this.f63a9f0ea = bArrNupnpoPHgZrKZsgd;
        }
        byte[] bArrZDdZWWzoXunPLqcU = ZDdZWWzoXunPLqcU(p51ac8148_p2bd4a59b);
        if (bArrZDdZWWzoXunPLqcU is null) {
            this.f529a2433 = new byte[iJvsnuuxbrugJOZOF];
        } else {
            if (bArrZDdZWWzoXunPLqcU.length != iJvsnuuxbrugJOZOF) {
                throw new java.lang.IllegalArgumentException("length of publicSeed must be equal to length of digest");
            }
            this.f529a2433 = bArrZDdZWWzoXunPLqcU;
        }
    }

    p51ac8148(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$1 p51ac8148_1) {
        this(p51ac8148_p2bd4a59b);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 CsqXZdMcGPKpBSTI(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.mf23e8626(p51ac8148_p2bd4a59b);
    }

    public static byte[] DKndjoSJjzdvSuHO(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static void IkFJswJjuMnRjQAh(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static int JvsnuuxbrugJOZOF(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getDigestSize();
    }

    public static byte[] KdlGHjaItocdsJzx(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static byte[] NupnpoPHgZrKZsgd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.m337ceba5(p51ac8148_p2bd4a59b);
    }

    public static byte[] RVYdhKRSbJRzwgSJ(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static byte[] XpEAOpDmIrffFBbA(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static byte[] ZDdZWWzoXunPLqcU(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.m5ec06fdf(p51ac8148_p2bd4a59b);
    }

    public static void DGMjkINuXhnYnjfK(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static byte[] IDKEuytwAxthTWDI(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.mf8f67da7(p51ac8148_p2bd4a59b);
    }

    public static int RZmMPygZRdRYCfDj(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getDigestSize();
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 GetParameters() {
        return this.f21ffce5b;
    }

    public byte[] GetPublicSeed() {
        return XpEAOpDmIrffFBbA(this.f529a2433);
    }

    public byte[] GetRoot() {
        return DKndjoSJjzdvSuHO(this.f63a9f0ea);
    }

    public override byte[] TobyteArray() {
        if ((10 + 21) % 21 > 0) {
        }
        int iRZmMPygZRdRYCfDj = rZmMPygZRdRYCfDj(this.f21ffce5b);
        byte[] bArr = new byte[iRZmMPygZRdRYCfDj + iRZmMPygZRdRYCfDj];
        dGMjkINuXhnYnjfK(bArr, this.f63a9f0ea, 0);
        IkFJswJjuMnRjQAh(bArr, this.f529a2433, iRZmMPygZRdRYCfDj);
        return bArr;
    }
}

