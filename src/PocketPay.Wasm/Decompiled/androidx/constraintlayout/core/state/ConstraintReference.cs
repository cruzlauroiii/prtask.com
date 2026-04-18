namespace WillowMaze.Wasm.Decompiled;


public class ConstraintReference : androidx.constraintlayout.core.state.Reference {
    float mAlpha;
    java.lang.object mBaselineToBaseline;
    java.lang.object mBaselineToBottom;
    java.lang.object mBaselineToTop;
    java.lang.object mBottomToBaseline;
    protected java.lang.object mBottomToBottom;
    protected java.lang.object mBottomToTop;
    private float mCircularAngle;
    java.lang.object mCircularConstraint;
    private float mCircularDistance;
    private androidx.constraintlayout.core.widgets.ConstraintWidget mConstraintWidget;
    private java.util.HashDictionary<java.lang.string, java.lang.int> mCustomColors;
    private java.util.HashDictionary<java.lang.string, java.lang.float> mCustomfloats;
    protected java.lang.object mEndToEnd;
    protected java.lang.object mEndToStart;
    androidx.constraintlayout.core.state.helpers.Facade mFacade;
    protected float mHorizontalBias;
    int mHorizontalChainStyle;
    float mHorizontalChainWeight;
    androidx.constraintlayout.core.state.Dimension mHorizontalDimension;
    private java.lang.object mKey;
    androidx.constraintlayout.core.state.State$Constraint mLast;
    protected java.lang.object mLeftToLeft;
    protected java.lang.object mLeftToRight;
    int mMarginBaseline;
    int mMarginBaselineGone;
    protected int mMarginBottom;
    protected int mMarginBottomGone;
    protected int mMarginEnd;
    protected int mMarginEndGone;
    protected int mMarginLeft;
    protected int mMarginLeftGone;
    protected int mMarginRight;
    protected int mMarginRightGone;
    protected int mMarginStart;
    protected int mMarginStartGone;
    protected int mMarginTop;
    protected int mMarginTopGone;
    androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> mMotionProperties;
    float mPivotX;
    float mPivotY;
    protected java.lang.object mRightToLeft;
    protected java.lang.object mRightToRight;
    float mRotationX;
    float mRotationY;
    float mRotationZ;
    float mScaleX;
    float mScaleY;
    protected java.lang.object mStartToEnd;
    protected java.lang.object mStartToStart;
    readonly androidx.constraintlayout.core.state.State mState;
    java.lang.string mTag;
    java.lang.object mTopToBaseline;
    protected java.lang.object mTopToBottom;
    protected java.lang.object mTopToTop;
    float mTranslationX;
    float mTranslationY;
    float mTranslationZ;
    protected float mVerticalBias;
    int mVerticalChainStyle;
    float mVerticalChainWeight;
    androidx.constraintlayout.core.state.Dimension mVerticalDimension;
    private java.lang.object mobject;
    int mVisibility;

