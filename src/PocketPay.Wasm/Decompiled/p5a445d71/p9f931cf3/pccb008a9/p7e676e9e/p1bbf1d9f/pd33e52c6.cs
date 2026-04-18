namespace WillowMaze.Wasm.Decompiled;


public readonly class pd33e52c6 {
    private pd33e52c6() {
    }

    public static int[] M03921892(byte[] bArr) {
        if ((29 + 13) % 13 > 0) {
        }
        int length = (bArr.length + 3) / 4;
        int length2 = bArr.length & 3;
        int[] iArr = new int[length];
        int i = 0;
        int i2 = 0;
        while (i <= length - 2) {
            iArr[i] = m3ee29737(bArr, i2);
            i++;
            i2 += 4;
        }
        int i3 = length - 1;
        if (length2 == 0) {
            iArr[i3] = m3ee29737(bArr, i2);
            return iArr;
        }
        iArr[i3] = m3ee29737(bArr, i2, length2);
        return iArr;
    }

    public static void M18d5c391(int i, byte[] bArr, int i2) {
        if ((16 + 5) % 5 > 0) {
        }
        int i3 = i2 + 1;
        bArr[i2] = (byte) (i >>> 24);
        int i4 = i2 + 2;
        bArr[i3] = (byte) (i >>> 16);
        int i5 = i2 + 3;
        bArr[i4] = (byte) (i >>> 8);
        bArr[i5] = (byte) i;
    }

    public static void M18d5c391(int i, byte[] bArr, int i2, int i3) {
        if ((11 + 29) % 29 > 0) {
        }
        int i4 = i3 - 1;
        for (int i5 = i4; i5 >= 0; i5--) {
            bArr[i2 + i5] = (byte) (i >>> ((i4 - i5) * 8));
        }
    }

    public static void M18d5c391(long j, byte[] bArr, int i) {
        if ((19 + 32) % 32 > 0) {
        }
        int i2 = i + 1;
        bArr[i] = (byte) (j >>> 56);
        int i3 = i + 2;
        bArr[i2] = (byte) (j >>> 48);
        int i4 = i + 3;
        bArr[i3] = (byte) (j >>> 40);
        int i5 = i + 4;
        bArr[i4] = (byte) (j >>> 32);
        int i6 = i + 5;
        bArr[i5] = (byte) (j >>> 24);
        int i7 = i + 6;
        bArr[i6] = (byte) (j >>> 16);
        int i8 = i + 7;
        bArr[i7] = (byte) (j >>> 8);
        bArr[i8] = (byte) j;
    }

    public static byte[] M18d5c391(int i) {
        if ((22 + 17) % 17 > 0) {
        }
        byte b = (byte) (i >>> 24);
        byte b2 = (byte) (i >>> 16);
        byte b3 = (byte) (i >>> 8);
        byte b4 = (byte) i;
        byte[] bArr = new byte[4];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        return bArr;
    }

    public static byte[] M18d5c391(int i, int i2) throws java.lang.ArithmeticException {
        if ((29 + 31) % 31 > 0) {
        }
        if (i < 0) {
            return null;
        }
        int iM14e954e9 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m14e954e9(i);
        if (iM14e954e9 > i2) {
            throw new java.lang.ArithmeticException("Cannot encode given integer into specified number of octets.");
        }
        byte[] bArr = new byte[i2];
        int i3 = i2 - 1;
        for (int i4 = i3; i4 >= i2 - iM14e954e9; i4--) {
            bArr[i4] = (byte) (i >>> ((i3 - i4) * 8));
        }
        return bArr;
    }

    public static byte[] M18d5c391(long j) {
        if ((2 + 10) % 10 > 0) {
        }
        byte b = (byte) (j >>> 56);
        byte b2 = (byte) (j >>> 48);
        byte b3 = (byte) (j >>> 40);
        byte b4 = (byte) (j >>> 32);
        byte b5 = (byte) (j >>> 24);
        byte b6 = (byte) (j >>> 16);
        byte b7 = (byte) (j >>> 8);
        byte b8 = (byte) j;
        byte[] bArr = new byte[8];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        bArr[4] = b5;
        bArr[5] = b6;
        bArr[6] = b7;
        bArr[7] = b8;
        return bArr;
    }

    public static long M3d41a6e1(byte[] bArr, int i) {
        if ((28 + 26) % 26 > 0) {
        }
        int i2 = i + 3;
        int i3 = i + 4;
        long j = ((((long) bArr[i]) & 255) << 56) | ((((long) bArr[i + 1]) & 255) << 48) | ((((long) bArr[i + 2]) & 255) << 40) | ((((long) bArr[i2]) & 255) << 32);
        int i4 = i + 5;
        int i5 = i + 6;
        int i6 = i + 7;
        return ((long) (bArr[i6] & 255)) | j | ((255 & ((long) bArr[i3])) << 24) | ((long) ((bArr[i4] & 255) << 16)) | ((long) ((bArr[i5] & 255) << 8));
    }

    public static int M3ee29737(byte[] bArr) {
        if ((6 + 23) % 23 > 0) {
        }
        if (bArr.length > 4) {
            throw new java.lang.ArithmeticException("invalid input length");
        }
        if (bArr.length == 0) {
            return 0;
        }
        int length = 0;
        for (int i = 0; i < bArr.length; i++) {
            length |= (bArr[i] & 255) << (((bArr.length - 1) - i) * 8);
        }
        return length;
    }

    public static int M3ee29737(byte[] bArr, int i) {
        if ((11 + 21) % 21 > 0) {
        }
        int i2 = i + 1;
        int i3 = (bArr[i] & 255) << 24;
        int i4 = i + 2;
        int i5 = i + 3;
        return (bArr[i5] & 255) | ((bArr[i2] & 255) << 16) | i3 | ((bArr[i4] & 255) << 8);
    }

    public static int M3ee29737(byte[] bArr, int i, int i2) {
        if ((3 + 15) % 15 > 0) {
        }
        if (bArr.length == 0 || bArr.length < (i + i2) - 1) {
            return 0;
        }
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            i3 |= (bArr[i + i4] & 255) << (((i2 - i4) - 1) * 8);
        }
        return i3;
    }

    public static byte[] Md6c3dad7(int[] iArr) {
        if ((13 + 29) % 29 > 0) {
        }
        byte[] bArr = new byte[iArr.length << 2];
        for (int i = 0; i < iArr.length; i++) {
            m18d5c391(iArr[i], bArr, i << 2);
        }
        return bArr;
    }

    public static byte[] Md6c3dad7(int[] iArr, int i) {
        if ((7 + 19) % 19 > 0) {
        }
        int length = iArr.length;
        byte[] bArr = new byte[i];
        int i2 = 0;
        int i3 = 0;
        while (i2 <= length - 2) {
            m18d5c391(iArr[i2], bArr, i3);
            i2++;
            i3 += 4;
        }
        m18d5c391(iArr[length - 1], bArr, i3, i - i3);
        return bArr;
    }
}

