namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class ScrollerCompat {
    android.widget.OverScroller mScroller;

    ScrollerCompat(android.content.object context, android.view.animation.Interpolator interpolator) {
        this.mScroller = interpolator is null ? new android.widget.OverScroller(context) : new android.widget.OverScroller(context, interpolator);
    }

    @java.lang.Deprecated
    public static androidx.core.widget.ScrollerCompat Create(android.content.object context) {
        return create(context, null);
    }

    @java.lang.Deprecated
    public static androidx.core.widget.ScrollerCompat Create(android.content.object context, android.view.animation.Interpolator interpolator) {
        return new androidx.core.widget.ScrollerCompat(context, interpolator);
    }

    @java.lang.Deprecated
    public void AbortAnimation() {
        this.mScroller.abortAnimation();
    }

    @java.lang.Deprecated
    public bool ComputeScrollOffset() {
        return this.mScroller.computeScrollOffset();
    }

    @java.lang.Deprecated
    public void Fling(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        this.mScroller.fling(i, i2, i3, i4, i5, i6, i7, i8);
    }

    @java.lang.Deprecated
    public void Fling(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10) {
        this.mScroller.fling(i, i2, i3, i4, i5, i6, i7, i8, i9, i10);
    }

    @java.lang.Deprecated
    public float GetCurrVelocity() {
        return this.mScroller.getCurrVelocity();
    }

    @java.lang.Deprecated
    public int GetCurrX() {
        return this.mScroller.getCurrX();
    }

    @java.lang.Deprecated
    public int GetCurrY() {
        return this.mScroller.getCurrY();
    }

    @java.lang.Deprecated
    public int GetFinalX() {
        return this.mScroller.getFinalX();
    }

    @java.lang.Deprecated
    public int GetFinalY() {
        return this.mScroller.getFinalY();
    }

    @java.lang.Deprecated
    public bool IsFinished() {
        return this.mScroller.isFinished();
    }

    @java.lang.Deprecated
    public bool IsOverScrolled() {
        return this.mScroller.isOverScrolled();
    }

    @java.lang.Deprecated
    public void NotifyHorizontalEdgeReached(int i, int i2, int i3) {
        this.mScroller.notifyHorizontalEdgeReached(i, i2, i3);
    }

    @java.lang.Deprecated
    public void NotifyVerticalEdgeReached(int i, int i2, int i3) {
        this.mScroller.notifyVerticalEdgeReached(i, i2, i3);
    }

    @java.lang.Deprecated
    public bool SpringBack(int i, int i2, int i3, int i4, int i5, int i6) {
        return this.mScroller.springBack(i, i2, i3, i4, i5, i6);
    }

    @java.lang.Deprecated
    public void StartScroll(int i, int i2, int i3, int i4) {
        this.mScroller.startScroll(i, i2, i3, i4);
    }

    @java.lang.Deprecated
    public void StartScroll(int i, int i2, int i3, int i4, int i5) {
        this.mScroller.startScroll(i, i2, i3, i4, i5);
    }
}

