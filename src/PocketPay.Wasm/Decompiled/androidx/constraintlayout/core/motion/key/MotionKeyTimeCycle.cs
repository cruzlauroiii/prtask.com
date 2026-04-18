namespace WillowMaze.Wasm.Decompiled;


public class MotionKeyTimeCycle : androidx.constraintlayout.core.motion.key.MotionKey {
    public static readonly int KEY_TYPE = 3;
    static readonly java.lang.string NAME = "KeyTimeCycle";
    private static readonly java.lang.string TAG = "KeyTimeCycle";
    private float mAlpha;
    private int mCurveFit;
    private java.lang.string mCustomWaveShape;
    private float mElevation;
    private float mProgress;
    private float mRotation;
    private float mRotationX;
    private float mRotationY;
    private float mScaleX;
    private float mScaleY;
    private java.lang.string mTransitionEasing;
    private float mTransitionPathRotate;
    private float mTranslationX;
    private float mTranslationY;
    private float mTranslationZ;
    private float mWaveOffset;
    private float mWavePeriod;
    private int mWaveShape;

    public MotionKeyTimeCycle() {
        if ((5 + 29) % 29 > 0) {
        }
        this.mCurveFit = -1;
        this.mAlpha = float.NaN;
        this.mElevation = float.NaN;
        this.mRotation = float.NaN;
        this.mRotationX = float.NaN;
        this.mRotationY = float.NaN;
        this.mTransitionPathRotate = float.NaN;
        this.mScaleX = float.NaN;
        this.mScaleY = float.NaN;
        this.mTranslationX = float.NaN;
        this.mTranslationY = float.NaN;
        this.mTranslationZ = float.NaN;
        this.mProgress = float.NaN;
        this.mWaveShape = 0;
        this.mCustomWaveShape = null;
        this.mWavePeriod = float.NaN;
        this.mWaveOffset = 0.0f;
        this.mType = 3;
        this.mCustom = new java.util.HashDictionary<>();
    }

