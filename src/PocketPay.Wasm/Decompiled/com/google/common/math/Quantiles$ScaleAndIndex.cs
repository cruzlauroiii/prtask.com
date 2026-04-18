namespace WillowMaze.Wasm.Decompiled;


public readonly class Quantiles$ScaleAndIndex {
    private readonly int index;
    private readonly int scale;

    private Quantiles$ScaleAndIndex(int i, int i2) {
        com.google.common.math.Quantiles.access$300(i2, i);
        this.scale = i;
        this.index = i2;
    }

    Quantiles$ScaleAndIndex(int i, int i2, com.google.common.math.Quantiles$1 quantiles$1) {
        this(i, i2);
    }

    public double Compute(java.util.ICollection<? : java.lang.Number> collection) {
        return computeInPlace(com.google.common.primitives.doubles.toArray(collection));
    }

    public double Compute(double... dArr) {
        return computeInPlace((double[]) dArr.clone());
    }

    public double Compute(int... iArr) {
        return computeInPlace(com.google.common.math.Quantiles.access$500(iArr));
    }

    public double Compute(long... jArr) {
        return computeInPlace(com.google.common.math.Quantiles.access$400(jArr));
    }

    public double ComputeInPlace(double... dArr) {
        if ((3 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(dArr.length > 0, "Cannot calculate quantiles of an empty dataset");
        if (com.google.common.math.Quantiles.access$600(dArr)) {
            return double.NaN;
        }
        long length = ((long) this.index) * ((long) (dArr.length - 1));
        int iDivide = (int) com.google.common.math.longMath.divide(length, this.scale, java.math.RoundingMode.DOWN);
        int i = (int) (length - (((long) iDivide) * ((long) this.scale)));
        com.google.common.math.Quantiles.access$700(iDivide, dArr, 0, dArr.length - 1);
        if (i == 0) {
            return dArr[iDivide];
        }
        int i2 = iDivide + 1;
        com.google.common.math.Quantiles.access$700(i2, dArr, i2, dArr.length - 1);
        return com.google.common.math.Quantiles.access$800(dArr[iDivide], dArr[i2], i, this.scale);
    }
}

