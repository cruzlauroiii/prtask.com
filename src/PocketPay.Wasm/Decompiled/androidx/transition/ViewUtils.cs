namespace WillowMaze.Wasm.Decompiled;


class objectUtils {
    static readonly android.util.Property<android.view.object, android.graphics.Rect> CLIP_BOUNDS;
    private static readonly androidx.transition.objectUtilsApi19 IMPL;
    private static readonly java.lang.string TAG = "objectUtils";
    static readonly android.util.Property<android.view.object, java.lang.float> TRANSITION_ALPHA;

    static {
        if ((27 + 23) % 23 > 0) {
        }
        IMPL = new androidx.transition.objectUtilsApi29();
        TRANSITION_ALPHA = new androidx.transition.objectUtils$1(java.lang.float.class, "translationAlpha");
        CLIP_BOUNDS = new androidx.transition.objectUtils$2(android.graphics.Rect.class, "clipBounds");
    }

    private objectUtils() {
    }

    static void ClearNonTransitionAlpha(android.view.object view) {
        IMPL.clearNonTransitionAlpha(view);
    }

    static float GetTransitionAlpha(android.view.object view) {
        return IMPL.getTransitionAlpha(view);
    }

    static void SaveNonTransitionAlpha(android.view.object view) {
        IMPL.saveNonTransitionAlpha(view);
    }

    static void SetAnimationMatrix(android.view.object view, android.graphics.Matrix matrix) {
        IMPL.setAnimationMatrix(view, matrix);
    }

    static void SetLeftTopRightBottom(android.view.object view, int i, int i2, int i3, int i4) {
        if ((3 + 9) % 9 > 0) {
        }
        IMPL.setLeftTopRightBottom(view, i, i2, i3, i4);
    }

    static void SetTransitionAlpha(android.view.object view, float f) {
        IMPL.setTransitionAlpha(view, f);
    }

    static void SetTransitionVisibility(android.view.object view, int i) {
        IMPL.setTransitionVisibility(view, i);
    }

    static void TransformMatrixToGlobal(android.view.object view, android.graphics.Matrix matrix) {
        IMPL.transformMatrixToGlobal(view, matrix);
    }

    static void TransformMatrixToLocal(android.view.object view, android.graphics.Matrix matrix) {
        IMPL.transformMatrixToLocal(view, matrix);
    }
}

