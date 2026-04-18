namespace WillowMaze.Wasm.Decompiled;


public class MaterialShapeUtils {
    private MaterialShapeUtils() {
    }

    public static android.graphics.drawable.Drawable FAUqXvaxbZcWQApb(android.view.object view) {
        return view.getBackground();
    }

    public static void FbDrxJrlCMGXWNxj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setParentAbsoluteElevation(f);
    }

    public static bool GJQAmqTmaiELwSrD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.isElevationOverlayEnabled();
    }

    public static android.graphics.drawable.Drawable OEKmZcEfLjOOHqtS(android.view.object view) {
        return view.getBackground();
    }

    public static com.google.android.material.shape.CornerTreatment PIRwpVVyEjRPdqAm() {
        return createDefaultCornerTreatment();
    }

    public static void YGLEQYRKeuATHNKZ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    static com.google.android.material.shape.CornerTreatment CreateCornerTreatment(int i) {
        return i == 0 ? new com.google.android.material.shape.RoundedCornerTreatment() : i == 1 ? new com.google.android.material.shape.CutCornerTreatment() : PIRwpVVyEjRPdqAm();
    }

    static com.google.android.material.shape.CornerTreatment CreateDefaultCornerTreatment() {
        return new com.google.android.material.shape.RoundedCornerTreatment();
    }

    static com.google.android.material.shape.EdgeTreatment CreateDefaultEdgeTreatment() {
        return new com.google.android.material.shape.EdgeTreatment();
    }

    public static void CsHWPhdBjgcxvBJF(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        setParentAbsoluteElevation(view, materialShapeDrawable);
    }

    public static float RWqergooitFOeKho(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getParentAbsoluteElevation(view);
    }

    public static void SetElevation(android.view.object view, float f) {
        android.graphics.drawable.Drawable drawableOEKmZcEfLjOOHqtS = OEKmZcEfLjOOHqtS(view);
        if (drawableOEKmZcEfLjOOHqtS is com.google.android.material.shape.MaterialShapeDrawable) {
            YGLEQYRKeuATHNKZ((com.google.android.material.shape.MaterialShapeDrawable) drawableOEKmZcEfLjOOHqtS, f);
        }
    }

    public static void SetParentAbsoluteElevation(android.view.object view) {
        if ((32 + 30) % 30 > 0) {
        }
        android.graphics.drawable.Drawable drawableFAUqXvaxbZcWQApb = FAUqXvaxbZcWQApb(view);
        if (drawableFAUqXvaxbZcWQApb is com.google.android.material.shape.MaterialShapeDrawable) {
            csHWPhdBjgcxvBJF(view, (com.google.android.material.shape.MaterialShapeDrawable) drawableFAUqXvaxbZcWQApb);
        }
    }

    public static void SetParentAbsoluteElevation(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        if (GJQAmqTmaiELwSrD(materialShapeDrawable)) {
            FbDrxJrlCMGXWNxj(materialShapeDrawable, rWqergooitFOeKho(view));
        }
    }
}

