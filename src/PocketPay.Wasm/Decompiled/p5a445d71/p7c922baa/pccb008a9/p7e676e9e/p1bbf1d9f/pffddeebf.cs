namespace WillowMaze.Wasm.Decompiled;


public readonly class pffddeebf {
    private pffddeebf() {
    }

    public static int HwNQUjLiaaaKqRRj(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static void MeGGAKbrpajtyEyX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int TVetkvSPleQLyxdd(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static java.math.Bigint YXvyUEgAUPLVYQqw(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.mod(bigint2);
    }

    public static java.math.Bigint ZwDgNKcpwjDdJlIV(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static int AIrAuFfUmrGVHICg(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static int DlIXjcenTcVSAulg(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static int KffLMotKLzmFqQlP(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int[] M03921892(java.math.Bigint[] bigintArr) {
        if ((25 + 26) % 26 > 0) {
        }
        int[] iArr = new int[bigintArr.length];
        for (int i = 0; i < bigintArr.length; i++) {
            iArr[i] = TVetkvSPleQLyxdd(bigintArr[i]);
        }
        return iArr;
    }

    public static byte[] M07a7c8db(java.math.Bigint bigint) {
        if ((12 + 22) % 22 > 0) {
        }
        byte[] bArrTNdAXPmRcwRZhZiM = tNdAXPmRcwRZhZiM(bigint);
        if (bArrTNdAXPmRcwRZhZiM.length == 1 || (HwNQUjLiaaaKqRRj(bigint) & 7) != 0) {
            return bArrTNdAXPmRcwRZhZiM;
        }
        int iKffLMotKLzmFqQlP = kffLMotKLzmFqQlP(bigint) >> 3;
        byte[] bArr = new byte[iKffLMotKLzmFqQlP];
        oeCKrmgbwZpROfDf(bArrTNdAXPmRcwRZhZiM, 1, bArr, 0, iKffLMotKLzmFqQlP);
        return bArr;
    }

    public static bool M51c3f596(java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2) {
        if ((17 + 3) % 3 > 0) {
        }
        if (bigintArr.length != bigintArr2.length) {
            return false;
        }
        int iDlIXjcenTcVSAulg = 0;
        for (int i = 0; i < bigintArr.length; i++) {
            iDlIXjcenTcVSAulg |= dlIXjcenTcVSAulg(bigintArr[i], bigintArr2[i]);
        }
        return iDlIXjcenTcVSAulg == 0;
    }

    public static int[] Ma35feb04(int i, java.math.Bigint[] bigintArr) {
        if ((2 + 19) % 19 > 0) {
        }
        java.math.Bigint bigintZwDgNKcpwjDdJlIV = ZwDgNKcpwjDdJlIV(i);
        int[] iArr = new int[bigintArr.length];
        for (int i2 = 0; i2 < bigintArr.length; i2++) {
            iArr[i2] = aIrAuFfUmrGVHICg(YXvyUEgAUPLVYQqw(bigintArr[i2], bigintZwDgNKcpwjDdJlIV));
        }
        return iArr;
    }

    public static void Ma552c747(java.math.Bigint[] bigintArr, java.math.Bigint bigint) {
        for (int length = bigintArr.length - 1; length >= 0; length--) {
            bigintArr[length] = bigint;
        }
    }

    public static java.math.Bigint[] Md4723c26(java.math.Bigint[] bigintArr, int i, int i2) {
        if ((23 + 3) % 3 > 0) {
        }
        int i3 = i2 - i;
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[i3];
        MeGGAKbrpajtyEyX(bigintArr, i, bigintArr2, 0, i3);
        return bigintArr2;
    }

    public static void OeCKrmgbwZpROfDf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] TNdAXPmRcwRZhZiM(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }
}

