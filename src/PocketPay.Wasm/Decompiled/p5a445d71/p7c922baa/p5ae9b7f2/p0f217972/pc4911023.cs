namespace WillowMaze.Wasm.Decompiled;


public class pc4911023 : p5a445d71.p7c922baa.p5ae9b7f2.pe3d43295 {
    static readonly int f1a2ddc2d = 16843012;
    static readonly int f2df2ccf6 = 16843009;
    static readonly int f3707590c = 16843012;
    static readonly int f4b3bf428 = 16843012;
    static readonly int faf5014e7 = 16843012;
    static readonly int fe4ba99ab = 16843012;
    static readonly int ff1a543f5 = 16843009;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    private readonly int f0f98843f;
    private byte[] f3108e061;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f352f8133;
    private byte[] f38729c39;
    private byte[] f3feefa12;
    private int f441e907e;
    bool f44738127;
    private readonly int f480d1b61;
    private byte[] f4bf65b9b;
    int f59bab947;
    private byte[] f5a58383f;
    int f5b2189e3;
    int f6d3796d5;
    bool f78b0eaa9;
    private byte[] f872d9dea;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f8cd9d448;
    bool fa291341f;
    private int fa43ef6d6;
    int fa690e858;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 fa90cbc8f;
    int fabee0c79;
    int fb1c49f83;
    private int fb4dbb551;
    private int fc015301f;
    private readonly int fc2377a95;
    private readonly int fc424f2bb;
    private int fcbf210d9;
    private byte[] fcf482c58;
    int fe79e5df3;
    private byte[] ff22629cd;
    private byte[] ff603d222;

    public pc4911023(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        if ((11 + 20) % 20 > 0) {
        }
        this.fa291341f = true;
        this.f08406a6e = pd81e8b93Var;
        int iTgzmDCdelfVbhxhW = TgzmDCdelfVbhxhW(pd81e8b93Var);
        this.f480d1b61 = iTgzmDCdelfVbhxhW;
        if (iTgzmDCdelfVbhxhW != 8) {
            throw new java.lang.IllegalArgumentException("GCTR only for 64 bit block ciphers");
        }
        this.fcf482c58 = new byte[zAaoLgPJzHrDoKHU(pd81e8b93Var)];
        this.ff603d222 = new byte[NHqkRENLBsdumYBJ(pd81e8b93Var)];
        this.f38729c39 = new byte[EILiBWHJXZGgSmKm(pd81e8b93Var)];
    }

