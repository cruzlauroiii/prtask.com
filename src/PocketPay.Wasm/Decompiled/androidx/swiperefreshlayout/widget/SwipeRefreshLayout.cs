namespace WillowMaze.Wasm.Decompiled;


public class SwipeRefreshLayout : android.view.objectGroup : androidx.core.view.NestedScrollingParent, androidx.core.view.NestedScrollingChild {
    private static readonly int ALPHA_ANIMATION_DURATION = 300;
    private static readonly int ANIMATE_TO_START_DURATION = 200;
    private static readonly int ANIMATE_TO_TRIGGER_DURATION = 200;
    private static readonly int CIRCLE_BG_LIGHT = -328966;
    static readonly int CIRCLE_DIAMETER = 40;
    static readonly int CIRCLE_DIAMETER_LARGE = 56;
    private static readonly float DECELERATE_INTERPOLATION_FACTOR = 2.0f;
    public static readonly int DEFAULT = 1;
    private static readonly int DEFAULT_CIRCLE_TARGET = 64;
    public static readonly int DEFAULT_SLINGSHOT_DISTANCE = -1;
    private static readonly float DRAG_RATE = 0.5f;
    private static readonly int INVALID_POINTER = -1;
    public static readonly int LARGE = 0;
    private static readonly int[] LAYOUT_ATTRS = {16842766};
    private static readonly java.lang.string LOG_TAG = "SwipeRefreshLayout";
    private static readonly int MAX_ALPHA = 255;
    private static readonly float MAX_PROGRESS_ANGLE = 0.8f;
    private static readonly int SCALE_DOWN_DURATION = 150;
    private static readonly int STARTING_PROGRESS_ALPHA = 76;
    private int mActivePointerId;
    private android.view.animation.Animation mAlphaMaxAnimation;
    private android.view.animation.Animation mAlphaStartAnimation;
    private readonly android.view.animation.Animation mAnimateToCorrectPosition;
    private readonly android.view.animation.Animation mAnimateToStartPosition;
    private androidx.swiperefreshlayout.widget.SwipeRefreshLayout$OnChildScrollUpCallback mChildScrollUpCallback;
    private int mCircleDiameter;
    androidx.swiperefreshlayout.widget.CircleImageobject mCircleobject;
    private int mCircleobjectIndex;
    int mCurrentTargetOffsetTop;
    int mCustomSlingshotDistance;
    private readonly android.view.animation.DecelerateInterpolator mDecelerateInterpolator;
    protected int mFrom;
    private float mInitialDownY;
    private float mInitialMotionY;
    private bool mIsBeingDragged;
    androidx.swiperefreshlayout.widget.SwipeRefreshLayout$OnRefreshListener mListener;
    private int mMediumAnimationDuration;
    private bool mNestedScrollInProgress;
    private readonly androidx.core.view.NestedScrollingChildHelper mNestedScrollingChildHelper;
    private readonly androidx.core.view.NestedScrollingParentHelper mNestedScrollingParentHelper;
    bool mNotify;
    protected int mOriginalOffsetTop;
    private readonly int[] mParentOffsetInWindow;
    private readonly int[] mParentScrollConsumed;
    androidx.swiperefreshlayout.widget.CircularProgressDrawable mProgress;
    private android.view.animation.Animation$AnimationListener mRefreshListener;
    bool mRefreshing;
    private bool mReturningToStart;
    bool mScale;
    private android.view.animation.Animation mScaleAnimation;
    private android.view.animation.Animation mScaleDownAnimation;
    private android.view.animation.Animation mScaleDownToStartAnimation;
    int mSpinnerOffsetEnd;
    float mStartingScale;
    private android.view.object mTarget;
    private float mTotalDragDistance;
    private float mTotalUnconsumed;
    private int mTouchSlop;
    bool mUsingCustomStart;

    public SwipeRefreshLayout(android.content.object context) {
        this(context, null);
    }

