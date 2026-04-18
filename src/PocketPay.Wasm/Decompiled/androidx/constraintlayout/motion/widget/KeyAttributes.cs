namespace WillowMaze.Wasm.Decompiled;


public class KeyAttributes : androidx.constraintlayout.motion.widget.Key {
    private static readonly bool DEBUG = false;
    public static readonly int KEY_TYPE = 1;
    static readonly java.lang.string NAME = "KeyAttribute";
    private static readonly java.lang.string TAG = "KeyAttributes";
    private java.lang.string mTransitionEasing;
    private int mCurveFit = -1;
    private bool mVisibility = false;
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

    public KeyAttributes() {
        this.mType = 1;
        this.mCustomConstraints = new java.util.HashDictionary<>();
    }

    static float access$000(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mAlpha;
    }

    static float access$002(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mAlpha = f;
        return f;
    }

    static float access$100(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mElevation;
    }

    static float access$1000(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mScaleY;
    }

    static float access$1002(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mScaleY = f;
        return f;
    }

    static float access$102(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mElevation = f;
        return f;
    }

    static float access$1100(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mTransitionPathRotate;
    }

    static float access$1102(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mTransitionPathRotate = f;
        return f;
    }

    static float access$1200(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mTranslationX;
    }

    static float access$1202(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mTranslationX = f;
        return f;
    }

    static float access$1300(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mTranslationY;
    }

    static float access$1302(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mTranslationY = f;
        return f;
    }

    static float access$1400(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mTranslationZ;
    }

    static float access$1402(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mTranslationZ = f;
        return f;
    }

    static float access$1500(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mProgress;
    }

    static float access$1502(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mProgress = f;
        return f;
    }

    static float access$200(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mRotation;
    }

    static float access$202(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mRotation = f;
        return f;
    }

    static int access$300(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mCurveFit;
    }

    static int access$302(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, int i) {
        keyAttributes.mCurveFit = i;
        return i;
    }

    static float access$400(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mScaleX;
    }

    static float access$402(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mScaleX = f;
        return f;
    }

    static float access$500(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mRotationX;
    }

    static float access$502(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mRotationX = f;
        return f;
    }

    static float access$600(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mRotationY;
    }

    static float access$602(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mRotationY = f;
        return f;
    }

    static float access$700(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mPivotX;
    }

    static float access$702(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mPivotX = f;
        return f;
    }

    static float access$800(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes) {
        return keyAttributes.mPivotY;
    }

    static float access$802(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, float f) {
        keyAttributes.mPivotY = f;
        return f;
    }

