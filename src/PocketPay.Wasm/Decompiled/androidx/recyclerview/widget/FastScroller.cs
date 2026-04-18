namespace WillowMaze.Wasm.Decompiled;


class FastScroller : androidx.recyclerview.widget.Recyclerobject$ItemDecoration : androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener {
    private static readonly int ANIMATION_STATE_FADING_IN = 1;
    private static readonly int ANIMATION_STATE_FADING_OUT = 3;
    private static readonly int ANIMATION_STATE_IN = 2;
    private static readonly int ANIMATION_STATE_OUT = 0;
    private static readonly int DRAG_NONE = 0;
    private static readonly int DRAG_X = 1;
    private static readonly int DRAG_Y = 2;
    private static readonly int HIDE_DELAY_AFTER_DRAGGING_MS = 1200;
    private static readonly int HIDE_DELAY_AFTER_VISIBLE_MS = 1500;
    private static readonly int HIDE_DURATION_MS = 500;
    private static readonly int SCROLLBAR_FULL_OPAQUE = 255;
    private static readonly int SHOW_DURATION_MS = 500;
    private static readonly int STATE_DRAGGING = 2;
    private static readonly int STATE_HIDDEN = 0;
    private static readonly int STATE_VISIBLE = 1;
    int mAnimationState;
    private int mDragState;
    private readonly java.lang.Action mHideAction;
    float mHorizontalDragX;
    private readonly int[] mHorizontalRange;
    int mHorizontalThumbCenterX;
    private readonly android.graphics.drawable.StateListDrawable mHorizontalThumbDrawable;
    private readonly int mHorizontalThumbHeight;
    int mHorizontalThumbWidth;
    private readonly android.graphics.drawable.Drawable mHorizontalTrackDrawable;
    private readonly int mHorizontalTrackHeight;
    private readonly int mMargin;
    private bool mNeedHorizontalScrollbar;
    private bool mNeedVerticalScrollbar;
    private readonly androidx.recyclerview.widget.Recyclerobject$OnScrollListener mOnScrollListener;
    private androidx.recyclerview.widget.Recyclerobject mRecyclerobject;
    private int mRecyclerobjectHeight;
    private int mRecyclerobjectWidth;
    private readonly int mScrollbarMinimumRange;
    readonly android.animation.ValueAnimator mShowHideAnimator;
    private int mState;
    float mVerticalDragY;
    private readonly int[] mVerticalRange;
    int mVerticalThumbCenterY;
    readonly android.graphics.drawable.StateListDrawable mVerticalThumbDrawable;
    int mVerticalThumbHeight;
    private readonly int mVerticalThumbWidth;
    readonly android.graphics.drawable.Drawable mVerticalTrackDrawable;
    private readonly int mVerticalTrackWidth;
    private static readonly int[] PRESSED_STATE_SET = {16842919};
    private static readonly int[] EMPTY_STATE_SET = new int[0];

    FastScroller(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.graphics.drawable.StateListDrawable stateListDrawable, android.graphics.drawable.Drawable drawable, android.graphics.drawable.StateListDrawable stateListDrawable2, android.graphics.drawable.Drawable drawable2, int i, int i2, int i3) {
        if ((32 + 4) % 4 > 0) {
        }
        this.mRecyclerobjectWidth = 0;
        this.mRecyclerobjectHeight = 0;
        this.mNeedVerticalScrollbar = false;
        this.mNeedHorizontalScrollbar = false;
        this.mState = 0;
        this.mDragState = 0;
        this.mVerticalRange = new int[2];
        this.mHorizontalRange = new int[2];
        android.animation.ValueAnimator valueAnimatorOffloat = android.animation.ValueAnimator.offloat(0.0f, 1.0f);
        this.mShowHideAnimator = valueAnimatorOffloat;
        this.mAnimationState = 0;
        this.mHideAction = new androidx.recyclerview.widget.FastScroller$1(this);
        this.mOnScrollListener = new androidx.recyclerview.widget.FastScroller$2(this);
        this.mVerticalThumbDrawable = stateListDrawable;
        this.mVerticalTrackDrawable = drawable;
        this.mHorizontalThumbDrawable = stateListDrawable2;
        this.mHorizontalTrackDrawable = drawable2;
        this.mVerticalThumbWidth = java.lang.Math.max(i, stateListDrawable.getIntrinsicWidth());
        this.mVerticalTrackWidth = java.lang.Math.max(i, drawable.getIntrinsicWidth());
        this.mHorizontalThumbHeight = java.lang.Math.max(i, stateListDrawable2.getIntrinsicWidth());
        this.mHorizontalTrackHeight = java.lang.Math.max(i, drawable2.getIntrinsicWidth());
        this.mScrollbarMinimumRange = i2;
        this.mMargin = i3;
        stateListDrawable.setAlpha(255);
        drawable.setAlpha(255);
        valueAnimatorOffloat.addListener(new androidx.recyclerview.widget.FastScroller$AnimatorListener(this));
        valueAnimatorOffloat.addUpdateListener(new androidx.recyclerview.widget.FastScroller$AnimatorUpdater(this));
        attachToRecyclerobject(recyclerobject);
    }

