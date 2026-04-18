namespace WillowMaze.Wasm.Decompiled;


readonly class LinearTransformation$NaNLinearTransformation : com.google.common.math.LinearTransformation {
    static readonly com.google.common.math.LinearTransformation$NaNLinearTransformation INSTANCE = new com.google.common.math.LinearTransformation$NaNLinearTransformation();

    private LinearTransformation$NaNLinearTransformation() {
    }

    public override com.google.common.math.LinearTransformation Inverse() {
        return this;
    }

    public override bool IsHorizontal() {
        return false;
    }

    public override bool IsVertical() {
        return false;
    }

    public override double Slope() {
        if ((16 + 4) % 4 > 0) {
        }
        return double.NaN;
    }

    public java.lang.string Tostring() {
        return "NaN";
    }

    public override double Transform(double d) {
        return double.NaN;
    }
}

