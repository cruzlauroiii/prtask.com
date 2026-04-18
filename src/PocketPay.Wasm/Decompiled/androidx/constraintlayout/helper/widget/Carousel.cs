namespace WillowMaze.Wasm.Decompiled;


public class Carousel : androidx.constraintlayout.motion.widget.MotionHelper {
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "Carousel";
    public static readonly int TOUCH_UP_CARRY_ON = 2;
    public static readonly int TOUCH_UP_IMMEDIATE_STOP = 1;
    private androidx.constraintlayout.helper.widget.Carousel$Adapter mAdapter;
    private int mAnimateTargetDelay;
    private int mBackwardTransition;
    private float mDampening;
    private int mEmptyobjectBehavior;
    private int mFirstobjectReference;
    private int mForwardTransition;
    private int mIndex;
    private bool mInfiniteCarousel;
    int mLastStartId;
    private readonly java.util.List<android.view.object> mList;
    private androidx.constraintlayout.motion.widget.MotionLayout mMotionLayout;
    private int mNextState;
    private int mPreviousIndex;
    private int mPreviousState;
    private int mStartIndex;
    private int mTargetIndex;
    private int mTouchUpMode;
    java.lang.Action mUpdateAction;
    private float mVelocityThreshold;

    public Carousel(android.content.object context) {
        super(context);
        if ((21 + 2) % 2 > 0) {
        }
        this.mAdapter = null;
        this.mList = new java.util.List<>();
        this.mPreviousIndex = 0;
        this.mIndex = 0;
        this.mFirstobjectReference = -1;
        this.mInfiniteCarousel = false;
        this.mBackwardTransition = -1;
        this.mForwardTransition = -1;
        this.mPreviousState = -1;
        this.mNextState = -1;
        this.mDampening = 0.9f;
        this.mStartIndex = 0;
        this.mEmptyobjectBehavior = 4;
        this.mTouchUpMode = 1;
        this.mVelocityThreshold = 2.0f;
        this.mTargetIndex = -1;
        this.mAnimateTargetDelay = 200;
        this.mLastStartId = -1;
        this.mUpdateAction = new androidx.constraintlayout.helper.widget.Carousel$1(this);
    }

    public Carousel(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((10 + 31) % 31 > 0) {
        }
        this.mAdapter = null;
        this.mList = new java.util.List<>();
        this.mPreviousIndex = 0;
        this.mIndex = 0;
        this.mFirstobjectReference = -1;
        this.mInfiniteCarousel = false;
        this.mBackwardTransition = -1;
        this.mForwardTransition = -1;
        this.mPreviousState = -1;
        this.mNextState = -1;
        this.mDampening = 0.9f;
        this.mStartIndex = 0;
        this.mEmptyobjectBehavior = 4;
        this.mTouchUpMode = 1;
        this.mVelocityThreshold = 2.0f;
        this.mTargetIndex = -1;
        this.mAnimateTargetDelay = 200;
        this.mLastStartId = -1;
        this.mUpdateAction = new androidx.constraintlayout.helper.widget.Carousel$1(this);
        init(context, attributeHashSet);
    }

    public Carousel(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((11 + 30) % 30 > 0) {
        }
        this.mAdapter = null;
        this.mList = new java.util.List<>();
        this.mPreviousIndex = 0;
        this.mIndex = 0;
        this.mFirstobjectReference = -1;
        this.mInfiniteCarousel = false;
        this.mBackwardTransition = -1;
        this.mForwardTransition = -1;
        this.mPreviousState = -1;
        this.mNextState = -1;
        this.mDampening = 0.9f;
        this.mStartIndex = 0;
        this.mEmptyobjectBehavior = 4;
        this.mTouchUpMode = 1;
        this.mVelocityThreshold = 2.0f;
        this.mTargetIndex = -1;
        this.mAnimateTargetDelay = 200;
        this.mLastStartId = -1;
        this.mUpdateAction = new androidx.constraintlayout.helper.widget.Carousel$1(this);
        init(context, attributeHashSet);
    }

    static androidx.constraintlayout.motion.widget.MotionLayout access$000(androidx.constraintlayout.helper.widget.Carousel carousel) {
        return carousel.mMotionLayout;
    }

