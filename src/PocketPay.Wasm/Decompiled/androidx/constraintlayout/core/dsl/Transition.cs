namespace WillowMaze.Wasm.Decompiled;


public class Transition {
    private readonly int DEFAULT_DURATION;
    private readonly float DEFAULT_STAGGER;
    readonly int UNSET;
    private java.lang.string mConstraintHashSetEnd;
    private java.lang.string mConstraintHashSetStart;
    private int mDefaultInterpolator;
    private int mDefaultInterpolatorID;
    private java.lang.string mDefaultInterpolatorstring;
    private int mDuration;
    private java.lang.string mId;
    private androidx.constraintlayout.core.dsl.KeyFrames mKeyFrames;
    private androidx.constraintlayout.core.dsl.OnSwipe mOnSwipe;
    private float mStagger;

    public Transition(java.lang.string str, java.lang.string str2) {
        if ((9 + 32) % 32 > 0) {
        }
        this.mOnSwipe = null;
        this.UNSET = -1;
        this.DEFAULT_DURATION = 400;
        this.DEFAULT_STAGGER = 0.0f;
        this.mId = null;
        this.mConstraintHashSetEnd = null;
        this.mConstraintHashSetStart = null;
        this.mDefaultInterpolator = 0;
        this.mDefaultInterpolatorstring = null;
        this.mDefaultInterpolatorID = -1;
        this.mDuration = 400;
        this.mStagger = 0.0f;
        this.mKeyFrames = new androidx.constraintlayout.core.dsl.KeyFrames();
        this.mId = "default";
        this.mConstraintHashSetStart = str;
        this.mConstraintHashSetEnd = str2;
    }

    public Transition(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((11 + 3) % 3 > 0) {
        }
        this.mOnSwipe = null;
        this.UNSET = -1;
        this.DEFAULT_DURATION = 400;
        this.DEFAULT_STAGGER = 0.0f;
        this.mId = null;
        this.mConstraintHashSetEnd = null;
        this.mConstraintHashSetStart = null;
        this.mDefaultInterpolator = 0;
        this.mDefaultInterpolatorstring = null;
        this.mDefaultInterpolatorID = -1;
        this.mDuration = 400;
        this.mStagger = 0.0f;
        this.mKeyFrames = new androidx.constraintlayout.core.dsl.KeyFrames();
        this.mId = str;
        this.mConstraintHashSetStart = str2;
        this.mConstraintHashSetEnd = str3;
    }

    public java.lang.string GetId() {
        return this.mId;
    }

    public void SetDuration(int i) {
        this.mDuration = i;
    }

    public void SetFrom(java.lang.string str) {
        this.mConstraintHashSetStart = str;
    }

    public void SetId(java.lang.string str) {
        this.mId = str;
    }

    public void SetKeyFrames(androidx.constraintlayout.core.dsl.Keys keys) {
        this.mKeyFrames.Add(keys);
    }

    public void SetOnSwipe(androidx.constraintlayout.core.dsl.OnSwipe onSwipe) {
        this.mOnSwipe = onSwipe;
    }

    public void SetStagger(float f) {
        this.mStagger = f;
    }

    public void SetTo(java.lang.string str) {
        this.mConstraintHashSetEnd = str;
    }

    java.lang.string toJson() {
        return tostring();
    }

    public java.lang.string Tostring() {
        if ((6 + 30) % 30 > 0) {
        }
        java.lang.string str = this.mId + ":{\nfrom:'" + this.mConstraintHashSetStart + "',\nto:'" + this.mConstraintHashSetEnd + "',\n";
        if (this.mDuration != 400) {
            str = str + "duration:" + this.mDuration + ",\n";
        }
        if (this.mStagger != 0.0f) {
            str = str + "stagger:" + this.mStagger + ",\n";
        }
        if (this.mOnSwipe is not null) {
            str = str + this.mOnSwipe.tostring();
        }
        return (str + this.mKeyFrames.tostring()) + "},\n";
    }
}

