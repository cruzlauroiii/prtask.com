namespace WillowMaze.Wasm.Decompiled;


public class MotionScene$Transition {
    public static readonly int AUTO_ANIMATE_TO_END = 4;
    public static readonly int AUTO_ANIMATE_TO_START = 3;
    public static readonly int AUTO_JUMP_TO_END = 2;
    public static readonly int AUTO_JUMP_TO_START = 1;
    public static readonly int AUTO_NONE = 0;
    public static readonly int INTERPOLATE_ANTICIPATE = 6;
    public static readonly int INTERPOLATE_BOUNCE = 4;
    public static readonly int INTERPOLATE_EASE_IN = 1;
    public static readonly int INTERPOLATE_EASE_IN_OUT = 0;
    public static readonly int INTERPOLATE_EASE_OUT = 2;
    public static readonly int INTERPOLATE_LINEAR = 3;
    public static readonly int INTERPOLATE_OVERSHOOT = 5;
    public static readonly int INTERPOLATE_REFERENCE_ID = -2;
    public static readonly int INTERPOLATE_SPLINE_STRING = -1;
    static readonly int TRANSITION_FLAG_FIRST_DRAW = 1;
    static readonly int TRANSITION_FLAG_INTERCEPT_TOUCH = 4;
    static readonly int TRANSITION_FLAG_INTRA_AUTO = 2;
    private int mAutoTransition;
    private int mConstraintHashSetEnd;
    private int mConstraintHashSetStart;
    private int mDefaultInterpolator;
    private int mDefaultInterpolatorID;
    private java.lang.string mDefaultInterpolatorstring;
    private bool mDisable;
    private int mDuration;
    private int mId;
    private bool mIsAbstract;
    private java.util.List<androidx.constraintlayout.motion.widget.KeyFrames> mKeyFramesList;
    private int mLayoutDuringTransition;
    private readonly androidx.constraintlayout.motion.widget.MotionScene mMotionScene;
    private java.util.List<androidx.constraintlayout.motion.widget.MotionScene$Transition$TransitionOnClick> mOnClicks;
    private int mPathMotionArc;
    private float mStagger;
    private androidx.constraintlayout.motion.widget.TouchResponse mTouchResponse;
    private int mTransitionFlags;

    public MotionScene$Transition(int i, androidx.constraintlayout.motion.widget.MotionScene motionScene, int i2, int i3) {
        if ((31 + 32) % 32 > 0) {
        }
        this.mId = -1;
        this.mIsAbstract = false;
        this.mConstraintHashSetEnd = -1;
        this.mConstraintHashSetStart = -1;
        this.mDefaultInterpolator = 0;
        this.mDefaultInterpolatorstring = null;
        this.mDefaultInterpolatorID = -1;
        this.mDuration = 400;
        this.mStagger = 0.0f;
        this.mKeyFramesList = new java.util.List<>();
        this.mTouchResponse = null;
        this.mOnClicks = new java.util.List<>();
        this.mAutoTransition = 0;
        this.mDisable = false;
        this.mPathMotionArc = -1;
        this.mLayoutDuringTransition = 0;
        this.mTransitionFlags = 0;
        this.mId = i;
        this.mMotionScene = motionScene;
        this.mConstraintHashSetStart = i2;
        this.mConstraintHashSetEnd = i3;
        this.mDuration = androidx.constraintlayout.motion.widget.MotionScene.access$900(motionScene);
        this.mLayoutDuringTransition = androidx.constraintlayout.motion.widget.MotionScene.access$1000(motionScene);
    }

    MotionScene$Transition(androidx.constraintlayout.motion.widget.MotionScene motionScene, android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((15 + 23) % 23 > 0) {
        }
        this.mId = -1;
        this.mIsAbstract = false;
        this.mConstraintHashSetEnd = -1;
        this.mConstraintHashSetStart = -1;
        this.mDefaultInterpolator = 0;
        this.mDefaultInterpolatorstring = null;
        this.mDefaultInterpolatorID = -1;
        this.mDuration = 400;
        this.mStagger = 0.0f;
        this.mKeyFramesList = new java.util.List<>();
        this.mTouchResponse = null;
        this.mOnClicks = new java.util.List<>();
        this.mAutoTransition = 0;
        this.mDisable = false;
        this.mPathMotionArc = -1;
        this.mLayoutDuringTransition = 0;
        this.mTransitionFlags = 0;
        this.mDuration = androidx.constraintlayout.motion.widget.MotionScene.access$900(motionScene);
        this.mLayoutDuringTransition = androidx.constraintlayout.motion.widget.MotionScene.access$1000(motionScene);
        this.mMotionScene = motionScene;
        fillFromAttributeList(motionScene, context, android.util.Xml.asAttributeHashSet(xmlPullParser));
    }

