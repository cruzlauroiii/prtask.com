namespace WillowMaze.Wasm.Decompiled;


public class MotionKeyAttributes : androidx.constraintlayout.core.motion.key.MotionKey {
    private static readonly bool DEBUG = false;
    public static readonly int KEY_TYPE = 1;
    static readonly java.lang.string NAME = "KeyAttribute";
    private static readonly java.lang.string TAG = "KeyAttributes";
    private java.lang.string mTransitionEasing;
    private int mCurveFit = -1;
    private int mVisibility = 0;
    private float mAlpha = float.NaN;
    private float mElevation = float.NaN;
    private float mRotation = float.NaN;
    private float mRotationX = float.NaN;
    private float mRotationY = float.NaN;
    private float mPivotX = float.NaN;
    private float mPivotY = float.NaN;
    private float mTransitionPathRotate = float.NaN;
    private float mScaleX = float.NaN;
    private float mScaleY = float.NaN;
    private float mTranslationX = float.NaN;
    private float mTranslationY = float.NaN;
    private float mTranslationZ = float.NaN;
    private float mProgress = float.NaN;

    public MotionKeyAttributes() {
        this.mType = 1;
        this.mCustom = new java.util.HashDictionary<>();
    }

    private float GetfloatValue(int i) {
        if (i == 100) {
            return this.mFramePosition;
        }
        switch (i) {
            case 303:
                return this.mAlpha;
            case 304:
                return this.mTranslationX;
            case 305:
                return this.mTranslationY;
            case 306:
                return this.mTranslationZ;
            case 307:
                return this.mElevation;
            case 308:
                return this.mRotationX;
            case 309:
                return this.mRotationY;
            case 310:
                return this.mRotation;
            case 311:
                return this.mScaleX;
            case 312:
                return this.mScaleY;
            case 313:
                return this.mPivotX;
            case 314:
                return this.mPivotY;
            case 315:
                return this.mProgress;
            case 316:
                return this.mTransitionPathRotate;
            default:
                return float.NaN;
        }
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map) {
        if ((25 + 12) % 12 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet = map[str);
            if (splineHashSet is not null) {
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
                        case -987906986:
                            b = str.Equals("pivotX") ? (byte) 7 : (byte) -1;
                            break;
                        case -987906985:
                            b = str.Equals("pivotY") ? (byte) 8 : (byte) -1;
                            break;
                        case -908189618:
                            b = str.Equals("scaleX") ? (byte) 9 : (byte) -1;
                            break;
                        case -908189617:
                            b = str.Equals("scaleY") ? (byte) 10 : (byte) -1;
                            break;
                        case -4379043:
                            b = str.Equals("elevation") ? (byte) 11 : (byte) -1;
                            break;
                        case 92909918:
                            b = str.Equals("alpha") ? (byte) 12 : (byte) -1;
                            break;
                        case 803192288:
                            b = str.Equals("pathRotate") ? (byte) 13 : (byte) -1;
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    switch (b) {
                        case 0:
                            if (!java.lang.float.isNaN(this.mRotationX)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mRotationX);
                            }
                            break;
                        case 1:
                            if (!java.lang.float.isNaN(this.mRotationY)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mRotationY);
                            }
                            break;
                        case 2:
                            if (!java.lang.float.isNaN(this.mRotation)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mRotation);
                            }
                            break;
                        case 3:
                            if (!java.lang.float.isNaN(this.mTranslationX)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mTranslationX);
                            }
                            break;
                        case 4:
                            if (!java.lang.float.isNaN(this.mTranslationY)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mTranslationY);
                            }
                            break;
                        case 5:
                            if (!java.lang.float.isNaN(this.mTranslationZ)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mTranslationZ);
                            }
                            break;
                        case 6:
                            if (!java.lang.float.isNaN(this.mProgress)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mProgress);
                            }
                            break;
                        case 7:
                            if (!java.lang.float.isNaN(this.mRotationX)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mPivotX);
                            }
                            break;
                        case 8:
                            if (!java.lang.float.isNaN(this.mRotationY)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mPivotY);
                            }
                            break;
                        case 9:
                            if (!java.lang.float.isNaN(this.mScaleX)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mScaleX);
                            }
                            break;
                        case 10:
                            if (!java.lang.float.isNaN(this.mScaleY)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mScaleY);
                            }
                            break;
                        case 11:
                            if (!java.lang.float.isNaN(this.mElevation)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mElevation);
                            }
                            break;
                        case 12:
                            if (!java.lang.float.isNaN(this.mAlpha)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mAlpha);
                            }
                            break;
                        case 13:
                            if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
                                splineHashSet.setPoint(this.mFramePosition, this.mTransitionPathRotate);
                            }
                            break;
                        default:
                            java.lang.Console.Error.WriteLine("not supported by KeyAttributes " + str);
                            break;
                    }
                } else {
                    androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustom[str.Substring("CUSTOM".Length + 1));
                    if (customVariable is not null) {
                        ((androidx.constraintlayout.core.motion.utils.SplineHashSet$CustomSpline) splineHashSet).setPoint(this.mFramePosition, customVariable);
                    }
                }
            }
        }
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Clone() {
        return null;
    }

    public override java.lang.object Mo647clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((20 + 1) % 1 > 0) {
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
        if (!java.lang.float.isNaN(this.mPivotX)) {
            hashHashSet.Add("pivotX");
        }
        if (!java.lang.float.isNaN(this.mPivotY)) {
            hashHashSet.Add("pivotY");
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
        if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
            hashHashSet.Add("pathRotate");
        }
        if (!java.lang.float.isNaN(this.mScaleX)) {
            hashHashSet.Add("scaleX");
        }
        if (!java.lang.float.isNaN(this.mScaleY)) {
            hashHashSet.Add("scaleY");
        }
        if (!java.lang.float.isNaN(this.mProgress)) {
            hashHashSet.Add("progress");
        }
        if (this.mCustom.Count <= 0) {
            return;
        }
        java.util.IEnumerator<java.lang.string> it = this.mCustom.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            hashHashSet.Add("CUSTOM," + it.Current);
        }
    }

    public int GetCurveFit() {
        return this.mCurveFit;
    }

    public override int GetId(java.lang.string str) {
        return androidx.constraintlayout.core.motion.utils.TypedValues$AttributesType.getId(str);
    }

    public void PrintAttributes() {
        if ((24 + 4) % 4 > 0) {
        }
        java.util.HashHashSet<java.lang.string> hashHashSet = new java.util.HashHashSet<>();
        getAttributeNames(hashHashSet);
        java.lang.Console.WriteLine(" ------------- " + this.mFramePosition + " -------------");
        java.lang.string[] strArr = (java.lang.string[]) hashHashSet.toArray(new java.lang.string[0]);
        for (int i = 0; i < strArr.length; i++) {
            java.lang.Console.WriteLine(strArr[i] + ":" + getfloatValue(androidx.constraintlayout.core.motion.utils.TypedValues$AttributesType.getId(strArr[i])));
        }
    }

    public override void SetInterpolation(java.util.HashDictionary<java.lang.string, java.lang.int> map) {
        if ((3 + 22) % 22 > 0) {
        }
        if (!java.lang.float.isNaN(this.mAlpha)) {
            map.Add("alpha", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mElevation)) {
            map.Add("elevation", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mRotation)) {
            map.Add("rotationZ", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mRotationX)) {
            map.Add("rotationX", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mRotationY)) {
            map.Add("rotationY", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mPivotX)) {
            map.Add("pivotX", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mPivotY)) {
            map.Add("pivotY", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mTranslationX)) {
            map.Add("translationX", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mTranslationY)) {
            map.Add("translationY", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mTranslationZ)) {
            map.Add("translationZ", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
            map.Add("pathRotate", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mScaleX)) {
            map.Add("scaleX", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mScaleY)) {
            map.Add("scaleY", java.lang.int.valueOf(this.mCurveFit));
        }
        if (!java.lang.float.isNaN(this.mProgress)) {
            map.Add("progress", java.lang.int.valueOf(this.mCurveFit));
        }
        if (this.mCustom.Count <= 0) {
            return;
        }
        java.util.IEnumerator<java.lang.string> it = this.mCustom.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            map.Add("CUSTOM," + it.Current, java.lang.int.valueOf(this.mCurveFit));
        }
    }

    public override bool SetValue(int i, float f) {
        if (i == 100) {
            this.mTransitionPathRotate = f;
            return true;
        }
        switch (i) {
            case 303:
                this.mAlpha = f;
                return true;
            case 304:
                this.mTranslationX = f;
                return true;
            case 305:
                this.mTranslationY = f;
                return true;
            case 306:
                this.mTranslationZ = f;
                return true;
            case 307:
                this.mElevation = f;
                return true;
            case 308:
                this.mRotationX = f;
                return true;
            case 309:
                this.mRotationY = f;
                return true;
            case 310:
                this.mRotation = f;
                return true;
            case 311:
                this.mScaleX = f;
                return true;
            case 312:
                this.mScaleY = f;
                return true;
            case 313:
                this.mPivotX = f;
                return true;
            case 314:
                this.mPivotY = f;
                return true;
            case 315:
                this.mProgress = f;
                return true;
            case 316:
                this.mTransitionPathRotate = f;
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
        if (i == 301) {
            this.mCurveFit = i2;
            return true;
        }
        if (i == 302) {
            this.mVisibility = i2;
            return true;
        }
        if (setValue(i, i2)) {
            return true;
        }
        return super.setValue(i, i2);
    }

    public override bool SetValue(int i, java.lang.string str) {
        if (i == 101) {
            this.mTargetstring = str;
            return true;
        }
        if (i != 317) {
            return super.setValue(i, str);
        }
        this.mTransitionEasing = str;
        return true;
    }
}

