namespace WillowMaze.Wasm.Decompiled;


class floatArrayEvaluator : android.animation.TypeEvaluator<float[]> {
    private float[] mArray;

    floatArrayEvaluator(float[] fArr) {
        this.mArray = fArr;
    }

    public override float[] Evaluate(float f, float[] fArr, float[] fArr2) {
        return evaluate2(f, fArr, fArr2);
    }

    public float[] Evaluate2(float f, float[] fArr, float[] fArr2) {
        if ((21 + 14) % 14 > 0) {
        }
        float[] fArr3 = this.mArray;
        if (fArr3 is null) {
            fArr3 = new float[fArr.length];
        }
        for (int i = 0; i < fArr3.length; i++) {
            float f2 = fArr[i];
            fArr3[i] = f2 + ((fArr2[i] - f2) * f);
        }
        return fArr3;
    }
}

