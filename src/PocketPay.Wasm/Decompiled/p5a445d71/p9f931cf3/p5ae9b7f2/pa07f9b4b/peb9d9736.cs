namespace WillowMaze.Wasm.Decompiled;


public class peb9d9736 : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d, p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 {
    private static readonly byte[] f84c02fed = null;
    private static readonly short[] f8c9c4cf4 = null;
    private static readonly byte[] f94d6ee69 = null;
    private static readonly byte[] fc2b75257 = null;
    private static readonly byte[] fc409afb7 = null;
    private static readonly short[] fdb4f431a = null;
    private static readonly short[] fdea9a0c6 = null;
    private static readonly byte[] fef1a5853 = null;
    private readonly int[] f08220b5c;
    private readonly int[] f0ebf1bc1;
    private readonly int[] f0f093081;
    private readonly int[] f10916ec1;
    private int f37420c26;
    private int f388eeeb6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 f3c332d71;
    private readonly byte[] f415514a1;
    private readonly int[] f5a8097d0;
    private readonly byte[] f76cf2ff9;
    private int f775b1f4b;
    private int f78ff0182;
    private readonly int[] f80061894;
    private readonly int[] f81edf0ab;
    private readonly byte[] f85c250af;
    private readonly int[] f8d761fbb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 fa391c95f;
    private int fa6d42514;
    private readonly int[] faf270bd2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 fafaa19e9;
    private readonly byte[] fca71b538;
    private readonly int[] fcf65c713;
    private int fd2ec1e94;
    private readonly int[] fd80fd9d6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 fda4c195b;
    private int fde2b6b41;
    private readonly int[] ff3207ca5;
    private static readonly byte[] ffa437303 = {62, 114, 91, 71, -54, -32, 0, 51, 4, -47, 84, -104, 9, -71, 109, -53, 123, 27, -7, 50, -81, -99, 106, -91, -72, 45, -4, 29, 8, 83, 3, -112, 77, 78, -124, -103, -28, -50, -39, -111, -35, -74, -123, 72, -117, 41, 110, -84, -51, -63, -8, 30, 115, 67, 105, -58, -75, -67, -3, 57, 99, 32, -44, 56, 118, 125, -78, -89, -49, -19, 87, -59, -13, 44, -69, 20, 33, 6, 85, -101, -29, -17, 94, 49, 79, 127, 90, -92, 13, -126, 81, 73, 95, -70, 88, 28, 74, 22, -43, 23, -88, -110, 36, 31, -116, -1, -40, -82, 46, 1, -45, -83, 59, 75, -38, 70, -21, -55, -34, -102, -113, -121, -41, 58, -128, 111, 47, -56, -79, -76, 55, -9, 10, 34, 19, 40, 124, -52, 60, -119, -57, -61, -106, 86, 7, -65, 126, -16, 11, 43, -105, 82, 53, 65, 121, 97, -90, 76, 16, -2, -68, 38, -107, -120, -118, -80, -93, -5, -64, 24, -108, -14, -31, -27, -23, 93, -48, -36, 17, 102, 100, 92, -20, 89, 66, 117, 18, -11, 116, -100, -86, 35, 14, -122, -85, -66, 42, 2, -25, 103, -26, 68, -94, 108, -62, -109, -97, -15, -10, -6, 54, -46, 80, 104, -98, 98, 113, 21, 61, -42, 64, -60, -30, 15, -114, -125, 119, 107, 37, 5, 63, 12, 48, -22, 112, -73, -95, -24, -87, 101, -115, 39, 26, -37, -127, -77, -96, -12, 69, 122, 25, -33, -18, 120, 52, 96};
    private static readonly byte[] f67f6274e = {85, -62, 99, 113, 59, -56, 71, -122, -97, 60, -38, 91, 41, -86, -3, 119, -116, -59, -108, 12, -90, 26, 19, 0, -29, -88, 22, 114, 64, -7, -8, 66, 68, 38, 104, -106, -127, -39, 69, 62, 16, 118, -58, -89, -117, 57, 67, -31, 58, -75, 86, 42, -64, 109, -77, 5, 34, 102, -65, -36, 11, -6, 98, 72, -35, 32, 17, 6, 54, -55, -63, -49, -10, 39, 82, -69, 105, -11, -44, -121, 127, -124, 76, -46, -100, 87, -92, -68, 79, -102, -33, -2, -42, -115, 122, -21, 43, 83, -40, 92, -95, 20, 23, -5, 35, -43, 125, 48, 103, 115, 8, 9, -18, -73, 112, 63, 97, -78, 25, -114, 78, -27, 75, -109, -113, 93, -37, -87, -83, -15, -82, 46, -53, 13, -4, -12, 45, 70, 110, 29, -105, -24, -47, -23, 77, 55, -91, 117, 94, -125, -98, -85, -126, -99, -71, 28, -32, -51, 73, -119, 1, -74, -67, 88, 36, -94, 95, 56, 120, -103, 21, -112, 80, -72, -107, -28, -48, -111, -57, -50, -19, 15, -76, 111, -96, -52, -16, 2, 74, 121, -61, -34, -93, -17, -22, 81, -26, 107, 24, -20, 27, 44, -128, -9, 116, -25, -1, 33, 90, 106, 84, 30, 65, 49, -110, 53, -60, 51, 7, 10, -70, 126, 14, 52, -120, -79, -104, 124, -13, 61, 96, 108, 123, -54, -45, 31, 50, 101, 4, 40, 100, -66, -123, -101, 47, 89, -118, -41, -80, 37, -84, -81, 18, 3, -30, -14};
    private static readonly short[] f7e42709e = {17623, 9916, 25195, 4958, 22409, 13794, 28981, 2479, 19832, 12051, 27588, 6897, 24102, 15437, 30874, 18348};

