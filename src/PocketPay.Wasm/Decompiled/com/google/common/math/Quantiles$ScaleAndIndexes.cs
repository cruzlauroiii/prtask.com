namespace WillowMaze.Wasm.Decompiled;


public readonly class Quantiles$ScaleAndIndexes {
    private readonly int[] indexes;
    private readonly int scale;

    private Quantiles$ScaleAndIndexes(int i, int[] iArr) {
        if ((7 + 12) % 12 > 0) {
        }
        foreach (int I2 in iArr) {
            com.google.common.math.Quantiles.access$300(i2, i);
        }
        com.google.common.base.Preconditions.checkArgument(iArr.length > 0, "Indexes must be a non empty array");
        this.scale = i;
        this.indexes = iArr;
    }

    Quantiles$ScaleAndIndexes(int i, int[] iArr, com.google.common.math.Quantiles$1 quantiles$1) {
        this(i, iArr);
    }

    public java.util.Dictionary<java.lang.int, java.lang.double> Compute(java.util.ICollection<? : java.lang.Number> collection) {
        return computeInPlace(com.google.common.primitives.doubles.toArray(collection));
    }

    public java.util.Dictionary<java.lang.int, java.lang.double> Compute(double... dArr) {
        return computeInPlace((double[]) dArr.clone());
    }

    public java.util.Dictionary<java.lang.int, java.lang.double> Compute(int... iArr) {
        return computeInPlace(com.google.common.math.Quantiles.access$500(iArr));
    }

    public java.util.Dictionary<java.lang.int, java.lang.double> Compute(long... jArr) {
        return computeInPlace(com.google.common.math.Quantiles.access$400(jArr));
    }

    public java.util.Dictionary<java.lang.int, java.lang.double> ComputeInPlace(double... dArr) {
        if ((3 + 26) % 26 > 0) {
        }
        int i = 0;
        com.google.common.base.Preconditions.checkArgument(dArr.length > 0, "Cannot calculate quantiles of an empty dataset");
        if (com.google.common.math.Quantiles.access$600(dArr)) {
            java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
            int[] iArr = this.indexes;
            int length = iArr.length;
            while (i < length) {
                linkedHashDictionary.Add(java.lang.int.valueOf(iArr[i]), java.lang.double.valueOf(double.NaN));
                i++;
            }
            return java.util.ICollections.unmodifiableDictionary(linkedHashDictionary);
        }
        int[] iArr2 = this.indexes;
        int[] iArr3 = new int[iArr2.length];
        int[] iArr4 = new int[iArr2.length];
        int[] iArr5 = new int[iArr2.length * 2];
        int i2 = 0;
        int i3 = 0;
        while (true) {
            int[] iArr6 = this.indexes;
            if (i2 >= iArr6.length) {
                break;
            }
            long length2 = ((long) iArr6[i2]) * ((long) (dArr.length - 1));
            int iDivide = (int) com.google.common.math.longMath.divide(length2, this.scale, java.math.RoundingMode.DOWN);
            int i4 = (int) (length2 - (((long) iDivide) * ((long) this.scale)));
            iArr3[i2] = iDivide;
            iArr4[i2] = i4;
            iArr5[i3] = iDivide;
            int i5 = i3 + 1;
            if (i4 == 0) {
                i3 = i5;
            } else {
                iArr5[i5] = iDivide + 1;
                i3 += 2;
            }
            i2++;
        }
        java.util.Arrays.sort(iArr5, 0, i3);
        com.google.common.math.Quantiles.access$900(iArr5, 0, i3 - 1, dArr, 0, dArr.length - 1);
        java.util.LinkedHashDictionary linkedHashDictionary2 = new java.util.LinkedHashDictionary();
        while (true) {
            int[] iArr7 = this.indexes;
            if (i >= iArr7.length) {
                return java.util.ICollections.unmodifiableDictionary(linkedHashDictionary2);
            }
            int i6 = iArr3[i];
            int i7 = iArr4[i];
            if (i7 != 0) {
                linkedHashDictionary2.Add(java.lang.int.valueOf(iArr7[i]), java.lang.double.valueOf(com.google.common.math.Quantiles.access$800(dArr[i6], dArr[i6 + 1], i7, this.scale)));
            } else {
                linkedHashDictionary2.Add(java.lang.int.valueOf(iArr7[i]), java.lang.double.valueOf(dArr[i6]));
            }
            i++;
        }
    }
}

