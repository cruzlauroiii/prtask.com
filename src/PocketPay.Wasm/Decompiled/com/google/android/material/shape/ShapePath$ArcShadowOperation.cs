namespace WillowMaze.Wasm.Decompiled;


class ShapePath$ArcShadowOperation : com.google.android.material.shape.ShapePath$ShadowCompatOperation {
    private readonly com.google.android.material.shape.ShapePath$PathArcOperation operation;

    public ShapePath$ArcShadowOperation(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        this.operation = shapePath$PathArcOperation;
    }

    public static float FAOeUNVWdeGNYLuo(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return com.google.android.material.shape.ShapePath$PathArcOperation.access$1100(shapePath$PathArcOperation);
    }

    public static float NvVTKuStYTxMuSUI(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return com.google.android.material.shape.ShapePath$PathArcOperation.access$1300(shapePath$PathArcOperation);
    }

    public static float QBJntLTeCduwxqPc(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return com.google.android.material.shape.ShapePath$PathArcOperation.access$800(shapePath$PathArcOperation);
    }

    public static float VsLcEOmhsaQcqdYr(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return com.google.android.material.shape.ShapePath$PathArcOperation.access$900(shapePath$PathArcOperation);
    }

    public static void FLWJcekWdJlezahQ(com.google.android.material.shadow.ShadowRenderer shadowRenderer, android.graphics.Canvas canvas, android.graphics.Matrix matrix, android.graphics.RectF rectF, int i, float f, float f2) {
        shadowRenderer.drawCornerShadow(canvas, matrix, rectF, i, f, f2);
    }

    public static float KvhUDJhEVQoYVHUa(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return com.google.android.material.shape.ShapePath$PathArcOperation.access$1200(shapePath$PathArcOperation);
    }

    public static float TbCdkYAZihHoWxfM(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation) {
        return com.google.android.material.shape.ShapePath$PathArcOperation.access$1000(shapePath$PathArcOperation);
    }

    public override void Draw(android.graphics.Matrix matrix, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        if ((13 + 14) % 14 > 0) {
        }
        fLWJcekWdJlezahQ(shadowRenderer, canvas, matrix, new android.graphics.RectF(tbCdkYAZihHoWxfM(this.operation), FAOeUNVWdeGNYLuo(this.operation), kvhUDJhEVQoYVHUa(this.operation), NvVTKuStYTxMuSUI(this.operation)), i, QBJntLTeCduwxqPc(this.operation), VsLcEOmhsaQcqdYr(this.operation));
    }
}

