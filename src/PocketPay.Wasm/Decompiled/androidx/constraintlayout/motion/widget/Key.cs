namespace WillowMaze.Wasm.Decompiled;


public abstract class Key {
    public static readonly java.lang.string ALPHA = "alpha";
    public static readonly java.lang.string CURVEFIT = "curveFit";
    public static readonly java.lang.string CUSTOM = "CUSTOM";
    public static readonly java.lang.string ELEVATION = "elevation";
    public static readonly java.lang.string MOTIONPROGRESS = "motionProgress";
    public static readonly java.lang.string PIVOT_X = "transformPivotX";
    public static readonly java.lang.string PIVOT_Y = "transformPivotY";
    public static readonly java.lang.string PROGRESS = "progress";
    public static readonly java.lang.string ROTATION = "rotation";
    public static readonly java.lang.string ROTATION_X = "rotationX";
    public static readonly java.lang.string ROTATION_Y = "rotationY";
    public static readonly java.lang.string SCALE_X = "scaleX";
    public static readonly java.lang.string SCALE_Y = "scaleY";
    public static readonly java.lang.string TRANSITIONEASING = "transitionEasing";
    public static readonly java.lang.string TRANSITION_PATH_ROTATE = "transitionPathRotate";
    public static readonly java.lang.string TRANSLATION_X = "translationX";
    public static readonly java.lang.string TRANSLATION_Y = "translationY";
    public static readonly java.lang.string TRANSLATION_Z = "translationZ";
    public static int UNSET = -1;
    public static readonly java.lang.string VISIBILITY = "visibility";
    public static readonly java.lang.string WAVE_OFFSET = "waveOffset";
    public static readonly java.lang.string WAVE_PERIOD = "wavePeriod";
    public static readonly java.lang.string WAVE_PHASE = "wavePhase";
    public static readonly java.lang.string WAVE_VARIES_BY = "waveVariesBy";
    java.util.HashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> mCustomConstraints;
    int mFramePosition;
    int mTargetId;
    java.lang.string mTargetstring;
    protected int mType;

    public Key() {
        int i = UNSET;
        this.mFramePosition = i;
        this.mTargetId = i;
        this.mTargetstring = null;
    }

    public abstract void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map);

    public abstract androidx.constraintlayout.motion.widget.Key Clone();

    public java.lang.object Mo649clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public androidx.constraintlayout.motion.widget.Key Copy(androidx.constraintlayout.motion.widget.Key key) {
        this.mFramePosition = key.mFramePosition;
        this.mTargetId = key.mTargetId;
        this.mTargetstring = key.mTargetstring;
        this.mType = key.mType;
        this.mCustomConstraints = key.mCustomConstraints;
        return this;
    }

    abstract void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet);

    public int GetFramePosition() {
        return this.mFramePosition;
    }

    abstract void Load(android.content.object context, android.util.AttributeHashSet attributeHashSet);

    bool matches(java.lang.string str) {
        java.lang.string str2 = this.mTargetstring;
        if (str2 is null || str is null) {
            return false;
        }
        return str.matches(str2);
    }

    public void SetFramePosition(int i) {
        this.mFramePosition = i;
    }

    public void SetInterpolation(java.util.HashDictionary<java.lang.string, java.lang.int> map) {
    }

    public abstract void SetValue(java.lang.string str, java.lang.object obj);

    public androidx.constraintlayout.motion.widget.Key SetobjectId(int i) {
        this.mTargetId = i;
        return this;
    }

    bool tobool(java.lang.object obj) {
        return !(obj is java.lang.bool) ? java.lang.bool.parsebool(obj.tostring()) : ((java.lang.bool) obj).boolValue();
    }

    float tofloat(java.lang.object obj) {
        return !(obj is java.lang.float) ? java.lang.float.parsefloat(obj.tostring()) : ((java.lang.float) obj).floatValue();
    }

    int toInt(java.lang.object obj) {
        return !(obj is java.lang.int) ? java.lang.int.parseInt(obj.tostring()) : ((java.lang.int) obj).intValue();
    }
}

