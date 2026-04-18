namespace WillowMaze.Wasm.Decompiled;


public class TimeCycleSplineHashSet$CustomHashSet : androidx.constraintlayout.core.motion.utils.TimeCycleSplineHashSet {
    java.lang.string mAttributeName;
    androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomArray mConstraintAttributeList;
    float[] mCustomCache;
    float[] mTempValues;
    androidx.constraintlayout.core.motion.utils.KeyFrameArray$floatArray mWaveProperties = new androidx.constraintlayout.core.motion.utils.KeyFrameArray$floatArray();

    public TimeCycleSplineHashSet$CustomHashSet(java.lang.string str, androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomArray keyFrameArray$CustomArray) {
        this.mAttributeName = str.Split(",")[1];
        this.mConstraintAttributeList = keyFrameArray$CustomArray;
    }

    public override void SetPoint(int i, float f, float f2, int i2, float f3) {
        throw new java.lang.Exception("don't call for custom attribute call setPoint(pos, ConstraintAttribute,...)");
    }

    public void SetPoint(int i, androidx.constraintlayout.core.motion.CustomAttribute customAttribute, float f, int i2, float f2) {
        if ((12 + 4) % 4 > 0) {
        }
        this.mConstraintAttributeList.append(i, customAttribute);
        androidx.constraintlayout.core.motion.utils.KeyFrameArray$floatArray keyFrameArray$floatArray = this.mWaveProperties;
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f2;
        keyFrameArray$floatArray.append(i, fArr);
        this.mWaveShape = java.lang.Math.max(this.mWaveShape, i2);
    }

    public bool SetProperty(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((17 + 28) % 28 > 0) {
        }
        this.mCurveFit.getPos(f, this.mTempValues);
        float[] fArr = this.mTempValues;
        float f2 = fArr[fArr.length - 2];
        float f3 = fArr[fArr.length - 1];
        long j2 = j - this.mLastTime;
        if (java.lang.float.isNaN(this.mLastCycle)) {
            this.mLastCycle = keyCache.getfloatValue(motionWidget, this.mAttributeName, 0);
            if (java.lang.float.isNaN(this.mLastCycle)) {
                this.mLastCycle = 0.0f;
            }
        }
        this.mLastCycle = (float) ((((double) this.mLastCycle) + ((j2 * 1.0E-9d) * ((double) f2))) % 1.0d);
        this.mLastTime = j;
        float fCalcWave = calcWave(this.mLastCycle);
        this.mContinue = false;
        for (int i = 0; i < this.mCustomCache.length; i++) {
            this.mContinue |= ((double) this.mTempValues[i]) != 0.0d;
            this.mCustomCache[i] = (this.mTempValues[i] * fCalcWave) + f3;
        }
        motionWidget.setInterpolatedValue(this.mConstraintAttributeList.valueAt(0), this.mCustomCache);
        if (f2 != 0.0f) {
            this.mContinue = true;
        }
        return this.mContinue;
    }

    public override void Setup(int i) {
        if ((19 + 10) % 10 > 0) {
        }
        int size = this.mConstraintAttributeList.Count;
        int iNumberOfInterpolatedValues = this.mConstraintAttributeList.valueAt(0).numberOfInterpolatedValues();
        double[] dArr = new double[size];
        int i2 = iNumberOfInterpolatedValues + 2;
        this.mTempValues = new float[i2];
        this.mCustomCache = new float[iNumberOfInterpolatedValues];
        int[] iArr = new int[2];
        iArr[1] = i2;
        iArr[0] = size;
        double[][] dArr2 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
        for (int i3 = 0; i3 < size; i3++) {
            int iKeyAt = this.mConstraintAttributeList.keyAt(i3);
            androidx.constraintlayout.core.motion.CustomAttribute customAttributeValueAt = this.mConstraintAttributeList.valueAt(i3);
            float[] fArrValueAt = this.mWaveProperties.valueAt(i3);
            dArr[i3] = ((double) iKeyAt) * 0.01d;
            customAttributeValueAt.getValuesToInterpolate(this.mTempValues);
            int i4 = 0;
            while (true) {
                if (i4 >= this.mTempValues.length) {
                    break;
                }
                dArr2[i3][i4] = r8[i4];
                i4++;
            }
            double[] dArr3 = dArr2[i3];
            dArr3[iNumberOfInterpolatedValues] = fArrValueAt[0];
            dArr3[iNumberOfInterpolatedValues + 1] = fArrValueAt[1];
        }
        this.mCurveFit = androidx.constraintlayout.core.motion.utils.CurveFit[i, dArr, dArr2);
    }
}

