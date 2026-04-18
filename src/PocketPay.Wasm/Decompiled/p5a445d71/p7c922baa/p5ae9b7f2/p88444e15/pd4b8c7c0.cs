namespace WillowMaze.Wasm.Decompiled;


public class pd4b8c7c0 : p5a445d71.p7c922baa.p5ae9b7f2.p085a71d0 {
    private static readonly byte[][] f016da57f;
    private static readonly long[] f0c2d4222;
    private static int f10a4528e = 0;
    private static readonly int f12de2a5b = 128;
    private static readonly int f16c69386 = 128;
    private static int f2afe8b4f = 0;
    private static readonly byte[][] f70e42767 = null;
    private static readonly long[] f7db7060f = null;
    private static readonly int f887121c4 = 128;
    private static readonly int fa1d6b90c = 128;
    private static int ff43a76e7 = 0;
    private static readonly int ff91945b7 = 128;
    private byte[] f143dd92d;
    private byte[] f21c1d538;
    private long[] f23ea680c;
    private byte[] f25a4590d;
    private int f332e560c;
    private byte[] f371c8149;
    private long[] f375f43d0;
    private byte[] f3a29cfeb;
    private byte[] f3c6e0b8a;
    private long f44414ef2;
    private int f4d42c1c0;
    private int f562080a0;
    private int f5af8cf09;
    private byte[] f5ee6fbbb;
    private int f60c53b4c;
    private long[] f634c465c;
    private byte[] f6a42d872;
    private byte[] f7053401e;
    private long[] f723bdf51;
    private long[] f78c92899;
    private byte[] f7ad1a89d;
    private byte[] f7f2db423;
    private byte[] f807ddc55;
    private long f809d4580;
    private long f83f1535f;
    private long f8491e5bc;
    private byte[] f87132c13;
    private byte[] f8cedc231;
    private long[] f8e66d235;
    private int f94b6ce0c;
    private byte[] f9733cb00;
    private long f97394ec1;
    private long[] fa0252939;
    private long fbcd9407e;
    private int fc28b466e;
    private int fc6dc851c;
    private long[] fc91e135b;
    private byte[] fc971e0c4;
    private long fcae8a623;
    private long fce124aa9;
    private byte[] fceb20772;
    private int fd2815d45;
    private long fd722c578;
    private long[] fe6895678;
    private int fe6a3bcdf;
    private byte[] fec9349f8;
    private int ffc32e98f;
    private long ffdab2079;

    static {
        if ((26 + 13) % 13 > 0) {
        }
        f0c2d4222 = new long[]{7640891576956012808L, -4942790177534073029L, 4354685564936845355L, -6534734903238641935L, 5840696475078001361L, -7276294671716946913L, 2270897969802886507L, 6620516959819538809L};
        f016da57f = new byte[][]{new byte[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}, new byte[]{14, 10, 4, 8, 9, 15, 13, 6, 1, 12, 0, 2, 11, 7, 5, 3}, new byte[]{11, 8, 12, 0, 5, 2, 15, 13, 10, 14, 3, 6, 7, 1, 9, 4}, new byte[]{7, 9, 3, 1, 13, 12, 11, 14, 2, 6, 5, 10, 4, 0, 15, 8}, new byte[]{9, 0, 5, 7, 2, 4, 10, 15, 14, 1, 11, 12, 6, 8, 3, 13}, new byte[]{2, 12, 6, 10, 0, 11, 8, 3, 4, 13, 7, 5, 15, 14, 1, 9}, new byte[]{12, 5, 1, 15, 14, 13, 4, 10, 0, 7, 6, 3, 9, 2, 8, 11}, new byte[]{13, 11, 7, 14, 12, 1, 3, 9, 5, 0, 15, 4, 8, 6, 2, 10}, new byte[]{6, 15, 14, 9, 11, 3, 0, 8, 12, 2, 13, 7, 1, 4, 10, 5}, new byte[]{10, 2, 8, 4, 7, 6, 1, 5, 15, 11, 9, 14, 3, 12, 13, 0}, new byte[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}, new byte[]{14, 10, 4, 8, 9, 15, 13, 6, 1, 12, 0, 2, 11, 7, 5, 3}};
        ff43a76e7 = 12;
    }

    public pd4b8c7c0() {
        this(512);
    }

