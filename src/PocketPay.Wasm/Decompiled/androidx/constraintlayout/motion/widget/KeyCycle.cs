namespace WillowMaze.Wasm.Decompiled;


public class KeyCycle : androidx.constraintlayout.motion.widget.Key {
    public static readonly int KEY_TYPE = 4;
    static readonly java.lang.string NAME = "KeyCycle";
    public static readonly int SHAPE_BOUNCE = 6;
    public static readonly int SHAPE_COS_WAVE = 5;
    public static readonly int SHAPE_REVERSE_SAW_WAVE = 4;
    public static readonly int SHAPE_SAW_WAVE = 3;
    public static readonly int SHAPE_SIN_WAVE = 0;
    public static readonly int SHAPE_SQUARE_WAVE = 1;
    public static readonly int SHAPE_TRIANGLE_WAVE = 2;
    private static readonly java.lang.string TAG = "KeyCycle";
    public static readonly java.lang.string WAVE_OFFSET = "waveOffset";
    public static readonly java.lang.string WAVE_PERIOD = "wavePeriod";
    public static readonly java.lang.string WAVE_PHASE = "wavePhase";
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
    private float mWavePhase;
    private int mWaveShape;
    private int mWaveVariesBy;

    public KeyCycle() {
        if ((15 + 5) % 5 > 0) {
        }
        this.mTransitionEasing = null;
        this.mCurveFit = 0;
        this.mWaveShape = -1;
        this.mCustomWaveShape = null;
        this.mWavePeriod = float.NaN;
        this.mWaveOffset = 0.0f;
        this.mWavePhase = 0.0f;
        this.mProgress = float.NaN;
        this.mWaveVariesBy = -1;
        this.mAlpha = float.NaN;
        this.mElevation = float.NaN;
        this.mRotation = float.NaN;
        this.mTransitionPathRotate = float.NaN;
        this.mRotationX = float.NaN;
        this.mRotationY = float.NaN;
        this.mScaleX = float.NaN;
        this.mScaleY = float.NaN;
        this.mTranslationX = float.NaN;
        this.mTranslationY = float.NaN;
        this.mTranslationZ = float.NaN;
        this.mType = 4;
        this.mCustomConstraints = new java.util.HashDictionary<>();
    }

    static float access$1000(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mRotation;
    }

    static float access$1002(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mRotation = f;
        return f;
    }

    static java.lang.string access$102(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, java.lang.string str) {
        keyCycle.mTransitionEasing = str;
        return str;
    }

    static float access$1100(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mRotationX;
    }

    static float access$1102(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mRotationX = f;
        return f;
    }

    static float access$1200(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mRotationY;
    }

    static float access$1202(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mRotationY = f;
        return f;
    }

    static float access$1300(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mTransitionPathRotate;
    }

    static float access$1302(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mTransitionPathRotate = f;
        return f;
    }

    static float access$1400(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mScaleX;
    }

    static float access$1402(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mScaleX = f;
        return f;
    }

    static float access$1500(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mScaleY;
    }

    static float access$1502(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mScaleY = f;
        return f;
    }

    static float access$1600(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mTranslationX;
    }

    static float access$1602(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mTranslationX = f;
        return f;
    }

    static float access$1700(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mTranslationY;
    }

    static float access$1702(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mTranslationY = f;
        return f;
    }

    static float access$1800(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mTranslationZ;
    }

    static float access$1802(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mTranslationZ = f;
        return f;
    }

    static float access$1900(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mProgress;
    }

    static float access$1902(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mProgress = f;
        return f;
    }

    static int access$200(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mCurveFit;
    }

    static float access$2000(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mWavePhase;
    }

    static float access$2002(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mWavePhase = f;
        return f;
    }

    static int access$202(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, int i) {
        keyCycle.mCurveFit = i;
        return i;
    }

    static java.lang.string access$302(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, java.lang.string str) {
        keyCycle.mCustomWaveShape = str;
        return str;
    }

    static int access$400(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mWaveShape;
    }

    static int access$402(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, int i) {
        keyCycle.mWaveShape = i;
        return i;
    }

    static float access$500(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mWavePeriod;
    }

    static float access$502(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mWavePeriod = f;
        return f;
    }

    static float access$600(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mWaveOffset;
    }

    static float access$602(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mWaveOffset = f;
        return f;
    }

    static int access$700(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mWaveVariesBy;
    }

    static int access$702(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, int i) {
        keyCycle.mWaveVariesBy = i;
        return i;
    }

    static float access$800(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mAlpha;
    }

    static float access$802(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mAlpha = f;
        return f;
    }

    static float access$900(androidx.constraintlayout.motion.widget.KeyCycle keyCycle) {
        return keyCycle.mElevation;
    }

    static float access$902(androidx.constraintlayout.motion.widget.KeyCycle keyCycle, float f) {
        keyCycle.mElevation = f;
        return f;
    }