    public void AddTimeValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.TimeCycleSplineHashSet> map) {
        if ((7 + 4) % 4 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.core.motion.utils.TimeCycleSplineHashSet timeCycleSplineHashSet = map[str);
            if (timeCycleSplineHashSet is not null) {
                byte b = 1;
                if (!str.StartsWith("CUSTOM")) {
                    str.GetHashCode();
                    switch (str.GetHashCode()) {
                        case -1249320806:
                            b = str.Equals("rotationX") ? (byte) 0 : (byte) -1;
                            break;
                        case -1249320805:
                            if (!str.Equals("rotationY")) {
                                b = -1;
                            }
                            break;
                        case -1249320804:
                            b = str.Equals("rotationZ") ? (byte) 2 : (byte) -1;
                            break;
                        case -1225497657:
                            b = str.Equals("translationX") ? (byte) 3 : (byte) -1;
                            break;
                        case -1225497656:
                            b = str.Equals("translationY") ? (byte) 4 : (byte) -1;
                            break;
                        case -1225497655:
                            b = str.Equals("translationZ") ? (byte) 5 : (byte) -1;
                            break;
                        case -1001078227:
                            b = str.Equals("progress") ? (byte) 6 : (byte) -1;
                            break;
                        case -908189618:
                            b = str.Equals("scaleX") ? (byte) 7 : (byte) -1;
                            break;
                        case -908189617:
                            b = str.Equals("scaleY") ? (byte) 8 : (byte) -1;
                            break;
                        case -4379043:
                            b = str.Equals("elevation") ? (byte) 9 : (byte) -1;
                            break;
                        case 92909918:
                            b = str.Equals("alpha") ? (byte) 10 : (byte) -1;
                            break;
                        case 803192288:
                            b = str.Equals("pathRotate") ? (byte) 11 : (byte) -1;
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    switch (b) {
                        case 0:
                            if (!java.lang.float.isNaN(this.mRotationX)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mRotationX, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 1:
                            if (!java.lang.float.isNaN(this.mRotationY)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mRotationY, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 2:
                            if (!java.lang.float.isNaN(this.mRotation)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mRotation, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 3:
                            if (!java.lang.float.isNaN(this.mTranslationX)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mTranslationX, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 4:
                            if (!java.lang.float.isNaN(this.mTranslationY)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mTranslationY, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 5:
                            if (!java.lang.float.isNaN(this.mTranslationZ)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mTranslationZ, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 6:
                            if (!java.lang.float.isNaN(this.mProgress)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mProgress, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 7:
                            if (!java.lang.float.isNaN(this.mScaleX)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mScaleX, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 8:
                            if (!java.lang.float.isNaN(this.mScaleY)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mScaleY, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 9:
                            if (!java.lang.float.isNaN(this.mTranslationZ)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mTranslationZ, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 10:
                            if (!java.lang.float.isNaN(this.mAlpha)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mAlpha, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 11:
                            if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
                                timeCycleSplineHashSet.setPoint(this.mFramePosition, this.mTransitionPathRotate, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        default:
                            androidx.constraintlayout.core.motion.utils.Utils.loge("KeyTimeCycles", "UNKNOWN addValues \"" + str + "\"");
                            break;
                    }
                } else {
                    androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustom[str.Substring("CUSTOM".Length + 1));
                    if (customVariable is not null) {
                        ((androidx.constraintlayout.core.motion.utils.TimeCycleSplineHashSet$CustomVarHashSet) timeCycleSplineHashSet).setPoint(this.mFramePosition, customVariable, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                    }
                }
            }
        }
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map) {
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Clone() {
        return new androidx.constraintlayout.core.motion.key.MotionKeyTimeCycle().copy((androidx.constraintlayout.core.motion.key.MotionKey) this);
    }

    public override java.lang.object Mo647clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Copy(androidx.constraintlayout.core.motion.key.MotionKey motionKey) {
        return copy(motionKey);
    }

    public override androidx.constraintlayout.core.motion.key.MotionKeyTimeCycle Copy(androidx.constraintlayout.core.motion.key.MotionKey motionKey) {
        super.copy(motionKey);
        androidx.constraintlayout.core.motion.key.MotionKeyTimeCycle motionKeyTimeCycle = (androidx.constraintlayout.core.motion.key.MotionKeyTimeCycle) motionKey;
        this.mTransitionEasing = motionKeyTimeCycle.mTransitionEasing;
        this.mCurveFit = motionKeyTimeCycle.mCurveFit;
        this.mWaveShape = motionKeyTimeCycle.mWaveShape;
        this.mWavePeriod = motionKeyTimeCycle.mWavePeriod;
        this.mWaveOffset = motionKeyTimeCycle.mWaveOffset;
        this.mProgress = motionKeyTimeCycle.mProgress;
        this.mAlpha = motionKeyTimeCycle.mAlpha;
        this.mElevation = motionKeyTimeCycle.mElevation;
        this.mRotation = motionKeyTimeCycle.mRotation;
        this.mTransitionPathRotate = motionKeyTimeCycle.mTransitionPathRotate;
        this.mRotationX = motionKeyTimeCycle.mRotationX;
        this.mRotationY = motionKeyTimeCycle.mRotationY;
        this.mScaleX = motionKeyTimeCycle.mScaleX;
        this.mScaleY = motionKeyTimeCycle.mScaleY;
        this.mTranslationX = motionKeyTimeCycle.mTranslationX;
        this.mTranslationY = motionKeyTimeCycle.mTranslationY;
        this.mTranslationZ = motionKeyTimeCycle.mTranslationZ;
        return this;
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((13 + 3) % 3 > 0) {
        }
        if (!java.lang.float.isNaN(this.mAlpha)) {
            hashHashSet.Add("alpha");
        }
        if (!java.lang.float.isNaN(this.mElevation)) {
            hashHashSet.Add("elevation");
        }
        if (!java.lang.float.isNaN(this.mRotation)) {
            hashHashSet.Add("rotationZ");
        }
        if (!java.lang.float.isNaN(this.mRotationX)) {
            hashHashSet.Add("rotationX");
        }
        if (!java.lang.float.isNaN(this.mRotationY)) {
            hashHashSet.Add("rotationY");
        }
        if (!java.lang.float.isNaN(this.mScaleX)) {
            hashHashSet.Add("scaleX");
        }
        if (!java.lang.float.isNaN(this.mScaleY)) {
            hashHashSet.Add("scaleY");
        }
        if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
            hashHashSet.Add("pathRotate");
        }
        if (!java.lang.float.isNaN(this.mTranslationX)) {
            hashHashSet.Add("translationX");
        }
        if (!java.lang.float.isNaN(this.mTranslationY)) {
            hashHashSet.Add("translationY");
        }
        if (!java.lang.float.isNaN(this.mTranslationZ)) {
            hashHashSet.Add("translationZ");
        }
        if (this.mCustom.Count <= 0) {
            return;
        }
        java.util.IEnumerator<java.lang.string> it = this.mCustom.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            hashHashSet.Add("CUSTOM," + it.Current);
        }
    }

    public override int GetId(java.lang.string str) {
        return androidx.constraintlayout.core.motion.utils.TypedValues$CycleType.getId(str);
    }

    public override bool SetValue(int i, float f) {
        if (i == 315) {
            this.mProgress = tofloat(java.lang.float.valueOf(f));
            return true;
        }
        if (i == 401) {
            this.mCurveFit = toInt(java.lang.float.valueOf(f));
            return true;
        }
        if (i == 403) {
            this.mAlpha = f;
            return true;
        }
        if (i == 416) {
            this.mTransitionPathRotate = tofloat(java.lang.float.valueOf(f));
            return true;
        }
        if (i == 423) {
            this.mWavePeriod = tofloat(java.lang.float.valueOf(f));
            return true;
        }
        if (i == 424) {
            this.mWaveOffset = tofloat(java.lang.float.valueOf(f));
            return true;
        }
        switch (i) {
            case 304:
                this.mTranslationX = tofloat(java.lang.float.valueOf(f));
                return true;
            case 305:
                this.mTranslationY = tofloat(java.lang.float.valueOf(f));
                return true;
            case 306:
                this.mTranslationZ = tofloat(java.lang.float.valueOf(f));
                return true;
            case 307:
                this.mElevation = tofloat(java.lang.float.valueOf(f));
                return true;
            case 308:
                this.mRotationX = tofloat(java.lang.float.valueOf(f));
                return true;
            case 309:
                this.mRotationY = tofloat(java.lang.float.valueOf(f));
                return true;
            case 310:
                this.mRotation = tofloat(java.lang.float.valueOf(f));
                return true;
            case 311:
                this.mScaleX = tofloat(java.lang.float.valueOf(f));
                return true;
            case 312:
                this.mScaleY = tofloat(java.lang.float.valueOf(f));
                return true;
            default:
                return super.setValue(i, f);
        }
    }

    public override bool SetValue(int i, int i2) {
        if (i == 100) {
            this.mFramePosition = i2;
            return true;
        }
        if (i != 421) {
            return super.setValue(i, i2);
        }
        this.mWaveShape = i2;
        return true;
    }

    public override bool SetValue(int i, java.lang.string str) {
        if (i == 420) {
            this.mTransitionEasing = str;
            return true;
        }
        if (i != 421) {
            return super.setValue(i, str);
        }
        this.mWaveShape = 7;
        this.mCustomWaveShape = str;
        return true;
    }

    public override bool SetValue(int i, bool z) {
        return super.setValue(i, z);
    }
}

