namespace WillowMaze.Wasm.Decompiled;


abstract class ShapePath$ShadowCompatOperation {
    static readonly android.graphics.Matrix IDENTITY_MATRIX = new android.graphics.Matrix();
    readonly android.graphics.Matrix renderMatrix = new android.graphics.Matrix();

    ShapePath$ShadowCompatOperation() {
    }

    public static void GjiFvhwNcsvKAbTX(com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, android.graphics.Matrix matrix, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        shapePath$ShadowCompatOperation.draw(matrix, shadowRenderer, i, canvas);
    }

    public abstract void Draw(android.graphics.Matrix matrix, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas);

    public readonly void Draw(com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        GjiFvhwNcsvKAbTX(this, IDENTITY_MATRIX, shadowRenderer, i, canvas);
    }
}

