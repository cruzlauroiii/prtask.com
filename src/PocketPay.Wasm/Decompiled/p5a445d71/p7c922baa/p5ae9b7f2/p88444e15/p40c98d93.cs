namespace WillowMaze.Wasm.Decompiled;


public class p40c98d93 : p5a445d71.p7c922baa.p5ae9b7f2.p085a71d0, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 {
    private static readonly int f0133ca9b = 16;
    private static readonly int f0184e7e1 = 285;
    private static readonly int f0d7e5a5c = 64;
    private static readonly byte[][] f1556ee0b = null;
    private static readonly int f1b405827 = 128;
    private static readonly int f1e83087e = 14;
    private static readonly int f1e847936 = 10;
    private static readonly int f1f206c53 = 285;
    private static readonly int f33d6ad52 = 8;
    private static readonly byte[][] f45c327f4 = null;
    private static readonly byte[][] f4f021238 = null;
    private static readonly int f54fd1d95 = 285;
    private static readonly int f5989d5f3 = 64;
    private static readonly byte[][] f5bcb2c70 = null;
    private static readonly int f606ffe02 = 16;
    private static readonly int f7104d7e2 = 8;
    private static readonly int f73505c1b = 14;
    private static readonly int f76c91deb = 8;
    private static readonly int f7ec78af4 = 64;
    private static readonly int f8bd5c340 = 8;
    private static readonly byte[][] f9001d89d = null;
    private static readonly int f912e716a = 128;
    private static readonly int f9786774e = 8;
    private static readonly int f98443ad8 = 14;
    private static readonly int f9d7e4072 = 10;
    private static readonly int fa38f4464 = 8;
    private static readonly int fb21e1fe2 = 16;
    private static readonly int fb6928334 = 8;
    private static readonly byte[][] fba80cc6d;
    private static readonly byte[][] fc219d3da = null;
    private static readonly int fce4aae3b = 8;
    private static readonly int fd42a8c0d = 8;
    private static readonly int fe02f566f = 8;
    private static readonly int fe5856e2f = 8;
    private static readonly int fec60c4db = 8;
    private static readonly byte[][] ff093f00a;
    private static readonly int ff58f5159 = 285;
    private long f041709f4;
    private byte[][] f14f0c1ce;
    private int f17344fad;
    private byte[][] f1928dafd;
    private int f3587ab47;
    private byte[][] f38352212;
    private byte[] f3aac2945;
    private byte[] f40201b03;
    private int f480d1b61;
    private long[] f4a1efc57;
    private byte[][] f4b14c05a;
    private int f4e5d99d9;
    private int f4fe2f532;
    private int f511b8787;
    private int f54ca84a7;
    private byte[][] f5625fb1b;
    private byte[] f5cf32afe;
    private byte[] f5d177164;
    private int f65d2a691;
    private long f70a54cd1;
    private long[] f76333aca;
    private byte[][] f7a46577e;
    private int f7a7bacbf;
    private int f7b108470;
    private int f8112b92d;
    private byte[][] f81734cbc;
    private long[] f83082853;
    private int f844dd805;
    private byte[][] f87452606;
    private int f8945cb4e;
    private long f8bed82e6;
    private int f8d7e7aa4;
    private int f8ef6af73;
    private int f8f338c8a;
    private int f94221148;
    private int f9b15cb2a;
    private byte[] f9bc0fbaf;
    private byte[] f9cee019e;
    private byte[][] f9ed39e2e;
    private byte[] fa36a2209;
    private byte[] fa74d7e48;
    private byte[] fa94d3b44;
    private byte[] fbbc77c79;
    private int fbd55a9f8;
    private byte[] fbeb2c368;
    private long[] fbf0a43d7;
    private byte[] fc3b09c86;
    private byte[] fcb7e52b2;
    private long fcf379519;
    private int fd502b549;
    private int fd8baebf5;
    private int fda996c49;
    private byte[][] fdcb60f97;
    private byte[] fe5cb2705;
    private byte[] fe83ce4cf;
    private byte[] feba1fcd2;

