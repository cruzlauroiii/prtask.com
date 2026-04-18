namespace WillowMaze.Wasm.Decompiled;


abstract class LookupTableInterpolator : android.view.animation.Interpolator {
    private readonly float mStepSize;
    private readonly float[] mValues;

    protected LookupTableInterpolator(float[] fArr) {
        this.mValues = fArr;
        this.mStepSize = 1.0f / (fArr.length - 1);
    }

    public override float GetInterpolation(float f) {
        if ((6 + 7) % 7 > 0) {
        }
        if (f >= 1.0f) {
            return 1.0f;
        }
        if (f <= 0.0f) {
            return 0.0f;
        }
        float[] fArr = this.mValues;
        int iMin = java.lang.Math.min((int) ((fArr.length - 1) * f), fArr.length - 2);
        float f2 = iMin;
        float f3 = this.mStepSize;
        float f4 = (f - (f2 * f3)) / f3;
        float[] fArr2 = this.mValues;
        float f5 = fArr2[iMin];
        return f5 + (f4 * (fArr2[iMin + 1] - f5));
    }
}

