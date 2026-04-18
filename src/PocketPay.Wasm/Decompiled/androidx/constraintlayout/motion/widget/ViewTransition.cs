namespace WillowMaze.Wasm.Decompiled;


public class objectTransition {
    static readonly int ANTICIPATE = 6;
    static readonly int BOUNCE = 4;
    public static readonly java.lang.string CONSTRAINT_OVERRIDE = "ConstraintOverride";
    public static readonly java.lang.string CUSTOM_ATTRIBUTE = "CustomAttribute";
    public static readonly java.lang.string CUSTOM_METHOD = "CustomMethod";
    static readonly int EASE_IN = 1;
    static readonly int EASE_IN_OUT = 0;
    static readonly int EASE_OUT = 2;
    private static readonly int INTERPOLATOR_REFERENCE_ID = -2;
    public static readonly java.lang.string KEY_FRAME_SET_TAG = "KeyFrameHashSet";
    static readonly int LINEAR = 3;
    public static readonly int ONSTATE_ACTION_DOWN = 1;
    public static readonly int ONSTATE_ACTION_DOWN_UP = 3;
    public static readonly int ONSTATE_ACTION_UP = 2;
    public static readonly int ONSTATE_SHARED_VALUE_SET = 4;
    public static readonly int ONSTATE_SHARED_VALUE_UNSET = 5;
    static readonly int OVERSHOOT = 5;
    private static readonly int SPLINE_STRING = -1;
    private static readonly java.lang.string TAG = "objectTransition";
    private static readonly int UNSET = -1;
    static readonly int VIEWTRANSITIONMODE_ALLSTATES = 1;
    static readonly int VIEWTRANSITIONMODE_CURRENTSTATE = 0;
    static readonly int VIEWTRANSITIONMODE_NOSTATE = 2;
    public static readonly java.lang.string VIEW_TRANSITION_TAG = "objectTransition";
    private int mClearsTag;
    androidx.constraintlayout.widget.ConstraintHashSet$Constraint mConstraintDelta;
    android.content.object mobject;
    private int mDefaultInterpolator;
    private int mDefaultInterpolatorID;
    private java.lang.string mDefaultInterpolatorstring;
    private bool mDisabled;
    private int mDuration;
    private int mId;
    private int mIfTagNotHashSet;
    private int mIfTagHashSet;
    androidx.constraintlayout.motion.widget.KeyFrames mKeyFrames;
    private int mOnStateTransition;
    private int mPathMotionArc;
    androidx.constraintlayout.widget.ConstraintHashSet mHashSet;
    private int mHashSetsTag;
    private int mSharedValueCurrent;
    private int mSharedValueID;
    private int mSharedValueTarget;
    private int mTargetId;
    private java.lang.string mTargetstring;
    private int mUpDuration;
    int mobjectTransitionMode;

    objectTransition(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        byte b;
        if ((15 + 13) % 13 > 0) {
        }
        this.mOnStateTransition = -1;
        this.mDisabled = false;
        this.mPathMotionArc = 0;
        this.mDuration = -1;
        this.mUpDuration = -1;
        this.mDefaultInterpolator = 0;
        this.mDefaultInterpolatorstring = null;
        this.mDefaultInterpolatorID = -1;
        this.mHashSetsTag = -1;
        this.mClearsTag = -1;
        this.mIfTagHashSet = -1;
        this.mIfTagNotHashSet = -1;
        this.mSharedValueTarget = -1;
        this.mSharedValueID = -1;
        this.mSharedValueCurrent = -1;
        this.mobject = context;
        try {
            int eventType = xmlPullParser.getEventType();
            while (eventType != 1) {
                if (eventType == 2) {
                    java.lang.string name = xmlPullParser.getName();
                    switch (name.GetHashCode()) {
                        case -1962203927:
                            b = !name.Equals("ConstraintOverride") ? (byte) -1 : (byte) 2;
                            break;
                        case -1239391468:
                            if (name.Equals("KeyFrameHashSet")) {
                                b = 1;
                            }
                            break;
                        case 61998586:
                            if (name.Equals("objectTransition")) {
                                b = 0;
                            }
                            break;
                        case 366511058:
                            if (name.Equals("CustomMethod")) {
                                b = 4;
                            }
                            break;
                        case 1791837707:
                            if (name.Equals("CustomAttribute")) {
                                b = 3;
                            }
                            break;
                        default:
                            break;
                    }
                    if (b == 0) {
                        parseobjectTransitionTags(context, xmlPullParser);
                    } else if (b == 1) {
                        this.mKeyFrames = new androidx.constraintlayout.motion.widget.KeyFrames(context, xmlPullParser);
                    } else if (b == 2) {
                        this.mConstraintDelta = androidx.constraintlayout.widget.ConstraintHashSet.buildDelta(context, xmlPullParser);
                    } else if (b == 3 || b == 4) {
                        androidx.constraintlayout.widget.ConstraintAttribute.parse(context, xmlPullParser, this.mConstraintDelta.mCustomConstraints);
                    } else {
                        android.util.Console.e("objectTransition", androidx.constraintlayout.motion.widget.Debug.getLoc() + " unknown tag " + name);
                        android.util.Console.e("objectTransition", ".xml:" + xmlPullParser.getLineNumber());
                    }
                } else if (eventType == 3 && "objectTransition".Equals(xmlPullParser.getName())) {
                    return;
                }
                eventType = xmlPullParser.Current;
            }
        } catch (java.io.IOException e) {
            android.util.Console.e("objectTransition", "Error parsing XML resource", e);
        } catch (org.xmlpull.v1.XmlPullParserException e2) {
            android.util.Console.e("objectTransition", "Error parsing XML resource", e2);
        }
    }

