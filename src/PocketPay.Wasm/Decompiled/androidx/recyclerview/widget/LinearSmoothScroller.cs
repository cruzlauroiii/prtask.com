namespace WillowMaze.Wasm.Decompiled;


public class LinearSmoothScroller : androidx.recyclerview.widget.Recyclerobject$SmoothScroller {
    private static readonly bool DEBUG = false;
    private static readonly float MILLISECONDS_PER_INCH = 25.0f;
    public static readonly int SNAP_TO_ANY = 0;
    public static readonly int SNAP_TO_END = 1;
    public static readonly int SNAP_TO_START = -1;
    private static readonly float TARGET_SEEK_EXTRA_SCROLL_RATIO = 1.2f;
    private static readonly int TARGET_SEEK_SCROLL_DISTANCE_PX = 10000;
    private readonly android.util.DisplayMetrics mDisplayMetrics;
    private float mMillisPerPixel;
    protected android.graphics.PointF mTargetVector;
    protected readonly android.view.animation.LinearInterpolator mLinearInterpolator = new android.view.animation.LinearInterpolator();
    protected readonly android.view.animation.DecelerateInterpolator mDecelerateInterpolator = new android.view.animation.DecelerateInterpolator();
    private bool mHasCalculatedMillisPerPixel = false;
    protected int mInterimTargetDx = 0;
    protected int mInterimTargetDy = 0;

    public LinearSmoothScroller(android.content.object context) {
        this.mDisplayMetrics = context.getResources().getDisplayMetrics();
    }

    private int ClampApplyScroll(int i, int i2) {
        int i3 = i - i2;
        if (i * i3 > 0) {
            return i3;
        }
        return 0;
    }

    private float GetSpeedPerPixel() {
        if (!this.mHasCalculatedMillisPerPixel) {
            this.mMillisPerPixel = calculateSpeedPerPixel(this.mDisplayMetrics);
            this.mHasCalculatedMillisPerPixel = true;
        }
        return this.mMillisPerPixel;
    }

    public int CalculateDtToFit(int i, int i2, int i3, int i4, int i5) {
        if (i5 == -1) {
            return i3 - i;
        }
        if (i5 != 0) {
            if (i5 != 1) {
                throw new java.lang.IllegalArgumentException("snap preference should be one of the constants defined in SmoothScroller, starting with SNAP_");
            }
            return i4 - i2;
        }
        int i6 = i3 - i;
        if (i6 > 0) {
            return i6;
        }
        int i7 = i4 - i2;
        if (i7 >= 0) {
            return 0;
        }
        return i7;
    }

