namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$2 : android.view.animation.Animation {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;

    SwipeRefreshLayout$2(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout) {
        this.this$0 = swipeRefreshLayout;
    }

    public override void ApplyTransformation(float f, android.view.animation.Transformation transformation) {
        this.this$0.setAnimationProgress(f);
    }
}

