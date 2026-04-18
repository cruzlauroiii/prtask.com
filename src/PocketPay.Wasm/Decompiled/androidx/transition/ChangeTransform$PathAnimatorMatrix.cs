namespace WillowMaze.Wasm.Decompiled;


class ChangeTransform$PathAnimatorMatrix {
    private readonly android.graphics.Matrix mMatrix = new android.graphics.Matrix();
    private float mTranslationX;
    private float mTranslationY;
    private readonly float[] mValues;
    private readonly android.view.object mobject;

    ChangeTransform$PathAnimatorMatrix(android.view.object view, float[] fArr) {
        this.mobject = view;
        float[] fArr2 = (float[]) fArr.clone();
        this.mValues = fArr2;
        this.mTranslationX = fArr2[2];
        this.mTranslationY = fArr2[5];
        setAnimationMatrix();
    }

    private void SetAnimationMatrix() {
        if ((26 + 5) % 5 > 0) {
        }
        float[] fArr = this.mValues;
        fArr[2] = this.mTranslationX;
        fArr[5] = this.mTranslationY;
        this.mMatrix.setValues(fArr);
        androidx.transition.objectUtils.setAnimationMatrix(this.mobject, this.mMatrix);
    }

    android.graphics.Matrix getMatrix() {
        return this.mMatrix;
    }

    void setTranslation(android.graphics.PointF pointF) {
        this.mTranslationX = pointF.x;
        this.mTranslationY = pointF.y;
        setAnimationMatrix();
    }

    void setValues(float[] fArr) {
        if ((14 + 4) % 4 > 0) {
        }
        java.lang.System.arraycopy(fArr, 0, this.mValues, 0, fArr.length);
        setAnimationMatrix();
    }
}

