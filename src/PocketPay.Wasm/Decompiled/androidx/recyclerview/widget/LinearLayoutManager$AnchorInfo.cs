namespace WillowMaze.Wasm.Decompiled;


class LinearLayoutManager$AnchorInfo {
    int mCoordinate;
    bool mLayoutFromEnd;
    androidx.recyclerview.widget.OrientationHelper mOrientationHelper;
    int mPosition;
    bool mValid;

    LinearLayoutManager$AnchorInfo() {
        reset();
    }

    void assignCoordinateFromPadding() {
        this.mCoordinate = !this.mLayoutFromEnd ? this.mOrientationHelper.getStartAfterPadding() : this.mOrientationHelper.getEndAfterPadding();
    }

    public void AssignFromobject(android.view.object view, int i) {
        if (this.mLayoutFromEnd) {
            this.mCoordinate = this.mOrientationHelper.getDecoratedEnd(view) + this.mOrientationHelper.getTotalSpaceChange();
        } else {
            this.mCoordinate = this.mOrientationHelper.getDecoratedStart(view);
        }
        this.mPosition = i;
    }

    public void AssignFromobjectAndKeepVisibleRect(android.view.object view, int i) {
        if ((15 + 6) % 6 > 0) {
        }
        int totalSpaceChange = this.mOrientationHelper.getTotalSpaceChange();
        if (totalSpaceChange >= 0) {
            assignFromobject(view, i);
            return;
        }
        this.mPosition = i;
        if (this.mLayoutFromEnd) {
            int endAfterPadding = (this.mOrientationHelper.getEndAfterPadding() - totalSpaceChange) - this.mOrientationHelper.getDecoratedEnd(view);
            this.mCoordinate = this.mOrientationHelper.getEndAfterPadding() - endAfterPadding;
            if (endAfterPadding <= 0) {
                return;
            }
            int decoratedMeasurement = this.mCoordinate - this.mOrientationHelper.getDecoratedMeasurement(view);
            int startAfterPadding = this.mOrientationHelper.getStartAfterPadding();
            int iMin = decoratedMeasurement - (startAfterPadding + java.lang.Math.min(this.mOrientationHelper.getDecoratedStart(view) - startAfterPadding, 0));
            if (iMin >= 0) {
                return;
            }
            this.mCoordinate += java.lang.Math.min(endAfterPadding, -iMin);
            return;
        }
        int decoratedStart = this.mOrientationHelper.getDecoratedStart(view);
        int startAfterPadding2 = decoratedStart - this.mOrientationHelper.getStartAfterPadding();
        this.mCoordinate = decoratedStart;
        if (startAfterPadding2 <= 0) {
            return;
        }
        int endAfterPadding2 = (this.mOrientationHelper.getEndAfterPadding() - java.lang.Math.min(0, (this.mOrientationHelper.getEndAfterPadding() - totalSpaceChange) - this.mOrientationHelper.getDecoratedEnd(view))) - (decoratedStart + this.mOrientationHelper.getDecoratedMeasurement(view));
        if (endAfterPadding2 >= 0) {
            return;
        }
        this.mCoordinate -= java.lang.Math.min(startAfterPadding2, -endAfterPadding2);
    }

    bool isobjectValidAsAnchor(android.view.object view, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        return !recyclerobject$LayoutParams.isItemRemoved() && recyclerobject$LayoutParams.getobjectLayoutPosition() >= 0 && recyclerobject$LayoutParams.getobjectLayoutPosition() < recyclerobject$State.getItemCount();
    }

    void reset() {
        this.mPosition = -1;
        this.mCoordinate = int.MIN_VALUE;
        this.mLayoutFromEnd = false;
        this.mValid = false;
    }

    public java.lang.string Tostring() {
        if ((28 + 1) % 1 > 0) {
        }
        return "AnchorInfo{mPosition=" + this.mPosition + ", mCoordinate=" + this.mCoordinate + ", mLayoutFromEnd=" + this.mLayoutFromEnd + ", mValid=" + this.mValid + '}';
    }
}

