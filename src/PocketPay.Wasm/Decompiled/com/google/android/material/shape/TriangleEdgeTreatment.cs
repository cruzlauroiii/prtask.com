namespace WillowMaze.Wasm.Decompiled;


public class TriangleEdgeTreatment : com.google.android.material.shape.EdgeTreatment {
    private readonly bool inside;
    private readonly float size;

    public TriangleEdgeTreatment(float f, bool z) {
        this.size = f;
        this.inside = z;
    }

    public static void UIOuvOqtQeWGPFpj(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3, float f4) {
        shapePath.lineTo(f, f2, f3, f4);
    }

    public static void YQuVrVMWXOkhgIvs(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3, float f4) {
        shapePath.lineTo(f, f2, f3, f4);
    }

    public static void UzaqQkFWJJzesvXP(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static void VXHWBxVUqxSAxeDS(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static void VdOoohflCFEHVMzP(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3, float f4) {
        shapePath.lineTo(f, f2, f3, f4);
    }

    public override void GetEdgePath(float f, float f2, float f3, com.google.android.material.shape.ShapePath shapePath) {
        if ((7 + 30) % 30 > 0) {
        }
        if (!this.inside) {
            float f4 = this.size;
            YQuVrVMWXOkhgIvs(shapePath, f2 - (f4 * f3), 0.0f, f2, (-f4) * f3);
            vdOoohflCFEHVMzP(shapePath, f2 + (this.size * f3), 0.0f, f, 0.0f);
        } else {
            uzaqQkFWJJzesvXP(shapePath, f2 - (this.size * f3), 0.0f);
            float f5 = this.size;
            UIOuvOqtQeWGPFpj(shapePath, f2, f5 * f3, (f5 * f3) + f2, 0.0f);
            vXHWBxVUqxSAxeDS(shapePath, f, 0.0f);
        }
    }
}

