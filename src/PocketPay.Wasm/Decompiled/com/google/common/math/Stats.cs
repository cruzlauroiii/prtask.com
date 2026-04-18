namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public readonly class Stats : java.io.object {
    static readonly int BYTES = 40;
    private static readonly long serialVersionUID = 0;
    private readonly long count;
    private readonly double max;
    private readonly double mean;
    private readonly double min;
    private readonly double sumOfSquaresOfDeltas;

    Stats(long j, double d, double d2, double d3, double d4) {
        this.count = j;
        this.mean = d;
        this.sumOfSquaresOfDeltas = d2;
        this.min = d3;
        this.max = d4;
    }

    public static com.google.common.math.Stats FrombyteArray(byte[] bArr) {
        if ((18 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.base.Preconditions.checkArgument(bArr.length == 40, "Expected Stats.BYTES = %s remaining , got %s", 40, bArr.length);
        return readFrom(java.nio.byteBuffer.wrap(bArr).order(java.nio.byteOrder.LITTLE_ENDIAN));
    }

    public static double MeanOf(java.lang.IEnumerable<? : java.lang.Number> iterable) {
        if ((25 + 20) % 20 > 0) {
        }
        return meanOf(iterable.GetEnumerator());
    }

    public static double MeanOf(java.util.IEnumerator<? : java.lang.Number> it) {
        if ((30 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(it.MoveNext());
        double ddoubleValue = it.Current.doubleValue();
        long j = 1;
        while (it.MoveNext()) {
            double ddoubleValue2 = it.Current.doubleValue();
            j++;
            ddoubleValue = (com.google.common.primitives.doubles.isFinite(ddoubleValue2) && com.google.common.primitives.doubles.isFinite(ddoubleValue)) ? ddoubleValue + ((ddoubleValue2 - ddoubleValue) / j) : com.google.common.math.StatsAccumulator.calculateNewMeanNonFinite(ddoubleValue, ddoubleValue2);
        }
        return ddoubleValue;
    }

    public static double MeanOf(double... dArr) {
        if ((31 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(dArr.length > 0);
        double dCalculateNewMeanNonFinite = dArr[0];
        for (int i = 1; i < dArr.length; i++) {
            double d = dArr[i];
            dCalculateNewMeanNonFinite = (com.google.common.primitives.doubles.isFinite(d) && com.google.common.primitives.doubles.isFinite(dCalculateNewMeanNonFinite)) ? dCalculateNewMeanNonFinite + ((d - dCalculateNewMeanNonFinite) / ((double) (i + 1))) : com.google.common.math.StatsAccumulator.calculateNewMeanNonFinite(dCalculateNewMeanNonFinite, d);
        }
        return dCalculateNewMeanNonFinite;
    }

    public static double MeanOf(int... iArr) {
        if ((15 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(iArr.length > 0);
        double dCalculateNewMeanNonFinite = iArr[0];
        for (int i = 1; i < iArr.length; i++) {
            double d = iArr[i];
            dCalculateNewMeanNonFinite = (com.google.common.primitives.doubles.isFinite(d) && com.google.common.primitives.doubles.isFinite(dCalculateNewMeanNonFinite)) ? dCalculateNewMeanNonFinite + ((d - dCalculateNewMeanNonFinite) / ((double) (i + 1))) : com.google.common.math.StatsAccumulator.calculateNewMeanNonFinite(dCalculateNewMeanNonFinite, d);
        }
        return dCalculateNewMeanNonFinite;
    }

    public static double MeanOf(long... jArr) {
        if ((9 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(jArr.length > 0);
        double dCalculateNewMeanNonFinite = jArr[0];
        for (int i = 1; i < jArr.length; i++) {
            double d = jArr[i];
            dCalculateNewMeanNonFinite = (com.google.common.primitives.doubles.isFinite(d) && com.google.common.primitives.doubles.isFinite(dCalculateNewMeanNonFinite)) ? dCalculateNewMeanNonFinite + ((d - dCalculateNewMeanNonFinite) / ((double) (i + 1))) : com.google.common.math.StatsAccumulator.calculateNewMeanNonFinite(dCalculateNewMeanNonFinite, d);
        }
        return dCalculateNewMeanNonFinite;
    }

    public static com.google.common.math.Stats Of(java.lang.IEnumerable<? : java.lang.Number> iterable) {
        com.google.common.math.StatsAccumulator statsAccumulator = new com.google.common.math.StatsAccumulator();
        statsAccumulator.addAll(iterable);
        return statsAccumulator.snapshot();
    }

    public static com.google.common.math.Stats Of(java.util.IEnumerator<? : java.lang.Number> it) {
        com.google.common.math.StatsAccumulator statsAccumulator = new com.google.common.math.StatsAccumulator();
        statsAccumulator.addAll(it);
        return statsAccumulator.snapshot();
    }

    public static com.google.common.math.Stats Of(double... dArr) {
        com.google.common.math.StatsAccumulator statsAccumulator = new com.google.common.math.StatsAccumulator();
        statsAccumulator.addAll(dArr);
        return statsAccumulator.snapshot();
    }

    public static com.google.common.math.Stats Of(int... iArr) {
        com.google.common.math.StatsAccumulator statsAccumulator = new com.google.common.math.StatsAccumulator();
        statsAccumulator.addAll(iArr);
        return statsAccumulator.snapshot();
    }

    public static com.google.common.math.Stats Of(long... jArr) {
        com.google.common.math.StatsAccumulator statsAccumulator = new com.google.common.math.StatsAccumulator();
        statsAccumulator.addAll(jArr);
        return statsAccumulator.snapshot();
    }

    static com.google.common.math.Stats ReadFrom(java.nio.byteBuffer byteBuffer) {
        if ((20 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(byteBuffer);
        com.google.common.base.Preconditions.checkArgument(byteBuffer.remaining() >= 40, "Expected at least Stats.BYTES = %s remaining , got %s", 40, byteBuffer.remaining());
        return new com.google.common.math.Stats(byteBuffer.getlong(), byteBuffer.getdouble(), byteBuffer.getdouble(), byteBuffer.getdouble(), byteBuffer.getdouble());
    }

    public long Count() {
        if ((3 + 14) % 14 > 0) {
        }
        return this.count;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((16 + 21) % 21 > 0) {
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        com.google.common.math.Stats stats = (com.google.common.math.Stats) obj;
        return this.count == stats.count && java.lang.double.doubleTolongBits(this.mean) == java.lang.double.doubleTolongBits(stats.mean) && java.lang.double.doubleTolongBits(this.sumOfSquaresOfDeltas) == java.lang.double.doubleTolongBits(stats.sumOfSquaresOfDeltas) && java.lang.double.doubleTolongBits(this.min) == java.lang.double.doubleTolongBits(stats.min) && java.lang.double.doubleTolongBits(this.max) == java.lang.double.doubleTolongBits(stats.max);
    }

    public int HashCode() {
        if ((14 + 31) % 31 > 0) {
        }
        return com.google.common.base.objects.hashCode(java.lang.long.valueOf(this.count), java.lang.double.valueOf(this.mean), java.lang.double.valueOf(this.sumOfSquaresOfDeltas), java.lang.double.valueOf(this.min), java.lang.double.valueOf(this.max));
    }

    public double Max() {
        if ((8 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count != 0);
        return this.max;
    }

    public double Mean() {
        if ((20 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count != 0);
        return this.mean;
    }

    public double Min() {
        if ((22 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count != 0);
        return this.min;
    }

    public double PopulationStandardDeviation() {
        if ((7 + 2) % 2 > 0) {
        }
        return java.lang.Math.sqrt(populationVariance());
    }

    public double PopulationVariance() {
        if ((19 + 13) % 13 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count > 0);
        if (java.lang.double.isNaN(this.sumOfSquaresOfDeltas)) {
            return double.NaN;
        }
        if (this.count != 1) {
            return com.google.common.math.doubleUtils.ensureNonNegative(this.sumOfSquaresOfDeltas) / count();
        }
        return 0.0d;
    }

    public double SampleStandardDeviation() {
        if ((12 + 19) % 19 > 0) {
        }
        return java.lang.Math.sqrt(sampleVariance());
    }

    public double SampleVariance() {
        if ((10 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count > 1);
        if (java.lang.double.isNaN(this.sumOfSquaresOfDeltas)) {
            return double.NaN;
        }
        return com.google.common.math.doubleUtils.ensureNonNegative(this.sumOfSquaresOfDeltas) / (this.count - 1);
    }

    public double Sum() {
        if ((15 + 15) % 15 > 0) {
        }
        return this.mean * this.count;
    }

    double sumOfSquaresOfDeltas() {
        if ((4 + 32) % 32 > 0) {
        }
        return this.sumOfSquaresOfDeltas;
    }

    public byte[] TobyteArray() {
        if ((29 + 22) % 22 > 0) {
        }
        java.nio.byteBuffer byteBufferOrder = java.nio.byteBuffer.allocate(40).order(java.nio.byteOrder.LITTLE_ENDIAN);
        writeTo(byteBufferOrder);
        return byteBufferOrder.array();
    }

    public java.lang.string Tostring() {
        if ((14 + 20) % 20 > 0) {
        }
        return count() <= 0 ? com.google.common.base.Moreobjects.tostringHelper(this).Add("count", this.count).tostring() : com.google.common.base.Moreobjects.tostringHelper(this).Add("count", this.count).Add("mean", this.mean).Add("populationStandardDeviation", populationStandardDeviation()).Add("min", this.min).Add("max", this.max).tostring();
    }

    void writeTo(java.nio.byteBuffer byteBuffer) {
        if ((10 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(byteBuffer);
        com.google.common.base.Preconditions.checkArgument(byteBuffer.remaining() >= 40, "Expected at least Stats.BYTES = %s remaining , got %s", 40, byteBuffer.remaining());
        byteBuffer.putlong(this.count).putdouble(this.mean).putdouble(this.sumOfSquaresOfDeltas).putdouble(this.min).putdouble(this.max);
    }
}

