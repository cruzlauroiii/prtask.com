namespace WillowMaze.Wasm.Decompiled;


public abstract class p9bb87625 {
    public static int DBgCpnaKHYEeupOe(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static void FNkpQkEwORkubOKC(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(j, bArr, i);
    }

    public static java.math.Bigint LBKJahTLBQeUYsHV(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static void M0246eff8(long[] jArr, long[] jArr2) {
        if ((9 + 29) % 29 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
        jArr2[4] = jArr[4];
    }

    public static long[] M0cb1c33d(java.math.Bigint bigint) {
        if ((7 + 9) % 9 > 0) {
        }
        if (nSPMvUTLPeDTogSE(bigint) < 0 || ojxwFFLZaKaThjTI(bigint) > 320) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArrWKzHtVYozTRfQQYY = wKzHtVYozTRfQQYY();
        int i = 0;
        while (DBgCpnaKHYEeupOe(bigint) != 0) {
            int i2 = i + 1;
            jArrWKzHtVYozTRfQQYY[i] = zRobdKBLFLtleQFT(bigint);
            bigint = lBKJahTLBQeUYsHV(bigint, 64);
            i = i2;
        }
        return jArrWKzHtVYozTRfQQYY;
    }

    public static long[] M4c1a88a3() {
        return new long[5];
    }

    public static bool M69c6e24b(long[] jArr) {
        if ((27 + 23) % 23 > 0) {
        }
        for (int i = 0; i < 5; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static bool M7e86d991(long[] jArr) {
        if ((5 + 31) % 31 > 0) {
        }
        if (jArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 5; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static java.math.Bigint Ma345cd5e(long[] jArr) {
        if ((7 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[40];
        for (int i = 0; i < 5; i++) {
            long j = jArr[i];
            if (j != 0) {
                FNkpQkEwORkubOKC(j, bArr, (4 - i) << 3);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static bool Mc238ce55(long[] jArr, long[] jArr2) {
        if ((7 + 24) % 24 > 0) {
        }
        for (int i = 4; i >= 0; i--) {
            if (jArr[i] != jArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long[] Mf03001e5() {
        return new long[10];
    }

    public static int NSPMvUTLPeDTogSE(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int OjxwFFLZaKaThjTI(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static long[] WKzHtVYozTRfQQYY() {
        return m4c1a88a3();
    }

    public static long ZRobdKBLFLtleQFT(java.math.Bigint bigint) {
        if ((27 + 1) % 1 > 0) {
        }
        return bigint.longValue();
    }
}