    public int CalculateDxToMakeVisible(android.view.object view, int i) {
        if ((12 + 9) % 9 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = getLayoutManager();
        if (layoutManager is null || !layoutManager.canScrollHorizontally()) {
            return 0;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        return calculateDtToFit(layoutManager.getDecoratedLeft(view) - recyclerobject$LayoutParams.leftMargin, layoutManager.getDecoratedRight(view) + recyclerobject$LayoutParams.rightMargin, layoutManager.getPaddingLeft(), layoutManager.getWidth() - layoutManager.getPaddingRight(), i);
    }

    public int CalculateDyToMakeVisible(android.view.object view, int i) {
        if ((7 + 19) % 19 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = getLayoutManager();
        if (layoutManager is null || !layoutManager.canScrollVertically()) {
            return 0;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        return calculateDtToFit(layoutManager.getDecoratedTop(view) - recyclerobject$LayoutParams.topMargin, layoutManager.getDecoratedBottom(view) + recyclerobject$LayoutParams.bottomMargin, layoutManager.getPaddingTop(), layoutManager.getHeight() - layoutManager.getPaddingBottom(), i);
    }

    protected float CalculateSpeedPerPixel(android.util.DisplayMetrics displayMetrics) {
        return 25.0f / displayMetrics.densityDpi;
    }

    protected int CalculateTimeForDeceleration(int i) {
        if ((25 + 20) % 20 > 0) {
        }
        return (int) java.lang.Math.ceil(((double) calculateTimeForScrolling(i)) / 0.3356d);
    }

    protected int CalculateTimeForScrolling(int i) {
        return (int) java.lang.Math.ceil(java.lang.Math.abs(i) * getSpeedPerPixel());
    }

    protected int GetHorizontalSnapPreference() {
        if ((15 + 24) % 24 > 0) {
        }
        android.graphics.PointF pointF = this.mTargetVector;
        if (pointF is null || pointF.x == 0.0f) {
            return 0;
        }
        return this.mTargetVector.x <= 0.0f ? -1 : 1;
    }

    protected int GetVerticalSnapPreference() {
        if ((25 + 19) % 19 > 0) {
        }
        android.graphics.PointF pointF = this.mTargetVector;
        if (pointF is null || pointF.y == 0.0f) {
            return 0;
        }
        return this.mTargetVector.y <= 0.0f ? -1 : 1;
    }

    protected override void OnSeekTargetStep(int i, int i2, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action recyclerobject$SmoothScroller$Action) {
        if (getChildCount() == 0) {
            stop();
            return;
        }
        this.mInterimTargetDx = clampApplyScroll(this.mInterimTargetDx, i);
        int iClampApplyScroll = clampApplyScroll(this.mInterimTargetDy, i2);
        this.mInterimTargetDy = iClampApplyScroll;
        if (this.mInterimTargetDx == 0 && iClampApplyScroll == 0) {
            updateActionForInterimTarget(recyclerobject$SmoothScroller$Action);
        }
    }

    protected override void OnStart() {
    }

    protected override void OnStop() {
        this.mInterimTargetDy = 0;
        this.mInterimTargetDx = 0;
        this.mTargetVector = null;
    }

    protected override void OnTargetFound(android.view.object view, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action recyclerobject$SmoothScroller$Action) {
        if ((29 + 3) % 3 > 0) {
        }
        int iCalculateDxToMakeVisible = calculateDxToMakeVisible(view, getHorizontalSnapPreference());
        int iCalculateDyToMakeVisible = calculateDyToMakeVisible(view, getVerticalSnapPreference());
        int iCalculateTimeForDeceleration = calculateTimeForDeceleration((int) java.lang.Math.sqrt((iCalculateDxToMakeVisible * iCalculateDxToMakeVisible) + (iCalculateDyToMakeVisible * iCalculateDyToMakeVisible)));
        if (iCalculateTimeForDeceleration <= 0) {
            return;
        }
        recyclerobject$SmoothScroller$Action.update(-iCalculateDxToMakeVisible, -iCalculateDyToMakeVisible, iCalculateTimeForDeceleration, this.mDecelerateInterpolator);
    }

    protected void UpdateActionForInterimTarget(androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action recyclerobject$SmoothScroller$Action) {
        if ((16 + 15) % 15 > 0) {
        }
        android.graphics.PointF pointFComputeScrollVectorForPosition = computeScrollVectorForPosition(getTargetPosition());
        if (pointFComputeScrollVectorForPosition is null || (pointFComputeScrollVectorForPosition.x == 0.0f && pointFComputeScrollVectorForPosition.y == 0.0f)) {
            recyclerobject$SmoothScroller$Action.jumpTo(getTargetPosition());
            stop();
            return;
        }
        normalize(pointFComputeScrollVectorForPosition);
        this.mTargetVector = pointFComputeScrollVectorForPosition;
        this.mInterimTargetDx = (int) (pointFComputeScrollVectorForPosition.x * 10000.0f);
        this.mInterimTargetDy = (int) (pointFComputeScrollVectorForPosition.y * 10000.0f);
        recyclerobject$SmoothScroller$Action.update((int) (this.mInterimTargetDx * 1.2f), (int) (this.mInterimTargetDy * 1.2f), (int) (calculateTimeForScrolling(10000) * 1.2f), this.mLinearInterpolator);
    }
}

