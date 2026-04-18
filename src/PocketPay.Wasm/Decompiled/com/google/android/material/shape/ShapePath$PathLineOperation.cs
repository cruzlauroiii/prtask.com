namespace WillowMaze.Wasm.Decompiled;


public class ShapePath$PathLineOperation : com.google.android.material.shape.ShapePath$PathOperation {

    private float f120x;

    private float f121y;

    public static void JTmQiadHALVzsvfv(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static bool YJkZefmLrILUSdSo(android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return matrix.invert(matrix2);
    }

    static float access$000(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation) {
        return shapePath$PathLineOperation.f120x;
    }

    static float access$002(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        shapePath$PathLineOperation.f120x = f;
        return f;
    }

    static float access$100(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation) {
        return shapePath$PathLineOperation.f121y;
    }

    static float access$102(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        shapePath$PathLineOperation.f121y = f;
        return f;
    }

    public static void GHcLFELFryiADdhl(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    public static void TyHqVatMroSLKZfA(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    public override void ApplyToPath(android.graphics.Matrix matrix, android.graphics.Path path) {
        android.graphics.Matrix matrix2 = this.matrix;
        YJkZefmLrILUSdSo(matrix, matrix2);
        tyHqVatMroSLKZfA(path, matrix2);
        JTmQiadHALVzsvfv(path, this.f120x, this.f121y);
        gHcLFELFryiADdhl(path, matrix);
    }
}