    static {
        if ((10 + 18) % 18 > 0) {
        }
        ff093f00a = new byte[][]{new byte[]{1, 1, 5, 1, 8, 6, 7, 4}, new byte[]{4, 1, 1, 5, 1, 8, 6, 7}, new byte[]{7, 4, 1, 1, 5, 1, 8, 6}, new byte[]{6, 7, 4, 1, 1, 5, 1, 8}, new byte[]{8, 6, 7, 4, 1, 1, 5, 1}, new byte[]{1, 8, 6, 7, 4, 1, 1, 5}, new byte[]{5, 1, 8, 6, 7, 4, 1, 1}, new byte[]{1, 5, 1, 8, 6, 7, 4, 1}};
        fba80cc6d = new byte[][]{new byte[]{-88, 67, 95, 6, 107, 117, 108, 89, 113, -33, -121, -107, 23, -16, -40, 9, 109, -13, 29, -53, -55, 77, 44, -81, 121, -32, -105, -3, 111, 75, 69, 57, 62, -35, -93, 79, -76, -74, -102, 14, 31, -65, 21, -31, 73, -46, -109, -58, -110, 114, -98, 97, -47, 99, -6, -18, -12, 25, -43, -83, 88, -92, -69, -95, -36, -14, -125, 55, 66, -28, 122, 50, -100, -52, -85, 74, -113, 110, 4, 39, 46, -25, -30, 90, -106, 22, 35, 43, -62, 101, 102, 15, -68, -87, 71, 65, 52, 72, -4, -73, 106, -120, -91, 83, -122, -7, 91, -37, 56, 123, -61, 30, 34, 51, 36, 40, 54, -57, -78, 59, -114, 119, -70, -11, 20, -97, 8, 85, -101, 76, -2, 96, 92, -38, 24, 70, -51, 125, 33, -80, 63, 27, -119, -1, -21, -124, 105, 58, -99, -41, -45, 112, 103, 64, -75, -34, 93, 48, -111, -79, 120, 17, 1, -27, 0, 104, -104, -96, -59, 2, -90, 116, 45, 11, -94, 118, -77, -66, -50, -67, -82, -23, -118, 49, 28, -20, -15, -103, -108, -86, -10, 38, 47, -17, -24, -116, 53, 3, -44, 127, -5, 5, -63, 94, -112, 32, 61, -126, -9, -22, 10, 13, 126, -8, 80, 26, -60, 7, 87, -72, 60, 98, -29, -56, -84, 82, 100, 16, -48, -39, 19, 12, 18, 41, 81, -71, -49, -42, 115, -115, -127, 84, -64, -19, 78, 68, -89, 42, -123, 37, -26, -54, 124, -117, 86, -128}, new byte[]{-50, -69, -21, -110, -22, -53, 19, -63, -23, 58, -42, -78, -46, -112, 23, -8, 66, 21, 86, -76, 101, 28, -120, 67, -59, 92, 54, -70, -11, 87, 103, -115, 49, -10, 100, 88, -98, -12, 34, -86, 117, 15, 2, -79, -33, 109, 115, 77, 124, 38, 46, -9, 8, 93, 68, 62, -97, 20, -56, -82, 84, 16, -40, -68, 26, 107, 105, -13, -67, 51, -85, -6, -47, -101, 104, 78, 22, -107, -111, -18, 76, 99, -114, 91, -52, 60, 25, -95, -127, 73, 123, -39, 111, 55, 96, -54, -25, 43, 72, -3, -106, 69, -4, 65, 18, 13, 121, -27, -119, -116, -29, 32, 48, -36, -73, 108, 74, -75, 63, -105, -44, 98, 45, 6, -92, -91, -125, 95, 42, -38, -55, 0, 126, -94, 85, -65, 17, -43, -100, -49, 14, 10, 61, 81, 125, -109, 27, -2, -60, 71, 9, -122, 11, -113, -99, 106, 7, -71, -80, -104, 24, 50, 113, 75, -17, 59, 112, -96, -28, 64, -1, -61, -87, -26, 120, -7, -117, 70, -128, 30, 56, -31, -72, -88, -32, 12, 35, 118, 29, 37, 36, 5, -15, 110, -108, 40, -102, -124, -24, -93, 79, 119, -45, -123, -30, 82, -14, -126, 80, 122, 47, 116, 83, -77, 97, -81, 57, 53, -34, -51, 31, -103, -84, -83, 114, 44, -35, -48, -121, -66, 94, -90, -20, 4, -58, 3, 52, -5, -37, 89, -74, -62, 1, -16, 90, -19, -89, 102, 33, 127, -118, 39, -57, -64, 41, -41}, new byte[]{-109, -39, -102, -75, -104, 34, 69, -4, -70, 106, -33, 2, -97, -36, 81, 89, 74, 23, 43, -62, -108, -12, -69, -93, 98, -28, 113, -44, -51, 112, 22, -31, 73, 60, -64, -40, 92, -101, -83, -123, 83, -95, 122, -56, 45, -32, -47, 114, -90, 44, -60, -29, 118, 120, -73, -76, 9, 59, 14, 65, 76, -34, -78, -112, 37, -91, -41, 3, 17, 0, -61, 46, -110, -17, 78, 18, -99, 125, -53, 53, 16, -43, 79, -98, 77, -87, 85, -58, -48, 123, 24, -105, -45, 54, -26, 72, 86, -127, -113, 119, -52, -100, -71, -30, -84, -72, 47, 21, -92, 124, -38, 56, 30, 11, 5, -42, 20, 110, 108, 126, 102, -3, -79, -27, 96, -81, 94, 51, -121, -55, -16, 93, 109, 63, -120, -115, -57, -9, 29, -23, -20, -19, -128, 41, 39, -49, -103, -88, 80, 15, 55, 36, 40, 48, -107, -46, 62, 91, 64, -125, -77, 105, 87, 31, 7, 28, -118, -68, 32, -21, -50, -114, -85, -18, 49, -94, 115, -7, -54, 58, 26, -5, 13, -63, -2, -6, -14, 111, -67, -106, -35, 67, 82, -74, 8, -13, -82, -66, 25, -119, 50, 38, -80, -22, 75, 100, -124, -126, 107, -11, 121, -65, 1, 95, 117, 99, 27, 35, 61, 104, 42, 101, -24, -111, -10, -1, 19, 88, -15, 71, 10, 127, -59, -89, -25, 97, 90, 6, 70, 68, 66, 4, -96, -37, 57, -122, 84, -86, -116, 52, 33, -117, -8, 12, 116, 103}, new byte[]{104, -115, -54, 77, 115, 75, 78, 42, -44, 82, 38, -77, 84, 30, 25, 31, 34, 3, 70, 61, 45, 74, 83, -125, 19, -118, -73, -43, 37, 121, -11, -67, 88, 47, 13, 2, -19, 81, -98, 17, -14, 62, 85, 94, -47, 22, 60, 102, 112, 93, -13, 69, 64, -52, -24, -108, 86, 8, -50, 26, 58, -46, -31, -33, -75, 56, 110, 14, -27, -12, -7, -122, -23, 79, -42, -123, 35, -49, 50, -103, 49, 20, -82, -18, -56, 72, -45, 48, -95, -110, 65, -79, 24, -60, 44, 113, 114, 68, 21, -3, 55, -66, 95, -86, -101, -120, -40, -85, -119, -100, -6, 96, -22, -68, 98, 12, 36, -90, -88, -20, 103, 32, -37, 124, 40, -35, -84, 91, 52, 126, 16, -15, 123, -113, 99, -96, 5, -102, 67, 119, 33, -65, 39, 9, -61, -97, -74, -41, 41, -62, -21, -64, -92, -117, -116, 29, -5, -1, -63, -78, -105, 46, -8, 101, -10, 117, 7, 4, 73, 51, -28, -39, -71, -48, 66, -57, 108, -112, 0, -114, 111, 80, 1, -59, -38, 71, 63, -51, 105, -94, -30, 122, -89, -58, -109, 15, 10, 6, -26, 43, -106, -93, 28, -81, 106, 18, -124, 57, -25, -80, -126, -9, -2, -99, -121, 92, -127, 53, -34, -76, -91, -4, -128, -17, -53, -69, 107, 118, -70, 90, 125, 120, 11, -107, -29, -83, 116, -104, 59, 54, 100, 109, -36, -16, 89, -87, 76, 23, 127, -111, -72, -55, 87, 27, -32, 97}};
    }

