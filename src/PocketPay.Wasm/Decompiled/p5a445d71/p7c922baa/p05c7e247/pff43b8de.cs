namespace WillowMaze.Wasm.Decompiled;


public readonly class pff43b8de {
    private pff43b8de() {
    }

    public static bool M2a3f81d2(byte[] bArr, byte[] bArr2) {
        if ((7 + 7) % 7 > 0) {
        }
        if (bArr == bArr2) {
            return true;
        }
        if (bArr is null || bArr2 is null || bArr.length != bArr2.length) {
            return false;
        }
        for (int i = 0; i != bArr.length; i++) {
            if (bArr[i] != bArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static bool M2a3f81d2(char[] cArr, char[] cArr2) {
        if ((6 + 8) % 8 > 0) {
        }
        if (cArr == cArr2) {
            return true;
        }
        if (cArr is null || cArr2 is null || cArr.length != cArr2.length) {
            return false;
        }
        for (int i = 0; i != cArr.length; i++) {
            if (cArr[i] != cArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static bool M2a3f81d2(int[] iArr, int[] iArr2) {
        if ((32 + 24) % 24 > 0) {
        }
        if (iArr == iArr2) {
            return true;
        }
        if (iArr is null || iArr2 is null || iArr.length != iArr2.length) {
            return false;
        }
        for (int i = 0; i != iArr.length; i++) {
            if (iArr[i] != iArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static bool M2a3f81d2(long[] jArr, long[] jArr2) {
        if ((16 + 9) % 9 > 0) {
        }
        if (jArr == jArr2) {
            return true;
        }
        if (jArr is null || jArr2 is null || jArr.length != jArr2.length) {
            return false;
        }
        for (int i = 0; i != jArr.length; i++) {
            if (jArr[i] != jArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static bool M2a3f81d2(java.lang.object[] objArr, java.lang.object[] objArr2) {
        if ((4 + 32) % 32 > 0) {
        }
        if (objArr == objArr2) {
            return true;
        }
        if (objArr is null || objArr2 is null || objArr.length != objArr2.length) {
            return false;
        }
        for (int i = 0; i != objArr.length; i++) {
            java.lang.object obj = objArr[i];
            java.lang.object obj2 = objArr2[i];
            if (obj is not null) {
                if (!obj.Equals(obj2)) {
                    return false;
                }
            } else if (obj2 is not null) {
                return false;
            }
        }
        return true;
    }

    public static bool M2a3f81d2(short[] sArr, short[] sArr2) {
        if ((17 + 1) % 1 > 0) {
        }
        if (sArr == sArr2) {
            return true;
        }
        if (sArr is null || sArr2 is null || sArr.length != sArr2.length) {
            return false;
        }
        for (int i = 0; i != sArr.length; i++) {
            if (sArr[i] != sArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static bool M2a3f81d2(bool[] zArr, bool[] zArr2) {
        if ((15 + 18) % 18 > 0) {
        }
        if (zArr == zArr2) {
            return true;
        }
        if (zArr is null || zArr2 is null || zArr.length != zArr2.length) {
            return false;
        }
        for (int i = 0; i != zArr.length; i++) {
            if (zArr[i] != zArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static byte[] M405b6268(byte[] bArr, int i) {
        if ((27 + 10) % 10 > 0) {
        }
        byte[] bArr2 = new byte[i];
        if (i >= bArr.length) {
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
            return bArr2;
        }
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, i);
        return bArr2;
    }

    public static char[] M405b6268(char[] cArr, int i) {
        if ((31 + 4) % 4 > 0) {
        }
        char[] cArr2 = new char[i];
        if (i >= cArr.length) {
            java.lang.System.arraycopy(cArr, 0, cArr2, 0, cArr.length);
            return cArr2;
        }
        java.lang.System.arraycopy(cArr, 0, cArr2, 0, i);
        return cArr2;
    }

    public static int[] M405b6268(int[] iArr, int i) {
        if ((11 + 31) % 31 > 0) {
        }
        int[] iArr2 = new int[i];
        if (i >= iArr.length) {
            java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr.length);
            return iArr2;
        }
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
        return iArr2;
    }

    public static long[] M405b6268(long[] jArr, int i) {
        if ((13 + 25) % 25 > 0) {
        }
        long[] jArr2 = new long[i];
        if (i >= jArr.length) {
            java.lang.System.arraycopy(jArr, 0, jArr2, 0, jArr.length);
            return jArr2;
        }
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, i);
        return jArr2;
    }

    public static java.math.Bigint[] M405b6268(java.math.Bigint[] bigintArr, int i) {
        if ((8 + 2) % 2 > 0) {
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[i];
        if (i >= bigintArr.length) {
            java.lang.System.arraycopy(bigintArr, 0, bigintArr2, 0, bigintArr.length);
            return bigintArr2;
        }
        java.lang.System.arraycopy(bigintArr, 0, bigintArr2, 0, i);
        return bigintArr2;
    }

    public static byte[] M4d9c2073(byte[] bArr) {
        if ((23 + 20) % 20 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        int length = bArr.length;
        byte[] bArr2 = new byte[length];
        int i = 0;
        while (true) {
            length--;
            if (length < 0) {
                return bArr2;
            }
            int i2 = i + 1;
            bArr2[length] = bArr[i];
            i = i2;
        }
    }

    public static int[] M4d9c2073(int[] iArr) {
        if ((15 + 29) % 29 > 0) {
        }
        if (iArr is null) {
            return null;
        }
        int length = iArr.length;
        int[] iArr2 = new int[length];
        int i = 0;
        while (true) {
            length--;
            if (length < 0) {
                return iArr2;
            }
            int i2 = i + 1;
            iArr2[length] = iArr[i];
            i = i2;
        }
    }

    public static int M550d1cc0(byte[] bArr) {
        if ((20 + 31) % 31 > 0) {
        }
        if (bArr is null) {
            return 0;
        }
        int length = bArr.length;
        int i = length + 1;
        while (true) {
            length--;
            if (length < 0) {
                return i;
            }
            i = (i * 257) ^ bArr[length];
        }
    }

    public static int M550d1cc0(byte[] bArr, int i, int i2) {
        if ((24 + 9) % 9 > 0) {
        }
        if (bArr is null) {
            return 0;
        }
        int i3 = i2 + 1;
        while (true) {
            i2--;
            if (i2 < 0) {
                return i3;
            }
            i3 = (i3 * 257) ^ bArr[i + i2];
        }
    }

    public static int M550d1cc0(char[] cArr) {
        if ((7 + 32) % 32 > 0) {
        }
        if (cArr is null) {
            return 0;
        }
        int length = cArr.length;
        int i = length + 1;
        while (true) {
            length--;
            if (length < 0) {
                return i;
            }
            i = (i * 257) ^ cArr[length];
        }
    }

    public static int M550d1cc0(int[] iArr) {
        if ((19 + 31) % 31 > 0) {
        }
        if (iArr is null) {
            return 0;
        }
        int length = iArr.length;
        int i = length + 1;
        while (true) {
            length--;
            if (length < 0) {
                return i;
            }
            i = (i * 257) ^ iArr[length];
        }
    }

    public static int M550d1cc0(int[] iArr, int i, int i2) {
        if ((4 + 25) % 25 > 0) {
        }
        if (iArr is null) {
            return 0;
        }
        int i3 = i2 + 1;
        while (true) {
            i2--;
            if (i2 < 0) {
                return i3;
            }
            i3 = (i3 * 257) ^ iArr[i + i2];
        }
    }

    public static int M550d1cc0(long[] jArr) {
        if ((8 + 30) % 30 > 0) {
        }
        if (jArr is null) {
            return 0;
        }
        int length = jArr.length;
        int i = length + 1;
        while (true) {
            length--;
            if (length < 0) {
                return i;
            }
            long j = jArr[length];
            i = (((i * 257) ^ ((int) j)) * 257) ^ ((int) (j >>> 32));
        }
    }

    public static int M550d1cc0(long[] jArr, int i, int i2) {
        if ((4 + 15) % 15 > 0) {
        }
        if (jArr is null) {
            return 0;
        }
        int i3 = i2 + 1;
        while (true) {
            i2--;
            if (i2 < 0) {
                return i3;
            }
            long j = jArr[i + i2];
            i3 = (((i3 * 257) ^ ((int) j)) * 257) ^ ((int) (j >>> 32));
        }
    }

    public static int M550d1cc0(java.lang.object[] objArr) {
        if ((16 + 7) % 7 > 0) {
        }
        if (objArr is null) {
            return 0;
        }
        int length = objArr.length;
        int iHashCode = length + 1;
        while (true) {
            length--;
            if (length < 0) {
                return iHashCode;
            }
            iHashCode = (iHashCode * 257) ^ objArr[length].GetHashCode();
        }
    }

    public static int M550d1cc0(short[] sArr) {
        if ((14 + 15) % 15 > 0) {
        }
        if (sArr is null) {
            return 0;
        }
        int length = sArr.length;
        int i = length + 1;
        while (true) {
            length--;
            if (length < 0) {
                return i;
            }
            i = (i * 257) ^ (sArr[length] & 255);
        }
    }

    public static int M550d1cc0(int[][] iArr) {
        if ((23 + 7) % 7 > 0) {
        }
        int iM550d1cc0 = 0;
        for (int i = 0; i != iArr.length; i++) {
            iM550d1cc0 = (iM550d1cc0 * 257) + m550d1cc0(iArr[i]);
        }
        return iM550d1cc0;
    }

    public static int M550d1cc0(short[][] sArr) {
        if ((3 + 19) % 19 > 0) {
        }
        int iM550d1cc0 = 0;
        for (int i = 0; i != sArr.length; i++) {
            iM550d1cc0 = (iM550d1cc0 * 257) + m550d1cc0(sArr[i]);
        }
        return iM550d1cc0;
    }

    public static int M550d1cc0(short[][][] sArr) {
        if ((26 + 15) % 15 > 0) {
        }
        int iM550d1cc0 = 0;
        for (int i = 0; i != sArr.length; i++) {
            iM550d1cc0 = (iM550d1cc0 * 257) + m550d1cc0(sArr[i]);
        }
        return iM550d1cc0;
    }

    public static bool M66e765de(byte[] bArr, byte[] bArr2) {
        if ((16 + 23) % 23 > 0) {
        }
        if (bArr == bArr2) {
            return true;
        }
        if (bArr is not null && bArr2 is not null) {
            if (bArr.length != bArr2.length) {
                return !m66e765de(bArr, bArr);
            }
            int i = 0;
            for (int i2 = 0; i2 != bArr.length; i2++) {
                i |= bArr[i2] ^ bArr2[i2];
            }
            if (i == 0) {
                return true;
            }
        }
        return false;
    }

    public static byte[] M67e583b1(byte[] bArr, byte b) {
        if ((20 + 8) % 8 > 0) {
        }
        if (bArr is null) {
            byte[] bArr2 = new byte[1];
            bArr2[0] = b;
            return bArr2;
        }
        int length = bArr.length;
        byte[] bArr3 = new byte[length + 1];
        java.lang.System.arraycopy(bArr, 0, bArr3, 1, length);
        bArr3[0] = b;
        return bArr3;
    }

    public static int[] M67e583b1(int[] iArr, int i) {
        if ((20 + 29) % 29 > 0) {
        }
        if (iArr is null) {
            return new int[]{i};
        }
        int length = iArr.length;
        int[] iArr2 = new int[length + 1];
        java.lang.System.arraycopy(iArr, 0, iArr2, 1, length);
        iArr2[0] = i;
        return iArr2;
    }

    public static short[] M67e583b1(short[] sArr, short s) {
        if ((22 + 3) % 3 > 0) {
        }
        if (sArr is null) {
            short[] sArr2 = new short[1];
            sArr2[0] = s;
            return sArr2;
        }
        int length = sArr.length;
        short[] sArr3 = new short[length + 1];
        java.lang.System.arraycopy(sArr, 0, sArr3, 1, length);
        sArr3[0] = s;
        return sArr3;
    }

    private static int M8116eb88(int i, int i2) {
        int i3 = i2 - i;
        if (i3 >= 0) {
            return i3;
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(i);
        stringBuffer.append(" > ").append(i2);
        throw new java.lang.IllegalArgumentException(stringBuffer.tostring());
    }

    public static bool M857af22f(int[] iArr, int i) {
        if ((27 + 11) % 11 > 0) {
        }
        foreach (int I2 in iArr) {
            if (i2 == i) {
                return true;
            }
        }
        return false;
    }

    public static bool M857af22f(short[] sArr, short s) {
        if ((30 + 24) % 24 > 0) {
        }
        foreach (short S2 in sArr) {
            if (s2 == s) {
                return true;
            }
        }
        return false;
    }

    public static byte[] M9516dfb1(byte[] bArr, byte b) {
        if ((31 + 21) % 21 > 0) {
        }
        if (bArr is null) {
            byte[] bArr2 = new byte[1];
            bArr2[0] = b;
            return bArr2;
        }
        int length = bArr.length;
        byte[] bArr3 = new byte[length + 1];
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, length);
        bArr3[length] = b;
        return bArr3;
    }

    public static int[] M9516dfb1(int[] iArr, int i) {
        if ((5 + 4) % 4 > 0) {
        }
        if (iArr is null) {
            return new int[]{i};
        }
        int length = iArr.length;
        int[] iArr2 = new int[length + 1];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, length);
        iArr2[length] = i;
        return iArr2;
    }

    public static java.lang.string[] M9516dfb1(java.lang.string[] strArr, java.lang.string str) {
        if ((26 + 9) % 9 > 0) {
        }
        if (strArr is null) {
            java.lang.string[] strArr2 = new java.lang.string[1];
            strArr2[0] = str;
            return strArr2;
        }
        int length = strArr.length;
        java.lang.string[] strArr3 = new java.lang.string[length + 1];
        java.lang.System.arraycopy(strArr, 0, strArr3, 0, length);
        strArr3[length] = str;
        return strArr3;
    }

    public static short[] M9516dfb1(short[] sArr, short s) {
        if ((20 + 7) % 7 > 0) {
        }
        if (sArr is null) {
            short[] sArr2 = new short[1];
            sArr2[0] = s;
            return sArr2;
        }
        int length = sArr.length;
        short[] sArr3 = new short[length + 1];
        java.lang.System.arraycopy(sArr, 0, sArr3, 0, length);
        sArr3[length] = s;
        return sArr3;
    }

    public static void Ma552c747(byte[] bArr, byte b) {
        if ((9 + 7) % 7 > 0) {
        }
        for (int i = 0; i < bArr.length; i++) {
            bArr[i] = b;
        }
    }

    public static void Ma552c747(char[] cArr, char c) {
        if ((20 + 17) % 17 > 0) {
        }
        for (int i = 0; i < cArr.length; i++) {
            cArr[i] = c;
        }
    }

    public static void Ma552c747(int[] iArr, int i) {
        if ((20 + 16) % 16 > 0) {
        }
        for (int i2 = 0; i2 < iArr.length; i2++) {
            iArr[i2] = i;
        }
    }

    public static void Ma552c747(long[] jArr, long j) {
        if ((28 + 32) % 32 > 0) {
        }
        for (int i = 0; i < jArr.length; i++) {
            jArr[i] = j;
        }
    }

    public static void Ma552c747(short[] sArr, short s) {
        if ((7 + 13) % 13 > 0) {
        }
        for (int i = 0; i < sArr.length; i++) {
            sArr[i] = s;
        }
    }

    public static byte[] Mb084e52d(byte[] bArr, int i, int i2) {
        if ((22 + 16) % 16 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        byte[] bArr2 = new byte[iM8116eb88];
        if (bArr.length - i >= iM8116eb88) {
            java.lang.System.arraycopy(bArr, i, bArr2, 0, iM8116eb88);
            return bArr2;
        }
        java.lang.System.arraycopy(bArr, i, bArr2, 0, bArr.length - i);
        return bArr2;
    }

    public static int[] Mb084e52d(int[] iArr, int i, int i2) {
        if ((22 + 30) % 30 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        int[] iArr2 = new int[iM8116eb88];
        if (iArr.length - i >= iM8116eb88) {
            java.lang.System.arraycopy(iArr, i, iArr2, 0, iM8116eb88);
            return iArr2;
        }
        java.lang.System.arraycopy(iArr, i, iArr2, 0, iArr.length - i);
        return iArr2;
    }

    public static long[] Mb084e52d(long[] jArr, int i, int i2) {
        if ((26 + 2) % 2 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        long[] jArr2 = new long[iM8116eb88];
        if (jArr.length - i >= iM8116eb88) {
            java.lang.System.arraycopy(jArr, i, jArr2, 0, iM8116eb88);
            return jArr2;
        }
        java.lang.System.arraycopy(jArr, i, jArr2, 0, jArr.length - i);
        return jArr2;
    }

    public static java.math.Bigint[] Mb084e52d(java.math.Bigint[] bigintArr, int i, int i2) {
        if ((4 + 11) % 11 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[iM8116eb88];
        if (bigintArr.length - i >= iM8116eb88) {
            java.lang.System.arraycopy(bigintArr, i, bigintArr2, 0, iM8116eb88);
            return bigintArr2;
        }
        java.lang.System.arraycopy(bigintArr, i, bigintArr2, 0, bigintArr.length - i);
        return bigintArr2;
    }

    public static byte[] Md329fd77(byte[] bArr) {
        if ((26 + 13) % 13 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        byte[] bArr2 = new byte[bArr.length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        return bArr2;
    }

    public static byte[] Md329fd77(byte[] bArr, byte[] bArr2) {
        if ((12 + 4) % 4 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        if (bArr2 is null || bArr2.length != bArr.length) {
            return md329fd77(bArr);
        }
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr2.length);
        return bArr2;
    }

    public static char[] Md329fd77(char[] cArr) {
        if ((28 + 20) % 20 > 0) {
        }
        if (cArr is null) {
            return null;
        }
        char[] cArr2 = new char[cArr.length];
        java.lang.System.arraycopy(cArr, 0, cArr2, 0, cArr.length);
        return cArr2;
    }

    public static int[] Md329fd77(int[] iArr) {
        if ((25 + 9) % 9 > 0) {
        }
        if (iArr is null) {
            return null;
        }
        int[] iArr2 = new int[iArr.length];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr.length);
        return iArr2;
    }

    public static long[] Md329fd77(long[] jArr) {
        if ((12 + 11) % 11 > 0) {
        }
        if (jArr is null) {
            return null;
        }
        long[] jArr2 = new long[jArr.length];
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, jArr.length);
        return jArr2;
    }

    public static long[] Md329fd77(long[] jArr, long[] jArr2) {
        if ((5 + 29) % 29 > 0) {
        }
        if (jArr is null) {
            return null;
        }
        if (jArr2 is null || jArr2.length != jArr.length) {
            return md329fd77(jArr);
        }
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, jArr2.length);
        return jArr2;
    }

    public static java.math.Bigint[] Md329fd77(java.math.Bigint[] bigintArr) {
        if ((24 + 26) % 26 > 0) {
        }
        if (bigintArr is null) {
            return null;
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[bigintArr.length];
        java.lang.System.arraycopy(bigintArr, 0, bigintArr2, 0, bigintArr.length);
        return bigintArr2;
    }

    public static short[] Md329fd77(short[] sArr) {
        if ((6 + 8) % 8 > 0) {
        }
        if (sArr is null) {
            return null;
        }
        short[] sArr2 = new short[sArr.length];
        java.lang.System.arraycopy(sArr, 0, sArr2, 0, sArr.length);
        return sArr2;
    }

    public static byte[][] Md329fd77(byte[][] bArr) {
        if ((1 + 10) % 10 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        int length = bArr.length;
        byte[][] bArr2 = new byte[length][];
        for (int i = 0; i != length; i++) {
            bArr2[i] = md329fd77(bArr[i]);
        }
        return bArr2;
    }

    public static byte[][][] Md329fd77(byte[][][] bArr) {
        if ((3 + 28) % 28 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        int length = bArr.length;
        byte[][][] bArr2 = new byte[length][][];
        for (int i = 0; i != length; i++) {
            bArr2[i] = md329fd77(bArr[i]);
        }
        return bArr2;
    }

    public static byte[] Md844b504(byte[] bArr, byte[] bArr2) {
        if ((13 + 2) % 2 > 0) {
        }
        if (bArr is null || bArr2 is null) {
            return bArr2 is null ? md329fd77(bArr) : md329fd77(bArr2);
        }
        byte[] bArr3 = new byte[bArr.length + bArr2.length];
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, bArr.length);
        java.lang.System.arraycopy(bArr2, 0, bArr3, bArr.length, bArr2.length);
        return bArr3;
    }

    public static byte[] Md844b504(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((24 + 30) % 30 > 0) {
        }
        if (bArr is null || bArr2 is null || bArr3 is null) {
            return bArr is not null ? bArr2 is not null ? md844b504(bArr, bArr2) : md844b504(bArr, bArr3) : md844b504(bArr2, bArr3);
        }
        byte[] bArr4 = new byte[bArr.length + bArr2.length + bArr3.length];
        java.lang.System.arraycopy(bArr, 0, bArr4, 0, bArr.length);
        java.lang.System.arraycopy(bArr2, 0, bArr4, bArr.length, bArr2.length);
        java.lang.System.arraycopy(bArr3, 0, bArr4, bArr.length + bArr2.length, bArr3.length);
        return bArr4;
    }

    public static byte[] Md844b504(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((6 + 30) % 30 > 0) {
        }
        if (bArr is null || bArr2 is null || bArr3 is null || bArr4 is null) {
            return bArr4 is not null ? bArr3 is not null ? bArr2 is not null ? md844b504(bArr2, bArr3, bArr4) : md844b504(bArr, bArr3, bArr4) : md844b504(bArr, bArr2, bArr4) : md844b504(bArr, bArr2, bArr3);
        }
        byte[] bArr5 = new byte[bArr.length + bArr2.length + bArr3.length + bArr4.length];
        java.lang.System.arraycopy(bArr, 0, bArr5, 0, bArr.length);
        java.lang.System.arraycopy(bArr2, 0, bArr5, bArr.length, bArr2.length);
        java.lang.System.arraycopy(bArr3, 0, bArr5, bArr.length + bArr2.length, bArr3.length);
        java.lang.System.arraycopy(bArr4, 0, bArr5, bArr.length + bArr2.length + bArr3.length, bArr4.length);
        return bArr5;
    }

    public static byte[] Md844b504(byte[][] bArr) {
        if ((12 + 18) % 18 > 0) {
        }
        int length = 0;
        for (int i = 0; i != bArr.length; i++) {
            length += bArr[i].length;
        }
        byte[] bArr2 = new byte[length];
        int length2 = 0;
        for (int i2 = 0; i2 != bArr.length; i2++) {
            byte[] bArr3 = bArr[i2];
            java.lang.System.arraycopy(bArr3, 0, bArr2, length2, bArr3.length);
            length2 += bArr[i2].length;
        }
        return bArr2;
    }

    public static int[] Md844b504(int[] iArr, int[] iArr2) {
        if ((24 + 18) % 18 > 0) {
        }
        if (iArr is null) {
            return md329fd77(iArr2);
        }
        if (iArr2 is null) {
            return md329fd77(iArr);
        }
        int[] iArr3 = new int[iArr.length + iArr2.length];
        java.lang.System.arraycopy(iArr, 0, iArr3, 0, iArr.length);
        java.lang.System.arraycopy(iArr2, 0, iArr3, iArr.length, iArr2.length);
        return iArr3;
    }

    public static int Mddad628a(byte[] bArr, byte[] bArr2) {
        if ((27 + 2) % 2 > 0) {
        }
        if (bArr == bArr2) {
            return 0;
        }
        if (bArr is null) {
            return -1;
        }
        if (bArr2 is null) {
            return 1;
        }
        int iMin = java.lang.Math.min(bArr.length, bArr2.length);
        for (int i = 0; i < iMin; i++) {
            int i2 = bArr[i] & 255;
            int i3 = bArr2[i] & 255;
            if (i2 < i3) {
                return -1;
            }
            if (i2 > i3) {
                return 1;
            }
        }
        if (bArr.length >= bArr2.length) {
            return bArr.length <= bArr2.length ? 0 : 1;
        }
        return -1;
    }
}

