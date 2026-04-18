namespace WillowMaze.Wasm.Decompiled;


public class p73339aa1 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int[] f3d9de7e8 = null;
    private static readonly int f765a6aca = 255;
    private static readonly byte[] f7c3a7117 = null;
    private static readonly byte[] f9d9ad42f = null;
    private static readonly int fb938ab1a = 255;
    private static readonly int[] fba1a0ced = null;
    private static readonly int fc4b333ad = 16;
    private static readonly int fc75e2054 = 16;
    private static readonly int[] ff5ecb08f = null;
    private int[] f00a67834;
    private bool f1bf39594;
    private bool f2abd8a31;
    private bool f2ee0c37d;
    private int[] f36884f78;
    private bool f3a3b63c8;
    private bool f3e91079a;
    private int[] f5b4a69b2;
    private bool f80ed0e82;
    private bool f84d10a1e;
    private bool fa5b0fd38;
    private int[] fa8e95237;
    private int[] fe07b44e7;
    private bool fe966bc1f;
    private bool fed9ef35b;
    private int[] ff3eab6e0;
    private int[] ffdae9d8b;
    private static readonly int[] f0b1c668d = {-1600231809, 1003262091, -1233459112, 1286239154, -957401297, -380665154, 1426019237, -237801700, 283453434, -563598051, -1336506174, -1276722691};
    private static readonly byte[] f4028611d = {112, -126, 44, -20, -77, 39, -64, -27, -28, -123, 87, 53, -22, 12, -82, 65, 35, -17, 107, -109, 69, 25, -91, 33, -19, 14, 79, 78, 29, 101, -110, -67, -122, -72, -81, -113, 124, -21, 31, -50, 62, 48, -36, 95, 94, -59, 11, 26, -90, -31, 57, -54, -43, 71, 93, 61, -39, 1, 90, -42, 81, 86, 108, 77, -117, 13, -102, 102, -5, -52, -80, 45, 116, 18, 43, 32, -16, -79, -124, -103, -33, 76, -53, -62, 52, 126, 118, 5, 109, -73, -87, 49, -47, 23, 4, -41, 20, 88, 58, 97, -34, 27, 17, 28, 50, 15, -100, 22, 83, 24, -14, 34, -2, 68, -49, -78, -61, -75, 122, -111, 36, 8, -24, -88, 96, -4, 105, 80, -86, -48, -96, 125, -95, -119, 98, -105, 84, 91, 30, -107, -32, -1, 100, -46, 16, -60, 0, 72, -93, -9, 117, -37, -118, 3, -26, -38, 9, 63, -35, -108, -121, 92, -125, 2, -51, 74, -112, 51, 115, 103, -10, -13, -99, 127, -65, -30, 82, -101, -40, 38, -56, 55, -58, 59, -127, -106, 111, 75, 19, -66, 99, 46, -23, 121, -89, -116, -97, 110, -68, -114, 41, -11, -7, -74, 47, -3, -76, 89, 120, -104, 6, 106, -25, 70, 113, -70, -44, 37, -85, 66, -120, -94, -115, -6, 114, 7, -71, 85, -8, -18, -84, 10, 54, 73, 42, 104, 60, 56, -15, -92, 64, 40, -45, 123, -69, -55, 67, -63, 21, -29, -83, -12, 119, -57, -128, -98};
    private int[] f37ee9d25 = new int[96];
    private int[] f048685d9 = new int[8];
    private int[] f25bc6654 = new int[12];
    private int[] f9ed39e2e = new int[4];

    private static void M00c0bf49(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((2 + 17) % 17 > 0) {
        }
        int i4 = i2 + 1;
        int i5 = 32 - i;
        iArr2[i3] = (iArr[i2] << i) | (iArr[i4] >>> i5);
        int i6 = i3 + 1;
        int i7 = i2 + 2;
        iArr2[i6] = (iArr[i4] << i) | (iArr[i7] >>> i5);
        int i8 = i3 + 2;
        int i9 = i2 + 3;
        iArr2[i8] = (iArr[i7] << i) | (iArr[i9] >>> i5);
        int i10 = i3 + 3;
        iArr2[i10] = (iArr[i9] << i) | (iArr[i2] >>> i5);
        iArr[i2] = iArr2[i3];
        iArr[i4] = iArr2[i6];
        iArr[i7] = iArr2[i8];
        iArr[i9] = iArr2[i10];
    }

    private byte M05ab960f(byte b, int i) {
        return (byte) ((b << i) | ((b & 255) >>> (8 - i)));
    }

    private void M1b39f912(int[] iArr, int[] iArr2, int i) {
        if ((16 + 20) % 20 > 0) {
        }
        int iMa7c28b3d = iArr[1] ^ ma7c28b3d(iArr[0] & iArr2[i], 1);
        iArr[1] = iMa7c28b3d;
        iArr[0] = (iMa7c28b3d | iArr2[i + 1]) ^ iArr[0];
        int i2 = iArr[2];
        int i3 = iArr2[i + 3];
        int i4 = iArr[3];
        int i5 = i2 ^ (i3 | i4);
        iArr[2] = i5;
        iArr[3] = ma7c28b3d(iArr2[i + 2] & i5, 1) ^ i4;
    }

    private static void M24c255af(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((24 + 27) % 27 > 0) {
        }
        int i4 = i2 + 1;
        int i5 = i - 32;
        int i6 = i2 + 2;
        int i7 = 64 - i;
        iArr2[i3] = (iArr[i4] << i5) | (iArr[i6] >>> i7);
        int i8 = i3 + 1;
        int i9 = i2 + 3;
        iArr2[i8] = (iArr[i6] << i5) | (iArr[i9] >>> i7);
        int i10 = i3 + 2;
        iArr2[i10] = (iArr[i9] << i5) | (iArr[i2] >>> i7);
        int i11 = i3 + 3;
        iArr2[i11] = (iArr[i4] >>> i7) | (iArr[i2] << i5);
        iArr[i2] = iArr2[i3];
        iArr[i4] = iArr2[i8];
        iArr[i6] = iArr2[i10];
        iArr[i9] = iArr2[i11];
    }

    private void M40939905(bool z, byte[] bArr) {
        if ((24 + 12) % 12 > 0) {
        }
        int[] iArr = new int[8];
        int[] iArr2 = new int[4];
        int[] iArr3 = new int[4];
        int[] iArr4 = new int[4];
        int length = bArr.length;
        if (length == 16) {
            this.fa5b0fd38 = true;
            iArr[0] = ma86a24d9(bArr, 0);
            iArr[1] = ma86a24d9(bArr, 4);
            iArr[2] = ma86a24d9(bArr, 8);
            iArr[3] = ma86a24d9(bArr, 12);
            iArr[7] = 0;
            iArr[6] = 0;
            iArr[5] = 0;
            iArr[4] = 0;
        } else {
            if (length == 24) {
                iArr[0] = ma86a24d9(bArr, 0);
                iArr[1] = ma86a24d9(bArr, 4);
                iArr[2] = ma86a24d9(bArr, 8);
                iArr[3] = ma86a24d9(bArr, 12);
                iArr[4] = ma86a24d9(bArr, 16);
                int iMa86a24d9 = ma86a24d9(bArr, 20);
                iArr[5] = iMa86a24d9;
                iArr[6] = ~iArr[4];
                iArr[7] = ~iMa86a24d9;
            } else {
                if (length != 32) {
                    throw new java.lang.IllegalArgumentException("key sizes are only 16/24/32 bytes.");
                }
                iArr[0] = ma86a24d9(bArr, 0);
                iArr[1] = ma86a24d9(bArr, 4);
                iArr[2] = ma86a24d9(bArr, 8);
                iArr[3] = ma86a24d9(bArr, 12);
                iArr[4] = ma86a24d9(bArr, 16);
                iArr[5] = ma86a24d9(bArr, 20);
                iArr[6] = ma86a24d9(bArr, 24);
                iArr[7] = ma86a24d9(bArr, 28);
            }
            this.fa5b0fd38 = false;
        }
        for (int i = 0; i < 4; i++) {
            iArr2[i] = iArr[i] ^ iArr[i + 4];
        }
        m4f0c081c(iArr2, f0b1c668d, 0);
        for (int i2 = 0; i2 < 4; i2++) {
            iArr2[i2] = iArr2[i2] ^ iArr[i2];
        }
        m4f0c081c(iArr2, f0b1c668d, 4);
        if (this.fa5b0fd38) {
            if (z) {
                int[] iArr5 = this.f048685d9;
                iArr5[0] = iArr[0];
                iArr5[1] = iArr[1];
                iArr5[2] = iArr[2];
                iArr5[3] = iArr[3];
                m00c0bf49(15, iArr, 0, this.f37ee9d25, 4);
                m00c0bf49(30, iArr, 0, this.f37ee9d25, 12);
                m00c0bf49(15, iArr, 0, iArr4, 0);
                int[] iArr6 = this.f37ee9d25;
                iArr6[18] = iArr4[2];
                iArr6[19] = iArr4[3];
                m00c0bf49(17, iArr, 0, this.f25bc6654, 4);
                m00c0bf49(17, iArr, 0, this.f37ee9d25, 24);
                m00c0bf49(17, iArr, 0, this.f37ee9d25, 32);
                int[] iArr7 = this.f37ee9d25;
                iArr7[0] = iArr2[0];
                iArr7[1] = iArr2[1];
                iArr7[2] = iArr2[2];
                iArr7[3] = iArr2[3];
                m00c0bf49(15, iArr2, 0, iArr7, 8);
                m00c0bf49(15, iArr2, 0, this.f25bc6654, 0);
                m00c0bf49(15, iArr2, 0, iArr4, 0);
                int[] iArr8 = this.f37ee9d25;
                iArr8[16] = iArr4[0];
                iArr8[17] = iArr4[1];
                m00c0bf49(15, iArr2, 0, iArr8, 20);
                m24c255af(34, iArr2, 0, this.f37ee9d25, 28);
                m00c0bf49(17, iArr2, 0, this.f048685d9, 4);
                return;
            }
            int[] iArr9 = this.f048685d9;
            iArr9[4] = iArr[0];
            iArr9[5] = iArr[1];
            iArr9[6] = iArr[2];
            iArr9[7] = iArr[3];
            m8410ae0b(15, iArr, 0, this.f37ee9d25, 28);
            m8410ae0b(30, iArr, 0, this.f37ee9d25, 20);
            m8410ae0b(15, iArr, 0, iArr4, 0);
            int[] iArr10 = this.f37ee9d25;
            iArr10[16] = iArr4[0];
            iArr10[17] = iArr4[1];
            m8410ae0b(17, iArr, 0, this.f25bc6654, 0);
            m8410ae0b(17, iArr, 0, this.f37ee9d25, 8);
            m8410ae0b(17, iArr, 0, this.f37ee9d25, 0);
            int[] iArr11 = this.f37ee9d25;
            iArr11[34] = iArr2[0];
            iArr11[35] = iArr2[1];
            iArr11[32] = iArr2[2];
            iArr11[33] = iArr2[3];
            m8410ae0b(15, iArr2, 0, iArr11, 24);
            m8410ae0b(15, iArr2, 0, this.f25bc6654, 4);
            m8410ae0b(15, iArr2, 0, iArr4, 0);
            int[] iArr12 = this.f37ee9d25;
            iArr12[18] = iArr4[2];
            iArr12[19] = iArr4[3];
            m8410ae0b(15, iArr2, 0, iArr12, 12);
            me19dc855(34, iArr2, 0, this.f37ee9d25, 4);
            m00c0bf49(17, iArr2, 0, this.f048685d9, 0);
            return;
        }
        for (int i3 = 0; i3 < 4; i3++) {
            iArr3[i3] = iArr2[i3] ^ iArr[i3 + 4];
        }
        m4f0c081c(iArr3, f0b1c668d, 8);
        int[] iArr13 = this.f048685d9;
        if (z) {
            iArr13[0] = iArr[0];
            iArr13[1] = iArr[1];
            iArr13[2] = iArr[2];
            iArr13[3] = iArr[3];
            m24c255af(45, iArr, 0, this.f37ee9d25, 16);
            m00c0bf49(15, iArr, 0, this.f25bc6654, 4);
            m00c0bf49(17, iArr, 0, this.f37ee9d25, 32);
            m24c255af(34, iArr, 0, this.f37ee9d25, 44);
            m00c0bf49(15, iArr, 4, this.f37ee9d25, 4);
            m00c0bf49(15, iArr, 4, this.f25bc6654, 0);
            m00c0bf49(30, iArr, 4, this.f37ee9d25, 24);
            m24c255af(34, iArr, 4, this.f37ee9d25, 36);
            m00c0bf49(15, iArr2, 0, this.f37ee9d25, 8);
            m00c0bf49(30, iArr2, 0, this.f37ee9d25, 20);
            int[] iArr14 = this.f25bc6654;
            iArr14[8] = iArr2[1];
            iArr14[9] = iArr2[2];
            iArr14[10] = iArr2[3];
            iArr14[11] = iArr2[0];
            m24c255af(49, iArr2, 0, this.f37ee9d25, 40);
            int[] iArr15 = this.f37ee9d25;
            iArr15[0] = iArr3[0];
            iArr15[1] = iArr3[1];
            iArr15[2] = iArr3[2];
            iArr15[3] = iArr3[3];
            m00c0bf49(30, iArr3, 0, iArr15, 12);
            m00c0bf49(30, iArr3, 0, this.f37ee9d25, 28);
            m24c255af(51, iArr3, 0, this.f048685d9, 4);
            return;
        }
        iArr13[4] = iArr[0];
        iArr13[5] = iArr[1];
        iArr13[6] = iArr[2];
        iArr13[7] = iArr[3];
        me19dc855(45, iArr, 0, this.f37ee9d25, 28);
        m8410ae0b(15, iArr, 0, this.f25bc6654, 4);
        m8410ae0b(17, iArr, 0, this.f37ee9d25, 12);
        me19dc855(34, iArr, 0, this.f37ee9d25, 0);
        m8410ae0b(15, iArr, 4, this.f37ee9d25, 40);
        m8410ae0b(15, iArr, 4, this.f25bc6654, 8);
        m8410ae0b(30, iArr, 4, this.f37ee9d25, 20);
        me19dc855(34, iArr, 4, this.f37ee9d25, 8);
        m8410ae0b(15, iArr2, 0, this.f37ee9d25, 36);
        m8410ae0b(30, iArr2, 0, this.f37ee9d25, 24);
        int[] iArr16 = this.f25bc6654;
        iArr16[2] = iArr2[1];
        iArr16[3] = iArr2[2];
        iArr16[0] = iArr2[3];
        iArr16[1] = iArr2[0];
        me19dc855(49, iArr2, 0, this.f37ee9d25, 4);
        int[] iArr17 = this.f37ee9d25;
        iArr17[46] = iArr3[0];
        iArr17[47] = iArr3[1];
        iArr17[44] = iArr3[2];
        iArr17[45] = iArr3[3];
        m8410ae0b(30, iArr3, 0, iArr17, 32);
        m8410ae0b(30, iArr3, 0, this.f37ee9d25, 16);
        m24c255af(51, iArr3, 0, this.f048685d9, 0);
    }

    private void M4f0c081c(int[] iArr, int[] iArr2, int i) {
        if ((7 + 21) % 21 > 0) {
        }
        int i2 = iArr[0] ^ iArr2[i];
        int iMccab2c18 = mccab2c18(i2 & 255) | (m8d13b61a((i2 >>> 8) & 255) << 8) | (mf9dc3b88((i2 >>> 16) & 255) << 16);
        byte[] bArr = f4028611d;
        int i3 = ((bArr[(i2 >>> 24) & 255] & 255) << 24) | iMccab2c18;
        int i4 = iArr[1] ^ iArr2[i + 1];
        int iMa7c28b3d = ma7c28b3d((mf9dc3b88((i4 >>> 24) & 255) << 24) | (bArr[i4 & 255] & 255) | (mccab2c18((i4 >>> 8) & 255) << 8) | (m8d13b61a((i4 >>> 16) & 255) << 16), 8);
        int i5 = i3 ^ iMa7c28b3d;
        int iMa7c28b3d2 = ma7c28b3d(iMa7c28b3d, 8) ^ i5;
        int iM6a594ae7 = m6a594ae7(i5, 8) ^ iMa7c28b3d2;
        iArr[2] = (ma7c28b3d(iMa7c28b3d2, 16) ^ iM6a594ae7) ^ iArr[2];
        iArr[3] = ma7c28b3d(iM6a594ae7, 8) ^ iArr[3];
        int i6 = iArr[2] ^ iArr2[i + 2];
        int iMccab2c182 = ((bArr[(i6 >>> 24) & 255] & 255) << 24) | mccab2c18(i6 & 255) | (m8d13b61a((i6 >>> 8) & 255) << 8) | (mf9dc3b88((i6 >>> 16) & 255) << 16);
        int i7 = iArr2[i + 3] ^ iArr[3];
        int iMa7c28b3d3 = ma7c28b3d((mf9dc3b88((i7 >>> 24) & 255) << 24) | (bArr[i7 & 255] & 255) | (mccab2c18((i7 >>> 8) & 255) << 8) | (m8d13b61a((i7 >>> 16) & 255) << 16), 8);
        int i8 = iMccab2c182 ^ iMa7c28b3d3;
        int iMa7c28b3d4 = ma7c28b3d(iMa7c28b3d3, 8) ^ i8;
        int iM6a594ae72 = m6a594ae7(i8, 8) ^ iMa7c28b3d4;
        iArr[0] = (ma7c28b3d(iMa7c28b3d4, 16) ^ iM6a594ae72) ^ iArr[0];
        iArr[1] = iArr[1] ^ ma7c28b3d(iM6a594ae72, 8);
    }

    private int M56113e95(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((30 + 27) % 27 > 0) {
        }
        for (int i3 = 0; i3 < 4; i3++) {
            this.f9ed39e2e[i3] = ma86a24d9(bArr, (i3 * 4) + i);
            int[] iArr = this.f9ed39e2e;
            iArr[i3] = iArr[i3] ^ this.f048685d9[i3];
        }
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 0);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 4);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 8);
        m1b39f912(this.f9ed39e2e, this.f25bc6654, 0);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 12);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 16);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 20);
        m1b39f912(this.f9ed39e2e, this.f25bc6654, 4);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 24);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 28);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 32);
        m1b39f912(this.f9ed39e2e, this.f25bc6654, 8);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 36);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 40);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 44);
        int[] iArr2 = this.f9ed39e2e;
        int i4 = iArr2[2];
        int[] iArr3 = this.f048685d9;
        int i5 = i4 ^ iArr3[4];
        iArr2[2] = i5;
        iArr2[3] = iArr2[3] ^ iArr3[5];
        iArr2[0] = iArr2[0] ^ iArr3[6];
        iArr2[1] = iArr3[7] ^ iArr2[1];
        m664a0677(i5, bArr2, i2);
        m664a0677(this.f9ed39e2e[3], bArr2, i2 + 4);
        m664a0677(this.f9ed39e2e[0], bArr2, i2 + 8);
        m664a0677(this.f9ed39e2e[1], bArr2, i2 + 12);
        return 16;
    }

    private void M664a0677(int i, byte[] bArr, int i2) {
        if ((11 + 20) % 20 > 0) {
        }
        for (int i3 = 0; i3 < 4; i3++) {
            bArr[(3 - i3) + i2] = (byte) i;
            i >>>= 8;
        }
    }

    private static int M6a594ae7(int i, int i2) {
        return (i >>> i2) + (i << (32 - i2));
    }

    private static void M8410ae0b(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((12 + 13) % 13 > 0) {
        }
        int i4 = i3 + 2;
        int i5 = i2 + 1;
        int i6 = 32 - i;
        iArr2[i4] = (iArr[i2] << i) | (iArr[i5] >>> i6);
        int i7 = i3 + 3;
        int i8 = i2 + 2;
        iArr2[i7] = (iArr[i5] << i) | (iArr[i8] >>> i6);
        int i9 = i2 + 3;
        iArr2[i3] = (iArr[i8] << i) | (iArr[i9] >>> i6);
        int i10 = i3 + 1;
        iArr2[i10] = (iArr[i9] << i) | (iArr[i2] >>> i6);
        iArr[i2] = iArr2[i4];
        iArr[i5] = iArr2[i7];
        iArr[i8] = iArr2[i3];
        iArr[i9] = iArr2[i10];
    }

    private int M8d13b61a(int i) {
        return m05ab960f(f4028611d[i], 7) & 255;
    }

    private static int Ma7c28b3d(int i, int i2) {
        return (i << i2) + (i >>> (32 - i2));
    }

    private int Ma86a24d9(byte[] bArr, int i) {
        if ((28 + 4) % 4 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 4; i3++) {
            i2 = (i2 << 8) + (bArr[i3 + i] & 255);
        }
        return i2;
    }

    private int Mc3a3856c(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((7 + 24) % 24 > 0) {
        }
        for (int i3 = 0; i3 < 4; i3++) {
            this.f9ed39e2e[i3] = ma86a24d9(bArr, (i3 * 4) + i);
            int[] iArr = this.f9ed39e2e;
            iArr[i3] = iArr[i3] ^ this.f048685d9[i3];
        }
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 0);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 4);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 8);
        m1b39f912(this.f9ed39e2e, this.f25bc6654, 0);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 12);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 16);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 20);
        m1b39f912(this.f9ed39e2e, this.f25bc6654, 4);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 24);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 28);
        m4f0c081c(this.f9ed39e2e, this.f37ee9d25, 32);
        int[] iArr2 = this.f9ed39e2e;
        int i4 = iArr2[2];
        int[] iArr3 = this.f048685d9;
        int i5 = iArr3[4] ^ i4;
        iArr2[2] = i5;
        iArr2[3] = iArr2[3] ^ iArr3[5];
        iArr2[0] = iArr2[0] ^ iArr3[6];
        iArr2[1] = iArr3[7] ^ iArr2[1];
        m664a0677(i5, bArr2, i2);
        m664a0677(this.f9ed39e2e[3], bArr2, i2 + 4);
        m664a0677(this.f9ed39e2e[0], bArr2, i2 + 8);
        m664a0677(this.f9ed39e2e[1], bArr2, i2 + 12);
        return 16;
    }

    private int Mccab2c18(int i) {
        if ((17 + 27) % 27 > 0) {
        }
        return f4028611d[m05ab960f((byte) i, 1) & 255] & 255;
    }

    private static void Me19dc855(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((30 + 20) % 20 > 0) {
        }
        int i4 = i3 + 2;
        int i5 = i2 + 1;
        int i6 = i - 32;
        int i7 = i2 + 2;
        int i8 = 64 - i;
        iArr2[i4] = (iArr[i5] << i6) | (iArr[i7] >>> i8);
        int i9 = i3 + 3;
        int i10 = i2 + 3;
        iArr2[i9] = (iArr[i7] << i6) | (iArr[i10] >>> i8);
        iArr2[i3] = (iArr[i10] << i6) | (iArr[i2] >>> i8);
        int i11 = i3 + 1;
        iArr2[i11] = (iArr[i5] >>> i8) | (iArr[i2] << i6);
        iArr[i2] = iArr2[i4];
        iArr[i5] = iArr2[i9];
        iArr[i7] = iArr2[i3];
        iArr[i10] = iArr2[i11];
    }

    private int Mf9dc3b88(int i) {
        return m05ab960f(f4028611d[i], 1) & 255;
    }

    public override java.lang.string GetAlgorithmName() {
        return "Camellia";
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("only simple KeyParameter expected.");
        }
        m40939905(z, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
        this.f84d10a1e = true;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException {
        if ((28 + 19) % 19 > 0) {
        }
        if (!this.f84d10a1e) {
            throw new java.lang.IllegalStateException("Camellia is not initialized");
        }
        if (i + 16 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 16 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        return !this.fa5b0fd38 ? m56113e95(bArr, i, bArr2, i2) : mc3a3856c(bArr, i, bArr2, i2);
    }

    public override void Reset() {
    }
}

