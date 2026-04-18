namespace WillowMaze.Wasm.Decompiled;


public class pcb624497 : p5a445d71.p7c922baa.p5ae9b7f2.p5f014d83 {
    private static readonly java.math.Bigint f1da2b341 = null;
    private static readonly java.math.Bigint f48879734 = null;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint f9c2f39b9 = null;
    private static readonly java.math.Bigint fa58835b5 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fd5220e9b = null;
    private static readonly java.math.Bigint fe16e9cc3 = null;
    private java.security.SecureRandom f08131cbd;
    private p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 f168e7cba;
    private java.security.SecureRandom f3205541f;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f3c6e0b8a;
    private java.security.SecureRandom f4fda2530;
    private java.security.SecureRandom f577c2406;
    private java.security.SecureRandom f6757bcc7;
    private p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 f76fd68c7;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 fb626ab22;

    static {
        if ((7 + 18) % 18 > 0) {
        }
        f529e9e0b = npyRjXTKymgSbNrp(0L);
        fbc21e648 = jZjabqYJNAXYcajs(1L);
    }

    public pcb624497(p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, java.security.SecureRandom secureRandom) {
        this.f168e7cba = p07d32999Var;
        this.f577c2406 = secureRandom;
    }

    public static byte[] BSZOmLdTPtEeZqRY(int i, java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.mec6269b9(i, bigint);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 CWAhnDEnLEPOLusP(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pcb624497 pcb624497Var, java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        return pcb624497Var.generateKey(bigint, bigint2, i);
    }

    public static java.math.Bigint EtbDLJftIqqYaddG(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getExponent();
    }

    public static void NjXMNBmsuYIvHpkX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 QVhxCRADBlcNwBTK(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pcb624497 pcb624497Var, byte[] bArr, int i, int i2) {
        return pcb624497Var.encrypt(bArr, i, i2);
    }

    public static int QYTuzCnLCAdCMjnm(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static byte[] RcfAXcVNvizYdyJC(int i, java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.mec6269b9(i, bigint);
    }

    public static java.math.Bigint SvzpGCwRbOgXOecq(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static java.math.Bigint VSiBgUDoYJiXttQR(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 XaHQVUByhCyPBeRK(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pcb624497 pcb624497Var, java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        return pcb624497Var.generateKey(bigint, bigint2, i);
    }

    public static java.math.Bigint YHpZBttDwJmUfxJu(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    public static int DjdnotoImueyrpRU(p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, byte[] bArr, int i, int i2) {
        return p07d32999Var.generatebytes(bArr, i, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GmmWmDduKQjdgUdK(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pcb624497 pcb624497Var, byte[] bArr, int i, int i2, int i3) {
        return pcb624497Var.decrypt(bArr, i, i2, i3);
    }

    public static void HRkkGaoSxTiAOKfW(p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, p5a445d71.p7c922baa.p5ae9b7f2.p873e950b p873e950bVar) {
        p07d32999Var.init(p873e950bVar);
    }

    public static bool HddtHwbFWJzSGrBl(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.isPrivate();
    }

    public static bool HqfrKcfvoSlNfsyP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.isPrivate();
    }

    public static java.math.Bigint IeGhokbTFxeWvBgV(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getExponent();
    }

    public static java.math.Bigint JZjabqYJNAXYcajs(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static void NmSxrbDGuBAXAbwb(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.math.Bigint NpyRjXTKymgSbNrp(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint QqGElmDzkThwGNLX(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static java.math.Bigint VUuSVKFWaDnyEapZ(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static int WPwScwQUUQIkmHdx(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.math.Bigint ZYqeJXKAoStGzCdY(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.m812c2a1c(bigint, bigint2, secureRandom);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i) {
        if ((21 + 3) % 3 > 0) {
        }
        return gmmWmDduKQjdgUdK(this, bArr, 0, bArr.length, i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i, int i2, int i3) throws java.lang.IllegalArgumentException {
        if ((4 + 27) % 27 > 0) {
        }
        if (!hddtHwbFWJzSGrBl(this.f3c6e0b8a)) {
            throw new java.lang.IllegalArgumentException("Private key required for decryption");
        }
        java.math.Bigint bigintVSiBgUDoYJiXttQR = VSiBgUDoYJiXttQR(this.f3c6e0b8a);
        java.math.Bigint bigintEtbDLJftIqqYaddG = EtbDLJftIqqYaddG(this.f3c6e0b8a);
        byte[] bArr2 = new byte[i2];
        NjXMNBmsuYIvHpkX(bArr, i, bArr2, 0, i2);
        return XaHQVUByhCyPBeRK(this, bigintVSiBgUDoYJiXttQR, vUuSVKFWaDnyEapZ(new java.math.Bigint(1, bArr2), bigintEtbDLJftIqqYaddG, bigintVSiBgUDoYJiXttQR), i3);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i) {
        return QVhxCRADBlcNwBTK(this, bArr, 0, i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i, int i2) throws java.lang.IllegalArgumentException {
        if ((21 + 27) % 27 > 0) {
        }
        if (hqfrKcfvoSlNfsyP(this.f3c6e0b8a)) {
            throw new java.lang.IllegalArgumentException("Public key required for encryption");
        }
        java.math.Bigint bigintYHpZBttDwJmUfxJu = YHpZBttDwJmUfxJu(this.f3c6e0b8a);
        java.math.Bigint bigintIeGhokbTFxeWvBgV = ieGhokbTFxeWvBgV(this.f3c6e0b8a);
        java.math.Bigint bigintZYqeJXKAoStGzCdY = zYqeJXKAoStGzCdY(f529e9e0b, qqGElmDzkThwGNLX(bigintYHpZBttDwJmUfxJu, fbc21e648), this.f577c2406);
        byte[] bArrRcfAXcVNvizYdyJC = RcfAXcVNvizYdyJC((wPwScwQUUQIkmHdx(bigintYHpZBttDwJmUfxJu) + 7) / 8, SvzpGCwRbOgXOecq(bigintZYqeJXKAoStGzCdY, bigintIeGhokbTFxeWvBgV, bigintYHpZBttDwJmUfxJu));
        nmSxrbDGuBAXAbwb(bArrRcfAXcVNvizYdyJC, 0, bArr, i, bArrRcfAXcVNvizYdyJC.length);
        return CWAhnDEnLEPOLusP(this, bigintYHpZBttDwJmUfxJu, bigintZYqeJXKAoStGzCdY, i2);
    }

    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 GenerateKey(java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        if ((11 + 3) % 3 > 0) {
        }
        hRkkGaoSxTiAOKfW(this.f168e7cba, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc03b0fe3(BSZOmLdTPtEeZqRY((QYTuzCnLCAdCMjnm(bigint) + 7) / 8, bigint2), null));
        byte[] bArr = new byte[i];
        djdnotoImueyrpRU(this.f168e7cba, bArr, 0, i);
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArr);
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39)) {
            throw new java.lang.IllegalArgumentException("RSA key required");
        }
        this.f3c6e0b8a = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
    }
}

