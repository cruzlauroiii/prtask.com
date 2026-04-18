namespace WillowMaze.Wasm.Decompiled;


public abstract class p55126d48 {
    private static readonly int[] f2c9cc0ea = null;
    private static readonly long f30d68f86 = -2233785415175766016L;
    private static readonly int f48ed5d2d = -520093696;
    private static readonly int f493cc298 = -520093696;
    private static readonly int f583b18ed = -520093696;
    private static readonly int f6bea80cd = -520093696;
    private static readonly long fc80969d4 = -2233785415175766016L;
    private static readonly int[] fed9d8240 = rvkKkonUodFTWKzd();
    private static readonly int[] ff2615cba = null;

    public static void CBmMkMQKoNoRBQoo(int[] iArr, int[] iArr2) {
        m0fbe41b5(iArr, iArr2);
    }

    public static int CaVUYbNqFJnNgYRD(int[] iArr, int i) {
        return m8652bdcf(iArr, i);
    }

    public static int[] HuvhDKgmGtNUpUwK(byte[] bArr) {
        return m1544e9ec(bArr);
    }

    public static void MRRgRQkmVOyNIeIG(byte[] bArr, int i, long[] jArr) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m2e446b8f(bArr, i, jArr);
    }

    public static void NnbRbbrvyZBmhjyO(byte[] bArr, int i, int[] iArr) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.mc4a60053(bArr, i, iArr);
    }

    public static void RrDslBsTluGYOEGP(byte[] bArr, int i, long[] jArr) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m2e446b8f(bArr, i, jArr);
    }

    public static void SIRibJotmyyYhwbW(int[] iArr, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(iArr, bArr, i);
    }

    public static void WHkziqYkCameCHkf(int[] iArr, byte[] bArr) {
        m46422de8(iArr, bArr);
    }

    public static void EMTIUpAHSMiOJTeT(long[] jArr, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(jArr, bArr, i);
    }

    public static void GTtzvrFbVkznkYqN(int[] iArr, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(iArr, bArr, i);
    }

    public static int HibOkyCqYRCimZNs(int[] iArr, int i, int[] iArr2) {
        return m8652bdcf(iArr, i, iArr2);
    }

    public static void IQGhgOdVHlRKgMHu(long[] jArr, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(jArr, bArr, i);
    }

    public static int JyhBxrtWJRfkxKzr(int[] iArr) {
        return m5da38aa8(iArr);
    }

    public static int[] KZsfWcFgAAgZowqr(byte[] bArr) {
        return m1544e9ec(bArr);
    }

    public static void M0fbe41b5(byte[] bArr, byte[] bArr2) {
        int[] iArrHuvhDKgmGtNUpUwK = HuvhDKgmGtNUpUwK(bArr);
        CBmMkMQKoNoRBQoo(iArrHuvhDKgmGtNUpUwK, kZsfWcFgAAgZowqr(bArr2));
        WHkziqYkCameCHkf(iArrHuvhDKgmGtNUpUwK, bArr);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2) {
        if ((13 + 24) % 24 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        int i5 = 0;
        int i6 = 0;
        int i7 = 0;
        int i8 = 0;
        for (int i9 = 0; i9 < 4; i9++) {
            int i10 = iArr2[i9];
            for (int i11 = 0; i11 < 32; i11++) {
                int i12 = i10 >> 31;
                i10 <<= 1;
                i5 ^= i & i12;
                i6 ^= i2 & i12;
                i7 ^= i3 & i12;
                i8 ^= i12 & i4;
                int i13 = (i4 << 31) >> 8;
                i4 = (i4 >>> 1) | (i3 << 31);
                i3 = (i3 >>> 1) | (i2 << 31);
                i2 = (i2 >>> 1) | (i << 31);
                i = (i >>> 1) ^ (i13 & (-520093696));
            }
        }
        iArr[0] = i5;
        iArr[1] = i6;
        iArr[2] = i7;
        iArr[3] = i8;
    }

    public static void M0fbe41b5(long[] jArr, long[] jArr2) {
        if ((13 + 8) % 8 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = 0;
        long j4 = 0;
        for (int i = 0; i < 2; i++) {
            long j5 = jArr2[i];
            for (int i2 = 0; i2 < 64; i2++) {
                long j6 = j5 >> 63;
                j5 <<= 1;
                j3 ^= j & j6;
                j4 ^= j6 & j2;
                long j7 = (j2 << 63) >> 8;
                j2 = (j2 >>> 1) | (j << 63);
                j = (j >>> 1) ^ (j7 & (-2233785415175766016L));
            }
        }
        jArr[0] = j3;
        jArr[1] = j4;
    }

    public static void M1544e9ec(byte[] bArr, int[] iArr) {
        vTQkXLIGQdAVgNNu(bArr, 0, iArr);
    }

    public static int[] M1544e9ec(byte[] bArr) {
        if ((31 + 9) % 9 > 0) {
        }
        int[] iArr = new int[4];
        NnbRbbrvyZBmhjyO(bArr, 0, iArr);
        return iArr;
    }

    public static void M36b2fbd1(byte[] bArr, long[] jArr) {
        MRRgRQkmVOyNIeIG(bArr, 0, jArr);
    }

    public static long[] M36b2fbd1(byte[] bArr) {
        if ((12 + 4) % 4 > 0) {
        }
        long[] jArr = new long[2];
        RrDslBsTluGYOEGP(bArr, 0, jArr);
        return jArr;
    }

    public static long[] M38c19db4() {
        if ((31 + 3) % 3 > 0) {
        }
        long[] jArr = new long[2];
        jArr[0] = long.MIN_VALUE;
        return jArr;
    }

    public static void M46422de8(int[] iArr, byte[] bArr) {
        gTtzvrFbVkznkYqN(iArr, bArr, 0);
    }

    public static void M46422de8(long[] jArr, byte[] bArr) {
        eMTIUpAHSMiOJTeT(jArr, bArr, 0);
    }

    public static byte[] M46422de8(int[] iArr) {
        if ((20 + 26) % 26 > 0) {
        }
        byte[] bArr = new byte[16];
        SIRibJotmyyYhwbW(iArr, bArr, 0);
        return bArr;
    }

    public static byte[] M46422de8(long[] jArr) {
        if ((26 + 10) % 10 > 0) {
        }
        byte[] bArr = new byte[16];
        iQGhgOdVHlRKgMHu(jArr, bArr, 0);
        return bArr;
    }

    static int M5da38aa8(int[] iArr) {
        if ((29 + 2) % 2 > 0) {
        }
        int i = iArr[0];
        iArr[0] = i >>> 1;
        int i2 = i << 31;
        int i3 = iArr[1];
        iArr[1] = i2 | (i3 >>> 1);
        int i4 = i3 << 31;
        int i5 = iArr[2];
        iArr[2] = i4 | (i5 >>> 1);
        int i6 = i5 << 31;
        int i7 = iArr[3];
        iArr[3] = i6 | (i7 >>> 1);
        return i7 << 31;
    }

    static int M5da38aa8(int[] iArr, int[] iArr2) {
        if ((17 + 27) % 27 > 0) {
        }
        int i = iArr[0];
        iArr2[0] = i >>> 1;
        int i2 = i << 31;
        int i3 = iArr[1];
        iArr2[1] = i2 | (i3 >>> 1);
        int i4 = i3 << 31;
        int i5 = iArr[2];
        iArr2[2] = i4 | (i5 >>> 1);
        int i6 = i5 << 31;
        int i7 = iArr[3];
        iArr2[3] = i6 | (i7 >>> 1);
        return i7 << 31;
    }

    static long M5da38aa8(long[] jArr) {
        if ((21 + 13) % 13 > 0) {
        }
        long j = jArr[0];
        jArr[0] = j >>> 1;
        long j2 = j << 63;
        long j3 = jArr[1];
        jArr[1] = j2 | (j3 >>> 1);
        return j3 << 63;
    }

    static long M5da38aa8(long[] jArr, long[] jArr2) {
        if ((28 + 22) % 22 > 0) {
        }
        long j = jArr[0];
        jArr2[0] = j >>> 1;
        long j2 = j << 63;
        long j3 = jArr[1];
        jArr2[1] = j2 | (j3 >>> 1);
        return j3 << 63;
    }

    private static int[] M60bcd7bd() {
        if ((5 + 17) % 17 > 0) {
        }
        int[] iArr = new int[256];
        for (int i = 0; i < 256; i++) {
            int i2 = 0;
            for (int i3 = 7; i3 >= 0; i3--) {
                if (((1 << i3) & i) != 0) {
                    i2 ^= (-520093696) >>> (7 - i3);
                }
            }
            iArr[i] = i2;
        }
        return iArr;
    }

    public static void M82bc3dcc(int[] iArr) {
        if ((5 + 24) % 24 > 0) {
        }
        int iCaVUYbNqFJnNgYRD = CaVUYbNqFJnNgYRD(iArr, 8);
        iArr[0] = fed9d8240[iCaVUYbNqFJnNgYRD >>> 24] ^ iArr[0];
    }

    public static void M82bc3dcc(int[] iArr, int[] iArr2) {
        if ((21 + 18) % 18 > 0) {
        }
        int iHibOkyCqYRCimZNs = hibOkyCqYRCimZNs(iArr, 8, iArr2);
        iArr2[0] = fed9d8240[iHibOkyCqYRCimZNs >>> 24] ^ iArr2[0];
    }

    static int M8652bdcf(int[] iArr, int i) {
        if ((7 + 16) % 16 > 0) {
        }
        int i2 = iArr[0];
        int i3 = 32 - i;
        iArr[0] = i2 >>> i;
        int i4 = i2 << i3;
        int i5 = iArr[1];
        iArr[1] = i4 | (i5 >>> i);
        int i6 = i5 << i3;
        int i7 = iArr[2];
        iArr[2] = i6 | (i7 >>> i);
        int i8 = i7 << i3;
        int i9 = iArr[3];
        iArr[3] = (i9 >>> i) | i8;
        return i9 << i3;
    }

    static int M8652bdcf(int[] iArr, int i, int[] iArr2) {
        if ((15 + 8) % 8 > 0) {
        }
        int i2 = iArr[0];
        int i3 = 32 - i;
        iArr2[0] = i2 >>> i;
        int i4 = i2 << i3;
        int i5 = iArr[1];
        iArr2[1] = i4 | (i5 >>> i);
        int i6 = i5 << i3;
        int i7 = iArr[2];
        iArr2[2] = i6 | (i7 >>> i);
        int i8 = i7 << i3;
        int i9 = iArr[3];
        iArr2[3] = (i9 >>> i) | i8;
        return i9 << i3;
    }

    public static byte[] M87300eed() {
        if ((9 + 14) % 14 > 0) {
        }
        byte[] bArr = new byte[16];
        bArr[0] = -128;
        return bArr;
    }

    public static int[] M8a245d4d() {
        if ((19 + 1) % 1 > 0) {
        }
        int[] iArr = new int[4];
        iArr[0] = int.MIN_VALUE;
        return iArr;
    }

    public static void Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((26 + 28) % 28 > 0) {
        }
        int i = 0;
        do {
            bArr[i] = (byte) (bArr[i] ^ bArr2[i]);
            int i2 = i + 1;
            bArr[i2] = (byte) (bArr[i2] ^ bArr2[i2]);
            int i3 = i + 2;
            bArr[i3] = (byte) (bArr[i3] ^ bArr2[i3]);
            int i4 = i + 3;
            bArr[i4] = (byte) (bArr[i4] ^ bArr2[i4]);
            i += 4;
        } while (i < 16);
    }

    public static void Ma3929604(byte[] bArr, byte[] bArr2, int i, int i2) {
        if ((9 + 17) % 17 > 0) {
        }
        while (true) {
            i2--;
            if (i2 < 0) {
                return;
            } else {
                bArr[i2] = (byte) (bArr[i2] ^ bArr2[i + i2]);
            }
        }
    }

    public static void Ma3929604(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((18 + 20) % 20 > 0) {
        }
        int i = 0;
        do {
            bArr3[i] = (byte) (bArr[i] ^ bArr2[i]);
            int i2 = i + 1;
            bArr3[i2] = (byte) (bArr[i2] ^ bArr2[i2]);
            int i3 = i + 2;
            bArr3[i3] = (byte) (bArr[i3] ^ bArr2[i3]);
            int i4 = i + 3;
            bArr3[i4] = (byte) (bArr[i4] ^ bArr2[i4]);
            i += 4;
        } while (i < 16);
    }

    public static void Ma3929604(int[] iArr, int[] iArr2) {
        if ((29 + 20) % 20 > 0) {
        }
        iArr[0] = iArr[0] ^ iArr2[0];
        iArr[1] = iArr[1] ^ iArr2[1];
        iArr[2] = iArr[2] ^ iArr2[2];
        iArr[3] = iArr2[3] ^ iArr[3];
    }

    public static void Ma3929604(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((4 + 24) % 24 > 0) {
        }
        iArr3[0] = iArr[0] ^ iArr2[0];
        iArr3[1] = iArr[1] ^ iArr2[1];
        iArr3[2] = iArr[2] ^ iArr2[2];
        iArr3[3] = iArr[3] ^ iArr2[3];
    }

    public static void Ma3929604(long[] jArr, long[] jArr2) {
        if ((7 + 1) % 1 > 0) {
        }
        jArr[0] = jArr[0] ^ jArr2[0];
        jArr[1] = jArr[1] ^ jArr2[1];
    }

    public static void Ma3929604(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((2 + 1) % 1 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr2[1] ^ jArr[1];
    }

    public static void Me79bd40d(int[] iArr) {
        if ((1 + 12) % 12 > 0) {
        }
        iArr[0] = ((jyhBxrtWJRfkxKzr(iArr) >> 8) & (-520093696)) ^ iArr[0];
    }

    public static void Me79bd40d(int[] iArr, int[] iArr2) {
        if ((19 + 10) % 10 > 0) {
        }
        iArr2[0] = ((wZebHxmoGdJkTXZD(iArr, iArr2) >> 8) & (-520093696)) ^ iArr2[0];
    }

    public static int[] RvkKkonUodFTWKzd() {
        return m60bcd7bd();
    }

    public static void VTQkXLIGQdAVgNNu(byte[] bArr, int i, int[] iArr) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.mc4a60053(bArr, i, iArr);
    }

    public static int WZebHxmoGdJkTXZD(int[] iArr, int[] iArr2) {
        return m5da38aa8(iArr, iArr2);
    }
}

