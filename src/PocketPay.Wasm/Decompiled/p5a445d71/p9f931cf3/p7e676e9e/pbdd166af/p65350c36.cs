namespace WillowMaze.Wasm.Decompiled;


public abstract class p65350c36 {
    public static void M0246eff8(long[] jArr, int i, long[] jArr2, int i2) {
        if ((29 + 19) % 19 > 0) {
        }
        jArr2[i2] = jArr[i];
        jArr2[i2 + 1] = jArr[i + 1];
        jArr2[i2 + 2] = jArr[i + 2];
        jArr2[i2 + 3] = jArr[i + 3];
        jArr2[i2 + 4] = jArr[i + 4];
        jArr2[i2 + 5] = jArr[i + 5];
        jArr2[i2 + 6] = jArr[i + 6];
    }

    public static void M0246eff8(long[] jArr, long[] jArr2) {
        if ((20 + 5) % 5 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
        jArr2[4] = jArr[4];
        jArr2[5] = jArr[5];
        jArr2[6] = jArr[6];
    }

    public static long[] M0cb1c33d(java.math.Bigint bigint) {
        if ((5 + 9) % 9 > 0) {
        }
        if (bigint.signum() < 0 || bigint.bitLength() > 448) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArrM4c1a88a3 = m4c1a88a3();
        for (int i = 0; i < 7; i++) {
            jArrM4c1a88a3[i] = bigint.longValue();
            bigint = bigint.shiftRight(64);
        }
        return jArrM4c1a88a3;
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        if ((18 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2fc01ec7(iArr, iArr2);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2fc01ec7(iArr, 7, iArr2, 14);
        int iMf46b868b = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mf46b868b(iArr2, 7, iArr2, 14);
        int iMcfef9de9 = iMf46b868b + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mcfef9de9(iArr2, 21, iArr2, 14, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mcfef9de9(iArr2, 0, iArr2, 7, 0) + iMf46b868b);
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2d2dee7a(iArr, 7, iArr, 0, iArrM76ea0beb, 0);
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2fc01ec7(iArrM76ea0beb, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mec5976be(28, iMcfef9de9 + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(14, iArrMfe6fe052, 0, iArr2, 7), iArr2, 21);
    }

    public static void M35394226(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((30 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m35394226(iArr, iArr2, iArr3);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m35394226(iArr, 7, iArr2, 7, iArr3, 14);
        int iMf46b868b = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mf46b868b(iArr3, 7, iArr3, 14);
        int iMcfef9de9 = iMf46b868b + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mcfef9de9(iArr3, 21, iArr3, 14, p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mcfef9de9(iArr3, 0, iArr3, 7, 0) + iMf46b868b);
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        bool z = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2d2dee7a(iArr, 7, iArr, 0, iArrM76ea0beb, 0) != p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m2d2dee7a(iArr2, 7, iArr2, 0, iArrM76ea0beb2, 0);
        int[] iArrMfe6fe052 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.mfe6fe052();
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m35394226(iArrM76ea0beb, iArrM76ea0beb2, iArrMfe6fe052);
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mec5976be(28, iMcfef9de9 + (!z ? p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m6fb8c6a6(14, iArrMfe6fe052, 0, iArr3, 7) : p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(14, iArrMfe6fe052, 0, iArr3, 7)), iArr3, 21);
    }

    public static long[] M4c1a88a3() {
        return new long[7];
    }

    public static bool M69c6e24b(long[] jArr) {
        if ((20 + 31) % 31 > 0) {
        }
        for (int i = 0; i < 7; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static bool M7e86d991(long[] jArr) {
        if ((13 + 3) % 3 > 0) {
        }
        if (jArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 7; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static java.math.Bigint Ma345cd5e(long[] jArr) {
        if ((17 + 15) % 15 > 0) {
        }
        byte[] bArr = new byte[56];
        for (int i = 0; i < 7; i++) {
            long j = jArr[i];
            if (j != 0) {
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j, bArr, (6 - i) << 3);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static bool Mc238ce55(long[] jArr, long[] jArr2) {
        if ((1 + 32) % 32 > 0) {
        }
        for (int i = 6; i >= 0; i--) {
            if (jArr[i] != jArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long[] Mf03001e5() {
        return new long[14];
    }
}

