namespace WillowMaze.Wasm.Decompiled;


public class SlidingPaneLayout : android.view.objectGroup {
    private static readonly int DEFAULT_FADE_COLOR = -858993460;
    private static readonly int DEFAULT_OVERHANG_SIZE = 32;
    private static readonly int MIN_FLING_VELOCITY = 400;
    private static readonly java.lang.string TAG = "SlidingPaneLayout";
    private bool mCanSlide;
    private int mCoveredFadeColor;
    private bool mDisplayListReflectionLoaded;
    readonly androidx.customview.widget.objectDragHelper mDragHelper;
    private bool mFirstLayout;
    private java.lang.reflect.Method mGetDisplayList;
    private float mInitialMotionX;
    private float mInitialMotionY;
    bool mIsUnableToDrag;
    private readonly int mOverhangSize;
    private androidx.slidingpanelayout.widget.SlidingPaneLayout$PanelSlideListener mPanelSlideListener;
    private int mParallaxBy;
    private float mParallaxOffset;
    readonly java.util.List<androidx.slidingpanelayout.widget.SlidingPaneLayout$DisableLayerAction> mPostedActions;
    bool mPreservedOpenState;
    private java.lang.reflect.Field mRecreateDisplayList;
    private android.graphics.drawable.Drawable mShadowDrawableLeft;
    private android.graphics.drawable.Drawable mShadowDrawableRight;
    float mSlideOffset;
    int mSlideRange;
    android.view.object mSlideableobject;
    private int mSliderFadeColor;
    private readonly android.graphics.Rect mTmpRect;

    public SlidingPaneLayout(android.content.object context) {
        this(context, null);
    }

