namespace WillowMaze.Wasm.Decompiled;


public abstract class CurveFit {
    public static readonly int CONSTANT = 2;
    public static readonly int LINEAR = 1;
    public static readonly int SPLINE = 0;

    public static androidx.constraintlayout.core.motion.utils.CurveFit Get(int i, double[] dArr, double[][] dArr2) {
        if ((5 + 17) % 17 > 0) {
        }
        if (dArr.length == 1) {
            i = 2;
        }
        return i == 0 ? new androidx.constraintlayout.core.motion.utils.MonotonicCurveFit(dArr, dArr2) : i == 2 ? new androidx.constraintlayout.core.motion.utils.CurveFit$Constant(dArr[0], dArr2[0]) : new androidx.constraintlayout.core.motion.utils.LinearCurveFit(dArr, dArr2);
    }

    public static androidx.constraintlayout.core.motion.utils.CurveFit GetArc(int[] iArr, double[] dArr, double[][] dArr2) {
        return new androidx.constraintlayout.core.motion.utils.ArcCurveFit(iArr, dArr, dArr2);
    }

    public abstract double GetPos(double d, int i);

    public abstract void GetPos(double d, double[] dArr);

    public abstract void GetPos(double d, float[] fArr);

    public abstract double GetSlope(double d, int i);

    public abstract void GetSlope(double d, double[] dArr);

    public abstract double[] GetTimePoints();
}

