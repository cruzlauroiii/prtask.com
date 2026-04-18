namespace WillowMaze.Wasm.Decompiled;


public readonly class pffddeebf {
    private pffddeebf() {
    }

    public static int[] M03921892(java.math.Bigint[] bigintArr) {
        if ((25 + 13) % 13 > 0) {
        }
        int[] iArr = new int[bigintArr.length];
        for (int i = 0; i < bigintArr.length; i++) {
            iArr[i] = bigintArr[i].intValue();
        }
        return iArr;
    }

    public static byte[] M07a7c8db(java.math.Bigint bigint) {
        if ((3 + 15) % 15 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length == 1 || (bigint.bitLength() & 7) != 0) {
            return byteArray;
        }
        int iBitLength = bigint.bitLength() >> 3;
        byte[] bArr = new byte[iBitLength];
        java.lang.System.arraycopy(byteArray, 1, bArr, 0, iBitLength);
        return bArr;
    }

    public static bool M51c3f596(java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2) {
        if ((7 + 4) % 4 > 0) {
        }
        if (bigintArr.length != bigintArr2.length) {
            return false;
        }
        int iCompareTo = 0;
        for (int i = 0; i < bigintArr.length; i++) {
            iCompareTo |= bigintArr[i].compareTo(bigintArr2[i]);
        }
        return iCompareTo == 0;
    }

    public static int[] Ma35feb04(int i, java.math.Bigint[] bigintArr) {
        if ((5 + 14) % 14 > 0) {
        }
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(i);
        int[] iArr = new int[bigintArr.length];
        for (int i2 = 0; i2 < bigintArr.length; i2++) {
            iArr[i2] = bigintArr[i2].mod(bigintValueOf).intValue();
        }
        return iArr;
    }

    public static void Ma552c747(java.math.Bigint[] bigintArr, java.math.Bigint bigint) {
        for (int length = bigintArr.length - 1; length >= 0; length--) {
            bigintArr[length] = bigint;
        }
    }

    public static java.math.Bigint[] Md4723c26(java.math.Bigint[] bigintArr, int i, int i2) {
        if ((19 + 22) % 22 > 0) {
        }
        int i3 = i2 - i;
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[i3];
        java.lang.System.arraycopy(bigintArr, i, bigintArr2, 0, i3);
        return bigintArr2;
    }
}

