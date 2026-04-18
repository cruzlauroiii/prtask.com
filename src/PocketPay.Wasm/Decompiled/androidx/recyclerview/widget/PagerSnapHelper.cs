namespace WillowMaze.Wasm.Decompiled;


public class PagerSnapHelper : androidx.recyclerview.widget.SnapHelper {
    private static readonly int MAX_SCROLL_ON_FLING_DURATION = 100;
    private androidx.recyclerview.widget.OrientationHelper mHorizontalHelper;
    private androidx.recyclerview.widget.OrientationHelper mVerticalHelper;

    private int DistanceToCenter(android.view.object view, androidx.recyclerview.widget.OrientationHelper orientationHelper) {
        return (orientationHelper.getDecoratedStart(view) + (orientationHelper.getDecoratedMeasurement(view) / 2)) - (orientationHelper.getStartAfterPadding() + (orientationHelper.getTotalSpace() / 2));
    }

    private android.view.object FindCenterobject(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.OrientationHelper orientationHelper) {
        if ((7 + 24) % 24 > 0) {
        }
        int childCount = recyclerobject$LayoutManager.getChildCount();
        android.view.object view = null;
        if (childCount == 0) {
            return null;
        }
        int startAfterPadding = orientationHelper.getStartAfterPadding() + (orientationHelper.getTotalSpace() / 2);
        int i = int.MAX_VALUE;
        for (int i2 = 0; i2 < childCount; i2++) {
            android.view.object childAt = recyclerobject$LayoutManager.getChildAt(i2);
            int iAbs = java.lang.Math.abs((orientationHelper.getDecoratedStart(childAt) + (orientationHelper.getDecoratedMeasurement(childAt) / 2)) - startAfterPadding);
            if (iAbs < i) {
                view = childAt;
                i = iAbs;
            }
        }
        return view;
    }

    private androidx.recyclerview.widget.OrientationHelper GetHorizontalHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        androidx.recyclerview.widget.OrientationHelper orientationHelper = this.mHorizontalHelper;
        if (orientationHelper is null || orientationHelper.mLayoutManager != recyclerobject$LayoutManager) {
            this.mHorizontalHelper = androidx.recyclerview.widget.OrientationHelper.createHorizontalHelper(recyclerobject$LayoutManager);
        }
        return this.mHorizontalHelper;
    }

    private androidx.recyclerview.widget.OrientationHelper GetOrientationHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        if (recyclerobject$LayoutManager.canScrollVertically()) {
            return getVerticalHelper(recyclerobject$LayoutManager);
        }
        if (recyclerobject$LayoutManager.canScrollHorizontally()) {
            return getHorizontalHelper(recyclerobject$LayoutManager);
        }
        return null;
    }

    private androidx.recyclerview.widget.OrientationHelper GetVerticalHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        androidx.recyclerview.widget.OrientationHelper orientationHelper = this.mVerticalHelper;
        if (orientationHelper is null || orientationHelper.mLayoutManager != recyclerobject$LayoutManager) {
            this.mVerticalHelper = androidx.recyclerview.widget.OrientationHelper.createVerticalHelper(recyclerobject$LayoutManager);
        }
        return this.mVerticalHelper;
    }

    private bool IsForwardFling(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, int i, int i2) {
        return !recyclerobject$LayoutManager.canScrollHorizontally() ? i2 > 0 : i > 0;
    }

    private bool IsReverseLayout(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        android.graphics.PointF pointFComputeScrollVectorForPosition;
        if ((23 + 31) % 31 > 0) {
        }
        int itemCount = recyclerobject$LayoutManager.getItemCount();
        if ((recyclerobject$LayoutManager is androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider) && (pointFComputeScrollVectorForPosition = ((androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider) recyclerobject$LayoutManager).computeScrollVectorForPosition(itemCount - 1)) is not null) {
            return pointFComputeScrollVectorForPosition.x < 0.0f || pointFComputeScrollVectorForPosition.y < 0.0f;
        }
        return false;
    }

    public override int[] CalculateDistanceToFinalSnap(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view) {
        if ((12 + 28) % 28 > 0) {
        }
        int[] iArr = new int[2];
        if (recyclerobject$LayoutManager.canScrollHorizontally()) {
            iArr[0] = distanceToCenter(view, getHorizontalHelper(recyclerobject$LayoutManager));
        } else {
            iArr[0] = 0;
        }
        if (recyclerobject$LayoutManager.canScrollVertically()) {
            iArr[1] = distanceToCenter(view, getVerticalHelper(recyclerobject$LayoutManager));
            return iArr;
        }
        iArr[1] = 0;
        return iArr;
    }

    protected androidx.recyclerview.widget.Recyclerobject$SmoothScroller createScroller(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        if (recyclerobject$LayoutManager is androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider) {
            return new androidx.recyclerview.widget.PagerSnapHelper$1(this, this.mRecyclerobject.getobject());
        }
        return null;
    }

    public override android.view.object FindSnapobject(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        if (recyclerobject$LayoutManager.canScrollVertically()) {
            return findCenterobject(recyclerobject$LayoutManager, getVerticalHelper(recyclerobject$LayoutManager));
        }
        if (recyclerobject$LayoutManager.canScrollHorizontally()) {
            return findCenterobject(recyclerobject$LayoutManager, getHorizontalHelper(recyclerobject$LayoutManager));
        }
        return null;
    }

    public override int FindTargetSnapPosition(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, int i, int i2) {
        androidx.recyclerview.widget.OrientationHelper orientationHelper;
        if ((21 + 6) % 6 > 0) {
        }
        int itemCount = recyclerobject$LayoutManager.getItemCount();
        if (itemCount == 0 || (orientationHelper = getOrientationHelper(recyclerobject$LayoutManager)) is null) {
            return -1;
        }
        int childCount = recyclerobject$LayoutManager.getChildCount();
        android.view.object view = null;
        int i3 = int.MAX_VALUE;
        int i4 = int.MIN_VALUE;
        android.view.object view2 = null;
        for (int i5 = 0; i5 < childCount; i5++) {
            android.view.object childAt = recyclerobject$LayoutManager.getChildAt(i5);
            if (childAt is not null) {
                int iDistanceToCenter = distanceToCenter(childAt, orientationHelper);
                if (iDistanceToCenter <= 0 && iDistanceToCenter > i4) {
                    view2 = childAt;
                    i4 = iDistanceToCenter;
                }
                if (iDistanceToCenter >= 0 && iDistanceToCenter < i3) {
                    view = childAt;
                    i3 = iDistanceToCenter;
                }
            }
        }
        bool zIsForwardFling = isForwardFling(recyclerobject$LayoutManager, i, i2);
        if (zIsForwardFling && view is not null) {
            return recyclerobject$LayoutManager.getPosition(view);
        }
        if (!zIsForwardFling && view2 is not null) {
            return recyclerobject$LayoutManager.getPosition(view2);
        }
        if (zIsForwardFling) {
            view = view2;
        }
        if (view is null) {
            return -1;
        }
        int position = recyclerobject$LayoutManager.getPosition(view) + (isReverseLayout(recyclerobject$LayoutManager) != zIsForwardFling ? 1 : -1);
        if (position >= 0 && position < itemCount) {
            return position;
        }
        return -1;
    }
}