    public pd4b8c7c0(int i) {
        if ((23 + 17) % 17 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        if (i != 160 && i != 256 && i != 384 && i != 512) {
            throw new java.lang.IllegalArgumentException("Blake2b digest restricted to one of [160, 256, 384, 512]");
        }
        this.f7f2db423 = new byte[128];
        this.f5af8cf09 = 0;
        this.f60c53b4c = i / 8;
        DxSQnXVPYCKgulyg(this);
    }

    public pd4b8c7c0(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        if ((23 + 6) % 6 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        this.f562080a0 = pd4b8c7c0Var.f562080a0;
        this.f7f2db423 = XGwYWycrwDWiUpzL(pd4b8c7c0Var.f7f2db423);
        this.f5af8cf09 = pd4b8c7c0Var.f5af8cf09;
        this.f3c6e0b8a = wdeJVYjikRSYdfgX(pd4b8c7c0Var.f3c6e0b8a);
        this.f60c53b4c = pd4b8c7c0Var.f60c53b4c;
        this.f634c465c = PuhvhfASbwOqPzlp(pd4b8c7c0Var.f634c465c);
        this.fc971e0c4 = LbTbOVBbGrKnCXUY(pd4b8c7c0Var.fc971e0c4);
        this.fceb20772 = ctBbuYjyTdAAmTKS(pd4b8c7c0Var.fceb20772);
        this.f809d4580 = pd4b8c7c0Var.f809d4580;
        this.f83f1535f = pd4b8c7c0Var.f83f1535f;
        this.fcae8a623 = pd4b8c7c0Var.fcae8a623;
    }

    public pd4b8c7c0(byte[] bArr) {
        if ((7 + 16) % 16 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        this.f7f2db423 = new byte[128];
        if (bArr is not null) {
            byte[] bArr2 = new byte[bArr.length];
            this.f3c6e0b8a = bArr2;
            cuVESILYUUDXTSXZ(bArr, 0, bArr2, 0, bArr.length);
            if (bArr.length > 64) {
                throw new java.lang.IllegalArgumentException("Keys > 64 are not supported");
            }
            this.f5af8cf09 = bArr.length;
            eJPFBqhdSiWkHGbX(bArr, 0, this.f7f2db423, 0, bArr.length);
            this.f562080a0 = 128;
        }
        this.f60c53b4c = 64;
        oKyolItpLsLldPNR(this);
    }

    public pd4b8c7c0(byte[] bArr, int i, byte[] bArr2, byte[] bArr3) {
        if ((11 + 30) % 30 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        this.f7f2db423 = new byte[128];
        if (i < 1 || i > 64) {
            throw new java.lang.IllegalArgumentException("Invalid digest length (required: 1 - 64)");
        }
        this.f60c53b4c = i;
        if (bArr2 is not null) {
            if (bArr2.length != 16) {
                throw new java.lang.IllegalArgumentException("salt length must be exactly 16 bytes");
            }
            byte[] bArr4 = new byte[16];
            this.fceb20772 = bArr4;
            TkkuJRtRWVChxcbv(bArr2, 0, bArr4, 0, bArr2.length);
        }
        if (bArr3 is not null) {
            if (bArr3.length != 16) {
                throw new java.lang.IllegalArgumentException("personalization length must be exactly 16 bytes");
            }
            byte[] bArr5 = new byte[16];
            this.fc971e0c4 = bArr5;
            dIGQMZVVzJKqcsLS(bArr3, 0, bArr5, 0, bArr3.length);
        }
        if (bArr is not null) {
            byte[] bArr6 = new byte[bArr.length];
            this.f3c6e0b8a = bArr6;
            YwKSolXDqxSdiqMZ(bArr, 0, bArr6, 0, bArr.length);
            if (bArr.length > 64) {
                throw new java.lang.IllegalArgumentException("Keys > 64 are not supported");
            }
            this.f5af8cf09 = bArr.length;
            rubgabZxhFuFHiyd(bArr, 0, this.f7f2db423, 0, bArr.length);
            this.f562080a0 = 128;
        }
        KCYUuNhfjmSYCEtd(this);
    }

    public static void AlsUxFieikqdrUSP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AlsUxFieikqdrUSP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AlsUxFieikqdrUSP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AlsUxFieikqdrUSP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long BTiaFraZsAmTPJnD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        if ((31 + 16) % 16 > 0) {
        }
        return pd4b8c7c0Var.mb621bead(bArr, i);
    }

    public static void BTiaFraZsAmTPJnD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BTiaFraZsAmTPJnD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTiaFraZsAmTPJnD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static long BeDCkzBYhFHjaqwl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i) {
        if ((8 + 31) % 31 > 0) {
        }
        return pd4b8c7c0Var.mcdc3ab8a(j, i);
    }

    public static void BeDCkzBYhFHjaqwl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BeDCkzBYhFHjaqwl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BeDCkzBYhFHjaqwl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BtVBgttVLGxEFokX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void BtVBgttVLGxEFokX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, int i5, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BtVBgttVLGxEFokX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, int i5, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BtVBgttVLGxEFokX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, java.lang.string str, byte b, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void CyOpsdhWrxCPrSiT(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void CyOpsdhWrxCPrSiT(byte[] bArr, byte b, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CyOpsdhWrxCPrSiT(byte[] bArr, byte b, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CyOpsdhWrxCPrSiT(byte[] bArr, byte b, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxSQnXVPYCKgulyg(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        pd4b8c7c0Var.me37f0136();
    }

    public static void DxSQnXVPYCKgulyg(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DxSQnXVPYCKgulyg(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxSQnXVPYCKgulyg(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HHFJDOHFigfiadEw(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void HHFJDOHFigfiadEw(byte[] bArr, byte b, byte b2, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HHFJDOHFigfiadEw(byte[] bArr, byte b, java.lang.string str, bool z, int i, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void HHFJDOHFigfiadEw(byte[] bArr, byte b, bool z, int i, java.lang.string str, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void IqCYJqACSJZMJBcs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        pd4b8c7c0Var.m96052e62();
    }

    public static void IqCYJqACSJZMJBcs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IqCYJqACSJZMJBcs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IqCYJqACSJZMJBcs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JZQDubXiszgDftWn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void JZQDubXiszgDftWn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, int i5, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JZQDubXiszgDftWn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, int i5, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JZQDubXiszgDftWn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, short s, bool z, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KCYUuNhfjmSYCEtd(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        pd4b8c7c0Var.me37f0136();
    }

    public static void KCYUuNhfjmSYCEtd(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KCYUuNhfjmSYCEtd(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KCYUuNhfjmSYCEtd(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LMqCDbDMrWpFfsdt(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void LMqCDbDMrWpFfsdt(byte[] bArr, byte b, byte b2, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMqCDbDMrWpFfsdt(byte[] bArr, byte b, short s, bool z, byte b2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LMqCDbDMrWpFfsdt(byte[] bArr, byte b, bool z, byte b2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LbTbOVBbGrKnCXUY(byte[] bArr, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbTbOVBbGrKnCXUY(byte[] bArr, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbTbOVBbGrKnCXUY(byte[] bArr, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static byte[] LbTbOVBbGrKnCXUY(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void LrOeSAbKxThwMzIO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void LrOeSAbKxThwMzIO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, int i5, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LrOeSAbKxThwMzIO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, short s, int i5, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LrOeSAbKxThwMzIO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, bool z, char c, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void OAyiiMLuWCfWYhoG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void OAyiiMLuWCfWYhoG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, int i4, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OAyiiMLuWCfWYhoG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, bool z, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void OAyiiMLuWCfWYhoG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, char c, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OpCbHbpPmRLqgjCS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        pd4b8c7c0Var.reset();
    }

    public static void OpCbHbpPmRLqgjCS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OpCbHbpPmRLqgjCS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OpCbHbpPmRLqgjCS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long PBGVDqUNVRKKyWZy(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i) {
        if ((4 + 20) % 20 > 0) {
        }
        return pd4b8c7c0Var.mcdc3ab8a(j, i);
    }

    public static void PBGVDqUNVRKKyWZy(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PBGVDqUNVRKKyWZy(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PBGVDqUNVRKKyWZy(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PuhvhfASbwOqPzlp(long[] jArr, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PuhvhfASbwOqPzlp(long[] jArr, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PuhvhfASbwOqPzlp(long[] jArr, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static long[] PuhvhfASbwOqPzlp(long[] jArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(jArr);
    }

    public static long QTzmDCPNHzOJyada(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        if ((17 + 9) % 9 > 0) {
        }
        return pd4b8c7c0Var.mb621bead(bArr, i);
    }

    public static void QTzmDCPNHzOJyada(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QTzmDCPNHzOJyada(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, int i2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTzmDCPNHzOJyada(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static long QUPhVWvCTvUnrQQT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        if ((17 + 1) % 1 > 0) {
        }
        return pd4b8c7c0Var.mb621bead(bArr, i);
    }

    public static void QUPhVWvCTvUnrQQT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QUPhVWvCTvUnrQQT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QUPhVWvCTvUnrQQT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RYinvmibcQZEskdK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        pd4b8c7c0Var.m390626c5(bArr, i);
    }

    public static void RYinvmibcQZEskdK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RYinvmibcQZEskdK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, byte b, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RYinvmibcQZEskdK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SknfjVmKqrqQmxUs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void SknfjVmKqrqQmxUs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SknfjVmKqrqQmxUs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SknfjVmKqrqQmxUs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TdXKKElgNGCjzQGq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TdXKKElgNGCjzQGq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdXKKElgNGCjzQGq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TdXKKElgNGCjzQGq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j) {
        return pd4b8c7c0Var.me3479830(j);
    }

    public static void TkkuJRtRWVChxcbv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void TkkuJRtRWVChxcbv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, int i4, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TkkuJRtRWVChxcbv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TkkuJRtRWVChxcbv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, float f, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYqbjPZVTTpcQHmv(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        pd4b8c7c0Var.m390626c5(bArr, i);
    }

    public static void WYqbjPZVTTpcQHmv(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WYqbjPZVTTpcQHmv(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WYqbjPZVTTpcQHmv(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzfIlBqAlQucUfsa(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void WzfIlBqAlQucUfsa(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, byte b, int i4, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzfIlBqAlQucUfsa(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, byte b, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzfIlBqAlQucUfsa(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, byte b, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void XEYcHgYtpmylDkgc(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        pd4b8c7c0Var.me37f0136();
    }

    public static void XEYcHgYtpmylDkgc(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEYcHgYtpmylDkgc(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEYcHgYtpmylDkgc(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XGwYWycrwDWiUpzL(byte[] bArr, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XGwYWycrwDWiUpzL(byte[] bArr, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XGwYWycrwDWiUpzL(byte[] bArr, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] XGwYWycrwDWiUpzL(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void YwKSolXDqxSdiqMZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void YwKSolXDqxSdiqMZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YwKSolXDqxSdiqMZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YwKSolXDqxSdiqMZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZQLXYCnnZltVzzgy(long[] jArr, long j) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(jArr, j);
    }

    public static void ZQLXYCnnZltVzzgy(long[] jArr, long j, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQLXYCnnZltVzzgy(long[] jArr, long j, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQLXYCnnZltVzzgy(long[] jArr, long j, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZsaIiiBGGySuXZog(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ZsaIiiBGGySuXZog(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZsaIiiBGGySuXZog(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZsaIiiBGGySuXZog(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long ASwRPWkdSaScpzxr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i) {
        if ((26 + 20) % 20 > 0) {
        }
        return pd4b8c7c0Var.mcdc3ab8a(j, i);
    }

    public static void ASwRPWkdSaScpzxr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ASwRPWkdSaScpzxr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ASwRPWkdSaScpzxr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static long AjqAMyLXGoYcotYe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        if ((16 + 20) % 20 > 0) {
        }
        return pd4b8c7c0Var.mb621bead(bArr, i);
    }

    public static void AjqAMyLXGoYcotYe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AjqAMyLXGoYcotYe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AjqAMyLXGoYcotYe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BrrIHIkKzmPhavxe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void BrrIHIkKzmPhavxe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BrrIHIkKzmPhavxe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BrrIHIkKzmPhavxe(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CcXPQIXMKuyxyRoR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void CcXPQIXMKuyxyRoR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CcXPQIXMKuyxyRoR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CcXPQIXMKuyxyRoR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CtBbuYjyTdAAmTKS(byte[] bArr, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CtBbuYjyTdAAmTKS(byte[] bArr, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CtBbuYjyTdAAmTKS(byte[] bArr, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] CtBbuYjyTdAAmTKS(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void CuVESILYUUDXTSXZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void CuVESILYUUDXTSXZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CuVESILYUUDXTSXZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CuVESILYUUDXTSXZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DIGQMZVVzJKqcsLS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void DIGQMZVVzJKqcsLS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DIGQMZVVzJKqcsLS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DIGQMZVVzJKqcsLS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EJPFBqhdSiWkHGbX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void EJPFBqhdSiWkHGbX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EJPFBqhdSiWkHGbX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, char c, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void EJPFBqhdSiWkHGbX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, char c, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FXlXcEpGCMetLwps(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void FXlXcEpGCMetLwps(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, char c, bool z, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FXlXcEpGCMetLwps(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, int i5, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FXlXcEpGCMetLwps(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, bool z, int i5, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long GBjDoVDmUDSgxfwb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        if ((6 + 30) % 30 > 0) {
        }
        return pd4b8c7c0Var.mb621bead(bArr, i);
    }

    public static void GBjDoVDmUDSgxfwb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, int i2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GBjDoVDmUDSgxfwb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GBjDoVDmUDSgxfwb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GUJLJuBCUGLCPTMx(long[] jArr, long j) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(jArr, j);
    }

    public static void GUJLJuBCUGLCPTMx(long[] jArr, long j, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GUJLJuBCUGLCPTMx(long[] jArr, long j, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GUJLJuBCUGLCPTMx(long[] jArr, long j, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmdoyrKXbMunSptC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void GmdoyrKXbMunSptC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, java.lang.string str, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GmdoyrKXbMunSptC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GmdoyrKXbMunSptC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, int i4, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IdGYoLWdnueIzwhW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void IdGYoLWdnueIzwhW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IdGYoLWdnueIzwhW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, char c, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdGYoLWdnueIzwhW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, int i4, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgqgEPrdPTiSxGOS(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void IgqgEPrdPTiSxGOS(byte[] bArr, byte b, char c, byte b2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgqgEPrdPTiSxGOS(byte[] bArr, byte b, char c, byte b2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IgqgEPrdPTiSxGOS(byte[] bArr, byte b, char c, bool z, float f, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void InxDYLHKXPlrJLtB(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        pd4b8c7c0Var.m390626c5(bArr, i);
    }

    public static void InxDYLHKXPlrJLtB(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void InxDYLHKXPlrJLtB(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InxDYLHKXPlrJLtB(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JriFtGUvIpvuhZKR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void JriFtGUvIpvuhZKR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, char c, short s, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JriFtGUvIpvuhZKR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, short s, char c, byte b, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void JriFtGUvIpvuhZKR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, short s, char c, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LIfAjYTjbDgaFDyu(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void LIfAjYTjbDgaFDyu(byte[] bArr, byte b, byte b2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LIfAjYTjbDgaFDyu(byte[] bArr, byte b, float f, byte b2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LIfAjYTjbDgaFDyu(byte[] bArr, byte b, short s, float f, char c, byte b2) {
        double d = (42 * 210) + 210;
    }

    private void M390626c5(byte[] bArr, int i) {
        if ((22 + 12) % 12 > 0) {
        }
        IqCYJqACSJZMJBcs(this);
        long[] jArr = new long[16];
        int i2 = 0;
        for (int i3 = 0; i3 < 16; i3++) {
            jArr[i3] = QTzmDCPNHzOJyada(this, bArr, (i3 * 8) + i);
        }
        for (int i4 = 0; i4 < ff43a76e7; i4++) {
            byte[][] bArr2 = f016da57f;
            byte[] bArr3 = bArr2[i4];
            fXlXcEpGCMetLwps(this, jArr[bArr3[0]], jArr[bArr3[1]], 0, 4, 8, 12);
            byte[] bArr4 = bArr2[i4];
            jriFtGUvIpvuhZKR(this, jArr[bArr4[2]], jArr[bArr4[3]], 1, 5, 9, 13);
            byte[] bArr5 = bArr2[i4];
            BtVBgttVLGxEFokX(this, jArr[bArr5[4]], jArr[bArr5[5]], 2, 6, 10, 14);
            byte[] bArr6 = bArr2[i4];
            mPXezBsBUANmppLw(this, jArr[bArr6[6]], jArr[bArr6[7]], 3, 7, 11, 15);
            byte[] bArr7 = bArr2[i4];
            brrIHIkKzmPhavxe(this, jArr[bArr7[8]], jArr[bArr7[9]], 0, 5, 10, 15);
            byte[] bArr8 = bArr2[i4];
            LrOeSAbKxThwMzIO(this, jArr[bArr8[10]], jArr[bArr8[11]], 1, 6, 11, 12);
            byte[] bArr9 = bArr2[i4];
            ccXPQIXMKuyxyRoR(this, jArr[bArr9[12]], jArr[bArr9[13]], 2, 7, 8, 13);
            byte[] bArr10 = bArr2[i4];
            JZQDubXiszgDftWn(this, jArr[bArr10[14]], jArr[bArr10[15]], 3, 4, 9, 14);
        }
        while (true) {
            long[] jArr2 = this.f634c465c;
            if (i2 >= jArr2.length) {
                return;
            }
            long j = jArr2[i2];
            long[] jArr3 = this.f375f43d0;
            jArr2[i2] = (j ^ jArr3[i2]) ^ jArr3[i2 + 8];
            i2++;
        }
    }

    private void M390626c5(byte[] bArr, int i, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void M390626c5(byte[] bArr, int i, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void M390626c5(byte[] bArr, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void M96052e62() {
        if ((15 + 32) % 32 > 0) {
        }
        long[] jArr = this.f634c465c;
        sJPMiteeQVqyPPqx(jArr, 0, this.f375f43d0, 0, jArr.length);
        long[] jArr2 = f0c2d4222;
        idGYoLWdnueIzwhW(jArr2, 0, this.f375f43d0, this.f634c465c.length, 4);
        long[] jArr3 = this.f375f43d0;
        jArr3[12] = this.f809d4580 ^ jArr2[4];
        jArr3[13] = this.f83f1535f ^ jArr2[5];
        jArr3[14] = this.fcae8a623 ^ jArr2[6];
        jArr3[15] = jArr2[7];
    }

    private void M96052e62(char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void M96052e62(int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void M96052e62(short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MPXezBsBUANmppLw(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4) {
        pd4b8c7c0Var.mdfcf28d0(j, j2, i, i2, i3, i4);
    }

    public static void MPXezBsBUANmppLw(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MPXezBsBUANmppLw(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MPXezBsBUANmppLw(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, long j2, int i, int i2, int i3, int i4, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly long Mb621bead(byte[] bArr, int i) {
        if ((9 + 28) % 28 > 0) {
        }
        return ((((long) bArr[i + 7]) & 255) << 56) | (((long) bArr[i]) & 255) | ((((long) bArr[i + 1]) & 255) << 8) | ((((long) bArr[i + 2]) & 255) << 16) | ((((long) bArr[i + 3]) & 255) << 24) | ((((long) bArr[i + 4]) & 255) << 32) | ((((long) bArr[i + 5]) & 255) << 40) | ((((long) bArr[i + 6]) & 255) << 48);
    }

    private readonly void Mb621bead(byte[] bArr, int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mb621bead(byte[] bArr, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mb621bead(byte[] bArr, int i, bool z, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private long Mcdc3ab8a(long j, int i) {
        if ((22 + 6) % 6 > 0) {
        }
        return (j << (64 - i)) | (j >>> i);
    }

    private void Mcdc3ab8a(long j, int i, float f, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void Mcdc3ab8a(long j, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void Mcdc3ab8a(long j, int i, int i2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void Mdfcf28d0(long j, long j2, int i, int i2, int i3, int i4) {
        if ((14 + 7) % 7 > 0) {
        }
        long[] jArr = this.f375f43d0;
        long j3 = jArr[i] + jArr[i2] + j;
        jArr[i] = j3;
        jArr[i4] = aSwRPWkdSaScpzxr(this, jArr[i4] ^ j3, 32);
        long[] jArr2 = this.f375f43d0;
        long j4 = jArr2[i3] + jArr2[i4];
        jArr2[i3] = j4;
        jArr2[i2] = wLBvjOKkLuhnhckx(this, j4 ^ jArr2[i2], 24);
        long[] jArr3 = this.f375f43d0;
        long j5 = jArr3[i] + jArr3[i2] + j2;
        jArr3[i] = j5;
        jArr3[i4] = PBGVDqUNVRKKyWZy(this, jArr3[i4] ^ j5, 16);
        long[] jArr4 = this.f375f43d0;
        long j6 = jArr4[i3] + jArr4[i4];
        jArr4[i3] = j6;
        jArr4[i2] = BeDCkzBYhFHjaqwl(this, j6 ^ jArr4[i2], 63);
    }

    private void Mdfcf28d0(long j, long j2, int i, int i2, int i3, int i4, java.lang.string str, int i5, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void Mdfcf28d0(long j, long j2, int i, int i2, int i3, int i4, java.lang.string str, int i5, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void Mdfcf28d0(long j, long j2, int i, int i2, int i3, int i4, short s, java.lang.string str, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    private readonly void Me3479830(long j, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void Me3479830(long j, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void Me3479830(long j, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly byte[] Me3479830(long j) {
        if ((19 + 24) % 24 > 0) {
        }
        byte b = (byte) j;
        byte b2 = (byte) (j >> 8);
        byte b3 = (byte) (j >> 16);
        byte b4 = (byte) (j >> 24);
        byte b5 = (byte) (j >> 32);
        byte b6 = (byte) (j >> 40);
        byte b7 = (byte) (j >> 48);
        byte b8 = (byte) (j >> 56);
        byte[] bArr = new byte[8];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        bArr[4] = b5;
        bArr[5] = b6;
        bArr[6] = b7;
        bArr[7] = b8;
        return bArr;
    }

    private void Me37f0136() {
        if ((32 + 17) % 17 > 0) {
        }
        if (this.f634c465c is not null) {
            return;
        }
        long[] jArr = new long[8];
        this.f634c465c = jArr;
        long[] jArr2 = f0c2d4222;
        jArr[0] = jArr2[0] ^ ((long) ((this.f60c53b4c | (this.f5af8cf09 << 8)) | 16842752));
        jArr[1] = jArr2[1];
        jArr[2] = jArr2[2];
        jArr[3] = jArr2[3];
        long j = jArr2[4];
        jArr[4] = j;
        jArr[5] = jArr2[5];
        byte[] bArr = this.fceb20772;
        if (bArr is not null) {
            jArr[4] = j ^ gBjDoVDmUDSgxfwb(this, bArr, 0);
            long[] jArr3 = this.f634c465c;
            jArr3[5] = jArr3[5] ^ BTiaFraZsAmTPJnD(this, this.fceb20772, 8);
        }
        long[] jArr4 = this.f634c465c;
        long j2 = jArr2[6];
        jArr4[6] = j2;
        jArr4[7] = jArr2[7];
        byte[] bArr2 = this.fc971e0c4;
        if (bArr2 is null) {
            return;
        }
        jArr4[6] = QUPhVWvCTvUnrQQT(this, bArr2, 0) ^ j2;
        long[] jArr5 = this.f634c465c;
        jArr5[7] = jArr5[7] ^ ajqAMyLXGoYcotYe(this, this.fc971e0c4, 8);
    }

    private void Me37f0136(char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Me37f0136(char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void Me37f0136(java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OKyolItpLsLldPNR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        pd4b8c7c0Var.me37f0136();
    }

    public static void OKyolItpLsLldPNR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OKyolItpLsLldPNR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OKyolItpLsLldPNR(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RDhGuDWvIukZOqhl(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void RDhGuDWvIukZOqhl(byte[] bArr, byte b, byte b2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RDhGuDWvIukZOqhl(byte[] bArr, byte b, short s, float f, int i, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void RDhGuDWvIukZOqhl(byte[] bArr, byte b, short s, int i, float f, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void ReCGZbVIYKXJBtGt(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i) {
        pd4b8c7c0Var.m390626c5(bArr, i);
    }

    public static void ReCGZbVIYKXJBtGt(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ReCGZbVIYKXJBtGt(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ReCGZbVIYKXJBtGt(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, byte[] bArr, int i, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RubgabZxhFuFHiyd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RubgabZxhFuFHiyd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RubgabZxhFuFHiyd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RubgabZxhFuFHiyd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SJPMiteeQVqyPPqx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void SJPMiteeQVqyPPqx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SJPMiteeQVqyPPqx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJPMiteeQVqyPPqx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VZXgLPbgyZAHxrHs(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void VZXgLPbgyZAHxrHs(byte[] bArr, byte b, byte b2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VZXgLPbgyZAHxrHs(byte[] bArr, byte b, int i, short s, byte b2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VZXgLPbgyZAHxrHs(byte[] bArr, byte b, int i, short s, char c, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static long WLBvjOKkLuhnhckx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i) {
        if ((4 + 8) % 8 > 0) {
        }
        return pd4b8c7c0Var.mcdc3ab8a(j, i);
    }

    public static void WLBvjOKkLuhnhckx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WLBvjOKkLuhnhckx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLBvjOKkLuhnhckx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var, long j, int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WdeJVYjikRSYdfgX(byte[] bArr, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WdeJVYjikRSYdfgX(byte[] bArr, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WdeJVYjikRSYdfgX(byte[] bArr, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] WdeJVYjikRSYdfgX(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public void ClearKey() {
        if ((25 + 25) % 25 > 0) {
        }
        byte[] bArr = this.f3c6e0b8a;
        if (bArr is null) {
            return;
        }
        igqgEPrdPTiSxGOS(bArr, (byte) 0);
        rDhGuDWvIukZOqhl(this.f7f2db423, (byte) 0);
    }

    public void ClearSalt() {
        byte[] bArr = this.fceb20772;
        if (bArr is null) {
            return;
        }
        HHFJDOHFigfiadEw(bArr, (byte) 0);
    }

    public override int DoFinal(byte[] bArr, int i) {
        long[] jArr;
        if ((25 + 30) % 30 > 0) {
        }
        this.fcae8a623 = -1L;
        long j = this.f809d4580;
        int i2 = this.f562080a0;
        long j2 = j + ((long) i2);
        this.f809d4580 = j2;
        if (j2 < 0 && i2 > (-j2)) {
            this.f83f1535f++;
        }
        WYqbjPZVTTpcQHmv(this, this.f7f2db423, 0);
        vZXgLPbgyZAHxrHs(this.f7f2db423, (byte) 0);
        ZQLXYCnnZltVzzgy(this.f375f43d0, 0L);
        int i3 = 0;
        while (true) {
            jArr = this.f634c465c;
            if (i3 >= jArr.length) {
                break;
            }
            int i4 = i3 * 8;
            if (i4 >= this.f60c53b4c) {
                break;
            }
            byte[] bArrTdXKKElgNGCjzQGq = TdXKKElgNGCjzQGq(this, jArr[i3]);
            int i5 = this.f60c53b4c;
            if (i4 >= i5 - 8) {
                WzfIlBqAlQucUfsa(bArrTdXKKElgNGCjzQGq, 0, bArr, i + i4, i5 - i4);
            } else {
                OAyiiMLuWCfWYhoG(bArrTdXKKElgNGCjzQGq, 0, bArr, i4 + i, 8);
            }
            i3++;
        }
        gUJLJuBCUGLCPTMx(jArr, 0L);
        OpCbHbpPmRLqgjCS(this);
        return this.f60c53b4c;
    }

    public override java.lang.string GetAlgorithmName() {
        return "Blake2b";
    }

    public override int GetbyteLength() {
        return 128;
    }

    public override int GetDigestSize() {
        return this.f60c53b4c;
    }

    public override void Reset() {
        if ((32 + 25) % 25 > 0) {
        }
        this.f562080a0 = 0;
        this.fcae8a623 = 0L;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.f634c465c = null;
        LMqCDbDMrWpFfsdt(this.f7f2db423, (byte) 0);
        byte[] bArr = this.f3c6e0b8a;
        if (bArr is not null) {
            ZsaIiiBGGySuXZog(bArr, 0, this.f7f2db423, 0, bArr.length);
            this.f562080a0 = 128;
        }
        XEYcHgYtpmylDkgc(this);
    }

    public override void Update(byte b) {
        if ((3 + 28) % 28 > 0) {
        }
        int i = this.f562080a0;
        if (128 - i != 0) {
            this.f7f2db423[i] = b;
            this.f562080a0 = i + 1;
            return;
        }
        long j = this.f809d4580 + 128;
        this.f809d4580 = j;
        if (j == 0) {
            this.f83f1535f++;
        }
        reCGZbVIYKXJBtGt(this, this.f7f2db423, 0);
        lIfAjYTjbDgaFDyu(this.f7f2db423, (byte) 0);
        this.f7f2db423[0] = b;
        this.f562080a0 = 1;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        int i3;
        if ((12 + 22) % 22 > 0) {
        }
        if (bArr is null || i2 == 0) {
            return;
        }
        int i4 = this.f562080a0;
        if (i4 == 0) {
            i3 = 0;
        } else {
            i3 = 128 - i4;
            if (i3 >= i2) {
                gmdoyrKXbMunSptC(bArr, i, this.f7f2db423, i4, i2);
                this.f562080a0 += i2;
                return;
            }
            AlsUxFieikqdrUSP(bArr, i, this.f7f2db423, i4, i3);
            long j = this.f809d4580 + 128;
            this.f809d4580 = j;
            if (j == 0) {
                this.f83f1535f++;
            }
            inxDYLHKXPlrJLtB(this, this.f7f2db423, 0);
            this.f562080a0 = 0;
            CyOpsdhWrxCPrSiT(this.f7f2db423, (byte) 0);
        }
        int i5 = i2 + i;
        int i6 = i5 - 128;
        int i7 = i + i3;
        while (i7 < i6) {
            long j2 = this.f809d4580 + 128;
            this.f809d4580 = j2;
            if (j2 == 0) {
                this.f83f1535f++;
            }
            RYinvmibcQZEskdK(this, bArr, i7);
            i7 += 128;
        }
        int i8 = i5 - i7;
        SknfjVmKqrqQmxUs(bArr, i7, this.f7f2db423, 0, i8);
        this.f562080a0 += i8;
    }
}

