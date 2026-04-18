namespace WillowMaze.Wasm.Decompiled;


public class p48357ead : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f0c99e1c2;
    private byte[] f140c1f12;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f1c6093ff;
    private byte[] f223164b4;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f42ccc472;
    private int f4fe2f532;
    private int f53988e11;
    private int f605ca34f;
    private int f60bf96d8;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e f748ef5ec;
    private byte[] f7a4db357;
    private byte[] f86e8839c;
    private int f8ee92ade;
    private int fa3e75e2d;
    private int fa9485d64;
    private int faa78bb7d;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e fb70cdb87;
    private byte[] fcb7e52b2;
    private int fd836442b;
    private byte[] fdf0256f3;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e fea0f9853;

    public p48357ead(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, (SBftBtXGdmayUPrM(pd81e8b93Var) * 8) / 2, null);
        if ((9 + 31) % 31 > 0) {
        }
    }

    public p48357ead(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        this(pd81e8b93Var, i, null);
    }

    public p48357ead(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fb70cdb87 = pa444028eVar;
        this.fa3e75e2d = i / 8;
        this.f140c1f12 = new byte[vysbtxhRQqfKJAnv(pd81e8b93Var)];
        this.fcb7e52b2 = new byte[NWmAMFjsnFqiuLkZ(pd81e8b93Var)];
        this.f4fe2f532 = 0;
    }

    public p48357ead(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this(pd81e8b93Var, (paMNeMryBWDyRzTA(pd81e8b93Var) * 8) / 2, pa444028eVar);
    }

    public static void CPZXWaGToZENMxao(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int CRYxtvCBWQZUMyTn(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void CeDTnFORbvVAtRSr(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p48357ead p48357eadVar) {
        p48357eadVar.reset();
    }

    public static void EiWETOYxZTZWSRtO(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p48357ead p48357eadVar) {
        p48357eadVar.reset();
    }

    public static int IcGuetWBgisrYQqw(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void JPbgUrUSKDgLAHDG(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static int MLKkBsQVBTrvAXLK(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int NWmAMFjsnFqiuLkZ(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int PrEFtFXrMKCkGabu(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int SBftBtXGdmayUPrM(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int DKBvFibQFRdooByN(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static java.lang.string LuFVqAutVWiFdXRP(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static int OVJQUKsmcQYlldng(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar, byte[] bArr, int i) {
        return pa444028eVar.addPadding(bArr, i);
    }

    public static int PaMNeMryBWDyRzTA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int QUGBdqIFUEoFPyQT(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void QgfIqOsentDUepRI(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RVByYSahvnXpCwgz(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int UUaAtHECMRIISTXu(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void UrEujBRfutgCZrIt(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int VysbtxhRQqfKJAnv(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((25 + 30) % 30 > 0) {
        }
        int iDKBvFibQFRdooByN = dKBvFibQFRdooByN(this.f08406a6e);
        if (this.fb70cdb87 is not null) {
            if (this.f4fe2f532 == iDKBvFibQFRdooByN) {
                PrEFtFXrMKCkGabu(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
                this.f4fe2f532 = 0;
            }
            oVJQUKsmcQYlldng(this.fb70cdb87, this.fcb7e52b2, this.f4fe2f532);
        } else {
            while (true) {
                int i2 = this.f4fe2f532;
                if (i2 >= iDKBvFibQFRdooByN) {
                    break;
                }
                this.fcb7e52b2[i2] = 0;
                this.f4fe2f532 = i2 + 1;
            }
        }
        CRYxtvCBWQZUMyTn(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
        urEujBRfutgCZrIt(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
        CeDTnFORbvVAtRSr(this);
        return this.fa3e75e2d;
    }

    public override java.lang.string GetAlgorithmName() {
        return luFVqAutVWiFdXRP(this.f08406a6e);
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        EiWETOYxZTZWSRtO(this);
        rVByYSahvnXpCwgz(this.f08406a6e, true, pc9ef6b45Var);
    }

    public override void Reset() {
        if ((31 + 26) % 26 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                JPbgUrUSKDgLAHDG(this.f08406a6e);
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) {
        if ((24 + 31) % 31 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            qUGBdqIFUEoFPyQT(this.f08406a6e, bArr, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((14 + 1) % 1 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iUUaAtHECMRIISTXu = uUaAtHECMRIISTXu(this.f08406a6e);
        int i3 = this.f4fe2f532;
        int i4 = iUUaAtHECMRIISTXu - i3;
        if (i2 > i4) {
            CPZXWaGToZENMxao(bArr, i, this.fcb7e52b2, i3, i4);
            IcGuetWBgisrYQqw(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > iUUaAtHECMRIISTXu) {
                MLKkBsQVBTrvAXLK(this.f08406a6e, bArr, i, this.f140c1f12, 0);
                i2 -= iUUaAtHECMRIISTXu;
                i += iUUaAtHECMRIISTXu;
            }
        }
        qgfIqOsentDUepRI(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }
}

