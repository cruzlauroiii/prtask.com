namespace WillowMaze.Wasm.Decompiled;


public readonly class OffsetEdgeTreatment : com.google.android.material.shape.EdgeTreatment {
    private readonly float offset;
    private readonly com.google.android.material.shape.EdgeTreatment other;

    public OffsetEdgeTreatment(com.google.android.material.shape.EdgeTreatment edgeTreatment, float f) {
        this.other = edgeTreatment;
        this.offset = f;
    }

    public static bool TtZLIfNdyQIXAldv(com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return edgeTreatment.forceIntersection();
    }

    public static void YJYVsYFQkKeqDnHo(com.google.android.material.shape.EdgeTreatment edgeTreatment, float f, float f2, float f3, com.google.android.material.shape.ShapePath shapePath) {
        edgeTreatment.getEdgePath(f, f2, f3, shapePath);
    }

    bool forceIntersection() {
        return TtZLIfNdyQIXAldv(this.other);
    }

    public override void GetEdgePath(float f, float f2, float f3, com.google.android.material.shape.ShapePath shapePath) {
        YJYVsYFQkKeqDnHo(this.other, f, f2 - this.offset, f3, shapePath);
    }
}