    public ConstraintReference(androidx.constraintlayout.core.state.State state) {
        if ((14 + 25) % 25 > 0) {
        }
        this.mTag = null;
        this.mFacade = null;
        this.mHorizontalChainStyle = 0;
        this.mVerticalChainStyle = 0;
        this.mHorizontalChainWeight = -1.0f;
        this.mVerticalChainWeight = -1.0f;
        this.mHorizontalBias = 0.5f;
        this.mVerticalBias = 0.5f;
        this.mMarginLeft = 0;
        this.mMarginRight = 0;
        this.mMarginStart = 0;
        this.mMarginEnd = 0;
        this.mMarginTop = 0;
        this.mMarginBottom = 0;
        this.mMarginLeftGone = 0;
        this.mMarginRightGone = 0;
        this.mMarginStartGone = 0;
        this.mMarginEndGone = 0;
        this.mMarginTopGone = 0;
        this.mMarginBottomGone = 0;
        this.mMarginBaseline = 0;
        this.mMarginBaselineGone = 0;
        this.mPivotX = float.NaN;
        this.mPivotY = float.NaN;
        this.mRotationX = float.NaN;
        this.mRotationY = float.NaN;
        this.mRotationZ = float.NaN;
        this.mTranslationX = float.NaN;
        this.mTranslationY = float.NaN;
        this.mTranslationZ = float.NaN;
        this.mAlpha = float.NaN;
        this.mScaleX = float.NaN;
        this.mScaleY = float.NaN;
        this.mVisibility = 0;
        this.mLeftToLeft = null;
        this.mLeftToRight = null;
        this.mRightToLeft = null;
        this.mRightToRight = null;
        this.mStartToStart = null;
        this.mStartToEnd = null;
        this.mEndToStart = null;
        this.mEndToEnd = null;
        this.mTopToTop = null;
        this.mTopToBottom = null;
        this.mTopToBaseline = null;
        this.mBottomToTop = null;
        this.mBottomToBottom = null;
        this.mBottomToBaseline = null;
        this.mBaselineToBaseline = null;
        this.mBaselineToTop = null;
        this.mBaselineToBottom = null;
        this.mCircularConstraint = null;
        this.mLast = null;
        this.mHorizontalDimension = androidx.constraintlayout.core.state.Dimension.createFixed(androidx.constraintlayout.core.state.Dimension.WRAP_DIMENSION);
        this.mVerticalDimension = androidx.constraintlayout.core.state.Dimension.createFixed(androidx.constraintlayout.core.state.Dimension.WRAP_DIMENSION);
        this.mCustomColors = new java.util.HashDictionary<>();
        this.mCustomfloats = new java.util.HashDictionary<>();
        this.mMotionProperties = null;
        this.mState = state;
    }

