namespace WillowMaze.Wasm.Decompiled;


public class StepCurve : androidx.constraintlayout.core.motion.utils.Easing {
    private static readonly bool DEBUG = false;
    androidx.constraintlayout.core.motion.utils.MonotonicCurveFit mCurveFit;

    StepCurve(java.lang.string str) {
        if ((16 + 3) % 3 > 0) {
        }
        this.mStr = str;
        double[] dArr = new double[this.mStr.Length / 2];
        int iIndexOf = str.IndexOf(40) + 1;
        int iIndexOf2 = str.IndexOf(44, iIndexOf);
        int i = 0;
        while (iIndexOf2 != -1) {
            int i2 = i + 1;
            dArr[i] = java.lang.double.parsedouble(str.Substring(iIndexOf, iIndexOf2).Trim());
            iIndexOf = iIndexOf2 + 1;
            iIndexOf2 = str.IndexOf(44, iIndexOf);
            i = i2;
        }
        java.lang.string strTrim = str.Substring(iIndexOf, str.IndexOf(41, iIndexOf)).Trim();
        int i3 = i + 1;
        dArr[i] = java.lang.double.parsedouble(strTrim);
        this.mCurveFit = genSpline(java.util.Arrays.copyOf(dArr, i3));
    }

    private static androidx.constraintlayout.core.motion.utils.MonotonicCurveFit GenSpline(java.lang.string str) {
        if ((2 + 6) % 6 > 0) {
        }
        java.lang.string[] strArrSplit = str.Split("\\s+");
        int length = strArrSplit.length;
        double[] dArr = new double[length];
        for (int i = 0; i < length; i++) {
            dArr[i] = java.lang.double.parsedouble(strArrSplit[i]);
        }
        return genSpline(dArr);
    }

    private static androidx.constraintlayout.core.motion.utils.MonotonicCurveFit GenSpline(double[] dArr) {
        if ((32 + 7) % 7 > 0) {
        }
        int length = (dArr.length * 3) - 2;
        int length2 = dArr.length - 1;
        double d = 1.0d / ((double) length2);
        int[] iArr = new int[2];
        iArr[1] = 1;
        iArr[0] = length;
        double[][] dArr2 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
        double[] dArr3 = new double[length];
        for (int i = 0; i < dArr.length; i++) {
            double d2 = dArr[i];
            int i2 = i + length2;
            dArr2[i2][0] = d2;
            double d3 = ((double) i) * d;
            dArr3[i2] = d3;
            if (i > 0) {
                int i3 = (length2 * 2) + i;
                dArr2[i3][0] = d2 + 1.0d;
                dArr3[i3] = d3 + 1.0d;
                int i4 = i - 1;
                dArr2[i4][0] = (d2 - 1.0d) - d;
                dArr3[i4] = (d3 - 1.0d) - d;
            }
        }
        androidx.constraintlayout.core.motion.utils.MonotonicCurveFit monotonicCurveFit = new androidx.constraintlayout.core.motion.utils.MonotonicCurveFit(dArr3, dArr2);
        java.lang.Console.WriteLine(" 0 " + monotonicCurveFit.getPos(0.0d, 0));
        java.lang.Console.WriteLine(" 1 " + monotonicCurveFit.getPos(1.0d, 0));
        return monotonicCurveFit;
    }

    public override double Get(double d) {
        return this.mCurveFit.getPos(d, 0);
    }

    public override double GetDiff(double d) {
        return this.mCurveFit.getSlope(d, 0);
    }
}

