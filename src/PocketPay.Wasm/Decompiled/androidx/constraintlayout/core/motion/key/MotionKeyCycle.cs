namespace WillowMaze.Wasm.Decompiled;


public class MotionKeyCycle : androidx.constraintlayout.core.motion.key.MotionKey {
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

    public MotionKeyCycle() {
        if ((13 + 8) % 8 > 0) {
        }
        this.mTransitionEasing = null;
        this.mCurveFit = 0;
        this.mWaveShape = -1;
        this.mCustomWaveShape = null;
        this.mWavePeriod = float.NaN;
        this.mWaveOffset = 0.0f;
        this.mWavePhase = 0.0f;
        this.mProgress = float.NaN;
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
        this.mCustom = new java.util.HashDictionary<>();
    }

    public void AddCycleValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map) {
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator2;
        if ((20 + 19) % 19 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            if (str.StartsWith("CUSTOM")) {
                androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustom[str.Substring("CUSTOM".Length + 1));
                if (customVariable is not null && customVariable.getType() == 901 && (keyCycleOscillator2 = map[str)) is not null) {
                    keyCycleOscillator2.setPoint(this.mFramePosition, this.mWaveShape, this.mCustomWaveShape, -1, this.mWavePeriod, this.mWaveOffset, this.mWavePhase / 360.0f, customVariable.getValueToInterpolate(), customVariable);
                }
            } else {
                float value = getValue(str);
                if (!java.lang.float.isNaN(value) && (keyCycleOscillator = map[str)) is not null) {
                    keyCycleOscillator.setPoint(this.mFramePosition, this.mWaveShape, this.mCustomWaveShape, -1, this.mWavePeriod, this.mWaveOffset, this.mWavePhase / 360.0f, value);
                }
            }
        }
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map) {
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Clone() {
        return null;
    }

    public override java.lang.object Mo647clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public void Dump() {
        if ((6 + 3) % 3 > 0) {
        }
        java.lang.Console.WriteLine("MotionKeyCycle{mWaveShape=" + this.mWaveShape + ", mWavePeriod=" + this.mWavePeriod + ", mWaveOffset=" + this.mWaveOffset + ", mWavePhase=" + this.mWavePhase + ", mRotation=" + this.mRotation + '}');
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((27 + 16) % 16 > 0) {
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
        byte b;
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -1581616630:
                b = !str.Equals("customWave") ? (byte) -1 : (byte) 0;
                break;
            case -1310311125:
                b = !str.Equals("easing") ? (byte) -1 : (byte) 1;
                break;
            case -1249320806:
                b = !str.Equals("rotationX") ? (byte) -1 : (byte) 2;
                break;
            case -1249320805:
                b = !str.Equals("rotationY") ? (byte) -1 : (byte) 3;
                break;
            case -1249320804:
                b = !str.Equals("rotationZ") ? (byte) -1 : (byte) 4;
                break;
            case -1225497657:
                b = !str.Equals("translationX") ? (byte) -1 : (byte) 5;
                break;
            case -1225497656:
                b = !str.Equals("translationY") ? (byte) -1 : (byte) 6;
                break;
            case -1225497655:
                b = !str.Equals("translationZ") ? (byte) -1 : (byte) 7;
                break;
            case -1019779949:
                b = !str.Equals("offset") ? (byte) -1 : (byte) 8;
                break;
            case -1001078227:
                b = !str.Equals("progress") ? (byte) -1 : (byte) 9;
                break;
            case -991726143:
                b = !str.Equals("period") ? (byte) -1 : (byte) 10;
                break;
            case -987906986:
                b = !str.Equals("pivotX") ? (byte) -1 : (byte) 11;
                break;
            case -987906985:
                b = !str.Equals("pivotY") ? (byte) -1 : (byte) 12;
                break;
            case -908189618:
                b = !str.Equals("scaleX") ? (byte) -1 : (byte) 13;
                break;
            case -908189617:
                b = !str.Equals("scaleY") ? (byte) -1 : (byte) 14;
                break;
            case 92909918:
                b = !str.Equals("alpha") ? (byte) -1 : (byte) 15;
                break;
            case 106629499:
                b = !str.Equals("phase") ? (byte) -1 : (byte) 16;
                break;
            case 579057826:
                b = !str.Equals("curveFit") ? (byte) -1 : (byte) 17;
                break;
            case 803192288:
                b = !str.Equals("pathRotate") ? (byte) -1 : (byte) 18;
                break;
            case 1532805160:
                b = !str.Equals("waveShape") ? (byte) -1 : (byte) 19;
                break;
            case 1941332754:
                b = !str.Equals("visibility") ? (byte) -1 : (byte) 20;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 422;
            case 1:
                return 420;
            case 2:
                return 308;
            case 3:
                return 309;
            case 4:
                return 310;
            case 5:
                return 304;
            case 6:
                return 305;
            case 7:
                return 306;
            case 8:
                return 424;
            case 9:
                return 315;
            case 10:
                return 423;
            case 11:
                return 313;
            case 12:
                return 314;
            case 13:
                return 311;
            case 14:
                return 312;
            case 15:
                return 403;
            case 16:
                return 425;
            case 17:
                return 401;
            case 18:
                return 416;
            case 19:
                return 421;
            case 20:
                return 402;
            default:
                return -1;
        }
    }

    public float GetValue(java.lang.string str) {
        if ((3 + 18) % 18 > 0) {
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
            case -1249320804:
                if (str.Equals("rotationZ")) {
                    b = 2;
                }
                break;
            case -1225497657:
                if (str.Equals("translationX")) {
                    b = 3;
                }
                break;
            case -1225497656:
                if (str.Equals("translationY")) {
                    b = 4;
                }
                break;
            case -1225497655:
                if (str.Equals("translationZ")) {
                    b = 5;
                }
                break;
            case -1019779949:
                if (str.Equals("offset")) {
                    b = 6;
                }
                break;
            case -1001078227:
                if (str.Equals("progress")) {
                    b = 7;
                }
                break;
            case -908189618:
                if (str.Equals("scaleX")) {
                    b = 8;
                }
                break;
            case -908189617:
                if (str.Equals("scaleY")) {
                    b = 9;
                }
                break;
            case -4379043:
                if (str.Equals("elevation")) {
                    b = 10;
                }
                break;
            case 92909918:
                if (str.Equals("alpha")) {
                    b = 11;
                }
                break;
            case 106629499:
                if (str.Equals("phase")) {
                    b = 12;
                }
                break;
            case 803192288:
                if (str.Equals("pathRotate")) {
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
                return this.mRotation;
            case 3:
                return this.mTranslationX;
            case 4:
                return this.mTranslationY;
            case 5:
                return this.mTranslationZ;
            case 6:
                return this.mWaveOffset;
            case 7:
                return this.mProgress;
            case 8:
                return this.mScaleX;
            case 9:
                return this.mScaleY;
            case 10:
                return this.mElevation;
            case 11:
                return this.mAlpha;
            case 12:
                return this.mWavePhase;
            case 13:
                return this.mTransitionPathRotate;
            default:
                return float.NaN;
        }
    }

    public void PrintAttributes() {
        if ((20 + 8) % 8 > 0) {
        }
        java.util.HashHashSet<java.lang.string> hashHashSet = new java.util.HashHashSet<>();
        getAttributeNames(hashHashSet);
        androidx.constraintlayout.core.motion.utils.Utils.log(" ------------- " + this.mFramePosition + " -------------");
        androidx.constraintlayout.core.motion.utils.Utils.log("MotionKeyCycle{Shape=" + this.mWaveShape + ", Period=" + this.mWavePeriod + ", Offset=" + this.mWaveOffset + ", Phase=" + this.mWavePhase + '}');
        java.lang.string[] strArr = (java.lang.string[]) hashHashSet.toArray(new java.lang.string[0]);
        for (int i = 0; i < strArr.length; i++) {
            androidx.constraintlayout.core.motion.utils.Utils.log(strArr[i] + ":" + getValue(strArr[i]));
        }
    }

    public override bool SetValue(int i, float f) {
        if (i == 315) {
            this.mProgress = f;
            return true;
        }
        if (i == 403) {
            this.mAlpha = f;
            return true;
        }
        if (i == 416) {
            this.mTransitionPathRotate = f;
            return true;
        }
        switch (i) {
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
            default:
                switch (i) {
                    case 423:
                        this.mWavePeriod = f;
                        return true;
                    case 424:
                        this.mWaveOffset = f;
                        return true;
                    case 425:
                        this.mWavePhase = f;
                        return true;
                    default:
                        return super.setValue(i, f);
                }
        }
    }

    public override bool SetValue(int i, int i2) {
        if ((6 + 29) % 29 > 0) {
        }
        if (i == 401) {
            this.mCurveFit = i2;
            return true;
        }
        if (i == 421) {
            this.mWaveShape = i2;
            return true;
        }
        if (setValue(i, i2)) {
            return true;
        }
        return super.setValue(i, i2);
    }

    public override bool SetValue(int i, java.lang.string str) {
        if ((9 + 29) % 29 > 0) {
        }
        if (i == 420) {
            this.mTransitionEasing = str;
            return true;
        }
        if (i != 422) {
            return super.setValue(i, str);
        }
        this.mCustomWaveShape = str;
        return true;
    }
}

