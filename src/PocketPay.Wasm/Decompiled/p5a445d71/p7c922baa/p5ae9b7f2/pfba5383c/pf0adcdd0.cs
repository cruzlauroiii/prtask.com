namespace WillowMaze.Wasm.Decompiled;


public class pf0adcdd0 : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private int f0353b601;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f093d1ab8;
    private byte[] f140c1f12;
    private int f4fe2f532;
    private int f50b9b45f;
    private byte[] f5d4c6ea9;
    private byte[] f63f37f6b;
    private byte[] f7dc8ebe0;
    private byte[] f8dc10b8f;
    private int f941a4461;
    private int f9c81fbd6;
    private byte[] fa37bbb10;
    private int fa3e75e2d;
    private byte[] fbb1ae831;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 fc136892b;
    private byte[] fcb7e52b2;
    private int fd36f0449;

    public pf0adcdd0(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, (BbFkDgpliagfjKSX(pd81e8b93Var) * 8) / 2);
    }

    public pf0adcdd0(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fa3e75e2d = i / 8;
        this.f140c1f12 = new byte[zptmHJbZNexTXKvo(pd81e8b93Var)];
        this.fcb7e52b2 = new byte[QFMMJSxczuZJjxPM(pd81e8b93Var)];
        this.f4fe2f532 = 0;
    }

    public static int BbFkDgpliagfjKSX(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int BxhIMzHzAVbGIbbt(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void MiCJlsGNGTGslkOT(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void OxIlvhXnESQAzibg(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int QFMMJSxczuZJjxPM(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int SGlvURVkMIlXunfV(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int SyQXGufYQufsNIiX(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int XMkKdnWSfoQbzadq(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int FvIyCUIwmyFsQFIA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static java.lang.string HREQBhNvvldaOotm(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void JAFxLgBAUUrrzsqA(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pf0adcdd0 pf0adcdd0Var) {
        pf0adcdd0Var.reset();
    }

    public static void KkGlQYSEiEllUAbE(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pf0adcdd0 pf0adcdd0Var) {
        pf0adcdd0Var.reset();
    }

    public static void NHFlZDRuFKfIrldU(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static int NdnaSfSEXaCCkwsB(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void SzFprOmVdGuioIzL(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void TcyZsVvcXNGaCDLL(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int ZptmHJbZNexTXKvo(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((5 + 30) % 30 > 0) {
        }
        int iSyQXGufYQufsNIiX = SyQXGufYQufsNIiX(this.f08406a6e);
        while (true) {
            int i2 = this.f4fe2f532;
            if (i2 >= iSyQXGufYQufsNIiX) {
                BxhIMzHzAVbGIbbt(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
                szFprOmVdGuioIzL(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
                jAFxLgBAUUrrzsqA(this);
                return this.fa3e75e2d;
            }
            this.fcb7e52b2[i2] = 0;
            this.f4fe2f532 = i2 + 1;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return hREQBhNvvldaOotm(this.f08406a6e);
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        kkGlQYSEiEllUAbE(this);
        tcyZsVvcXNGaCDLL(this.f08406a6e, true, pc9ef6b45Var);
    }

    public override void Reset() {
        if ((27 + 5) % 5 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                nHFlZDRuFKfIrldU(this.f08406a6e);
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) {
        if ((3 + 6) % 6 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            XMkKdnWSfoQbzadq(this.f08406a6e, bArr, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((4 + 7) % 7 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iSGlvURVkMIlXunfV = SGlvURVkMIlXunfV(this.f08406a6e);
        int i3 = this.f4fe2f532;
        int i4 = iSGlvURVkMIlXunfV - i3;
        if (i2 > i4) {
            OxIlvhXnESQAzibg(bArr, i, this.fcb7e52b2, i3, i4);
            fvIyCUIwmyFsQFIA(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > iSGlvURVkMIlXunfV) {
                ndnaSfSEXaCCkwsB(this.f08406a6e, bArr, i, this.f140c1f12, 0);
                i2 -= iSGlvURVkMIlXunfV;
                i += iSGlvURVkMIlXunfV;
            }
        }
        MiCJlsGNGTGslkOT(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }
}

