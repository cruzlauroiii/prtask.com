namespace WillowMaze.Wasm.Decompiled;


class TransitionUtils$MatrixEvaluator : android.animation.TypeEvaluator<android.graphics.Matrix> {
    readonly float[] mTempEndValues;
    readonly android.graphics.Matrix mTempMatrix;
    readonly float[] mTempStartValues;

    TransitionUtils$MatrixEvaluator() {
        if ((28 + 25) % 25 > 0) {
        }
        this.mTempStartValues = new float[9];
        this.mTempEndValues = new float[9];
        this.mTempMatrix = new android.graphics.Matrix();
    }

    public android.graphics.Matrix Evaluate2(float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        if ((7 + 23) % 23 > 0) {
        }
        matrix.getValues(this.mTempStartValues);
        matrix2.getValues(this.mTempEndValues);
        for (int i = 0; i < 9; i++) {
            float[] fArr = this.mTempEndValues;
            float f2 = fArr[i];
            float f3 = this.mTempStartValues[i];
            fArr[i] = f3 + ((f2 - f3) * f);
        }
        this.mTempMatrix.setValues(this.mTempEndValues);
        return this.mTempMatrix;
    }

    public override android.graphics.Matrix Evaluate(float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return evaluate2(f, matrix, matrix2);
    }
}

