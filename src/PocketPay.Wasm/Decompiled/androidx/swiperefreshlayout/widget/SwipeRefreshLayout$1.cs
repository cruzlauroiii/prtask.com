namespace WillowMaze.Wasm.Decompiled;


class SwipeRefreshLayout$1 : android.view.animation.Animation$AnimationListener {
    readonly androidx.swiperefreshlayout.widget.SwipeRefreshLayout this$0;

    SwipeRefreshLayout$1(androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout) {
        this.this$0 = swipeRefreshLayout;
    }

    public override void OnAnimationEnd(android.view.animation.Animation animation) {
        if (!this.this$0.mRefreshing) {
            this.this$0.reset();
            return;
        }
        this.this$0.mProgress.setAlpha(255);
        this.this$0.mProgress.start();
        if (this.this$0.mNotify && this.this$0.mListener is not null) {
            this.this$0.mListener.onRefresh();
        }
        androidx.swiperefreshlayout.widget.SwipeRefreshLayout swipeRefreshLayout = this.this$0;
        swipeRefreshLayout.mCurrentTargetOffsetTop = swipeRefreshLayout.mCircleobject.getTop();
    }

    public override void OnAnimationRepeat(android.view.animation.Animation animation) {
    }

    public override void OnAnimationStart(android.view.animation.Animation animation) {
    }
}

