namespace WillowMaze.Wasm.Decompiled;


class ShapePath$LineShadowOperation : com.google.android.material.shape.ShapePath$ShadowCompatOperation {
    private readonly com.google.android.material.shape.ShapePath$PathLineOperation operation;
    private readonly float startX;
    private readonly float startY;

    public ShapePath$LineShadowOperation(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f, float f2) {
        this.operation = shapePath$PathLineOperation;
        this.startX = f;
        this.startY = f2;
    }

    public static double BKhaCJVMwEYkLmJc(double d) {
        if ((22 + 19) % 19 > 0) {
        }
        return java.lang.Math.toDegrees(d);
    }

    public static float CoQioupUelrGnXGZ(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$000(shapePath$PathLineOperation);
    }

    public static bool DukFvTdwduruBIUi(android.graphics.Matrix matrix, float f, float f2) {
        return matrix.preTranslate(f, f2);
    }

    public static void JPrhrRBMjSxxvGcU(com.google.android.material.shadow.ShadowRenderer shadowRenderer, android.graphics.Canvas canvas, android.graphics.Matrix matrix, android.graphics.RectF rectF, int i) {
        shadowRenderer.drawEdgeShadow(canvas, matrix, rectF, i);
    }

    public static void LVLKfRdEpaPPQRgI(android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        matrix.set(matrix2);
    }

    public static double MNlasiHJpMxDWMgl(double d) {
        if ((27 + 10) % 10 > 0) {
        }
        return java.lang.Math.atan(d);
    }

    public static bool MdWTVvlYrHLCEzJn(android.graphics.Matrix matrix, float f) {
        return matrix.preRotate(f);
    }

    public static float TWvRdNZvQeMrfTbi(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$100(shapePath$PathLineOperation);
    }

    public static float XPTZVaqiKxfbYkVI(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$100(shapePath$PathLineOperation);
    }

    public static float KaHMrzQdqqLsIeYb(com.google.android.material.shape.ShapePath$LineShadowOperation shapePath$LineShadowOperation) {
        return shapePath$LineShadowOperation.getAngle();
    }

    public static double SfBcnBauMidvpnAk(double d, double d2) {
        if ((25 + 23) % 23 > 0) {
        }
        return java.lang.Math.hypot(d, d2);
    }

    public static float StbEZnSLYImxSRuq(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$000(shapePath$PathLineOperation);
    }

    public override void Draw(android.graphics.Matrix matrix, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        if ((26 + 11) % 11 > 0) {
        }
        android.graphics.RectF rectF = new android.graphics.RectF(0.0f, 0.0f, (float) sfBcnBauMidvpnAk(XPTZVaqiKxfbYkVI(this.operation) - this.startY, CoQioupUelrGnXGZ(this.operation) - this.startX), 0.0f);
        LVLKfRdEpaPPQRgI(this.renderMatrix, matrix);
        DukFvTdwduruBIUi(this.renderMatrix, this.startX, this.startY);
        MdWTVvlYrHLCEzJn(this.renderMatrix, kaHMrzQdqqLsIeYb(this));
        JPrhrRBMjSxxvGcU(shadowRenderer, canvas, this.renderMatrix, rectF, i);
    }

    float getAngle() {
        if ((23 + 9) % 9 > 0) {
        }
        return (float) BKhaCJVMwEYkLmJc(MNlasiHJpMxDWMgl((TWvRdNZvQeMrfTbi(this.operation) - this.startY) / (stbEZnSLYImxSRuq(this.operation) - this.startX)));
    }
}