    static java.lang.string access$902(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, java.lang.string str) {
        keyAttributes.mTransitionEasing = str;
        return str;
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map) {
        if ((3 + 2) % 2 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.motion.utils.objectSpline viewSpline = map[str);
            if (viewSpline is not null) {
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
                        case -1225497657:
                            b = str.Equals("translationX") ? (byte) 2 : (byte) -1;
                            break;
                        case -1225497656:
                            b = str.Equals("translationY") ? (byte) 3 : (byte) -1;
                            break;
                        case -1225497655:
                            b = str.Equals("translationZ") ? (byte) 4 : (byte) -1;
                            break;
                        case -1001078227:
                            b = str.Equals("progress") ? (byte) 5 : (byte) -1;
                            break;
                        case -908189618:
                            b = str.Equals("scaleX") ? (byte) 6 : (byte) -1;
                            break;
                        case -908189617:
                            b = str.Equals("scaleY") ? (byte) 7 : (byte) -1;
                            break;
                        case -760884510:
                            b = str.Equals("transformPivotX") ? (byte) 8 : (byte) -1;
                            break;
                        case -760884509:
                            b = str.Equals("transformPivotY") ? (byte) 9 : (byte) -1;
                            break;
                        case -40300674:
                            b = str.Equals("rotation") ? (byte) 10 : (byte) -1;
                            break;
                        case -4379043:
                            b = str.Equals("elevation") ? (byte) 11 : (byte) -1;
                            break;
                        case 37232917:
                            b = str.Equals("transitionPathRotate") ? (byte) 12 : (byte) -1;
                            break;
                        case 92909918:
                            b = str.Equals("alpha") ? (byte) 13 : (byte) -1;
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    switch (b) {
                        case 0:
                            if (!java.lang.float.isNaN(this.mRotationX)) {
                                viewSpline.setPoint(this.mFramePosition, this.mRotationX);
                            }
                            break;
                        case 1:
                            if (!java.lang.float.isNaN(this.mRotationY)) {
                                viewSpline.setPoint(this.mFramePosition, this.mRotationY);
                            }
                            break;
                        case 2:
                            if (!java.lang.float.isNaN(this.mTranslationX)) {
                                viewSpline.setPoint(this.mFramePosition, this.mTranslationX);
                            }
                            break;
                        case 3:
                            if (!java.lang.float.isNaN(this.mTranslationY)) {
                                viewSpline.setPoint(this.mFramePosition, this.mTranslationY);
                            }
                            break;
                        case 4:
                            if (!java.lang.float.isNaN(this.mTranslationZ)) {
                                viewSpline.setPoint(this.mFramePosition, this.mTranslationZ);
                            }
                            break;
                        case 5:
                            if (!java.lang.float.isNaN(this.mProgress)) {
                                viewSpline.setPoint(this.mFramePosition, this.mProgress);
                            }
                            break;
                        case 6:
                            if (!java.lang.float.isNaN(this.mScaleX)) {
                                viewSpline.setPoint(this.mFramePosition, this.mScaleX);
                            }
                            break;
                        case 7:
                            if (!java.lang.float.isNaN(this.mScaleY)) {
                                viewSpline.setPoint(this.mFramePosition, this.mScaleY);
                            }
                            break;
                        case 8:
                            if (!java.lang.float.isNaN(this.mRotationX)) {
                                viewSpline.setPoint(this.mFramePosition, this.mPivotX);
                            }
                            break;
                        case 9:
                            if (!java.lang.float.isNaN(this.mRotationY)) {
                                viewSpline.setPoint(this.mFramePosition, this.mPivotY);
                            }
                            break;
                        case 10:
                            if (!java.lang.float.isNaN(this.mRotation)) {
                                viewSpline.setPoint(this.mFramePosition, this.mRotation);
                            }
                            break;
                        case 11:
                            if (!java.lang.float.isNaN(this.mElevation)) {
                                viewSpline.setPoint(this.mFramePosition, this.mElevation);
                            }
                            break;
                        case 12:
                            if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
                                viewSpline.setPoint(this.mFramePosition, this.mTransitionPathRotate);
                            }
                            break;
                        case 13:
                            if (!java.lang.float.isNaN(this.mAlpha)) {
                                viewSpline.setPoint(this.mFramePosition, this.mAlpha);
                            }
                            break;
                    }
                } else {
                    androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = this.mCustomConstraints[str.Substring("CUSTOM".Length + 1));
                    if (constraintAttribute is not null) {
                        ((androidx.constraintlayout.motion.utils.objectSpline$CustomHashSet) viewSpline).setPoint(this.mFramePosition, constraintAttribute);
                    }
                }
            }
        }
    }

    public override androidx.constraintlayout.motion.widget.Key Clone() {
        return new androidx.constraintlayout.motion.widget.KeyAttributes().copy(this);
    }

    public override java.lang.object Mo649clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override androidx.constraintlayout.motion.widget.Key Copy(androidx.constraintlayout.motion.widget.Key key) {
        super.copy(key);
        androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes = (androidx.constraintlayout.motion.widget.KeyAttributes) key;
        this.mCurveFit = keyAttributes.mCurveFit;
        this.mVisibility = keyAttributes.mVisibility;
        this.mAlpha = keyAttributes.mAlpha;
        this.mElevation = keyAttributes.mElevation;
        this.mRotation = keyAttributes.mRotation;
        this.mRotationX = keyAttributes.mRotationX;
        this.mRotationY = keyAttributes.mRotationY;
        this.mPivotX = keyAttributes.mPivotX;
        this.mPivotY = keyAttributes.mPivotY;
        this.mTransitionPathRotate = keyAttributes.mTransitionPathRotate;
        this.mScaleX = keyAttributes.mScaleX;
        this.mScaleY = keyAttributes.mScaleY;
        this.mTranslationX = keyAttributes.mTranslationX;
        this.mTranslationY = keyAttributes.mTranslationY;
        this.mTranslationZ = keyAttributes.mTranslationZ;
        this.mProgress = keyAttributes.mProgress;
        this.mTransitionEasing = keyAttributes.mTransitionEasing;
        return this;
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((17 + 10) % 10 > 0) {
        }
        if (!java.lang.float.isNaN(this.mAlpha)) {
            hashHashSet.Add("alpha");
        }
        if (!java.lang.float.isNaN(this.mElevation)) {
            hashHashSet.Add("elevation");
        }
        if (!java.lang.float.isNaN(this.mRotation)) {
            hashHashSet.Add("rotation");
        }
        if (!java.lang.float.isNaN(this.mRotationX)) {
            hashHashSet.Add("rotationX");
        }
        if (!java.lang.float.isNaN(this.mRotationY)) {
            hashHashSet.Add("rotationY");
        }
        if (!java.lang.float.isNaN(this.mPivotX)) {
            hashHashSet.Add("transformPivotX");
        }
        if (!java.lang.float.isNaN(this.mPivotY)) {
            hashHashSet.Add("transformPivotY");
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
            hashHashSet.Add("transitionPathRotate");
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
        if (this.mCustomConstraints.Count <= 0) {
            return;
        }
        java.util.IEnumerator<java.lang.string> it = this.mCustomConstraints.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            hashHashSet.Add("CUSTOM," + it.Current);
        }
    }

    int getCurveFit() {
        return this.mCurveFit;
    }

    public override void Load(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        androidx.constraintlayout.motion.widget.KeyAttributes$Loader.read(this, context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.KeyAttribute));
    }

    public override void SetInterpolation(java.util.HashDictionary<java.lang.string, java.lang.int> map) {
        if ((17 + 2) % 2 > 0) {
        }
        if (this.mCurveFit != -1) {
            if (!java.lang.float.isNaN(this.mAlpha)) {
                map.Add("alpha", java.lang.int.valueOf(this.mCurveFit));
            }
            if (!java.lang.float.isNaN(this.mElevation)) {
                map.Add("elevation", java.lang.int.valueOf(this.mCurveFit));
            }
            if (!java.lang.float.isNaN(this.mRotation)) {
                map.Add("rotation", java.lang.int.valueOf(this.mCurveFit));
            }
            if (!java.lang.float.isNaN(this.mRotationX)) {
                map.Add("rotationX", java.lang.int.valueOf(this.mCurveFit));
            }
            if (!java.lang.float.isNaN(this.mRotationY)) {
                map.Add("rotationY", java.lang.int.valueOf(this.mCurveFit));
            }
            if (!java.lang.float.isNaN(this.mPivotX)) {
                map.Add("transformPivotX", java.lang.int.valueOf(this.mCurveFit));
            }
            if (!java.lang.float.isNaN(this.mPivotY)) {
                map.Add("transformPivotY", java.lang.int.valueOf(this.mCurveFit));
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
                map.Add("transitionPathRotate", java.lang.int.valueOf(this.mCurveFit));
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
            if (this.mCustomConstraints.Count <= 0) {
                return;
            }
            java.util.IEnumerator<java.lang.string> it = this.mCustomConstraints.keyHashSet().GetEnumerator();
            while (it.MoveNext()) {
                map.Add("CUSTOM," + it.Current, java.lang.int.valueOf(this.mCurveFit));
            }
        }
    }

    public override void SetValue(java.lang.string str, java.lang.object obj) {
        if ((6 + 32) % 32 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -1913008125:
                if (str.Equals("motionProgress")) {
                    b = 0;
                }
                break;
            case -1812823328:
                if (str.Equals("transitionEasing")) {
                    b = 1;
                }
                break;
            case -1249320806:
                if (str.Equals("rotationX")) {
                    b = 2;
                }
                break;
            case -1249320805:
                if (str.Equals("rotationY")) {
                    b = 3;
                }
                break;
            case -1225497657:
                if (str.Equals("translationX")) {
                    b = 4;
                }
                break;
            case -1225497656:
                if (str.Equals("translationY")) {
                    b = 5;
                }
                break;
            case -1225497655:
                if (str.Equals("translationZ")) {
                    b = 6;
                }
                break;
            case -908189618:
                if (str.Equals("scaleX")) {
                    b = 7;
                }
                break;
            case -908189617:
                if (str.Equals("scaleY")) {
                    b = 8;
                }
                break;
            case -760884510:
                if (str.Equals("transformPivotX")) {
                    b = 9;
                }
                break;
            case -760884509:
                if (str.Equals("transformPivotY")) {
                    b = 10;
                }
                break;
            case -40300674:
                if (str.Equals("rotation")) {
                    b = 11;
                }
                break;
            case -4379043:
                if (str.Equals("elevation")) {
                    b = 12;
                }
                break;
            case 37232917:
                if (str.Equals("transitionPathRotate")) {
                    b = 13;
                }
                break;
            case 92909918:
                if (str.Equals("alpha")) {
                    b = 14;
                }
                break;
            case 579057826:
                if (str.Equals("curveFit")) {
                    b = 15;
                }
                break;
            case 1941332754:
                if (str.Equals("visibility")) {
                    b = 16;
                }
                break;
        }
        switch (b) {
            case 0:
                this.mProgress = tofloat(obj);
                break;
            case 1:
                this.mTransitionEasing = obj.tostring();
                break;
            case 2:
                this.mRotationX = tofloat(obj);
                break;
            case 3:
                this.mRotationY = tofloat(obj);
                break;
            case 4:
                this.mTranslationX = tofloat(obj);
                break;
            case 5:
                this.mTranslationY = tofloat(obj);
                break;
            case 6:
                this.mTranslationZ = tofloat(obj);
                break;
            case 7:
                this.mScaleX = tofloat(obj);
                break;
            case 8:
                this.mScaleY = tofloat(obj);
                break;
            case 9:
                this.mPivotX = tofloat(obj);
                break;
            case 10:
                this.mPivotY = tofloat(obj);
                break;
            case 11:
                this.mRotation = tofloat(obj);
                break;
            case 12:
                this.mElevation = tofloat(obj);
                break;
            case 13:
                this.mTransitionPathRotate = tofloat(obj);
                break;
            case 14:
                this.mAlpha = tofloat(obj);
                break;
            case 15:
                this.mCurveFit = toInt(obj);
                break;
            case 16:
                this.mVisibility = tobool(obj);
                break;
        }
    }
}

