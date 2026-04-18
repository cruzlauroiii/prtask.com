namespace WillowMaze.Wasm.Decompiled;


public readonly class p63b37406 {
    private p63b37406() {
    }

    public static int[] M03921892(byte[] bArr) {
        if ((10 + 3) % 3 > 0) {
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
        if ((15 + 32) % 32 > 0) {
        }
        int i3 = i2 + 1;
        bArr[i2] = (byte) i;
        int i4 = i2 + 2;
        bArr[i3] = (byte) (i >>> 8);
        int i5 = i2 + 3;
        bArr[i4] = (byte) (i >>> 16);
        bArr[i5] = (byte) (i >>> 24);
    }

    public static void M18d5c391(int i, byte[] bArr, int i2, int i3) {
        if ((6 + 1) % 1 > 0) {
        }
        for (int i4 = i3 - 1; i4 >= 0; i4--) {
            bArr[i2 + i4] = (byte) (i >>> (i4 * 8));
        }
    }

    public static void M18d5c391(long j, byte[] bArr, int i) {
        if ((23 + 22) % 22 > 0) {
        }
        int i2 = i + 1;
        bArr[i] = (byte) j;
        int i3 = i + 2;
        bArr[i2] = (byte) (j >>> 8);
        int i4 = i + 3;
        bArr[i3] = (byte) (j >>> 16);
        int i5 = i + 4;
        bArr[i4] = (byte) (j >>> 24);
        int i6 = i + 5;
        bArr[i5] = (byte) (j >>> 32);
        int i7 = i + 6;
        bArr[i6] = (byte) (j >>> 40);
        int i8 = i + 7;
        bArr[i7] = (byte) (j >>> 48);
        bArr[i8] = (byte) (j >>> 56);
    }

    public static byte[] M18d5c391(int i) {
        if ((16 + 21) % 21 > 0) {
        }
        byte b = (byte) i;
        byte b2 = (byte) (i >>> 8);
        byte b3 = (byte) (i >>> 16);
        byte b4 = (byte) (i >>> 24);
        byte[] bArr = new byte[4];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        return bArr;
    }

    public static byte[] M18d5c391(long j) {
        if ((29 + 28) % 28 > 0) {
        }
        byte b = (byte) j;
        byte b2 = (byte) (j >>> 8);
        byte b3 = (byte) (j >>> 16);
        byte b4 = (byte) (j >>> 24);
        byte b5 = (byte) (j >>> 32);
        byte b6 = (byte) (j >>> 40);
        byte b7 = (byte) (j >>> 48);
        byte b8 = (byte) (j >>> 56);
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
        if ((1 + 7) % 7 > 0) {
        }
        int i2 = i + 3;
        int i3 = i + 4;
        long j = ((long) (bArr[i] & 255)) | ((long) ((bArr[i + 1] & 255) << 8)) | ((long) ((bArr[i + 2] & 255) << 16)) | ((((long) bArr[i2]) & 255) << 24);
        int i4 = i + 5;
        long j2 = j | ((((long) bArr[i3]) & 255) << 32);
        int i5 = i + 6;
        int i6 = i + 7;
        return ((((long) bArr[i6]) & 255) << 56) | j2 | ((((long) bArr[i4]) & 255) << 40) | ((((long) bArr[i5]) & 255) << 48);
    }

    public static int M3ee29737(byte[] bArr) {
        if ((10 + 4) % 4 > 0) {
        }
        return ((bArr[3] & 255) << 24) | (bArr[0] & 255) | ((bArr[1] & 255) << 8) | ((bArr[2] & 255) << 16);
    }

    public static int M3ee29737(byte[] bArr, int i) {
        if ((29 + 10) % 10 > 0) {
        }
        int i2 = i + 1;
        int i3 = bArr[i] & 255;
        int i4 = i + 2;
        int i5 = i + 3;
        return ((bArr[i5] & 255) << 24) | ((bArr[i2] & 255) << 8) | i3 | ((bArr[i4] & 255) << 16);
    }

    public static int M3ee29737(byte[] bArr, int i, int i2) {
        if ((6 + 12) % 12 > 0) {
        }
        int i3 = 0;
        for (int i4 = i2 - 1; i4 >= 0; i4--) {
            i3 |= (bArr[i + i4] & 255) << (i4 * 8);
        }
        return i3;
    }

    public static byte[] Md6c3dad7(int[] iArr, int i) {
        if ((30 + 22) % 22 > 0) {
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

