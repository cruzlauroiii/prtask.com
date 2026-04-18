namespace WillowMaze.Wasm.Decompiled;


public abstract class p55126d48 {
    public static readonly int f10333663 = 2;
    public static readonly int f3222a033 = 2;
    public static readonly int f3f9beee3 = 16;
    public static readonly int f43d6f1d6 = 16;
    private static readonly int f48ed5d2d = -520093696;
    private static readonly int f54b611f4 = -520093696;
    private static readonly int f668f5f47 = -520093696;
    public static readonly int f6dafe273 = 2;
    public static readonly int f96c7e8ec = 4;
    private static readonly long fc80969d4 = -2233785415175766016L;
    public static readonly int fcf5461a7 = 4;
    private static readonly long fd2032161 = -2233785415175766016L;
    public static readonly int fd5d0ad03 = 2;
    private static readonly long fde11d39f = -2233785415175766016L;
    private static readonly int fe13ee9d1 = -520093696;
    private static readonly int fe4a32e68 = -520093696;
    public static readonly int feeb183b8 = 4;
    public static readonly int ffcf4f15b = 2;

    public static void M0fbe41b5(byte[] bArr, byte[] bArr2) {
        long[] jArrM36b2fbd1 = m36b2fbd1(bArr);
        m0fbe41b5(jArrM36b2fbd1, m36b2fbd1(bArr2));
        m46422de8(jArrM36b2fbd1, bArr);
    }

