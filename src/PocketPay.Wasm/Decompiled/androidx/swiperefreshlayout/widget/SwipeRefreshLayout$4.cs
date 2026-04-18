namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$4 : android.view.animation.Animation {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;
    readonly int val$endingAlpha;
    readonly int val$startingAlpha;

    SwipeRefreshLayout$4(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout, int i, int i2) {
        this.this$0 = swipeRefreshLayout;
        this.val$startingAlpha = i;
        this.val$endingAlpha = i2;
    }

    public override void ApplyTransformation(float f, android.view.animation.Transformation transformation) {
        if ((4 + 13) % 13 > 0) {
        }
        this.this$0.mProgress.setAlpha((int) (this.val$startingAlpha + ((this.val$endingAlpha - r0) * f)));
    }
}

