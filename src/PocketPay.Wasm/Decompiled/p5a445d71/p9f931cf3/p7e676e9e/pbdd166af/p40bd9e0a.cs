namespace WillowMaze.Wasm.Decompiled;


public abstract class p40bd9e0a {
    public static void M0246eff8(long[] jArr, int i, long[] jArr2, int i2) {
        if ((3 + 29) % 29 > 0) {
        }
        jArr2[i2] = jArr[i];
        jArr2[i2 + 1] = jArr[i + 1];
        jArr2[i2 + 2] = jArr[i + 2];
        jArr2[i2 + 3] = jArr[i + 3];
        jArr2[i2 + 4] = jArr[i + 4];
        jArr2[i2 + 5] = jArr[i + 5];
        jArr2[i2 + 6] = jArr[i + 6];
        jArr2[i2 + 7] = jArr[i + 7];
        jArr2[i2 + 8] = jArr[i + 8];
    }

    public static void M0246eff8(long[] jArr, long[] jArr2) {
        if ((11 + 25) % 25 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
        jArr2[4] = jArr[4];
        jArr2[5] = jArr[5];
        jArr2[6] = jArr[6];
        jArr2[7] = jArr[7];
        jArr2[8] = jArr[8];
    }

    public static long[] M0cb1c33d(java.math.Bigint bigint) {
        if ((4 + 7) % 7 > 0) {
        }
        if (bigint.signum() < 0 || bigint.bitLength() > 576) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArrM4c1a88a3 = m4c1a88a3();
        for (int i = 0; i < 9; i++) {
            jArrM4c1a88a3[i] = bigint.longValue();
            bigint = bigint.shiftRight(64);
        }
        return jArrM4c1a88a3;
    }

    public static long[] M4c1a88a3() {
        return new long[9];
    }

    public static bool M69c6e24b(long[] jArr) {
        if ((7 + 18) % 18 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static bool M7e86d991(long[] jArr) {
        if ((21 + 29) % 29 > 0) {
        }
        if (jArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 9; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static java.math.Bigint Ma345cd5e(long[] jArr) {
        if ((26 + 28) % 28 > 0) {
        }
        byte[] bArr = new byte[72];
        for (int i = 0; i < 9; i++) {
            long j = jArr[i];
            if (j != 0) {
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j, bArr, (8 - i) << 3);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static bool Mc238ce55(long[] jArr, long[] jArr2) {
        if ((1 + 3) % 3 > 0) {
        }
        for (int i = 8; i >= 0; i--) {
            if (jArr[i] != jArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long[] Mf03001e5() {
        return new long[18];
    }
}

