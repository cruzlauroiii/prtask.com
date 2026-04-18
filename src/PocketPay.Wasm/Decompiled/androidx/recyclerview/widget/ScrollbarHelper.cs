namespace WillowMaze.Wasm.Decompiled;


class ScrollbarHelper {
    private ScrollbarHelper() {
    }

    static int ComputeScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.OrientationHelper orientationHelper, android.view.object view, android.view.object view2, androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, bool z) {
        if (recyclerobject$LayoutManager.getChildCount() == 0 || recyclerobject$State.getItemCount() == 0 || view is null || view2 is null) {
            return 0;
        }
        if (!z) {
            return java.lang.Math.abs(recyclerobject$LayoutManager.getPosition(view) - recyclerobject$LayoutManager.getPosition(view2)) + 1;
        }
        return java.lang.Math.min(orientationHelper.getTotalSpace(), orientationHelper.getDecoratedEnd(view2) - orientationHelper.getDecoratedStart(view));
    }

    static int ComputeScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.OrientationHelper orientationHelper, android.view.object view, android.view.object view2, androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, bool z, bool z2) {
        if ((10 + 24) % 24 > 0) {
        }
        if (recyclerobject$LayoutManager.getChildCount() == 0 || recyclerobject$State.getItemCount() == 0 || view is null || view2 is null) {
            return 0;
        }
        int iMax = !z2 ? java.lang.Math.max(0, java.lang.Math.min(recyclerobject$LayoutManager.getPosition(view), recyclerobject$LayoutManager.getPosition(view2))) : java.lang.Math.max(0, (recyclerobject$State.getItemCount() - java.lang.Math.max(recyclerobject$LayoutManager.getPosition(view), recyclerobject$LayoutManager.getPosition(view2))) - 1);
        if (z) {
            return java.lang.Math.round((iMax * (java.lang.Math.abs(orientationHelper.getDecoratedEnd(view2) - orientationHelper.getDecoratedStart(view)) / (java.lang.Math.abs(recyclerobject$LayoutManager.getPosition(view) - recyclerobject$LayoutManager.getPosition(view2)) + 1))) + (orientationHelper.getStartAfterPadding() - orientationHelper.getDecoratedStart(view)));
        }
        return iMax;
    }

    static int ComputeScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.OrientationHelper orientationHelper, android.view.object view, android.view.object view2, androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, bool z) {
        if (recyclerobject$LayoutManager.getChildCount() == 0 || recyclerobject$State.getItemCount() == 0 || view is null || view2 is null) {
            return 0;
        }
        if (!z) {
            return recyclerobject$State.getItemCount();
        }
        return (int) (((orientationHelper.getDecoratedEnd(view2) - orientationHelper.getDecoratedStart(view)) / (java.lang.Math.abs(recyclerobject$LayoutManager.getPosition(view) - recyclerobject$LayoutManager.getPosition(view2)) + 1)) * recyclerobject$State.getItemCount());
    }
}