    public p40c98d93(int i) {
        byte[][] bArr;
        if ((8 + 18) % 18 > 0) {
        }
        if (i != 256 && i != 384 && i != 512) {
            throw new java.lang.IllegalArgumentException("Hash size is not recommended. Use 256/384/512 instead");
        }
        this.f17344fad = i / 8;
        if (i <= 256) {
            this.f480d1b61 = 64;
            this.f54ca84a7 = 8;
            this.f8d7e7aa4 = 10;
            this.f9ed39e2e = new byte[64][];
        } else {
            this.f480d1b61 = 128;
            this.f54ca84a7 = 16;
            this.f8d7e7aa4 = 14;
            this.f9ed39e2e = new byte[128][];
        }
        int i2 = 0;
        while (true) {
            bArr = this.f9ed39e2e;
            if (i2 >= bArr.length) {
                break;
            }
            bArr[i2] = new byte[this.f54ca84a7];
            i2++;
        }
        bArr[0][0] = (byte) bArr.length;
        this.f5cf32afe = null;
        this.f5625fb1b = new byte[128][];
        this.f87452606 = new byte[128][];
        for (int i3 = 0; i3 < this.f9ed39e2e.length; i3++) {
            this.f5625fb1b[i3] = new byte[8];
            this.f87452606[i3] = new byte[8];
        }
        this.fa36a2209 = new byte[16];
        this.f5d177164 = new byte[8];
        this.f4a1efc57 = new long[this.f54ca84a7];
        this.fcb7e52b2 = new byte[this.f480d1b61];
    }

    public p40c98d93(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var) {
        wNaGachOKCQGaTHS(this, p40c98d93Var);
    }

