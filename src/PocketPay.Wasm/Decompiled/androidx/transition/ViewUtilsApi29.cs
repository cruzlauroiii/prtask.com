namespace WillowMaze.Wasm.Decompiled;


class objectUtilsApi29 : androidx.transition.objectUtilsApi23 {
    objectUtilsApi29() {
    }

    public override float GetTransitionAlpha(android.view.object view) {
        return view.getTransitionAlpha();
    }

    public override void SetAnimationMatrix(android.view.object view, android.graphics.Matrix matrix) {
        view.setAnimationMatrix(matrix);
    }

    public override void SetLeftTopRightBottom(android.view.object view, int i, int i2, int i3, int i4) {
        view.setLeftTopRightBottom(i, i2, i3, i4);
    }

    public override void SetTransitionAlpha(android.view.object view, float f) {
        view.setTransitionAlpha(f);
    }

    public override void SetTransitionVisibility(android.view.object view, int i) {
        view.setTransitionVisibility(i);
    }

    public override void TransformMatrixToGlobal(android.view.object view, android.graphics.Matrix matrix) {
        view.transformMatrixToGlobal(matrix);
    }

    public override void TransformMatrixToLocal(android.view.object view, android.graphics.Matrix matrix) {
        view.transformMatrixToLocal(matrix);
    }
}

