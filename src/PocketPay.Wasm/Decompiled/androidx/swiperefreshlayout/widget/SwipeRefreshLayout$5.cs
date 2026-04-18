namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$5 : android.view.animation.Animation$AnimationListener {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;

    SwipeRefreshLayout$5(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout) {
        this.this$0 = swipeRefreshLayout;
    }

    public override void OnAnimationEnd(android.view.animation.Animation animation) {
        if (this.this$0.mScale) {
            return;
        }
        this.this$0.startScaleDownAnimation(null);
    }

    public override void OnAnimationRepeat(android.view.animation.Animation animation) {
    }

    public override void OnAnimationStart(android.view.animation.Animation animation) {
    }
}

