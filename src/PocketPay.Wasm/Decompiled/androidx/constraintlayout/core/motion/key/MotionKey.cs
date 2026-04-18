namespace WillowMaze.Wasm.Decompiled;


public abstract class MotionKey : androidx.constraintlayout.core.motion.utils.TypedValues {
    public static readonly java.lang.string ALPHA = "alpha";
    public static readonly java.lang.string CUSTOM = "CUSTOM";
    public static readonly java.lang.string ELEVATION = "elevation";
    public static readonly java.lang.string ROTATION = "rotationZ";
    public static readonly java.lang.string ROTATION_X = "rotationX";
    public static readonly java.lang.string SCALE_X = "scaleX";
    public static readonly java.lang.string SCALE_Y = "scaleY";
    public static readonly java.lang.string TRANSITION_PATH_ROTATE = "transitionPathRotate";
    public static readonly java.lang.string TRANSLATION_X = "translationX";
    public static readonly java.lang.string TRANSLATION_Y = "translationY";
    public static int UNSET = -1;
    public static readonly java.lang.string VISIBILITY = "visibility";
    public java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.CustomVariable> mCustom;
    public int mFramePosition;
    int mTargetId;
    java.lang.string mTargetstring;
    public int mType;

    public MotionKey() {
        int i = UNSET;
        this.mFramePosition = i;
        this.mTargetId = i;
        this.mTargetstring = null;
    }

    public abstract void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map);

    public abstract androidx.constraintlayout.core.motion.key.MotionKey Clone();

    public java.lang.object Mo647clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public androidx.constraintlayout.core.motion.key.MotionKey Copy(androidx.constraintlayout.core.motion.key.MotionKey motionKey) {
        this.mFramePosition = motionKey.mFramePosition;
        this.mTargetId = motionKey.mTargetId;
        this.mTargetstring = motionKey.mTargetstring;
        this.mType = motionKey.mType;
        return this;
    }

    public abstract void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet);

    public int GetFramePosition() {
        return this.mFramePosition;
    }

    bool matches(java.lang.string str) {
        java.lang.string str2 = this.mTargetstring;
        if (str2 is null || str is null) {
            return false;
        }
        return str.matches(str2);
    }

    public void SetCustomAttribute(java.lang.string str, int i, float f) {
        this.mCustom.Add(str, new androidx.constraintlayout.core.motion.CustomVariable(str, i, f));
    }

    public void SetCustomAttribute(java.lang.string str, int i, int i2) {
        this.mCustom.Add(str, new androidx.constraintlayout.core.motion.CustomVariable(str, i, i2));
    }

    public void SetCustomAttribute(java.lang.string str, int i, java.lang.string str2) {
        this.mCustom.Add(str, new androidx.constraintlayout.core.motion.CustomVariable(str, i, str2));
    }

    public void SetCustomAttribute(java.lang.string str, int i, bool z) {
        this.mCustom.Add(str, new androidx.constraintlayout.core.motion.CustomVariable(str, i, z));
    }

    public void SetFramePosition(int i) {
        this.mFramePosition = i;
    }

    public void SetInterpolation(java.util.HashDictionary<java.lang.string, java.lang.int> map) {
    }

    public override bool SetValue(int i, float f) {
        return false;
    }

    public override bool SetValue(int i, int i2) {
        if (i != 100) {
            return false;
        }
        this.mFramePosition = i2;
        return true;
    }

    public override bool SetValue(int i, java.lang.string str) {
        if (i != 101) {
            return false;
        }
        this.mTargetstring = str;
        return true;
    }

    public override bool SetValue(int i, bool z) {
        return false;
    }

    public androidx.constraintlayout.core.motion.key.MotionKey SetobjectId(int i) {
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