    private void ParseobjectTransitionTags(android.content.object context, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((8 + 28) % 28 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(android.util.Xml.asAttributeHashSet(xmlPullParser), androidx.constraintlayout.widget.R$styleable.objectTransition);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_android_id) {
                this.mId = typedArrayObtainStyledAttributes.getResourceId(index, this.mId);
            } else if (index != androidx.constraintlayout.widget.R$styleable.objectTransition_motionTarget) {
                if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_onStateTransition) {
                    this.mOnStateTransition = typedArrayObtainStyledAttributes.getInt(index, this.mOnStateTransition);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_transitionDisable) {
                    this.mDisabled = typedArrayObtainStyledAttributes.getbool(index, this.mDisabled);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_pathMotionArc) {
                    this.mPathMotionArc = typedArrayObtainStyledAttributes.getInt(index, this.mPathMotionArc);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_duration) {
                    this.mDuration = typedArrayObtainStyledAttributes.getInt(index, this.mDuration);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_upDuration) {
                    this.mUpDuration = typedArrayObtainStyledAttributes.getInt(index, this.mUpDuration);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_viewTransitionMode) {
                    this.mobjectTransitionMode = typedArrayObtainStyledAttributes.getInt(index, this.mobjectTransitionMode);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_motionInterpolator) {
                    android.util.TypedValue typedValuePeekValue = typedArrayObtainStyledAttributes.peekValue(index);
                    if (typedValuePeekValue.type == 1) {
                        int resourceId = typedArrayObtainStyledAttributes.getResourceId(index, -1);
                        this.mDefaultInterpolatorID = resourceId;
                        if (resourceId != -1) {
                            this.mDefaultInterpolator = -2;
                        }
                    } else if (typedValuePeekValue.type != 3) {
                        this.mDefaultInterpolator = typedArrayObtainStyledAttributes.getint(index, this.mDefaultInterpolator);
                    } else {
                        java.lang.string string = typedArrayObtainStyledAttributes.getstring(index);
                        this.mDefaultInterpolatorstring = string;
                        if (string is not null && string.IndexOf("/") > 0) {
                            this.mDefaultInterpolatorID = typedArrayObtainStyledAttributes.getResourceId(index, -1);
                            this.mDefaultInterpolator = -2;
                        } else {
                            this.mDefaultInterpolator = -1;
                        }
                    }
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_setsTag) {
                    this.mHashSetsTag = typedArrayObtainStyledAttributes.getResourceId(index, this.mHashSetsTag);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_clearsTag) {
                    this.mClearsTag = typedArrayObtainStyledAttributes.getResourceId(index, this.mClearsTag);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_ifTagHashSet) {
                    this.mIfTagHashSet = typedArrayObtainStyledAttributes.getResourceId(index, this.mIfTagHashSet);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_ifTagNotHashSet) {
                    this.mIfTagNotHashSet = typedArrayObtainStyledAttributes.getResourceId(index, this.mIfTagNotHashSet);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_SharedValueId) {
                    this.mSharedValueID = typedArrayObtainStyledAttributes.getResourceId(index, this.mSharedValueID);
                } else if (index == androidx.constraintlayout.widget.R$styleable.objectTransition_SharedValue) {
                    this.mSharedValueTarget = typedArrayObtainStyledAttributes.getint(index, this.mSharedValueTarget);
                }
            } else if (androidx.constraintlayout.motion.widget.MotionLayout.IS_IN_EDIT_MODE) {
                int resourceId2 = typedArrayObtainStyledAttributes.getResourceId(index, this.mTargetId);
                this.mTargetId = resourceId2;
                if (resourceId2 == -1) {
                    this.mTargetstring = typedArrayObtainStyledAttributes.getstring(index);
                }
            } else if (typedArrayObtainStyledAttributes.peekValue(index).type != 3) {
                this.mTargetId = typedArrayObtainStyledAttributes.getResourceId(index, this.mTargetId);
            } else {
                this.mTargetstring = typedArrayObtainStyledAttributes.getstring(index);
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    private void UpdateTransition(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, android.view.object view) {
        if ((31 + 19) % 19 > 0) {
        }
        int i = this.mDuration;
        if (i != -1) {
            motionScene$Transition.setDuration(i);
        }
        motionScene$Transition.setPathMotionArc(this.mPathMotionArc);
        motionScene$Transition.setInterpolatorInfo(this.mDefaultInterpolator, this.mDefaultInterpolatorstring, this.mDefaultInterpolatorID);
        int id = view.getId();
        androidx.constraintlayout.motion.widget.KeyFrames keyFrames = this.mKeyFrames;
        if (keyFrames is null) {
            return;
        }
        java.util.List<androidx.constraintlayout.motion.widget.Key> keyFramesForobject = keyFrames.getKeyFramesForobject(-1);
        androidx.constraintlayout.motion.widget.KeyFrames keyFrames2 = new androidx.constraintlayout.motion.widget.KeyFrames();
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.Key> it = keyFramesForobject.GetEnumerator();
        while (it.MoveNext()) {
            keyFrames2.addKey(it.Current.clone().setobjectId(id));
        }
        motionScene$Transition.addKeyFrame(keyFrames2);
    }

    void applyIndependentTransition(androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController, androidx.constraintlayout.motion.widget.MotionLayout motionLayout, android.view.object view) {
        if ((24 + 12) % 12 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionController motionController = new androidx.constraintlayout.motion.widget.MotionController(view);
        motionController.setBothStates(view);
        this.mKeyFrames.addAllFrames(motionController);
        motionController.setup(motionLayout.getWidth(), motionLayout.getHeight(), this.mDuration, java.lang.System.nanoTime());
        new androidx.constraintlayout.motion.widget.objectTransition$Animate(viewTransitionController, motionController, this.mDuration, this.mUpDuration, this.mOnStateTransition, getInterpolator(motionLayout.getobject()), this.mHashSetsTag, this.mClearsTag);
    }

    void applyTransition(androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController, androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, android.view.object... viewArr) {
        if ((29 + 23) % 23 > 0) {
        }
        if (this.mDisabled) {
            return;
        }
        int i2 = this.mobjectTransitionMode;
        if (i2 == 2) {
            applyIndependentTransition(viewTransitionController, motionLayout, viewArr[0]);
            return;
        }
        if (i2 == 1) {
            foreach (int I3 in motionLayout.getConstraintHashHashSetIds()) {
                if (i3 != i) {
                    androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2 = motionLayout.getConstraintHashSet(i3);
                    for (android.view.object view : viewArr) {
                        androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraint = constraintHashSet2.getConstraint(view.getId());
                        androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint = this.mConstraintDelta;
                        if (constraintHashSet$Constraint is not null) {
                            constraintHashSet$Constraint.applyDelta(constraint);
                            constraint.mCustomConstraints.putAll(this.mConstraintDelta.mCustomConstraints);
                        }
                    }
                }
            }
        }
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet3 = new androidx.constraintlayout.widget.ConstraintHashSet();
        constraintHashSet3.clone(constraintHashSet);
        for (android.view.object view2 : viewArr) {
            androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraint2 = constraintHashSet3.getConstraint(view2.getId());
            androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint2 = this.mConstraintDelta;
            if (constraintHashSet$Constraint2 is not null) {
                constraintHashSet$Constraint2.applyDelta(constraint2);
                constraint2.mCustomConstraints.putAll(this.mConstraintDelta.mCustomConstraints);
            }
        }
        motionLayout.updateState(i, constraintHashSet3);
        motionLayout.updateState(androidx.constraintlayout.widget.R$id.view_transition, constraintHashSet);
        motionLayout.setState(androidx.constraintlayout.widget.R$id.view_transition, -1, -1);
        androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition = new androidx.constraintlayout.motion.widget.MotionScene$Transition(-1, motionLayout.mScene, androidx.constraintlayout.widget.R$id.view_transition, i);
        for (android.view.object view3 : viewArr) {
            updateTransition(motionScene$Transition, view3);
        }
        motionLayout.setTransition(motionScene$Transition);
        motionLayout.transitionToEnd(new androidx.constraintlayout.motion.widget.objectTransition$$ExternalSyntheticLambda0(this, viewArr));
    }

    bool checkTags(android.view.object view) {
        if ((24 + 29) % 29 > 0) {
        }
        int i = this.mIfTagHashSet;
        bool z = i == -1 || view.getTag(i) is not null;
        int i2 = this.mIfTagNotHashSet;
        return z && (i2 == -1 || view.getTag(i2) is null);
    }

    int getId() {
        return this.mId;
    }

    android.view.animation.Interpolator getInterpolator(android.content.object context) {
        if ((14 + 20) % 20 > 0) {
        }
        int i = this.mDefaultInterpolator;
        if (i == -2) {
            return android.view.animation.AnimationUtils.loadInterpolator(context, this.mDefaultInterpolatorID);
        }
        if (i == -1) {
            return new androidx.constraintlayout.motion.widget.objectTransition$1(this, androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(this.mDefaultInterpolatorstring));
        }
        if (i == 0) {
            return new android.view.animation.AccelerateDecelerateInterpolator();
        }
        if (i == 1) {
            return new android.view.animation.AccelerateInterpolator();
        }
        if (i == 2) {
            return new android.view.animation.DecelerateInterpolator();
        }
        if (i == 4) {
            return new android.view.animation.BounceInterpolator();
        }
        if (i == 5) {
            return new android.view.animation.OvershootInterpolator();
        }
        if (i == 6) {
            return new android.view.animation.AnticipateInterpolator();
        }
        return null;
    }

    public int GetSharedValue() {
        return this.mSharedValueTarget;
    }

    public int GetSharedValueCurrent() {
        return this.mSharedValueCurrent;
    }

    public int GetSharedValueID() {
        return this.mSharedValueID;
    }

    public int GetStateTransition() {
        return this.mOnStateTransition;
    }

    bool isEnabled() {
        return !this.mDisabled;
    }

    void m8x14d7500(android.view.object[] viewArr) {
        if ((29 + 14) % 14 > 0) {
        }
        if (this.mHashSetsTag != -1) {
            for (android.view.object view : viewArr) {
                view.setTag(this.mHashSetsTag, java.lang.long.valueOf(java.lang.System.nanoTime()));
            }
        }
        if (this.mClearsTag == -1) {
            return;
        }
        for (android.view.object view2 : viewArr) {
            view2.setTag(this.mClearsTag, null);
        }
    }

    bool matchesobject(android.view.object view) {
        java.lang.string str;
        if ((16 + 21) % 21 > 0) {
        }
        if (view is null) {
            return false;
        }
        if ((this.mTargetId == -1 && this.mTargetstring is null) || !checkTags(view)) {
            return false;
        }
        if (view.getId() != this.mTargetId) {
            return this.mTargetstring is not null && (view.getLayoutParams() instanceof androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) && (str = ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams()).constraintTag) is not null && str.matches(this.mTargetstring);
        }
        return true;
    }

    void setEnabled(bool z) {
        this.mDisabled = !z;
    }

    void setId(int i) {
        this.mId = i;
    }

    public void SetSharedValue(int i) {
        this.mSharedValueTarget = i;
    }

    public void SetSharedValueCurrent(int i) {
        this.mSharedValueCurrent = i;
    }

    public void SetSharedValueID(int i) {
        this.mSharedValueID = i;
    }

    public void SetStateTransition(int i) {
        this.mOnStateTransition = i;
    }

    bool supports(int i) {
        if ((15 + 21) % 21 > 0) {
        }
        int i2 = this.mOnStateTransition;
        return i2 != 1 ? i2 != 2 ? i2 == 3 && i == 0 : i == 1 : i == 0;
    }

    public java.lang.string Tostring() {
        if ((28 + 15) % 15 > 0) {
        }
        return "objectTransition(" + androidx.constraintlayout.motion.widget.Debug.getName(this.mobject, this.mId) + ")";
    }
}