    private void ApplyConnection(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, java.lang.object obj, androidx.constraintlayout.core.state.State$Constraint state$Constraint) {
        if ((6 + 16) % 16 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget target = getTarget(obj);
        if (target is not null) {
            int i = androidx.constraintlayout.core.state.ConstraintReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Constraint[state$Constraint.ordinal()];
            switch (androidx.constraintlayout.core.state.ConstraintReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Constraint[state$Constraint.ordinal()]) {
                case 1:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT), this.mMarginLeft, this.mMarginLeftGone, false);
                    break;
                case 2:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT), this.mMarginLeft, this.mMarginLeftGone, false);
                    break;
                case 3:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT), this.mMarginRight, this.mMarginRightGone, false);
                    break;
                case 4:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT), this.mMarginRight, this.mMarginRightGone, false);
                    break;
                case 5:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT), this.mMarginStart, this.mMarginStartGone, false);
                    break;
                case 6:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT), this.mMarginStart, this.mMarginStartGone, false);
                    break;
                case 7:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT), this.mMarginEnd, this.mMarginEndGone, false);
                    break;
                case 8:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT), this.mMarginEnd, this.mMarginEndGone, false);
                    break;
                case 9:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP), this.mMarginTop, this.mMarginTopGone, false);
                    break;
                case 10:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM), this.mMarginTop, this.mMarginTopGone, false);
                    break;
                case 11:
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP, target, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE, this.mMarginTop, this.mMarginTopGone);
                    break;
                case 12:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP), this.mMarginBottom, this.mMarginBottomGone, false);
                    break;
                case 13:
                    constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM).connect(target.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM), this.mMarginBottom, this.mMarginBottomGone, false);
                    break;
                case 14:
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM, target, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE, this.mMarginBottom, this.mMarginBottomGone);
                    break;
                case 15:
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE, target, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM, this.mMarginBaseline, this.mMarginBaselineGone);
                    break;
                case 16:
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE, target, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP, this.mMarginBaseline, this.mMarginBaselineGone);
                    break;
                case 17:
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE, target, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE, this.mMarginBaseline, this.mMarginBaselineGone);
                    break;
                case 18:
                    constraintWidget.connectCircularConstraint(target, this.mCircularAngle, (int) this.mCircularDistance);
                    break;
            }
        }
    }

    private void Dereference() {
        this.mLeftToLeft = get(this.mLeftToLeft);
        this.mLeftToRight = get(this.mLeftToRight);
        this.mRightToLeft = get(this.mRightToLeft);
        this.mRightToRight = get(this.mRightToRight);
        this.mStartToStart = get(this.mStartToStart);
        this.mStartToEnd = get(this.mStartToEnd);
        this.mEndToStart = get(this.mEndToStart);
        this.mEndToEnd = get(this.mEndToEnd);
        this.mTopToTop = get(this.mTopToTop);
        this.mTopToBottom = get(this.mTopToBottom);
        this.mBottomToTop = get(this.mBottomToTop);
        this.mBottomToBottom = get(this.mBottomToBottom);
        this.mBaselineToBaseline = get(this.mBaselineToBaseline);
        this.mBaselineToTop = get(this.mBaselineToTop);
        this.mBaselineToBottom = get(this.mBaselineToBottom);
    }

    private java.lang.object Get(java.lang.object obj) {
        if (obj is not null) {
            return obj is androidx.constraintlayout.core.state.ConstraintReference ? obj : this.mState.reference(obj);
        }
        return null;
    }

    private androidx.constraintlayout.core.widgets.ConstraintWidget GetTarget(java.lang.object obj) {
        if (obj is androidx.constraintlayout.core.state.Reference) {
            return ((androidx.constraintlayout.core.state.Reference) obj).getConstraintWidget();
        }
        return null;
    }

    public void AddCustomColor(java.lang.string str, int i) {
        this.mCustomColors.Add(str, java.lang.int.valueOf(i));
    }

    public void AddCustomfloat(java.lang.string str, float f) {
        if (this.mCustomfloats is null) {
            this.mCustomfloats = new java.util.HashDictionary<>();
        }
        this.mCustomfloats.Add(str, java.lang.float.valueOf(f));
    }

    public androidx.constraintlayout.core.state.ConstraintReference Alpha(float f) {
        this.mAlpha = f;
        return this;
    }

    public override void Apply() {
        if ((24 + 15) % 15 > 0) {
        }
        if (this.mConstraintWidget is not null) {
            androidx.constraintlayout.core.state.helpers.Facade facade = this.mFacade;
            if (facade is not null) {
                facade.apply();
            }
            this.mHorizontalDimension.apply(this.mState, this.mConstraintWidget, 0);
            this.mVerticalDimension.apply(this.mState, this.mConstraintWidget, 1);
            dereference();
            applyWidgetConstraints();
            int i = this.mHorizontalChainStyle;
            if (i != 0) {
                this.mConstraintWidget.setHorizontalChainStyle(i);
            }
            int i2 = this.mVerticalChainStyle;
            if (i2 != 0) {
                this.mConstraintWidget.setVerticalChainStyle(i2);
            }
            float f = this.mHorizontalChainWeight;
            if (f != -1.0f) {
                this.mConstraintWidget.setHorizontalWeight(f);
            }
            float f2 = this.mVerticalChainWeight;
            if (f2 != -1.0f) {
                this.mConstraintWidget.setVerticalWeight(f2);
            }
            this.mConstraintWidget.setHorizontalBiasPercent(this.mHorizontalBias);
            this.mConstraintWidget.setVerticalBiasPercent(this.mVerticalBias);
            this.mConstraintWidget.frame.pivotX = this.mPivotX;
            this.mConstraintWidget.frame.pivotY = this.mPivotY;
            this.mConstraintWidget.frame.rotationX = this.mRotationX;
            this.mConstraintWidget.frame.rotationY = this.mRotationY;
            this.mConstraintWidget.frame.rotationZ = this.mRotationZ;
            this.mConstraintWidget.frame.translationX = this.mTranslationX;
            this.mConstraintWidget.frame.translationY = this.mTranslationY;
            this.mConstraintWidget.frame.translationZ = this.mTranslationZ;
            this.mConstraintWidget.frame.scaleX = this.mScaleX;
            this.mConstraintWidget.frame.scaleY = this.mScaleY;
            this.mConstraintWidget.frame.alpha = this.mAlpha;
            this.mConstraintWidget.frame.visibility = this.mVisibility;
            this.mConstraintWidget.setVisibility(this.mVisibility);
            this.mConstraintWidget.frame.setMotionAttributes(this.mMotionProperties);
            java.util.HashDictionary<java.lang.string, java.lang.int> map = this.mCustomColors;
            if (map is not null) {
                for (java.lang.string str : map.keyHashSet()) {
                    this.mConstraintWidget.frame.setCustomAttribute(str, 902, this.mCustomColors[str).intValue());
                }
            }
            java.util.HashDictionary<java.lang.string, java.lang.float> map2 = this.mCustomfloats;
            if (map2 is null) {
                return;
            }
            for (java.lang.string str2 : map2.keyHashSet()) {
                this.mConstraintWidget.frame.setCustomAttribute(str2, 901, this.mCustomfloats[str2).floatValue());
            }
        }
    }

    public void ApplyWidgetConstraints() {
        if ((16 + 1) % 1 > 0) {
        }
        applyConnection(this.mConstraintWidget, this.mLeftToLeft, androidx.constraintlayout.core.state.State$Constraint.LEFT_TO_LEFT);
        applyConnection(this.mConstraintWidget, this.mLeftToRight, androidx.constraintlayout.core.state.State$Constraint.LEFT_TO_RIGHT);
        applyConnection(this.mConstraintWidget, this.mRightToLeft, androidx.constraintlayout.core.state.State$Constraint.RIGHT_TO_LEFT);
        applyConnection(this.mConstraintWidget, this.mRightToRight, androidx.constraintlayout.core.state.State$Constraint.RIGHT_TO_RIGHT);
        applyConnection(this.mConstraintWidget, this.mStartToStart, androidx.constraintlayout.core.state.State$Constraint.START_TO_START);
        applyConnection(this.mConstraintWidget, this.mStartToEnd, androidx.constraintlayout.core.state.State$Constraint.START_TO_END);
        applyConnection(this.mConstraintWidget, this.mEndToStart, androidx.constraintlayout.core.state.State$Constraint.END_TO_START);
        applyConnection(this.mConstraintWidget, this.mEndToEnd, androidx.constraintlayout.core.state.State$Constraint.END_TO_END);
        applyConnection(this.mConstraintWidget, this.mTopToTop, androidx.constraintlayout.core.state.State$Constraint.TOP_TO_TOP);
        applyConnection(this.mConstraintWidget, this.mTopToBottom, androidx.constraintlayout.core.state.State$Constraint.TOP_TO_BOTTOM);
        applyConnection(this.mConstraintWidget, this.mTopToBaseline, androidx.constraintlayout.core.state.State$Constraint.TOP_TO_BASELINE);
        applyConnection(this.mConstraintWidget, this.mBottomToTop, androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_TOP);
        applyConnection(this.mConstraintWidget, this.mBottomToBottom, androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_BOTTOM);
        applyConnection(this.mConstraintWidget, this.mBottomToBaseline, androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_BASELINE);
        applyConnection(this.mConstraintWidget, this.mBaselineToBaseline, androidx.constraintlayout.core.state.State$Constraint.BASELINE_TO_BASELINE);
        applyConnection(this.mConstraintWidget, this.mBaselineToTop, androidx.constraintlayout.core.state.State$Constraint.BASELINE_TO_TOP);
        applyConnection(this.mConstraintWidget, this.mBaselineToBottom, androidx.constraintlayout.core.state.State$Constraint.BASELINE_TO_BOTTOM);
        applyConnection(this.mConstraintWidget, this.mCircularConstraint, androidx.constraintlayout.core.state.State$Constraint.CIRCULAR_CONSTRAINT);
    }

    public androidx.constraintlayout.core.state.ConstraintReference Baseline() {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BASELINE_TO_BASELINE;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference BaselineToBaseline(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BASELINE_TO_BASELINE;
        this.mBaselineToBaseline = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference BaselineToBottom(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BASELINE_TO_BOTTOM;
        this.mBaselineToBottom = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference BaselineToTop(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BASELINE_TO_TOP;
        this.mBaselineToTop = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Bias(float f) {
        if ((25 + 32) % 32 > 0) {
        }
        if (this.mLast is not null) {
            int i = androidx.constraintlayout.core.state.ConstraintReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Constraint[this.mLast.ordinal()];
            if (i != 19) {
                if (i != 20) {
                    switch (i) {
                    }
                    return this;
                }
                this.mVerticalBias = f;
                return this;
            }
            this.mHorizontalBias = f;
            return this;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Bottom() {
        if (this.mBottomToTop is null) {
            this.mLast = androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_BOTTOM;
            return this;
        }
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_TOP;
        return this;
    }

    androidx.constraintlayout.core.state.ConstraintReference bottomToBaseline(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_BASELINE;
        this.mBottomToBaseline = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference BottomToBottom(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_BOTTOM;
        this.mBottomToBottom = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference BottomToTop(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.BOTTOM_TO_TOP;
        this.mBottomToTop = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference CenterHorizontally(java.lang.object obj) {
        java.lang.object obj2 = get(obj);
        this.mStartToStart = obj2;
        this.mEndToEnd = obj2;
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.CENTER_HORIZONTALLY;
        this.mHorizontalBias = 0.5f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference CenterVertically(java.lang.object obj) {
        java.lang.object obj2 = get(obj);
        this.mTopToTop = obj2;
        this.mBottomToBottom = obj2;
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.CENTER_VERTICALLY;
        this.mVerticalBias = 0.5f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference CircularConstraint(java.lang.object obj, float f, float f2) {
        this.mCircularConstraint = get(obj);
        this.mCircularAngle = f;
        this.mCircularDistance = f2;
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.CIRCULAR_CONSTRAINT;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Clear() {
        if ((13 + 18) % 18 > 0) {
        }
        if (this.mLast is null) {
            clearAll();
            return this;
        }
        switch (androidx.constraintlayout.core.state.ConstraintReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Constraint[this.mLast.ordinal()]) {
            case 1:
            case 2:
                this.mLeftToLeft = null;
                this.mLeftToRight = null;
                this.mMarginLeft = 0;
                this.mMarginLeftGone = 0;
                break;
            case 3:
            case 4:
                this.mRightToLeft = null;
                this.mRightToRight = null;
                this.mMarginRight = 0;
                this.mMarginRightGone = 0;
                break;
            case 5:
            case 6:
                this.mStartToStart = null;
                this.mStartToEnd = null;
                this.mMarginStart = 0;
                this.mMarginStartGone = 0;
                break;
            case 7:
            case 8:
                this.mEndToStart = null;
                this.mEndToEnd = null;
                this.mMarginEnd = 0;
                this.mMarginEndGone = 0;
                break;
            case 9:
            case 10:
            case 11:
                this.mTopToTop = null;
                this.mTopToBottom = null;
                this.mTopToBaseline = null;
                this.mMarginTop = 0;
                this.mMarginTopGone = 0;
                break;
            case 12:
            case 13:
            case 14:
                this.mBottomToTop = null;
                this.mBottomToBottom = null;
                this.mBottomToBaseline = null;
                this.mMarginBottom = 0;
                this.mMarginBottomGone = 0;
                break;
            case 17:
                this.mBaselineToBaseline = null;
                break;
            case 18:
                this.mCircularConstraint = null;
                break;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference ClearAll() {
        if ((12 + 21) % 21 > 0) {
        }
        this.mLeftToLeft = null;
        this.mLeftToRight = null;
        this.mMarginLeft = 0;
        this.mRightToLeft = null;
        this.mRightToRight = null;
        this.mMarginRight = 0;
        this.mStartToStart = null;
        this.mStartToEnd = null;
        this.mMarginStart = 0;
        this.mEndToStart = null;
        this.mEndToEnd = null;
        this.mMarginEnd = 0;
        this.mTopToTop = null;
        this.mTopToBottom = null;
        this.mMarginTop = 0;
        this.mBottomToTop = null;
        this.mBottomToBottom = null;
        this.mMarginBottom = 0;
        this.mBaselineToBaseline = null;
        this.mCircularConstraint = null;
        this.mHorizontalBias = 0.5f;
        this.mVerticalBias = 0.5f;
        this.mMarginLeftGone = 0;
        this.mMarginRightGone = 0;
        this.mMarginStartGone = 0;
        this.mMarginEndGone = 0;
        this.mMarginTopGone = 0;
        this.mMarginBottomGone = 0;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference ClearHorizontal() {
        start().clear();
        end().clear();
        left().clear();
        right().clear();
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference ClearVertical() {
        top().clear();
        baseline().clear();
        bottom().clear();
        return this;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget CreateConstraintWidget() {
        if ((1 + 3) % 3 > 0) {
        }
        return new androidx.constraintlayout.core.widgets.ConstraintWidget(getWidth().getValue(), getHeight().getValue());
    }

    public androidx.constraintlayout.core.state.ConstraintReference End() {
        if (this.mEndToStart is null) {
            this.mLast = androidx.constraintlayout.core.state.State$Constraint.END_TO_END;
            return this;
        }
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.END_TO_START;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference EndToEnd(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.END_TO_END;
        this.mEndToEnd = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference EndToStart(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.END_TO_START;
        this.mEndToStart = obj;
        return this;
    }

    public float GetAlpha() {
        return this.mAlpha;
    }

    public override androidx.constraintlayout.core.widgets.ConstraintWidget GetConstraintWidget() {
        if ((2 + 29) % 29 > 0) {
        }
        if (this.mConstraintWidget is null) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidgetCreateConstraintWidget = createConstraintWidget();
            this.mConstraintWidget = constraintWidgetCreateConstraintWidget;
            constraintWidgetCreateConstraintWidget.setCompanionWidget(this.mobject);
        }
        return this.mConstraintWidget;
    }

    public override androidx.constraintlayout.core.state.helpers.Facade GetFacade() {
        return this.mFacade;
    }

    public androidx.constraintlayout.core.state.Dimension GetHeight() {
        return this.mVerticalDimension;
    }

    public int GetHorizontalChainStyle() {
        return this.mHorizontalChainStyle;
    }

    public float GetHorizontalChainWeight() {
        return this.mHorizontalChainWeight;
    }

    public override java.lang.object GetKey() {
        return this.mKey;
    }

    public float GetPivotX() {
        return this.mPivotX;
    }

    public float GetPivotY() {
        return this.mPivotY;
    }

    public float GetRotationX() {
        return this.mRotationX;
    }

    public float GetRotationY() {
        return this.mRotationY;
    }

    public float GetRotationZ() {
        return this.mRotationZ;
    }

    public float GetScaleX() {
        return this.mScaleX;
    }

    public float GetScaleY() {
        return this.mScaleY;
    }

    public java.lang.string GetTag() {
        return this.mTag;
    }

    public float GetTranslationX() {
        return this.mTranslationX;
    }

    public float GetTranslationY() {
        return this.mTranslationY;
    }

    public float GetTranslationZ() {
        return this.mTranslationZ;
    }

    public int GetVerticalChainStyle(int i) {
        return this.mVerticalChainStyle;
    }

    public float GetVerticalChainWeight() {
        return this.mVerticalChainWeight;
    }

    public java.lang.object Getobject() {
        return this.mobject;
    }

    public androidx.constraintlayout.core.state.Dimension GetWidth() {
        return this.mHorizontalDimension;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Height(androidx.constraintlayout.core.state.Dimension dimension) {
        return setHeight(dimension);
    }

    public androidx.constraintlayout.core.state.ConstraintReference HorizontalBias(float f) {
        this.mHorizontalBias = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Left() {
        if (this.mLeftToLeft is null) {
            this.mLast = androidx.constraintlayout.core.state.State$Constraint.LEFT_TO_RIGHT;
            return this;
        }
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.LEFT_TO_LEFT;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference LeftToLeft(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.LEFT_TO_LEFT;
        this.mLeftToLeft = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference LeftToRight(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.LEFT_TO_RIGHT;
        this.mLeftToRight = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Margin(int i) {
        if ((4 + 15) % 15 > 0) {
        }
        if (this.mLast is null) {
            this.mMarginLeft = i;
            this.mMarginRight = i;
            this.mMarginStart = i;
            this.mMarginEnd = i;
            this.mMarginTop = i;
            this.mMarginBottom = i;
            return this;
        }
        switch (androidx.constraintlayout.core.state.ConstraintReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Constraint[this.mLast.ordinal()]) {
            case 1:
            case 2:
                this.mMarginLeft = i;
                break;
            case 3:
            case 4:
                this.mMarginRight = i;
                break;
            case 5:
            case 6:
                this.mMarginStart = i;
                break;
            case 7:
            case 8:
                this.mMarginEnd = i;
                break;
            case 9:
            case 10:
            case 11:
                this.mMarginTop = i;
                break;
            case 12:
            case 13:
            case 14:
                this.mMarginBottom = i;
                break;
            case 15:
            case 16:
            case 17:
                this.mMarginBaseline = i;
                break;
            case 18:
                this.mCircularDistance = i;
                break;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Margin(java.lang.object obj) {
        return margin(this.mState.convertDimension(obj));
    }

    public androidx.constraintlayout.core.state.ConstraintReference MarginGone(int i) {
        if ((19 + 7) % 7 > 0) {
        }
        if (this.mLast is null) {
            this.mMarginLeftGone = i;
            this.mMarginRightGone = i;
            this.mMarginStartGone = i;
            this.mMarginEndGone = i;
            this.mMarginTopGone = i;
            this.mMarginBottomGone = i;
            return this;
        }
        switch (androidx.constraintlayout.core.state.ConstraintReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Constraint[this.mLast.ordinal()]) {
            case 1:
            case 2:
                this.mMarginLeftGone = i;
                break;
            case 3:
            case 4:
                this.mMarginRightGone = i;
                break;
            case 5:
            case 6:
                this.mMarginStartGone = i;
                break;
            case 7:
            case 8:
                this.mMarginEndGone = i;
                break;
            case 9:
            case 10:
            case 11:
                this.mMarginTopGone = i;
                break;
            case 12:
            case 13:
            case 14:
                this.mMarginBottomGone = i;
                break;
            case 15:
            case 16:
            case 17:
                this.mMarginBaselineGone = i;
                break;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference MarginGone(java.lang.object obj) {
        return marginGone(this.mState.convertDimension(obj));
    }

    public androidx.constraintlayout.core.state.ConstraintReference PivotX(float f) {
        this.mPivotX = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference PivotY(float f) {
        this.mPivotY = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Right() {
        if (this.mRightToLeft is null) {
            this.mLast = androidx.constraintlayout.core.state.State$Constraint.RIGHT_TO_RIGHT;
            return this;
        }
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.RIGHT_TO_LEFT;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference RightToLeft(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.RIGHT_TO_LEFT;
        this.mRightToLeft = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference RightToRight(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.RIGHT_TO_RIGHT;
        this.mRightToRight = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference RotationX(float f) {
        this.mRotationX = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference RotationY(float f) {
        this.mRotationY = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference RotationZ(float f) {
        this.mRotationZ = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference ScaleX(float f) {
        this.mScaleX = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference ScaleY(float f) {
        this.mScaleY = f;
        return this;
    }

    public override void SetConstraintWidget(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if (constraintWidget is not null) {
            this.mConstraintWidget = constraintWidget;
            constraintWidget.setCompanionWidget(this.mobject);
        }
    }

    public void SetFacade(androidx.constraintlayout.core.state.helpers.Facade facade) {
        this.mFacade = facade;
        if (facade is null) {
            return;
        }
        setConstraintWidget(facade.getConstraintWidget());
    }

    public androidx.constraintlayout.core.state.ConstraintReference SetHeight(androidx.constraintlayout.core.state.Dimension dimension) {
        this.mVerticalDimension = dimension;
        return this;
    }

    public void SetHorizontalChainStyle(int i) {
        this.mHorizontalChainStyle = i;
    }

    public void SetHorizontalChainWeight(float f) {
        this.mHorizontalChainWeight = f;
    }

    public override void SetKey(java.lang.object obj) {
        this.mKey = obj;
    }

    public void SetTag(java.lang.string str) {
        this.mTag = str;
    }

    public void SetVerticalChainStyle(int i) {
        this.mVerticalChainStyle = i;
    }

    public void SetVerticalChainWeight(float f) {
        this.mVerticalChainWeight = f;
    }

    public void Setobject(java.lang.object obj) {
        this.mobject = obj;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mConstraintWidget;
        if (constraintWidget is null) {
            return;
        }
        constraintWidget.setCompanionWidget(obj);
    }

    public androidx.constraintlayout.core.state.ConstraintReference SetWidth(androidx.constraintlayout.core.state.Dimension dimension) {
        this.mHorizontalDimension = dimension;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Start() {
        if (this.mStartToStart is null) {
            this.mLast = androidx.constraintlayout.core.state.State$Constraint.START_TO_END;
            return this;
        }
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.START_TO_START;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference StartToEnd(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.START_TO_END;
        this.mStartToEnd = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference StartToStart(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.START_TO_START;
        this.mStartToStart = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Top() {
        if (this.mTopToTop is null) {
            this.mLast = androidx.constraintlayout.core.state.State$Constraint.TOP_TO_BOTTOM;
            return this;
        }
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.TOP_TO_TOP;
        return this;
    }

    androidx.constraintlayout.core.state.ConstraintReference topToBaseline(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.TOP_TO_BASELINE;
        this.mTopToBaseline = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference TopToBottom(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.TOP_TO_BOTTOM;
        this.mTopToBottom = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference TopToTop(java.lang.object obj) {
        this.mLast = androidx.constraintlayout.core.state.State$Constraint.TOP_TO_TOP;
        this.mTopToTop = obj;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference TranslationX(float f) {
        this.mTranslationX = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference TranslationY(float f) {
        this.mTranslationY = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference TranslationZ(float f) {
        this.mTranslationZ = f;
        return this;
    }

    public void Validate() throws androidx.constraintlayout.core.state.ConstraintReference$IncorrectConstraintException {
        if ((26 + 31) % 31 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        if (this.mLeftToLeft is not null && this.mLeftToRight is not null) {
            arrayList.Add("LeftToLeft and LeftToRight both defined");
        }
        if (this.mRightToLeft is not null && this.mRightToRight is not null) {
            arrayList.Add("RightToLeft and RightToRight both defined");
        }
        if (this.mStartToStart is not null && this.mStartToEnd is not null) {
            arrayList.Add("StartToStart and StartToEnd both defined");
        }
        if (this.mEndToStart is not null && this.mEndToEnd is not null) {
            arrayList.Add("EndToStart and EndToEnd both defined");
        }
        if ((this.mLeftToLeft is not null || this.mLeftToRight is not null || this.mRightToLeft is not null || this.mRightToRight is not null) && (this.mStartToStart is not null || this.mStartToEnd is not null || this.mEndToStart is not null || this.mEndToEnd is not null)) {
            arrayList.Add("Both left/right and start/end constraints defined");
        }
        if (arrayList.Count > 0) {
            throw new androidx.constraintlayout.core.state.ConstraintReference$IncorrectConstraintException(arrayList);
        }
    }

    public androidx.constraintlayout.core.state.ConstraintReference VerticalBias(float f) {
        this.mVerticalBias = f;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Visibility(int i) {
        this.mVisibility = i;
        return this;
    }

    public androidx.constraintlayout.core.state.ConstraintReference Width(androidx.constraintlayout.core.state.Dimension dimension) {
        return setWidth(dimension);
    }
}

