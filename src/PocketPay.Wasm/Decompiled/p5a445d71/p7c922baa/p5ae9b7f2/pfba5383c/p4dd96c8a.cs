namespace WillowMaze.Wasm.Decompiled;


public class p4dd96c8a : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d f08406a6e;
    private int f0a19f5e1;
    private byte[] f140c1f12;
    private byte[] f22289810;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e f28d96345;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e f3b37eccd;
    private byte[] f3d88f894;
    private int f4fe2f532;
    private int f56e0fbe7;
    private p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d f5dc3eae7;
    private int f6171e6f9;
    private byte[] f65567a82;
    private p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d f7a6b4b3e;
    private int f8c0f1488;
    private p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d f99999582;
    private int f9d5e66bc;
    private int fa26e4c86;
    private int fa3e75e2d;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e fb70cdb87;
    private byte[] fcb7e52b2;
    private int fd09fbef8;
    private p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d fd1feb814;
    private byte[] ff9de3636;

    public p4dd96c8a(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, 8, (GQYlTJnDzMSMhzUH(pd81e8b93Var) * 8) / 2, null);
        if ((4 + 29) % 29 > 0) {
        }
    }

    public p4dd96c8a(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, int i2) {
        this(pd81e8b93Var, i, i2, null);
    }

    public p4dd96c8a(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, int i2, p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this.fb70cdb87 = null;
        if (i2 % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        this.f140c1f12 = new byte[MfbaVSQjJMsBFbiW(pd81e8b93Var)];
        p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar = new p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d(pd81e8b93Var, i);
        this.f08406a6e = p1c43809dVar;
        this.fb70cdb87 = pa444028eVar;
        this.fa3e75e2d = i2 / 8;
        this.fcb7e52b2 = new byte[XXQHJTFRDtFmoLkq(p1c43809dVar)];
        this.f4fe2f532 = 0;
    }

    public p4dd96c8a(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this(pd81e8b93Var, 8, (hIiVExJefZvToXmd(pd81e8b93Var) * 8) / 2, pa444028eVar);
        if ((1 + 2) % 2 > 0) {
        }
    }

    public static java.lang.string AMhenxTARLZdGvhj(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar) {
        return p1c43809dVar.getAlgorithmName();
    }

    public static int CTzRUAIopsDRpzmI(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar, byte[] bArr, int i, byte[] bArr2, int i2) {
        return p1c43809dVar.processBlock(bArr, i, bArr2, i2);
    }

    public static void FdLJIprxPhMLoYWA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int FfvdzUZVNEjeygcz(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar, byte[] bArr, int i, byte[] bArr2, int i2) {
        return p1c43809dVar.processBlock(bArr, i, bArr2, i2);
    }

    public static int GQYlTJnDzMSMhzUH(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int IFxEpDNXuyLrgQxh(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar, byte[] bArr, int i, byte[] bArr2, int i2) {
        return p1c43809dVar.processBlock(bArr, i, bArr2, i2);
    }

    public static int KpRXErBrplxQRJjz(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar) {
        return p1c43809dVar.getBlockSize();
    }

    public static int MfbaVSQjJMsBFbiW(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void OApvwQmlcgkYzNqK(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar, byte[] bArr) {
        p1c43809dVar.getMacBlock(bArr);
    }

    public static int XXQHJTFRDtFmoLkq(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar) {
        return p1c43809dVar.getBlockSize();
    }

    public static void XlmAIXVMnibXiTOy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void EEOaHSitIMQJtLGJ(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar) {
        p1c43809dVar.reset();
    }

    public static int EXHdpOVFeMByZEew(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar, byte[] bArr, int i) {
        return pa444028eVar.addPadding(bArr, i);
    }

    public static void FiHssVvidxTLOBmg(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p4dd96c8a p4dd96c8aVar) {
        p4dd96c8aVar.reset();
    }

    public static int HIiVExJefZvToXmd(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void MISHcrotjDYqvaln(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p1c43809dVar.init(pc9ef6b45Var);
    }

    public static void SDeJpvoXHNaaRYNe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int TqxdQUpBoVmNMdEn(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar) {
        return p1c43809dVar.getBlockSize();
    }

    public static int VYILqkZBSZmEShHf(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar, byte[] bArr, int i, byte[] bArr2, int i2) {
        return p1c43809dVar.processBlock(bArr, i, bArr2, i2);
    }

    public static void YSiPEdfDMZVLfLXD(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p4dd96c8a p4dd96c8aVar) {
        p4dd96c8aVar.reset();
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((11 + 30) % 30 > 0) {
        }
        int iKpRXErBrplxQRJjz = KpRXErBrplxQRJjz(this.f08406a6e);
        p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar = this.fb70cdb87;
        if (pa444028eVar is not null) {
            eXHdpOVFeMByZEew(pa444028eVar, this.fcb7e52b2, this.f4fe2f532);
        } else {
            while (true) {
                int i2 = this.f4fe2f532;
                if (i2 >= iKpRXErBrplxQRJjz) {
                    break;
                }
                this.fcb7e52b2[i2] = 0;
                this.f4fe2f532 = i2 + 1;
            }
        }
        IFxEpDNXuyLrgQxh(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
        OApvwQmlcgkYzNqK(this.f08406a6e, this.f140c1f12);
        FdLJIprxPhMLoYWA(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
        ySiPEdfDMZVLfLXD(this);
        return this.fa3e75e2d;
    }

    public override java.lang.string GetAlgorithmName() {
        return AMhenxTARLZdGvhj(this.f08406a6e);
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        fiHssVvidxTLOBmg(this);
        mISHcrotjDYqvaln(this.f08406a6e, pc9ef6b45Var);
    }

    public override void Reset() {
        if ((12 + 20) % 20 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                eEOaHSitIMQJtLGJ(this.f08406a6e);
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) {
        if ((2 + 23) % 23 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            vYILqkZBSZmEShHf(this.f08406a6e, bArr, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((2 + 10) % 10 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iTqxdQUpBoVmNMdEn = tqxdQUpBoVmNMdEn(this.f08406a6e);
        int i3 = this.f4fe2f532;
        int i4 = iTqxdQUpBoVmNMdEn - i3;
        if (i2 > i4) {
            XlmAIXVMnibXiTOy(bArr, i, this.fcb7e52b2, i3, i4);
            FfvdzUZVNEjeygcz(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > iTqxdQUpBoVmNMdEn) {
                CTzRUAIopsDRpzmI(this.f08406a6e, bArr, i, this.f140c1f12, 0);
                i2 -= iTqxdQUpBoVmNMdEn;
                i += iTqxdQUpBoVmNMdEn;
            }
        }
        sDeJpvoXHNaaRYNe(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }
}

