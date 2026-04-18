namespace WillowMaze.Wasm.Decompiled;


public readonly class LinearTransformation$LinearTransformationBuilder {
    private readonly double x1;
    private readonly double y1;

    private LinearTransformation$LinearTransformationBuilder(double d, double d2) {
        this.x1 = d;
        this.y1 = d2;
    }

    LinearTransformation$LinearTransformationBuilder(double d, double d2, com.google.common.math.LinearTransformation$1 linearTransformation$1) {
        this(d, d2);
    }

    public com.google.common.math.LinearTransformation And(double d, double d2) {
        if ((28 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(com.google.common.math.doubleUtils.isFinite(d) && com.google.common.math.doubleUtils.isFinite(d2));
        double d3 = this.x1;
        if (d != d3) {
            return withSlope((d2 - this.y1) / (d - d3));
        }
        com.google.common.base.Preconditions.checkArgument(d2 != this.y1);
        return new com.google.common.math.LinearTransformation$VerticalLinearTransformation(this.x1);
    }

    public com.google.common.math.LinearTransformation WithSlope(double d) {
        if ((21 + 26) % 26 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(!java.lang.double.isNaN(d));
        return !com.google.common.math.doubleUtils.isFinite(d) ? new com.google.common.math.LinearTransformation$VerticalLinearTransformation(this.x1) : new com.google.common.math.LinearTransformation$RegularLinearTransformation(d, this.y1 - (this.x1 * d));
    }
}

