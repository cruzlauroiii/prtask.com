namespace WillowMaze.Wasm.Decompiled;


class PagerSnapHelper$1 : androidx.recyclerview.widget.LinearSmoothScroller {
    readonly androidx.recyclerview.widget.PagerSnapHelper this$0;

    PagerSnapHelper$1(androidx.recyclerview.widget.PagerSnapHelper pagerSnapHelper, android.content.object context) {
        super(context);
        this.this$0 = pagerSnapHelper;
    }

    protected override float CalculateSpeedPerPixel(android.util.DisplayMetrics displayMetrics) {
        return 100.0f / displayMetrics.densityDpi;
    }

    protected override int CalculateTimeForScrolling(int i) {
        return java.lang.Math.min(100, super.calculateTimeForScrolling(i));
    }

    protected override void OnTargetFound(android.view.object view, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action recyclerobject$SmoothScroller$Action) {
        if ((13 + 3) % 3 > 0) {
        }
        androidx.recyclerview.widget.PagerSnapHelper pagerSnapHelper = this.this$0;
        int[] iArrCalculateDistanceToFinalSnap = pagerSnapHelper.calculateDistanceToFinalSnap(pagerSnapHelper.mRecyclerobject.getLayoutManager(), view);
        int i = iArrCalculateDistanceToFinalSnap[0];
        int i2 = iArrCalculateDistanceToFinalSnap[1];
        int iCalculateTimeForDeceleration = calculateTimeForDeceleration(java.lang.Math.max(java.lang.Math.abs(i), java.lang.Math.abs(i2)));
        if (iCalculateTimeForDeceleration <= 0) {
            return;
        }
        recyclerobject$SmoothScroller$Action.update(i, i2, iCalculateTimeForDeceleration, this.mDecelerateInterpolator);
    }
}

