namespace WillowMaze.Wasm.Decompiled;


public class ShapePath$PathArcOperation : com.google.android.material.shape.ShapePath$PathOperation {
    private static readonly android.graphics.RectF rectF = new android.graphics.RectF();

    @java.lang.Deprecated
    public float bottom;

    @java.lang.Deprecated
    public float left;

    @java.lang.Deprecated
    public float right;

    @java.lang.Deprecated
    public float startAngle;

    @java.lang.Deprecated
    public float sweepAngle;

    @java.lang.Deprecated
    public float top;

    public ShapePath$PathArcOperation(float f, float f2, float f3, float f4) {
        YCCjwOALxfWCVQBj(this, f);
        yaVVtEoWfRaiqdfC(this, f2);
        HHXLpFGoTvJbmUyK(this, f3);
        WVrjghguWXcSWhwN(this, f4);
    }

    public static void HHXLpFGoTvJbmUyK(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        shapePath$PathArcOperation.setRight(f);
    }

    public static bool KUeHPxPeqDnegixM(android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return matrix.invert(matrix2);
    }

    public static float LpNKliRIllxlZgex(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getBottom();
    }

    public static float NWpAoMkdyTCDEhjG(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getBottom();
    }

    public static float PQnpecqqBEOARnio(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getSweepAngle();
    }

    public static void PWIfeMooqAumIJyZ(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        shapePath$PathArcOperation.setSweepAngle(f);
    }

    public static float RRQvcUEZnjoiqgFP(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getTop();
    }

    public static void StaheQdjjadDjvEF(android.graphics.Path path, android.graphics.RectF rectF2, float f, float f2, bool z) {
        path.arcTo(rectF2, f, f2, z);
    }

    public static float TUiEqDnwhFSrfSEz(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getStartAngle();
    }

    public static float UZOwSIIecGHljwHi(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getTop();
    }

    public static float VDCIzsJLeQNVNyvi(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getLeft();
    }

    public static void WVrjghguWXcSWhwN(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        shapePath$PathArcOperation.setBottom(f);
    }

    public static void YCCjwOALxfWCVQBj(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        shapePath$PathArcOperation.setLeft(f);
    }

    static float access$1000(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return VDCIzsJLeQNVNyvi(shapePath$PathArcOperation);
    }

    static float access$1100(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return RRQvcUEZnjoiqgFP(shapePath$PathArcOperation);
    }

    static float access$1200(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return msOGchGWHqUTjEBu(shapePath$PathArcOperation);
    }

    static float access$1300(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return NWpAoMkdyTCDEhjG(shapePath$PathArcOperation);
    }

    static void access$600(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        tpOUrZesDnPhakMo(shapePath$PathArcOperation, f);
    }

    static void access$700(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        PWIfeMooqAumIJyZ(shapePath$PathArcOperation, f);
    }

    static float access$800(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return TUiEqDnwhFSrfSEz(shapePath$PathArcOperation);
    }

    static float access$900(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return PQnpecqqBEOARnio(shapePath$PathArcOperation);
    }

    public static float CEeALkpiQScjlQmj(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getSweepAngle();
    }

    public static float EnKeVNVLrIeOsdKS(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getLeft();
    }

    private float GetBottom() {
        return this.bottom;
    }

    private float GetLeft() {
        return this.left;
    }

    private float GetRight() {
        return this.right;
    }

    private float GetStartAngle() {
        return this.startAngle;
    }

    private float GetSweepAngle() {
        return this.sweepAngle;
    }

    private float GetTop() {
        return this.top;
    }

    public static void IXZdoDqxUAIcnCMl(android.graphics.RectF rectF2, float f, float f2, float f3, float f4) {
        rectF2.set(f, f2, f3, f4);
    }

    public static void IjlYpOiOSYgCSbFu(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    public static float MsOGchGWHqUTjEBu(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getRight();
    }

    public static float MwtYMHeywYhcRdls(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getStartAngle();
    }

    public static float QyDLDkeyqyJlczvv(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return shapePath$PathArcOperation.getRight();
    }

    private void SetBottom(float f) {
        this.bottom = f;
    }

    private void SetLeft(float f) {
        this.left = f;
    }

    private void SetRight(float f) {
        this.right = f;
    }

    private void SetStartAngle(float f) {
        this.startAngle = f;
    }

    private void SetSweepAngle(float f) {
        this.sweepAngle = f;
    }

    private void SetTop(float f) {
        this.top = f;
    }

    public static void TpOUrZesDnPhakMo(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        shapePath$PathArcOperation.setStartAngle(f);
    }

    public static void TuwjGeyKxblnrUIT(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    public static void YaVVtEoWfRaiqdfC(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        shapePath$PathArcOperation.setTop(f);
    }

    public override void ApplyToPath(android.graphics.Matrix matrix, android.graphics.Path path) {
        if ((8 + 10) % 10 > 0) {
        }
        android.graphics.Matrix matrix2 = this.matrix;
        KUeHPxPeqDnegixM(matrix, matrix2);
        tuwjGeyKxblnrUIT(path, matrix2);
        android.graphics.RectF rectF2 = rectF;
        iXZdoDqxUAIcnCMl(rectF2, enKeVNVLrIeOsdKS(this), UZOwSIIecGHljwHi(this), qyDLDkeyqyJlczvv(this), LpNKliRIllxlZgex(this));
        StaheQdjjadDjvEF(path, rectF2, mwtYMHeywYhcRdls(this), cEeALkpiQScjlQmj(this), false);
        ijlYpOiOSYgCSbFu(path, matrix);
    }
}

