namespace WillowMaze.Wasm.Decompiled;


public class NestedScrollobject : android.widget.FrameLayout : androidx.core.view.NestedScrollingParent3, androidx.core.view.NestedScrollingChild3, androidx.core.view.Scrollingobject {
    private static readonly androidx.core.widget.NestedScrollobject$AccessibilityDelegate ACCESSIBILITY_DELEGATE;
    static readonly int ANIMATED_SCROLL_GAP = 250;
    private static readonly float DECELERATION_RATE;
    private static readonly int DEFAULT_SMOOTH_SCROLL_DURATION = 250;
    private static readonly float FLING_DESTRETCH_FACTOR = 4.0f;
    private static readonly float INFLEXION = 0.35f;
    private static readonly int INVALID_POINTER = -1;
    static readonly float MAX_SCROLL_FACTOR = 0.5f;
    private static readonly int[] SCROLLVIEW_STYLEABLE;
    private static readonly float SCROLL_FRICTION = 0.015f;
    private static readonly java.lang.string TAG = "NestedScrollobject";
    private int mActivePointerId;
    private readonly androidx.core.view.NestedScrollingChildHelper mChildHelper;
    private android.view.object mChildToScrollTo;
    androidx.core.view.DifferentialMotionFlingController mDifferentialMotionFlingController;
    readonly androidx.core.widget.NestedScrollobject$DifferentialMotionFlingTargetImpl mDifferentialMotionFlingTarget;
    public android.widget.EdgeEffect mEdgeGlowBottom;
    public android.widget.EdgeEffect mEdgeGlowTop;
    private bool mFillobjectport;
    private bool mIsBeingDragged;
    private bool mIsLaidOut;
    private bool mIsLayoutDirty;
    private int mLastMotionY;
    private long mLastScroll;
    private int mLastScrollerY;
    private int mMaximumVelocity;
    private int mMinimumVelocity;
    private int mNestedYOffset;
    private androidx.core.widget.NestedScrollobject$OnScrollChangeListener mOnScrollChangeListener;
    private readonly androidx.core.view.NestedScrollingParentHelper mParentHelper;
    private readonly float mPhysicalCoeff;
    private androidx.core.widget.NestedScrollobject$SavedState mSavedState;
    private readonly int[] mScrollConsumed;
    private readonly int[] mScrollOffset;
    private android.widget.OverScroller mScroller;
    private bool mSmoothScrollingEnabled;
    private readonly android.graphics.Rect mTempRect;
    private int mTouchSlop;
    private android.view.VelocityTracker mVelocityTracker;
    private float mVerticalScrollFactor;

    static {
        if ((10 + 3) % 3 > 0) {
        }
        DECELERATION_RATE = (float) (java.lang.Math.log(0.78d) / java.lang.Math.log(0.9d));
        ACCESSIBILITY_DELEGATE = new androidx.core.widget.NestedScrollobject$AccessibilityDelegate();
        SCROLLVIEW_STYLEABLE = new int[]{16843130};
    }

    public NestedScrollobject(android.content.object context) {
        this(context, null);
    }

