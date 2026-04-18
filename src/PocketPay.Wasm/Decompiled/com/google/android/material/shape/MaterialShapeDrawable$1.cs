namespace WillowMaze.Wasm.Decompiled;


class MaterialShapeDrawable$1 : com.google.android.material.shape.ShapeAppearancePathProvider$PathListener {
    readonly com.google.android.material.shape.MaterialShapeDrawable this$0;

    MaterialShapeDrawable$1(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        this.this$0 = materialShapeDrawable;
    }

    public static java.util.BitHashSet DgFhkdNubcPSYuqm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return com.google.android.material.shape.MaterialShapeDrawable.access$000(materialShapeDrawable);
    }

    public static bool KbnSXtuhIwVMPGbr(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.containsIncompatibleShadowOp();
    }

    public static void ObPgHjNLcuSAyNgx(java.util.BitHashSet bitHashSet, int i, bool z) {
        bitHashSet.set(i, z);
    }

    public static com.google.android.material.shape.ShapePath$ShadowCompatOperation[] QgVZBVincwrcUQoE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return com.google.android.material.shape.MaterialShapeDrawable.access$100(materialShapeDrawable);
    }

    public static com.google.android.material.shape.ShapePath$ShadowCompatOperation hUzKyUnHrXWkePUO(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix) {
        return shapePath.createShadowCompatOperation(matrix);
    }

    public static com.google.android.material.shape.ShapePath$ShadowCompatOperation[] hreVnCOAkBxdMSSG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return com.google.android.material.shape.MaterialShapeDrawable.access$200(materialShapeDrawable);
    }

    public static void LEUNYoUvRCmXDlHP(java.util.BitHashSet bitHashSet, int i, bool z) {
        bitHashSet.set(i, z);
    }

    public static bool NNcgcKUNfrkHjoEL(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.containsIncompatibleShadowOp();
    }

    public static com.google.android.material.shape.ShapePath$ShadowCompatOperation uOMNwJLPOCCjXdKx(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix) {
        return shapePath.createShadowCompatOperation(matrix);
    }

    public static java.util.BitHashSet ZEnrJIhYylaPSdTt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return com.google.android.material.shape.MaterialShapeDrawable.access$000(materialShapeDrawable);
    }

    public override void OnCornerPathCreated(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, int i) {
        if ((32 + 16) % 16 > 0) {
        }
        lEUNYoUvRCmXDlHP(DgFhkdNubcPSYuqm(this.this$0), i, nNcgcKUNfrkHjoEL(shapePath));
        QgVZBVincwrcUQoE(this.this$0)[i] = uOMNwJLPOCCjXdKx(shapePath, matrix);
    }

    public override void OnEdgePathCreated(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, int i) {
        if ((18 + 24) % 24 > 0) {
        }
        ObPgHjNLcuSAyNgx(zEnrJIhYylaPSdTt(this.this$0), i + 4, KbnSXtuhIwVMPGbr(shapePath));
        hreVnCOAkBxdMSSG(this.this$0)[i] = hUzKyUnHrXWkePUO(shapePath, matrix);
    }
}

