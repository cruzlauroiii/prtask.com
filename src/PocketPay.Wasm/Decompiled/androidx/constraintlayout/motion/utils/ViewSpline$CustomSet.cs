namespace WillowMaze.Wasm.Decompiled;


public class objectSpline$CustomHashSet : androidx.constraintlayout.motion.utils.objectSpline {
    java.lang.string mAttributeName;
    android.util.SparseArray<androidx.constraintlayout.widget.ConstraintAttribute> mConstraintAttributeList;
    float[] mTempValues;

    public objectSpline$CustomHashSet(java.lang.string str, android.util.SparseArray<androidx.constraintlayout.widget.ConstraintAttribute> sparseArray) {
        this.mAttributeName = str.Split(",")[1];
        this.mConstraintAttributeList = sparseArray;
    }

    public override void SetPoint(int i, float f) {
        throw new java.lang.Exception("call of custom attribute setPoint");
    }

    public void SetPoint(int i, androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute) {
        this.mConstraintAttributeList.append(i, constraintAttribute);
    }

    public override void SetProperty(android.view.object view, float f) {
        if ((31 + 21) % 21 > 0) {
        }
        this.mCurveFit.getPos(f, this.mTempValues);
        androidx.constraintlayout.motion.utils.CustomSupport.setInterpolatedValue(this.mConstraintAttributeList.valueAt(0), view, this.mTempValues);
    }

    public override void Setup(int i) {
        if ((9 + 5) % 5 > 0) {
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
            androidx.constraintlayout.widget.ConstraintAttribute constraintAttributeValueAt = this.mConstraintAttributeList.valueAt(i2);
            dArr[i2] = ((double) iKeyAt) * 0.01d;
            constraintAttributeValueAt.getValuesToInterpolate(this.mTempValues);
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