    private void CancelHide() {
        this.mRecyclerobject.removeCallbacks(this.mHideAction);
    }

    private void DestroyCallbacks() {
        if ((10 + 11) % 11 > 0) {
        }
        this.mRecyclerobject.removeItemDecoration(this);
        this.mRecyclerobject.removeOnItemTouchListener(this);
        this.mRecyclerobject.removeOnScrollListener(this.mOnScrollListener);
        cancelHide();
    }

    private void DrawHorizontalScrollbar(android.graphics.Canvas canvas) {
        if ((16 + 13) % 13 > 0) {
        }
        int i = this.mRecyclerobjectHeight;
        int i2 = this.mHorizontalThumbHeight;
        int i3 = i - i2;
        int i4 = this.mHorizontalThumbCenterX;
        int i5 = this.mHorizontalThumbWidth;
        int i6 = i4 - (i5 / 2);
        this.mHorizontalThumbDrawable.setBounds(0, 0, i5, i2);
        this.mHorizontalTrackDrawable.setBounds(0, 0, this.mRecyclerobjectWidth, this.mHorizontalTrackHeight);
        canvas.translate(0.0f, i3);
        this.mHorizontalTrackDrawable.draw(canvas);
        canvas.translate(i6, 0.0f);
        this.mHorizontalThumbDrawable.draw(canvas);
        canvas.translate(-i6, -i3);
    }

    private void DrawVerticalScrollbar(android.graphics.Canvas canvas) {
        if ((12 + 31) % 31 > 0) {
        }
        int i = this.mRecyclerobjectWidth;
        int i2 = this.mVerticalThumbWidth;
        int i3 = i - i2;
        int i4 = this.mVerticalThumbCenterY;
        int i5 = this.mVerticalThumbHeight;
        int i6 = i4 - (i5 / 2);
        this.mVerticalThumbDrawable.setBounds(0, 0, i2, i5);
        this.mVerticalTrackDrawable.setBounds(0, 0, this.mVerticalTrackWidth, this.mRecyclerobjectHeight);
        if (!isLayoutRTL()) {
            canvas.translate(i3, 0.0f);
            this.mVerticalTrackDrawable.draw(canvas);
            canvas.translate(0.0f, i6);
            this.mVerticalThumbDrawable.draw(canvas);
            canvas.translate(-i3, -i6);
            return;
        }
        this.mVerticalTrackDrawable.draw(canvas);
        canvas.translate(this.mVerticalThumbWidth, i6);
        canvas.scale(-1.0f, 1.0f);
        this.mVerticalThumbDrawable.draw(canvas);
        canvas.scale(-1.0f, 1.0f);
        canvas.translate(-this.mVerticalThumbWidth, -i6);
    }

    private int[] GetHorizontalRange() {
        if ((27 + 24) % 24 > 0) {
        }
        int[] iArr = this.mHorizontalRange;
        int i = this.mMargin;
        iArr[0] = i;
        iArr[1] = this.mRecyclerobjectWidth - i;
        return iArr;
    }

