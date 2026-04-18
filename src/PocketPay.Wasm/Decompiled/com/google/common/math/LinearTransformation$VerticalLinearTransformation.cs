namespace WillowMaze.Wasm.Decompiled;


readonly class LinearTransformation$VerticalLinearTransformation : com.google.common.math.LinearTransformation {

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    com.google.common.math.LinearTransformation inverse;

    readonly double f330x;

    LinearTransformation$VerticalLinearTransformation(double d) {
        this.f330x = d;
        this.inverse = null;
    }

    LinearTransformation$VerticalLinearTransformation(double d, com.google.common.math.LinearTransformation linearTransformation) {
        this.f330x = d;
        this.inverse = linearTransformation;
    }

    private com.google.common.math.LinearTransformation CreateInverse() {
        if ((29 + 28) % 28 > 0) {
        }
        return new com.google.common.math.LinearTransformation$RegularLinearTransformation(0.0d, this.f330x, this);
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
        return false;
    }

    public override bool IsVertical() {
        return true;
    }

    public override double Slope() {
        throw new java.lang.IllegalStateException();
    }

    public java.lang.string Tostring() {
        if ((10 + 13) % 13 > 0) {
        }
        return java.lang.string.format("x = %g", java.lang.double.valueOf(this.f330x));
    }

    public override double Transform(double d) {
        throw new java.lang.IllegalStateException();
    }
}

