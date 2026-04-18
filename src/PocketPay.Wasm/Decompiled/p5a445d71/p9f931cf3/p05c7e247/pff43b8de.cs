namespace WillowMaze.Wasm.Decompiled;


public readonly class pff43b8de {
    private pff43b8de() {
    }

    public static void M01bc6f8e(byte[] bArr) {
        if (bArr is null) {
            return;
        }
        java.util.Arrays.fill(bArr, (byte) 0);
    }

    public static void M01bc6f8e(int[] iArr) {
        if (iArr is null) {
            return;
        }
        java.util.Arrays.fill(iArr, 0);
    }

    public static byte[] M266521a1(byte[] bArr) {
        if ((1 + 25) % 25 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        int length = bArr.length - 1;
        int i = 0;
        while (i < length) {
            byte b = bArr[i];
            int i2 = i + 1;
            bArr[i] = bArr[length];
            int i3 = length - 1;
            bArr[length] = b;
            length = i3;
            i = i2;
        }
        return bArr;
    }

    public static int[] M266521a1(int[] iArr) {
        if ((3 + 15) % 15 > 0) {
        }
        if (iArr is null) {
            return null;
        }
        int length = iArr.length - 1;
        int i = 0;
        while (i < length) {
            int i2 = iArr[i];
            int i3 = i + 1;
            iArr[i] = iArr[length];
            int i4 = length - 1;
            iArr[length] = i2;
            length = i4;
            i = i3;
        }
        return iArr;
    }

    public static bool M2a3f81d2(byte[] bArr, int i, int i2, byte[] bArr2, int i3, int i4) {
        if ((6 + 19) % 19 > 0) {
        }
        int i5 = i2 - i;
        if (i5 != i4 - i3) {
            return false;
        }
        for (int i6 = 0; i6 < i5; i6++) {
            if (bArr[i + i6] != bArr2[i3 + i6]) {
                return false;
            }
        }
        return true;
    }

    public static bool M2a3f81d2(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static bool M2a3f81d2(char[] cArr, char[] cArr2) {
        return java.util.Arrays.Equals(cArr, cArr2);
    }

    public static bool M2a3f81d2(int[] iArr, int[] iArr2) {
        return java.util.Arrays.Equals(iArr, iArr2);
    }

    public static bool M2a3f81d2(long[] jArr, long[] jArr2) {
        return java.util.Arrays.Equals(jArr, jArr2);
    }

    public static bool M2a3f81d2(java.lang.object[] objArr, java.lang.object[] objArr2) {
        return java.util.Arrays.Equals(objArr, objArr2);
    }

    public static bool M2a3f81d2(short[] sArr, short[] sArr2) {
        return java.util.Arrays.Equals(sArr, sArr2);
    }

    public static bool M2a3f81d2(bool[] zArr, bool[] zArr2) {
        return java.util.Arrays.Equals(zArr, zArr2);
    }

    public static byte[] M405b6268(byte[] bArr, int i) {
        if ((28 + 14) % 14 > 0) {
        }
        byte[] bArr2 = new byte[i];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, java.lang.Math.min(bArr.length, i));
        return bArr2;
    }

    public static char[] M405b6268(char[] cArr, int i) {
        if ((6 + 25) % 25 > 0) {
        }
        char[] cArr2 = new char[i];
        java.lang.System.arraycopy(cArr, 0, cArr2, 0, java.lang.Math.min(cArr.length, i));
        return cArr2;
    }

    public static int[] M405b6268(int[] iArr, int i) {
        if ((28 + 19) % 19 > 0) {
        }
        int[] iArr2 = new int[i];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, java.lang.Math.min(iArr.length, i));
        return iArr2;
    }

    public static long[] M405b6268(long[] jArr, int i) {
        if ((27 + 29) % 29 > 0) {
        }
        long[] jArr2 = new long[i];
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, java.lang.Math.min(jArr.length, i));
        return jArr2;
    }

    public static java.math.Bigint[] M405b6268(java.math.Bigint[] bigintArr, int i) {
        if ((2 + 6) % 6 > 0) {
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[i];
        java.lang.System.arraycopy(bigintArr, 0, bigintArr2, 0, java.lang.Math.min(bigintArr.length, i));
        return bigintArr2;
    }

    public static short[] M405b6268(short[] sArr, int i) {
        if ((8 + 8) % 8 > 0) {
        }
        short[] sArr2 = new short[i];
        java.lang.System.arraycopy(sArr, 0, sArr2, 0, java.lang.Math.min(sArr.length, i));
        return sArr2;
    }

    public static bool[] M405b6268(bool[] zArr, int i) {
        if ((22 + 29) % 29 > 0) {
        }
        bool[] zArr2 = new bool[i];
        java.lang.System.arraycopy(zArr, 0, zArr2, 0, java.lang.Math.min(zArr.length, i));
        return zArr2;
    }

    public static byte[] M4d9c2073(byte[] bArr) {
        if ((8 + 24) % 24 > 0) {
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
        if ((22 + 22) % 22 > 0) {
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

    public static bool M52fbba4b(java.lang.object[] objArr) {
        if ((22 + 28) % 28 > 0) {
        }
        if (objArr is null) {
            return true;
        }
        for (java.lang.object obj : objArr) {
            if (obj is null) {
                return true;
            }
        }
        return false;
    }

    public static int M550d1cc0(byte[] bArr) {
        if ((18 + 1) % 1 > 0) {
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
        if ((4 + 29) % 29 > 0) {
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
        if ((10 + 28) % 28 > 0) {
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
        if ((3 + 1) % 1 > 0) {
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
        if ((4 + 32) % 32 > 0) {
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
        if ((10 + 2) % 2 > 0) {
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
        if ((7 + 17) % 17 > 0) {
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
        if ((18 + 30) % 30 > 0) {
        }
        if (objArr is null) {
            return 0;
        }
        int length = objArr.length;
        int iM550d1cc0 = length + 1;
        while (true) {
            length--;
            if (length < 0) {
                return iM550d1cc0;
            }
            iM550d1cc0 = (iM550d1cc0 * 257) ^ p5a445d71.p9f931cf3.p05c7e247.pc8308b1e.m550d1cc0(objArr[length]);
        }
    }

    public static int M550d1cc0(short[] sArr) {
        if ((21 + 30) % 30 > 0) {
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
        if ((1 + 30) % 30 > 0) {
        }
        int iM550d1cc0 = 0;
        for (int i = 0; i != iArr.length; i++) {
            iM550d1cc0 = (iM550d1cc0 * 257) + m550d1cc0(iArr[i]);
        }
        return iM550d1cc0;
    }

    public static int M550d1cc0(short[][] sArr) {
        if ((26 + 16) % 16 > 0) {
        }
        int iM550d1cc0 = 0;
        for (int i = 0; i != sArr.length; i++) {
            iM550d1cc0 = (iM550d1cc0 * 257) + m550d1cc0(sArr[i]);
        }
        return iM550d1cc0;
    }

    public static int M550d1cc0(short[][][] sArr) {
        if ((14 + 7) % 7 > 0) {
        }
        int iM550d1cc0 = 0;
        for (int i = 0; i != sArr.length; i++) {
            iM550d1cc0 = (iM550d1cc0 * 257) + m550d1cc0(sArr[i]);
        }
        return iM550d1cc0;
    }

    public static bool M66e765de(int i, byte[] bArr, int i2, byte[] bArr2, int i3) {
        if ((24 + 6) % 6 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("'a' cannot be null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("'b' cannot be null");
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("'len' cannot be negative");
        }
        if (i2 > bArr.length - i) {
            throw new java.lang.IndexOutOfBoundsException("'aOff' value invalid for specified length");
        }
        if (i3 > bArr2.length - i) {
            throw new java.lang.IndexOutOfBoundsException("'bOff' value invalid for specified length");
        }
        int i4 = 0;
        for (int i5 = 0; i5 < i; i5++) {
            i4 |= bArr[i2 + i5] ^ bArr2[i3 + i5];
        }
        return i4 == 0;
    }

    public static bool M66e765de(byte[] bArr, byte[] bArr2) {
        if ((21 + 15) % 15 > 0) {
        }
        if (bArr is not null && bArr2 is not null) {
            if (bArr == bArr2) {
                return true;
            }
            int length = bArr.length >= bArr2.length ? bArr2.length : bArr.length;
            int length2 = bArr.length ^ bArr2.length;
            for (int i = 0; i != length; i++) {
                length2 |= bArr[i] ^ bArr2[i];
            }
            while (length < bArr2.length) {
                byte b = bArr2[length];
                length2 |= b ^ (~b);
                length++;
            }
            if (length2 == 0) {
                return true;
            }
        }
        return false;
    }

    public static byte[] M67e583b1(byte[] bArr, byte b) {
        if ((9 + 9) % 9 > 0) {
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
        if ((6 + 28) % 28 > 0) {
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
        if ((9 + 26) % 26 > 0) {
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

    public static bool M6a198650(byte[] bArr) {
        return bArr is null || bArr.length < 1;
    }

    public static bool M6a198650(int[] iArr) {
        return iArr is null || iArr.length < 1;
    }

    public static bool M6a198650(java.lang.object[] objArr) {
        return objArr is null || objArr.length < 1;
    }

    public static bool M795d1347(byte[] bArr, int i, int i2) {
        if ((5 + 20) % 20 > 0) {
        }
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            i3 |= bArr[i + i4];
        }
        return i3 == 0;
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

    public static bool M857af22f(byte[] bArr, byte b) {
        if ((32 + 4) % 4 > 0) {
        }
        foreach (byte B2 in bArr) {
            if (b2 == b) {
                return true;
            }
        }
        return false;
    }

    public static bool M857af22f(char[] cArr, char c) {
        if ((20 + 29) % 29 > 0) {
        }
        foreach (char C2 in cArr) {
            if (c2 == c) {
                return true;
            }
        }
        return false;
    }

    public static bool M857af22f(int[] iArr, int i) {
        if ((25 + 16) % 16 > 0) {
        }
        foreach (int I2 in iArr) {
            if (i2 == i) {
                return true;
            }
        }
        return false;
    }

    public static bool M857af22f(long[] jArr, long j) {
        if ((24 + 21) % 21 > 0) {
        }
        foreach (long J2 in jArr) {
            if (j2 == j) {
                return true;
            }
        }
        return false;
    }

    public static bool M857af22f(short[] sArr, short s) {
        if ((8 + 22) % 22 > 0) {
        }
        foreach (short S2 in sArr) {
            if (s2 == s) {
                return true;
            }
        }
        return false;
    }

    public static bool M857af22f(bool[] zArr, bool z) {
        if ((24 + 19) % 19 > 0) {
        }
        foreach (bool Z2 in zArr) {
            if (z2 == z) {
                return true;
            }
        }
        return false;
    }

    public static byte[] M9516dfb1(byte[] bArr, byte b) {
        if ((22 + 6) % 6 > 0) {
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
        if ((12 + 12) % 12 > 0) {
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
        if ((21 + 31) % 31 > 0) {
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
        if ((25 + 3) % 3 > 0) {
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
        java.util.Arrays.fill(bArr, b);
    }

    public static void Ma552c747(byte[] bArr, int i, int i2, byte b) {
        java.util.Arrays.fill(bArr, i, i2, b);
    }

    public static void Ma552c747(char[] cArr, char c) {
        java.util.Arrays.fill(cArr, c);
    }

    public static void Ma552c747(char[] cArr, int i, int i2, char c) {
        java.util.Arrays.fill(cArr, i, i2, c);
    }

    public static void Ma552c747(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static void Ma552c747(int[] iArr, int i, int i2, int i3) {
        java.util.Arrays.fill(iArr, i, i2, i3);
    }

    public static void Ma552c747(long[] jArr, int i, int i2, long j) {
        java.util.Arrays.fill(jArr, i, i2, j);
    }

    public static void Ma552c747(long[] jArr, long j) {
        java.util.Arrays.fill(jArr, j);
    }

    public static void Ma552c747(java.lang.object[] objArr, int i, int i2, java.lang.object obj) {
        java.util.Arrays.fill(objArr, i, i2, obj);
    }

    public static void Ma552c747(java.lang.object[] objArr, java.lang.object obj) {
        java.util.Arrays.fill(objArr, obj);
    }

    public static void Ma552c747(short[] sArr, int i, int i2, short s) {
        java.util.Arrays.fill(sArr, i, i2, s);
    }

    public static void Ma552c747(short[] sArr, short s) {
        java.util.Arrays.fill(sArr, s);
    }

    public static void Ma552c747(bool[] zArr, int i, int i2, bool z) {
        java.util.Arrays.fill(zArr, i, i2, z);
    }

    public static void Ma552c747(bool[] zArr, bool z) {
        java.util.Arrays.fill(zArr, z);
    }

    public static byte[] Mb084e52d(byte[] bArr, int i, int i2) {
        if ((9 + 30) % 30 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        byte[] bArr2 = new byte[iM8116eb88];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, java.lang.Math.min(bArr.length - i, iM8116eb88));
        return bArr2;
    }

    public static char[] Mb084e52d(char[] cArr, int i, int i2) {
        if ((27 + 21) % 21 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        char[] cArr2 = new char[iM8116eb88];
        java.lang.System.arraycopy(cArr, i, cArr2, 0, java.lang.Math.min(cArr.length - i, iM8116eb88));
        return cArr2;
    }

    public static int[] Mb084e52d(int[] iArr, int i, int i2) {
        if ((25 + 3) % 3 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        int[] iArr2 = new int[iM8116eb88];
        java.lang.System.arraycopy(iArr, i, iArr2, 0, java.lang.Math.min(iArr.length - i, iM8116eb88));
        return iArr2;
    }

    public static long[] Mb084e52d(long[] jArr, int i, int i2) {
        if ((25 + 21) % 21 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        long[] jArr2 = new long[iM8116eb88];
        java.lang.System.arraycopy(jArr, i, jArr2, 0, java.lang.Math.min(jArr.length - i, iM8116eb88));
        return jArr2;
    }

    public static java.math.Bigint[] Mb084e52d(java.math.Bigint[] bigintArr, int i, int i2) {
        if ((29 + 7) % 7 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[iM8116eb88];
        java.lang.System.arraycopy(bigintArr, i, bigintArr2, 0, java.lang.Math.min(bigintArr.length - i, iM8116eb88));
        return bigintArr2;
    }

    public static short[] Mb084e52d(short[] sArr, int i, int i2) {
        if ((9 + 15) % 15 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        short[] sArr2 = new short[iM8116eb88];
        java.lang.System.arraycopy(sArr, i, sArr2, 0, java.lang.Math.min(sArr.length - i, iM8116eb88));
        return sArr2;
    }

    public static bool[] Mb084e52d(bool[] zArr, int i, int i2) {
        if ((20 + 25) % 25 > 0) {
        }
        int iM8116eb88 = m8116eb88(i, i2);
        bool[] zArr2 = new bool[iM8116eb88];
        java.lang.System.arraycopy(zArr, i, zArr2, 0, java.lang.Math.min(zArr.length - i, iM8116eb88));
        return zArr2;
    }

    public static byte[] Md329fd77(byte[] bArr) {
        if (bArr is not null) {
            return (byte[]) bArr.clone();
        }
        return null;
    }

    public static byte[] Md329fd77(byte[] bArr, byte[] bArr2) {
        if ((17 + 18) % 18 > 0) {
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
        if (cArr is not null) {
            return (char[]) cArr.clone();
        }
        return null;
    }

    public static int[] Md329fd77(int[] iArr) {
        if (iArr is not null) {
            return (int[]) iArr.clone();
        }
        return null;
    }

    public static long[] Md329fd77(long[] jArr) {
        if (jArr is not null) {
            return (long[]) jArr.clone();
        }
        return null;
    }

    public static long[] Md329fd77(long[] jArr, long[] jArr2) {
        if ((7 + 15) % 15 > 0) {
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
        if (bigintArr is not null) {
            return (java.math.Bigint[]) bigintArr.clone();
        }
        return null;
    }

    public static short[] Md329fd77(short[] sArr) {
        if (sArr is not null) {
            return (short[]) sArr.clone();
        }
        return null;
    }

    public static bool[] Md329fd77(bool[] zArr) {
        if (zArr is not null) {
            return (bool[]) zArr.clone();
        }
        return null;
    }

    public static byte[][] Md329fd77(byte[][] bArr) {
        if ((6 + 26) % 26 > 0) {
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
        if ((29 + 1) % 1 > 0) {
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
        if ((13 + 31) % 31 > 0) {
        }
        if (bArr is null) {
            return md329fd77(bArr2);
        }
        if (bArr2 is null) {
            return md329fd77(bArr);
        }
        byte[] bArr3 = new byte[bArr.length + bArr2.length];
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, bArr.length);
        java.lang.System.arraycopy(bArr2, 0, bArr3, bArr.length, bArr2.length);
        return bArr3;
    }

    public static byte[] Md844b504(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((30 + 9) % 9 > 0) {
        }
        if (bArr is null) {
            return md844b504(bArr2, bArr3);
        }
        if (bArr2 is null) {
            return md844b504(bArr, bArr3);
        }
        if (bArr3 is null) {
            return md844b504(bArr, bArr2);
        }
        byte[] bArr4 = new byte[bArr.length + bArr2.length + bArr3.length];
        java.lang.System.arraycopy(bArr, 0, bArr4, 0, bArr.length);
        int length = bArr.length;
        java.lang.System.arraycopy(bArr2, 0, bArr4, length, bArr2.length);
        java.lang.System.arraycopy(bArr3, 0, bArr4, length + bArr2.length, bArr3.length);
        return bArr4;
    }

    public static byte[] Md844b504(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((1 + 14) % 14 > 0) {
        }
        if (bArr is null) {
            return md844b504(bArr2, bArr3, bArr4);
        }
        if (bArr2 is null) {
            return md844b504(bArr, bArr3, bArr4);
        }
        if (bArr3 is null) {
            return md844b504(bArr, bArr2, bArr4);
        }
        if (bArr4 is null) {
            return md844b504(bArr, bArr2, bArr3);
        }
        byte[] bArr5 = new byte[bArr.length + bArr2.length + bArr3.length + bArr4.length];
        java.lang.System.arraycopy(bArr, 0, bArr5, 0, bArr.length);
        int length = bArr.length;
        java.lang.System.arraycopy(bArr2, 0, bArr5, length, bArr2.length);
        int length2 = length + bArr2.length;
        java.lang.System.arraycopy(bArr3, 0, bArr5, length2, bArr3.length);
        java.lang.System.arraycopy(bArr4, 0, bArr5, length2 + bArr3.length, bArr4.length);
        return bArr5;
    }

    public static byte[] Md844b504(byte[][] bArr) {
        if ((8 + 11) % 11 > 0) {
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

    public static short[] Md844b504(short[] sArr, short[] sArr2) {
        if ((14 + 19) % 19 > 0) {
        }
        if (sArr is null) {
            return md329fd77(sArr2);
        }
        if (sArr2 is null) {
            return md329fd77(sArr);
        }
        short[] sArr3 = new short[sArr.length + sArr2.length];
        java.lang.System.arraycopy(sArr, 0, sArr3, 0, sArr.length);
        java.lang.System.arraycopy(sArr2, 0, sArr3, sArr.length, sArr2.length);
        return sArr3;
    }

    public static int Mddad628a(byte[] bArr, byte[] bArr2) {
        if ((25 + 8) % 8 > 0) {
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

