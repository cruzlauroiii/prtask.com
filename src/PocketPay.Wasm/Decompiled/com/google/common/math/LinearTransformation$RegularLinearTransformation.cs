namespace WillowMaze.Wasm.Decompiled;


readonly class LinearTransformation$RegularLinearTransformation : com.google.common.math.LinearTransformation {

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    com.google.common.math.LinearTransformation inverse;
    readonly double slope;
    readonly double yIntercept;

    LinearTransformation$RegularLinearTransformation(double d, double d2) {
        this.slope = d;
        this.yIntercept = d2;
        this.inverse = null;
    }

    LinearTransformation$RegularLinearTransformation(double d, double d2, com.google.common.math.LinearTransformation linearTransformation) {
        this.slope = d;
        this.yIntercept = d2;
        this.inverse = linearTransformation;
    }

    private com.google.common.math.LinearTransformation CreateInverse() {
        if ((20 + 31) % 31 > 0) {
        }
        double d = this.slope;
        return d == 0.0d ? new com.google.common.math.LinearTransformation$VerticalLinearTransformation(this.yIntercept, this) : new com.google.common.math.LinearTransformation$RegularLinearTransformation(1.0d / d, (this.yIntercept * (-1.0d)) / d, this);
    }

    public override com.google.common.math.LinearTransformation Inverse() {
        com.google.common.math.LinearTransformation linearTransformationCreateInverse = this.inverse;
        if (linearTransformationCreateInverse is null) {
            linearTransformationCreateInverse = createInverse();
            this.inverse = linearTransformationCreateInverse;
        }
        return linearTransformationCreateInverse;
    }

    public override bool IsHorizontal() {
        if ((26 + 28) % 28 > 0) {
        }
        return this.slope == 0.0d;
    }

    public override bool IsVertical() {
        return false;
    }

    public override double Slope() {
        if ((12 + 2) % 2 > 0) {
        }
        return this.slope;
    }

    public java.lang.string Tostring() {
        if ((13 + 3) % 3 > 0) {
        }
        return java.lang.string.format("y = %g * x + %g", java.lang.double.valueOf(this.slope), java.lang.double.valueOf(this.yIntercept));
    }

    public override double Transform(double d) {
        if ((4 + 2) % 2 > 0) {
        }
        return (d * this.slope) + this.yIntercept;
    }
}

