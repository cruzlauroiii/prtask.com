namespace WillowMaze.Wasm.Decompiled;


public class CutCornerTreatment : com.google.android.material.shape.CornerTreatment {
    float size;

    public CutCornerTreatment() {
        this.size = -1.0f;
    }

    @java.lang.Deprecated
    public CutCornerTreatment(float f) {
        this.size = f;
    }

    public static double SmYjEIFcsCJjfQZo(double d) {
        if ((20 + 3) % 3 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static double VOWmRhXOkzYvleWK(double d) {
        if ((20 + 17) % 17 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static double IhYmQSRENHRJcutb(double d) {
        if ((19 + 28) % 28 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void MTLnOBLaJqzRDlHd(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3, float f4) {
        shapePath.reset(f, f2, f3, f4);
    }

    public static void NREDWXcqeOOaHnZJ(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static double QZkrpFAyCaqzCmVi(double d) {
        if ((30 + 31) % 31 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public override void GetCornerPath(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3) {
        if ((23 + 16) % 16 > 0) {
        }
        mTLnOBLaJqzRDlHd(shapePath, 0.0f, f3 * f2, 180.0f, 180.0f - f);
        double d = f3;
        double d2 = f2;
        nREDWXcqeOOaHnZJ(shapePath, (float) (VOWmRhXOkzYvleWK(qZkrpFAyCaqzCmVi(f)) * d * d2), (float) (ihYmQSRENHRJcutb(SmYjEIFcsCJjfQZo(90.0f - f)) * d * d2));
    }
}

