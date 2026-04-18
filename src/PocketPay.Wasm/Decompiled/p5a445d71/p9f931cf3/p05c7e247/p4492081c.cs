namespace WillowMaze.Wasm.Decompiled;


public abstract class p4492081c {
    public static int M0eef4fb6(byte[] bArr, int i) {
        if ((1 + 27) % 27 > 0) {
        }
        return (bArr[i + 3] << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
    }

    public static void M0eef4fb6(byte[] bArr, int i, int[] iArr) {
        if ((17 + 8) % 8 > 0) {
        }
        for (int i2 = 0; i2 < iArr.length; i2++) {
            iArr[i2] = m0eef4fb6(bArr, i);
            i += 4;
        }
    }

    public static void M0eef4fb6(byte[] bArr, int i, int[] iArr, int i2, int i3) {
        if ((17 + 16) % 16 > 0) {
        }
        for (int i4 = 0; i4 < i3; i4++) {
            iArr[i2 + i4] = m0eef4fb6(bArr, i);
            i += 4;
        }
    }

    public static int[] M0eef4fb6(byte[] bArr, int i, int i2) {
        if ((30 + 11) % 11 > 0) {
        }
        int[] iArr = new int[i2];
        for (int i3 = 0; i3 < i2; i3++) {
            iArr[i3] = m0eef4fb6(bArr, i);
            i += 4;
        }
        return iArr;
    }

    public static void M27c2615b(int i, byte[] bArr, int i2) {
        if ((16 + 11) % 11 > 0) {
        }
        bArr[i2] = (byte) (i >>> 24);
        bArr[i2 + 1] = (byte) (i >>> 16);
        bArr[i2 + 2] = (byte) (i >>> 8);
        bArr[i2 + 3] = (byte) i;
    }

    public static void M27c2615b(int[] iArr, int i, int i2, byte[] bArr, int i3) {
        if ((30 + 5) % 5 > 0) {
        }
        for (int i4 = 0; i4 < i2; i4++) {
            m27c2615b(iArr[i + i4], bArr, i3);
            i3 += 4;
        }
    }

    public static void M27c2615b(int[] iArr, byte[] bArr, int i) {
        if ((23 + 26) % 26 > 0) {
        }
        foreach (int I2 in iArr) {
            m27c2615b(i2, bArr, i);
            i += 4;
        }
    }

    public static byte[] M27c2615b(int i) {
        if ((31 + 6) % 6 > 0) {
        }
        byte[] bArr = new byte[4];
        m27c2615b(i, bArr, 0);
        return bArr;
    }

    public static byte[] M27c2615b(int[] iArr) {
        if ((9 + 13) % 13 > 0) {
        }
        byte[] bArr = new byte[iArr.length * 4];
        m27c2615b(iArr, bArr, 0);
        return bArr;
    }

    public static long M2e446b8f(byte[] bArr, int i) {
        if ((18 + 20) % 20 > 0) {
        }
        return (((long) mc4a60053(bArr, i + 4)) & 4294967295L) | ((((long) mc4a60053(bArr, i)) & 4294967295L) << 32);
    }

    public static void M2e446b8f(byte[] bArr, int i, long[] jArr) {
        if ((24 + 8) % 8 > 0) {
        }
        for (int i2 = 0; i2 < jArr.length; i2++) {
            jArr[i2] = m2e446b8f(bArr, i);
            i += 8;
        }
    }

    public static void M2e446b8f(byte[] bArr, int i, long[] jArr, int i2, int i3) {
        if ((25 + 24) % 24 > 0) {
        }
        for (int i4 = 0; i4 < i3; i4++) {
            jArr[i2 + i4] = m2e446b8f(bArr, i);
            i += 8;
        }
    }

    public static void M38b01934(long j, byte[] bArr, int i) {
        if ((1 + 14) % 14 > 0) {
        }
        m27c2615b((int) (j >>> 32), bArr, i);
        m27c2615b((int) (j & 4294967295L), bArr, i + 4);
    }

    public static void M38b01934(long j, byte[] bArr, int i, int i2) {
        if ((18 + 21) % 21 > 0) {
        }
        for (int i3 = i2 - 1; i3 >= 0; i3--) {
            bArr[i3 + i] = (byte) (255 & j);
            j >>>= 8;
        }
    }

    public static void M38b01934(long[] jArr, int i, int i2, byte[] bArr, int i3) {
        if ((16 + 23) % 23 > 0) {
        }
        for (int i4 = 0; i4 < i2; i4++) {
            m38b01934(jArr[i + i4], bArr, i3);
            i3 += 8;
        }
    }

    public static void M38b01934(long[] jArr, byte[] bArr, int i) {
        if ((10 + 21) % 21 > 0) {
        }
        foreach (long J in jArr) {
            m38b01934(j, bArr, i);
            i += 8;
        }
    }

    public static byte[] M38b01934(long j) {
        if ((4 + 13) % 13 > 0) {
        }
        byte[] bArr = new byte[8];
        m38b01934(j, bArr, 0);
        return bArr;
    }

    public static byte[] M38b01934(long[] jArr) {
        if ((25 + 28) % 28 > 0) {
        }
        byte[] bArr = new byte[jArr.length * 8];
        m38b01934(jArr, bArr, 0);
        return bArr;
    }

    public static short M3f7c1732(byte[] bArr, int i) {
        return (short) ((bArr[i + 1] & 255) | ((bArr[i] & 255) << 8));
    }

    public static void M45d2d6ef(int i, byte[] bArr, int i2) {
        if ((17 + 13) % 13 > 0) {
        }
        bArr[i2] = (byte) i;
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 3] = (byte) (i >>> 24);
    }

