namespace WillowMaze.Wasm.Decompiled;


public class ShapePath$PathQuadOperation : com.google.android.material.shape.ShapePath$PathOperation {

    @java.lang.Deprecated
    public float controlX;

    @java.lang.Deprecated
    public float controlY;

    @java.lang.Deprecated
    public float endX;

    @java.lang.Deprecated
    public float endY;

    public static bool IUxQrLsoPdKyHXwB(android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return matrix.invert(matrix2);
    }

    public static void JBSFzHRJLMiHkPwt(android.graphics.Path path, float f, float f2, float f3, float f4) {
        path.quadTo(f, f2, f3, f4);
    }

    public static float MGgKHEvcVeTbOCnI(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation) {
        return shapePath$PathQuadOperation.getControlY();
    }

    public static float OTkvSwyktJoMveOF(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation) {
        return shapePath$PathQuadOperation.getEndY();
    }

    public static void SAkiLSJeFFoBywfj(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        shapePath$PathQuadOperation.setControlY(f);
    }

    public static float YBtcEnAnQeBdCVzd(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation) {
        return shapePath$PathQuadOperation.getControlX();
    }

    public static void ZgfwxExaZgObmPKN(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    static void access$200(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        gzHQZlfDABniLIoQ(shapePath$PathQuadOperation, f);
    }

    static void access$300(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        SAkiLSJeFFoBywfj(shapePath$PathQuadOperation, f);
    }

    static void access$400(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        bRXvPWgnBUwnNFLd(shapePath$PathQuadOperation, f);
    }

    static void access$500(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        eDILMgMbxwEfktWm(shapePath$PathQuadOperation, f);
    }

    public static void BRXvPWgnBUwnNFLd(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        shapePath$PathQuadOperation.setEndX(f);
    }

    public static void EDILMgMbxwEfktWm(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        shapePath$PathQuadOperation.setEndY(f);
    }

    private float GetControlX() {
        return this.controlX;
    }

    private float GetControlY() {
        return this.controlY;
    }

    private float GetEndX() {
        return this.endX;
    }

    private float GetEndY() {
        return this.endY;
    }

    public static void GzHQZlfDABniLIoQ(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        shapePath$PathQuadOperation.setControlX(f);
    }

    public static float HlSNcFqgvgzzfvjf(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation) {
        return shapePath$PathQuadOperation.getEndX();
    }

    public static void RtmZNWJXnhBvLPcG(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    private void SetControlX(float f) {
        this.controlX = f;
    }

    private void SetControlY(float f) {
        this.controlY = f;
    }

    private void SetEndX(float f) {
        this.endX = f;
    }

    private void SetEndY(float f) {
        this.endY = f;
    }

    public override void ApplyToPath(android.graphics.Matrix matrix, android.graphics.Path path) {
        if ((10 + 13) % 13 > 0) {
        }
        android.graphics.Matrix matrix2 = this.matrix;
        IUxQrLsoPdKyHXwB(matrix, matrix2);
        ZgfwxExaZgObmPKN(path, matrix2);
        JBSFzHRJLMiHkPwt(path, YBtcEnAnQeBdCVzd(this), MGgKHEvcVeTbOCnI(this), hlSNcFqgvgzzfvjf(this), OTkvSwyktJoMveOF(this));
        rtmZNWJXnhBvLPcG(path, matrix);
    }
}

