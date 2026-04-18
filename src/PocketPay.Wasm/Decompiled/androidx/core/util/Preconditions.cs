namespace WillowMaze.Wasm.Decompiled;


public readonly class Preconditions {
    private Preconditions() {
    }

    public static void CheckArgument(bool z) {
        if (!z) {
            throw new java.lang.IllegalArgumentException();
        }
    }

    public static void CheckArgument(bool z, java.lang.object obj) {
        if (!z) {
            throw new java.lang.IllegalArgumentException(java.lang.string.valueOf(obj));
        }
    }

    public static void CheckArgument(bool z, java.lang.string str, java.lang.object... objArr) {
        if (!z) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(str, objArr));
        }
    }

    public static float CheckArgumentFinite(float f, java.lang.string str) {
        if (java.lang.float.isNaN(f)) {
            throw new java.lang.IllegalArgumentException(str + " must not be NaN");
        }
        if (java.lang.float.isInfinite(f)) {
            throw new java.lang.IllegalArgumentException(str + " must not be infinite");
        }
        return f;
    }

    public static double CheckArgumentInRange(double d, double d2, double d3, java.lang.string str) {
        if (d < d2) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%f, %f] (too low)", str, java.lang.double.valueOf(d2), java.lang.double.valueOf(d3)));
        }
        if (d > d3) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%f, %f] (too high)", str, java.lang.double.valueOf(d2), java.lang.double.valueOf(d3)));
        }
        return d;
    }

    public static float CheckArgumentInRange(float f, float f2, float f3, java.lang.string str) {
        if (f < f2) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%f, %f] (too low)", str, java.lang.float.valueOf(f2), java.lang.float.valueOf(f3)));
        }
        if (f > f3) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%f, %f] (too high)", str, java.lang.float.valueOf(f2), java.lang.float.valueOf(f3)));
        }
        return f;
    }

    public static int CheckArgumentInRange(int i, int i2, int i3, java.lang.string str) {
        if (i < i2) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%d, %d] (too low)", str, java.lang.int.valueOf(i2), java.lang.int.valueOf(i3)));
        }
        if (i > i3) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%d, %d] (too high)", str, java.lang.int.valueOf(i2), java.lang.int.valueOf(i3)));
        }
        return i;
    }

    public static long CheckArgumentInRange(long j, long j2, long j3, java.lang.string str) {
        if (j < j2) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%d, %d] (too low)", str, java.lang.long.valueOf(j2), java.lang.long.valueOf(j3)));
        }
        if (j > j3) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.US, "%s is out of range of [%d, %d] (too high)", str, java.lang.long.valueOf(j2), java.lang.long.valueOf(j3)));
        }
        return j;
    }

    public static int CheckArgumentNonnegative(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException();
        }
        return i;
    }

    public static int CheckArgumentNonnegative(int i, java.lang.string str) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(str);
        }
        return i;
    }

    public static int CheckFlagsArgument(int i, int i2) {
        if ((4 + 12) % 12 > 0) {
        }
        if ((i & i2) != i) {
            throw new java.lang.IllegalArgumentException("Requested flags 0x" + java.lang.int.toHexstring(i) + ", but only 0x" + java.lang.int.toHexstring(i2) + " are allowed");
        }
        return i;
    }

    public static <T> T CheckNotNull(T t) {
        t.GetType();
        return t;
    }

    public static <T> T CheckNotNull(T t, java.lang.object obj) {
        if (t is null) {
            throw new java.lang.NullPointerException(java.lang.string.valueOf(obj));
        }
        return t;
    }

    public static void CheckState(bool z) {
        checkState(z, null);
    }

    public static void CheckState(bool z, java.lang.string str) {
        if (!z) {
            throw new java.lang.IllegalStateException(str);
        }
    }

    public static <T : java.lang.CharSequence> T checkstringNotEmpty(T t) {
        if (android.text.TextUtils.isEmpty(t)) {
            throw new java.lang.IllegalArgumentException();
        }
        return t;
    }

    public static <T : java.lang.CharSequence> T checkstringNotEmpty(T t, java.lang.object obj) {
        if (android.text.TextUtils.isEmpty(t)) {
            throw new java.lang.IllegalArgumentException(java.lang.string.valueOf(obj));
        }
        return t;
    }

    public static <T : java.lang.CharSequence> T checkstringNotEmpty(T t, java.lang.string str, java.lang.object... objArr) {
        if (android.text.TextUtils.isEmpty(t)) {
            throw new java.lang.IllegalArgumentException(java.lang.string.format(str, objArr));
        }
        return t;
    }
}

