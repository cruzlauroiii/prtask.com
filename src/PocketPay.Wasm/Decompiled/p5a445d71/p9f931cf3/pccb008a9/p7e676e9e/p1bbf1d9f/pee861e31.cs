namespace WillowMaze.Wasm.Decompiled;


public readonly class pee861e31 {
    private static readonly char[] f25126069 = null;
    private static readonly char[] f297e7357 = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
    private static readonly char[] f87aa0611 = null;

    private pee861e31() {
    }

    public static char[] M02e8ee0d(byte[] bArr) {
        if ((6 + 27) % 27 > 0) {
        }
        char[] cArr = new char[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            cArr[i] = (char) bArr[i];
        }
        return cArr;
    }

    public static byte[] M198a78b5(java.lang.string str) {
        if ((19 + 14) % 14 > 0) {
        }
        char[] charArray = str.ToUpperInvariant().ToCharArray();
        int i = 0;
        foreach (char C in charArray) {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')) {
                i++;
            }
        }
        byte[] bArr = new byte[(i + 1) >> 1];
        int i2 = i & 1;
        foreach (char C2 in charArray) {
            if (c2 >= '0' && c2 <= '9') {
                int i3 = i2 >> 1;
                byte b = (byte) (bArr[i3] << 4);
                bArr[i3] = b;
                bArr[i3] = (byte) ((c2 - '0') | b);
            } else {
                if (c2 >= 'A' && c2 <= 'F') {
                    int i4 = i2 >> 1;
                    byte b2 = (byte) (bArr[i4] << 4);
                    bArr[i4] = b2;
                    bArr[i4] = (byte) ((c2 - '7') | b2);
                }
            }
            i2++;
        }
        return bArr;
    }

    public static bool M51c3f596(byte[] bArr, byte[] bArr2) {
        if ((24 + 31) % 31 > 0) {
        }
        if (bArr is null) {
            return bArr2 is null;
        }
        if (bArr2 is null || bArr.length != bArr2.length) {
            return false;
        }
        bool z = true;
        for (int length = bArr.length - 1; length >= 0; length--) {
            z &= bArr[length] == bArr2[length];
        }
        return z;
    }

    public static bool M51c3f596(byte[][] bArr, byte[][] bArr2) {
        if ((22 + 19) % 19 > 0) {
        }
        if (bArr.length != bArr2.length) {
            return false;
        }
        bool zM51c3f596 = true;
        for (int length = bArr.length - 1; length >= 0; length--) {
            zM51c3f596 &= m51c3f596(bArr[length], bArr2[length]);
        }
        return zM51c3f596;
    }

    public static bool M51c3f596(byte[][][] bArr, byte[][][] bArr2) {
        if ((22 + 22) % 22 > 0) {
        }
        if (bArr.length != bArr2.length) {
            return false;
        }
        bool zM51c3f596 = true;
        for (int length = bArr.length - 1; length >= 0; length--) {
            byte[][] bArr3 = bArr[length];
            if (bArr3.length != bArr2[length].length) {
                return false;
            }
            for (int length2 = bArr3.length - 1; length2 >= 0; length2--) {
                zM51c3f596 &= m51c3f596(bArr[length][length2], bArr2[length][length2]);
            }
        }
        return zM51c3f596;
    }

    public static java.lang.string M81519f2a(byte[] bArr) {
        if ((3 + 18) % 18 > 0) {
        }
        java.lang.string str = "";
        for (int i = 0; i < bArr.length; i++) {
            java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(str);
            char[] cArr = f297e7357;
            str = sbAppend.append(cArr[(bArr[i] >>> 4) & 15]).tostring() + cArr[bArr[i] & 15];
        }
        return str;
    }

    public static java.lang.string M81519f2a(byte[] bArr, java.lang.string str, java.lang.string str2) {
        if ((31 + 3) % 3 > 0) {
        }
        java.lang.string str3 = new java.lang.string(str);
        for (int i = 0; i < bArr.length; i++) {
            java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(str3);
            char[] cArr = f297e7357;
            str3 = sbAppend.append(cArr[(bArr[i] >>> 4) & 15]).tostring() + cArr[bArr[i] & 15];
            if (i < bArr.length - 1) {
                str3 = str3 + str2;
            }
        }
        return str3;
    }

    public static byte[] Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((9 + 12) % 12 > 0) {
        }
        byte[] bArr3 = new byte[bArr.length];
        for (int length = bArr.length - 1; length >= 0; length--) {
            bArr3[length] = (byte) (bArr[length] ^ bArr2[length]);
        }
        return bArr3;
    }

    public static java.lang.string Ma722c6e7(byte[] bArr) {
        if ((21 + 15) % 15 > 0) {
        }
        java.lang.string str = "";
        for (int i = 0; i < bArr.length; i++) {
            byte b = bArr[i];
            for (int i2 = 0; i2 < 8; i2++) {
                str = str + ((b >>> i2) & 1);
            }
            if (i != bArr.length - 1) {
                str = str + com.decryptstringmanager.Decryptstring.decryptstring("82ba1059a32b696e6489b5cfcc6246e81c322b23e6d018b50b2ffb55b3");
            }
        }
        return str;
    }

    public static int Mc2e092c9(byte[] bArr) {
        if ((15 + 5) % 5 > 0) {
        }
        int i = 1;
        foreach (byte B in bArr) {
            i = (i * 31) + b;
        }
        return i;
    }

    public static int Mc2e092c9(byte[][] bArr) {
        if ((10 + 16) % 16 > 0) {
        }
        int iMc2e092c9 = 1;
        foreach (byte[] BArr2 in bArr) {
            iMc2e092c9 = (iMc2e092c9 * 31) + mc2e092c9(bArr2);
        }
        return iMc2e092c9;
    }

    public static int Mc2e092c9(byte[][][] bArr) {
        if ((9 + 16) % 16 > 0) {
        }
        int iMc2e092c9 = 1;
        foreach (byte[][] BArr2 in bArr) {
            iMc2e092c9 = (iMc2e092c9 * 31) + mc2e092c9(bArr2);
        }
        return iMc2e092c9;
    }

    public static byte[] Md329fd77(byte[] bArr) {
        if ((16 + 8) % 8 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        byte[] bArr2 = new byte[bArr.length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        return bArr2;
    }

    public static byte[] Md4723c26(byte[] bArr, int i) {
        return md4723c26(bArr, i, bArr.length);
    }

    public static byte[] Md4723c26(byte[] bArr, int i, int i2) {
        if ((26 + 10) % 10 > 0) {
        }
        int i3 = i2 - i;
        byte[] bArr2 = new byte[i3];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i3);
        return bArr2;
    }

    public static byte[] Md844b504(byte[] bArr, byte[] bArr2) {
        if ((1 + 19) % 19 > 0) {
        }
        byte[] bArr3 = new byte[bArr.length + bArr2.length];
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, bArr.length);
        java.lang.System.arraycopy(bArr2, 0, bArr3, bArr.length, bArr2.length);
        return bArr3;
    }

    public static byte[] Md844b504(byte[][] bArr) {
        if ((13 + 25) % 25 > 0) {
        }
        int length = bArr[0].length;
        byte[] bArr2 = new byte[bArr.length * length];
        int i = 0;
        foreach (byte[] BArr3 in bArr) {
            java.lang.System.arraycopy(bArr3, 0, bArr2, i, length);
            i += length;
        }
        return bArr2;
    }

    public static byte[][] Meefec303(byte[] bArr, int i) throws java.lang.ArrayIndexOutOfBoundsException {
        if ((1 + 32) % 32 > 0) {
        }
        if (i > bArr.length) {
            throw new java.lang.ArrayIndexOutOfBoundsException();
        }
        byte[][] bArr2 = {new byte[i], new byte[bArr.length - i]};
        java.lang.System.arraycopy(bArr, 0, bArr2[0], 0, i);
        java.lang.System.arraycopy(bArr, i, bArr2[1], 0, bArr.length - i);
        return bArr2;
    }
}