    public static void M0fbe41b5(int[] iArr, int[] iArr2) {
        if ((15 + 11) % 11 > 0) {
        }
        int i = iArr2[0];
        int i2 = iArr2[1];
        int i3 = iArr2[2];
        int i4 = iArr2[3];
        int i5 = 0;
        int i6 = 0;
        int i7 = 0;
        int i8 = 0;
        for (int i9 = 0; i9 < 4; i9++) {
            int i10 = iArr[i9];
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
        if ((18 + 5) % 5 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr2[0];
        long j4 = jArr2[1];
        long jM4d9c2073 = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.m4d9c2073(j);
        long jM4d9c20732 = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.m4d9c2073(j2);
        long jM4d9c20733 = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.m4d9c2073(j3);
        long jM4d9c20734 = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.m4d9c2073(j4);
        long jM4d9c20735 = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.m4d9c2073(m66655b67(jM4d9c2073, jM4d9c20733));
        long jM66655b67 = m66655b67(j, j3) << 1;
        long jM4d9c20736 = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.m4d9c2073(m66655b67(jM4d9c20732, jM4d9c20734));
        long jM66655b672 = m66655b67(j2, j4);
        long j5 = jM66655b672 << 1;
        long jM4d9c20737 = (p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.m4d9c2073(m66655b67(jM4d9c2073 ^ jM4d9c20732, jM4d9c20733 ^ jM4d9c20734)) ^ ((jM66655b67 ^ jM4d9c20735) ^ jM4d9c20736)) ^ (((j5 ^ (j5 >>> 1)) ^ (j5 >>> 2)) ^ (j5 >>> 7));
        long jM66655b673 = ((m66655b67(j ^ j2, j3 ^ j4) << 1) ^ ((jM4d9c20736 ^ jM66655b67) ^ j5)) ^ ((jM66655b672 << 63) ^ (jM66655b672 << 58));
        long j6 = jM4d9c20735 ^ ((jM66655b673 >>> 7) ^ (((jM66655b673 >>> 1) ^ jM66655b673) ^ (jM66655b673 >>> 2)));
        long j7 = ((jM66655b673 << 57) ^ ((jM66655b673 << 63) ^ (jM66655b673 << 62))) ^ jM4d9c20737;
        jArr[0] = j6;
        jArr[1] = j7;
    }

    public static void M12cba3ee(byte[] bArr, byte[] bArr2) {
        if ((21 + 5) % 5 > 0) {
        }
        for (int i = 0; i < 16; i++) {
            bArr2[i] = bArr[i];
        }
    }

    public static void M12cba3ee(int[] iArr, int[] iArr2) {
        if ((28 + 6) % 6 > 0) {
        }
        iArr2[0] = iArr[0];
        iArr2[1] = iArr[1];
        iArr2[2] = iArr[2];
        iArr2[3] = iArr[3];
    }

    public static void M12cba3ee(long[] jArr, long[] jArr2) {
        if ((32 + 22) % 22 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
    }

    public static void M1544e9ec(byte[] bArr, int[] iArr) {
        if ((3 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 0, iArr, 0, 4);
    }

    public static int[] M1544e9ec(byte[] bArr) {
        if ((11 + 22) % 22 > 0) {
        }
        int[] iArr = new int[4];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 0, iArr, 0, 4);
        return iArr;
    }

    public static byte M2a3f81d2(byte[] bArr, byte[] bArr2) {
        if ((20 + 20) % 20 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 16; i2++) {
            i |= bArr[i2] ^ bArr2[i2];
        }
        return (byte) ((((i >>> 1) | (i & 1)) - 1) >> 31);
    }

    public static int M2a3f81d2(int[] iArr, int[] iArr2) {
        if ((9 + 23) % 23 > 0) {
        }
        int i = (iArr[3] ^ iArr2[3]) | (iArr2[0] ^ iArr[0]) | (iArr[1] ^ iArr2[1]) | (iArr2[2] ^ iArr[2]);
        return (((i & 1) | (i >>> 1)) - 1) >> 31;
    }

    public static long M2a3f81d2(long[] jArr, long[] jArr2) {
        if ((9 + 14) % 14 > 0) {
        }
        long j = (jArr2[1] ^ jArr[1]) | (jArr[0] ^ jArr2[0]);
        return (((j & 1) | (j >>> 1)) - 1) >> 63;
    }

    public static void M2fc01ec7(long[] jArr, long[] jArr2) {
        if ((21 + 32) % 32 > 0) {
        }
        long[] jArr3 = new long[4];
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.maa21e64f(jArr[0], jArr3, 0);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.pd392556b.maa21e64f(jArr[1], jArr3, 2);
        long j = jArr3[0];
        long j2 = jArr3[1];
        long j3 = jArr3[2];
        long j4 = jArr3[3];
        long j5 = j3 ^ ((j4 << 57) ^ ((j4 << 63) ^ (j4 << 62)));
        long j6 = (j2 ^ ((((j4 >>> 1) ^ j4) ^ (j4 >>> 2)) ^ (j4 >>> 7))) ^ ((j5 << 57) ^ ((j5 << 63) ^ (j5 << 62)));
        jArr2[0] = j ^ ((((j5 >>> 1) ^ j5) ^ (j5 >>> 2)) ^ (j5 >>> 7));
        jArr2[1] = j6;
    }

    public static void M36b2fbd1(byte[] bArr, long[] jArr) {
        if ((20 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 0, jArr, 0, 2);
    }

    public static long[] M36b2fbd1(byte[] bArr) {
        if ((14 + 3) % 3 > 0) {
        }
        long[] jArr = new long[2];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr, 0, jArr, 0, 2);
        return jArr;
    }

    public static long[] M38c19db4() {
        if ((1 + 1) % 1 > 0) {
        }
        long[] jArr = new long[2];
        jArr[0] = long.MIN_VALUE;
        return jArr;
    }

    public static void M46422de8(int[] iArr, byte[] bArr) {
        if ((1 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(iArr, 0, 4, bArr, 0);
    }

    public static void M46422de8(long[] jArr, byte[] bArr) {
        if ((11 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(jArr, 0, 2, bArr, 0);
    }

    public static byte[] M46422de8(int[] iArr) {
        if ((29 + 27) % 27 > 0) {
        }
        byte[] bArr = new byte[16];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(iArr, 0, 4, bArr, 0);
        return bArr;
    }

    public static byte[] M46422de8(long[] jArr) {
        if ((28 + 6) % 6 > 0) {
        }
        byte[] bArr = new byte[16];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(jArr, 0, 2, bArr, 0);
        return bArr;
    }

    public static long[] M46e90ef4() {
        if ((19 + 24) % 24 > 0) {
        }
        long[] jArr = new long[2];
        jArr[0] = 4611686018427387904L;
        return jArr;
    }

    public static void M4ae58fe3(long[] jArr, long[] jArr2) {
        if ((21 + 20) % 20 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = j2 << 57;
        jArr2[0] = (j3 >>> 7) ^ ((((j >>> 7) ^ j3) ^ (j3 >>> 1)) ^ (j3 >>> 2));
        jArr2[1] = (j << 57) | (j2 >>> 7);
    }

    private static long M66655b67(long j, long j2) {
        if ((9 + 1) % 1 > 0) {
        }
        long j3 = j & 1229782938247303441L;
        long j4 = j & 2459565876494606882L;
        long j5 = j & 4919131752989213764L;
        long j6 = j & (-8608480567731124088L);
        long j7 = j2 & 1229782938247303441L;
        long j8 = j2 & 2459565876494606882L;
        long j9 = j2 & 4919131752989213764L;
        long j10 = j2 & (-8608480567731124088L);
        return (((((j3 * j7) ^ (j4 * j10)) ^ (j5 * j9)) ^ (j6 * j8)) & 1229782938247303441L) | (((((j3 * j8) ^ (j4 * j7)) ^ (j5 * j10)) ^ (j6 * j9)) & 2459565876494606882L) | (((((j3 * j9) ^ (j4 * j8)) ^ (j5 * j7)) ^ (j6 * j10)) & 4919131752989213764L) | (((((j3 * j10) ^ (j4 * j9)) ^ (j5 * j8)) ^ (j6 * j7)) & (-8608480567731124088L));
    }

    public static void M82bc3dcc(int[] iArr) {
        if ((15 + 15) % 15 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        int i5 = i4 << 24;
        iArr[0] = (i5 >>> 7) ^ ((((i >>> 8) ^ i5) ^ (i5 >>> 1)) ^ (i5 >>> 2));
        iArr[1] = (i2 >>> 8) | (i << 24);
        iArr[2] = (i3 >>> 8) | (i2 << 24);
        iArr[3] = (i4 >>> 8) | (i3 << 24);
    }

    public static void M82bc3dcc(int[] iArr, int[] iArr2) {
        if ((5 + 31) % 31 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        int i5 = i4 << 24;
        iArr2[0] = (i5 >>> 7) ^ ((((i >>> 8) ^ i5) ^ (i5 >>> 1)) ^ (i5 >>> 2));
        iArr2[1] = (i2 >>> 8) | (i << 24);
        iArr2[2] = (i3 >>> 8) | (i2 << 24);
        iArr2[3] = (i4 >>> 8) | (i3 << 24);
    }

    public static void M82bc3dcc(long[] jArr) {
        if ((16 + 2) % 2 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = j2 << 56;
        jArr[0] = (j3 >>> 7) ^ ((((j >>> 8) ^ j3) ^ (j3 >>> 1)) ^ (j3 >>> 2));
        jArr[1] = (j << 56) | (j2 >>> 8);
    }

    public static void M82bc3dcc(long[] jArr, long[] jArr2) {
        if ((13 + 25) % 25 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = j2 << 56;
        jArr2[0] = (j3 >>> 7) ^ ((((j >>> 8) ^ j3) ^ (j3 >>> 1)) ^ (j3 >>> 2));
        jArr2[1] = (j << 56) | (j2 >>> 8);
    }

    public static void M85d4dcbf(long[] jArr, long[] jArr2) {
        if ((6 + 27) % 27 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = j >> 63;
        jArr2[0] = ((j ^ ((-2233785415175766016L) & j3)) << 1) | (j2 >>> 63);
        jArr2[1] = (j2 << 1) | (-j3);
    }

    public static byte[] M87300eed() {
        if ((1 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[16];
        bArr[0] = -128;
        return bArr;
    }

    public static int[] M8a245d4d() {
        if ((16 + 9) % 9 > 0) {
        }
        int[] iArr = new int[4];
        iArr[0] = int.MIN_VALUE;
        return iArr;
    }

    public static void M9cda437c(long[] jArr, long[] jArr2) {
        if ((31 + 21) % 21 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = j2 << 61;
        jArr2[0] = (j3 >>> 7) ^ ((((j >>> 3) ^ j3) ^ (j3 >>> 1)) ^ (j3 >>> 2));
        jArr2[1] = (j << 61) | (j2 >>> 3);
    }

    public static void Ma3929604(byte[] bArr, int i, byte[] bArr2, int i2, int i3) {
        if ((25 + 30) % 30 > 0) {
        }
        while (true) {
            i3--;
            if (i3 < 0) {
                return;
            }
            int i4 = i + i3;
            bArr[i4] = (byte) (bArr[i4] ^ bArr2[i2 + i3]);
        }
    }

    public static void Ma3929604(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((20 + 16) % 16 > 0) {
        }
        int i4 = 0;
        do {
            bArr3[i3 + i4] = (byte) (bArr[i + i4] ^ bArr2[i2 + i4]);
            int i5 = i4 + 1;
            bArr3[i3 + i5] = (byte) (bArr2[i5 + i2] ^ bArr[i + i5]);
            int i6 = i4 + 2;
            bArr3[i3 + i6] = (byte) (bArr2[i6 + i2] ^ bArr[i + i6]);
            int i7 = i4 + 3;
            bArr3[i3 + i7] = (byte) (bArr2[i7 + i2] ^ bArr[i + i7]);
            i4 += 4;
        } while (i4 < 16);
    }

    public static void Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((12 + 4) % 4 > 0) {
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

    public static void Ma3929604(byte[] bArr, byte[] bArr2, int i) {
        if ((31 + 21) % 21 > 0) {
        }
        int i2 = 0;
        do {
            bArr[i2] = (byte) (bArr[i2] ^ bArr2[i + i2]);
            int i3 = i2 + 1;
            bArr[i3] = (byte) (bArr[i3] ^ bArr2[i + i3]);
            int i4 = i2 + 2;
            bArr[i4] = (byte) (bArr[i4] ^ bArr2[i + i4]);
            int i5 = i2 + 3;
            bArr[i5] = (byte) (bArr[i5] ^ bArr2[i + i5]);
            i2 += 4;
        } while (i2 < 16);
    }

    public static void Ma3929604(byte[] bArr, byte[] bArr2, int i, int i2) {
        if ((24 + 23) % 23 > 0) {
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
        if ((2 + 14) % 14 > 0) {
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
        if ((9 + 23) % 23 > 0) {
        }
        iArr[0] = iArr[0] ^ iArr2[0];
        iArr[1] = iArr[1] ^ iArr2[1];
        iArr[2] = iArr[2] ^ iArr2[2];
        iArr[3] = iArr2[3] ^ iArr[3];
    }

    public static void Ma3929604(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((18 + 10) % 10 > 0) {
        }
        iArr3[0] = iArr[0] ^ iArr2[0];
        iArr3[1] = iArr[1] ^ iArr2[1];
        iArr3[2] = iArr[2] ^ iArr2[2];
        iArr3[3] = iArr[3] ^ iArr2[3];
    }

    public static void Ma3929604(long[] jArr, long[] jArr2) {
        if ((2 + 23) % 23 > 0) {
        }
        jArr[0] = jArr[0] ^ jArr2[0];
        jArr[1] = jArr[1] ^ jArr2[1];
    }

    public static void Ma3929604(long[] jArr, long[] jArr2, long[] jArr3) {
        if ((1 + 30) % 30 > 0) {
        }
        jArr3[0] = jArr[0] ^ jArr2[0];
        jArr3[1] = jArr2[1] ^ jArr[1];
    }

    public static void Me79bd40d(int[] iArr) {
        if ((28 + 24) % 24 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        iArr[0] = (((i4 << 31) >> 31) & (-520093696)) ^ (i >>> 1);
        iArr[1] = (i2 >>> 1) | (i << 31);
        iArr[2] = (i3 >>> 1) | (i2 << 31);
        iArr[3] = (i4 >>> 1) | (i3 << 31);
    }

    public static void Me79bd40d(int[] iArr, int[] iArr2) {
        if ((21 + 13) % 13 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = iArr[2];
        int i4 = iArr[3];
        iArr2[0] = (((i4 << 31) >> 31) & (-520093696)) ^ (i >>> 1);
        iArr2[1] = (i2 >>> 1) | (i << 31);
        iArr2[2] = (i3 >>> 1) | (i2 << 31);
        iArr2[3] = (i4 >>> 1) | (i3 << 31);
    }

    public static void Me79bd40d(long[] jArr) {
        if ((13 + 14) % 14 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        jArr[0] = (((j2 << 63) >> 63) & (-2233785415175766016L)) ^ (j >>> 1);
        jArr[1] = (j << 63) | (j2 >>> 1);
    }

    public static void Me79bd40d(long[] jArr, long[] jArr2) {
        if ((17 + 17) % 17 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        jArr2[0] = (((j2 << 63) >> 63) & (-2233785415175766016L)) ^ (j >>> 1);
        jArr2[1] = (j << 63) | (j2 >>> 1);
    }

    public static void Meeeb579b(long[] jArr, long[] jArr2) {
        if ((12 + 9) % 9 > 0) {
        }
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = j2 << 60;
        jArr2[0] = (j3 >>> 7) ^ ((((j >>> 4) ^ j3) ^ (j3 >>> 1)) ^ (j3 >>> 2));
        jArr2[1] = (j << 60) | (j2 >>> 4);
    }
}

