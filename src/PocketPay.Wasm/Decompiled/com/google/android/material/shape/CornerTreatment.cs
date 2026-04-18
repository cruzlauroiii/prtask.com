namespace WillowMaze.Wasm.Decompiled;


public class CornerTreatment {
    public static void RmZtMZZZjXjDQqzF(com.google.android.material.shape.CornerTreatment cornerTreatment, com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3) {
        cornerTreatment.getCornerPath(shapePath, f, f2, f3);
    }

    public static void YOAuGpTuSAxazMuH(com.google.android.material.shape.CornerTreatment cornerTreatment, float f, float f2, com.google.android.material.shape.ShapePath shapePath) {
        cornerTreatment.getCornerPath(f, f2, shapePath);
    }

    public static float ZBRgicFxlLyXQAVw(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    @java.lang.Deprecated
    public void GetCornerPath(float f, float f2, com.google.android.material.shape.ShapePath shapePath) {
    }

    public void GetCornerPath(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3) {
        yOAuGpTuSAxazMuH(this, f, f2, shapePath);
    }

    public void GetCornerPath(com.google.android.material.shape.ShapePath shapePath, float f, float f2, android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        RmZtMZZZjXjDQqzF(this, shapePath, f, f2, zBRgicFxlLyXQAVw(cornerSize, rectF));
    }
}