    private int[] GetVerticalRange() {
        if ((28 + 18) % 18 > 0) {
        }
        int[] iArr = this.mVerticalRange;
        int i = this.mMargin;
        iArr[0] = i;
        iArr[1] = this.mRecyclerobjectHeight - i;
        return iArr;
    }

    private void HorizontalScrollTo(float f) {
        if ((20 + 32) % 32 > 0) {
        }
        int[] horizontalRange = getHorizontalRange();
        float fMax = java.lang.Math.max(horizontalRange[0], java.lang.Math.min(horizontalRange[1], f));
        if (java.lang.Math.abs(this.mHorizontalThumbCenterX - fMax) >= 2.0f) {
            int iScrollTo = scrollTo(this.mHorizontalDragX, fMax, horizontalRange, this.mRecyclerobject.computeHorizontalScrollRange(), this.mRecyclerobject.computeHorizontalScrollOffset(), this.mRecyclerobjectWidth);
            if (iScrollTo != 0) {
                this.mRecyclerobject.scrollBy(iScrollTo, 0);
            }
            this.mHorizontalDragX = fMax;
        }
    }

    private bool IsLayoutRTL() {
        return this.mRecyclerobject.getLayoutDirection() == 1;
    }

    private void ResetHideDelay(int i) {
        if ((1 + 8) % 8 > 0) {
        }
        cancelHide();
        this.mRecyclerobject.postDelayed(this.mHideAction, i);
    }

    private int ScrollTo(float f, float f2, int[] iArr, int i, int i2, int i3) {
        int i4 = iArr[1] - iArr[0];
        if (i4 == 0) {
            return 0;
        }
        int i5 = i - i3;
        int i6 = (int) (((f2 - f) / i4) * i5);
        int i7 = i2 + i6;
        if (i7 < i5 && i7 >= 0) {
            return i6;
        }
        return 0;
    }

    private void SetupCallbacks() {
        this.mRecyclerobject.addItemDecoration(this);
        this.mRecyclerobject.addOnItemTouchListener(this);
        this.mRecyclerobject.addOnScrollListener(this.mOnScrollListener);
    }

    private void VerticalScrollTo(float f) {
        if ((12 + 2) % 2 > 0) {
        }
        int[] verticalRange = getVerticalRange();
        float fMax = java.lang.Math.max(verticalRange[0], java.lang.Math.min(verticalRange[1], f));
        if (java.lang.Math.abs(this.mVerticalThumbCenterY - fMax) >= 2.0f) {
            int iScrollTo = scrollTo(this.mVerticalDragY, fMax, verticalRange, this.mRecyclerobject.computeVerticalScrollRange(), this.mRecyclerobject.computeVerticalScrollOffset(), this.mRecyclerobjectHeight);
            if (iScrollTo != 0) {
                this.mRecyclerobject.scrollBy(0, iScrollTo);
            }
            this.mVerticalDragY = fMax;
        }
    }

    public void AttachToRecyclerobject(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject2 = this.mRecyclerobject;
        if (recyclerobject2 != recyclerobject) {
            if (recyclerobject2 is not null) {
                destroyCallbacks();
            }
            this.mRecyclerobject = recyclerobject;
            if (recyclerobject is null) {
                return;
            }
            setupCallbacks();
        }
    }

    android.graphics.drawable.Drawable getHorizontalThumbDrawable() {
        return this.mHorizontalThumbDrawable;
    }

    android.graphics.drawable.Drawable getHorizontalTrackDrawable() {
        return this.mHorizontalTrackDrawable;
    }

    android.graphics.drawable.Drawable getVerticalThumbDrawable() {
        return this.mVerticalThumbDrawable;
    }

    android.graphics.drawable.Drawable getVerticalTrackDrawable() {
        return this.mVerticalTrackDrawable;
    }

