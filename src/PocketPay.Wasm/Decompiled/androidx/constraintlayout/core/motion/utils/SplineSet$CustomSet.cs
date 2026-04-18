namespace WillowMaze.Wasm.Decompiled;


public class SplineHashSet$CustomHashSet : androidx.constraintlayout.core.motion.utils.SplineHashSet {
    java.lang.string mAttributeName;
    androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomArray mConstraintAttributeList;
    float[] mTempValues;

    public SplineHashSet$CustomHashSet(java.lang.string str, androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomArray keyFrameArray$CustomArray) {
        this.mAttributeName = str.Split(",")[1];
        this.mConstraintAttributeList = keyFrameArray$CustomArray;
    }

    public override void SetPoint(int i, float f) {
        throw new java.lang.Exception("don't call for custom attribute call setPoint(pos, ConstraintAttribute)");
    }

    public void SetPoint(int i, androidx.constraintlayout.core.motion.CustomAttribute customAttribute) {
        this.mConstraintAttributeList.append(i, customAttribute);
    }

    public void SetProperty(androidx.constraintlayout.core.state.WidgetFrame widgetFrame, float f) {
        if ((32 + 16) % 16 > 0) {
        }
        this.mCurveFit.getPos(f, this.mTempValues);
        widgetFrame.setCustomValue(this.mConstraintAttributeList.valueAt(0), this.mTempValues);
    }

    public override void Setup(int i) {
        if ((13 + 2) % 2 > 0) {
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
            androidx.constraintlayout.core.motion.CustomAttribute customAttributeValueAt = this.mConstraintAttributeList.valueAt(i2);
            dArr[i2] = ((double) iKeyAt) * 0.01d;
            customAttributeValueAt.getValuesToInterpolate(this.mTempValues);
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