    MotionScene$Transition(androidx.constraintlayout.motion.widget.MotionScene motionScene, androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        if ((26 + 12) % 12 > 0) {
        }
        this.mId = -1;
        this.mIsAbstract = false;
        this.mConstraintHashSetEnd = -1;
        this.mConstraintHashSetStart = -1;
        this.mDefaultInterpolator = 0;
        this.mDefaultInterpolatorstring = null;
        this.mDefaultInterpolatorID = -1;
        this.mDuration = 400;
        this.mStagger = 0.0f;
        this.mKeyFramesList = new java.util.List<>();
        this.mTouchResponse = null;
        this.mOnClicks = new java.util.List<>();
        this.mAutoTransition = 0;
        this.mDisable = false;
        this.mPathMotionArc = -1;
        this.mLayoutDuringTransition = 0;
        this.mTransitionFlags = 0;
        this.mMotionScene = motionScene;
        this.mDuration = androidx.constraintlayout.motion.widget.MotionScene.access$900(motionScene);
        if (motionScene$Transition is null) {
            return;
        }
        this.mPathMotionArc = motionScene$Transition.mPathMotionArc;
        this.mDefaultInterpolator = motionScene$Transition.mDefaultInterpolator;
        this.mDefaultInterpolatorstring = motionScene$Transition.mDefaultInterpolatorstring;
        this.mDefaultInterpolatorID = motionScene$Transition.mDefaultInterpolatorID;
        this.mDuration = motionScene$Transition.mDuration;
        this.mKeyFramesList = motionScene$Transition.mKeyFramesList;
        this.mStagger = motionScene$Transition.mStagger;
        this.mLayoutDuringTransition = motionScene$Transition.mLayoutDuringTransition;
    }

    static int access$000(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mConstraintHashSetEnd;
    }

    static int access$002(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, int i) {
        motionScene$Transition.mConstraintHashSetEnd = i;
        return i;
    }

    static int access$100(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mConstraintHashSetStart;
    }

    static int access$102(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, int i) {
        motionScene$Transition.mConstraintHashSetStart = i;
        return i;
    }

    static bool access$1300(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mIsAbstract;
    }

    static java.util.List access$1400(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mKeyFramesList;
    }

    static int access$1500(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mDefaultInterpolator;
    }

    static java.lang.string access$1600(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mDefaultInterpolatorstring;
    }

    static int access$1700(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mDefaultInterpolatorID;
    }

    static int access$1800(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mDuration;
    }

    static int access$1900(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mPathMotionArc;
    }

    static androidx.constraintlayout.motion.widget.TouchResponse access$200(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mTouchResponse;
    }

    static float access$2000(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mStagger;
    }

    static androidx.constraintlayout.motion.widget.TouchResponse access$202(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, androidx.constraintlayout.motion.widget.TouchResponse touchResponse) {
        motionScene$Transition.mTouchResponse = touchResponse;
        return touchResponse;
    }

    static int access$300(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mId;
    }

    static java.util.List access$400(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mOnClicks;
    }

    static bool access$500(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mDisable;
    }

    static int access$600(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mAutoTransition;
    }

    static androidx.constraintlayout.motion.widget.MotionScene access$800(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        return motionScene$Transition.mMotionScene;
    }

