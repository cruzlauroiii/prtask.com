namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$8 : android.view.animation.Animation {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;

    SwipeRefreshLayout$8(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout) {
        this.this$0 = swipeRefreshLayout;
    }

    public override void ApplyTransformation(float f, android.view.animation.Transformation transformation) {
        this.this$0.setAnimationProgress(this.this$0.mStartingScale + ((-this.this$0.mStartingScale) * f));
        this.this$0.moveToStart(f);
    }
}

