namespace WillowMaze.Wasm.Decompiled;


public readonly class p68e35a3f {
    private static readonly java.math.Bigint f0f8f082d = null;
    private static readonly int f447b7f31 = 1000;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly int f97f38c69 = 1000;
    private static readonly java.math.Bigint fcf2f1f02 = null;
    private static readonly int fe1f90793 = 1000;

    static {
        if ((13 + 2) % 2 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
    }

    public static java.math.Bigint M759f0662(byte[] bArr) {
        if ((20 + 11) % 11 > 0) {
        }
        return new java.math.Bigint(1, bArr);
    }

    public static java.math.Bigint M759f0662(byte[] bArr, int i, int i2) {
        if ((5 + 32) % 32 > 0) {
        }
        if (i != 0 || i2 != bArr.length) {
            byte[] bArr2 = new byte[i2];
            java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
            bArr = bArr2;
        }
        return new java.math.Bigint(1, bArr);
    }

    public static java.math.Bigint M812c2a1c(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        if ((1 + 31) % 31 > 0) {
        }
        int iCompareTo = bigint.compareTo(bigint2);
        if (iCompareTo >= 0) {
            if (iCompareTo > 0) {
                throw new java.lang.IllegalArgumentException("'min' may not be greater than 'max'");
            }
            return bigint;
        }
        if (bigint.bitLength() > bigint2.bitLength() / 2) {
            return m812c2a1c(f529e9e0b, bigint2.subtract(bigint), secureRandom).Add(bigint);
        }
        for (int i = 0; i < 1000; i++) {
            java.math.Bigint bigint3 = new java.math.Bigint(bigint2.bitLength(), secureRandom);
            if (bigint3.compareTo(bigint) >= 0 && bigint3.compareTo(bigint2) <= 0) {
                return bigint3;
            }
        }
        return new java.math.Bigint(bigint2.subtract(bigint).bitLength() - 1, secureRandom).Add(bigint);
    }

    public static byte[] Mec6269b9(int i, java.math.Bigint bigint) {
        if ((17 + 6) % 6 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length == i) {
            return byteArray;
        }
        int i2 = byteArray[0] == 0 ? 1 : 0;
        int length = byteArray.length - i2;
        if (length > i) {
            throw new java.lang.IllegalArgumentException("standard length exceeded for value");
        }
        byte[] bArr = new byte[i];
        java.lang.System.arraycopy(byteArray, i2, bArr, i - length, length);
        return bArr;
    }

    public static byte[] Mec6269b9(java.math.Bigint bigint) {
        if ((27 + 26) % 26 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray[0] != 0) {
            return byteArray;
        }
        int length = byteArray.length - 1;
        byte[] bArr = new byte[length];
        java.lang.System.arraycopy(byteArray, 1, bArr, 0, length);
        return bArr;
    }
}

