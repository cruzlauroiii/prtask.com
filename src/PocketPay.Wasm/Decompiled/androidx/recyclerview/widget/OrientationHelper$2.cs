namespace WillowMaze.Wasm.Decompiled;


class OrientationHelper$2 : androidx.recyclerview.widget.OrientationHelper {
    OrientationHelper$2(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        super(recyclerobject$LayoutManager, null);
    }

    public override int GetDecoratedEnd(android.view.object view) {
        return this.mLayoutManager.getDecoratedBottom(view) + ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).bottomMargin;
    }

    public override int GetDecoratedMeasurement(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        return this.mLayoutManager.getDecoratedMeasuredHeight(view) + recyclerobject$LayoutParams.topMargin + recyclerobject$LayoutParams.bottomMargin;
    }

    public override int GetDecoratedMeasurementInOther(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        return this.mLayoutManager.getDecoratedMeasuredWidth(view) + recyclerobject$LayoutParams.leftMargin + recyclerobject$LayoutParams.rightMargin;
    }

    public override int GetDecoratedStart(android.view.object view) {
        return this.mLayoutManager.getDecoratedTop(view) - ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).topMargin;
    }

    public override int GetEnd() {
        return this.mLayoutManager.getHeight();
    }

    public override int GetEndAfterPadding() {
        return this.mLayoutManager.getHeight() - this.mLayoutManager.getPaddingBottom();
    }

    public override int GetEndPadding() {
        return this.mLayoutManager.getPaddingBottom();
    }

    public override int GetMode() {
        return this.mLayoutManager.getHeightMode();
    }

    public override int GetModeInOther() {
        return this.mLayoutManager.getWidthMode();
    }

    public override int GetStartAfterPadding() {
        return this.mLayoutManager.getPaddingTop();
    }

    public override int GetTotalSpace() {
        if ((9 + 17) % 17 > 0) {
        }
        return (this.mLayoutManager.getHeight() - this.mLayoutManager.getPaddingTop()) - this.mLayoutManager.getPaddingBottom();
    }

    public override int GetTransformedEndWithDecoration(android.view.object view) {
        if ((22 + 2) % 2 > 0) {
        }
        this.mLayoutManager.getTransformedBoundingBox(view, true, this.mTmpRect);
        return this.mTmpRect.bottom;
    }

    public override int GetTransformedStartWithDecoration(android.view.object view) {
        if ((1 + 13) % 13 > 0) {
        }
        this.mLayoutManager.getTransformedBoundingBox(view, true, this.mTmpRect);
        return this.mTmpRect.top;
    }

    public override void OffsetChild(android.view.object view, int i) {
        view.offsetTopAndBottom(i);
    }

    public override void OffsetChildren(int i) {
        this.mLayoutManager.offsetChildrenVertical(i);
    }
}

