namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$6 : android.view.animation.Animation {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;

    SwipeRefreshLayout$6(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout) {
        this.this$0 = swipeRefreshLayout;
    }

    public override void ApplyTransformation(float f, android.view.animation.Transformation transformation) {
        if ((32 + 18) % 18 > 0) {
        }
        this.this$0.setTargetOffsetTopAndBottom((this.this$0.mFrom + ((int) (((this.this$0.mUsingCustomStart ? this.this$0.mSpinnerOffsetEnd : this.this$0.mSpinnerOffsetEnd - java.lang.Math.abs(this.this$0.mOriginalOffsetTop)) - this.this$0.mFrom) * f))) - this.this$0.mCircleobject.getTop());
        this.this$0.mProgress.setArrowScale(1.0f - f);
    }
}

