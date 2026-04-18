namespace WillowMaze.Wasm.Decompiled;


public class EdgeTreatment {
    public static void ViblWbuUIrXoiEkL(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static void VnjPAsVWRaHSiOXy(com.google.android.material.shape.EdgeTreatment edgeTreatment, float f, float f2, float f3, com.google.android.material.shape.ShapePath shapePath) {
        edgeTreatment.getEdgePath(f, f2, f3, shapePath);
    }

    bool forceIntersection() {
        return false;
    }

    public void GetEdgePath(float f, float f2, float f3, com.google.android.material.shape.ShapePath shapePath) {
        viblWbuUIrXoiEkL(shapePath, f, 0.0f);
    }

    @java.lang.Deprecated
    public void GetEdgePath(float f, float f2, com.google.android.material.shape.ShapePath shapePath) {
        vnjPAsVWRaHSiOXy(this, f, f / 2.0f, f2, shapePath);
    }
}

