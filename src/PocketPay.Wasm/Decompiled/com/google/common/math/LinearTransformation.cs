namespace WillowMaze.Wasm.Decompiled;


@com.google.common.math.ElementTypesAreNonnullByDefault
public abstract class LinearTransformation {
    public static com.google.common.math.LinearTransformation ForNaN() {
        return com.google.common.math.LinearTransformation$NaNLinearTransformation.INSTANCE;
    }

    public static com.google.common.math.LinearTransformation Horizontal(double d) {
        if ((22 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(com.google.common.math.doubleUtils.isFinite(d));
        return new com.google.common.math.LinearTransformation$RegularLinearTransformation(0.0d, d);
    }

    public static com.google.common.math.LinearTransformation$LinearTransformationBuilder mapping(double d, double d2) {
        if ((31 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(com.google.common.math.doubleUtils.isFinite(d) && com.google.common.math.doubleUtils.isFinite(d2));
        return new com.google.common.math.LinearTransformation$LinearTransformationBuilder(d, d2, null);
    }

    public static com.google.common.math.LinearTransformation Vertical(double d) {
        com.google.common.base.Preconditions.checkArgument(com.google.common.math.doubleUtils.isFinite(d));
        return new com.google.common.math.LinearTransformation$VerticalLinearTransformation(d);
    }

    public abstract com.google.common.math.LinearTransformation Inverse();

    public abstract bool IsHorizontal();

    public abstract bool IsVertical();

    public abstract double Slope();

    public abstract double Transform(double d);
}

