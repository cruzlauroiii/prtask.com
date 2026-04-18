namespace WillowMaze.Wasm.Decompiled;


public class pab2ee25d : p5a445d71.p7c922baa.p5ae9b7f2.pe3d43295 {
    private bool f0228b9a8;
    private byte[] f0e30abf0;
    private int f3408d58d;
    private byte[] f38729c39;
    private int f3f081050;
    private byte[] f4d13e881;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f4e2089db;
    private byte[] f59b4f0c6;
    private int f850bd0c5;
    private byte[] f8af0b10d;
    private byte[] fa28e8d26;
    private int fa43ef6d6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 fad1943a9;
    private byte[] fb1a33ea7;
    private byte[] fb7c3a63c;
    private byte[] fbd97ca4d;
    private bool fdb1687e1;
    private int fefe03596;
    private byte[] ff0b53b2d;
    private byte[] ff603d222;

    public pab2ee25d(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        this.fad1943a9 = pd81e8b93Var;
        this.ff0b53b2d = new byte[aokIuXcFzyfUPgDt(pd81e8b93Var)];
        this.ff603d222 = new byte[tHbSEjNMqWtpPSTs(pd81e8b93Var)];
        this.f38729c39 = new byte[UqqGPzWOhZHphJsr(pd81e8b93Var)];
    }

    public static java.lang.string QbaNeKmLIASNNmQu(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static int QrdAoayeDFcdcDrn(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar) {
        return pab2ee25dVar.getBlockSize();
    }

    public static void RUHKvlksrNZIQBpc(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static int ScoopJqMPIoQwqow(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void TAPLmTuxRGHgkRME(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static int UqqGPzWOhZHphJsr(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static java.lang.string WQJVmqokRgUfmjmb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XxCwRpIzPeBpUBER(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int AokIuXcFzyfUPgDt(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void BBGKRiUmMnmbQKha(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar) {
        pab2ee25dVar.reset();
    }

    public static void BkBgGZEyiYIhiMtT(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder FtMWnZDeERCwvbBU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HyDGHIfMMbUCYKqX(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return pab2ee25dVar.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static int IiKXLBWAQbqBHvrs(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int KizjhuyCeuJwxrSo(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    private void M09eb96ef() {
    }

    public static void MLDJecaWqHHEdIRJ(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar) {
        pab2ee25dVar.m09eb96ef();
    }

    private void Mdc669dcd(int i) {
        if ((4 + 27) % 27 > 0) {
        }
        while (true) {
            byte[] bArr = this.ff603d222;
            if (i >= bArr.length) {
                return;
            }
            int i2 = i + 1;
            byte b = (byte) (bArr[i] + 1);
            bArr[i] = b;
            if (b != 0) {
                return;
            } else {
                i = i2;
            }
        }
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 NsyzzeaeLYMoYNvb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static byte[] OeiNKeASPIvBCDWy(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static void PwkfEmdsXJDpIYSo(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar, int i) {
        pab2ee25dVar.mdc669dcd(i);
    }

    public static void QGKiBSzdXJeybuwP(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int THbSEjNMqWtpPSTs(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int VZsJxKXSQUXHcPij(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar) {
        return pab2ee25dVar.getBlockSize();
    }

    public static int WTylVyYNDislerWR(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar) {
        return pab2ee25dVar.getBlockSize();
    }

    public static int WqOQAUkrVWRJXdNx(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pab2ee25d pab2ee25dVar) {
        return pab2ee25dVar.getBlockSize();
    }

    protected override byte Calculatebyte(byte b) {
        if ((2 + 28) % 28 > 0) {
        }
        int i = this.fa43ef6d6;
        if (i != 0) {
            byte[] bArr = this.f38729c39;
            int i2 = i + 1;
            this.fa43ef6d6 = i2;
            byte b2 = (byte) (b ^ bArr[i]);
            if (i2 == this.ff603d222.length) {
                this.fa43ef6d6 = 0;
            }
            return b2;
        }
        pwkfEmdsXJDpIYSo(this, 0);
        mLDJecaWqHHEdIRJ(this);
        iiKXLBWAQbqBHvrs(this.fad1943a9, this.ff603d222, 0, this.f38729c39, 0);
        byte[] bArr2 = this.f38729c39;
        int i3 = this.fa43ef6d6;
        this.fa43ef6d6 = i3 + 1;
        return (byte) (bArr2[i3] ^ b);
    }

    public override java.lang.string GetAlgorithmName() {
        return WQJVmqokRgUfmjmb(XxCwRpIzPeBpUBER(ftMWnZDeERCwvbBU(new java.lang.stringBuilder(), QbaNeKmLIASNNmQu(this.fad1943a9)), "/KCTR"));
    }

    public override int GetBlockSize() {
        return ScoopJqMPIoQwqow(this.fad1943a9);
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((31 + 26) % 26 > 0) {
        }
        this.fdb1687e1 = true;
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] bArrOeiNKeASPIvBCDWy = oeiNKeASPIvBCDWy(pdd5da44eVar);
        byte[] bArr = this.ff0b53b2d;
        int length = bArr.length - bArrOeiNKeASPIvBCDWy.length;
        TAPLmTuxRGHgkRME(bArr, (byte) 0);
        bkBgGZEyiYIhiMtT(bArrOeiNKeASPIvBCDWy, 0, this.ff0b53b2d, length, bArrOeiNKeASPIvBCDWy.length);
        p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarNsyzzeaeLYMoYNvb = nsyzzeaeLYMoYNvb(pdd5da44eVar);
        if (pc9ef6b45VarNsyzzeaeLYMoYNvb is not null) {
            qGKiBSzdXJeybuwP(this.fad1943a9, true, pc9ef6b45VarNsyzzeaeLYMoYNvb);
        }
        bBGKRiUmMnmbQKha(this);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((3 + 22) % 22 > 0) {
        }
        if (bArr.length - i < wqOQAUkrVWRJXdNx(this)) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (bArr2.length - i2 < wTylVyYNDislerWR(this)) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
        }
        hyDGHIfMMbUCYKqX(this, bArr, i, QrdAoayeDFcdcDrn(this), bArr2, i2);
        return vZsJxKXSQUXHcPij(this);
    }

    public override void Reset() {
        if ((9 + 14) % 14 > 0) {
        }
        if (this.fdb1687e1) {
            kizjhuyCeuJwxrSo(this.fad1943a9, this.ff0b53b2d, 0, this.ff603d222, 0);
        }
        RUHKvlksrNZIQBpc(this.fad1943a9);
        this.fa43ef6d6 = 0;
    }
}

