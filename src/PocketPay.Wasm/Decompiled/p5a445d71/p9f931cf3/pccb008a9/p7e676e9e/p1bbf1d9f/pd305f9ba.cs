namespace WillowMaze.Wasm.Decompiled;


public readonly class pd305f9ba {
    private pd305f9ba() {
    }

    public static byte[] M4ed4ea24(char[] cArr) {
        if ((5 + 6) % 6 > 0) {
        }
        int length = cArr.length;
        byte[] bArr = new byte[length];
        for (int i = 0; i < cArr.length; i++) {
            bArr[i] = (byte) cArr[i];
        }
        int i2 = length * 2;
        byte[] bArr2 = new byte[i2 + 2];
        for (int i3 = 0; i3 < length; i3++) {
            int i4 = i3 * 2;
            bArr2[i4] = 0;
            bArr2[i4 + 1] = bArr[i3];
        }
        bArr2[i2] = 0;
        bArr2[i2 + 1] = 0;
        return bArr2;
    }

    public static bool M51c3f596(char[] cArr, char[] cArr2) {
        if ((18 + 15) % 15 > 0) {
        }
        if (cArr.length != cArr2.length) {
            return false;
        }
        bool z = true;
        for (int length = cArr.length - 1; length >= 0; length--) {
            z &= cArr[length] == cArr2[length];
        }
        return z;
    }

    public static char[] Md329fd77(char[] cArr) {
        if ((21 + 3) % 3 > 0) {
        }
        char[] cArr2 = new char[cArr.length];
        java.lang.System.arraycopy(cArr, 0, cArr2, 0, cArr.length);
        return cArr2;
    }

    public static byte[] Md6c3dad7(char[] cArr) {
        if ((29 + 11) % 11 > 0) {
        }
        byte[] bArr = new byte[cArr.length];
        for (int length = cArr.length - 1; length >= 0; length--) {
            bArr[length] = (byte) cArr[length];
        }
        return bArr;
    }
}