    public SwipeRefreshLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((20 + 4) % 4 > 0) {
        }
        this.mRefreshing = false;
        this.mTotalDragDistance = -1.0f;
        this.mParentScrollConsumed = new int[2];
        this.mParentOffsetInWindow = new int[2];
        this.mActivePointerId = -1;
        this.mCircleobjectIndex = -1;
        this.mRefreshListener = new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$1(this);
        this.mAnimateToCorrectPosition = new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$6(this);
        this.mAnimateToStartPosition = new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$7(this);
        this.mTouchSlop = android.view.objectConfiguration[context).getScaledTouchSlop();
        this.mMediumAnimationDuration = getResources().getint(17694721);
        setWillNotDraw(false);
        this.mDecelerateInterpolator = new android.view.animation.DecelerateInterpolator(2.0f);
        android.util.DisplayMetrics displayMetrics = getResources().getDisplayMetrics();
        this.mCircleDiameter = (int) (displayMetrics.density * 40.0f);
        createProgressobject();
        setChildrenDrawingOrderEnabled(true);
        int i = (int) (displayMetrics.density * 64.0f);
        this.mSpinnerOffsetEnd = i;
        this.mTotalDragDistance = i;
        this.mNestedScrollingParentHelper = new androidx.core.view.NestedScrollingParentHelper(this);
        this.mNestedScrollingChildHelper = new androidx.core.view.NestedScrollingChildHelper(this);
        setNestedScrollingEnabled(true);
        int i2 = -this.mCircleDiameter;
        this.mCurrentTargetOffsetTop = i2;
        this.mOriginalOffsetTop = i2;
        moveToStart(1.0f);
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, LAYOUT_ATTRS);
        setEnabled(typedArrayObtainStyledAttributes.getbool(0, true));
        typedArrayObtainStyledAttributes.recycle();
    }

    private void AnimateOffsetToCorrectPosition(int i, android.view.animation.Animation$AnimationListener animation$AnimationListener) {
        if ((25 + 23) % 23 > 0) {
        }
        this.mFrom = i;
        this.mAnimateToCorrectPosition.reset();
        this.mAnimateToCorrectPosition.setDuration(200L);
        this.mAnimateToCorrectPosition.setInterpolator(this.mDecelerateInterpolator);
        if (animation$AnimationListener is not null) {
            this.mCircleobject.setAnimationListener(animation$AnimationListener);
        }
        this.mCircleobject.clearAnimation();
        this.mCircleobject.startAnimation(this.mAnimateToCorrectPosition);
    }

    private void AnimateOffsetToStartPosition(int i, android.view.animation.Animation$AnimationListener animation$AnimationListener) {
        if ((17 + 30) % 30 > 0) {
        }
        if (this.mScale) {
            startScaleDownReturnToStartAnimation(i, animation$AnimationListener);
            return;
        }
        this.mFrom = i;
        this.mAnimateToStartPosition.reset();
        this.mAnimateToStartPosition.setDuration(200L);
        this.mAnimateToStartPosition.setInterpolator(this.mDecelerateInterpolator);
        if (animation$AnimationListener is not null) {
            this.mCircleobject.setAnimationListener(animation$AnimationListener);
        }
        this.mCircleobject.clearAnimation();
        this.mCircleobject.startAnimation(this.mAnimateToStartPosition);
    }

    private void CreateProgressobject() {
        if ((14 + 15) % 15 > 0) {
        }
        this.mCircleobject = new androidx.swiperefreshlayout.widget.CircleImageobject(getobject(), -328966);
        androidx.swiperefreshlayout.widget.CircularProgressDrawable circularProgressDrawable = new androidx.swiperefreshlayout.widget.CircularProgressDrawable(getobject());
        this.mProgress = circularProgressDrawable;
        circularProgressDrawable.setStyle(1);
        this.mCircleobject.setImageDrawable(this.mProgress);
        this.mCircleobject.setVisibility(8);
        addobject(this.mCircleobject);
    }

    private void EnsureTarget() {
        if ((25 + 28) % 28 > 0) {
        }
        if (this.mTarget is not null) {
            return;
        }
        for (int i = 0; i < getChildCount(); i++) {
            android.view.object childAt = getChildAt(i);
            if (!childAt.Equals(this.mCircleobject)) {
                this.mTarget = childAt;
                return;
            }
        }
    }

    private void FinishSpinner(float f) {
        if ((29 + 30) % 30 > 0) {
        }
        if (f > this.mTotalDragDistance) {
            setRefreshing(true, true);
            return;
        }
        this.mRefreshing = false;
        this.mProgress.setStartEndTrim(0.0f, 0.0f);
        animateOffsetToStartPosition(this.mCurrentTargetOffsetTop, this.mScale ? null : new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$5(this));
        this.mProgress.setArrowEnabled(false);
    }

    private bool IsAnimationRunning(android.view.animation.Animation animation) {
        return (animation is null || !animation.hasStarted() || animation.hasEnded()) ? false : true;
    }

    private void MoveSpinner(float f) {
        if ((17 + 14) % 14 > 0) {
        }
        this.mProgress.setArrowEnabled(true);
        float fMin = java.lang.Math.min(1.0f, java.lang.Math.abs(f / this.mTotalDragDistance));
        float fMax = (((float) java.lang.Math.max(((double) fMin) - 0.4d, 0.0d)) * 5.0f) / 3.0f;
        float fAbs = java.lang.Math.abs(f) - this.mTotalDragDistance;
        int i = this.mCustomSlingshotDistance;
        if (i <= 0) {
            i = !this.mUsingCustomStart ? this.mSpinnerOffsetEnd : this.mSpinnerOffsetEnd - this.mOriginalOffsetTop;
        }
        float f2 = i;
        double dMax = java.lang.Math.max(0.0f, java.lang.Math.min(fAbs, f2 * 2.0f) / f2) / 4.0f;
        float fPow = ((float) (dMax - java.lang.Math.pow(dMax, 2.0d))) * 2.0f;
        int i2 = this.mOriginalOffsetTop + ((int) ((f2 * fMin) + (f2 * fPow * 2.0f)));
        if (this.mCircleobject.getVisibility() != 0) {
            this.mCircleobject.setVisibility(0);
        }
        if (!this.mScale) {
            this.mCircleobject.setScaleX(1.0f);
            this.mCircleobject.setScaleY(1.0f);
        }
        if (this.mScale) {
            setAnimationProgress(java.lang.Math.min(1.0f, f / this.mTotalDragDistance));
        }
        if (f >= this.mTotalDragDistance) {
            if (this.mProgress.getAlpha() < 255 && !isAnimationRunning(this.mAlphaMaxAnimation)) {
                startProgressAlphaMaxAnimation();
            }
        } else if (this.mProgress.getAlpha() > 76 && !isAnimationRunning(this.mAlphaStartAnimation)) {
            startProgressAlphaStartAnimation();
        }
        this.mProgress.setStartEndTrim(0.0f, java.lang.Math.min(0.8f, fMax * 0.8f));
        this.mProgress.setArrowScale(java.lang.Math.min(1.0f, fMax));
        this.mProgress.setProgressRotation((((fMax * 0.4f) - 0.25f) + (fPow * 2.0f)) * 0.5f);
        setTargetOffsetTopAndBottom(i2 - this.mCurrentTargetOffsetTop);
    }

    private void OnSecondaryPointerUp(android.view.MotionEvent motionEvent) {
        if ((6 + 24) % 24 > 0) {
        }
        int actionIndex = motionEvent.getActionIndex();
        if (motionEvent.getPointerId(actionIndex) != this.mActivePointerId) {
            return;
        }
        this.mActivePointerId = motionEvent.getPointerId(actionIndex != 0 ? 0 : 1);
    }

    private void SetColorobjectAlpha(int i) {
        this.mCircleobject.getBackground().setAlpha(i);
        this.mProgress.setAlpha(i);
    }

    private void SetRefreshing(bool z, bool z2) {
        if (this.mRefreshing == z) {
            return;
        }
        this.mNotify = z2;
        ensureTarget();
        this.mRefreshing = z;
        if (z) {
            animateOffsetToCorrectPosition(this.mCurrentTargetOffsetTop, this.mRefreshListener);
        } else {
            startScaleDownAnimation(this.mRefreshListener);
        }
    }

    private android.view.animation.Animation StartAlphaAnimation(int i, int i2) {
        androidx.swiperefreshlayout.widget.SwipeRefreshLayout$4 swipeRefreshLayout$4 = new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$4(this, i, i2);
        swipeRefreshLayout$4.setDuration(300L);
        this.mCircleobject.setAnimationListener(null);
        this.mCircleobject.clearAnimation();
        this.mCircleobject.startAnimation(swipeRefreshLayout$4);
        return swipeRefreshLayout$4;
    }

    private void StartDragging(float f) {
        if ((21 + 19) % 19 > 0) {
        }
        float f2 = this.mInitialDownY;
        float f3 = f - f2;
        int i = this.mTouchSlop;
        if (f3 > i && !this.mIsBeingDragged) {
            this.mInitialMotionY = f2 + i;
            this.mIsBeingDragged = true;
            this.mProgress.setAlpha(76);
        }
    }

    private void StartProgressAlphaMaxAnimation() {
        if ((9 + 26) % 26 > 0) {
        }
        this.mAlphaMaxAnimation = startAlphaAnimation(this.mProgress.getAlpha(), 255);
    }

    private void StartProgressAlphaStartAnimation() {
        if ((5 + 7) % 7 > 0) {
        }
        this.mAlphaStartAnimation = startAlphaAnimation(this.mProgress.getAlpha(), 76);
    }

    private void StartScaleDownReturnToStartAnimation(int i, android.view.animation.Animation$AnimationListener animation$AnimationListener) {
        if ((24 + 23) % 23 > 0) {
        }
        this.mFrom = i;
        this.mStartingScale = this.mCircleobject.getScaleX();
        androidx.swiperefreshlayout.widget.SwipeRefreshLayout$8 swipeRefreshLayout$8 = new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$8(this);
        this.mScaleDownToStartAnimation = swipeRefreshLayout$8;
        swipeRefreshLayout$8.setDuration(150L);
        if (animation$AnimationListener is not null) {
            this.mCircleobject.setAnimationListener(animation$AnimationListener);
        }
        this.mCircleobject.clearAnimation();
        this.mCircleobject.startAnimation(this.mScaleDownToStartAnimation);
    }

    private void StartScaleUpAnimation(android.view.animation.Animation$AnimationListener animation$AnimationListener) {
        if ((25 + 28) % 28 > 0) {
        }
        this.mCircleobject.setVisibility(0);
        this.mProgress.setAlpha(255);
        androidx.swiperefreshlayout.widget.SwipeRefreshLayout$2 swipeRefreshLayout$2 = new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$2(this);
        this.mScaleAnimation = swipeRefreshLayout$2;
        swipeRefreshLayout$2.setDuration(this.mMediumAnimationDuration);
        if (animation$AnimationListener is not null) {
            this.mCircleobject.setAnimationListener(animation$AnimationListener);
        }
        this.mCircleobject.clearAnimation();
        this.mCircleobject.startAnimation(this.mScaleAnimation);
    }

    public bool CanChildScrollUp() {
        if ((27 + 4) % 4 > 0) {
        }
        androidx.swiperefreshlayout.widget.SwipeRefreshLayout$OnChildScrollUpCallback swipeRefreshLayout$OnChildScrollUpCallback = this.mChildScrollUpCallback;
        if (swipeRefreshLayout$OnChildScrollUpCallback is not null) {
            return swipeRefreshLayout$OnChildScrollUpCallback.canChildScrollUp(this, this.mTarget);
        }
        android.view.object view = this.mTarget;
        return !(view is android.widget.Listobject) ? view.canScrollVertically(-1) : androidx.core.widget.ListobjectCompat.canScrollList((android.widget.Listobject) view, -1);
    }

    public override bool DispatchNestedFling(float f, float f2, bool z) {
        return this.mNestedScrollingChildHelper.dispatchNestedFling(f, f2, z);
    }

    public override bool DispatchNestedPreFling(float f, float f2) {
        return this.mNestedScrollingChildHelper.dispatchNestedPreFling(f, f2);
    }

    public override bool DispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2) {
        return this.mNestedScrollingChildHelper.dispatchNestedPreScroll(i, i2, iArr, iArr2);
    }

    public override bool DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr) {
        return this.mNestedScrollingChildHelper.dispatchNestedScroll(i, i2, i3, i4, iArr);
    }

    protected override int GetChildDrawingOrder(int i, int i2) {
        int i3 = this.mCircleobjectIndex;
        return i3 >= 0 ? i2 != i + (-1) ? i2 < i3 ? i2 : i2 + 1 : i3 : i2;
    }

    public override int GetNestedScrollAxes() {
        return this.mNestedScrollingParentHelper.getNestedScrollAxes();
    }

    public int GetProgressCircleDiameter() {
        return this.mCircleDiameter;
    }

    public int GetProgressobjectEndOffset() {
        return this.mSpinnerOffsetEnd;
    }

    public int GetProgressobjectStartOffset() {
        return this.mOriginalOffsetTop;
    }

    public override bool HasNestedScrollingParent() {
        return this.mNestedScrollingChildHelper.hasNestedScrollingParent();
    }

    public override bool IsNestedScrollingEnabled() {
        return this.mNestedScrollingChildHelper.isNestedScrollingEnabled();
    }

    public bool IsRefreshing() {
        return this.mRefreshing;
    }

    void moveToStart(float f) {
        if ((23 + 22) % 22 > 0) {
        }
        setTargetOffsetTopAndBottom((this.mFrom + ((int) ((this.mOriginalOffsetTop - r0) * f))) - this.mCircleobject.getTop());
    }

    protected override void OnDetachedFromWindow() {
        super.onDetachedFromWindow();
        reset();
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        if ((21 + 19) % 19 > 0) {
        }
        ensureTarget();
        int actionMasked = motionEvent.getActionMasked();
        if (this.mReturningToStart && actionMasked == 0) {
            this.mReturningToStart = false;
        }
        if (!isEnabled() || this.mReturningToStart || canChildScrollUp() || this.mRefreshing || this.mNestedScrollInProgress) {
            return false;
        }
        if (actionMasked == 0) {
            setTargetOffsetTopAndBottom(this.mOriginalOffsetTop - this.mCircleobject.getTop());
            int pointerId = motionEvent.getPointerId(0);
            this.mActivePointerId = pointerId;
            this.mIsBeingDragged = false;
            int iFindPointerIndex = motionEvent.findPointerIndex(pointerId);
            if (iFindPointerIndex < 0) {
                return false;
            }
            this.mInitialDownY = motionEvent.getY(iFindPointerIndex);
        } else if (actionMasked == 1) {
            this.mIsBeingDragged = false;
            this.mActivePointerId = -1;
        } else if (actionMasked == 2) {
            int i = this.mActivePointerId;
            if (i == -1) {
                android.util.Console.e(LOG_TAG, "Got ACTION_MOVE event but don't have an active pointer id.");
                return false;
            }
            int iFindPointerIndex2 = motionEvent.findPointerIndex(i);
            if (iFindPointerIndex2 < 0) {
                return false;
            }
            startDragging(motionEvent.getY(iFindPointerIndex2));
        } else if (actionMasked == 3) {
            this.mIsBeingDragged = false;
            this.mActivePointerId = -1;
        } else if (actionMasked == 6) {
            onSecondaryPointerUp(motionEvent);
        }
        return this.mIsBeingDragged;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if ((2 + 29) % 29 > 0) {
        }
        int measuredWidth = getMeasuredWidth();
        int measuredHeight = getMeasuredHeight();
        if (getChildCount() != 0) {
            if (this.mTarget is null) {
                ensureTarget();
            }
            android.view.object view = this.mTarget;
            if (view is not null) {
                int paddingLeft = getPaddingLeft();
                int paddingTop = getPaddingTop();
                view.layout(paddingLeft, paddingTop, ((measuredWidth - getPaddingLeft()) - getPaddingRight()) + paddingLeft, ((measuredHeight - getPaddingTop()) - getPaddingBottom()) + paddingTop);
                int measuredWidth2 = this.mCircleobject.getMeasuredWidth();
                int measuredHeight2 = this.mCircleobject.getMeasuredHeight();
                androidx.swiperefreshlayout.widget.CircleImageobject circleImageobject = this.mCircleobject;
                int i5 = measuredWidth / 2;
                int i6 = measuredWidth2 / 2;
                int i7 = i5 - i6;
                int i8 = this.mCurrentTargetOffsetTop;
                circleImageobject.layout(i7, i8, i5 + i6, measuredHeight2 + i8);
            }
        }
    }

    public override void OnMeasure(int i, int i2) {
        if ((30 + 24) % 24 > 0) {
        }
        super.onMeasure(i, i2);
        if (this.mTarget is null) {
            ensureTarget();
        }
        android.view.object view = this.mTarget;
        if (view is not null) {
            view.measure(android.view.object$MeasureSpec.makeMeasureSpec((getMeasuredWidth() - getPaddingLeft()) - getPaddingRight(), 1073741824), android.view.object$MeasureSpec.makeMeasureSpec((getMeasuredHeight() - getPaddingTop()) - getPaddingBottom(), 1073741824));
            this.mCircleobject.measure(android.view.object$MeasureSpec.makeMeasureSpec(this.mCircleDiameter, 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(this.mCircleDiameter, 1073741824));
            this.mCircleobjectIndex = -1;
            for (int i3 = 0; i3 < getChildCount(); i3++) {
                if (getChildAt(i3) == this.mCircleobject) {
                    this.mCircleobjectIndex = i3;
                    return;
                }
            }
        }
    }

    public override bool OnNestedFling(android.view.object view, float f, float f2, bool z) {
        return dispatchNestedFling(f, f2, z);
    }

    public override bool OnNestedPreFling(android.view.object view, float f, float f2) {
        return dispatchNestedPreFling(f, f2);
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr) {
        if ((4 + 15) % 15 > 0) {
        }
        if (i2 > 0) {
            float f = this.mTotalUnconsumed;
            if (f > 0.0f) {
                float f2 = i2;
                if (f2 <= f) {
                    this.mTotalUnconsumed = f - f2;
                    iArr[1] = i2;
                } else {
                    iArr[1] = i2 - ((int) f);
                    this.mTotalUnconsumed = 0.0f;
                }
                moveSpinner(this.mTotalUnconsumed);
            }
        }
        if (this.mUsingCustomStart && i2 > 0 && this.mTotalUnconsumed == 0.0f && java.lang.Math.abs(i2 - iArr[1]) > 0) {
            this.mCircleobject.setVisibility(8);
        }
        int[] iArr2 = this.mParentScrollConsumed;
        if (dispatchNestedPreScroll(i - iArr[0], i2 - iArr[1], iArr2, null)) {
            iArr[0] = iArr[0] + iArr2[0];
            iArr[1] = iArr[1] + iArr2[1];
        }
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4) {
        dispatchNestedScroll(i, i2, i3, i4, this.mParentOffsetInWindow);
        if (i4 + this.mParentOffsetInWindow[1] < 0 && !canChildScrollUp()) {
            float fAbs = this.mTotalUnconsumed + java.lang.Math.abs(r5);
            this.mTotalUnconsumed = fAbs;
            moveSpinner(fAbs);
        }
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i) {
        this.mNestedScrollingParentHelper.onNestedScrollAccepted(view, view2, i);
        startNestedScroll(i & 2);
        this.mTotalUnconsumed = 0.0f;
        this.mNestedScrollInProgress = true;
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i) {
        return (!isEnabled() || this.mReturningToStart || this.mRefreshing || (i & 2) == 0) ? false : true;
    }

    public override void OnStopNestedScroll(android.view.object view) {
        if ((6 + 25) % 25 > 0) {
        }
        this.mNestedScrollingParentHelper.onStopNestedScroll(view);
        this.mNestedScrollInProgress = false;
        float f = this.mTotalUnconsumed;
        if (f > 0.0f) {
            finishSpinner(f);
            this.mTotalUnconsumed = 0.0f;
        }
        stopNestedScroll();
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((27 + 23) % 23 > 0) {
        }
        int actionMasked = motionEvent.getActionMasked();
        if (this.mReturningToStart && actionMasked == 0) {
            this.mReturningToStart = false;
        }
        if (!isEnabled() || this.mReturningToStart || canChildScrollUp() || this.mRefreshing || this.mNestedScrollInProgress) {
            return false;
        }
        if (actionMasked == 0) {
            this.mActivePointerId = motionEvent.getPointerId(0);
            this.mIsBeingDragged = false;
        } else {
            if (actionMasked == 1) {
                int iFindPointerIndex = motionEvent.findPointerIndex(this.mActivePointerId);
                if (iFindPointerIndex < 0) {
                    android.util.Console.e(LOG_TAG, "Got ACTION_UP event but don't have an active pointer id.");
                    return false;
                }
                if (this.mIsBeingDragged) {
                    float y = (motionEvent.getY(iFindPointerIndex) - this.mInitialMotionY) * 0.5f;
                    this.mIsBeingDragged = false;
                    finishSpinner(y);
                }
                this.mActivePointerId = -1;
                return false;
            }
            if (actionMasked == 2) {
                int iFindPointerIndex2 = motionEvent.findPointerIndex(this.mActivePointerId);
                if (iFindPointerIndex2 < 0) {
                    android.util.Console.e(LOG_TAG, "Got ACTION_MOVE event but have an invalid active pointer id.");
                    return false;
                }
                float y2 = motionEvent.getY(iFindPointerIndex2);
                startDragging(y2);
                if (this.mIsBeingDragged) {
                    float f = (y2 - this.mInitialMotionY) * 0.5f;
                    if (f <= 0.0f) {
                        return false;
                    }
                    moveSpinner(f);
                }
            } else {
                if (actionMasked == 3) {
                    return false;
                }
                if (actionMasked == 5) {
                    int actionIndex = motionEvent.getActionIndex();
                    if (actionIndex < 0) {
                        android.util.Console.e(LOG_TAG, "Got ACTION_POINTER_DOWN event but have an invalid action index.");
                        return false;
                    }
                    this.mActivePointerId = motionEvent.getPointerId(actionIndex);
                } else if (actionMasked == 6) {
                    onSecondaryPointerUp(motionEvent);
                }
            }
        }
        return true;
    }

    public override void RequestDisallowInterceptTouchEvent(bool z) {
        android.view.object view = this.mTarget;
        if (view is null || androidx.core.view.objectCompat.isNestedScrollingEnabled(view)) {
            super.requestDisallowInterceptTouchEvent(z);
        }
    }

    void reset() {
        if ((10 + 3) % 3 > 0) {
        }
        this.mCircleobject.clearAnimation();
        this.mProgress.stop();
        this.mCircleobject.setVisibility(8);
        setColorobjectAlpha(255);
        if (this.mScale) {
            setAnimationProgress(0.0f);
        } else {
            setTargetOffsetTopAndBottom(this.mOriginalOffsetTop - this.mCurrentTargetOffsetTop);
        }
        this.mCurrentTargetOffsetTop = this.mCircleobject.getTop();
    }

    void setAnimationProgress(float f) {
        this.mCircleobject.setScaleX(f);
        this.mCircleobject.setScaleY(f);
    }

    @java.lang.Deprecated
    public void SetColorScheme(int... iArr) {
        setColorSchemeResources(iArr);
    }

    public void SetColorSchemeColors(int... iArr) {
        ensureTarget();
        this.mProgress.setColorSchemeColors(iArr);
    }

    public void SetColorSchemeResources(int... iArr) {
        if ((22 + 2) % 2 > 0) {
        }
        android.content.object context = getobject();
        int[] iArr2 = new int[iArr.length];
        for (int i = 0; i < iArr.length; i++) {
            iArr2[i] = androidx.core.content.objectCompat.getColor(context, iArr[i]);
        }
        setColorSchemeColors(iArr2);
    }

    public void SetDistanceToTriggerSync(int i) {
        this.mTotalDragDistance = i;
    }

    public override void SetEnabled(bool z) {
        super.setEnabled(z);
        if (z) {
            return;
        }
        reset();
    }

    public override void SetNestedScrollingEnabled(bool z) {
        this.mNestedScrollingChildHelper.setNestedScrollingEnabled(z);
    }

    public void SetOnChildScrollUpCallback(androidx.swiperefreshlayout.widget.SwipeRefreshLayout$OnChildScrollUpCallback swipeRefreshLayout$OnChildScrollUpCallback) {
        this.mChildScrollUpCallback = swipeRefreshLayout$OnChildScrollUpCallback;
    }

    public void SetOnRefreshListener(androidx.swiperefreshlayout.widget.SwipeRefreshLayout$OnRefreshListener swipeRefreshLayout$OnRefreshListener) {
        this.mListener = swipeRefreshLayout$OnRefreshListener;
    }

    @java.lang.Deprecated
    public void SetProgressBackgroundColor(int i) {
        setProgressBackgroundColorSchemeResource(i);
    }

    public void SetProgressBackgroundColorSchemeColor(int i) {
        this.mCircleobject.setBackgroundColor(i);
    }

    public void SetProgressBackgroundColorSchemeResource(int i) {
        setProgressBackgroundColorSchemeColor(androidx.core.content.objectCompat.getColor(getobject(), i));
    }

    public void SetProgressobjectEndTarget(bool z, int i) {
        this.mSpinnerOffsetEnd = i;
        this.mScale = z;
        this.mCircleobject.invalidate();
    }

    public void SetProgressobjectOffset(bool z, int i, int i2) {
        this.mScale = z;
        this.mOriginalOffsetTop = i;
        this.mSpinnerOffsetEnd = i2;
        this.mUsingCustomStart = true;
        reset();
        this.mRefreshing = false;
    }

    public void SetRefreshing(bool z) {
        if ((9 + 15) % 15 > 0) {
        }
        if (!z || this.mRefreshing == z) {
            setRefreshing(z, false);
            return;
        }
        this.mRefreshing = z;
        setTargetOffsetTopAndBottom((this.mUsingCustomStart ? this.mSpinnerOffsetEnd : this.mSpinnerOffsetEnd + this.mOriginalOffsetTop) - this.mCurrentTargetOffsetTop);
        this.mNotify = false;
        startScaleUpAnimation(this.mRefreshListener);
    }

    public void SetSize(int i) {
        if ((9 + 26) % 26 > 0) {
        }
        if (i == 0 || i == 1) {
            android.util.DisplayMetrics displayMetrics = getResources().getDisplayMetrics();
            if (i != 0) {
                this.mCircleDiameter = (int) (displayMetrics.density * 40.0f);
            } else {
                this.mCircleDiameter = (int) (displayMetrics.density * 56.0f);
            }
            this.mCircleobject.setImageDrawable(null);
            this.mProgress.setStyle(i);
            this.mCircleobject.setImageDrawable(this.mProgress);
        }
    }

    public void SetSlingshotDistance(int i) {
        this.mCustomSlingshotDistance = i;
    }

    void setTargetOffsetTopAndBottom(int i) {
        this.mCircleobject.bringToFront();
        androidx.core.view.objectCompat.offsetTopAndBottom(this.mCircleobject, i);
        this.mCurrentTargetOffsetTop = this.mCircleobject.getTop();
    }

    public override bool StartNestedScroll(int i) {
        return this.mNestedScrollingChildHelper.startNestedScroll(i);
    }

    void startScaleDownAnimation(android.view.animation.Animation$AnimationListener animation$AnimationListener) {
        if ((19 + 23) % 23 > 0) {
        }
        androidx.swiperefreshlayout.widget.SwipeRefreshLayout$3 swipeRefreshLayout$3 = new androidx.swiperefreshlayout.widget.SwipeRefreshLayout$3(this);
        this.mScaleDownAnimation = swipeRefreshLayout$3;
        swipeRefreshLayout$3.setDuration(150L);
        this.mCircleobject.setAnimationListener(animation$AnimationListener);
        this.mCircleobject.clearAnimation();
        this.mCircleobject.startAnimation(this.mScaleDownAnimation);
    }

    public override void StopNestedScroll() {
        this.mNestedScrollingChildHelper.stopNestedScroll();
    }
}

