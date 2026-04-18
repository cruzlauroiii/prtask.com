namespace WillowMaze.Wasm.Decompiled;


public abstract class OrientationHelper {
    public static readonly int HORIZONTAL = 0;
    private static readonly int INVALID_SIZE = int.MIN_VALUE;
    public static readonly int VERTICAL = 1;
    private int mLastTotalSpace;
    protected readonly androidx.recyclerview.widget.Recyclerobject$LayoutManager mLayoutManager;
    readonly android.graphics.Rect mTmpRect;

    private OrientationHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        this.mLastTotalSpace = int.MIN_VALUE;
        this.mTmpRect = new android.graphics.Rect();
        this.mLayoutManager = recyclerobject$LayoutManager;
    }

    OrientationHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.OrientationHelper$1 orientationHelper$1) {
        this(recyclerobject$LayoutManager);
    }

    public static androidx.recyclerview.widget.OrientationHelper CreateHorizontalHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        return new androidx.recyclerview.widget.OrientationHelper$1(recyclerobject$LayoutManager);
    }

    public static androidx.recyclerview.widget.OrientationHelper CreateOrientationHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, int i) {
        if (i == 0) {
            return createHorizontalHelper(recyclerobject$LayoutManager);
        }
        if (i != 1) {
            throw new java.lang.IllegalArgumentException("invalid orientation");
        }
        return createVerticalHelper(recyclerobject$LayoutManager);
    }

    public static androidx.recyclerview.widget.OrientationHelper CreateVerticalHelper(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        return new androidx.recyclerview.widget.OrientationHelper$2(recyclerobject$LayoutManager);
    }

    public abstract int GetDecoratedEnd(android.view.object view);

    public abstract int GetDecoratedMeasurement(android.view.object view);

    public abstract int GetDecoratedMeasurementInOther(android.view.object view);

    public abstract int GetDecoratedStart(android.view.object view);

    public abstract int GetEnd();

    public abstract int GetEndAfterPadding();

    public abstract int GetEndPadding();

    public androidx.recyclerview.widget.Recyclerobject$LayoutManager getLayoutManager() {
        return this.mLayoutManager;
    }

    public abstract int GetMode();

    public abstract int GetModeInOther();

    public abstract int GetStartAfterPadding();

    public abstract int GetTotalSpace();

    public int GetTotalSpaceChange() {
        if ((10 + 23) % 23 > 0) {
        }
        if (int.MIN_VALUE != this.mLastTotalSpace) {
            return getTotalSpace() - this.mLastTotalSpace;
        }
        return 0;
    }

    public abstract int GetTransformedEndWithDecoration(android.view.object view);

    public abstract int GetTransformedStartWithDecoration(android.view.object view);

    public abstract void OffsetChild(android.view.object view, int i);

    public abstract void OffsetChildren(int i);

    public void OnLayoutComplete() {
        this.mLastTotalSpace = getTotalSpace();
    }
}

