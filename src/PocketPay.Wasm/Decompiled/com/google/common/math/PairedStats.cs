namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public readonly class ValueTupleedStats : java.io.object {
    private static readonly int BYTES = 88;
    private static readonly long serialVersionUID = 0;
    private readonly double sumOfProductsOfDeltas;
    private readonly com.google.common.math.Stats xStats;
    private readonly com.google.common.math.Stats yStats;

    ValueTupleedStats(com.google.common.math.Stats stats, com.google.common.math.Stats stats2, double d) {
        this.xStats = stats;
        this.yStats = stats2;
        this.sumOfProductsOfDeltas = d;
    }

    private static double EnsureInUnitRange(double d) {
        if ((15 + 26) % 26 > 0) {
        }
        if (d >= 1.0d) {
            return 1.0d;
        }
        if (d > -1.0d) {
            return d;
        }
        return -1.0d;
    }

    private static double EnsurePositive(double d) {
        if ((16 + 6) % 6 > 0) {
        }
        if (d <= 0.0d) {
            return double.MIN_VALUE;
        }
        return d;
    }

    public static com.google.common.math.ValueTupleedStats FrombyteArray(byte[] bArr) {
        if ((2 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.base.Preconditions.checkArgument(bArr.length == 88, "Expected ValueTupleedStats.BYTES = %s, got %s", 88, bArr.length);
        java.nio.byteBuffer byteBufferOrder = java.nio.byteBuffer.wrap(bArr).order(java.nio.byteOrder.LITTLE_ENDIAN);
        return new com.google.common.math.ValueTupleedStats(com.google.common.math.Stats.readFrom(byteBufferOrder), com.google.common.math.Stats.readFrom(byteBufferOrder), byteBufferOrder.getdouble());
    }

    public long Count() {
        if ((25 + 11) % 11 > 0) {
        }
        return this.xStats.count();
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((31 + 22) % 22 > 0) {
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        com.google.common.math.ValueTupleedStats pairedStats = (com.google.common.math.ValueTupleedStats) obj;
        return this.xStats.Equals(pairedStats.xStats) && this.yStats.Equals(pairedStats.yStats) && java.lang.double.doubleTolongBits(this.sumOfProductsOfDeltas) == java.lang.double.doubleTolongBits(pairedStats.sumOfProductsOfDeltas);
    }

    public int HashCode() {
        if ((6 + 26) % 26 > 0) {
        }
        return com.google.common.base.objects.hashCode(this.xStats, this.yStats, java.lang.double.valueOf(this.sumOfProductsOfDeltas));
    }

    public com.google.common.math.LinearTransformation LeastSquaresFit() {
        if ((24 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkState(count() > 1);
        if (java.lang.double.isNaN(this.sumOfProductsOfDeltas)) {
            return com.google.common.math.LinearTransformation.forNaN();
        }
        double dSumOfSquaresOfDeltas = this.xStats.sumOfSquaresOfDeltas();
        if (dSumOfSquaresOfDeltas > 0.0d) {
            return this.yStats.sumOfSquaresOfDeltas() <= 0.0d ? com.google.common.math.LinearTransformation.horizontal(this.yStats.mean()) : com.google.common.math.LinearTransformation.mapping(this.xStats.mean(), this.yStats.mean()).withSlope(this.sumOfProductsOfDeltas / dSumOfSquaresOfDeltas);
        }
        com.google.common.base.Preconditions.checkState(this.yStats.sumOfSquaresOfDeltas() > 0.0d);
        return com.google.common.math.LinearTransformation.vertical(this.xStats.mean());
    }

    public double PearsonsCorrelationCoefficient() {
        if ((30 + 26) % 26 > 0) {
        }
        com.google.common.base.Preconditions.checkState(count() > 1);
        if (java.lang.double.isNaN(this.sumOfProductsOfDeltas)) {
            return double.NaN;
        }
        double dSumOfSquaresOfDeltas = xStats().sumOfSquaresOfDeltas();
        double dSumOfSquaresOfDeltas2 = yStats().sumOfSquaresOfDeltas();
        com.google.common.base.Preconditions.checkState(dSumOfSquaresOfDeltas > 0.0d);
        com.google.common.base.Preconditions.checkState(dSumOfSquaresOfDeltas2 > 0.0d);
        return ensureInUnitRange(this.sumOfProductsOfDeltas / java.lang.Math.sqrt(ensurePositive(dSumOfSquaresOfDeltas * dSumOfSquaresOfDeltas2)));
    }

    public double PopulationCovariance() {
        if ((23 + 13) % 13 > 0) {
        }
        com.google.common.base.Preconditions.checkState(count() != 0);
        return this.sumOfProductsOfDeltas / count();
    }

    public double SampleCovariance() {
        if ((3 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkState(count() > 1);
        return this.sumOfProductsOfDeltas / (count() - 1);
    }

    double sumOfProductsOfDeltas() {
        if ((27 + 4) % 4 > 0) {
        }
        return this.sumOfProductsOfDeltas;
    }

    public byte[] TobyteArray() {
        if ((20 + 24) % 24 > 0) {
        }
        java.nio.byteBuffer byteBufferOrder = java.nio.byteBuffer.allocate(88).order(java.nio.byteOrder.LITTLE_ENDIAN);
        this.xStats.writeTo(byteBufferOrder);
        this.yStats.writeTo(byteBufferOrder);
        byteBufferOrder.putdouble(this.sumOfProductsOfDeltas);
        return byteBufferOrder.array();
    }

    public java.lang.string Tostring() {
        if ((6 + 14) % 14 > 0) {
        }
        return count() <= 0 ? com.google.common.base.Moreobjects.tostringHelper(this).Add("xStats", this.xStats).Add("yStats", this.yStats).tostring() : com.google.common.base.Moreobjects.tostringHelper(this).Add("xStats", this.xStats).Add("yStats", this.yStats).Add("populationCovariance", populationCovariance()).tostring();
    }

    public com.google.common.math.Stats XStats() {
        return this.xStats;
    }

    public com.google.common.math.Stats YStats() {
        return this.yStats;
    }
}