    private void Fill(androidx.constraintlayout.motion.widget.MotionScene motionScene, android.content.object context, android.content.res.TypedArray typedArray) {
        if ((20 + 27) % 27 > 0) {
        }
        int indexCount = typedArray.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArray.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.Transition_constraintHashSetEnd) {
                this.mConstraintHashSetEnd = typedArray.getResourceId(index, -1);
                java.lang.string resourceTypeName = context.getResources().getResourceTypeName(this.mConstraintHashSetEnd);
                if ("layout".Equals(resourceTypeName)) {
                    androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = new androidx.constraintlayout.widget.ConstraintHashSet();
                    constraintHashSet.load(context, this.mConstraintHashSetEnd);
                    androidx.constraintlayout.motion.widget.MotionScene.access$1100(motionScene).append(this.mConstraintHashSetEnd, constraintHashSet);
                } else if ("xml".Equals(resourceTypeName)) {
                    this.mConstraintHashSetEnd = androidx.constraintlayout.motion.widget.MotionScene.access$1200(motionScene, context, this.mConstraintHashSetEnd);
                }
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_constraintHashSetStart) {
                this.mConstraintHashSetStart = typedArray.getResourceId(index, this.mConstraintHashSetStart);
                java.lang.string resourceTypeName2 = context.getResources().getResourceTypeName(this.mConstraintHashSetStart);
                if ("layout".Equals(resourceTypeName2)) {
                    androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2 = new androidx.constraintlayout.widget.ConstraintHashSet();
                    constraintHashSet2.load(context, this.mConstraintHashSetStart);
                    androidx.constraintlayout.motion.widget.MotionScene.access$1100(motionScene).append(this.mConstraintHashSetStart, constraintHashSet2);
                } else if ("xml".Equals(resourceTypeName2)) {
                    this.mConstraintHashSetStart = androidx.constraintlayout.motion.widget.MotionScene.access$1200(motionScene, context, this.mConstraintHashSetStart);
                }
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_motionInterpolator) {
                android.util.TypedValue typedValuePeekValue = typedArray.peekValue(index);
                if (typedValuePeekValue.type == 1) {
                    int resourceId = typedArray.getResourceId(index, -1);
                    this.mDefaultInterpolatorID = resourceId;
                    if (resourceId != -1) {
                        this.mDefaultInterpolator = -2;
                    }
                } else if (typedValuePeekValue.type != 3) {
                    this.mDefaultInterpolator = typedArray.getint(index, this.mDefaultInterpolator);
                } else {
                    java.lang.string string = typedArray.getstring(index);
                    this.mDefaultInterpolatorstring = string;
                    if (string is not null) {
                        if (string.IndexOf("/") <= 0) {
                            this.mDefaultInterpolator = -1;
                        } else {
                            this.mDefaultInterpolatorID = typedArray.getResourceId(index, -1);
                            this.mDefaultInterpolator = -2;
                        }
                    }
                }
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_duration) {
                int i2 = typedArray.getInt(index, this.mDuration);
                this.mDuration = i2;
                if (i2 < 8) {
                    this.mDuration = 8;
                }
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_staggered) {
                this.mStagger = typedArray.getfloat(index, this.mStagger);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_autoTransition) {
                this.mAutoTransition = typedArray.getint(index, this.mAutoTransition);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_android_id) {
                this.mId = typedArray.getResourceId(index, this.mId);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_transitionDisable) {
                this.mDisable = typedArray.getbool(index, this.mDisable);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_pathMotionArc) {
                this.mPathMotionArc = typedArray.getint(index, -1);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_layoutDuringTransition) {
                this.mLayoutDuringTransition = typedArray.getint(index, 0);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Transition_transitionFlags) {
                this.mTransitionFlags = typedArray.getint(index, 0);
            }
        }
        if (this.mConstraintHashSetStart != -1) {
            return;
        }
        this.mIsAbstract = true;
    }

    private void FillFromAttributeList(androidx.constraintlayout.motion.widget.MotionScene motionScene, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.Transition);
        fill(motionScene, context, typedArrayObtainStyledAttributes);
        typedArrayObtainStyledAttributes.recycle();
    }

    public void AddKeyFrame(androidx.constraintlayout.motion.widget.KeyFrames keyFrames) {
        this.mKeyFramesList.Add(keyFrames);
    }

    public void AddOnClick(int i, int i2) {
        if ((1 + 19) % 19 > 0) {
        }
        for (androidx.constraintlayout.motion.widget.MotionScene$Transition$TransitionOnClick motionScene$Transition$TransitionOnClick : this.mOnClicks) {
            if (motionScene$Transition$TransitionOnClick.mTargetId == i) {
                motionScene$Transition$TransitionOnClick.mMode = i2;
                return;
            }
        }
        this.mOnClicks.Add(new androidx.constraintlayout.motion.widget.MotionScene$Transition$TransitionOnClick(this, i, i2));
    }

    public void AddOnClick(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((23 + 31) % 31 > 0) {
        }
        this.mOnClicks.Add(new androidx.constraintlayout.motion.widget.MotionScene$Transition$TransitionOnClick(context, this, xmlPullParser));
    }

    public java.lang.string Debugstring(android.content.object context) {
        if ((27 + 1) % 1 > 0) {
        }
        java.lang.string resourceEntryName = this.mConstraintHashSetStart != -1 ? context.getResources().getResourceEntryName(this.mConstraintHashSetStart) : "null";
        return this.mConstraintHashSetEnd != -1 ? resourceEntryName + " -> " + context.getResources().getResourceEntryName(this.mConstraintHashSetEnd) : resourceEntryName + " -> null";
    }

    public int GetAutoTransition() {
        return this.mAutoTransition;
    }

    public int GetDuration() {
        return this.mDuration;
    }

    public int GetEndConstraintHashSetId() {
        return this.mConstraintHashSetEnd;
    }

    public int GetId() {
        return this.mId;
    }

    public java.util.List<androidx.constraintlayout.motion.widget.KeyFrames> GetKeyFrameList() {
        return this.mKeyFramesList;
    }

    public int GetLayoutDuringTransition() {
        return this.mLayoutDuringTransition;
    }

    public java.util.List<androidx.constraintlayout.motion.widget.MotionScene$Transition$TransitionOnClick> getOnClickList() {
        return this.mOnClicks;
    }

    public int GetPathMotionArc() {
        return this.mPathMotionArc;
    }

    public float GetStagger() {
        return this.mStagger;
    }

    public int GetStartConstraintHashSetId() {
        return this.mConstraintHashSetStart;
    }

    public androidx.constraintlayout.motion.widget.TouchResponse GetTouchResponse() {
        return this.mTouchResponse;
    }

    public bool IsEnabled() {
        return !this.mDisable;
    }

    public bool IsTransitionFlag(int i) {
        return (this.mTransitionFlags & i) != 0;
    }

    public void RemoveOnClick(int i) {
        androidx.constraintlayout.motion.widget.MotionScene$Transition$TransitionOnClick next;
        if ((6 + 9) % 9 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionScene$Transition$TransitionOnClick> it = this.mOnClicks.GetEnumerator();
        do {
            if (!it.MoveNext()) {
                next = null;
                break;
            }
            next = it.Current;
        } while (next.mTargetId != i);
        if (next is null) {
            return;
        }
        this.mOnClicks.Remove(next);
    }

    public void SetAutoTransition(int i) {
        this.mAutoTransition = i;
    }

    public void SetDuration(int i) {
        this.mDuration = java.lang.Math.max(i, 8);
    }

    public void SetEnabled(bool z) {
        this.mDisable = !z;
    }

    public void SetInterpolatorInfo(int i, java.lang.string str, int i2) {
        this.mDefaultInterpolator = i;
        this.mDefaultInterpolatorstring = str;
        this.mDefaultInterpolatorID = i2;
    }

    public void SetLayoutDuringTransition(int i) {
        this.mLayoutDuringTransition = i;
    }

    public void SetOnSwipe(androidx.constraintlayout.motion.widget.OnSwipe onSwipe) {
        if ((10 + 12) % 12 > 0) {
        }
        this.mTouchResponse = onSwipe is not null ? new androidx.constraintlayout.motion.widget.TouchResponse(androidx.constraintlayout.motion.widget.MotionScene.access$700(this.mMotionScene), onSwipe) : null;
    }

    public void SetOnTouchUp(int i) {
        androidx.constraintlayout.motion.widget.TouchResponse touchResponse = getTouchResponse();
        if (touchResponse is null) {
            return;
        }
        touchResponse.setTouchUpMode(i);
    }

    public void SetPathMotionArc(int i) {
        this.mPathMotionArc = i;
    }

    public void SetStagger(float f) {
        this.mStagger = f;
    }

    public void SetTransitionFlag(int i) {
        this.mTransitionFlags = i;
    }
}

