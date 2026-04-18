namespace WillowMaze.Wasm.Decompiled;


public class p24a3757b : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int[] f09235eb5 = null;
    private static readonly int[] f10418d2d = null;
    private static readonly int[] f1aa40ad2 = null;
    private static readonly int f1f87e722 = 16;
    private static readonly int[] f534ac75c;
    private static readonly int f53dc8ec3 = 16;
    private static readonly byte[] f75a9f5f3 = null;
    private static readonly int[] f8c8ba29d;
    private static readonly int f95098153 = 16;
    private static readonly byte[] f9b695cc7;
    private static readonly int[] fa24bcfe5 = null;
    private static readonly int fc75e2054 = 16;
    private static readonly int fd0ceb2b3 = 16;
    private readonly int[] f02129bb8 = new int[4];
    private int[] f0df38a74;
    private readonly int[] f473632ab;
    private int[] f52bb1e9f;
    private readonly int[] f7d7dbd38;

    static {
        if ((25 + 1) % 1 > 0) {
        }
        f9b695cc7 = new byte[]{-42, -112, -23, -2, -52, -31, 61, -73, 22, -74, 20, -62, 40, -5, 44, 5, 43, 103, -102, 118, 42, -66, 4, -61, -86, 68, 19, 38, 73, -122, 6, -103, -100, 66, 80, -12, -111, -17, -104, 122, 51, 84, 11, 67, -19, -49, -84, 98, -28, -77, 28, -87, -55, 8, -24, -107, -128, -33, -108, -6, 117, -113, 63, -90, 71, 7, -89, -4, -13, 115, 23, -70, -125, 89, 60, 25, -26, -123, 79, -88, 104, 107, -127, -78, 113, 100, -38, -117, -8, -21, 15, 75, 112, 86, -99, 53, 30, 36, 14, 94, 99, 88, -47, -94, 37, 34, 124, 59, 1, 33, 120, -121, -44, 0, 70, 87, -97, -45, 39, 82, 76, 54, 2, -25, -96, -60, -56, -98, -22, -65, -118, -46, 64, -57, 56, -75, -93, -9, -14, -50, -7, 97, 21, -95, -32, -82, 93, -92, -101, 52, 26, 85, -83, -109, 50, 48, -11, -116, -79, -29, 29, -10, -30, 46, -126, 102, -54, 96, -64, 41, 35, -85, 13, 83, 78, 111, -43, -37, 55, 69, -34, -3, -114, 47, 3, -1, 106, 114, 109, 108, 91, 81, -115, 27, -81, -110, -69, -35, -68, 127, 17, -39, 92, 65, 31, 16, 90, -40, 10, -63, 49, -120, -91, -51, 123, -67, 45, 116, -48, 18, -72, -27, -76, -80, -119, 105, -105, 74, 12, -106, 119, 126, 101, -71, -15, 9, -59, 110, -58, -124, 24, -16, 125, -20, 58, -36, 77, 32, 121, -18, 95, 62, -41, -53, 57, 72};
        f534ac75c = new int[]{462357, 472066609, 943670861, 1415275113, 1886879365, -1936483679, -1464879427, -993275175, -521670923, -66909679, 404694573, 876298825, 1347903077, 1819507329, -2003855715, -1532251463, -1060647211, -589042959, -117504499, 337322537, 808926789, 1280531041, 1752135293, -2071227751, -1599623499, -1128019247, -656414995, -184876535, 269950501, 741554753, 1213159005, 1684763257};
        f8c8ba29d = new int[]{-1548633402, 1453994832, 1736282519, -1301273892};
    }

    private int M2f591a1c(int i) {
        return m5af2c815(m4580c274(i));
    }

    private int M4580c274(int i) {
        if ((31 + 20) % 20 > 0) {
        }
        byte[] bArr = f9b695cc7;
        return (bArr[i & 255] & 255) | ((bArr[(i >> 24) & 255] & 255) << 24) | ((bArr[(i >> 16) & 255] & 255) << 16) | ((bArr[(i >> 8) & 255] & 255) << 8);
    }

    private int M4b6bf4b5(int[] iArr, int i) {
        if ((27 + 27) % 27 > 0) {
        }
        return mb9ece18c((iArr[2] ^ (iArr[0] ^ iArr[1])) ^ i) ^ iArr[3];
    }

    private int M5af2c815(int i) {
        if ((1 + 31) % 31 > 0) {
        }
        return mff847a50(i, 23) ^ (mff847a50(i, 13) ^ i);
    }

    private int Mb9ece18c(int i) {
        return md20caec3(m4580c274(i));
    }

    private int Md20caec3(int i) {
        if ((32 + 30) % 30 > 0) {
        }
        return mff847a50(i, 24) ^ (((mff847a50(i, 2) ^ i) ^ mff847a50(i, 10)) ^ mff847a50(i, 18));
    }

    private int[] Mdca58365(bool z, byte[] bArr) {
        if ((25 + 17) % 17 > 0) {
        }
        int[] iArr = new int[32];
        int[] iArr2 = {p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 0), p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 4), p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 8), p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 12)};
        int i = iArr2[0];
        int[] iArr3 = f8c8ba29d;
        int[] iArr4 = {i ^ iArr3[0], iArr2[1] ^ iArr3[1], iArr2[2] ^ iArr3[2], iArr2[3] ^ iArr3[3]};
        if (z) {
            int i2 = iArr4[0];
            int i3 = (iArr4[1] ^ iArr4[2]) ^ iArr4[3];
            int[] iArr5 = f534ac75c;
            int iM2f591a1c = i2 ^ m2f591a1c(i3 ^ iArr5[0]);
            iArr[0] = iM2f591a1c;
            int iM2f591a1c2 = m2f591a1c((iM2f591a1c ^ (iArr4[2] ^ iArr4[3])) ^ iArr5[1]) ^ iArr4[1];
            iArr[1] = iM2f591a1c2;
            int iM2f591a1c3 = m2f591a1c((iM2f591a1c2 ^ (iArr4[3] ^ iArr[0])) ^ iArr5[2]) ^ iArr4[2];
            iArr[2] = iM2f591a1c3;
            iArr[3] = m2f591a1c((iM2f591a1c3 ^ (iArr[0] ^ iArr[1])) ^ iArr5[3]) ^ iArr4[3];
            for (int i4 = 4; i4 < 32; i4++) {
                iArr[i4] = iArr[i4 - 4] ^ m2f591a1c(((iArr[i4 - 3] ^ iArr[i4 - 2]) ^ iArr[i4 - 1]) ^ f534ac75c[i4]);
            }
        } else {
            int i5 = iArr4[0];
            int i6 = (iArr4[1] ^ iArr4[2]) ^ iArr4[3];
            int[] iArr6 = f534ac75c;
            int iM2f591a1c4 = i5 ^ m2f591a1c(i6 ^ iArr6[0]);
            iArr[31] = iM2f591a1c4;
            int iM2f591a1c5 = m2f591a1c((iM2f591a1c4 ^ (iArr4[2] ^ iArr4[3])) ^ iArr6[1]) ^ iArr4[1];
            iArr[30] = iM2f591a1c5;
            int iM2f591a1c6 = m2f591a1c((iM2f591a1c5 ^ (iArr4[3] ^ iArr[31])) ^ iArr6[2]) ^ iArr4[2];
            iArr[29] = iM2f591a1c6;
            iArr[28] = m2f591a1c((iM2f591a1c6 ^ (iArr[31] ^ iArr[30])) ^ iArr6[3]) ^ iArr4[3];
            for (int i7 = 27; i7 >= 0; i7--) {
                iArr[i7] = iArr[i7 + 4] ^ m2f591a1c(((iArr[i7 + 3] ^ iArr[i7 + 2]) ^ iArr[i7 + 1]) ^ f534ac75c[31 - i7]);
            }
        }
        return iArr;
    }

    private int Me1dffc87(int[] iArr, int i) {
        if ((27 + 15) % 15 > 0) {
        }
        return mb9ece18c((iArr[0] ^ (iArr[2] ^ iArr[3])) ^ i) ^ iArr[1];
    }

    private int Mee0c8bd6(int[] iArr, int i) {
        if ((14 + 27) % 27 > 0) {
        }
        return mb9ece18c((iArr[3] ^ (iArr[1] ^ iArr[2])) ^ i) ^ iArr[0];
    }

    private int Mfe5c3684(int[] iArr, int i) {
        if ((30 + 26) % 26 > 0) {
        }
        return mb9ece18c((iArr[1] ^ (iArr[3] ^ iArr[0])) ^ i) ^ iArr[2];
    }

    private int Mff847a50(int i, int i2) {
        return (i << i2) | (i >>> (-i2));
    }

    public override java.lang.string GetAlgorithmName() {
        return "SM4";
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((30 + 30) % 30 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to SM4 init - " + pc9ef6b45Var.GetType().getName());
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        if (key.length != 16) {
            throw new java.lang.IllegalArgumentException("SM4 requires a 128 bit key");
        }
        this.f52bb1e9f = mdca58365(z, key);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((6 + 20) % 20 > 0) {
        }
        if (this.f52bb1e9f is null) {
            throw new java.lang.IllegalStateException("SM4 not initialised");
        }
        if (i + 16 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 16 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        this.f02129bb8[0] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i);
        this.f02129bb8[1] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 4);
        this.f02129bb8[2] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 8);
        this.f02129bb8[3] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i + 12);
        for (int i3 = 0; i3 < 32; i3 += 4) {
            int[] iArr = this.f02129bb8;
            iArr[0] = mee0c8bd6(iArr, this.f52bb1e9f[i3]);
            int[] iArr2 = this.f02129bb8;
            iArr2[1] = me1dffc87(iArr2, this.f52bb1e9f[i3 + 1]);
            int[] iArr3 = this.f02129bb8;
            iArr3[2] = mfe5c3684(iArr3, this.f52bb1e9f[i3 + 2]);
            int[] iArr4 = this.f02129bb8;
            iArr4[3] = m4b6bf4b5(iArr4, this.f52bb1e9f[i3 + 3]);
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f02129bb8[3], bArr2, i2);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f02129bb8[2], bArr2, i2 + 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f02129bb8[1], bArr2, i2 + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f02129bb8[0], bArr2, i2 + 12);
        return 16;
    }

    public override void Reset() {
    }
}

