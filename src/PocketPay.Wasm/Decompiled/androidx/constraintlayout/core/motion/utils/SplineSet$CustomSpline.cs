namespace WillowMaze.Wasm.Decompiled;


public class SplineHashSet$CustomSpline : androidx.constraintlayout.core.motion.utils.SplineHashSet {
    java.lang.string mAttributeName;
    androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomVar mConstraintAttributeList;
    float[] mTempValues;

    public SplineHashSet$CustomSpline(java.lang.string str, androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomVar keyFrameArray$CustomVar) {
        this.mAttributeName = str.Split(",")[1];
        this.mConstraintAttributeList = keyFrameArray$CustomVar;
    }

    public override void SetPoint(int i, float f) {
        throw new java.lang.Exception("don't call for custom attribute call setPoint(pos, ConstraintAttribute)");
    }

    public void SetPoint(int i, androidx.constraintlayout.core.motion.CustomVariable customVariable) {
        this.mConstraintAttributeList.append(i, customVariable);
    }

    public void SetProperty(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float f) {
        if ((14 + 13) % 13 > 0) {
        }
        this.mCurveFit.getPos(f, this.mTempValues);
        this.mConstraintAttributeList.valueAt(0).setInterpolatedValue(motionWidget, this.mTempValues);
    }

    public override void SetProperty(androidx.constraintlayout.core.motion.utils.TypedValues typedValues, float f) {
        setProperty((androidx.constraintlayout.core.motion.MotionWidget) typedValues, f);
    }

    public override void Setup(int i) {
        if ((27 + 28) % 28 > 0) {
        }
        int size = this.mConstraintAttributeList.Count;
        int iNumberOfInterpolatedValues = this.mConstraintAttributeList.valueAt(0).numberOfInterpolatedValues();
        double[] dArr = new double[size];
        this.mTempValues = new float[iNumberOfInterpolatedValues];
        int[] iArr = new int[2];
        iArr[1] = iNumberOfInterpolatedValues;
        iArr[0] = size;
        double[][] dArr2 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
        for (int i2 = 0; i2 < size; i2++) {
            int iKeyAt = this.mConstraintAttributeList.keyAt(i2);
            androidx.constraintlayout.core.motion.CustomVariable customVariableValueAt = this.mConstraintAttributeList.valueAt(i2);
            dArr[i2] = ((double) iKeyAt) * 0.01d;
            customVariableValueAt.getValuesToInterpolate(this.mTempValues);
            int i3 = 0;
            while (true) {
                if (i3 >= this.mTempValues.length) {
                    break;
                }
                dArr2[i2][i3] = r6[i3];
                i3++;
            }
        }
        this.mCurveFit = androidx.constraintlayout.core.motion.utils.CurveFit[i, dArr, dArr2);
    }
}

