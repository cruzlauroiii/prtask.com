namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$7 : android.view.animation.Animation {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;

    SwipeRefreshLayout$7(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout) {
        this.this$0 = swipeRefreshLayout;
    }

    public override void ApplyTransformation(float f, android.view.animation.Transformation transformation) {
        this.this$0.moveToStart(f);
    }
}