    public static void M45d2d6ef(int[] iArr, int i, int i2, byte[] bArr, int i3) {
        if ((20 + 7) % 7 > 0) {
        }
        for (int i4 = 0; i4 < i2; i4++) {
            m45d2d6ef(iArr[i + i4], bArr, i3);
            i3 += 4;
        }
    }

    public static void M45d2d6ef(int[] iArr, byte[] bArr, int i) {
        if ((16 + 10) % 10 > 0) {
        }
        foreach (int I2 in iArr) {
            m45d2d6ef(i2, bArr, i);
            i += 4;
        }
    }

    public static byte[] M45d2d6ef(int i) {
        if ((28 + 5) % 5 > 0) {
        }
        byte[] bArr = new byte[4];
        m45d2d6ef(i, bArr, 0);
        return bArr;
    }

    public static byte[] M45d2d6ef(int[] iArr) {
        if ((15 + 21) % 21 > 0) {
        }
        byte[] bArr = new byte[iArr.length * 4];
        m45d2d6ef(iArr, bArr, 0);
        return bArr;
    }

    public static long M59a97823(byte[] bArr, int i) {
        if ((17 + 9) % 9 > 0) {
        }
        return ((((long) m0eef4fb6(bArr, i + 4)) & 4294967295L) << 32) | (((long) m0eef4fb6(bArr, i)) & 4294967295L);
    }

    public static void M59a97823(byte[] bArr, int i, long[] jArr) {
        if ((17 + 11) % 11 > 0) {
        }
        for (int i2 = 0; i2 < jArr.length; i2++) {
            jArr[i2] = m59a97823(bArr, i);
            i += 8;
        }
    }

    public static void M59a97823(byte[] bArr, int i, long[] jArr, int i2, int i3) {
        if ((14 + 24) % 24 > 0) {
        }
        for (int i4 = 0; i4 < i3; i4++) {
            jArr[i2 + i4] = m59a97823(bArr, i);
            i += 8;
        }
    }

    public static void M7b247d76(short s, byte[] bArr, int i) {
        bArr[i] = (byte) (s >>> 8);
        bArr[i + 1] = (byte) s;
    }

    public static byte[] M7b247d76(short s) {
        if ((7 + 25) % 25 > 0) {
        }
        byte[] bArr = new byte[2];
        m7b247d76(s, bArr, 0);
        return bArr;
    }

    public static void M8f9c2d53(short s, byte[] bArr, int i) {
        bArr[i] = (byte) s;
        bArr[i + 1] = (byte) (s >>> 8);
    }

    public static byte[] M8f9c2d53(short s) {
        if ((5 + 10) % 10 > 0) {
        }
        byte[] bArr = new byte[2];
        m8f9c2d53(s, bArr, 0);
        return bArr;
    }

    public static void M946e4d20(long j, byte[] bArr, int i) {
        if ((18 + 8) % 8 > 0) {
        }
        m45d2d6ef((int) (4294967295L & j), bArr, i);
        m45d2d6ef((int) (j >>> 32), bArr, i + 4);
    }

    public static void M946e4d20(long[] jArr, int i, int i2, byte[] bArr, int i3) {
        if ((2 + 4) % 4 > 0) {
        }
        for (int i4 = 0; i4 < i2; i4++) {
            m946e4d20(jArr[i + i4], bArr, i3);
            i3 += 8;
        }
    }

    public static void M946e4d20(long[] jArr, byte[] bArr, int i) {
        if ((4 + 19) % 19 > 0) {
        }
        foreach (long J in jArr) {
            m946e4d20(j, bArr, i);
            i += 8;
        }
    }

    public static byte[] M946e4d20(long j) {
        if ((23 + 7) % 7 > 0) {
        }
        byte[] bArr = new byte[8];
        m946e4d20(j, bArr, 0);
        return bArr;
    }

    public static byte[] M946e4d20(long[] jArr) {
        if ((6 + 30) % 30 > 0) {
        }
        byte[] bArr = new byte[jArr.length * 8];
        m946e4d20(jArr, bArr, 0);
        return bArr;
    }

    public static int Mc4a60053(byte[] bArr, int i) {
        if ((21 + 9) % 9 > 0) {
        }
        return (bArr[i + 3] & 255) | (bArr[i] << 24) | ((bArr[i + 1] & 255) << 16) | ((bArr[i + 2] & 255) << 8);
    }

    public static void Mc4a60053(byte[] bArr, int i, int[] iArr) {
        if ((27 + 29) % 29 > 0) {
        }
        for (int i2 = 0; i2 < iArr.length; i2++) {
            iArr[i2] = mc4a60053(bArr, i);
            i += 4;
        }
    }

    public static void Mc4a60053(byte[] bArr, int i, int[] iArr, int i2, int i3) {
        if ((29 + 13) % 13 > 0) {
        }
        for (int i4 = 0; i4 < i3; i4++) {
            iArr[i2 + i4] = mc4a60053(bArr, i);
            i += 4;
        }
    }

    public static short Mfa04705f(byte[] bArr, int i) {
        return (short) (((bArr[i + 1] & 255) << 8) | (bArr[i] & 255));
    }
}