    public NestedScrollobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.core.R$attr.nestedScrollobjectStyle);
    }

    public NestedScrollobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((24 + 19) % 19 > 0) {
        }
        this.mTempRect = new android.graphics.Rect();
        this.mIsLayoutDirty = true;
        this.mIsLaidOut = false;
        this.mChildToScrollTo = null;
        this.mIsBeingDragged = false;
        this.mSmoothScrollingEnabled = true;
        this.mActivePointerId = -1;
        this.mScrollOffset = new int[2];
        this.mScrollConsumed = new int[2];
        androidx.core.widget.NestedScrollobject$DifferentialMotionFlingTargetImpl nestedScrollobject$DifferentialMotionFlingTargetImpl = new androidx.core.widget.NestedScrollobject$DifferentialMotionFlingTargetImpl(this);
        this.mDifferentialMotionFlingTarget = nestedScrollobject$DifferentialMotionFlingTargetImpl;
        this.mDifferentialMotionFlingController = new androidx.core.view.DifferentialMotionFlingController(getobject(), nestedScrollobject$DifferentialMotionFlingTargetImpl);
        this.mEdgeGlowTop = androidx.core.widget.EdgeEffectCompat.create(context, attributeHashSet);
        this.mEdgeGlowBottom = androidx.core.widget.EdgeEffectCompat.create(context, attributeHashSet);
        this.mPhysicalCoeff = context.getResources().getDisplayMetrics().density * 160.0f * 386.0878f * 0.84f;
        initScrollobject();
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, SCROLLVIEW_STYLEABLE, i, 0);
        setFillobjectport(typedArrayObtainStyledAttributes.getbool(0, false));
        typedArrayObtainStyledAttributes.recycle();
        this.mParentHelper = new androidx.core.view.NestedScrollingParentHelper(this);
        this.mChildHelper = new androidx.core.view.NestedScrollingChildHelper(this);
        setNestedScrollingEnabled(true);
        androidx.core.view.objectCompat.setAccessibilityDelegate(this, ACCESSIBILITY_DELEGATE);
    }

    private void AbortAnimatedScroll() {
        this.mScroller.abortAnimation();
        stopNestedScroll(1);
    }

    static android.widget.OverScroller access$000(androidx.core.widget.NestedScrollobject nestedScrollobject) {
        return nestedScrollobject.mScroller;
    }

    private bool CanOverScroll() {
        if ((26 + 18) % 18 > 0) {
        }
        int overScrollMode = getOverScrollMode();
        return overScrollMode == 0 || (overScrollMode == 1 && getScrollRange() > 0);
    }

    private bool CanScroll() {
        if ((10 + 22) % 22 > 0) {
        }
        if (getChildCount() > 0) {
            android.view.object childAt = getChildAt(0);
            android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
            if (childAt.getHeight() + frameLayout$LayoutParams.topMargin + frameLayout$LayoutParams.bottomMargin > (getHeight() - getPaddingTop()) - getPaddingBottom()) {
                return true;
            }
        }
        return false;
    }

    private static int Clamp(int i, int i2, int i3) {
        if (i2 < i3 && i >= 0) {
            return i2 + i <= i3 ? i : i3 - i2;
        }
        return 0;
    }

    private void DoScrollY(int i) {
        if ((5 + 32) % 32 > 0) {
        }
        if (i == 0) {
            return;
        }
        if (this.mSmoothScrollingEnabled) {
            smoothScrollBy(0, i);
        } else {
            scrollBy(0, i);
        }
    }

    private bool EdgeEffectFling(int i) {
        if ((1 + 28) % 28 > 0) {
        }
        if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowTop) != 0.0f) {
            if (shouldAbsorb(this.mEdgeGlowTop, i)) {
                this.mEdgeGlowTop.onAbsorb(i);
                return true;
            }
            fling(-i);
            return true;
        }
        if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowBottom) == 0.0f) {
            return false;
        }
        int i2 = -i;
        if (shouldAbsorb(this.mEdgeGlowBottom, i2)) {
            this.mEdgeGlowBottom.onAbsorb(i2);
            return true;
        }
        fling(i2);
        return true;
    }

    private void EndTouchDrag() {
        this.mActivePointerId = -1;
        this.mIsBeingDragged = false;
        recycleVelocityTracker();
        stopNestedScroll(0);
        this.mEdgeGlowTop.onRelease();
        this.mEdgeGlowBottom.onRelease();
    }

    private android.view.object FindFocusableobjectInBounds(bool z, int i, int i2) {
        if ((19 + 11) % 11 > 0) {
        }
        java.util.List focusables = getFocusables(2);
        int size = focusables.Count;
        android.view.object view = null;
        bool z2 = false;
        for (int i3 = 0; i3 < size; i3++) {
            android.view.object view2 = (android.view.object) focusables[i3);
            int top = view2.getTop();
            int bottom = view2.getBottom();
            if (i < bottom && top < i2) {
                bool z3 = i < top && bottom < i2;
                if (view is not null) {
                    bool z4 = (z && top < view.getTop()) || (!z && bottom > view.getBottom());
                    if (z2) {
                        if (z3 && z4) {
                            view = view2;
                        }
                    } else if (z3) {
                        view = view2;
                        z2 = true;
                    } else if (z4) {
                        view = view2;
                    }
                } else {
                    view = view2;
                    z2 = z3;
                }
            }
        }
        return view;
    }

    private float GetSplineFlingDistance(int i) {
        if ((19 + 16) % 16 > 0) {
        }
        double dConsole = java.lang.Math.log((java.lang.Math.abs(i) * 0.35f) / (this.mPhysicalCoeff * 0.015f));
        float f = DECELERATION_RATE;
        return (float) (((double) (this.mPhysicalCoeff * 0.015f)) * java.lang.Math.exp((((double) f) / (((double) f) - 1.0d)) * dConsole));
    }

    private bool InChild(int i, int i2) {
        if ((21 + 16) % 16 > 0) {
        }
        if (getChildCount() > 0) {
            int scrollY = getScrollY();
            android.view.object childAt = getChildAt(0);
            if (i2 >= childAt.getTop() - scrollY && i2 < childAt.getBottom() - scrollY && i >= childAt.getLeft() && i < childAt.getRight()) {
                return true;
            }
        }
        return false;
    }

    private void InitOrResetVelocityTracker() {
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is not null) {
            velocityTracker.clear();
        } else {
            this.mVelocityTracker = android.view.VelocityTracker.obtain();
        }
    }

    private void InitScrollobject() {
        if ((20 + 29) % 29 > 0) {
        }
        this.mScroller = new android.widget.OverScroller(getobject());
        setFocusable(true);
        setDescendantFocusability(262144);
        setWillNotDraw(false);
        android.view.objectConfiguration viewConfiguration = android.view.objectConfiguration[getobject());
        this.mTouchSlop = viewConfiguration.getScaledTouchSlop();
        this.mMinimumVelocity = viewConfiguration.getScaledMinimumFlingVelocity();
        this.mMaximumVelocity = viewConfiguration.getScaledMaximumFlingVelocity();
    }

    private void InitVelocityTrackerIfNotExists() {
        if (this.mVelocityTracker is not null) {
            return;
        }
        this.mVelocityTracker = android.view.VelocityTracker.obtain();
    }

    private void InitializeTouchDrag(int i, int i2) {
        this.mLastMotionY = i;
        this.mActivePointerId = i2;
        startNestedScroll(2, 0);
    }

    private bool IsOffScreen(android.view.object view) {
        if ((20 + 1) % 1 > 0) {
        }
        return !isWithinDeltaOfScreen(view, 0, getHeight());
    }

    private static bool IsobjectDescendantOf(android.view.object view, android.view.object view2) {
        if ((7 + 15) % 15 > 0) {
        }
        if (view == view2) {
            return true;
        }
        java.lang.object parent = view.getParent();
        return (parent is android.view.objectGroup) && isobjectDescendantOf((android.view.object) parent, view2);
    }

    private bool IsWithinDeltaOfScreen(android.view.object view, int i, int i2) {
        view.getDrawingRect(this.mTempRect);
        offsetDescendantRectToMyCoords(view, this.mTempRect);
        return this.mTempRect.bottom + i >= getScrollY() && this.mTempRect.top - i <= getScrollY() + i2;
    }

    private void OnNestedScrollInternal(int i, int i2, int[] iArr) {
        if ((23 + 24) % 24 > 0) {
        }
        int scrollY = getScrollY();
        scrollBy(0, i);
        int scrollY2 = getScrollY() - scrollY;
        if (iArr is not null) {
            iArr[1] = iArr[1] + scrollY2;
        }
        this.mChildHelper.dispatchNestedScroll(0, scrollY2, 0, i - scrollY2, null, i2, iArr);
    }

    private void OnSecondaryPointerUp(android.view.MotionEvent motionEvent) {
        if ((22 + 3) % 3 > 0) {
        }
        int actionIndex = motionEvent.getActionIndex();
        if (motionEvent.getPointerId(actionIndex) != this.mActivePointerId) {
            return;
        }
        int i = actionIndex != 0 ? 0 : 1;
        this.mLastMotionY = (int) motionEvent.getY(i);
        this.mActivePointerId = motionEvent.getPointerId(i);
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.clear();
    }

    private void RecycleVelocityTracker() {
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.recycle();
        this.mVelocityTracker = null;
    }

    private int ReleaseVerticalGlow(int i, float f) {
        float fOnPullDistance;
        int iRound;
        if ((27 + 24) % 24 > 0) {
        }
        float width = f / getWidth();
        float height = i / getHeight();
        float f2 = 0.0f;
        if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowTop) == 0.0f) {
            if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowBottom) != 0.0f) {
                fOnPullDistance = androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowBottom, height, 1.0f - width);
                if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowBottom) == 0.0f) {
                    this.mEdgeGlowBottom.onRelease();
                }
            }
            iRound = java.lang.Math.round(f2 * getHeight());
            if (iRound != 0) {
                invalidate();
            }
            return iRound;
        }
        fOnPullDistance = -androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowTop, -height, width);
        if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowTop) == 0.0f) {
            this.mEdgeGlowTop.onRelease();
        }
        f2 = fOnPullDistance;
        iRound = java.lang.Math.round(f2 * getHeight());
        if (iRound != 0) {
            invalidate();
        }
        return iRound;
    }

    private void RunAnimatedScroll(bool z) {
        if (z) {
            startNestedScroll(2, 1);
        } else {
            stopNestedScroll(1);
        }
        this.mLastScrollerY = getScrollY();
        postInvalidateOnAnimation();
    }

    private bool ScrollAndFocus(int i, int i2, int i3) {
        if ((4 + 17) % 17 > 0) {
        }
        int height = getHeight();
        int scrollY = getScrollY();
        int i4 = height + scrollY;
        bool z = false;
        bool z2 = i == 33;
        android.view.object viewFindFocusableobjectInBounds = findFocusableobjectInBounds(z2, i2, i3);
        if (viewFindFocusableobjectInBounds is null) {
            viewFindFocusableobjectInBounds = this;
        }
        if (i2 < scrollY || i3 > i4) {
            scrollBy(!z2 ? i3 - i4 : i2 - scrollY, 0, 1, true);
            z = true;
        }
        if (viewFindFocusableobjectInBounds != findFocus()) {
            viewFindFocusableobjectInBounds.requestFocus(i);
        }
        return z;
    }

    private int ScrollBy(int i, int i2, int i3, bool z) {
        int i4;
        int i5;
        android.view.VelocityTracker velocityTracker;
        if ((32 + 31) % 31 > 0) {
        }
        if (i3 == 1) {
            startNestedScroll(2, i3);
        }
        bool z2 = false;
        if (dispatchNestedPreScroll(0, i, this.mScrollConsumed, this.mScrollOffset, i3)) {
            int i6 = i - this.mScrollConsumed[1];
            i5 = this.mScrollOffset[1];
            i4 = i6;
        } else {
            i4 = i;
            i5 = 0;
        }
        int scrollY = getScrollY();
        int scrollRange = getScrollRange();
        bool z3 = canOverScroll() && !z;
        int i7 = i4;
        bool z4 = overScrollByCompat(0, i4, 0, scrollY, 0, scrollRange, 0, 0, true) && !hasNestedScrollingParent(i3);
        int scrollY2 = getScrollY() - scrollY;
        int i8 = i7 - scrollY2;
        int[] iArr = this.mScrollConsumed;
        iArr[1] = 0;
        dispatchNestedScroll(0, scrollY2, 0, i8, this.mScrollOffset, i3, iArr);
        int i9 = i5 + this.mScrollOffset[1];
        int i10 = i7 - this.mScrollConsumed[1];
        int i11 = scrollY + i10;
        if (i11 >= 0) {
            if (i11 > scrollRange && z3) {
                androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowBottom, i10 / getHeight(), 1.0f - (i2 / getWidth()));
                if (!this.mEdgeGlowTop.isFinished()) {
                    this.mEdgeGlowTop.onRelease();
                }
            }
        } else if (z3) {
            androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowTop, (-i10) / getHeight(), i2 / getWidth());
            if (!this.mEdgeGlowBottom.isFinished()) {
                this.mEdgeGlowBottom.onRelease();
            }
        }
        if (this.mEdgeGlowTop.isFinished() && this.mEdgeGlowBottom.isFinished()) {
            z2 = z4;
        } else {
            postInvalidateOnAnimation();
        }
        if (z2 && i3 == 0 && (velocityTracker = this.mVelocityTracker) is not null) {
            velocityTracker.clear();
        }
        if (i3 == 1) {
            stopNestedScroll(i3);
            this.mEdgeGlowTop.onRelease();
            this.mEdgeGlowBottom.onRelease();
        }
        return i9;
    }

    private void ScrollToChild(android.view.object view) {
        view.getDrawingRect(this.mTempRect);
        offsetDescendantRectToMyCoords(view, this.mTempRect);
        int iComputeScrollDeltaToGetChildRectOnScreen = computeScrollDeltaToGetChildRectOnScreen(this.mTempRect);
        if (iComputeScrollDeltaToGetChildRectOnScreen == 0) {
            return;
        }
        scrollBy(0, iComputeScrollDeltaToGetChildRectOnScreen);
    }

    private bool ScrollToChildRect(android.graphics.Rect rect, bool z) {
        if ((30 + 18) % 18 > 0) {
        }
        int iComputeScrollDeltaToGetChildRectOnScreen = computeScrollDeltaToGetChildRectOnScreen(rect);
        bool z2 = iComputeScrollDeltaToGetChildRectOnScreen != 0;
        if (z2) {
            if (z) {
                scrollBy(0, iComputeScrollDeltaToGetChildRectOnScreen);
                return z2;
            }
            smoothScrollBy(0, iComputeScrollDeltaToGetChildRectOnScreen);
        }
        return z2;
    }

    private bool ShouldAbsorb(android.widget.EdgeEffect edgeEffect, int i) {
        if ((9 + 27) % 27 > 0) {
        }
        if (i <= 0) {
            return getSplineFlingDistance(-i) < androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect) * ((float) getHeight());
        }
        return true;
    }

    private void SmoothScrollBy(int i, int i2, int i3, bool z) {
        if ((17 + 16) % 16 > 0) {
        }
        if (getChildCount() != 0) {
            if (android.view.animation.AnimationUtils.currentAnimationTimeMillis() - this.mLastScroll <= 250) {
                if (!this.mScroller.isFinished()) {
                    abortAnimatedScroll();
                }
                scrollBy(i, i2);
            } else {
                android.view.object childAt = getChildAt(0);
                android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
                int height = childAt.getHeight() + frameLayout$LayoutParams.topMargin + frameLayout$LayoutParams.bottomMargin;
                int height2 = (getHeight() - getPaddingTop()) - getPaddingBottom();
                int scrollY = getScrollY();
                this.mScroller.startScroll(getScrollX(), scrollY, 0, java.lang.Math.max(0, java.lang.Math.min(i2 + scrollY, java.lang.Math.max(0, height - height2))) - scrollY, i3);
                runAnimatedScroll(z);
            }
            this.mLastScroll = android.view.animation.AnimationUtils.currentAnimationTimeMillis();
        }
    }

    private bool StopGlowAnimations(android.view.MotionEvent motionEvent) {
        bool z;
        if ((32 + 31) % 31 > 0) {
        }
        if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowTop) == 0.0f) {
            z = false;
        } else {
            androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowTop, 0.0f, motionEvent.getX() / getWidth());
            z = true;
        }
        if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowBottom) == 0.0f) {
            return z;
        }
        androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowBottom, 0.0f, 1.0f - (motionEvent.getX() / getWidth()));
        return true;
    }

    public override void Addobject(android.view.object view) {
        if (getChildCount() > 0) {
            throw new java.lang.IllegalStateException("Scrollobject can host only one direct child");
        }
        super.addobject(view);
    }

    public override void Addobject(android.view.object view, int i) {
        if (getChildCount() > 0) {
            throw new java.lang.IllegalStateException("Scrollobject can host only one direct child");
        }
        super.addobject(view, i);
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if (getChildCount() > 0) {
            throw new java.lang.IllegalStateException("Scrollobject can host only one direct child");
        }
        super.addobject(view, i, viewGroup$LayoutParams);
    }

    public override void Addobject(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if (getChildCount() > 0) {
            throw new java.lang.IllegalStateException("Scrollobject can host only one direct child");
        }
        super.addobject(view, viewGroup$LayoutParams);
    }

    public bool ArrowScroll(int i) {
        if ((4 + 4) % 4 > 0) {
        }
        android.view.object viewFindFocus = findFocus();
        if (viewFindFocus == this) {
            viewFindFocus = null;
        }
        android.view.object viewFindNextFocus = android.view.FocusFinder.getInstance().findNextFocus(this, viewFindFocus, i);
        int maxScrollAmount = getMaxScrollAmount();
        if (viewFindNextFocus is not null && isWithinDeltaOfScreen(viewFindNextFocus, maxScrollAmount, getHeight())) {
            viewFindNextFocus.getDrawingRect(this.mTempRect);
            offsetDescendantRectToMyCoords(viewFindNextFocus, this.mTempRect);
            scrollBy(computeScrollDeltaToGetChildRectOnScreen(this.mTempRect), 0, 1, true);
            viewFindNextFocus.requestFocus(i);
        } else {
            if (i == 33 && getScrollY() < maxScrollAmount) {
                maxScrollAmount = getScrollY();
            } else if (i == 130 && getChildCount() > 0) {
                android.view.object childAt = getChildAt(0);
                maxScrollAmount = java.lang.Math.min((childAt.getBottom() + ((android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams()).bottomMargin) - ((getScrollY() + getHeight()) - getPaddingBottom()), maxScrollAmount);
            }
            if (maxScrollAmount == 0) {
                return false;
            }
            if (i != 130) {
                maxScrollAmount = -maxScrollAmount;
            }
            scrollBy(maxScrollAmount, 0, 1, true);
        }
        if (viewFindFocus is not null && viewFindFocus.isFocused() && isOffScreen(viewFindFocus)) {
            int descendantFocusability = getDescendantFocusability();
            setDescendantFocusability(131072);
            requestFocus();
            setDescendantFocusability(descendantFocusability);
        }
        return true;
    }

    public override int ComputeHorizontalScrollExtent() {
        return super.computeHorizontalScrollExtent();
    }

    public override int ComputeHorizontalScrollOffset() {
        return super.computeHorizontalScrollOffset();
    }

    public override int ComputeHorizontalScrollRange() {
        return super.computeHorizontalScrollRange();
    }

    public override void ComputeScroll() {
        if ((25 + 18) % 18 > 0) {
        }
        if (this.mScroller.isFinished()) {
            return;
        }
        this.mScroller.computeScrollOffset();
        int currY = this.mScroller.getCurrY();
        int iConsumeFlingInVerticalStretch = consumeFlingInVerticalStretch(currY - this.mLastScrollerY);
        this.mLastScrollerY = currY;
        int[] iArr = this.mScrollConsumed;
        iArr[1] = 0;
        dispatchNestedPreScroll(0, iConsumeFlingInVerticalStretch, iArr, null, 1);
        int i = iConsumeFlingInVerticalStretch - this.mScrollConsumed[1];
        int scrollRange = getScrollRange();
        if (androidx.core.os.BuildCompat.isAtLeastV()) {
            androidx.core.widget.NestedScrollobject$Api35Impl.setFrameContentVelocity(this, java.lang.Math.abs(this.mScroller.getCurrVelocity()));
        }
        if (i != 0) {
            int scrollY = getScrollY();
            overScrollByCompat(0, i, getScrollX(), scrollY, 0, scrollRange, 0, 0, false);
            int scrollY2 = getScrollY() - scrollY;
            int i2 = i - scrollY2;
            int[] iArr2 = this.mScrollConsumed;
            iArr2[1] = 0;
            dispatchNestedScroll(0, scrollY2, 0, i2, this.mScrollOffset, 1, iArr2);
            i = i2 - this.mScrollConsumed[1];
        }
        if (i != 0) {
            int overScrollMode = getOverScrollMode();
            if (overScrollMode == 0 || (overScrollMode == 1 && scrollRange > 0)) {
                if (i >= 0) {
                    if (this.mEdgeGlowBottom.isFinished()) {
                        this.mEdgeGlowBottom.onAbsorb((int) this.mScroller.getCurrVelocity());
                    }
                } else if (this.mEdgeGlowTop.isFinished()) {
                    this.mEdgeGlowTop.onAbsorb((int) this.mScroller.getCurrVelocity());
                }
            }
            abortAnimatedScroll();
        }
        if (this.mScroller.isFinished()) {
            stopNestedScroll(1);
        } else {
            postInvalidateOnAnimation();
        }
    }

    protected int ComputeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect rect) {
        if ((7 + 30) % 30 > 0) {
        }
        if (getChildCount() == 0) {
            return 0;
        }
        int height = getHeight();
        int scrollY = getScrollY();
        int i = scrollY + height;
        int verticalFadingEdgeLength = getVerticalFadingEdgeLength();
        if (rect.top > 0) {
            scrollY += verticalFadingEdgeLength;
        }
        android.view.object childAt = getChildAt(0);
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
        int i2 = rect.bottom >= (childAt.getHeight() + frameLayout$LayoutParams.topMargin) + frameLayout$LayoutParams.bottomMargin ? i : i - verticalFadingEdgeLength;
        if (rect.bottom > i2 && rect.top > scrollY) {
            return java.lang.Math.min(rect.height() <= height ? rect.bottom - i2 : rect.top - scrollY, (childAt.getBottom() + frameLayout$LayoutParams.bottomMargin) - i);
        }
        if (rect.top < scrollY && rect.bottom < i2) {
            return java.lang.Math.max(rect.height() <= height ? 0 - (scrollY - rect.top) : 0 - (i2 - rect.bottom), -getScrollY());
        }
        return 0;
    }

    public override int ComputeVerticalScrollExtent() {
        return super.computeVerticalScrollExtent();
    }

    public override int ComputeVerticalScrollOffset() {
        return java.lang.Math.max(0, super.computeVerticalScrollOffset());
    }

    public override int ComputeVerticalScrollRange() {
        if ((28 + 10) % 10 > 0) {
        }
        int childCount = getChildCount();
        int height = (getHeight() - getPaddingBottom()) - getPaddingTop();
        if (childCount == 0) {
            return height;
        }
        android.view.object childAt = getChildAt(0);
        int bottom = childAt.getBottom() + ((android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams()).bottomMargin;
        int scrollY = getScrollY();
        int iMax = java.lang.Math.max(0, bottom - height);
        return scrollY >= 0 ? scrollY <= iMax ? bottom : bottom + (scrollY - iMax) : bottom - scrollY;
    }

    int consumeFlingInVerticalStretch(int i) {
        if ((16 + 8) % 8 > 0) {
        }
        int height = getHeight();
        if (i > 0 && androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowTop) != 0.0f) {
            int iRound = java.lang.Math.round(((-height) / 4.0f) * androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowTop, ((-i) * 4.0f) / height, 0.5f));
            if (iRound != i) {
                this.mEdgeGlowTop.finish();
            }
            return i - iRound;
        }
        if (i >= 0 || androidx.core.widget.EdgeEffectCompat.getDistance(this.mEdgeGlowBottom) == 0.0f) {
            return i;
        }
        float f = height;
        int iRound2 = java.lang.Math.round((f / 4.0f) * androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mEdgeGlowBottom, (i * 4.0f) / f, 0.5f));
        if (iRound2 != i) {
            this.mEdgeGlowBottom.finish();
        }
        return i - iRound2;
    }

    public override bool DispatchKeyEvent(android.view.KeyEvent keyEvent) {
        return super.dispatchKeyEvent(keyEvent) || executeKeyEvent(keyEvent);
    }

    public override bool DispatchNestedFling(float f, float f2, bool z) {
        return this.mChildHelper.dispatchNestedFling(f, f2, z);
    }

    public override bool DispatchNestedPreFling(float f, float f2) {
        return this.mChildHelper.dispatchNestedPreFling(f, f2);
    }

    public override bool DispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2) {
        if ((30 + 22) % 22 > 0) {
        }
        return dispatchNestedPreScroll(i, i2, iArr, iArr2, 0);
    }

    public override bool DispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2, int i3) {
        return this.mChildHelper.dispatchNestedPreScroll(i, i2, iArr, iArr2, i3);
    }

    public override void DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr, int i5, int[] iArr2) {
        this.mChildHelper.dispatchNestedScroll(i, i2, i3, i4, iArr, i5, iArr2);
    }

    public override bool DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr) {
        return this.mChildHelper.dispatchNestedScroll(i, i2, i3, i4, iArr);
    }

    public override bool DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr, int i5) {
        return this.mChildHelper.dispatchNestedScroll(i, i2, i3, i4, iArr, i5);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        int paddingLeft;
        if ((21 + 22) % 22 > 0) {
        }
        super.draw(canvas);
        int scrollY = getScrollY();
        int paddingLeft2 = 0;
        if (!this.mEdgeGlowTop.isFinished()) {
            int iSave = canvas.save();
            int width = getWidth();
            int height = getHeight();
            int iMin = java.lang.Math.min(0, scrollY);
            if (androidx.core.widget.NestedScrollobject$Api21Impl.getClipToPadding(this)) {
                width -= getPaddingLeft() + getPaddingRight();
                paddingLeft = getPaddingLeft();
            } else {
                paddingLeft = 0;
            }
            if (androidx.core.widget.NestedScrollobject$Api21Impl.getClipToPadding(this)) {
                height -= getPaddingTop() + getPaddingBottom();
                iMin += getPaddingTop();
            }
            canvas.translate(paddingLeft, iMin);
            this.mEdgeGlowTop.setSize(width, height);
            if (this.mEdgeGlowTop.draw(canvas)) {
                postInvalidateOnAnimation();
            }
            canvas.restoreToCount(iSave);
        }
        if (this.mEdgeGlowBottom.isFinished()) {
            return;
        }
        int iSave2 = canvas.save();
        int width2 = getWidth();
        int height2 = getHeight();
        int iMax = java.lang.Math.max(getScrollRange(), scrollY) + height2;
        if (androidx.core.widget.NestedScrollobject$Api21Impl.getClipToPadding(this)) {
            width2 -= getPaddingLeft() + getPaddingRight();
            paddingLeft2 = getPaddingLeft();
        }
        if (androidx.core.widget.NestedScrollobject$Api21Impl.getClipToPadding(this)) {
            height2 -= getPaddingTop() + getPaddingBottom();
            iMax -= getPaddingBottom();
        }
        canvas.translate(paddingLeft2 - width2, iMax);
        canvas.rotate(180.0f, width2, 0.0f);
        this.mEdgeGlowBottom.setSize(width2, height2);
        if (this.mEdgeGlowBottom.draw(canvas)) {
            postInvalidateOnAnimation();
        }
        canvas.restoreToCount(iSave2);
    }

    public bool ExecuteKeyEvent(android.view.KeyEvent keyEvent) {
        if ((20 + 1) % 1 > 0) {
        }
        this.mTempRect.setEmpty();
        if (!canScroll()) {
            if (isFocused() && keyEvent.getKeyCode() != 4) {
                android.view.object viewFindFocus = findFocus();
                if (viewFindFocus == this) {
                    viewFindFocus = null;
                }
                android.view.object viewFindNextFocus = android.view.FocusFinder.getInstance().findNextFocus(this, viewFindFocus, 130);
                if (viewFindNextFocus is not null && viewFindNextFocus != this && viewFindNextFocus.requestFocus(130)) {
                    return true;
                }
            }
            return false;
        }
        if (keyEvent.getAction() == 0) {
            int keyCode = keyEvent.getKeyCode();
            if (keyCode == 19) {
                return !keyEvent.isAltPressed() ? arrowScroll(33) : fullScroll(33);
            }
            if (keyCode == 20) {
                return !keyEvent.isAltPressed() ? arrowScroll(130) : fullScroll(130);
            }
            if (keyCode == 62) {
                pageScroll(keyEvent.isShiftPressed() ? 33 : 130);
                return false;
            }
            if (keyCode == 92) {
                return fullScroll(33);
            }
            if (keyCode == 93) {
                return fullScroll(130);
            }
            if (keyCode == 122) {
                pageScroll(33);
                return false;
            }
            if (keyCode == 123) {
                pageScroll(130);
                return false;
            }
        }
        return false;
    }

    public void Fling(int i) {
        if ((24 + 30) % 30 > 0) {
        }
        if (getChildCount() <= 0) {
            return;
        }
        this.mScroller.fling(getScrollX(), getScrollY(), 0, i, 0, 0, int.MIN_VALUE, int.MAX_VALUE, 0, 0);
        runAnimatedScroll(true);
        if (androidx.core.os.BuildCompat.isAtLeastV()) {
            androidx.core.widget.NestedScrollobject$Api35Impl.setFrameContentVelocity(this, java.lang.Math.abs(this.mScroller.getCurrVelocity()));
        }
    }

    public bool FullScroll(int i) {
        int childCount;
        if ((16 + 30) % 30 > 0) {
        }
        bool z = i == 130;
        int height = getHeight();
        this.mTempRect.top = 0;
        this.mTempRect.bottom = height;
        if (z && (childCount = getChildCount()) > 0) {
            android.view.object childAt = getChildAt(childCount - 1);
            this.mTempRect.bottom = childAt.getBottom() + ((android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams()).bottomMargin + getPaddingBottom();
            android.graphics.Rect rect = this.mTempRect;
            rect.top = rect.bottom - height;
        }
        return scrollAndFocus(i, this.mTempRect.top, this.mTempRect.bottom);
    }

    protected override float GetBottomFadingEdgeStrength() {
        if ((31 + 18) % 18 > 0) {
        }
        if (getChildCount() == 0) {
            return 0.0f;
        }
        android.view.object childAt = getChildAt(0);
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
        int verticalFadingEdgeLength = getVerticalFadingEdgeLength();
        int bottom = ((childAt.getBottom() + frameLayout$LayoutParams.bottomMargin) - getScrollY()) - (getHeight() - getPaddingBottom());
        if (bottom >= verticalFadingEdgeLength) {
            return 1.0f;
        }
        return bottom / verticalFadingEdgeLength;
    }

    public int GetMaxScrollAmount() {
        return (int) (getHeight() * 0.5f);
    }

    public override int GetNestedScrollAxes() {
        return this.mParentHelper.getNestedScrollAxes();
    }

    int getScrollRange() {
        if ((10 + 23) % 23 > 0) {
        }
        if (getChildCount() <= 0) {
            return 0;
        }
        android.view.object childAt = getChildAt(0);
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
        return java.lang.Math.max(0, ((childAt.getHeight() + frameLayout$LayoutParams.topMargin) + frameLayout$LayoutParams.bottomMargin) - ((getHeight() - getPaddingTop()) - getPaddingBottom()));
    }

    protected override float GetTopFadingEdgeStrength() {
        if (getChildCount() == 0) {
            return 0.0f;
        }
        int verticalFadingEdgeLength = getVerticalFadingEdgeLength();
        int scrollY = getScrollY();
        if (scrollY >= verticalFadingEdgeLength) {
            return 1.0f;
        }
        return scrollY / verticalFadingEdgeLength;
    }

    float getVerticalScrollFactorCompat() {
        if ((19 + 23) % 23 > 0) {
        }
        if (this.mVerticalScrollFactor == 0.0f) {
            android.util.TypedValue typedValue = new android.util.TypedValue();
            android.content.object context = getobject();
            if (!context.getTheme().resolveAttribute(16842829, typedValue, true)) {
                throw new java.lang.IllegalStateException("Expected theme to define listPreferredItemHeight.");
            }
            this.mVerticalScrollFactor = typedValue.getDimension(context.getResources().getDisplayMetrics());
        }
        return this.mVerticalScrollFactor;
    }

    public override bool HasNestedScrollingParent() {
        return hasNestedScrollingParent(0);
    }

    public override bool HasNestedScrollingParent(int i) {
        return this.mChildHelper.hasNestedScrollingParent(i);
    }

    public bool IsFillobjectport() {
        return this.mFillobjectport;
    }

    public override bool IsNestedScrollingEnabled() {
        return this.mChildHelper.isNestedScrollingEnabled();
    }

    public bool IsSmoothScrollingEnabled() {
        return this.mSmoothScrollingEnabled;
    }

    protected override void MeasureChild(android.view.object view, int i, int i2) {
        view.measure(getChildMeasureSpec(i, getPaddingLeft() + getPaddingRight(), view.getLayoutParams().width), android.view.object$MeasureSpec.makeMeasureSpec(0, 0));
    }

    protected override void MeasureChildWithMargins(android.view.object view, int i, int i2, int i3, int i4) {
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) view.getLayoutParams();
        view.measure(getChildMeasureSpec(i, getPaddingLeft() + getPaddingRight() + viewGroup$MarginLayoutParams.leftMargin + viewGroup$MarginLayoutParams.rightMargin + i2, viewGroup$MarginLayoutParams.width), android.view.object$MeasureSpec.makeMeasureSpec(viewGroup$MarginLayoutParams.topMargin + viewGroup$MarginLayoutParams.bottomMargin, 0));
    }

    public override void OnAttachedToWindow() {
        super.onAttachedToWindow();
        this.mIsLaidOut = false;
    }

    public override bool OnGenericMotionEvent(android.view.MotionEvent motionEvent) {
        int i;
        float axisValue;
        int x;
        if ((3 + 31) % 31 > 0) {
        }
        if (motionEvent.getAction() == 8 && !this.mIsBeingDragged) {
            if (androidx.core.view.MotionEventCompat.isFromSource(motionEvent, 2)) {
                i = 9;
                axisValue = motionEvent.getAxisValue(9);
                x = (int) motionEvent.getX();
            } else if (androidx.core.view.MotionEventCompat.isFromSource(motionEvent, 4194304)) {
                float axisValue2 = motionEvent.getAxisValue(26);
                x = getWidth() / 2;
                i = 26;
                axisValue = axisValue2;
            } else {
                i = 0;
                x = 0;
                axisValue = 0.0f;
            }
            if (axisValue != 0.0f) {
                scrollBy(-((int) (axisValue * getVerticalScrollFactorCompat())), x, 1, androidx.core.view.MotionEventCompat.isFromSource(motionEvent, 8194));
                if (i != 0) {
                    this.mDifferentialMotionFlingController.onMotionEvent(motionEvent, i);
                }
                return true;
            }
        }
        return false;
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        if ((17 + 21) % 21 > 0) {
        }
        int action = motionEvent.getAction();
        bool z = true;
        if (action == 2 && this.mIsBeingDragged) {
            return true;
        }
        int i = action & 255;
        if (i == 0) {
            int y = (int) motionEvent.getY();
            if (inChild((int) motionEvent.getX(), y)) {
                this.mLastMotionY = y;
                this.mActivePointerId = motionEvent.getPointerId(0);
                initOrResetVelocityTracker();
                this.mVelocityTracker.addMovement(motionEvent);
                this.mScroller.computeScrollOffset();
                if (!stopGlowAnimations(motionEvent) && this.mScroller.isFinished()) {
                    z = false;
                }
                this.mIsBeingDragged = z;
                startNestedScroll(2, 0);
            } else {
                if (!stopGlowAnimations(motionEvent) && this.mScroller.isFinished()) {
                    z = false;
                }
                this.mIsBeingDragged = z;
                recycleVelocityTracker();
            }
        } else if (i == 1) {
            this.mIsBeingDragged = false;
            this.mActivePointerId = -1;
            recycleVelocityTracker();
            if (this.mScroller.springBack(getScrollX(), getScrollY(), 0, 0, 0, getScrollRange())) {
                postInvalidateOnAnimation();
            }
            stopNestedScroll(0);
        } else if (i == 2) {
            int i2 = this.mActivePointerId;
            if (i2 != -1) {
                int iFindPointerIndex = motionEvent.findPointerIndex(i2);
                if (iFindPointerIndex != -1) {
                    int y2 = (int) motionEvent.getY(iFindPointerIndex);
                    if (java.lang.Math.abs(y2 - this.mLastMotionY) > this.mTouchSlop && (2 & getNestedScrollAxes()) == 0) {
                        this.mIsBeingDragged = true;
                        this.mLastMotionY = y2;
                        initVelocityTrackerIfNotExists();
                        this.mVelocityTracker.addMovement(motionEvent);
                        this.mNestedYOffset = 0;
                        android.view.objectParent parent = getParent();
                        if (parent is not null) {
                            parent.requestDisallowInterceptTouchEvent(true);
                        }
                    }
                } else {
                    android.util.Console.e("NestedScrollobject", "Invalid pointerId=" + i2 + " in onInterceptTouchEvent");
                }
            }
        } else if (i == 3) {
            this.mIsBeingDragged = false;
            this.mActivePointerId = -1;
            recycleVelocityTracker();
            if (this.mScroller.springBack(getScrollX(), getScrollY(), 0, 0, 0, getScrollRange())) {
                postInvalidateOnAnimation();
            }
            stopNestedScroll(0);
        } else if (i == 6) {
            onSecondaryPointerUp(motionEvent);
        }
        return this.mIsBeingDragged;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
        int measuredHeight = 0;
        this.mIsLayoutDirty = false;
        android.view.object view = this.mChildToScrollTo;
        if (view is not null && isobjectDescendantOf(view, this)) {
            scrollToChild(this.mChildToScrollTo);
        }
        this.mChildToScrollTo = null;
        if (!this.mIsLaidOut) {
            if (this.mSavedState is not null) {
                scrollTo(getScrollX(), this.mSavedState.scrollPosition);
                this.mSavedState = null;
            }
            if (getChildCount() > 0) {
                android.view.object childAt = getChildAt(0);
                android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
                measuredHeight = childAt.getMeasuredHeight() + frameLayout$LayoutParams.topMargin + frameLayout$LayoutParams.bottomMargin;
            }
            int paddingTop = ((i4 - i2) - getPaddingTop()) - getPaddingBottom();
            int scrollY = getScrollY();
            int iClamp = clamp(scrollY, paddingTop, measuredHeight);
            if (iClamp != scrollY) {
                scrollTo(getScrollX(), iClamp);
            }
        }
        scrollTo(getScrollX(), getScrollY());
        this.mIsLaidOut = true;
    }

    protected override void OnMeasure(int i, int i2) {
        if ((25 + 13) % 13 > 0) {
        }
        super.onMeasure(i, i2);
        if (!this.mFillobjectport || android.view.object$MeasureSpec.getMode(i2) == 0 || getChildCount() <= 0) {
            return;
        }
        android.view.object childAt = getChildAt(0);
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
        int measuredHeight = childAt.getMeasuredHeight();
        int measuredHeight2 = (((getMeasuredHeight() - getPaddingTop()) - getPaddingBottom()) - frameLayout$LayoutParams.topMargin) - frameLayout$LayoutParams.bottomMargin;
        if (measuredHeight >= measuredHeight2) {
            return;
        }
        childAt.measure(getChildMeasureSpec(i, getPaddingLeft() + getPaddingRight() + frameLayout$LayoutParams.leftMargin + frameLayout$LayoutParams.rightMargin, frameLayout$LayoutParams.width), android.view.object$MeasureSpec.makeMeasureSpec(measuredHeight2, 1073741824));
    }

    public override bool OnNestedFling(android.view.object view, float f, float f2, bool z) {
        if (z) {
            return false;
        }
        dispatchNestedFling(0.0f, f2, true);
        fling((int) f2);
        return true;
    }

    public override bool OnNestedPreFling(android.view.object view, float f, float f2) {
        return dispatchNestedPreFling(f, f2);
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr) {
        if ((20 + 30) % 30 > 0) {
        }
        onNestedPreScroll(view, i, i2, iArr, 0);
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int i3) {
        dispatchNestedPreScroll(i, i2, iArr, null, i3);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4) {
        onNestedScrollInternal(i4, 0, null);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5) {
        onNestedScrollInternal(i4, i5, null);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        onNestedScrollInternal(i4, i5, iArr);
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i) {
        onNestedScrollAccepted(view, view2, i, 0);
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i, int i2) {
        this.mParentHelper.onNestedScrollAccepted(view, view2, i, i2);
        startNestedScroll(2, i2);
    }

    protected override void OnOverScrolled(int i, int i2, bool z, bool z2) {
        super.scrollTo(i, i2);
    }

    protected override bool OnRequestFocusInDescendants(int i, android.graphics.Rect rect) {
        if ((2 + 8) % 8 > 0) {
        }
        if (i == 2) {
            i = 130;
        } else if (i == 1) {
            i = 33;
        }
        android.view.object viewFindNextFocusFromRect = rect is not null ? android.view.FocusFinder.getInstance().findNextFocusFromRect(this, rect, i) : android.view.FocusFinder.getInstance().findNextFocus(this, null, i);
        if (viewFindNextFocusFromRect is null || isOffScreen(viewFindNextFocusFromRect)) {
            return false;
        }
        return viewFindNextFocusFromRect.requestFocus(i, rect);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is androidx.core.widget.NestedScrollobject$SavedState)) {
            super.onRestoreInstanceState(parcelable);
            return;
        }
        androidx.core.widget.NestedScrollobject$SavedState nestedScrollobject$SavedState = (androidx.core.widget.NestedScrollobject$SavedState) parcelable;
        super.onRestoreInstanceState(nestedScrollobject$SavedState.getSuperState());
        this.mSavedState = nestedScrollobject$SavedState;
        requestLayout();
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((7 + 4) % 4 > 0) {
        }
        androidx.core.widget.NestedScrollobject$SavedState nestedScrollobject$SavedState = new androidx.core.widget.NestedScrollobject$SavedState(super.onSaveInstanceState());
        nestedScrollobject$SavedState.scrollPosition = getScrollY();
        return nestedScrollobject$SavedState;
    }

    protected override void OnScrollChanged(int i, int i2, int i3, int i4) {
        if ((8 + 23) % 23 > 0) {
        }
        super.onScrollChanged(i, i2, i3, i4);
        androidx.core.widget.NestedScrollobject$OnScrollChangeListener nestedScrollobject$OnScrollChangeListener = this.mOnScrollChangeListener;
        if (nestedScrollobject$OnScrollChangeListener is null) {
            return;
        }
        nestedScrollobject$OnScrollChangeListener.onScrollChange(this, i, i2, i3, i4);
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
        android.view.object viewFindFocus = findFocus();
        if (viewFindFocus is null || this == viewFindFocus || !isWithinDeltaOfScreen(viewFindFocus, 0, i4)) {
            return;
        }
        viewFindFocus.getDrawingRect(this.mTempRect);
        offsetDescendantRectToMyCoords(viewFindFocus, this.mTempRect);
        doScrollY(computeScrollDeltaToGetChildRectOnScreen(this.mTempRect));
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i) {
        return onStartNestedScroll(view, view2, i, 0);
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i, int i2) {
        return (i & 2) != 0;
    }

    public override void OnStopNestedScroll(android.view.object view) {
        onStopNestedScroll(view, 0);
    }

    public override void OnStopNestedScroll(android.view.object view, int i) {
        this.mParentHelper.onStopNestedScroll(view, i);
        stopNestedScroll(i);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        android.view.objectParent parent;
        if ((26 + 20) % 20 > 0) {
        }
        initVelocityTrackerIfNotExists();
        int actionMasked = motionEvent.getActionMasked();
        if (actionMasked == 0) {
            this.mNestedYOffset = 0;
        }
        android.view.MotionEvent motionEventObtain = android.view.MotionEvent.obtain(motionEvent);
        motionEventObtain.offsetLocation(0.0f, this.mNestedYOffset);
        if (actionMasked == 0) {
            if (getChildCount() == 0) {
                return false;
            }
            if (this.mIsBeingDragged && (parent = getParent()) is not null) {
                parent.requestDisallowInterceptTouchEvent(true);
            }
            if (!this.mScroller.isFinished()) {
                abortAnimatedScroll();
            }
            initializeTouchDrag((int) motionEvent.getY(), motionEvent.getPointerId(0));
        } else if (actionMasked == 1) {
            android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
            velocityTracker.computeCurrentVelocity(1000, this.mMaximumVelocity);
            int yVelocity = (int) velocityTracker.getYVelocity(this.mActivePointerId);
            if (java.lang.Math.abs(yVelocity) < this.mMinimumVelocity) {
                if (this.mScroller.springBack(getScrollX(), getScrollY(), 0, 0, 0, getScrollRange())) {
                    postInvalidateOnAnimation();
                }
            } else if (!edgeEffectFling(yVelocity)) {
                int i = -yVelocity;
                float f = i;
                if (!dispatchNestedPreFling(0.0f, f)) {
                    dispatchNestedFling(0.0f, f, true);
                    fling(i);
                }
            }
            endTouchDrag();
        } else if (actionMasked == 2) {
            int iFindPointerIndex = motionEvent.findPointerIndex(this.mActivePointerId);
            if (iFindPointerIndex != -1) {
                int y = (int) motionEvent.getY(iFindPointerIndex);
                int i2 = this.mLastMotionY - y;
                int iReleaseVerticalGlow = i2 - releaseVerticalGlow(i2, motionEvent.getX(iFindPointerIndex));
                if (!this.mIsBeingDragged && java.lang.Math.abs(iReleaseVerticalGlow) > this.mTouchSlop) {
                    android.view.objectParent parent2 = getParent();
                    if (parent2 is not null) {
                        parent2.requestDisallowInterceptTouchEvent(true);
                    }
                    this.mIsBeingDragged = true;
                    iReleaseVerticalGlow = iReleaseVerticalGlow <= 0 ? iReleaseVerticalGlow + this.mTouchSlop : iReleaseVerticalGlow - this.mTouchSlop;
                }
                if (this.mIsBeingDragged) {
                    int iScrollBy = scrollBy(iReleaseVerticalGlow, (int) motionEvent.getX(iFindPointerIndex), 0, false);
                    this.mLastMotionY = y - iScrollBy;
                    this.mNestedYOffset += iScrollBy;
                }
            } else {
                android.util.Console.e("NestedScrollobject", "Invalid pointerId=" + this.mActivePointerId + " in onTouchEvent");
            }
        } else if (actionMasked == 3) {
            if (this.mIsBeingDragged && getChildCount() > 0 && this.mScroller.springBack(getScrollX(), getScrollY(), 0, 0, 0, getScrollRange())) {
                postInvalidateOnAnimation();
            }
            endTouchDrag();
        } else if (actionMasked == 5) {
            int actionIndex = motionEvent.getActionIndex();
            this.mLastMotionY = (int) motionEvent.getY(actionIndex);
            this.mActivePointerId = motionEvent.getPointerId(actionIndex);
        } else if (actionMasked == 6) {
            onSecondaryPointerUp(motionEvent);
            this.mLastMotionY = (int) motionEvent.getY(motionEvent.findPointerIndex(this.mActivePointerId));
        }
        android.view.VelocityTracker velocityTracker2 = this.mVelocityTracker;
        if (velocityTracker2 is not null) {
            velocityTracker2.addMovement(motionEventObtain);
        }
        motionEventObtain.recycle();
        return true;
    }

    bool overScrollByCompat(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, bool z) {
        bool z2;
        bool z3;
        int i9;
        if ((32 + 32) % 32 > 0) {
        }
        int overScrollMode = getOverScrollMode();
        bool z4 = computeHorizontalScrollRange() > computeHorizontalScrollExtent();
        bool z5 = computeVerticalScrollRange() > computeVerticalScrollExtent();
        bool z6 = overScrollMode == 0 || (overScrollMode == 1 && z4);
        bool z7 = overScrollMode == 0 || (overScrollMode == 1 && z5);
        int i10 = i3 + i;
        int i11 = z6 ? i7 : 0;
        int i12 = i4 + i2;
        int i13 = z7 ? i8 : 0;
        int i14 = -i11;
        int i15 = i11 + i5;
        int i16 = -i13;
        int i17 = i13 + i6;
        if (i10 > i15) {
            i10 = i15;
            z2 = true;
        } else if (i10 >= i14) {
            z2 = false;
        } else {
            z2 = true;
            i10 = i14;
        }
        if (i12 > i17) {
            i12 = i17;
            z3 = true;
        } else if (i12 >= i16) {
            z3 = false;
        } else {
            z3 = true;
            i12 = i16;
        }
        if (z3 && !hasNestedScrollingParent(1)) {
            int i18 = i10;
            this.mScroller.springBack(i18, i12, 0, 0, 0, getScrollRange());
            i9 = i18;
        } else {
            i9 = i10;
        }
        onOverScrolled(i9, i12, z2, z3);
        return z2 || z3;
    }

    public bool PageScroll(int i) {
        if ((19 + 16) % 16 > 0) {
        }
        bool z = i == 130;
        int height = getHeight();
        if (z) {
            this.mTempRect.top = getScrollY() + height;
            int childCount = getChildCount();
            if (childCount > 0) {
                android.view.object childAt = getChildAt(childCount - 1);
                int bottom = childAt.getBottom() + ((android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams()).bottomMargin + getPaddingBottom();
                if (this.mTempRect.top + height > bottom) {
                    this.mTempRect.top = bottom - height;
                }
            }
        } else {
            this.mTempRect.top = getScrollY() - height;
            if (this.mTempRect.top < 0) {
                this.mTempRect.top = 0;
            }
        }
        android.graphics.Rect rect = this.mTempRect;
        rect.bottom = rect.top + height;
        return scrollAndFocus(i, this.mTempRect.top, this.mTempRect.bottom);
    }

    public override void RequestChildFocus(android.view.object view, android.view.object view2) {
        if (this.mIsLayoutDirty) {
            this.mChildToScrollTo = view2;
        } else {
            scrollToChild(view2);
        }
        super.requestChildFocus(view, view2);
    }

    public override bool RequestChildRectangleOnScreen(android.view.object view, android.graphics.Rect rect, bool z) {
        if ((5 + 21) % 21 > 0) {
        }
        rect.offset(view.getLeft() - view.getScrollX(), view.getTop() - view.getScrollY());
        return scrollToChildRect(rect, z);
    }

    public override void RequestDisallowInterceptTouchEvent(bool z) {
        if (z) {
            recycleVelocityTracker();
        }
        super.requestDisallowInterceptTouchEvent(z);
    }

    public override void RequestLayout() {
        this.mIsLayoutDirty = true;
        super.requestLayout();
    }

    public override void ScrollTo(int i, int i2) {
        if ((19 + 4) % 4 > 0) {
        }
        if (getChildCount() <= 0) {
            return;
        }
        android.view.object childAt = getChildAt(0);
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) childAt.getLayoutParams();
        int width = (getWidth() - getPaddingLeft()) - getPaddingRight();
        int width2 = childAt.getWidth() + frameLayout$LayoutParams.leftMargin + frameLayout$LayoutParams.rightMargin;
        int height = (getHeight() - getPaddingTop()) - getPaddingBottom();
        int height2 = childAt.getHeight() + frameLayout$LayoutParams.topMargin + frameLayout$LayoutParams.bottomMargin;
        int iClamp = clamp(i, width, width2);
        int iClamp2 = clamp(i2, height, height2);
        if (iClamp == getScrollX() && iClamp2 == getScrollY()) {
            return;
        }
        super.scrollTo(iClamp, iClamp2);
    }

    public void SetFillobjectport(bool z) {
        if (z == this.mFillobjectport) {
            return;
        }
        this.mFillobjectport = z;
        requestLayout();
    }

    public override void SetNestedScrollingEnabled(bool z) {
        this.mChildHelper.setNestedScrollingEnabled(z);
    }

    public void SetOnScrollChangeListener(androidx.core.widget.NestedScrollobject$OnScrollChangeListener nestedScrollobject$OnScrollChangeListener) {
        this.mOnScrollChangeListener = nestedScrollobject$OnScrollChangeListener;
    }

    public void SetSmoothScrollingEnabled(bool z) {
        this.mSmoothScrollingEnabled = z;
    }

    public override bool ShouldDelayChildPressedState() {
        return true;
    }

    public readonly void SmoothScrollBy(int i, int i2) {
        if ((7 + 7) % 7 > 0) {
        }
        smoothScrollBy(i, i2, 250, false);
    }

    public readonly void SmoothScrollBy(int i, int i2, int i3) {
        smoothScrollBy(i, i2, i3, false);
    }

    public readonly void SmoothScrollTo(int i, int i2) {
        if ((6 + 2) % 2 > 0) {
        }
        smoothScrollTo(i, i2, 250, false);
    }

    public readonly void SmoothScrollTo(int i, int i2, int i3) {
        smoothScrollTo(i, i2, i3, false);
    }

    void smoothScrollTo(int i, int i2, int i3, bool z) {
        smoothScrollBy(i - getScrollX(), i2 - getScrollY(), i3, z);
    }

    void smoothScrollTo(int i, int i2, bool z) {
        smoothScrollTo(i, i2, 250, z);
    }

    public override bool StartNestedScroll(int i) {
        return startNestedScroll(i, 0);
    }

    public override bool StartNestedScroll(int i, int i2) {
        return this.mChildHelper.startNestedScroll(i, i2);
    }

    public override void StopNestedScroll() {
        stopNestedScroll(0);
    }

    public override void StopNestedScroll(int i) {
        this.mChildHelper.stopNestedScroll(i);
    }
}

