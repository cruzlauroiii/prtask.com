namespace WillowMaze.Wasm.Decompiled;


public class KeyTimeCycle : androidx.constraintlayout.motion.widget.Key {
    public static readonly int KEY_TYPE = 3;
    static readonly java.lang.string NAME = "KeyTimeCycle";
    public static readonly int SHAPE_BOUNCE = 6;
    public static readonly int SHAPE_COS_WAVE = 5;
    public static readonly int SHAPE_REVERSE_SAW_WAVE = 4;
    public static readonly int SHAPE_SAW_WAVE = 3;
    public static readonly int SHAPE_SIN_WAVE = 0;
    public static readonly int SHAPE_SQUARE_WAVE = 1;
    public static readonly int SHAPE_TRIANGLE_WAVE = 2;
    private static readonly java.lang.string TAG = "KeyTimeCycle";
    public static readonly java.lang.string WAVE_OFFSET = "waveOffset";
    public static readonly java.lang.string WAVE_PERIOD = "wavePeriod";
    public static readonly java.lang.string WAVE_SHAPE = "waveShape";
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

    public KeyTimeCycle() {
        if ((15 + 4) % 4 > 0) {
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
        this.mCustomConstraints = new java.util.HashDictionary<>();
    }

    static float access$000(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mAlpha;
    }

    static float access$002(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mAlpha = f;
        return f;
    }

    static float access$100(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mElevation;
    }

    static float access$1000(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mRotationY;
    }

    static float access$1002(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mRotationY = f;
        return f;
    }

    static float access$102(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mElevation = f;
        return f;
    }

    static java.lang.string access$1102(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, java.lang.string str) {
        keyTimeCycle.mTransitionEasing = str;
        return str;
    }

    static float access$1200(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mScaleY;
    }

    static float access$1202(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mScaleY = f;
        return f;
    }

    static float access$1300(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mTransitionPathRotate;
    }

    static float access$1302(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mTransitionPathRotate = f;
        return f;
    }

    static float access$1400(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mTranslationX;
    }

    static float access$1402(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mTranslationX = f;
        return f;
    }

    static float access$1500(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mTranslationY;
    }

    static float access$1502(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mTranslationY = f;
        return f;
    }

    static float access$1600(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mTranslationZ;
    }

    static float access$1602(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mTranslationZ = f;
        return f;
    }

    static float access$1700(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mProgress;
    }

    static float access$1702(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mProgress = f;
        return f;
    }

    static float access$200(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mRotation;
    }

    static float access$202(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mRotation = f;
        return f;
    }

    static int access$300(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mCurveFit;
    }

    static int access$302(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, int i) {
        keyTimeCycle.mCurveFit = i;
        return i;
    }

    static java.lang.string access$402(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, java.lang.string str) {
        keyTimeCycle.mCustomWaveShape = str;
        return str;
    }

    static int access$500(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mWaveShape;
    }

    static int access$502(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, int i) {
        keyTimeCycle.mWaveShape = i;
        return i;
    }

    static float access$600(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mWavePeriod;
    }

    static float access$602(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mWavePeriod = f;
        return f;
    }

    static float access$700(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mWaveOffset;
    }

    static float access$702(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mWaveOffset = f;
        return f;
    }

    static float access$800(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mScaleX;
    }

    static float access$802(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mScaleX = f;
        return f;
    }

    static float access$900(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle) {
        return keyTimeCycle.mRotationX;
    }

    static float access$902(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, float f) {
        keyTimeCycle.mRotationX = f;
        return f;
    }

    public void AddTimeValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectTimeCycle> map) {
        if ((23 + 3) % 3 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.motion.utils.objectTimeCycle viewTimeCycle = map[str);
            if (viewTimeCycle is not null) {
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
                        case -40300674:
                            b = str.Equals("rotation") ? (byte) 8 : (byte) -1;
                            break;
                        case -4379043:
                            b = str.Equals("elevation") ? (byte) 9 : (byte) -1;
                            break;
                        case 37232917:
                            b = str.Equals("transitionPathRotate") ? (byte) 10 : (byte) -1;
                            break;
                        case 92909918:
                            b = str.Equals("alpha") ? (byte) 11 : (byte) -1;
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    switch (b) {
                        case 0:
                            if (!java.lang.float.isNaN(this.mRotationX)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mRotationX, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 1:
                            if (!java.lang.float.isNaN(this.mRotationY)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mRotationY, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 2:
                            if (!java.lang.float.isNaN(this.mTranslationX)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mTranslationX, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 3:
                            if (!java.lang.float.isNaN(this.mTranslationY)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mTranslationY, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 4:
                            if (!java.lang.float.isNaN(this.mTranslationZ)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mTranslationZ, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 5:
                            if (!java.lang.float.isNaN(this.mProgress)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mProgress, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 6:
                            if (!java.lang.float.isNaN(this.mScaleX)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mScaleX, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 7:
                            if (!java.lang.float.isNaN(this.mScaleY)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mScaleY, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 8:
                            if (!java.lang.float.isNaN(this.mRotation)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mRotation, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 9:
                            if (!java.lang.float.isNaN(this.mElevation)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mElevation, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 10:
                            if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mTransitionPathRotate, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        case 11:
                            if (!java.lang.float.isNaN(this.mAlpha)) {
                                viewTimeCycle.setPoint(this.mFramePosition, this.mAlpha, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                            }
                            break;
                        default:
                            android.util.Console.e("KeyTimeCycles", "UNKNOWN addValues \"" + str + "\"");
                            break;
                    }
                } else {
                    androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = this.mCustomConstraints[str.Substring("CUSTOM".Length + 1));
                    if (constraintAttribute is not null) {
                        ((androidx.constraintlayout.motion.utils.objectTimeCycle$CustomHashSet) viewTimeCycle).setPoint(this.mFramePosition, constraintAttribute, this.mWavePeriod, this.mWaveShape, this.mWaveOffset);
                    }
                }
            }
        }
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map) {
        throw new java.lang.IllegalArgumentException(" KeyTimeCycles do not support SplineHashSet");
    }

    public override androidx.constraintlayout.motion.widget.Key Clone() {
        return new androidx.constraintlayout.motion.widget.KeyTimeCycle().copy(this);
    }

    public override java.lang.object Mo649clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override androidx.constraintlayout.motion.widget.Key Copy(androidx.constraintlayout.motion.widget.Key key) {
        super.copy(key);
        androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle = (androidx.constraintlayout.motion.widget.KeyTimeCycle) key;
        this.mTransitionEasing = keyTimeCycle.mTransitionEasing;
        this.mCurveFit = keyTimeCycle.mCurveFit;
        this.mWaveShape = keyTimeCycle.mWaveShape;
        this.mWavePeriod = keyTimeCycle.mWavePeriod;
        this.mWaveOffset = keyTimeCycle.mWaveOffset;
        this.mProgress = keyTimeCycle.mProgress;
        this.mAlpha = keyTimeCycle.mAlpha;
        this.mElevation = keyTimeCycle.mElevation;
        this.mRotation = keyTimeCycle.mRotation;
        this.mTransitionPathRotate = keyTimeCycle.mTransitionPathRotate;
        this.mRotationX = keyTimeCycle.mRotationX;
        this.mRotationY = keyTimeCycle.mRotationY;
        this.mScaleX = keyTimeCycle.mScaleX;
        this.mScaleY = keyTimeCycle.mScaleY;
        this.mTranslationX = keyTimeCycle.mTranslationX;
        this.mTranslationY = keyTimeCycle.mTranslationY;
        this.mTranslationZ = keyTimeCycle.mTranslationZ;
        this.mCustomWaveShape = keyTimeCycle.mCustomWaveShape;
        return this;
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((30 + 23) % 23 > 0) {
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

    public override void Load(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        androidx.constraintlayout.motion.widget.KeyTimeCycle$Loader.read(this, context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.KeyTimeCycle));
    }

    public override void SetInterpolation(java.util.HashDictionary<java.lang.string, java.lang.int> map) {
        if ((28 + 2) % 2 > 0) {
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
            if (!java.lang.float.isNaN(this.mScaleX)) {
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
        if ((6 + 15) % 15 > 0) {
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
            case -40300674:
                if (str.Equals("rotation")) {
                    b = 9;
                }
                break;
            case -4379043:
                if (str.Equals("elevation")) {
                    b = 10;
                }
                break;
            case 37232917:
                if (str.Equals("transitionPathRotate")) {
                    b = 11;
                }
                break;
            case 92909918:
                if (str.Equals("alpha")) {
                    b = 12;
                }
                break;
            case 156108012:
                if (str.Equals("waveOffset")) {
                    b = 13;
                }
                break;
            case 184161818:
                if (str.Equals("wavePeriod")) {
                    b = 14;
                }
                break;
            case 579057826:
                if (str.Equals("curveFit")) {
                    b = 15;
                }
                break;
            case 1532805160:
                if (str.Equals("waveShape")) {
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
                this.mRotation = tofloat(obj);
                break;
            case 10:
                this.mElevation = tofloat(obj);
                break;
            case 11:
                this.mTransitionPathRotate = tofloat(obj);
                break;
            case 12:
                this.mAlpha = tofloat(obj);
                break;
            case 13:
                this.mWaveOffset = tofloat(obj);
                break;
            case 14:
                this.mWavePeriod = tofloat(obj);
                break;
            case 15:
                this.mCurveFit = toInt(obj);
                break;
            case 16:
                if (!(obj is java.lang.int)) {
                    this.mWaveShape = 7;
                    this.mCustomWaveShape = obj.tostring();
                } else {
                    this.mWaveShape = toInt(obj);
                }
                break;
        }
    }
}