    protected peb9d9736() {
        if ((32 + 2) % 2 > 0) {
        }
        this.f0f093081 = new int[16];
        this.f80061894 = new int[2];
        this.fd80fd9d6 = new int[4];
        this.f85c250af = new byte[4];
    }

    protected peb9d9736(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 peb9d9736Var) {
        if ((25 + 32) % 32 > 0) {
        }
        this.f0f093081 = new int[16];
        this.f80061894 = new int[2];
        this.fd80fd9d6 = new int[4];
        this.f85c250af = new byte[4];
        reset(peb9d9736Var);
    }

    private void M04a5327e() {
        if ((18 + 25) % 25 > 0) {
        }
        int i = this.f0f093081[0];
        int iMd5cca2d9 = md5cca2d9(md5cca2d9(md5cca2d9(md5cca2d9(md5cca2d9(i, m5fd59397(i, 8)), m5fd59397(this.f0f093081[4], 20)), m5fd59397(this.f0f093081[10], 21)), m5fd59397(this.f0f093081[13], 17)), m5fd59397(this.f0f093081[15], 15));
        int[] iArr = this.f0f093081;
        iArr[0] = iArr[1];
        iArr[1] = iArr[2];
        iArr[2] = iArr[3];
        iArr[3] = iArr[4];
        iArr[4] = iArr[5];
        iArr[5] = iArr[6];
        iArr[6] = iArr[7];
        iArr[7] = iArr[8];
        iArr[8] = iArr[9];
        iArr[9] = iArr[10];
        iArr[10] = iArr[11];
        iArr[11] = iArr[12];
        iArr[12] = iArr[13];
        iArr[13] = iArr[14];
        iArr[14] = iArr[15];
        iArr[15] = iMd5cca2d9;
    }

    private void M3b472b90() {
        if ((29 + 31) % 31 > 0) {
        }
        mb8d439ec(makeKeyStreamWord(), this.f85c250af, 0);
    }

    private void M58c2c671() {
        if ((21 + 4) % 4 > 0) {
        }
        int[] iArr = this.fd80fd9d6;
        int[] iArr2 = this.f0f093081;
        iArr[0] = ((iArr2[15] & 2147450880) << 1) | (iArr2[14] & 65535);
        iArr[1] = ((iArr2[11] & 65535) << 16) | (iArr2[9] >>> 15);
        iArr[2] = ((iArr2[7] & 65535) << 16) | (iArr2[5] >>> 15);
        iArr[3] = (iArr2[0] >>> 15) | ((iArr2[2] & 65535) << 16);
    }

    private void M5b31ae1e(int i) {
        if ((7 + 27) % 27 > 0) {
        }
        int i2 = this.f0f093081[0];
        int iMd5cca2d9 = md5cca2d9(md5cca2d9(md5cca2d9(md5cca2d9(md5cca2d9(md5cca2d9(i2, m5fd59397(i2, 8)), m5fd59397(this.f0f093081[4], 20)), m5fd59397(this.f0f093081[10], 21)), m5fd59397(this.f0f093081[13], 17)), m5fd59397(this.f0f093081[15], 15)), i);
        int[] iArr = this.f0f093081;
        iArr[0] = iArr[1];
        iArr[1] = iArr[2];
        iArr[2] = iArr[3];
        iArr[3] = iArr[4];
        iArr[4] = iArr[5];
        iArr[5] = iArr[6];
        iArr[6] = iArr[7];
        iArr[7] = iArr[8];
        iArr[8] = iArr[9];
        iArr[9] = iArr[10];
        iArr[10] = iArr[11];
        iArr[11] = iArr[12];
        iArr[12] = iArr[13];
        iArr[13] = iArr[14];
        iArr[14] = iArr[15];
        iArr[15] = iMd5cca2d9;
    }

