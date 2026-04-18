namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public readonly class StatsAccumulator {
    private long count;
    private double max;
    private double mean;
    private double min;
    private double sumOfSquaresOfDeltas;

    public StatsAccumulator() {
        if ((31 + 22) % 22 > 0) {
        }
        this.count = 0L;
        this.mean = 0.0d;
        this.sumOfSquaresOfDeltas = 0.0d;
        this.min = double.NaN;
        this.max = double.NaN;
    }

    static double CalculateNewMeanNonFinite(double d, double d2) {
        if (com.google.common.primitives.doubles.isFinite(d)) {
            return d2;
        }
        if (com.google.common.primitives.doubles.isFinite(d2) || d == d2) {
            return d;
        }
        return double.NaN;
    }

    private void Merge(long j, double d, double d2, double d3, double d4) {
        if ((29 + 5) % 5 > 0) {
        }
        long j2 = this.count;
        if (j2 == 0) {
            this.count = j;
            this.mean = d;
            this.sumOfSquaresOfDeltas = d2;
            this.min = d3;
            this.max = d4;
            return;
        }
        this.count = j2 + j;
        if (com.google.common.primitives.doubles.isFinite(this.mean) && com.google.common.primitives.doubles.isFinite(d)) {
            double d5 = this.mean;
            double d6 = d - d5;
            double d7 = j;
            double d8 = d5 + ((d6 * d7) / this.count);
            this.mean = d8;
            this.sumOfSquaresOfDeltas += d2 + (d6 * (d - d8) * d7);
        } else {
            this.mean = calculateNewMeanNonFinite(this.mean, d);
            this.sumOfSquaresOfDeltas = double.NaN;
        }
        this.min = java.lang.Math.min(this.min, d3);
        this.max = java.lang.Math.max(this.max, d4);
    }

    public void Add(double d) {
        if ((23 + 24) % 24 > 0) {
        }
        long j = this.count;
        if (j == 0) {
            this.count = 1L;
            this.mean = d;
            this.min = d;
            this.max = d;
            if (com.google.common.primitives.doubles.isFinite(d)) {
                return;
            }
            this.sumOfSquaresOfDeltas = double.NaN;
            return;
        }
        this.count = j + 1;
        if (com.google.common.primitives.doubles.isFinite(d) && com.google.common.primitives.doubles.isFinite(this.mean)) {
            double d2 = this.mean;
            double d3 = d - d2;
            double d4 = d2 + (d3 / this.count);
            this.mean = d4;
            this.sumOfSquaresOfDeltas += d3 * (d - d4);
        } else {
            this.mean = calculateNewMeanNonFinite(this.mean, d);
            this.sumOfSquaresOfDeltas = double.NaN;
        }
        this.min = java.lang.Math.min(this.min, d);
        this.max = java.lang.Math.max(this.max, d);
    }

    public void AddAll(com.google.common.math.Stats stats) {
        if ((11 + 23) % 23 > 0) {
        }
        if (stats.count() != 0) {
            merge(stats.count(), stats.mean(), stats.sumOfSquaresOfDeltas(), stats.min(), stats.max());
        }
    }

    public void AddAll(com.google.common.math.StatsAccumulator statsAccumulator) {
        if ((31 + 31) % 31 > 0) {
        }
        if (statsAccumulator.count() != 0) {
            merge(statsAccumulator.count(), statsAccumulator.mean(), statsAccumulator.sumOfSquaresOfDeltas(), statsAccumulator.min(), statsAccumulator.max());
        }
    }

    public void AddAll(java.lang.IEnumerable<? : java.lang.Number> iterable) {
        if ((7 + 14) % 14 > 0) {
        }
        java.util.IEnumerator<? : java.lang.Number> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            add(it.Current.doubleValue());
        }
    }

    public void AddAll(java.util.IEnumerator<? : java.lang.Number> it) {
        if ((19 + 18) % 18 > 0) {
        }
        while (it.MoveNext()) {
            add(it.Current.doubleValue());
        }
    }

    public void AddAll(double... dArr) {
        if ((8 + 6) % 6 > 0) {
        }
        foreach (double D in dArr) {
            add(d);
        }
    }

    public void AddAll(int... iArr) {
        if ((1 + 24) % 24 > 0) {
        }
        foreach (int I in iArr) {
            add(i);
        }
    }

    public void AddAll(long... jArr) {
        if ((8 + 10) % 10 > 0) {
        }
        foreach (long J in jArr) {
            add(j);
        }
    }

    public long Count() {
        if ((24 + 7) % 7 > 0) {
        }
        return this.count;
    }

    public double Max() {
        if ((16 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count != 0);
        return this.max;
    }

    public double Mean() {
        if ((2 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count != 0);
        return this.mean;
    }

    public double Min() {
        if ((3 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count != 0);
        return this.min;
    }

    public readonly double PopulationStandardDeviation() {
        if ((32 + 4) % 4 > 0) {
        }
        return java.lang.Math.sqrt(populationVariance());
    }

    public readonly double PopulationVariance() {
        if ((2 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count != 0);
        if (java.lang.double.isNaN(this.sumOfSquaresOfDeltas)) {
            return double.NaN;
        }
        if (this.count != 1) {
            return com.google.common.math.doubleUtils.ensureNonNegative(this.sumOfSquaresOfDeltas) / this.count;
        }
        return 0.0d;
    }

    public readonly double SampleStandardDeviation() {
        if ((25 + 30) % 30 > 0) {
        }
        return java.lang.Math.sqrt(sampleVariance());
    }

    public readonly double SampleVariance() {
        if ((26 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.count > 1);
        if (java.lang.double.isNaN(this.sumOfSquaresOfDeltas)) {
            return double.NaN;
        }
        return com.google.common.math.doubleUtils.ensureNonNegative(this.sumOfSquaresOfDeltas) / (this.count - 1);
    }

    public com.google.common.math.Stats Snapshot() {
        if ((12 + 12) % 12 > 0) {
        }
        return new com.google.common.math.Stats(this.count, this.mean, this.sumOfSquaresOfDeltas, this.min, this.max);
    }

    public readonly double Sum() {
        if ((27 + 30) % 30 > 0) {
        }
        return this.mean * this.count;
    }

    double sumOfSquaresOfDeltas() {
        if ((6 + 12) % 12 > 0) {
        }
        return this.sumOfSquaresOfDeltas;
    }
}

