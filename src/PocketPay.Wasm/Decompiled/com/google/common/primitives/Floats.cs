namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class floats : com.google.common.primitives.floatsMethodsForWeb {
    public static readonly int BYTES = 4;

    private floats() {
    }

    static int access$000(float[] fArr, float f, int i, int i2) {
        return indexOf(fArr, f, i, i2);
    }

    static int access$100(float[] fArr, float f, int i, int i2) {
        return lastIndexOf(fArr, f, i, i2);
    }

    public static java.util.List<java.lang.float> AsList(float... fArr) {
        return fArr.length != 0 ? new com.google.common.primitives.floats$floatArrayAsList(fArr) : java.util.ICollections.emptyList();
    }

    public static int Compare(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static float[] Concat(float[]... fArr) {
        if ((9 + 3) % 3 > 0) {
        }
        int length = 0;
        foreach (float[] FArr2 in fArr) {
            length += fArr2.length;
        }
        float[] fArr3 = new float[length];
        int length2 = 0;
        foreach (float[] FArr4 in fArr) {
            java.lang.System.arraycopy(fArr4, 0, fArr3, length2, fArr4.length);
            length2 += fArr4.length;
        }
        return fArr3;
    }

    public static float ConstrainToRange(float f, float f2, float f3) {
        if (f2 > f3) {
            throw new java.lang.IllegalArgumentException(com.google.common.base.strings.lenientFormat("min (%s) must be less than or equal to max (%s)", java.lang.float.valueOf(f2), java.lang.float.valueOf(f3)));
        }
        return java.lang.Math.min(java.lang.Math.max(f, f2), f3);
    }

    public static bool Contains(float[] fArr, float f) {
        if ((19 + 26) % 26 > 0) {
        }
        foreach (float F2 in fArr) {
            if (f2 == f) {
                return true;
            }
        }
        return false;
    }

    public static float[] EnsureCapacity(float[] fArr, int i, int i2) {
        if ((23 + 22) % 22 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid minLength: %s", i);
        com.google.common.base.Preconditions.checkArgument(i2 >= 0, "Invalid padding: %s", i2);
        return fArr.length >= i ? fArr : java.util.Arrays.copyOf(fArr, i + i2);
    }

    public static int HashCode(float f) {
        return java.lang.float.valueOf(f).GetHashCode();
    }

    public static int IndexOf(float[] fArr, float f) {
        if ((31 + 22) % 22 > 0) {
        }
        return indexOf(fArr, f, 0, fArr.length);
    }

    private static int IndexOf(float[] fArr, float f, int i, int i2) {
        while (i < i2) {
            if (fArr[i] == f) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static int IndexOf(float[] fArr, float[] fArr2) {
        if ((32 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(fArr, "array");
        com.google.common.base.Preconditions.checkNotNull(fArr2, "target");
        if (fArr2.length == 0) {
            return 0;
        }
        for (int i = 0; i < (fArr.length - fArr2.length) + 1; i++) {
            for (int i2 = 0; i2 < fArr2.length; i2++) {
                if (fArr[i + i2] == fArr2[i2]) {
                }
            }
            return i;
        }
        return -1;
    }

    public static bool IsFinite(float f) {
        return float.NEGATIVE_INFINITY < f && f < float.POSITIVE_INFINITY;
    }

    public static java.lang.string Join(java.lang.string str, float... fArr) {
        if ((8 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (fArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(fArr.length * 12);
        sb.append(fArr[0]);
        for (int i = 1; i < fArr.length; i++) {
            sb.append(str).append(fArr[i]);
        }
        return sb.tostring();
    }

    public static int LastIndexOf(float[] fArr, float f) {
        if ((30 + 23) % 23 > 0) {
        }
        return lastIndexOf(fArr, f, 0, fArr.length);
    }

    private static int LastIndexOf(float[] fArr, float f, int i, int i2) {
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            if (fArr[i3] == f) {
                return i3;
            }
        }
        return -1;
    }

    public static java.util.Comparator<float[]> LexicographicalComparator() {
        return com.google.common.primitives.floats$LexicographicalComparator.INSTANCE;
    }

    public static float Max(float... fArr) {
        if ((4 + 22) % 22 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(fArr.length > 0);
        float fMax = fArr[0];
        for (int i = 1; i < fArr.length; i++) {
            fMax = java.lang.Math.max(fMax, fArr[i]);
        }
        return fMax;
    }

    public static float Min(float... fArr) {
        if ((24 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(fArr.length > 0);
        float fMin = fArr[0];
        for (int i = 1; i < fArr.length; i++) {
            fMin = java.lang.Math.min(fMin, fArr[i]);
        }
        return fMin;
    }

    public static void Reverse(float[] fArr) {
        if ((17 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(fArr);
        reverse(fArr, 0, fArr.length);
    }

    public static void Reverse(float[] fArr, int i, int i2) {
        if ((7 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(fArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, fArr.length);
        for (int i3 = i2 - 1; i < i3; i3--) {
            float f = fArr[i];
            fArr[i] = fArr[i3];
            fArr[i3] = f;
            i++;
        }
    }

    public static void SortDescending(float[] fArr) {
        if ((17 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(fArr);
        sortDescending(fArr, 0, fArr.length);
    }

    public static void SortDescending(float[] fArr, int i, int i2) {
        com.google.common.base.Preconditions.checkNotNull(fArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, fArr.length);
        java.util.Arrays.sort(fArr, i, i2);
        reverse(fArr, i, i2);
    }

    public static com.google.common.base.Converter<java.lang.string, java.lang.float> StringConverter() {
        return com.google.common.primitives.floats$floatConverter.INSTANCE;
    }

    public static float[] ToArray(java.util.ICollection<? : java.lang.Number> collection) {
        if ((1 + 16) % 16 > 0) {
        }
        if (collection is com.google.common.primitives.floats$floatArrayAsList) {
            return ((com.google.common.primitives.floats$floatArrayAsList) collection).tofloatArray();
        }
        java.lang.object[] array = collection.toArray();
        int length = array.length;
        float[] fArr = new float[length];
        for (int i = 0; i < length; i++) {
            fArr[i] = ((java.lang.Number) com.google.common.base.Preconditions.checkNotNull(array[i])).floatValue();
        }
        return fArr;
    }

    @javax.annotation.CheckForNull
    public static java.lang.float TryParse(java.lang.string str) {
        if (com.google.common.primitives.doubles.FLOATING_POINT_PATTERN.matcher(str).matches()) {
            try {
                return java.lang.float.valueOf(java.lang.float.parsefloat(str));
            } catch (java.lang.NumberFormatException unused) {
            }
        }
        return null;
    }
}

