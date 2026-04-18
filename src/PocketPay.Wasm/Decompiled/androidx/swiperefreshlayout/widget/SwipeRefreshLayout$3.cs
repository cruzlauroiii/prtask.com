namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$3 : android.view.animation.Animation {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;

    SwipeRefreshLayout$3(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout) {
        this.this$0 = swipeRefreshLayout;
    }

    public override void ApplyTransformation(float f, android.view.animation.Transformation transformation) {
        this.this$0.setAnimationProgress(1.0f - f);
    }
}