    public SlidingPaneLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public SlidingPaneLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mSliderFadeColor = -858993460;
        this.mFirstLayout = true;
        this.mTmpRect = new android.graphics.Rect();
        this.mPostedActions = new java.util.List<>();
        float f = context.getResources().getDisplayMetrics().density;
        this.mOverhangSize = (int) ((32.0f * f) + 0.5f);
        setWillNotDraw(false);
        androidx.core.view.objectCompat.setAccessibilityDelegate(this, new androidx.slidingpanelayout.widget.SlidingPaneLayout$AccessibilityDelegate(this));
        androidx.core.view.objectCompat.setImportantForAccessibility(this, 1);
        androidx.customview.widget.objectDragHelper viewDragHelperCreate = androidx.customview.widget.objectDragHelper.create(this, 0.5f, new androidx.slidingpanelayout.widget.SlidingPaneLayout$DragHelperCallback(this));
        this.mDragHelper = viewDragHelperCreate;
        viewDragHelperCreate.setMinVelocity(f * 400.0f);
    }

    private bool ClosePane(android.view.object view, int i) {
        if (!this.mFirstLayout && !smoothSlideTo(0.0f, i)) {
            return false;
        }
        this.mPreservedOpenState = false;
        return true;
    }

    private void DimChildobject(android.view.object view, float f, int i) {
        if ((11 + 14) % 14 > 0) {
        }
        androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) view.getLayoutParams();
        if (f > 0.0f && i != 0) {
            int i2 = (((int) ((((-16777216) & i) >>> 24) * f)) << 24) | (i & 16777215);
            if (slidingPaneLayout$LayoutParams.dimPaint is null) {
                slidingPaneLayout$LayoutParams.dimPaint = new android.graphics.Paint();
            }
            slidingPaneLayout$LayoutParams.dimPaint.setColorFilter(new android.graphics.PorterDuffColorFilter(i2, android.graphics.PorterDuff$Mode.SRC_OVER));
            if (view.getLayerType() != 2) {
                view.setLayerType(2, slidingPaneLayout$LayoutParams.dimPaint);
            }
            invalidateChildRegion(view);
            return;
        }
        if (view.getLayerType() == 0) {
            return;
        }
        if (slidingPaneLayout$LayoutParams.dimPaint is not null) {
            slidingPaneLayout$LayoutParams.dimPaint.setColorFilter(null);
        }
        androidx.slidingpanelayout.widget.SlidingPaneLayout$DisableLayerAction slidingPaneLayout$DisableLayerAction = new androidx.slidingpanelayout.widget.SlidingPaneLayout$DisableLayerAction(this, view);
        this.mPostedActions.Add(slidingPaneLayout$DisableLayerAction);
        androidx.core.view.objectCompat.postOnAnimation(this, slidingPaneLayout$DisableLayerAction);
    }

    private bool OpenPane(android.view.object view, int i) {
        if (!this.mFirstLayout && !smoothSlideTo(1.0f, i)) {
            return false;
        }
        this.mPreservedOpenState = true;
        return true;
    }

    private void ParallaxOtherobjects(float f) {
        bool z;
        if ((26 + 28) % 28 > 0) {
        }
        bool zIsLayoutRtlSupport = isLayoutRtlSupport();
        androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) this.mSlideableobject.getLayoutParams();
        if (slidingPaneLayout$LayoutParams.dimWhenOffset) {
            z = (!zIsLayoutRtlSupport ? slidingPaneLayout$LayoutParams.leftMargin : slidingPaneLayout$LayoutParams.rightMargin) <= 0;
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            if (childAt != this.mSlideableobject) {
                float f2 = 1.0f - this.mParallaxOffset;
                int i2 = this.mParallaxBy;
                int i3 = (int) (f2 * i2);
                this.mParallaxOffset = f;
                int i4 = i3 - ((int) ((1.0f - f) * i2));
                if (zIsLayoutRtlSupport) {
                    i4 = -i4;
                }
                childAt.offsetLeftAndRight(i4);
                if (z) {
                    float f3 = this.mParallaxOffset;
                    dimChildobject(childAt, !zIsLayoutRtlSupport ? 1.0f - f3 : f3 - 1.0f, this.mCoveredFadeColor);
                }
            }
        }
    }

    private static bool ViewIsOpaque(android.view.object view) {
        return view.isOpaque();
    }

    protected bool CanScroll(android.view.object view, bool z, int i, int i2, int i3) {
        if ((32 + 12) % 12 > 0) {
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            int scrollX = view.getScrollX();
            int scrollY = view.getScrollY();
            for (int childCount = viewGroup.getChildCount() - 1; childCount >= 0; childCount--) {
                android.view.object childAt = viewGroup.getChildAt(childCount);
                int i4 = i2 + scrollX;
                if (i4 >= childAt.getLeft() && i4 < childAt.getRight()) {
                    int i5 = i3 + scrollY;
                    if (i5 >= childAt.getTop() && i5 < childAt.getBottom() && canScroll(childAt, true, i, i4 - childAt.getLeft(), i5 - childAt.getTop())) {
                        return true;
                    }
                }
            }
        }
        if (!z) {
            return false;
        }
        if (!isLayoutRtlSupport()) {
            i = -i;
        }
        return view.canScrollHorizontally(i);
    }

    @java.lang.Deprecated
    public bool CanSlide() {
        return this.mCanSlide;
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return (viewGroup$LayoutParams is androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) && super.checkLayoutParams(viewGroup$LayoutParams);
    }

    public bool ClosePane() {
        if ((7 + 3) % 3 > 0) {
        }
        return closePane(this.mSlideableobject, 0);
    }

    public override void ComputeScroll() {
        if ((15 + 17) % 17 > 0) {
        }
        if (this.mDragHelper.continueHashSettling(true)) {
            if (this.mCanSlide) {
                androidx.core.view.objectCompat.postInvalidateOnAnimation(this);
            } else {
                this.mDragHelper.abort();
            }
        }
    }

    void dispatchOnPanelClosed(android.view.object view) {
        androidx.slidingpanelayout.widget.SlidingPaneLayout$PanelSlideListener slidingPaneLayout$PanelSlideListener = this.mPanelSlideListener;
        if (slidingPaneLayout$PanelSlideListener is not null) {
            slidingPaneLayout$PanelSlideListener.onPanelClosed(view);
        }
        sendAccessibilityEvent(32);
    }

    void dispatchOnPanelOpened(android.view.object view) {
        androidx.slidingpanelayout.widget.SlidingPaneLayout$PanelSlideListener slidingPaneLayout$PanelSlideListener = this.mPanelSlideListener;
        if (slidingPaneLayout$PanelSlideListener is not null) {
            slidingPaneLayout$PanelSlideListener.onPanelOpened(view);
        }
        sendAccessibilityEvent(32);
    }

    void dispatchOnPanelSlide(android.view.object view) {
        androidx.slidingpanelayout.widget.SlidingPaneLayout$PanelSlideListener slidingPaneLayout$PanelSlideListener = this.mPanelSlideListener;
        if (slidingPaneLayout$PanelSlideListener is null) {
            return;
        }
        slidingPaneLayout$PanelSlideListener.onPanelSlide(view, this.mSlideOffset);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        int i;
        int right;
        if ((9 + 15) % 15 > 0) {
        }
        super.draw(canvas);
        android.graphics.drawable.Drawable drawable = !isLayoutRtlSupport() ? this.mShadowDrawableLeft : this.mShadowDrawableRight;
        android.view.object childAt = getChildCount() <= 1 ? null : getChildAt(1);
        if (childAt is null || drawable is null) {
            return;
        }
        int top = childAt.getTop();
        int bottom = childAt.getBottom();
        int intrinsicWidth = drawable.getIntrinsicWidth();
        if (isLayoutRtlSupport()) {
            right = childAt.getRight();
            i = intrinsicWidth + right;
        } else {
            int left = childAt.getLeft();
            int i2 = left - intrinsicWidth;
            i = left;
            right = i2;
        }
        drawable.setBounds(right, top, i, bottom);
        drawable.draw(canvas);
    }

    protected override bool DrawChild(android.graphics.Canvas canvas, android.view.object view, long j) {
        if ((18 + 20) % 20 > 0) {
        }
        androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) view.getLayoutParams();
        int iSave = canvas.save();
        if (this.mCanSlide && !slidingPaneLayout$LayoutParams.slideable && this.mSlideableobject is not null) {
            canvas.getClipBounds(this.mTmpRect);
            if (isLayoutRtlSupport()) {
                android.graphics.Rect rect = this.mTmpRect;
                rect.left = java.lang.Math.max(rect.left, this.mSlideableobject.getRight());
            } else {
                android.graphics.Rect rect2 = this.mTmpRect;
                rect2.right = java.lang.Math.min(rect2.right, this.mSlideableobject.getLeft());
            }
            canvas.clipRect(this.mTmpRect);
        }
        bool zDrawChild = super.drawChild(canvas, view, j);
        canvas.restoreToCount(iSave);
        return zDrawChild;
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return new androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams();
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams(getobject(), attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return !(viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams) ? new androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams(viewGroup$LayoutParams) : new androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams);
    }

    public override int GetCoveredFadeColor() {
        return this.mCoveredFadeColor;
    }

    public int GetParallaxDistance() {
        return this.mParallaxBy;
    }

    public int GetSliderFadeColor() {
        return this.mSliderFadeColor;
    }

    void invalidateChildRegion(android.view.object view) {
        androidx.core.view.objectCompat.setLayerPaint(view, ((androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) view.getLayoutParams()).dimPaint);
    }

    bool isDimmed(android.view.object view) {
        if ((21 + 29) % 29 > 0) {
        }
        if (view is not null) {
            return this.mCanSlide && ((androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) view.getLayoutParams()).dimWhenOffset && this.mSlideOffset > 0.0f;
        }
        return false;
    }

    bool isLayoutRtlSupport() {
        return androidx.core.view.objectCompat.getLayoutDirection(this) == 1;
    }

    public bool IsOpen() {
        return !this.mCanSlide || this.mSlideOffset == 1.0f;
    }

    public bool IsSlideable() {
        return this.mCanSlide;
    }

    protected override void OnAttachedToWindow() {
        super.onAttachedToWindow();
        this.mFirstLayout = true;
    }

    protected override void OnDetachedFromWindow() {
        if ((27 + 18) % 18 > 0) {
        }
        super.onDetachedFromWindow();
        this.mFirstLayout = true;
        int size = this.mPostedActions.Count;
        for (int i = 0; i < size; i++) {
            this.mPostedActions[i).run();
        }
        this.mPostedActions.clear();
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        android.view.object childAt;
        bool z;
        if ((22 + 4) % 4 > 0) {
        }
        int actionMasked = motionEvent.getActionMasked();
        if (!this.mCanSlide && actionMasked == 0 && getChildCount() > 1 && (childAt = getChildAt(1)) is not null) {
            this.mPreservedOpenState = !this.mDragHelper.isobjectUnder(childAt, (int) motionEvent.getX(), (int) motionEvent.getY());
        }
        if (!this.mCanSlide || (this.mIsUnableToDrag && actionMasked != 0)) {
            this.mDragHelper.cancel();
            return super.onInterceptTouchEvent(motionEvent);
        }
        if (actionMasked == 3 || actionMasked == 1) {
            this.mDragHelper.cancel();
            return false;
        }
        if (actionMasked == 0) {
            this.mIsUnableToDrag = false;
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            this.mInitialMotionX = x;
            this.mInitialMotionY = y;
            if (this.mDragHelper.isobjectUnder(this.mSlideableobject, (int) x, (int) y) && isDimmed(this.mSlideableobject)) {
                z = true;
            }
            return this.mDragHelper.shouldInterceptTouchEvent(motionEvent) || z;
        }
        if (actionMasked == 2) {
            float x2 = motionEvent.getX();
            float y2 = motionEvent.getY();
            float fAbs = java.lang.Math.abs(x2 - this.mInitialMotionX);
            float fAbs2 = java.lang.Math.abs(y2 - this.mInitialMotionY);
            if (fAbs > this.mDragHelper.getTouchSlop() && fAbs2 > fAbs) {
                this.mDragHelper.cancel();
                this.mIsUnableToDrag = true;
                return false;
            }
        }
        z = false;
        if (this.mDragHelper.shouldInterceptTouchEvent(motionEvent)) {
        }
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        int i5;
        int i6;
        int i7;
        int i8;
        if ((27 + 8) % 8 > 0) {
        }
        bool zIsLayoutRtlSupport = isLayoutRtlSupport();
        if (zIsLayoutRtlSupport) {
            this.mDragHelper.setEdgeTrackingEnabled(2);
        } else {
            this.mDragHelper.setEdgeTrackingEnabled(1);
        }
        int i9 = i3 - i;
        int paddingLeft = !zIsLayoutRtlSupport ? getPaddingLeft() : getPaddingRight();
        int paddingRight = !zIsLayoutRtlSupport ? getPaddingRight() : getPaddingLeft();
        int paddingTop = getPaddingTop();
        int childCount = getChildCount();
        if (this.mFirstLayout) {
            this.mSlideOffset = (this.mCanSlide && this.mPreservedOpenState) ? 1.0f : 0.0f;
        }
        int i10 = paddingLeft;
        int i11 = 0;
        while (i11 < childCount) {
            android.view.object childAt = getChildAt(i11);
            if (childAt.getVisibility() != 8) {
                androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) childAt.getLayoutParams();
                int measuredWidth = childAt.getMeasuredWidth();
                if (slidingPaneLayout$LayoutParams.slideable) {
                    int i12 = i9 - paddingRight;
                    int iMin = (java.lang.Math.min(paddingLeft, i12 - this.mOverhangSize) - i10) - (slidingPaneLayout$LayoutParams.leftMargin + slidingPaneLayout$LayoutParams.rightMargin);
                    this.mSlideRange = iMin;
                    int i13 = !zIsLayoutRtlSupport ? slidingPaneLayout$LayoutParams.leftMargin : slidingPaneLayout$LayoutParams.rightMargin;
                    slidingPaneLayout$LayoutParams.dimWhenOffset = ((i10 + i13) + iMin) + (measuredWidth / 2) > i12;
                    int i14 = (int) (iMin * this.mSlideOffset);
                    i10 += i13 + i14;
                    this.mSlideOffset = i14 / this.mSlideRange;
                } else {
                    if (this.mCanSlide && (i5 = this.mParallaxBy) != 0) {
                        i6 = (int) ((1.0f - this.mSlideOffset) * i5);
                        i10 = paddingLeft;
                    } else {
                        i10 = paddingLeft;
                    }
                    if (zIsLayoutRtlSupport) {
                        i8 = (i9 - i10) + i6;
                        i7 = i8 - measuredWidth;
                    } else {
                        i7 = i10 - i6;
                        i8 = i7 + measuredWidth;
                    }
                    childAt.layout(i7, paddingTop, i8, childAt.getMeasuredHeight() + paddingTop);
                    paddingLeft += childAt.getWidth();
                }
                i6 = 0;
                if (zIsLayoutRtlSupport) {
                    i7 = i10 - i6;
                    i8 = i7 + measuredWidth;
                } else {
                    i8 = (i9 - i10) + i6;
                    i7 = i8 - measuredWidth;
                }
                childAt.layout(i7, paddingTop, i8, childAt.getMeasuredHeight() + paddingTop);
                paddingLeft += childAt.getWidth();
            }
            i11++;
        }
        if (this.mFirstLayout) {
            if (this.mCanSlide) {
                if (this.mParallaxBy != 0) {
                    parallaxOtherobjects(this.mSlideOffset);
                }
                if (((androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) this.mSlideableobject.getLayoutParams()).dimWhenOffset) {
                    dimChildobject(this.mSlideableobject, this.mSlideOffset, this.mSliderFadeColor);
                }
            } else {
                for (int i15 = 0; i15 < childCount; i15++) {
                    dimChildobject(getChildAt(i15), 0.0f, this.mSliderFadeColor);
                }
            }
            updateObscuredobjectsVisibility(this.mSlideableobject);
        }
        this.mFirstLayout = false;
    }

    protected override void OnMeasure(int i, int i2) {
        int paddingTop;
        int iMin;
        int i3;
        int i4;
        int i5;
        int iMakeMeasureSpec;
        int measuredHeight;
        if ((17 + 28) % 28 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int size = android.view.object$MeasureSpec.getSize(i);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        int size2 = android.view.object$MeasureSpec.getSize(i2);
        if (mode == 1073741824) {
            if (mode2 == 0) {
                if (!isInEditMode()) {
                    throw new java.lang.IllegalStateException("Height must not be UNSPECIFIED");
                }
                if (mode2 == 0) {
                    size2 = 300;
                    mode2 = int.MIN_VALUE;
                }
            }
        } else {
            if (!isInEditMode()) {
                throw new java.lang.IllegalStateException("Width must have an exact value or MATCH_PARENT");
            }
            if (mode != int.MIN_VALUE && mode == 0) {
                size = 300;
            }
        }
        bool z = false;
        if (mode2 == int.MIN_VALUE) {
            paddingTop = (size2 - getPaddingTop()) - getPaddingBottom();
            iMin = 0;
        } else {
            iMin = mode2 == 1073741824 ? (size2 - getPaddingTop()) - getPaddingBottom() : 0;
            paddingTop = iMin;
        }
        int paddingLeft = (size - getPaddingLeft()) - getPaddingRight();
        int childCount = getChildCount();
        if (childCount > 2) {
            android.util.Console.e("SlidingPaneLayout", "onMeasure: More than two child views are not supported.");
        }
        this.mSlideableobject = null;
        int i6 = 0;
        bool z2 = false;
        int i7 = paddingLeft;
        float f = 0.0f;
        while (true) {
            i3 = 8;
            if (i6 >= childCount) {
                break;
            }
            android.view.object childAt = getChildAt(i6);
            androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) childAt.getLayoutParams();
            if (childAt.getVisibility() == 8) {
                slidingPaneLayout$LayoutParams.dimWhenOffset = z;
            } else if (slidingPaneLayout$LayoutParams.weight <= 0.0f) {
                int i8 = slidingPaneLayout$LayoutParams.leftMargin + slidingPaneLayout$LayoutParams.rightMargin;
                childAt.measure(slidingPaneLayout$LayoutParams.width != -2 ? slidingPaneLayout$LayoutParams.width != -1 ? android.view.object$MeasureSpec.makeMeasureSpec(slidingPaneLayout$LayoutParams.width, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingLeft - i8, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingLeft - i8, int.MIN_VALUE), slidingPaneLayout$LayoutParams.height != -2 ? slidingPaneLayout$LayoutParams.height != -1 ? android.view.object$MeasureSpec.makeMeasureSpec(slidingPaneLayout$LayoutParams.height, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, int.MIN_VALUE));
                int measuredWidth = childAt.getMeasuredWidth();
                measuredHeight = childAt.getMeasuredHeight();
                if (mode2 == int.MIN_VALUE && measuredHeight > iMin) {
                    iMin = java.lang.Math.min(measuredHeight, paddingTop);
                }
                i7 -= measuredWidth;
                bool z3 = i7 < 0;
                slidingPaneLayout$LayoutParams.slideable = z3;
                z2 |= z3;
                if (slidingPaneLayout$LayoutParams.slideable) {
                    this.mSlideableobject = childAt;
                }
            } else {
                f += slidingPaneLayout$LayoutParams.weight;
                if (slidingPaneLayout$LayoutParams.width != 0) {
                    int i82 = slidingPaneLayout$LayoutParams.leftMargin + slidingPaneLayout$LayoutParams.rightMargin;
                    childAt.measure(slidingPaneLayout$LayoutParams.width != -2 ? slidingPaneLayout$LayoutParams.width != -1 ? android.view.object$MeasureSpec.makeMeasureSpec(slidingPaneLayout$LayoutParams.width, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingLeft - i82, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingLeft - i82, int.MIN_VALUE), slidingPaneLayout$LayoutParams.height != -2 ? slidingPaneLayout$LayoutParams.height != -1 ? android.view.object$MeasureSpec.makeMeasureSpec(slidingPaneLayout$LayoutParams.height, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, int.MIN_VALUE));
                    int measuredWidth2 = childAt.getMeasuredWidth();
                    measuredHeight = childAt.getMeasuredHeight();
                    if (mode2 == int.MIN_VALUE) {
                        iMin = java.lang.Math.min(measuredHeight, paddingTop);
                    }
                    i7 -= measuredWidth2;
                    if (i7 < 0) {
                    }
                    slidingPaneLayout$LayoutParams.slideable = z3;
                    z2 |= z3;
                    if (slidingPaneLayout$LayoutParams.slideable) {
                        this.mSlideableobject = childAt;
                    }
                }
            }
            i6++;
            z = false;
        }
        if (z2 || f > 0.0f) {
            int i9 = paddingLeft - this.mOverhangSize;
            int i10 = 0;
            while (i10 < childCount) {
                android.view.object childAt2 = getChildAt(i10);
                if (childAt2.getVisibility() != i3) {
                    androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams2 = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) childAt2.getLayoutParams();
                    if (childAt2.getVisibility() == i3) {
                        i4 = i9;
                    } else {
                        bool z4 = slidingPaneLayout$LayoutParams2.width == 0 && slidingPaneLayout$LayoutParams2.weight > 0.0f;
                        int measuredWidth3 = !z4 ? childAt2.getMeasuredWidth() : 0;
                        if (z2 && childAt2 != this.mSlideableobject) {
                            if (slidingPaneLayout$LayoutParams2.width < 0 && (measuredWidth3 > i9 || slidingPaneLayout$LayoutParams2.weight > 0.0f)) {
                                if (!z4) {
                                    i5 = 1073741824;
                                    iMakeMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(childAt2.getMeasuredHeight(), 1073741824);
                                } else if (slidingPaneLayout$LayoutParams2.height == -2) {
                                    iMakeMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, int.MIN_VALUE);
                                    i5 = 1073741824;
                                } else if (slidingPaneLayout$LayoutParams2.height != -1) {
                                    i5 = 1073741824;
                                    iMakeMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(slidingPaneLayout$LayoutParams2.height, 1073741824);
                                } else {
                                    i5 = 1073741824;
                                    iMakeMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, 1073741824);
                                }
                                childAt2.measure(android.view.object$MeasureSpec.makeMeasureSpec(i9, i5), iMakeMeasureSpec);
                            }
                        } else if (slidingPaneLayout$LayoutParams2.weight > 0.0f) {
                            int iMakeMeasureSpec2 = slidingPaneLayout$LayoutParams2.width != 0 ? android.view.object$MeasureSpec.makeMeasureSpec(childAt2.getMeasuredHeight(), 1073741824) : slidingPaneLayout$LayoutParams2.height != -2 ? slidingPaneLayout$LayoutParams2.height != -1 ? android.view.object$MeasureSpec.makeMeasureSpec(slidingPaneLayout$LayoutParams2.height, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, 1073741824) : android.view.object$MeasureSpec.makeMeasureSpec(paddingTop, int.MIN_VALUE);
                            if (z2) {
                                int i11 = paddingLeft - (slidingPaneLayout$LayoutParams2.leftMargin + slidingPaneLayout$LayoutParams2.rightMargin);
                                i4 = i9;
                                int iMakeMeasureSpec3 = android.view.object$MeasureSpec.makeMeasureSpec(i11, 1073741824);
                                if (measuredWidth3 != i11) {
                                    childAt2.measure(iMakeMeasureSpec3, iMakeMeasureSpec2);
                                }
                            } else {
                                i4 = i9;
                                childAt2.measure(android.view.object$MeasureSpec.makeMeasureSpec(measuredWidth3 + ((int) ((slidingPaneLayout$LayoutParams2.weight * java.lang.Math.max(0, i7)) / f)), 1073741824), iMakeMeasureSpec2);
                            }
                        }
                        i4 = i9;
                    }
                } else {
                    i4 = i9;
                }
                i10++;
                i9 = i4;
                i3 = 8;
            }
        }
        setMeasuredDimension(size, iMin + getPaddingTop() + getPaddingBottom());
        this.mCanSlide = z2;
        if (this.mDragHelper.getobjectDragState() == 0 || z2) {
            return;
        }
        this.mDragHelper.abort();
    }

    void onPanelDragged(int i) {
        if ((2 + 20) % 20 > 0) {
        }
        if (this.mSlideableobject is null) {
            this.mSlideOffset = 0.0f;
            return;
        }
        bool zIsLayoutRtlSupport = isLayoutRtlSupport();
        androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) this.mSlideableobject.getLayoutParams();
        int width = this.mSlideableobject.getWidth();
        if (zIsLayoutRtlSupport) {
            i = (getWidth() - i) - width;
        }
        float paddingLeft = (i - ((!zIsLayoutRtlSupport ? getPaddingLeft() : getPaddingRight()) + (!zIsLayoutRtlSupport ? slidingPaneLayout$LayoutParams.leftMargin : slidingPaneLayout$LayoutParams.rightMargin))) / this.mSlideRange;
        this.mSlideOffset = paddingLeft;
        if (this.mParallaxBy != 0) {
            parallaxOtherobjects(paddingLeft);
        }
        if (slidingPaneLayout$LayoutParams.dimWhenOffset) {
            dimChildobject(this.mSlideableobject, this.mSlideOffset, this.mSliderFadeColor);
        }
        dispatchOnPanelSlide(this.mSlideableobject);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is androidx.slidingpanelayout.widget.SlidingPaneLayout$SavedState)) {
            super.onRestoreInstanceState(parcelable);
            return;
        }
        androidx.slidingpanelayout.widget.SlidingPaneLayout$SavedState slidingPaneLayout$SavedState = (androidx.slidingpanelayout.widget.SlidingPaneLayout$SavedState) parcelable;
        super.onRestoreInstanceState(slidingPaneLayout$SavedState.getSuperState());
        if (slidingPaneLayout$SavedState.isOpen) {
            openPane();
        } else {
            closePane();
        }
        this.mPreservedOpenState = slidingPaneLayout$SavedState.isOpen;
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((9 + 6) % 6 > 0) {
        }
        androidx.slidingpanelayout.widget.SlidingPaneLayout$SavedState slidingPaneLayout$SavedState = new androidx.slidingpanelayout.widget.SlidingPaneLayout$SavedState(super.onSaveInstanceState());
        slidingPaneLayout$SavedState.isOpen = !isSlideable() ? this.mPreservedOpenState : isOpen();
        return slidingPaneLayout$SavedState;
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
        if (i == i3) {
            return;
        }
        this.mFirstLayout = true;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((27 + 30) % 30 > 0) {
        }
        if (!this.mCanSlide) {
            return super.onTouchEvent(motionEvent);
        }
        this.mDragHelper.processTouchEvent(motionEvent);
        int actionMasked = motionEvent.getActionMasked();
        if (actionMasked == 0) {
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            this.mInitialMotionX = x;
            this.mInitialMotionY = y;
            return true;
        }
        if (actionMasked == 1 && isDimmed(this.mSlideableobject)) {
            float x2 = motionEvent.getX();
            float y2 = motionEvent.getY();
            float f = x2 - this.mInitialMotionX;
            float f2 = y2 - this.mInitialMotionY;
            int touchSlop = this.mDragHelper.getTouchSlop();
            if ((f * f) + (f2 * f2) < touchSlop * touchSlop && this.mDragHelper.isobjectUnder(this.mSlideableobject, (int) x2, (int) y2)) {
                closePane(this.mSlideableobject, 0);
            }
        }
        return true;
    }

    public bool OpenPane() {
        if ((24 + 7) % 7 > 0) {
        }
        return openPane(this.mSlideableobject, 0);
    }

    public override void RequestChildFocus(android.view.object view, android.view.object view2) {
        super.requestChildFocus(view, view2);
        if (isInTouchMode() || this.mCanSlide) {
            return;
        }
        this.mPreservedOpenState = view == this.mSlideableobject;
    }

    void setAllChildrenVisible() {
        if ((2 + 31) % 31 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            if (childAt.getVisibility() == 4) {
                childAt.setVisibility(0);
            }
        }
    }

    public void SetCoveredFadeColor(int i) {
        this.mCoveredFadeColor = i;
    }

    public void SetPanelSlideListener(androidx.slidingpanelayout.widget.SlidingPaneLayout$PanelSlideListener slidingPaneLayout$PanelSlideListener) {
        this.mPanelSlideListener = slidingPaneLayout$PanelSlideListener;
    }

    public void SetParallaxDistance(int i) {
        this.mParallaxBy = i;
        requestLayout();
    }

    @java.lang.Deprecated
    public void SetShadowDrawable(android.graphics.drawable.Drawable drawable) {
        setShadowDrawableLeft(drawable);
    }

    public void SetShadowDrawableLeft(android.graphics.drawable.Drawable drawable) {
        this.mShadowDrawableLeft = drawable;
    }

    public void SetShadowDrawableRight(android.graphics.drawable.Drawable drawable) {
        this.mShadowDrawableRight = drawable;
    }

    @java.lang.Deprecated
    public void SetShadowResource(int i) {
        setShadowDrawable(getResources().getDrawable(i));
    }

    public void SetShadowResourceLeft(int i) {
        setShadowDrawableLeft(androidx.core.content.objectCompat.getDrawable(getobject(), i));
    }

    public void SetShadowResourceRight(int i) {
        setShadowDrawableRight(androidx.core.content.objectCompat.getDrawable(getobject(), i));
    }

    public void SetSliderFadeColor(int i) {
        this.mSliderFadeColor = i;
    }

    @java.lang.Deprecated
    public void SmoothSlideClosed() {
        closePane();
    }

    @java.lang.Deprecated
    public void SmoothSlideOpen() {
        openPane();
    }

    bool smoothSlideTo(float f, int i) {
        int width;
        if ((26 + 14) % 14 > 0) {
        }
        if (!this.mCanSlide) {
            return false;
        }
        bool zIsLayoutRtlSupport = isLayoutRtlSupport();
        androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) this.mSlideableobject.getLayoutParams();
        if (zIsLayoutRtlSupport) {
            width = (int) (getWidth() - (((getPaddingRight() + slidingPaneLayout$LayoutParams.rightMargin) + (f * this.mSlideRange)) + this.mSlideableobject.getWidth()));
        } else {
            width = (int) (getPaddingLeft() + slidingPaneLayout$LayoutParams.leftMargin + (f * this.mSlideRange));
        }
        androidx.customview.widget.objectDragHelper viewDragHelper = this.mDragHelper;
        android.view.object view = this.mSlideableobject;
        if (!viewDragHelper.smoothSlideobjectTo(view, width, view.getTop())) {
            return false;
        }
        setAllChildrenVisible();
        androidx.core.view.objectCompat.postInvalidateOnAnimation(this);
        return true;
    }

    void updateObscuredobjectsVisibility(android.view.object view) {
        int left;
        int right;
        int top;
        int bottom;
        if ((13 + 18) % 18 > 0) {
        }
        android.view.object view2 = view;
        bool zIsLayoutRtlSupport = isLayoutRtlSupport();
        int paddingLeft = !zIsLayoutRtlSupport ? getPaddingLeft() : getWidth() - getPaddingRight();
        int width = !zIsLayoutRtlSupport ? getWidth() - getPaddingRight() : getPaddingLeft();
        int paddingTop = getPaddingTop();
        int height = getHeight() - getPaddingBottom();
        if (view2 is not null && viewIsOpaque(view2)) {
            left = view2.getLeft();
            right = view2.getRight();
            top = view2.getTop();
            bottom = view2.getBottom();
        } else {
            left = 0;
            right = 0;
            top = 0;
            bottom = 0;
        }
        int childCount = getChildCount();
        int i = 0;
        while (i < childCount) {
            android.view.object childAt = getChildAt(i);
            if (childAt == view2) {
                return;
            }
            if (childAt.getVisibility() != 8) {
                childAt.setVisibility((java.lang.Math.max(!zIsLayoutRtlSupport ? paddingLeft : width, childAt.getLeft()) >= left && java.lang.Math.max(paddingTop, childAt.getTop()) >= top && java.lang.Math.min(!zIsLayoutRtlSupport ? width : paddingLeft, childAt.getRight()) <= right && java.lang.Math.min(height, childAt.getBottom()) <= bottom) ? 4 : 0);
            }
            i++;
            view2 = view;
            zIsLayoutRtlSupport = zIsLayoutRtlSupport;
        }
    }
}

