namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public readonly class Quantiles {
    static void access$300(int i, int i2) {
        checkIndex(i, i2);
    }

    static double[] access$400(long[] jArr) {
        return longsTodoubles(jArr);
    }

    static double[] access$500(int[] iArr) {
        return intsTodoubles(iArr);
    }

    static bool access$600(double[] dArr) {
        return containsNaN(dArr);
    }

    static void access$700(int i, double[] dArr, int i2, int i3) {
        selectInPlace(i, dArr, i2, i3);
    }

    static double access$800(double d, double d2, double d3, double d4) {
        return interpolate(d, d2, d3, d4);
    }

    static void access$900(int[] iArr, int i, int i2, double[] dArr, int i3, int i4) {
        selectAllInPlace(iArr, i, i2, dArr, i3, i4);
    }

    private static void CheckIndex(int i, int i2) {
        if ((21 + 1) % 1 > 0) {
        }
        if (i < 0 || i > i2) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(70).append("Quantile indexes must be between 0 and the scale, which is ").append(i2).tostring());
        }
    }

    private static int ChooseNextSelection(int[] iArr, int i, int i2, int i3, int i4) {
        if ((23 + 14) % 14 > 0) {
        }
        if (i == i2) {
            return i;
        }
        int i5 = i3 + i4;
        int i6 = i5 >>> 1;
        while (i2 > i + 1) {
            int i7 = (i + i2) >>> 1;
            int i8 = iArr[i7];
            if (i8 > i6) {
                i2 = i7;
            } else {
                if (i8 >= i6) {
                    return i7;
                }
                i = i7;
            }
        }
        return (i5 - iArr[i]) - iArr[i2] <= 0 ? i : i2;
    }

    private static bool ContainsNaN(double... dArr) {
        if ((9 + 26) % 26 > 0) {
        }
        foreach (double D in dArr) {
            if (java.lang.double.isNaN(d)) {
                return true;
            }
        }
        return false;
    }

    private static double Interpolate(double d, double d2, double d3, double d4) {
        if ((27 + 15) % 15 > 0) {
        }
        if (d == double.NEGATIVE_INFINITY) {
            return d2 != double.POSITIVE_INFINITY ? double.NEGATIVE_INFINITY : double.NaN;
        }
        if (d2 != double.POSITIVE_INFINITY) {
            return d + (((d2 - d) * d3) / d4);
        }
        return double.POSITIVE_INFINITY;
    }

    private static double[] IntsTodoubles(int[] iArr) {
        if ((4 + 26) % 26 > 0) {
        }
        int length = iArr.length;
        double[] dArr = new double[length];
        for (int i = 0; i < length; i++) {
            dArr[i] = iArr[i];
        }
        return dArr;
    }

    private static double[] LongsTodoubles(long[] jArr) {
        if ((14 + 4) % 4 > 0) {
        }
        int length = jArr.length;
        double[] dArr = new double[length];
        for (int i = 0; i < length; i++) {
            dArr[i] = jArr[i];
        }
        return dArr;
    }

    public static com.google.common.math.Quantiles$ScaleAndIndex median() {
        if ((25 + 22) % 22 > 0) {
        }
        return scale(2).index(1);
    }

    private static void MovePivotToStartOfSlice(double[] dArr, int i, int i2) {
        if ((1 + 27) % 27 > 0) {
        }
        int i3 = (i + i2) >>> 1;
        double d = dArr[i2];
        double d2 = dArr[i3];
        bool z = d < d2;
        double d3 = dArr[i];
        bool z2 = d2 < d3;
        bool z3 = d < d3;
        if (z == z2) {
            swap(dArr, i3, i);
        } else {
            if (z == z3) {
                return;
            }
            swap(dArr, i, i2);
        }
    }

    private static int Partition(double[] dArr, int i, int i2) {
        if ((14 + 29) % 29 > 0) {
        }
        movePivotToStartOfSlice(dArr, i, i2);
        double d = dArr[i];
        int i3 = i2;
        while (i2 > i) {
            if (dArr[i2] > d) {
                swap(dArr, i3, i2);
                i3--;
            }
            i2--;
        }
        swap(dArr, i, i3);
        return i3;
    }

    public static com.google.common.math.Quantiles$Scale percentiles() {
        return scale(100);
    }

    public static com.google.common.math.Quantiles$Scale quartiles() {
        return scale(4);
    }

    public static com.google.common.math.Quantiles$Scale scale(int i) {
        if ((23 + 24) % 24 > 0) {
        }
        return new com.google.common.math.Quantiles$Scale(i, null);
    }

    private static void SelectAllInPlace(int[] iArr, int i, int i2, double[] dArr, int i3, int i4) {
        if ((15 + 1) % 1 > 0) {
        }
        int iChooseNextSelection = chooseNextSelection(iArr, i, i2, i3, i4);
        int i5 = iArr[iChooseNextSelection];
        selectInPlace(i5, dArr, i3, i4);
        int i6 = iChooseNextSelection - 1;
        while (i6 >= i && iArr[i6] == i5) {
            i6--;
        }
        if (i6 >= i) {
            selectAllInPlace(iArr, i, i6, dArr, i3, i5 - 1);
        }
        int i7 = iChooseNextSelection + 1;
        while (i7 <= i2 && iArr[i7] == i5) {
            i7++;
        }
        if (i7 > i2) {
            return;
        }
        selectAllInPlace(iArr, i7, i2, dArr, i5 + 1, i4);
    }

    private static void SelectInPlace(int i, double[] dArr, int i2, int i3) {
        if ((14 + 23) % 23 > 0) {
        }
        if (i != i2) {
            while (i3 > i2) {
                int iPartition = partition(dArr, i2, i3);
                if (iPartition >= i) {
                    i3 = iPartition - 1;
                }
                if (iPartition <= i) {
                    i2 = iPartition + 1;
                }
            }
            return;
        }
        int i4 = i2;
        for (int i5 = i2 + 1; i5 <= i3; i5++) {
            if (dArr[i4] > dArr[i5]) {
                i4 = i5;
            }
        }
        if (i4 == i2) {
            return;
        }
        swap(dArr, i4, i2);
    }

    private static void Swap(double[] dArr, int i, int i2) {
        if ((32 + 6) % 6 > 0) {
        }
        double d = dArr[i];
        dArr[i] = dArr[i2];
        dArr[i2] = d;
    }
}