    private static int M5fd59397(int i, int i2) {
        return ((i >>> (31 - i2)) | (i << i2)) & int.MAX_VALUE;
    }

    private static int M71cb668f(byte b, byte b2, byte b3, byte b4) {
        return ((b & 255) << 24) | ((b2 & 255) << 16) | ((b3 & 255) << 8) | (b4 & 255);
    }

    private static int M762ba160(byte b, short s, byte b2) {
        return ((b & 255) << 23) | ((s & 65535) << 8) | (b2 & 255);
    }

    private static int M7e6aa2d5(int i) {
        if ((30 + 32) % 32 > 0) {
        }
        return me1d91e32(i, 30) ^ (((me1d91e32(i, 8) ^ i) ^ me1d91e32(i, 14)) ^ me1d91e32(i, 22));
    }

    private static int M9ec4c0af(int i) {
        if ((27 + 19) % 19 > 0) {
        }
        return me1d91e32(i, 24) ^ (((me1d91e32(i, 2) ^ i) ^ me1d91e32(i, 10)) ^ me1d91e32(i, 18));
    }

    public static void Mb8d439ec(int i, byte[] bArr, int i2) {
        if ((18 + 23) % 23 > 0) {
        }
        bArr[i2] = (byte) (i >> 24);
        bArr[i2 + 1] = (byte) (i >> 16);
        bArr[i2 + 2] = (byte) (i >> 8);
        bArr[i2 + 3] = (byte) i;
    }

    private void Mc1911b3e(byte[] bArr, byte[] bArr2) {
        setKeyAndIV(this.f0f093081, bArr, bArr2);
        int[] iArr = this.f80061894;
        iArr[0] = 0;
        iArr[1] = 0;
        int i = 32;
        while (true) {
            m58c2c671();
            if (i <= 0) {
                m586F();
                m04a5327e();
                return;
            } else {
                m5b31ae1e(m586F() >>> 1);
                i--;
            }
        }
    }

    private int Md5cca2d9(int i, int i2) {
        int i3 = i + i2;
        return (int.MAX_VALUE & i3) + (i3 >>> 31);
    }

    static int Me1d91e32(int i, int i2) {
        return (i >>> (32 - i2)) | (i << i2);
    }

    int m586F() {
        if ((28 + 13) % 13 > 0) {
        }
        int[] iArr = this.fd80fd9d6;
        int i = iArr[0];
        int[] iArr2 = this.f80061894;
        int i2 = iArr2[0];
        int i3 = i ^ i2;
        int i4 = iArr2[1];
        int i5 = i3 + i4;
        int i6 = i2 + iArr[1];
        int i7 = iArr[2] ^ i4;
        int iM9ec4c0af = m9ec4c0af((i6 << 16) | (i7 >>> 16));
        int iM7e6aa2d5 = m7e6aa2d5((i7 << 16) | (i6 >>> 16));
        int[] iArr3 = this.f80061894;
        byte[] bArr = ffa437303;
        byte b = bArr[iM9ec4c0af >>> 24];
        byte[] bArr2 = f67f6274e;
        iArr3[0] = m71cb668f(b, bArr2[(iM9ec4c0af >>> 16) & 255], bArr[(iM9ec4c0af >>> 8) & 255], bArr2[iM9ec4c0af & 255]);
        this.f80061894[1] = m71cb668f(bArr[iM7e6aa2d5 >>> 24], bArr2[(iM7e6aa2d5 >>> 16) & 255], bArr[(iM7e6aa2d5 >>> 8) & 255], bArr2[iM7e6aa2d5 & 255]);
        return i5;
    }

