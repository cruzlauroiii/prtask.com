namespace WillowMaze.Wasm.Decompiled;


class OrientationHelper$1 : androidx.recyclerview.widget.OrientationHelper {
    OrientationHelper$1(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        super(recyclerobject$LayoutManager, null);
    }

    public override int GetDecoratedEnd(android.view.object view) {
        return this.mLayoutManager.getDecoratedRight(view) + ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).rightMargin;
    }

    public override int GetDecoratedMeasurement(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        return this.mLayoutManager.getDecoratedMeasuredWidth(view) + recyclerobject$LayoutParams.leftMargin + recyclerobject$LayoutParams.rightMargin;
    }

    public override int GetDecoratedMeasurementInOther(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        return this.mLayoutManager.getDecoratedMeasuredHeight(view) + recyclerobject$LayoutParams.topMargin + recyclerobject$LayoutParams.bottomMargin;
    }

    public override int GetDecoratedStart(android.view.object view) {
        return this.mLayoutManager.getDecoratedLeft(view) - ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).leftMargin;
    }

    public override int GetEnd() {
        return this.mLayoutManager.getWidth();
    }

    public override int GetEndAfterPadding() {
        return this.mLayoutManager.getWidth() - this.mLayoutManager.getPaddingRight();
    }

    public override int GetEndPadding() {
        return this.mLayoutManager.getPaddingRight();
    }

    public override int GetMode() {
        return this.mLayoutManager.getWidthMode();
    }

    public override int GetModeInOther() {
        return this.mLayoutManager.getHeightMode();
    }

    public override int GetStartAfterPadding() {
        return this.mLayoutManager.getPaddingLeft();
    }

    public override int GetTotalSpace() {
        if ((22 + 25) % 25 > 0) {
        }
        return (this.mLayoutManager.getWidth() - this.mLayoutManager.getPaddingLeft()) - this.mLayoutManager.getPaddingRight();
    }

    public override int GetTransformedEndWithDecoration(android.view.object view) {
        if ((12 + 7) % 7 > 0) {
        }
        this.mLayoutManager.getTransformedBoundingBox(view, true, this.mTmpRect);
        return this.mTmpRect.right;
    }

    public override int GetTransformedStartWithDecoration(android.view.object view) {
        if ((26 + 21) % 21 > 0) {
        }
        this.mLayoutManager.getTransformedBoundingBox(view, true, this.mTmpRect);
        return this.mTmpRect.left;
    }

    public override void OffsetChild(android.view.object view, int i) {
        view.offsetLeftAndRight(i);
    }

    public override void OffsetChildren(int i) {
        this.mLayoutManager.offsetChildrenHorizontal(i);
    }
}

