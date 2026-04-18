namespace WillowMaze.Wasm.Decompiled;


public abstract class p40bd9e0a {
    public static long DIWAKwtrHSLEddsc(java.math.Bigint bigint) {
        if ((25 + 13) % 13 > 0) {
        }
        return bigint.longValue();
    }

    public static int WYqtqFTztjkLnsAm(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int DoVSiaLXETzzeJNh(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static java.math.Bigint LEXTulkVkoKpjGjY(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static void M0246eff8(long[] jArr, long[] jArr2) {
        if ((4 + 30) % 30 > 0) {
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
        if ((14 + 25) % 25 > 0) {
        }
        if (WYqtqFTztjkLnsAm(bigint) < 0 || vLjOFzlikHWHCqWt(bigint) > 576) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArrVYoDwcoMbmPiQyKL = vYoDwcoMbmPiQyKL();
        int i = 0;
        while (doVSiaLXETzzeJNh(bigint) != 0) {
            int i2 = i + 1;
            jArrVYoDwcoMbmPiQyKL[i] = DIWAKwtrHSLEddsc(bigint);
            bigint = lEXTulkVkoKpjGjY(bigint, 64);
            i = i2;
        }
        return jArrVYoDwcoMbmPiQyKL;
    }

    public static long[] M4c1a88a3() {
        return new long[9];
    }

    public static bool M69c6e24b(long[] jArr) {
        if ((3 + 11) % 11 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static bool M7e86d991(long[] jArr) {
        if ((22 + 6) % 6 > 0) {
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
        if ((4 + 21) % 21 > 0) {
        }
        byte[] bArr = new byte[72];
        for (int i = 0; i < 9; i++) {
            long j = jArr[i];
            if (j != 0) {
                xnTtyANKzEpWejiH(j, bArr, (8 - i) << 3);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static bool Mc238ce55(long[] jArr, long[] jArr2) {
        if ((6 + 16) % 16 > 0) {
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

    public static int VLjOFzlikHWHCqWt(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static long[] VYoDwcoMbmPiQyKL() {
        return m4c1a88a3();
    }

    public static void XnTtyANKzEpWejiH(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(j, bArr, i);
    }
}