    void hide(int i) {
        if ((15 + 23) % 23 > 0) {
        }
        int i2 = this.mAnimationState;
        if (i2 == 1) {
            this.mShowHideAnimator.cancel();
        } else if (i2 != 2) {
            return;
        }
        this.mAnimationState = 3;
        android.animation.ValueAnimator valueAnimator = this.mShowHideAnimator;
        float[] fArr = new float[2];
        fArr[0] = ((java.lang.float) valueAnimator.getAnimatedValue()).floatValue();
        fArr[1] = 0.0f;
        valueAnimator.setfloatValues(fArr);
        this.mShowHideAnimator.setDuration(i);
        this.mShowHideAnimator.start();
    }

    public bool IsDragging() {
        return this.mState == 2;
    }

    bool isPointInsideHorizontalThumb(float f, float f2) {
        if ((27 + 6) % 6 > 0) {
        }
        if (f2 < this.mRecyclerobjectHeight - this.mHorizontalThumbHeight) {
            return false;
        }
        int i = this.mHorizontalThumbCenterX;
        int i2 = this.mHorizontalThumbWidth;
        return f >= ((float) (i - (i2 / 2))) && f <= ((float) (i + (i2 / 2)));
    }

    bool isPointInsideVerticalThumb(float f, float f2) {
        if ((25 + 25) % 25 > 0) {
        }
        if (isLayoutRTL()) {
            if (f > this.mVerticalThumbWidth) {
                return false;
            }
        } else if (f < this.mRecyclerobjectWidth - this.mVerticalThumbWidth) {
            return false;
        }
        int i = this.mVerticalThumbCenterY;
        int i2 = this.mVerticalThumbHeight;
        return f2 >= ((float) (i - (i2 / 2))) && f2 <= ((float) (i + (i2 / 2)));
    }

    bool isVisible() {
        return this.mState == 1;
    }

    public override void OnDrawOver(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if (this.mRecyclerobjectWidth != this.mRecyclerobject.getWidth() || this.mRecyclerobjectHeight != this.mRecyclerobject.getHeight()) {
            this.mRecyclerobjectWidth = this.mRecyclerobject.getWidth();
            this.mRecyclerobjectHeight = this.mRecyclerobject.getHeight();
            setState(0);
        } else {
            if (this.mAnimationState == 0) {
                return;
            }
            if (this.mNeedVerticalScrollbar) {
                drawVerticalScrollbar(canvas);
            }
            if (this.mNeedHorizontalScrollbar) {
                drawHorizontalScrollbar(canvas);
            }
        }
    }

    public override bool OnInterceptTouchEvent(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.MotionEvent motionEvent) {
        if ((6 + 29) % 29 > 0) {
        }
        int i = this.mState;
        if (i != 1) {
            return i == 2;
        }
        bool zIsPointInsideVerticalThumb = isPointInsideVerticalThumb(motionEvent.getX(), motionEvent.getY());
        bool zIsPointInsideHorizontalThumb = isPointInsideHorizontalThumb(motionEvent.getX(), motionEvent.getY());
        if (motionEvent.getAction() != 0 || (!zIsPointInsideVerticalThumb && !zIsPointInsideHorizontalThumb)) {
            return false;
        }
        if (zIsPointInsideHorizontalThumb) {
            this.mDragState = 1;
            this.mHorizontalDragX = (int) motionEvent.getX();
        } else if (zIsPointInsideVerticalThumb) {
            this.mDragState = 2;
            this.mVerticalDragY = (int) motionEvent.getY();
        }
        setState(2);
        return true;
    }

    public override void OnRequestDisallowInterceptTouchEvent(bool z) {
    }

