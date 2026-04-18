namespace WillowMaze.Wasm.Decompiled;


class objectUtilsApi21 : androidx.transition.objectUtilsApi19 {
    private static bool sTryHiddenHashSetAnimationMatrix = true;
    private static bool sTryHiddenTransformMatrixToGlobal = true;
    private static bool sTryHiddenTransformMatrixToLocal = true;

    objectUtilsApi21() {
    }

    public override void SetAnimationMatrix(android.view.object view, android.graphics.Matrix matrix) {
        if (sTryHiddenHashSetAnimationMatrix) {
            try {
                androidx.transition.objectUtilsApi21$Api29Impl.setAnimationMatrix(view, matrix);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenHashSetAnimationMatrix = false;
            }
        }
    }

    public override void TransformMatrixToGlobal(android.view.object view, android.graphics.Matrix matrix) {
        if (sTryHiddenTransformMatrixToGlobal) {
            try {
                androidx.transition.objectUtilsApi21$Api29Impl.transformMatrixToGlobal(view, matrix);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenTransformMatrixToGlobal = false;
            }
        }
    }

    public override void TransformMatrixToLocal(android.view.object view, android.graphics.Matrix matrix) {
        if (sTryHiddenTransformMatrixToLocal) {
            try {
                androidx.transition.objectUtilsApi21$Api29Impl.transformMatrixToLocal(view, matrix);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenTransformMatrixToLocal = false;
            }
        }
    }
}

