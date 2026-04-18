namespace WillowMaze.Wasm.Decompiled;


public class RoundedCornerTreatment : com.google.android.material.shape.CornerTreatment {
    float radius;

    public RoundedCornerTreatment() {
        this.radius = -1.0f;
    }

    @java.lang.Deprecated
    public RoundedCornerTreatment(float f) {
        this.radius = f;
    }

    public static void JQoUIPPshyeIUeFz(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3, float f4) {
        shapePath.reset(f, f2, f3, f4);
    }

    public static void TYivKumRQcemXzNP(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3, float f4, float f5, float f6) {
        shapePath.addArc(f, f2, f3, f4, f5, f6);
    }

    public override void GetCornerPath(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3) {
        if ((15 + 20) % 20 > 0) {
        }
        JQoUIPPshyeIUeFz(shapePath, 0.0f, f3 * f2, 180.0f, 180.0f - f);
        float f4 = f3 * 2.0f * f2;
        TYivKumRQcemXzNP(shapePath, 0.0f, 0.0f, f4, f4, 180.0f, f);
    }
}