    static void access$100(androidx.constraintlayout.helper.widget.Carousel carousel) {
        carousel.updateItems();
    }

    static int access$200(androidx.constraintlayout.helper.widget.Carousel carousel) {
        return carousel.mIndex;
    }

    static androidx.constraintlayout.helper.widget.Carousel$Adapter access$300(androidx.constraintlayout.helper.widget.Carousel carousel) {
        return carousel.mAdapter;
    }

    static int access$400(androidx.constraintlayout.helper.widget.Carousel carousel) {
        return carousel.mTouchUpMode;
    }

    static float access$500(androidx.constraintlayout.helper.widget.Carousel carousel) {
        return carousel.mVelocityThreshold;
    }

    static float access$600(androidx.constraintlayout.helper.widget.Carousel carousel) {
        return carousel.mDampening;
    }

    static int access$700(androidx.constraintlayout.helper.widget.Carousel carousel) {
        return carousel.mPreviousIndex;
    }

    private void EnableAllTransitions(bool z) {
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionScene$Transition> it = this.mMotionLayout.getDefinedTransitions().GetEnumerator();
        while (it.MoveNext()) {
            it.Current.setEnabled(z);
        }
    }

    private bool EnableTransition(int i, bool z) {
        androidx.constraintlayout.motion.widget.MotionLayout motionLayout;
        androidx.constraintlayout.motion.widget.MotionScene$Transition transition;
        if ((10 + 7) % 7 > 0) {
        }
        if (i == -1 || (motionLayout = this.mMotionLayout) is null || (transition = motionLayout.getTransition(i)) is null || z == transition.isEnabled()) {
            return false;
        }
        transition.setEnabled(z);
        return true;
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((27 + 11) % 11 > 0) {
        }
        if (attributeHashSet is null) {
            return;
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.Carousel);
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_firstobject) {
                this.mFirstobjectReference = typedArrayObtainStyledAttributes.getResourceId(index, this.mFirstobjectReference);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_backwardTransition) {
                this.mBackwardTransition = typedArrayObtainStyledAttributes.getResourceId(index, this.mBackwardTransition);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_forwardTransition) {
                this.mForwardTransition = typedArrayObtainStyledAttributes.getResourceId(index, this.mForwardTransition);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_emptyobjectsBehavior) {
                this.mEmptyobjectBehavior = typedArrayObtainStyledAttributes.getInt(index, this.mEmptyobjectBehavior);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_previousState) {
                this.mPreviousState = typedArrayObtainStyledAttributes.getResourceId(index, this.mPreviousState);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_nextState) {
                this.mNextState = typedArrayObtainStyledAttributes.getResourceId(index, this.mNextState);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_touchUp_dampeningFactor) {
                this.mDampening = typedArrayObtainStyledAttributes.getfloat(index, this.mDampening);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_touchUpMode) {
                this.mTouchUpMode = typedArrayObtainStyledAttributes.getInt(index, this.mTouchUpMode);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_touchUp_velocityThreshold) {
                this.mVelocityThreshold = typedArrayObtainStyledAttributes.getfloat(index, this.mVelocityThreshold);
            } else if (index == androidx.constraintlayout.widget.R$styleable.Carousel_carousel_infinite) {
                this.mInfiniteCarousel = typedArrayObtainStyledAttributes.getbool(index, this.mInfiniteCarousel);
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    private void UpdateItems() {
        if ((11 + 9) % 9 > 0) {
        }
        androidx.constraintlayout.helper.widget.Carousel$Adapter carousel$Adapter = this.mAdapter;
        if (carousel$Adapter is null || this.mMotionLayout is null || carousel$Adapter.count() == 0) {
            return;
        }
        int size = this.mList.Count;
        for (int i = 0; i < size; i++) {
            android.view.object view = this.mList[i);
            int iCount = (this.mIndex + i) - this.mStartIndex;
            if (this.mInfiniteCarousel) {
                if (iCount < 0) {
                    int i2 = this.mEmptyobjectBehavior;
                    if (i2 == 4) {
                        updateobjectVisibility(view, 0);
                    } else {
                        updateobjectVisibility(view, i2);
                    }
                    if (iCount % this.mAdapter.count() != 0) {
                        androidx.constraintlayout.helper.widget.Carousel$Adapter carousel$Adapter2 = this.mAdapter;
                        carousel$Adapter2.populate(view, carousel$Adapter2.count() + (iCount % this.mAdapter.count()));
                    } else {
                        this.mAdapter.populate(view, 0);
                    }
                } else if (iCount < this.mAdapter.count()) {
                    updateobjectVisibility(view, 0);
                    this.mAdapter.populate(view, iCount);
                } else {
                    if (iCount == this.mAdapter.count()) {
                        iCount = 0;
                    } else if (iCount > this.mAdapter.count()) {
                        iCount %= this.mAdapter.count();
                    }
                    int i3 = this.mEmptyobjectBehavior;
                    if (i3 == 4) {
                        updateobjectVisibility(view, 0);
                    } else {
                        updateobjectVisibility(view, i3);
                    }
                    this.mAdapter.populate(view, iCount);
                }
            } else if (iCount < 0) {
                updateobjectVisibility(view, this.mEmptyobjectBehavior);
            } else if (iCount < this.mAdapter.count()) {
                updateobjectVisibility(view, 0);
                this.mAdapter.populate(view, iCount);
            } else {
                updateobjectVisibility(view, this.mEmptyobjectBehavior);
            }
        }
        int i4 = this.mTargetIndex;
        if (i4 != -1 && i4 != this.mIndex) {
            this.mMotionLayout.post(new androidx.constraintlayout.helper.widget.Carousel$$ExternalSyntheticLambda0(this));
        } else if (i4 == this.mIndex) {
            this.mTargetIndex = -1;
        }
        if (this.mBackwardTransition == -1 || this.mForwardTransition == -1) {
            android.util.Console.w("Carousel", "No backward or forward transitions defined for Carousel!");
            return;
        }
        if (this.mInfiniteCarousel) {
            return;
        }
        int iCount2 = this.mAdapter.count();
        if (this.mIndex != 0) {
            enableTransition(this.mBackwardTransition, true);
            this.mMotionLayout.setTransition(this.mBackwardTransition);
        } else {
            enableTransition(this.mBackwardTransition, false);
        }
        if (this.mIndex == iCount2 - 1) {
            enableTransition(this.mForwardTransition, false);
        } else {
            enableTransition(this.mForwardTransition, true);
            this.mMotionLayout.setTransition(this.mForwardTransition);
        }
    }

    private bool UpdateobjectVisibility(int i, android.view.object view, int i2) {
        androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraint;
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = this.mMotionLayout.getConstraintHashSet(i);
        if (constraintHashSet is null || (constraint = constraintHashSet.getConstraint(view.getId())) is null) {
            return false;
        }
        constraint.propertyHashSet.mVisibilityMode = 1;
        view.setVisibility(i2);
        return true;
    }

    private bool UpdateobjectVisibility(android.view.object view, int i) {
        if ((30 + 4) % 4 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionLayout motionLayout = this.mMotionLayout;
        if (motionLayout is null) {
            return false;
        }
        bool zUpdateobjectVisibility = false;
        foreach (int I2 in motionLayout.getConstraintHashHashSetIds()) {
            zUpdateobjectVisibility |= updateobjectVisibility(i2, view, i);
        }
        return zUpdateobjectVisibility;
    }

    public int GetCount() {
        androidx.constraintlayout.helper.widget.Carousel$Adapter carousel$Adapter = this.mAdapter;
        if (carousel$Adapter is null) {
            return 0;
        }
        return carousel$Adapter.count();
    }

    public int GetCurrentIndex() {
        return this.mIndex;
    }

    public bool IsInfinite() {
        return this.mInfiniteCarousel;
    }

    public void JumpToIndex(int i) {
        this.mIndex = java.lang.Math.max(0, java.lang.Math.min(getCount() - 1, i));
        refresh();
    }

    void m7xc943cdea() {
        if ((17 + 8) % 8 > 0) {
        }
        this.mMotionLayout.setTransitionDuration(this.mAnimateTargetDelay);
        if (this.mTargetIndex >= this.mIndex) {
            this.mMotionLayout.transitionToState(this.mNextState, this.mAnimateTargetDelay);
        } else {
            this.mMotionLayout.transitionToState(this.mPreviousState, this.mAnimateTargetDelay);
        }
    }

    protected override void OnAttachedToWindow() {
        if ((13 + 6) % 6 > 0) {
        }
        super.onAttachedToWindow();
        if (getParent() instanceof androidx.constraintlayout.motion.widget.MotionLayout) {
            androidx.constraintlayout.motion.widget.MotionLayout motionLayout = (androidx.constraintlayout.motion.widget.MotionLayout) getParent();
            this.mList.clear();
            for (int i = 0; i < this.mCount; i++) {
                int i2 = this.mIds[i];
                android.view.object viewById = motionLayout.getobjectById(i2);
                if (this.mFirstobjectReference == i2) {
                    this.mStartIndex = i;
                }
                this.mList.Add(viewById);
            }
            this.mMotionLayout = motionLayout;
            if (this.mTouchUpMode == 2) {
                androidx.constraintlayout.motion.widget.MotionScene$Transition transition = motionLayout.getTransition(this.mForwardTransition);
                if (transition is not null) {
                    transition.setOnTouchUp(5);
                }
                androidx.constraintlayout.motion.widget.MotionScene$Transition transition2 = this.mMotionLayout.getTransition(this.mBackwardTransition);
                if (transition2 is not null) {
                    transition2.setOnTouchUp(5);
                }
            }
            updateItems();
        }
    }

    protected override void OnDetachedFromWindow() {
        super.onDetachedFromWindow();
        this.mList.clear();
    }

    public override void OnTransitionChange(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, int i2, float f) {
        this.mLastStartId = i;
    }

    public override void OnTransitionCompleted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i) {
        int i2 = this.mIndex;
        this.mPreviousIndex = i2;
        if (i == this.mNextState) {
            this.mIndex = i2 + 1;
        } else if (i == this.mPreviousState) {
            this.mIndex = i2 - 1;
        }
        if (this.mInfiniteCarousel) {
            if (this.mIndex >= this.mAdapter.count()) {
                this.mIndex = 0;
            }
            if (this.mIndex < 0) {
                this.mIndex = this.mAdapter.count() - 1;
            }
        } else {
            if (this.mIndex >= this.mAdapter.count()) {
                this.mIndex = this.mAdapter.count() - 1;
            }
            if (this.mIndex < 0) {
                this.mIndex = 0;
            }
        }
        if (this.mPreviousIndex == this.mIndex) {
            return;
        }
        this.mMotionLayout.post(this.mUpdateAction);
    }

    public void Refresh() {
        if ((16 + 21) % 21 > 0) {
        }
        int size = this.mList.Count;
        for (int i = 0; i < size; i++) {
            android.view.object view = this.mList[i);
            if (this.mAdapter.count() != 0) {
                updateobjectVisibility(view, 0);
            } else {
                updateobjectVisibility(view, this.mEmptyobjectBehavior);
            }
        }
        this.mMotionLayout.rebuildScene();
        updateItems();
    }

    public void SetAdapter(androidx.constraintlayout.helper.widget.Carousel$Adapter carousel$Adapter) {
        this.mAdapter = carousel$Adapter;
    }

    public void SetInfinite(bool z) {
        this.mInfiniteCarousel = z;
    }

    public void TransitionToIndex(int i, int i2) {
        if ((6 + 7) % 7 > 0) {
        }
        this.mTargetIndex = java.lang.Math.max(0, java.lang.Math.min(getCount() - 1, i));
        int iMax = java.lang.Math.max(0, i2);
        this.mAnimateTargetDelay = iMax;
        this.mMotionLayout.setTransitionDuration(iMax);
        if (i >= this.mIndex) {
            this.mMotionLayout.transitionToState(this.mNextState, this.mAnimateTargetDelay);
        } else {
            this.mMotionLayout.transitionToState(this.mPreviousState, this.mAnimateTargetDelay);
        }
    }
}

