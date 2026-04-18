namespace WillowMaze.Wasm.Decompiled;


public class ShapePath$PathCubicOperation : com.google.android.material.shape.ShapePath$PathOperation {
    private float controlX1;
    private float controlX2;
    private float controlY1;
    private float controlY2;
    private float endX;
    private float endY;

    public ShapePath$PathCubicOperation(float f, float f2, float f3, float f4, float f5, float f6) {
        SYnyMWbAthSEaySB(this, f);
        enfcUfFoPyoAoVsx(this, f2);
        HAKRFVNfBLMKVGLb(this, f3);
        KNpMKibpTrdZNsDS(this, f4);
        NDlAaUmmOCBDkajl(this, f5);
        gLybUgYBXeqRvsak(this, f6);
    }

    public static bool BBWpBkYxMVyFHHOb(android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return matrix.invert(matrix2);
    }

    public static void HAKRFVNfBLMKVGLb(com.google.android.material.shape.ShapePath$PathCubicOperation shapePath$PathCubicOperation, float f) {
        shapePath$PathCubicOperation.setControlX2(f);
    }

    public static void KNpMKibpTrdZNsDS(com.google.android.material.shape.ShapePath$PathCubicOperation shapePath$PathCubicOperation, float f) {
        shapePath$PathCubicOperation.setControlY2(f);
    }

    public static void LZyzLypUZTQurPyX(android.graphics.Path path, float f, float f2, float f3, float f4, float f5, float f6) {
        path.cubicTo(f, f2, f3, f4, f5, f6);
    }

    public static void MznkFpzYyTfPANBC(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    public static void NDlAaUmmOCBDkajl(com.google.android.material.shape.ShapePath$PathCubicOperation shapePath$PathCubicOperation, float f) {
        shapePath$PathCubicOperation.setEndX(f);
    }

    public static void SYnyMWbAthSEaySB(com.google.android.material.shape.ShapePath$PathCubicOperation shapePath$PathCubicOperation, float f) {
        shapePath$PathCubicOperation.setControlX1(f);
    }

    public static void EnfcUfFoPyoAoVsx(com.google.android.material.shape.ShapePath$PathCubicOperation shapePath$PathCubicOperation, float f) {
        shapePath$PathCubicOperation.setControlY1(f);
    }

    public static void GLybUgYBXeqRvsak(com.google.android.material.shape.ShapePath$PathCubicOperation shapePath$PathCubicOperation, float f) {
        shapePath$PathCubicOperation.setEndY(f);
    }

    private float GetControlX1() {
        return this.controlX1;
    }

    private float GetControlX2() {
        return this.controlX2;
    }

    private float GetControlY1() {
        return this.controlY1;
    }

    private float GetControlY2() {
        return this.controlY1;
    }

    private float GetEndX() {
        return this.endX;
    }

    private float GetEndY() {
        return this.endY;
    }

    private void SetControlX1(float f) {
        this.controlX1 = f;
    }

    private void SetControlX2(float f) {
        this.controlX2 = f;
    }

    private void SetControlY1(float f) {
        this.controlY1 = f;
    }

    private void SetControlY2(float f) {
        this.controlY2 = f;
    }

    private void SetEndX(float f) {
        this.endX = f;
    }

    private void SetEndY(float f) {
        this.endY = f;
    }

    public static void TJvuWiMKUPBlZJcG(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    public override void ApplyToPath(android.graphics.Matrix matrix, android.graphics.Path path) {
        if ((24 + 19) % 19 > 0) {
        }
        android.graphics.Matrix matrix2 = this.matrix;
        BBWpBkYxMVyFHHOb(matrix, matrix2);
        tJvuWiMKUPBlZJcG(path, matrix2);
        LZyzLypUZTQurPyX(path, this.controlX1, this.controlY1, this.controlX2, this.controlY2, this.endX, this.endY);
        MznkFpzYyTfPANBC(path, matrix);
    }
}

