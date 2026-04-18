namespace WillowMaze.Wasm.Decompiled;


public class p104efdf0 {
    public static bool M51c3f596(short[] sArr, short[] sArr2) {
        if ((10 + 14) % 14 > 0) {
        }
        if (sArr.length != sArr2.length) {
            return false;
        }
        bool z = true;
        for (int length = sArr.length - 1; length >= 0; length--) {
            z &= sArr[length] == sArr2[length];
        }
        return z;
    }

    public static bool M51c3f596(short[][] sArr, short[][] sArr2) {
        if ((22 + 7) % 7 > 0) {
        }
        if (sArr.length != sArr2.length) {
            return false;
        }
        bool zM51c3f596 = true;
        for (int length = sArr.length - 1; length >= 0; length--) {
            zM51c3f596 &= m51c3f596(sArr[length], sArr2[length]);
        }
        return zM51c3f596;
    }

    public static bool M51c3f596(short[][][] sArr, short[][][] sArr2) {
        if ((25 + 12) % 12 > 0) {
        }
        if (sArr.length != sArr2.length) {
            return false;
        }
        bool zM51c3f596 = true;
        for (int length = sArr.length - 1; length >= 0; length--) {
            zM51c3f596 &= m51c3f596(sArr[length], sArr2[length]);
        }
        return zM51c3f596;
    }

    public static byte[] M6aceb6ef(int[] iArr) {
        if ((6 + 25) % 25 > 0) {
        }
        byte[] bArr = new byte[iArr.length];
        for (int i = 0; i < iArr.length; i++) {
            bArr[i] = (byte) iArr[i];
        }
        return bArr;
    }

    public static int[] M85a9e095(byte[] bArr) {
        if ((4 + 21) % 21 > 0) {
        }
        int[] iArr = new int[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            iArr[i] = bArr[i] & 255;
        }
        return iArr;
    }

    public static byte[] Me2d26373(short[] sArr) {
        if ((25 + 24) % 24 > 0) {
        }
        byte[] bArr = new byte[sArr.length];
        for (int i = 0; i < sArr.length; i++) {
            bArr[i] = (byte) sArr[i];
        }
        return bArr;
    }

    public static short[] Me2d26373(byte[] bArr) {
        if ((4 + 10) % 10 > 0) {
        }
        short[] sArr = new short[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            sArr[i] = (short) (bArr[i] & 255);
        }
        return sArr;
    }

    public static byte[][] Me2d26373(short[][] sArr) {
        if ((32 + 26) % 26 > 0) {
        }
        int length = sArr.length;
        int[] iArr = new int[2];
        iArr[1] = sArr[0].length;
        iArr[0] = length;
        byte[][] bArr = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr[0].length; i2++) {
                bArr[i][i2] = (byte) sArr[i][i2];
            }
        }
        return bArr;
    }

    public static short[][] Me2d26373(byte[][] bArr) {
        if ((16 + 18) % 18 > 0) {
        }
        int length = bArr.length;
        int[] iArr = new int[2];
        iArr[1] = bArr[0].length;
        iArr[0] = length;
        short[][] sArr = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        for (int i = 0; i < bArr.length; i++) {
            for (int i2 = 0; i2 < bArr[0].length; i2++) {
                sArr[i][i2] = (short) (bArr[i][i2] & 255);
            }
        }
        return sArr;
    }

    public static byte[][][] Me2d26373(short[][][] sArr) {
        if ((3 + 11) % 11 > 0) {
        }
        int length = sArr.length;
        short[][] sArr2 = sArr[0];
        int length2 = sArr2.length;
        int[] iArr = new int[3];
        iArr[2] = sArr2[0].length;
        iArr[1] = length2;
        iArr[0] = length;
        byte[][][] bArr = (byte[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr[0].length; i2++) {
                for (int i3 = 0; i3 < sArr[0][0].length; i3++) {
                    bArr[i][i2][i3] = (byte) sArr[i][i2][i3];
                }
            }
        }
        return bArr;
    }

    public static short[][][] Me2d26373(byte[][][] bArr) {
        if ((4 + 22) % 22 > 0) {
        }
        int length = bArr.length;
        byte[][] bArr2 = bArr[0];
        int length2 = bArr2.length;
        int[] iArr = new int[3];
        iArr[2] = bArr2[0].length;
        iArr[1] = length2;
        iArr[0] = length;
        short[][][] sArr = (short[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        for (int i = 0; i < bArr.length; i++) {
            for (int i2 = 0; i2 < bArr[0].length; i2++) {
                for (int i3 = 0; i3 < bArr[0][0].length; i3++) {
                    sArr[i][i2][i3] = (short) (bArr[i][i2][i3] & 255);
                }
            }
        }
        return sArr;
    }
}