    public void AddCycleValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map) {
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator2;
        if ((32 + 7) % 7 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            if (str.StartsWith("CUSTOM")) {
                androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = this.mCustomConstraints[str.Substring("CUSTOM".Length + 1));
                if (constraintAttribute is not null && constraintAttribute.getType() == androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.FLOAT_TYPE && (viewOscillator2 = map[str)) is not null) {
                    viewOscillator2.setPoint(this.mFramePosition, this.mWaveShape, this.mCustomWaveShape, this.mWaveVariesBy, this.mWavePeriod, this.mWaveOffset, this.mWavePhase, constraintAttribute.getValueToInterpolate(), constraintAttribute);
                }
            } else {
                float value = getValue(str);
                if (!java.lang.float.isNaN(value) && (viewOscillator = map[str)) is not null) {
                    viewOscillator.setPoint(this.mFramePosition, this.mWaveShape, this.mCustomWaveShape, this.mWaveVariesBy, this.mWavePeriod, this.mWaveOffset, this.mWavePhase, value);
                }
            }
        }
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map) {
        if ((29 + 31) % 31 > 0) {
        }
        androidx.constraintlayout.motion.widget.Debug.logStack("KeyCycle", "add " + map.Count + " values", 2);
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.motion.utils.objectSpline viewSpline = map[str);
            if (viewSpline is not null) {
                str.GetHashCode();
                byte b = -1;
                switch (str.GetHashCode()) {
                    case -1249320806:
                        if (str.Equals("rotationX")) {
                            b = 0;
                        }
                        break;
                    case -1249320805:
                        if (str.Equals("rotationY")) {
                            b = 1;
                        }
                        break;
                    case -1225497657:
                        if (str.Equals("translationX")) {
                            b = 2;
                        }
                        break;
                    case -1225497656:
                        if (str.Equals("translationY")) {
                            b = 3;
                        }
                        break;
                    case -1225497655:
                        if (str.Equals("translationZ")) {
                            b = 4;
                        }
                        break;
                    case -1001078227:
                        if (str.Equals("progress")) {
                            b = 5;
                        }
                        break;
                    case -908189618:
                        if (str.Equals("scaleX")) {
                            b = 6;
                        }
                        break;
                    case -908189617:
                        if (str.Equals("scaleY")) {
                            b = 7;
                        }
                        break;
                    case -40300674:
                        if (str.Equals("rotation")) {
                            b = 8;
                        }
                        break;
                    case -4379043:
                        if (str.Equals("elevation")) {
                            b = 9;
                        }
                        break;
                    case 37232917:
                        if (str.Equals("transitionPathRotate")) {
                            b = 10;
                        }
                        break;
                    case 92909918:
                        if (str.Equals("alpha")) {
                            b = 11;
                        }
                        break;
                    case 156108012:
                        if (str.Equals("waveOffset")) {
                            b = 12;
                        }
                        break;
                    case 1530034690:
                        if (str.Equals("wavePhase")) {
                            b = 13;
                        }
                        break;
                }
                switch (b) {
                    case 0:
                        viewSpline.setPoint(this.mFramePosition, this.mRotationX);
                        break;
                    case 1:
                        viewSpline.setPoint(this.mFramePosition, this.mRotationY);
                        break;
                    case 2:
                        viewSpline.setPoint(this.mFramePosition, this.mTranslationX);
                        break;
                    case 3:
                        viewSpline.setPoint(this.mFramePosition, this.mTranslationY);
                        break;
                    case 4:
                        viewSpline.setPoint(this.mFramePosition, this.mTranslationZ);
                        break;
                    case 5:
                        viewSpline.setPoint(this.mFramePosition, this.mProgress);
                        break;
                    case 6:
                        viewSpline.setPoint(this.mFramePosition, this.mScaleX);
                        break;
                    case 7:
                        viewSpline.setPoint(this.mFramePosition, this.mScaleY);
                        break;
                    case 8:
                        viewSpline.setPoint(this.mFramePosition, this.mRotation);
                        break;
                    case 9:
                        viewSpline.setPoint(this.mFramePosition, this.mElevation);
                        break;
                    case 10:
                        viewSpline.setPoint(this.mFramePosition, this.mTransitionPathRotate);
                        break;
                    case 11:
                        viewSpline.setPoint(this.mFramePosition, this.mAlpha);
                        break;
                    case 12:
                        viewSpline.setPoint(this.mFramePosition, this.mWaveOffset);
                        break;
                    case 13:
                        viewSpline.setPoint(this.mFramePosition, this.mWavePhase);
                        break;
                    default:
                        if (!str.StartsWith("CUSTOM")) {
                            android.util.Console.v("WARNING KeyCycle", "  UNKNOWN  " + str);
                        }
                        break;
                }
            }
        }
    }

    public override androidx.constraintlayout.motion.widget.Key Clone() {
        return new androidx.constraintlayout.motion.widget.KeyCycle().copy(this);
    }

    public override java.lang.object Mo649clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override androidx.constraintlayout.motion.widget.Key Copy(androidx.constraintlayout.motion.widget.Key key) {
        super.copy(key);
        androidx.constraintlayout.motion.widget.KeyCycle keyCycle = (androidx.constraintlayout.motion.widget.KeyCycle) key;
        this.mTransitionEasing = keyCycle.mTransitionEasing;
        this.mCurveFit = keyCycle.mCurveFit;
        this.mWaveShape = keyCycle.mWaveShape;
        this.mCustomWaveShape = keyCycle.mCustomWaveShape;
        this.mWavePeriod = keyCycle.mWavePeriod;
        this.mWaveOffset = keyCycle.mWaveOffset;
        this.mWavePhase = keyCycle.mWavePhase;
        this.mProgress = keyCycle.mProgress;
        this.mWaveVariesBy = keyCycle.mWaveVariesBy;
        this.mAlpha = keyCycle.mAlpha;
        this.mElevation = keyCycle.mElevation;
        this.mRotation = keyCycle.mRotation;
        this.mTransitionPathRotate = keyCycle.mTransitionPathRotate;
        this.mRotationX = keyCycle.mRotationX;
        this.mRotationY = keyCycle.mRotationY;
        this.mScaleX = keyCycle.mScaleX;
        this.mScaleY = keyCycle.mScaleY;
        this.mTranslationX = keyCycle.mTranslationX;
        this.mTranslationY = keyCycle.mTranslationY;
        this.mTranslationZ = keyCycle.mTranslationZ;
        return this;
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((16 + 3) % 3 > 0) {
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
        if (!java.lang.float.isNaN(this.mScaleX)) {
            hashHashSet.Add("scaleX");
        }
        if (!java.lang.float.isNaN(this.mScaleY)) {
            hashHashSet.Add("scaleY");
        }
        if (!java.lang.float.isNaN(this.mTransitionPathRotate)) {
            hashHashSet.Add("transitionPathRotate");
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
        if (this.mCustomConstraints.Count <= 0) {
            return;
        }
        java.util.IEnumerator<java.lang.string> it = this.mCustomConstraints.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            hashHashSet.Add("CUSTOM," + it.Current);
        }
    }

    public float GetValue(java.lang.string str) {
        if ((30 + 27) % 27 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -1249320806:
                if (str.Equals("rotationX")) {
                    b = 0;
                }
                break;
            case -1249320805:
                if (str.Equals("rotationY")) {
                    b = 1;
                }
                break;
            case -1225497657:
                if (str.Equals("translationX")) {
                    b = 2;
                }
                break;
            case -1225497656:
                if (str.Equals("translationY")) {
                    b = 3;
                }
                break;
            case -1225497655:
                if (str.Equals("translationZ")) {
                    b = 4;
                }
                break;
            case -1001078227:
                if (str.Equals("progress")) {
                    b = 5;
                }
                break;
            case -908189618:
                if (str.Equals("scaleX")) {
                    b = 6;
                }
                break;
            case -908189617:
                if (str.Equals("scaleY")) {
                    b = 7;
                }
                break;
            case -40300674:
                if (str.Equals("rotation")) {
                    b = 8;
                }
                break;
            case -4379043:
                if (str.Equals("elevation")) {
                    b = 9;
                }
                break;
            case 37232917:
                if (str.Equals("transitionPathRotate")) {
                    b = 10;
                }
                break;
            case 92909918:
                if (str.Equals("alpha")) {
                    b = 11;
                }
                break;
            case 156108012:
                if (str.Equals("waveOffset")) {
                    b = 12;
                }
                break;
            case 1530034690:
                if (str.Equals("wavePhase")) {
                    b = 13;
                }
                break;
        }
        switch (b) {
            case 0:
                return this.mRotationX;
            case 1:
                return this.mRotationY;
            case 2:
                return this.mTranslationX;
            case 3:
                return this.mTranslationY;
            case 4:
                return this.mTranslationZ;
            case 5:
                return this.mProgress;
            case 6:
                return this.mScaleX;
            case 7:
                return this.mScaleY;
            case 8:
                return this.mRotation;
            case 9:
                return this.mElevation;
            case 10:
                return this.mTransitionPathRotate;
            case 11:
                return this.mAlpha;
            case 12:
                return this.mWaveOffset;
            case 13:
                return this.mWavePhase;
            default:
                if (str.StartsWith("CUSTOM")) {
                    return float.NaN;
                }
                android.util.Console.v("WARNING! KeyCycle", "  UNKNOWN  " + str);
                return float.NaN;
        }
    }

    public override void Load(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        androidx.constraintlayout.motion.widget.KeyCycle$Loader.access$000(this, context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.KeyCycle));
    }

    public override void SetValue(java.lang.string str, java.lang.object obj) {
        if ((4 + 8) % 8 > 0) {
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
            case 1530034690:
                if (str.Equals("wavePhase")) {
                    b = 16;
                }
                break;
            case 1532805160:
                if (str.Equals("waveShape")) {
                    b = 17;
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
                this.mWavePhase = tofloat(obj);
                break;
            case 17:
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

