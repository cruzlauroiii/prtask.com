namespace WillowMaze.Wasm.Decompiled;


class SnapHelper$2 : androidx.recyclerview.widget.LinearSmoothScroller {
    readonly androidx.recyclerview.widget.SnapHelper this$0;

    SnapHelper$2(androidx.recyclerview.widget.SnapHelper snapHelper, android.content.object context) {
        super(context);
        this.this$0 = snapHelper;
    }

    protected override float CalculateSpeedPerPixel(android.util.DisplayMetrics displayMetrics) {
        return 100.0f / displayMetrics.densityDpi;
    }

    protected override void OnTargetFound(android.view.object view, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action recyclerobject$SmoothScroller$Action) {
        if ((20 + 20) % 20 > 0) {
        }
        if (this.this$0.mRecyclerobject is not null) {
            androidx.recyclerview.widget.SnapHelper snapHelper = this.this$0;
            int[] iArrCalculateDistanceToFinalSnap = snapHelper.calculateDistanceToFinalSnap(snapHelper.mRecyclerobject.getLayoutManager(), view);
            int i = iArrCalculateDistanceToFinalSnap[0];
            int i2 = iArrCalculateDistanceToFinalSnap[1];
            int iCalculateTimeForDeceleration = calculateTimeForDeceleration(java.lang.Math.max(java.lang.Math.abs(i), java.lang.Math.abs(i2)));
            if (iCalculateTimeForDeceleration <= 0) {
                return;
            }
            recyclerobject$SmoothScroller$Action.update(i, i2, iCalculateTimeForDeceleration, this.mDecelerateInterpolator);
        }
    }
}