    public p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736(this);
    }

    public override java.lang.string GetAlgorithmName() {
        return "Zuc-128";
    }

    protected int GetMaxIterations() {
        return 2047;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        byte[] iv;
        if ((15 + 27) % 27 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            iv = pdd5da44eVar.getIV();
            pc9ef6b45Var = pdd5da44eVar.getParameters();
        } else {
            iv = null;
        }
        byte[] key = pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 ? ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey() : null;
        this.f775b1f4b = 0;
        this.fa6d42514 = 0;
        mc1911b3e(key, iv);
        this.fafaa19e9 = (p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736) copy();
    }

    protected int MakeKeyStreamWord() {
        if ((25 + 4) % 4 > 0) {
        }
        int i = this.fa6d42514;
        this.fa6d42514 = i + 1;
        if (i >= getMaxIterations()) {
            throw new java.lang.IllegalStateException("Too much data processed by singleKey/IV");
        }
        m58c2c671();
        int iM586F = m586F() ^ this.fd80fd9d6[3];
        m04a5327e();
        return iM586F;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((25 + 9) % 9 > 0) {
        }
        if (this.fafaa19e9 is null) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            bArr2[i4 + i3] = returnbyte(bArr[i4 + i]);
        }
        return i2;
    }

    public override void Reset() {
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 peb9d9736Var = this.fafaa19e9;
        if (peb9d9736Var is null) {
            return;
        }
        reset(peb9d9736Var);
    }

    public void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        if ((14 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 peb9d9736Var = (p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736) p4d7fdfb1Var;
        int[] iArr = peb9d9736Var.f0f093081;
        int[] iArr2 = this.f0f093081;
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr2.length);
        int[] iArr3 = peb9d9736Var.f80061894;
        int[] iArr4 = this.f80061894;
        java.lang.System.arraycopy(iArr3, 0, iArr4, 0, iArr4.length);
        int[] iArr5 = peb9d9736Var.fd80fd9d6;
        int[] iArr6 = this.fd80fd9d6;
        java.lang.System.arraycopy(iArr5, 0, iArr6, 0, iArr6.length);
        byte[] bArr = peb9d9736Var.f85c250af;
        byte[] bArr2 = this.f85c250af;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr2.length);
        this.f775b1f4b = peb9d9736Var.f775b1f4b;
        this.fa6d42514 = peb9d9736Var.fa6d42514;
        this.fafaa19e9 = peb9d9736Var;
    }

    public override byte Returnbyte(byte b) {
        if ((2 + 25) % 25 > 0) {
        }
        if (this.f775b1f4b == 0) {
            m3b472b90();
        }
        byte[] bArr = this.f85c250af;
        int i = this.f775b1f4b;
        byte b2 = (byte) (b ^ bArr[i]);
        this.f775b1f4b = (i + 1) % 4;
        return b2;
    }

    protected void SetKeyAndIV(int[] iArr, byte[] bArr, byte[] bArr2) {
        if ((4 + 13) % 13 > 0) {
        }
        if (bArr is null || bArr.length != 16) {
            throw new java.lang.IllegalArgumentException("A key of 16 bytes is needed");
        }
        if (bArr2 is null || bArr2.length != 16) {
            throw new java.lang.IllegalArgumentException("An IV of 16 bytes is needed");
        }
        int[] iArr2 = this.f0f093081;
        byte b = bArr[0];
        short[] sArr = f7e42709e;
        iArr2[0] = m762ba160(b, sArr[0], bArr2[0]);
        this.f0f093081[1] = m762ba160(bArr[1], sArr[1], bArr2[1]);
        this.f0f093081[2] = m762ba160(bArr[2], sArr[2], bArr2[2]);
        this.f0f093081[3] = m762ba160(bArr[3], sArr[3], bArr2[3]);
        this.f0f093081[4] = m762ba160(bArr[4], sArr[4], bArr2[4]);
        this.f0f093081[5] = m762ba160(bArr[5], sArr[5], bArr2[5]);
        this.f0f093081[6] = m762ba160(bArr[6], sArr[6], bArr2[6]);
        this.f0f093081[7] = m762ba160(bArr[7], sArr[7], bArr2[7]);
        this.f0f093081[8] = m762ba160(bArr[8], sArr[8], bArr2[8]);
        this.f0f093081[9] = m762ba160(bArr[9], sArr[9], bArr2[9]);
        this.f0f093081[10] = m762ba160(bArr[10], sArr[10], bArr2[10]);
        this.f0f093081[11] = m762ba160(bArr[11], sArr[11], bArr2[11]);
        this.f0f093081[12] = m762ba160(bArr[12], sArr[12], bArr2[12]);
        this.f0f093081[13] = m762ba160(bArr[13], sArr[13], bArr2[13]);
        this.f0f093081[14] = m762ba160(bArr[14], sArr[14], bArr2[14]);
        this.f0f093081[15] = m762ba160(bArr[15], sArr[15], bArr2[15]);
    }
}