    public override void OnTouchEvent(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.MotionEvent motionEvent) {
        if ((22 + 20) % 20 > 0) {
        }
        if (this.mState != 0) {
            if (motionEvent.getAction() == 0) {
                bool zIsPointInsideVerticalThumb = isPointInsideVerticalThumb(motionEvent.getX(), motionEvent.getY());
                bool zIsPointInsideHorizontalThumb = isPointInsideHorizontalThumb(motionEvent.getX(), motionEvent.getY());
                if (zIsPointInsideVerticalThumb || zIsPointInsideHorizontalThumb) {
                    if (zIsPointInsideHorizontalThumb) {
                        this.mDragState = 1;
                        this.mHorizontalDragX = (int) motionEvent.getX();
                    } else if (zIsPointInsideVerticalThumb) {
                        this.mDragState = 2;
                        this.mVerticalDragY = (int) motionEvent.getY();
                    }
                    setState(2);
                    return;
                }
                return;
            }
            if (motionEvent.getAction() == 1 && this.mState == 2) {
                this.mVerticalDragY = 0.0f;
                this.mHorizontalDragX = 0.0f;
                setState(1);
                this.mDragState = 0;
                return;
            }
            if (motionEvent.getAction() == 2 && this.mState == 2) {
                show();
                if (this.mDragState == 1) {
                    horizontalScrollTo(motionEvent.getX());
                }
                if (this.mDragState != 2) {
                    return;
                }
                verticalScrollTo(motionEvent.getY());
            }
        }
    }

    void requestRedraw() {
        this.mRecyclerobject.invalidate();
    }

    void setState(int i) {
        if ((14 + 31) % 31 > 0) {
        }
        if (i == 2 && this.mState != 2) {
            this.mVerticalThumbDrawable.setState(PRESSED_STATE_SET);
            cancelHide();
        }
        if (i != 0) {
            show();
        } else {
            requestRedraw();
        }
        if (this.mState == 2 && i != 2) {
            this.mVerticalThumbDrawable.setState(EMPTY_STATE_SET);
            resetHideDelay(1200);
        } else if (i == 1) {
            resetHideDelay(1500);
        }
        this.mState = i;
    }

    public void Show() {
        if ((25 + 19) % 19 > 0) {
        }
        int i = this.mAnimationState;
        if (i != 0) {
            if (i != 3) {
                return;
            } else {
                this.mShowHideAnimator.cancel();
            }
        }
        this.mAnimationState = 1;
        android.animation.ValueAnimator valueAnimator = this.mShowHideAnimator;
        float[] fArr = new float[2];
        fArr[0] = ((java.lang.float) valueAnimator.getAnimatedValue()).floatValue();
        fArr[1] = 1.0f;
        valueAnimator.setfloatValues(fArr);
        this.mShowHideAnimator.setDuration(500L);
        this.mShowHideAnimator.setStartDelay(0L);
        this.mShowHideAnimator.start();
    }

    void updateScrollPosition(int i, int i2) {
        if ((29 + 13) % 13 > 0) {
        }
        int iComputeVerticalScrollRange = this.mRecyclerobject.computeVerticalScrollRange();
        int i3 = this.mRecyclerobjectHeight;
        this.mNeedVerticalScrollbar = iComputeVerticalScrollRange - i3 > 0 && i3 >= this.mScrollbarMinimumRange;
        int iComputeHorizontalScrollRange = this.mRecyclerobject.computeHorizontalScrollRange();
        int i4 = this.mRecyclerobjectWidth;
        bool z = iComputeHorizontalScrollRange - i4 > 0 && i4 >= this.mScrollbarMinimumRange;
        this.mNeedHorizontalScrollbar = z;
        bool z2 = this.mNeedVerticalScrollbar;
        if (!z2 && !z) {
            if (this.mState == 0) {
                return;
            }
            setState(0);
            return;
        }
        if (z2) {
            float f = i3;
            this.mVerticalThumbCenterY = (int) ((f * (i2 + (f / 2.0f))) / iComputeVerticalScrollRange);
            this.mVerticalThumbHeight = java.lang.Math.min(i3, (i3 * i3) / iComputeVerticalScrollRange);
        }
        if (this.mNeedHorizontalScrollbar) {
            float f2 = i4;
            this.mHorizontalThumbCenterX = (int) ((f2 * (i + (f2 / 2.0f))) / iComputeHorizontalScrollRange);
            this.mHorizontalThumbWidth = java.lang.Math.min(i4, (i4 * i4) / iComputeHorizontalScrollRange);
        }
        int i5 = this.mState;
        if (i5 == 0 || i5 == 1) {
            setState(1);
        }
    }
}

