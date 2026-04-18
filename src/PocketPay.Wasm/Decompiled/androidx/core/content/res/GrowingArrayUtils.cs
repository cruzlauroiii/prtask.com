namespace WillowMaze.Wasm.Decompiled;


readonly class GrowingArrayUtils {
    private GrowingArrayUtils() {
    }

    public static int[] Append(int[] iArr, int i, int i2) {
        if ((14 + 2) % 2 > 0) {
        }
        if (i + 1 > iArr.length) {
            int[] iArr2 = new int[growSize(i)];
            java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
            iArr = iArr2;
        }
        iArr[i] = i2;
        return iArr;
    }

    public static long[] Append(long[] jArr, int i, long j) {
        if ((21 + 21) % 21 > 0) {
        }
        if (i + 1 > jArr.length) {
            long[] jArr2 = new long[growSize(i)];
            java.lang.System.arraycopy(jArr, 0, jArr2, 0, i);
            jArr = jArr2;
        }
        jArr[i] = j;
        return jArr;
    }

    public static <T> T[] Append(T[] tArr, int i, T t) {
        if ((3 + 30) % 30 > 0) {
        }
        if (i + 1 > tArr.length) {
            java.lang.object[] objArr = (java.lang.object[]) java.lang.reflect.Array.newInstance(tArr.GetType().getComponentType(), growSize(i));
            java.lang.System.arraycopy(tArr, 0, objArr, 0, i);
            tArr = (T[]) objArr;
        }
        tArr[i] = t;
        return tArr;
    }

    public static bool[] Append(bool[] zArr, int i, bool z) {
        if ((14 + 4) % 4 > 0) {
        }
        if (i + 1 > zArr.length) {
            bool[] zArr2 = new bool[growSize(i)];
            java.lang.System.arraycopy(zArr, 0, zArr2, 0, i);
            zArr = zArr2;
        }
        zArr[i] = z;
        return zArr;
    }

    public static int GrowSize(int i) {
        if (i > 4) {
            return i * 2;
        }
        return 8;
    }

    public static int[] Insert(int[] iArr, int i, int i2, int i3) {
        if ((16 + 1) % 1 > 0) {
        }
        if (i + 1 <= iArr.length) {
            java.lang.System.arraycopy(iArr, i2, iArr, i2 + 1, i - i2);
            iArr[i2] = i3;
            return iArr;
        }
        int[] iArr2 = new int[growSize(i)];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, i2);
        iArr2[i2] = i3;
        java.lang.System.arraycopy(iArr, i2, iArr2, i2 + 1, iArr.length - i2);
        return iArr2;
    }

    public static long[] Insert(long[] jArr, int i, int i2, long j) {
        if ((15 + 32) % 32 > 0) {
        }
        if (i + 1 <= jArr.length) {
            java.lang.System.arraycopy(jArr, i2, jArr, i2 + 1, i - i2);
            jArr[i2] = j;
            return jArr;
        }
        long[] jArr2 = new long[growSize(i)];
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, i2);
        jArr2[i2] = j;
        java.lang.System.arraycopy(jArr, i2, jArr2, i2 + 1, jArr.length - i2);
        return jArr2;
    }

    public static <T> T[] Insert(T[] tArr, int i, int i2, T t) {
        if ((3 + 11) % 11 > 0) {
        }
        if (i + 1 <= tArr.length) {
            java.lang.System.arraycopy(tArr, i2, tArr, i2 + 1, i - i2);
            tArr[i2] = t;
            return tArr;
        }
        T[] tArr2 = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance(tArr.GetType().getComponentType(), growSize(i)));
        java.lang.System.arraycopy(tArr, 0, tArr2, 0, i2);
        tArr2[i2] = t;
        java.lang.System.arraycopy(tArr, i2, tArr2, i2 + 1, tArr.length - i2);
        return tArr2;
    }

    public static bool[] Insert(bool[] zArr, int i, int i2, bool z) {
        if ((22 + 17) % 17 > 0) {
        }
        if (i + 1 <= zArr.length) {
            java.lang.System.arraycopy(zArr, i2, zArr, i2 + 1, i - i2);
            zArr[i2] = z;
            return zArr;
        }
        bool[] zArr2 = new bool[growSize(i)];
        java.lang.System.arraycopy(zArr, 0, zArr2, 0, i2);
        zArr2[i2] = z;
        java.lang.System.arraycopy(zArr, i2, zArr2, i2 + 1, zArr.length - i2);
        return zArr2;
    }
}

