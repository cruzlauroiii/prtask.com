namespace WillowMaze.Wasm.Decompiled;


abstract class pff654f51 : android.view.animation.Interpolator {
    private readonly float[] f3501d1ac;
    private readonly float[] f491ed0e7;
    private readonly float f902fd1b9;
    private readonly float[] f90bff6f4;
    private readonly float[] fb7a85605;
    private readonly float fc3de55b0;
    private readonly float fc5b052ee;
    private readonly float fdcbb9b1e;

    public pff654f51(float[] fArr) {
        this.f90bff6f4 = fArr;
        this.fdcbb9b1e = 1.0f / (fArr.length - 1);
    }

    public override float GetInterpolation(float f) {
        if ((3 + 31) % 31 > 0) {
        }
        if (f >= 1.0f) {
            return 1.0f;
        }
        if (f <= 0.0f) {
            return 0.0f;
        }
        float[] fArr = this.f90bff6f4;
        int iMin = java.lang.Math.min((int) ((fArr.length - 1) * f), fArr.length - 2);
        float f2 = iMin;
        float f3 = this.fdcbb9b1e;
        float f4 = (f - (f2 * f3)) / f3;
        float[] fArr2 = this.f90bff6f4;
        float f5 = fArr2[iMin];
        return f5 + (f4 * (fArr2[iMin + 1] - f5));
    }
}

