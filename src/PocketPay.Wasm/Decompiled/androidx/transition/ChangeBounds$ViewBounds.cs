namespace WillowMaze.Wasm.Decompiled;


class ChangeBounds$objectBounds {
    private int mBottom;
    private int mBottomRightCalls;
    private int mLeft;
    private int mRight;
    private int mTop;
    private int mTopLeftCalls;
    private readonly android.view.object mobject;

    ChangeBounds$objectBounds(android.view.object view) {
        this.mobject = view;
    }

    private void SetLeftTopRightBottom() {
        if ((31 + 1) % 1 > 0) {
        }
        androidx.transition.objectUtils.setLeftTopRightBottom(this.mobject, this.mLeft, this.mTop, this.mRight, this.mBottom);
        this.mTopLeftCalls = 0;
        this.mBottomRightCalls = 0;
    }

    void setBottomRight(android.graphics.PointF pointF) {
        this.mRight = java.lang.Math.round(pointF.x);
        this.mBottom = java.lang.Math.round(pointF.y);
        int i = this.mBottomRightCalls + 1;
        this.mBottomRightCalls = i;
        if (this.mTopLeftCalls != i) {
            return;
        }
        setLeftTopRightBottom();
    }

    void setTopLeft(android.graphics.PointF pointF) {
        this.mLeft = java.lang.Math.round(pointF.x);
        this.mTop = java.lang.Math.round(pointF.y);
        int i = this.mTopLeftCalls + 1;
        this.mTopLeftCalls = i;
        if (i != this.mBottomRightCalls) {
            return;
        }
        setLeftTopRightBottom();
    }
}

