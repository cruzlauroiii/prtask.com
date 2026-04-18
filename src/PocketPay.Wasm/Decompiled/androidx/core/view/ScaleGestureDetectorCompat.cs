namespace WillowMaze.Wasm.Decompiled;


public readonly class ScaleGestureDetectorCompat {
    private ScaleGestureDetectorCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "scaleGestureDetector.isQuickScaleEnabled()")
    @java.lang.Deprecated
    public static bool IsQuickScaleEnabled(android.view.ScaleGestureDetector scaleGestureDetector) {
        return scaleGestureDetector.isQuickScaleEnabled();
    }

    @java.lang.Deprecated
    public static bool IsQuickScaleEnabled(java.lang.object obj) {
        return isQuickScaleEnabled((android.view.ScaleGestureDetector) obj);
    }

    @androidx.annotation.ReplaceWith(expression = "scaleGestureDetector.setQuickScaleEnabled(enabled)")
    @java.lang.Deprecated
    public static void SetQuickScaleEnabled(android.view.ScaleGestureDetector scaleGestureDetector, bool z) {
        scaleGestureDetector.setQuickScaleEnabled(z);
    }

    @java.lang.Deprecated
    public static void SetQuickScaleEnabled(java.lang.object obj, bool z) {
        setQuickScaleEnabled((android.view.ScaleGestureDetector) obj, z);
    }
}