    public static void ABsXASMbdkrMDCeT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var) {
        p40c98d93Var.m44c29edb();
    }

    public static void ABsXASMbdkrMDCeT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABsXASMbdkrMDCeT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABsXASMbdkrMDCeT(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CPaJHWCeyaPbHPBq(long[] jArr, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CPaJHWCeyaPbHPBq(long[] jArr, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CPaJHWCeyaPbHPBq(long[] jArr, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static long[] CPaJHWCeyaPbHPBq(long[] jArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(jArr);
    }

    public static void CpkrsDeSnCUorxIJ(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void CpkrsDeSnCUorxIJ(byte[] bArr, byte b, byte b2, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CpkrsDeSnCUorxIJ(byte[] bArr, byte b, short s, byte b2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpkrsDeSnCUorxIJ(byte[] bArr, byte b, short s, int i, byte b2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EkdtasuJoERCberf(byte[][] bArr, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EkdtasuJoERCberf(byte[][] bArr, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EkdtasuJoERCberf(byte[][] bArr, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[][] EkdtasuJoERCberf(byte[][] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void GRyagfUhISoyarhs(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void GRyagfUhISoyarhs(byte[] bArr, byte b, char c, byte b2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GRyagfUhISoyarhs(byte[] bArr, byte b, float f, byte b2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRyagfUhISoyarhs(byte[] bArr, byte b, short s, float f, byte b2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GaOjDoDDQhmKyXHx(byte[] bArr, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GaOjDoDDQhmKyXHx(byte[] bArr, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GaOjDoDDQhmKyXHx(byte[] bArr, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] GaOjDoDDQhmKyXHx(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void GdgsaIdwUPFuEZVC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void GdgsaIdwUPFuEZVC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, int i4, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GdgsaIdwUPFuEZVC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GdgsaIdwUPFuEZVC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, short s, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HnEfRCrfoeDunYWH(byte[][] bArr, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HnEfRCrfoeDunYWH(byte[][] bArr, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HnEfRCrfoeDunYWH(byte[][] bArr, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[][] HnEfRCrfoeDunYWH(byte[][] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void IxLQEvOeUqxNavRA(byte[][] bArr, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxLQEvOeUqxNavRA(byte[][] bArr, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IxLQEvOeUqxNavRA(byte[][] bArr, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[][] IxLQEvOeUqxNavRA(byte[][] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void JoBcMqhuarKHWqOh(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var) {
        p40c98d93Var.reset();
    }

    public static void JoBcMqhuarKHWqOh(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JoBcMqhuarKHWqOh(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JoBcMqhuarKHWqOh(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NyIajqBHtWHbiqIA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i) {
        p40c98d93Var.me3ee4228(bArr, i);
    }

    public static void NyIajqBHtWHbiqIA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyIajqBHtWHbiqIA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NyIajqBHtWHbiqIA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SjLzVzOnWbHFCMVC(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void SjLzVzOnWbHFCMVC(byte[] bArr, byte b, byte b2, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SjLzVzOnWbHFCMVC(byte[] bArr, byte b, short s, int i, byte b2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SjLzVzOnWbHFCMVC(byte[] bArr, byte b, short s, int i, java.lang.string str, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void SmpAXsdUuUGJTUpk(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void SmpAXsdUuUGJTUpk(byte[] bArr, byte b, float f, byte b2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SmpAXsdUuUGJTUpk(byte[] bArr, byte b, float f, short s, java.lang.string str, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void SmpAXsdUuUGJTUpk(byte[] bArr, byte b, short s, byte b2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TcHxAtTvlrlbrMPW(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m946e4d20(j, bArr, i);
    }

    public static void TcHxAtTvlrlbrMPW(long j, byte[] bArr, int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TcHxAtTvlrlbrMPW(long j, byte[] bArr, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TcHxAtTvlrlbrMPW(long j, byte[] bArr, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VgOuAWqvmQhNIEqT(byte[] bArr, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VgOuAWqvmQhNIEqT(byte[] bArr, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VgOuAWqvmQhNIEqT(byte[] bArr, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] VgOuAWqvmQhNIEqT(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void WuBthDfzZLlblPhi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2) {
        p40c98d93Var.me7efa710(p40c98d93Var2);
    }

    public static void WuBthDfzZLlblPhi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuBthDfzZLlblPhi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WuBthDfzZLlblPhi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WvWFnSsRGPdMmmza(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void WvWFnSsRGPdMmmza(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, byte b, int i4, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WvWFnSsRGPdMmmza(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, int i4, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WvWFnSsRGPdMmmza(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, float f, byte b, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void XGoiPHPpfIaGjOLV(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, int i2, char c, int i3, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XGoiPHPpfIaGjOLV(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, int i2, int i3, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XGoiPHPpfIaGjOLV(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, int i2, java.lang.string str, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] XGoiPHPpfIaGjOLV(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, int i2) {
        return p40c98d93Var.m4dca00da(bArr, i, i2);
    }

    public static long XdXGqNBtMpNwomtL(byte[] bArr, int i) {
        if ((23 + 32) % 32 > 0) {
        }
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m59a97823(bArr, i);
    }

    public static void XdXGqNBtMpNwomtL(byte[] bArr, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XdXGqNBtMpNwomtL(byte[] bArr, int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XdXGqNBtMpNwomtL(byte[] bArr, int i, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YIowTuttcmyKvPyI(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void YIowTuttcmyKvPyI(byte[] bArr, byte b, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YIowTuttcmyKvPyI(byte[] bArr, byte b, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YIowTuttcmyKvPyI(byte[] bArr, byte b, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BNwBuLAnXxuDaMAg(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m946e4d20(j, bArr, i);
    }

    public static void BNwBuLAnXxuDaMAg(long j, byte[] bArr, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNwBuLAnXxuDaMAg(long j, byte[] bArr, int i, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNwBuLAnXxuDaMAg(long j, byte[] bArr, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HzIoJYAfIVeFwWQM(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void HzIoJYAfIVeFwWQM(byte[] bArr, byte b, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzIoJYAfIVeFwWQM(byte[] bArr, byte b, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HzIoJYAfIVeFwWQM(byte[] bArr, byte b, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte IVPZfIJSbAXGUsHQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2) {
        return p40c98d93Var.m5199f372(b, b2);
    }

    public static void IVPZfIJSbAXGUsHQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, int i, bool z, java.lang.string str, byte b3) {
        double d = (42 * 210) + 210;
    }

    public static void IVPZfIJSbAXGUsHQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, java.lang.string str, int i, byte b3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVPZfIJSbAXGUsHQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, bool z, byte b3, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte IdwKnBvtZQsFnfFl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2) {
        return p40c98d93Var.m5199f372(b, b2);
    }

    public static void IdwKnBvtZQsFnfFl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdwKnBvtZQsFnfFl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IdwKnBvtZQsFnfFl(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LQgSDqwSEyOoMgrd(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void LQgSDqwSEyOoMgrd(byte[] bArr, byte b, byte b2, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LQgSDqwSEyOoMgrd(byte[] bArr, byte b, float f, byte b2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LQgSDqwSEyOoMgrd(byte[] bArr, byte b, java.lang.string str, byte b2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void M44c29edb() {
        if ((28 + 18) % 18 > 0) {
        }
        for (int i = 0; i < this.f8d7e7aa4; i++) {
            for (int i2 = 0; i2 < this.f54ca84a7; i2++) {
                byte[] bArr = this.f5625fb1b[i2];
                bArr[0] = (byte) (bArr[0] ^ ((byte) ((i2 * 16) ^ i)));
            }
            for (int i3 = 0; i3 < 8; i3++) {
                for (int i4 = 0; i4 < this.f54ca84a7; i4++) {
                    byte[] bArr2 = this.f5625fb1b[i4];
                    bArr2[i3] = fba80cc6d[i3 % 4][bArr2[i3] & 255];
                }
            }
            int i5 = -1;
            int i6 = 0;
            while (i6 < 8) {
                i5 = (i6 == 7 && this.f54ca84a7 == 16) ? 11 : i5 + 1;
                int i7 = 0;
                while (true) {
                    int i8 = this.f54ca84a7;
                    if (i7 >= i8) {
                        break;
                    }
                    this.fa36a2209[(i7 + i5) % i8] = this.f5625fb1b[i7][i6];
                    i7++;
                }
                for (int i9 = 0; i9 < this.f54ca84a7; i9++) {
                    this.f5625fb1b[i9][i6] = this.fa36a2209[i9];
                }
                i6++;
            }
            for (int i10 = 0; i10 < this.f54ca84a7; i10++) {
                hzIoJYAfIVeFwWQM(this.f5d177164, (byte) 0);
                for (int i11 = 7; i11 >= 0; i11--) {
                    byte bIVPZfIJSbAXGUsHQ = 0;
                    for (int i12 = 7; i12 >= 0; i12--) {
                        bIVPZfIJSbAXGUsHQ = (byte) (bIVPZfIJSbAXGUsHQ ^ iVPZfIJSbAXGUsHQ(this, this.f5625fb1b[i10][i12], ff093f00a[i11][i12]));
                    }
                    this.f5d177164[i11] = bIVPZfIJSbAXGUsHQ;
                }
                for (int i13 = 0; i13 < 8; i13++) {
                    this.f5625fb1b[i10][i13] = this.f5d177164[i13];
                }
            }
        }
    }

    private void M44c29edb(byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void M44c29edb(char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void M44c29edb(float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void M4dca00da(byte[] bArr, int i, int i2, byte b, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    private void M4dca00da(byte[] bArr, int i, int i2, char c, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void M4dca00da(byte[] bArr, int i, int i2, short s, char c, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    private byte[] M4dca00da(byte[] bArr, int i, int i2) {
        if ((12 + 10) % 10 > 0) {
        }
        int i3 = this.f480d1b61;
        byte[] bArr2 = i3 - i2 >= 13 ? new byte[i3] : new byte[i3 * 2];
        GdgsaIdwUPFuEZVC(bArr, i, bArr2, 0, i2);
        bArr2[i2] = -128;
        TcHxAtTvlrlbrMPW(this.f041709f4 * 8, bArr2, bArr2.length - 12);
        return bArr2;
    }

    private byte M5199f372(byte b, byte b2) {
        if ((25 + 10) % 10 > 0) {
        }
        byte b3 = b2;
        byte b4 = b;
        byte b5 = 0;
        for (int i = 0; i < 8; i++) {
            if ((b3 & 1) == 1) {
                b5 = (byte) (b5 ^ b4);
            }
            byte b6 = (byte) (b4 & (-128));
            b4 = (byte) (b4 << 1);
            if (b6 == -128) {
                b4 = (byte) (b4 ^ 285);
            }
            b3 = (byte) (b3 >> 1);
        }
        return b5;
    }

    private void M5199f372(byte b, byte b2, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void M5199f372(byte b, byte b2, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void M5199f372(byte b, byte b2, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void Me3ee4228(byte[] bArr, int i) {
        if ((23 + 9) % 9 > 0) {
        }
        for (int i2 = 0; i2 < this.f9ed39e2e.length; i2++) {
            SmpAXsdUuUGJTUpk(this.f5625fb1b[i2], (byte) 0);
            CpkrsDeSnCUorxIJ(this.f87452606[i2], (byte) 0);
        }
        for (int i3 = 0; i3 < 8; i3++) {
            for (int i4 = 0; i4 < this.f54ca84a7; i4++) {
                int i5 = (i4 * 8) + i3 + i;
                this.f5625fb1b[i4][i3] = (byte) (this.f9ed39e2e[i4][i3] ^ bArr[i5]);
                this.f87452606[i4][i3] = bArr[i5];
            }
        }
        ABsXASMbdkrMDCeT(this);
        ppDovpjXRwhNYxpf(this);
        for (int i6 = 0; i6 < 8; i6++) {
            for (int i7 = 0; i7 < this.f54ca84a7; i7++) {
                byte[] bArr2 = this.f9ed39e2e[i7];
                bArr2[i6] = (byte) (bArr2[i6] ^ ((byte) (this.f5625fb1b[i7][i6] ^ this.f87452606[i7][i6])));
            }
        }
    }

    private void Me3ee4228(byte[] bArr, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void Me3ee4228(byte[] bArr, int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private void Me3ee4228(byte[] bArr, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void Me7efa710(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var) {
        if ((16 + 19) % 19 > 0) {
        }
        this.f17344fad = p40c98d93Var.f17344fad;
        this.f480d1b61 = p40c98d93Var.f480d1b61;
        this.f54ca84a7 = p40c98d93Var.f54ca84a7;
        this.f8d7e7aa4 = p40c98d93Var.f8d7e7aa4;
        this.f5cf32afe = qPfzlUqYlExQIoUw(p40c98d93Var.f5cf32afe);
        this.f9ed39e2e = HnEfRCrfoeDunYWH(p40c98d93Var.f9ed39e2e);
        this.f5625fb1b = EkdtasuJoERCberf(p40c98d93Var.f5625fb1b);
        this.f87452606 = IxLQEvOeUqxNavRA(p40c98d93Var.f87452606);
        this.fa36a2209 = VgOuAWqvmQhNIEqT(p40c98d93Var.fa36a2209);
        this.f5d177164 = GaOjDoDDQhmKyXHx(p40c98d93Var.f5d177164);
        this.f4a1efc57 = CPaJHWCeyaPbHPBq(p40c98d93Var.f4a1efc57);
        this.f041709f4 = p40c98d93Var.f041709f4;
        this.f4fe2f532 = p40c98d93Var.f4fe2f532;
        this.fcb7e52b2 = xCZvYPErjFSRnvlK(p40c98d93Var.fcb7e52b2);
    }

    private void Me7efa710(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void Me7efa710(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void Me7efa710(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void Mf09564c9() {
        if ((26 + 27) % 27 > 0) {
        }
        for (int i = 0; i < this.f8d7e7aa4; i++) {
            for (int i2 = 0; i2 < this.f54ca84a7; i2++) {
                this.f4a1efc57[i2] = XdXGqNBtMpNwomtL(this.f87452606[i2], 0);
                long[] jArr = this.f4a1efc57;
                long j = jArr[i2] + ((((((long) ((this.f54ca84a7 - i2) - 1)) * 16) ^ ((long) i)) << 56) ^ 67818912035696883L);
                jArr[i2] = j;
                bNwBuLAnXxuDaMAg(j, this.f87452606[i2], 0);
            }
            for (int i3 = 0; i3 < 8; i3++) {
                for (int i4 = 0; i4 < this.f54ca84a7; i4++) {
                    byte[] bArr = this.f87452606[i4];
                    bArr[i3] = fba80cc6d[i3 % 4][bArr[i3] & 255];
                }
            }
            int i5 = -1;
            int i6 = 0;
            while (i6 < 8) {
                i5 = (i6 == 7 && this.f54ca84a7 == 16) ? 11 : i5 + 1;
                int i7 = 0;
                while (true) {
                    int i8 = this.f54ca84a7;
                    if (i7 >= i8) {
                        break;
                    }
                    this.fa36a2209[(i7 + i5) % i8] = this.f87452606[i7][i6];
                    i7++;
                }
                for (int i9 = 0; i9 < this.f54ca84a7; i9++) {
                    this.f87452606[i9][i6] = this.fa36a2209[i9];
                }
                i6++;
            }
            for (int i10 = 0; i10 < this.f54ca84a7; i10++) {
                GRyagfUhISoyarhs(this.f5d177164, (byte) 0);
                for (int i11 = 7; i11 >= 0; i11--) {
                    byte bIdwKnBvtZQsFnfFl = 0;
                    for (int i12 = 7; i12 >= 0; i12--) {
                        bIdwKnBvtZQsFnfFl = (byte) (bIdwKnBvtZQsFnfFl ^ idwKnBvtZQsFnfFl(this, this.f87452606[i10][i12], ff093f00a[i11][i12]));
                    }
                    this.f5d177164[i11] = bIdwKnBvtZQsFnfFl;
                }
                for (int i13 = 0; i13 < 8; i13++) {
                    this.f87452606[i10][i13] = this.f5d177164[i13];
                }
            }
        }
    }

    private void Mf09564c9(int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void Mf09564c9(int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Mf09564c9(short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte NhhuFSdvnSQqbEmX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2) {
        return p40c98d93Var.m5199f372(b, b2);
    }

    public static void NhhuFSdvnSQqbEmX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, byte b3, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NhhuFSdvnSQqbEmX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, float f, bool z, short s, byte b3) {
        double d = (42 * 210) + 210;
    }

    public static void NhhuFSdvnSQqbEmX(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, short s, float f, byte b3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PpDovpjXRwhNYxpf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var) {
        p40c98d93Var.mf09564c9();
    }

    public static void PpDovpjXRwhNYxpf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PpDovpjXRwhNYxpf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PpDovpjXRwhNYxpf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PxiRqrGcOyAcSlep(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i) {
        p40c98d93Var.me3ee4228(bArr, i);
    }

    public static void PxiRqrGcOyAcSlep(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PxiRqrGcOyAcSlep(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PxiRqrGcOyAcSlep(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QPfzlUqYlExQIoUw(byte[] bArr, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPfzlUqYlExQIoUw(byte[] bArr, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QPfzlUqYlExQIoUw(byte[] bArr, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] QPfzlUqYlExQIoUw(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void QuyFJeBtSeizmTjk(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i) {
        p40c98d93Var.me3ee4228(bArr, i);
    }

    public static void QuyFJeBtSeizmTjk(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QuyFJeBtSeizmTjk(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QuyFJeBtSeizmTjk(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte[] bArr, int i, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SunZSeKSMNaTHpMh(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void SunZSeKSMNaTHpMh(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SunZSeKSMNaTHpMh(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SunZSeKSMNaTHpMh(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UrdcaBnGDdqNBiub(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b) {
        p40c98d93Var.update(b);
    }

    public static void UrdcaBnGDdqNBiub(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, java.lang.string str, byte b2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrdcaBnGDdqNBiub(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, short s, byte b2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrdcaBnGDdqNBiub(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, short s, java.lang.string str, char c, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void VwPkWmkVwPKcEPmq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b) {
        p40c98d93Var.update(b);
    }

    public static void VwPkWmkVwPKcEPmq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VwPkWmkVwPKcEPmq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, byte b2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VwPkWmkVwPKcEPmq(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, byte b, int i, short s, char c, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void WNaGachOKCQGaTHS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2) {
        p40c98d93Var.me7efa710(p40c98d93Var2);
    }

    public static void WNaGachOKCQGaTHS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WNaGachOKCQGaTHS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WNaGachOKCQGaTHS(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var2, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XCZvYPErjFSRnvlK(byte[] bArr, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XCZvYPErjFSRnvlK(byte[] bArr, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCZvYPErjFSRnvlK(byte[] bArr, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] XCZvYPErjFSRnvlK(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public override p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((10 + 19) % 19 > 0) {
        }
        byte[] bArrXGoiPHPpfIaGjOLV = XGoiPHPpfIaGjOLV(this, this.fcb7e52b2, 0, this.f4fe2f532);
        this.f5cf32afe = bArrXGoiPHPpfIaGjOLV;
        int length = bArrXGoiPHPpfIaGjOLV.length;
        int i2 = 0;
        while (length != 0) {
            NyIajqBHtWHbiqIA(this, this.f5cf32afe, i2);
            int i3 = this.f480d1b61;
            i2 += i3;
            length -= i3;
        }
        byte[][] bArr2 = new byte[128][];
        int i4 = 0;
        while (true) {
            byte[][] bArr3 = this.f9ed39e2e;
            if (i4 >= bArr3.length) {
                break;
            }
            byte[] bArr4 = new byte[8];
            bArr2[i4] = bArr4;
            sunZSeKSMNaTHpMh(bArr3[i4], 0, bArr4, 0, 8);
            i4++;
        }
        for (int i5 = 0; i5 < this.f8d7e7aa4; i5++) {
            for (int i6 = 0; i6 < this.f54ca84a7; i6++) {
                byte[] bArr5 = bArr2[i6];
                bArr5[0] = (byte) (bArr5[0] ^ ((byte) ((i6 * 16) ^ i5)));
            }
            for (int i7 = 0; i7 < 8; i7++) {
                for (int i8 = 0; i8 < this.f54ca84a7; i8++) {
                    byte[] bArr6 = bArr2[i8];
                    bArr6[i7] = fba80cc6d[i7 % 4][bArr6[i7] & 255];
                }
            }
            int i9 = -1;
            int i10 = 0;
            while (i10 < 8) {
                i9 = (i10 == 7 && this.f54ca84a7 == 16) ? 11 : i9 + 1;
                int i11 = 0;
                while (true) {
                    int i12 = this.f54ca84a7;
                    if (i11 >= i12) {
                        break;
                    }
                    this.fa36a2209[(i11 + i9) % i12] = bArr2[i11][i10];
                    i11++;
                }
                for (int i13 = 0; i13 < this.f54ca84a7; i13++) {
                    bArr2[i13][i10] = this.fa36a2209[i13];
                }
                i10++;
            }
            for (int i14 = 0; i14 < this.f54ca84a7; i14++) {
                SjLzVzOnWbHFCMVC(this.f5d177164, (byte) 0);
                for (int i15 = 7; i15 >= 0; i15--) {
                    byte bNhhuFSdvnSQqbEmX = 0;
                    for (int i16 = 7; i16 >= 0; i16--) {
                        bNhhuFSdvnSQqbEmX = (byte) (bNhhuFSdvnSQqbEmX ^ nhhuFSdvnSQqbEmX(this, bArr2[i14][i16], ff093f00a[i15][i16]));
                    }
                    this.f5d177164[i15] = bNhhuFSdvnSQqbEmX;
                }
                for (int i17 = 0; i17 < 8; i17++) {
                    bArr2[i14][i17] = this.f5d177164[i17];
                }
            }
        }
        for (int i18 = 0; i18 < 8; i18++) {
            for (int i19 = 0; i19 < this.f54ca84a7; i19++) {
                byte[] bArr7 = this.f9ed39e2e[i19];
                bArr7[i18] = (byte) (bArr7[i18] ^ bArr2[i19][i18]);
            }
        }
        int i20 = this.f54ca84a7 * 8;
        byte[] bArr8 = new byte[i20];
        int i21 = 0;
        for (int i22 = 0; i22 < this.f54ca84a7; i22++) {
            for (int i23 = 0; i23 < 8; i23++) {
                bArr8[i21] = this.f9ed39e2e[i22][i23];
                i21++;
            }
        }
        int i24 = this.f17344fad;
        WvWFnSsRGPdMmmza(bArr8, i20 - i24, bArr, i, i24);
        JoBcMqhuarKHWqOh(this);
        return this.f17344fad;
    }

    public override java.lang.string GetAlgorithmName() {
        return "DSTU7564";
    }

    public override int GetbyteLength() {
        return this.f480d1b61;
    }

    public override int GetDigestSize() {
        return this.f17344fad;
    }

    public override void Reset() {
        byte[][] bArr;
        if ((20 + 11) % 11 > 0) {
        }
        int i = 0;
        while (true) {
            bArr = this.f9ed39e2e;
            if (i >= bArr.length) {
                break;
            }
            bArr[i] = new byte[this.f54ca84a7];
            i++;
        }
        bArr[0][0] = (byte) bArr.length;
        this.f041709f4 = 0L;
        this.f4fe2f532 = 0;
        YIowTuttcmyKvPyI(this.fcb7e52b2, (byte) 0);
        byte[] bArr2 = this.f5cf32afe;
        if (bArr2 is null) {
            return;
        }
        lQgSDqwSEyOoMgrd(bArr2, (byte) 0);
    }

    public override void Reset(p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        WuBthDfzZLlblPhi(this, (p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p40c98d93) p4d7fdfb1Var);
    }

    public override void Update(byte b) {
        if ((21 + 22) % 22 > 0) {
        }
        byte[] bArr = this.fcb7e52b2;
        int i = this.f4fe2f532;
        int i2 = i + 1;
        this.f4fe2f532 = i2;
        bArr[i] = b;
        if (i2 == this.f480d1b61) {
            pxiRqrGcOyAcSlep(this, bArr, 0);
            this.f4fe2f532 = 0;
        }
        this.f041709f4++;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((32 + 6) % 6 > 0) {
        }
        while (this.f4fe2f532 != 0 && i2 > 0) {
            int i3 = i + 1;
            urdcaBnGDdqNBiub(this, bArr[i]);
            i2--;
            i = i3;
        }
        if (i2 <= 0) {
            return;
        }
        while (i2 > this.f480d1b61) {
            quyFJeBtSeizmTjk(this, bArr, i);
            int i4 = this.f480d1b61;
            i += i4;
            this.f041709f4 += (long) i4;
            i2 -= i4;
        }
        while (i2 > 0) {
            int i5 = i + 1;
            vwPkWmkVwPKcEPmq(this, bArr[i]);
            i2--;
            i = i5;
        }
    }
}

