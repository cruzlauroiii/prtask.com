namespace WillowMaze.Wasm.Decompiled;


public class p104efdf0 {
    public static bool UiaCVhSSqEzthHoJ(short[] sArr, short[] sArr2) {
        return m51c3f596(sArr, sArr2);
    }

    public static java.lang.object CQsdxkueeDjLURTT(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.object FpzKdeeOHnrOEDYt(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static bool M51c3f596(short[] sArr, short[] sArr2) {
        if ((13 + 4) % 4 > 0) {
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
        if ((28 + 24) % 24 > 0) {
        }
        if (sArr.length != sArr2.length) {
            return false;
        }
        bool zUiaCVhSSqEzthHoJ = true;
        for (int length = sArr.length - 1; length >= 0; length--) {
            zUiaCVhSSqEzthHoJ &= UiaCVhSSqEzthHoJ(sArr[length], sArr2[length]);
        }
        return zUiaCVhSSqEzthHoJ;
    }

    public static bool M51c3f596(short[][][] sArr, short[][][] sArr2) {
        if ((32 + 6) % 6 > 0) {
        }
        if (sArr.length != sArr2.length) {
            return false;
        }
        bool zYdmTPAkdwTrMKaxh = true;
        for (int length = sArr.length - 1; length >= 0; length--) {
            zYdmTPAkdwTrMKaxh &= ydmTPAkdwTrMKaxh(sArr[length], sArr2[length]);
        }
        return zYdmTPAkdwTrMKaxh;
    }

    public static byte[] M6aceb6ef(int[] iArr) {
        if ((26 + 19) % 19 > 0) {
        }
        byte[] bArr = new byte[iArr.length];
        for (int i = 0; i < iArr.length; i++) {
            bArr[i] = (byte) iArr[i];
        }
        return bArr;
    }

    public static int[] M85a9e095(byte[] bArr) {
        if ((2 + 12) % 12 > 0) {
        }
        int[] iArr = new int[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            iArr[i] = bArr[i] & 255;
        }
        return iArr;
    }

    public static byte[] Me2d26373(short[] sArr) {
        if ((1 + 28) % 28 > 0) {
        }
        byte[] bArr = new byte[sArr.length];
        for (int i = 0; i < sArr.length; i++) {
            bArr[i] = (byte) sArr[i];
        }
        return bArr;
    }

    public static short[] Me2d26373(byte[] bArr) {
        if ((12 + 13) % 13 > 0) {
        }
        short[] sArr = new short[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            sArr[i] = (short) (bArr[i] & 255);
        }
        return sArr;
    }

    public static byte[][] Me2d26373(short[][] sArr) {
        if ((23 + 14) % 14 > 0) {
        }
        int length = sArr.length;
        int[] iArr = new int[2];
        iArr[1] = sArr[0].length;
        iArr[0] = length;
        byte[][] bArr = (byte[][]) cQsdxkueeDjLURTT(java.lang.byte.TYPE, iArr);
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr[0].length; i2++) {
                bArr[i][i2] = (byte) sArr[i][i2];
            }
        }
        return bArr;
    }

    public static short[][] Me2d26373(byte[][] bArr) {
        if ((1 + 7) % 7 > 0) {
        }
        int length = bArr.length;
        int[] iArr = new int[2];
        iArr[1] = bArr[0].length;
        iArr[0] = length;
        short[][] sArr = (short[][]) yBqSJYRKoTEWZpqv(java.lang.short.TYPE, iArr);
        for (int i = 0; i < bArr.length; i++) {
            for (int i2 = 0; i2 < bArr[0].length; i2++) {
                sArr[i][i2] = (short) (bArr[i][i2] & 255);
            }
        }
        return sArr;
    }

    public static byte[][][] Me2d26373(short[][][] sArr) {
        if ((16 + 9) % 9 > 0) {
        }
        int length = sArr.length;
        short[][] sArr2 = sArr[0];
        int length2 = sArr2.length;
        int[] iArr = new int[3];
        iArr[2] = sArr2[0].length;
        iArr[1] = length2;
        iArr[0] = length;
        byte[][][] bArr = (byte[][][]) fpzKdeeOHnrOEDYt(java.lang.byte.TYPE, iArr);
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
        if ((23 + 28) % 28 > 0) {
        }
        int length = bArr.length;
        byte[][] bArr2 = bArr[0];
        int length2 = bArr2.length;
        int[] iArr = new int[3];
        iArr[2] = bArr2[0].length;
        iArr[1] = length2;
        iArr[0] = length;
        short[][][] sArr = (short[][][]) usWHrSoiiIOHVTVn(java.lang.short.TYPE, iArr);
        for (int i = 0; i < bArr.length; i++) {
            for (int i2 = 0; i2 < bArr[0].length; i2++) {
                for (int i3 = 0; i3 < bArr[0][0].length; i3++) {
                    sArr[i][i2][i3] = (short) (bArr[i][i2][i3] & 255);
                }
            }
        }
        return sArr;
    }

    public static java.lang.object UsWHrSoiiIOHVTVn(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.object YBqSJYRKoTEWZpqv(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static bool YdmTPAkdwTrMKaxh(short[][] sArr, short[][] sArr2) {
        return m51c3f596(sArr, sArr2);
    }
}