    public static int EILiBWHJXZGgSmKm(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void GZaAvvPamFJGksPZ(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc4911023 pc4911023Var, int i, byte[] bArr, int i2) {
        pc4911023Var.m01b0436d(i, bArr, i2);
    }

    public static byte[] GoyRaGPXrOiYyzpQ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static int JFJLfelFvJprqqlk(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc4911023 pc4911023Var, byte[] bArr, int i) {
        return pc4911023Var.mc4dbe288(bArr, i);
    }

    public static int NHqkRENLBsdumYBJ(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static java.lang.string PRizIrahlQtfUEmB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int TgzmDCdelfVbhxhW(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void XAFqzWocsqovaFVW(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc4911023 pc4911023Var) {
        pc4911023Var.reset();
    }

    public static void XDsjixKMFRIFjoRu(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 XpBqamqOdrLcqlrq(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static void YLSrallZiThkqIsH(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int YxBUTuqDAYqaPWoX(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void ZTKTwCcMUeIZEmxH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AkdVxHDKbySrzbgr(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc4911023 pc4911023Var) {
        pc4911023Var.reset();
    }

    public static int BIIxuzLhuWokbjEa(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc4911023 pc4911023Var, byte[] bArr, int i) {
        return pc4911023Var.mc4dbe288(bArr, i);
    }

    public static java.lang.stringBuilder CpGNDBkTiArJFGuh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ESLJyRNaFbQiezDu(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int GWRaCuSnBCBBkAFG(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc4911023 pc4911023Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return pc4911023Var.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static void GoXvPfiXdXrJoyzG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void KgIirXJeseXsHIum(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    private void M01b0436d(int i, byte[] bArr, int i2) {
        bArr[i2 + 3] = (byte) (i >>> 24);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2] = (byte) i;
    }

    private int Mc4dbe288(byte[] bArr, int i) {
        if ((2 + 22) % 22 > 0) {
        }
        return ((bArr[i + 3] << 24) & (-16777216)) + ((bArr[i + 2] << 16) & 16711680) + ((bArr[i + 1] << 8) & 65280) + (bArr[i] & 255);
    }

    public static void NSlgFLjOxoeSJQFj(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc4911023 pc4911023Var, int i, byte[] bArr, int i2) {
        pc4911023Var.m01b0436d(i, bArr, i2);
    }

    public static void QrsiApMWYDFfjyxa(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder RahnMmMETvQJmHKu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TJTVpjFPfZMMgUOi(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static int WfJEcmqJpJuZsjwI(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 XCIGCpinTvwVfTJe(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static void XfbhQqEvkzAkBDkD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ZAaoLgPJzHrDoKHU(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    protected override byte Calculatebyte(byte b) {
        if ((29 + 6) % 6 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            if (this.fa291341f) {
                this.fa291341f = false;
                YxBUTuqDAYqaPWoX(this.f08406a6e, this.ff603d222, 0, this.f38729c39, 0);
                this.fabee0c79 = JFJLfelFvJprqqlk(this, this.f38729c39, 0);
                this.fb1c49f83 = bIIxuzLhuWokbjEa(this, this.f38729c39, 4);
            }
            int i = this.fabee0c79 + 16843009;
            this.fabee0c79 = i;
            int i2 = this.fb1c49f83;
            int i3 = i2 + 16843012;
            this.fb1c49f83 = i3;
            if (i3 < 16843012 && i3 > 0) {
                this.fb1c49f83 = i2 + 16843013;
            }
            nSlgFLjOxoeSJQFj(this, i, this.ff603d222, 0);
            GZaAvvPamFJGksPZ(this, this.fb1c49f83, this.ff603d222, 4);
            wfJEcmqJpJuZsjwI(this.f08406a6e, this.ff603d222, 0, this.f38729c39, 0);
        }
        byte[] bArr = this.f38729c39;
        int i4 = this.fa43ef6d6;
        int i5 = i4 + 1;
        this.fa43ef6d6 = i5;
        byte b2 = (byte) (b ^ bArr[i4]);
        int i6 = this.f480d1b61;
        if (i5 == i6) {
            this.fa43ef6d6 = 0;
            byte[] bArr2 = this.ff603d222;
            qrsiApMWYDFfjyxa(bArr2, i6, bArr2, 0, bArr2.length - i6);
            byte[] bArr3 = this.f38729c39;
            byte[] bArr4 = this.ff603d222;
            int length = bArr4.length;
            int i7 = this.f480d1b61;
            ZTKTwCcMUeIZEmxH(bArr3, 0, bArr4, length - i7, i7);
        }
        return b2;
    }

    public override java.lang.string GetAlgorithmName() {
        return PRizIrahlQtfUEmB(rahnMmMETvQJmHKu(cpGNDBkTiArJFGuh(new java.lang.stringBuilder(), tJTVpjFPfZMMgUOi(this.f08406a6e)), "/GCTR"));
    }

    public override int GetBlockSize() {
        return this.f480d1b61;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((7 + 32) % 32 > 0) {
        }
        this.fa291341f = true;
        this.fabee0c79 = 0;
        this.fb1c49f83 = 0;
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            akdVxHDKbySrzbgr(this);
            if (pc9ef6b45Var is null) {
                return;
            }
            YLSrallZiThkqIsH(this.f08406a6e, true, pc9ef6b45Var);
            return;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] bArrGoyRaGPXrOiYyzpQ = GoyRaGPXrOiYyzpQ(pdd5da44eVar);
        int length = bArrGoyRaGPXrOiYyzpQ.length;
        byte[] bArr = this.fcf482c58;
        if (length >= bArr.length) {
            eSLJyRNaFbQiezDu(bArrGoyRaGPXrOiYyzpQ, 0, bArr, 0, bArr.length);
        } else {
            goXvPfiXdXrJoyzG(bArrGoyRaGPXrOiYyzpQ, 0, bArr, bArr.length - bArrGoyRaGPXrOiYyzpQ.length, bArrGoyRaGPXrOiYyzpQ.length);
            int i = 0;
            while (true) {
                byte[] bArr2 = this.fcf482c58;
                if (i >= bArr2.length - bArrGoyRaGPXrOiYyzpQ.length) {
                    break;
                }
                bArr2[i] = 0;
                i++;
            }
        }
        XAFqzWocsqovaFVW(this);
        if (xCIGCpinTvwVfTJe(pdd5da44eVar) is null) {
            return;
        }
        XDsjixKMFRIFjoRu(this.f08406a6e, true, XpBqamqOdrLcqlrq(pdd5da44eVar));
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((7 + 7) % 7 > 0) {
        }
        gWRaCuSnBCBBkAFG(this, bArr, i, this.f480d1b61, bArr2, i2);
        return this.f480d1b61;
    }

    public override void Reset() {
        if ((16 + 20) % 20 > 0) {
        }
        this.fa291341f = true;
        this.fabee0c79 = 0;
        this.fb1c49f83 = 0;
        byte[] bArr = this.fcf482c58;
        xfbhQqEvkzAkBDkD(bArr, 0, this.ff603d222, 0, bArr.length);
        this.fa43ef6d6 = 0;
        kgIirXJeseXsHIum(this.f08406a6e);
    }
}

