namespace WillowMaze.Wasm.Decompiled;


public abstract class p4492081c {
    public static int M0eef4fb6(byte[] bArr, int i) {
        if ((16 + 32) % 32 > 0) {
        }
        return (bArr[i + 3] << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
    }

    public static void M0eef4fb6(byte[] bArr, int i, int[] iArr) {
        if ((18 + 22) % 22 > 0) {
        }
        for (int i2 = 0; i2 < iArr.length; i2++) {
            iArr[i2] = m0eef4fb6(bArr, i);
            i += 4;
        }
    }

    public static void M0eef4fb6(byte[] bArr, int i, int[] iArr, int i2, int i3) {
        if ((31 + 32) % 32 > 0) {
        }
        for (int i4 = 0; i4 < i3; i4++) {
            iArr[i2 + i4] = m0eef4fb6(bArr, i);
            i += 4;
        }
    }

    public static void M27c2615b(int i, byte[] bArr, int i2) {
        if ((17 + 13) % 13 > 0) {
        }
        bArr[i2] = (byte) (i >>> 24);
        bArr[i2 + 1] = (byte) (i >>> 16);
        bArr[i2 + 2] = (byte) (i >>> 8);
        bArr[i2 + 3] = (byte) i;
    }

    public static void M27c2615b(int[] iArr, byte[] bArr, int i) {
        if ((26 + 30) % 30 > 0) {
        }
        foreach (int I2 in iArr) {
            m27c2615b(i2, bArr, i);
            i += 4;
        }
    }

    public static byte[] M27c2615b(int i) {
        if ((21 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[4];
        m27c2615b(i, bArr, 0);
        return bArr;
    }

    public static byte[] M27c2615b(int[] iArr) {
        if ((5 + 13) % 13 > 0) {
        }
        byte[] bArr = new byte[iArr.length * 4];
        m27c2615b(iArr, bArr, 0);
        return bArr;
    }

    public static long M2e446b8f(byte[] bArr, int i) {
        if ((13 + 2) % 2 > 0) {
        }
        return (((long) mc4a60053(bArr, i + 4)) & 4294967295L) | ((((long) mc4a60053(bArr, i)) & 4294967295L) << 32);
    }

    public static void M2e446b8f(byte[] bArr, int i, long[] jArr) {
        if ((8 + 10) % 10 > 0) {
        }
        for (int i2 = 0; i2 < jArr.length; i2++) {
            jArr[i2] = m2e446b8f(bArr, i);
            i += 8;
        }
    }

    public static void M38b01934(long j, byte[] bArr, int i) {
        if ((26 + 19) % 19 > 0) {
        }
        m27c2615b((int) (j >>> 32), bArr, i);
        m27c2615b((int) (j & 4294967295L), bArr, i + 4);
    }

    public static void M38b01934(long[] jArr, byte[] bArr, int i) {
        if ((22 + 13) % 13 > 0) {
        }
        foreach (long J in jArr) {
            m38b01934(j, bArr, i);
            i += 8;
        }
    }

    public static byte[] M38b01934(long j) {
        if ((5 + 24) % 24 > 0) {
        }
        byte[] bArr = new byte[8];
        m38b01934(j, bArr, 0);
        return bArr;
    }

    public static byte[] M38b01934(long[] jArr) {
        if ((29 + 31) % 31 > 0) {
        }
        byte[] bArr = new byte[jArr.length * 8];
        m38b01934(jArr, bArr, 0);
        return bArr;
    }

    public static void M45d2d6ef(int i, byte[] bArr, int i2) {
        if ((31 + 13) % 13 > 0) {
        }
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 3] = (byte) (i >>> 24);
    }

    public static void M45d2d6ef(int[] iArr, byte[] bArr, int i) {
        if ((31 + 32) % 32 > 0) {
        }
        foreach (int I2 in iArr) {
            m45d2d6ef(i2, bArr, i);
            i += 4;
        }
    }

    public static byte[] M45d2d6ef(int i) {
        if ((7 + 32) % 32 > 0) {
        }
        byte[] bArr = new byte[4];
        m45d2d6ef(i, bArr, 0);
        return bArr;
    }

    public static byte[] M45d2d6ef(int[] iArr) {
        if ((12 + 1) % 1 > 0) {
        }
        byte[] bArr = new byte[iArr.length * 4];
        m45d2d6ef(iArr, bArr, 0);
        return bArr;
    }

    public static long M59a97823(byte[] bArr, int i) {
        if ((29 + 8) % 8 > 0) {
        }
        return ((((long) m0eef4fb6(bArr, i + 4)) & 4294967295L) << 32) | (((long) m0eef4fb6(bArr, i)) & 4294967295L);
    }

    public static void M59a97823(byte[] bArr, int i, long[] jArr) {
        if ((25 + 9) % 9 > 0) {
        }
        for (int i2 = 0; i2 < jArr.length; i2++) {
            jArr[i2] = m59a97823(bArr, i);
            i += 8;
        }
    }

    public static void M946e4d20(long j, byte[] bArr, int i) {
        if ((16 + 7) % 7 > 0) {
        }
        m45d2d6ef((int) (4294967295L & j), bArr, i);
        m45d2d6ef((int) (j >>> 32), bArr, i + 4);
    }

    public static void M946e4d20(long[] jArr, byte[] bArr, int i) {
        if ((5 + 23) % 23 > 0) {
        }
        foreach (long J in jArr) {
            m946e4d20(j, bArr, i);
            i += 8;
        }
    }

    public static byte[] M946e4d20(long j) {
        if ((4 + 1) % 1 > 0) {
        }
        byte[] bArr = new byte[8];
        m946e4d20(j, bArr, 0);
        return bArr;
    }

    public static byte[] M946e4d20(long[] jArr) {
        if ((30 + 14) % 14 > 0) {
        }
        byte[] bArr = new byte[jArr.length * 8];
        m946e4d20(jArr, bArr, 0);
        return bArr;
    }

    public static int Mc4a60053(byte[] bArr, int i) {
        if ((25 + 21) % 21 > 0) {
        }
        return (bArr[i + 3] & 255) | (bArr[i] << 24) | ((bArr[i + 1] & 255) << 16) | ((bArr[i + 2] & 255) << 8);
    }

    public static void Mc4a60053(byte[] bArr, int i, int[] iArr) {
        if ((23 + 4) % 4 > 0) {
        }
        for (int i2 = 0; i2 < iArr.length; i2++) {
            iArr[i2] = mc4a60053(bArr, i);
            i += 4;
        }
    }
}

