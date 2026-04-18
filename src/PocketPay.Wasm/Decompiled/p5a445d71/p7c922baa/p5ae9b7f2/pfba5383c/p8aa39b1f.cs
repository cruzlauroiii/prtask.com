namespace WillowMaze.Wasm.Decompiled;


public class p8aa39b1f : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f140c1f12;
    private byte[] f1d386c5b;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e f2b0c5fbb;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f411f08af;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f43bc6d02;
    private int f4fe2f532;
    private byte[] f5133c43a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f5d77a0b4;
    private int f7d3d3258;
    private byte[] f867a38be;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e f86ff99b6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f882d91ed;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 f8b4489f7;
    private int fa3e75e2d;
    private int fb2036fd3;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e fb70cdb87;
    private byte[] fcb7e52b2;
    private byte[] fce758411;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 fd4a01a7e;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 fd720be1c;
    private p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e fddaeab60;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 fe1660322;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 fe282ed0b;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 fe2b82c52;
    private byte[] fe58d2459;

    public p8aa39b1f(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, BWYuUHQdFgevTYta(pd81e8b93Var) * 8, null);
        if ((9 + 13) % 13 > 0) {
        }
    }

    public p8aa39b1f(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        this(pd81e8b93Var, i, null);
    }

    public p8aa39b1f(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        if (!(pd81e8b93Var is p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p4803ba84)) {
            throw new java.lang.IllegalArgumentException("cipher must be instance of DESEngine");
        }
        this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fb70cdb87 = pa444028eVar;
        this.fa3e75e2d = i / 8;
        this.f140c1f12 = new byte[MIBKtLXnpoULRGbL(pd81e8b93Var)];
        this.fcb7e52b2 = new byte[BIaDOKjGYsNBWGEo(pd81e8b93Var)];
        this.f4fe2f532 = 0;
    }

    public p8aa39b1f(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this(pd81e8b93Var, QWcahqXPIVGjyfpE(pd81e8b93Var) * 8, pa444028eVar);
    }

    public static void AunWqgSckUPibezl(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static int BIaDOKjGYsNBWGEo(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int BWYuUHQdFgevTYta(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void BYsTwssAvRHPuwnK(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p4803ba84 p4803ba84Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p4803ba84Var.init(z, pc9ef6b45Var);
    }

    public static byte[] DXRWwRMygJsAcDTl(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var) {
        return p94919be6Var.getKey();
    }

    public static void HINeUmwLuRJjLKCx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int HudyxBynBegVVctn(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int IKCHmYVCiYbcfHTa(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int MIBKtLXnpoULRGbL(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int MsuFtGzVxWDUxSru(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void OsHauHtDPdgdUKHG(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p4803ba84 p4803ba84Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p4803ba84Var.init(z, pc9ef6b45Var);
    }

    public static void PfYKwXGiwIUTuxlA(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p8aa39b1f p8aa39b1fVar) {
        p8aa39b1fVar.reset();
    }

    public static int QWcahqXPIVGjyfpE(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void QoetPchktgGHrFzs(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int UcKvJREqNkdfGoCA(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p4803ba84 p4803ba84Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return p4803ba84Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int VyqsRzOcCXzMjLgy(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar, byte[] bArr, int i) {
        return pa444028eVar.addPadding(bArr, i);
    }

    public static int ZjqbzEWUBxFkAesi(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void BVZtQsLrTBHyzTiN(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int EThIhuJIptoPffdU(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void EWTQLVjMCBEjhTHd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void FLBoqSWXzJIsYPWX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int GUDtKrDNgyueYmih(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static byte[] IiXEBWTpaoqrvKVa(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 KsmvDBhyUYOpCsFc(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static void OXZKamJTjAPRRIAv(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p8aa39b1f p8aa39b1fVar) {
        p8aa39b1fVar.reset();
    }

    public static int QkvOAUxDKtgGCqxM(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int WFHBXOaOfjBKnjJV(p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p4803ba84 p4803ba84Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return p4803ba84Var.processBlock(bArr, i, bArr2, i2);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((16 + 3) % 3 > 0) {
        }
        int iQkvOAUxDKtgGCqxM = qkvOAUxDKtgGCqxM(this.f08406a6e);
        if (this.fb70cdb87 is not null) {
            if (this.f4fe2f532 == iQkvOAUxDKtgGCqxM) {
                eThIhuJIptoPffdU(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
                this.f4fe2f532 = 0;
            }
            VyqsRzOcCXzMjLgy(this.fb70cdb87, this.fcb7e52b2, this.f4fe2f532);
        } else {
            while (true) {
                int i2 = this.f4fe2f532;
                if (i2 >= iQkvOAUxDKtgGCqxM) {
                    break;
                }
                this.fcb7e52b2[i2] = 0;
                this.f4fe2f532 = i2 + 1;
            }
        }
        ZjqbzEWUBxFkAesi(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
        p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p4803ba84 p4803ba84Var = new p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p4803ba84();
        BYsTwssAvRHPuwnK(p4803ba84Var, false, this.fe2b82c52);
        byte[] bArr2 = this.f140c1f12;
        UcKvJREqNkdfGoCA(p4803ba84Var, bArr2, 0, bArr2, 0);
        OsHauHtDPdgdUKHG(p4803ba84Var, true, this.fe282ed0b);
        byte[] bArr3 = this.f140c1f12;
        wFHBXOaOfjBKnjJV(p4803ba84Var, bArr3, 0, bArr3, 0);
        HINeUmwLuRJjLKCx(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
        oXZKamJTjAPRRIAv(this);
        return this.fa3e75e2d;
    }

    public override java.lang.string GetAlgorithmName() {
        return "ISO9797Alg3";
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var;
        if ((29 + 32) % 32 > 0) {
        }
        PfYKwXGiwIUTuxlA(this);
        bool z = pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6;
        if (!z && !(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("params must be an instance of KeyParameter or ParametersWithIV");
        }
        byte[] bArrDXRWwRMygJsAcDTl = DXRWwRMygJsAcDTl(!z ? (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) ksmvDBhyUYOpCsFc((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var) : (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var);
        if (bArrDXRWwRMygJsAcDTl.length == 16) {
            p94919be6Var = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrDXRWwRMygJsAcDTl, 0, 8);
            this.fe2b82c52 = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrDXRWwRMygJsAcDTl, 8, 8);
            this.fe282ed0b = p94919be6Var;
        } else {
            if (bArrDXRWwRMygJsAcDTl.length != 24) {
                throw new java.lang.IllegalArgumentException("Key must be either 112 or 168 bit long");
            }
            p94919be6Var = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrDXRWwRMygJsAcDTl, 0, 8);
            this.fe2b82c52 = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrDXRWwRMygJsAcDTl, 8, 8);
            this.fe282ed0b = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrDXRWwRMygJsAcDTl, 16, 8);
        }
        if (pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            QoetPchktgGHrFzs(this.f08406a6e, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e(p94919be6Var, iiXEBWTpaoqrvKVa((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var)));
        } else {
            bVZtQsLrTBHyzTiN(this.f08406a6e, true, p94919be6Var);
        }
    }

    public override void Reset() {
        if ((3 + 19) % 19 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                AunWqgSckUPibezl(this.f08406a6e);
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) {
        if ((3 + 23) % 23 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            IKCHmYVCiYbcfHTa(this.f08406a6e, bArr, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((17 + 7) % 7 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iHudyxBynBegVVctn = HudyxBynBegVVctn(this.f08406a6e);
        int i3 = this.f4fe2f532;
        int i4 = iHudyxBynBegVVctn - i3;
        if (i2 > i4) {
            eWTQLVjMCBEjhTHd(bArr, i, this.fcb7e52b2, i3, i4);
            gUDtKrDNgyueYmih(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > iHudyxBynBegVVctn) {
                MsuFtGzVxWDUxSru(this.f08406a6e, bArr, i, this.f140c1f12, 0);
                i2 -= iHudyxBynBegVVctn;
                i += iHudyxBynBegVVctn;
            }
        }
        fLBoqSWXzJIsYPWX(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }
}

