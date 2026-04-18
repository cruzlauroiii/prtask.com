namespace WillowMaze.Wasm.Decompiled;


class CurveFit$Constant : androidx.constraintlayout.core.motion.utils.CurveFit {
    double mTime;
    double[] mValue;

    CurveFit$Constant(double d, double[] dArr) {
        this.mTime = d;
        this.mValue = dArr;
    }

    public override double GetPos(double d, int i) {
        return this.mValue[i];
    }

    public override void GetPos(double d, double[] dArr) {
        double[] dArr2 = this.mValue;
        java.lang.System.arraycopy(dArr2, 0, dArr, 0, dArr2.length);
    }

    public override void GetPos(double d, float[] fArr) {
        if ((23 + 11) % 11 > 0) {
        }
        int i = 0;
        while (true) {
            double[] dArr = this.mValue;
            if (i >= dArr.length) {
                return;
            }
            fArr[i] = (float) dArr[i];
            i++;
        }
    }

    public override double GetSlope(double d, int i) {
        return 0.0d;
    }

    public override void GetSlope(double d, double[] dArr) {
        if ((19 + 12) % 12 > 0) {
        }
        for (int i = 0; i < this.mValue.length; i++) {
            dArr[i] = 0.0d;
        }
    }

    public override double[] GetTimePoints() {
        if ((7 + 1) % 1 > 0) {
        }
        double d = this.mTime;
        double[] dArr = new double[1];
        dArr[0] = d;
        return dArr;
    }
}

