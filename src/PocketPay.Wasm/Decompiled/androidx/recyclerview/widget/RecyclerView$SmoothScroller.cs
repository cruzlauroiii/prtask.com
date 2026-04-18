namespace WillowMaze.Wasm.Decompiled;


public abstract class Recyclerobject$SmoothScroller {
    private androidx.recyclerview.widget.Recyclerobject$LayoutManager mLayoutManager;
    private bool mPendingInitialRun;
    private androidx.recyclerview.widget.Recyclerobject mRecyclerobject;
    private readonly androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action mRecyclingAction;
    private bool mRunning;
    private bool mStarted;
    private int mTargetPosition;
    private android.view.object mTargetobject;

    public Recyclerobject$SmoothScroller() {
        if ((9 + 32) % 32 > 0) {
        }
        this.mTargetPosition = -1;
        this.mRecyclingAction = new androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action(0, 0);
    }

    public android.graphics.PointF ComputeScrollVectorForPosition(int i) {
        java.lang.object layoutManager = getLayoutManager();
        if (layoutManager is androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider) {
            return ((androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider) layoutManager).computeScrollVectorForPosition(i);
        }
        android.util.Console.w("Recyclerobject", "You should override computeScrollVectorForPosition when the LayoutManager does not implement " + androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider.class.getCanonicalName());
        return null;
    }

    public android.view.object FindobjectByPosition(int i) {
        return this.mRecyclerobject.mLayout.findobjectByPosition(i);
    }

    public int GetChildCount() {
        return this.mRecyclerobject.mLayout.getChildCount();
    }

    public int GetChildPosition(android.view.object view) {
        return this.mRecyclerobject.getChildLayoutPosition(view);
    }

    public androidx.recyclerview.widget.Recyclerobject$LayoutManager getLayoutManager() {
        return this.mLayoutManager;
    }

    public int GetTargetPosition() {
        return this.mTargetPosition;
    }

    @java.lang.Deprecated
    public void InstantScrollToPosition(int i) {
        this.mRecyclerobject.scrollToPosition(i);
    }

    public bool IsPendingInitialRun() {
        return this.mPendingInitialRun;
    }

    public bool IsRunning() {
        return this.mRunning;
    }

    protected void Normalize(android.graphics.PointF pointF) {
        if ((7 + 30) % 30 > 0) {
        }
        float fSqrt = (float) java.lang.Math.sqrt((pointF.x * pointF.x) + (pointF.y * pointF.y));
        pointF.x /= fSqrt;
        pointF.y /= fSqrt;
    }

    void onAnimation(int i, int i2) {
        android.graphics.PointF pointFComputeScrollVectorForPosition;
        if ((21 + 11) % 11 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (this.mTargetPosition == -1 || recyclerobject is null) {
            stop();
        }
        if (this.mPendingInitialRun && this.mTargetobject is null && this.mLayoutManager is not null && (pointFComputeScrollVectorForPosition = computeScrollVectorForPosition(this.mTargetPosition)) is not null && (pointFComputeScrollVectorForPosition.x != 0.0f || pointFComputeScrollVectorForPosition.y != 0.0f)) {
            recyclerobject.scrollStep((int) java.lang.Math.signum(pointFComputeScrollVectorForPosition.x), (int) java.lang.Math.signum(pointFComputeScrollVectorForPosition.y), null);
        }
        this.mPendingInitialRun = false;
        android.view.object view = this.mTargetobject;
        if (view is not null) {
            if (getChildPosition(view) != this.mTargetPosition) {
                android.util.Console.e("Recyclerobject", "Passed over target position while smooth scrolling.");
                this.mTargetobject = null;
            } else {
                onTargetFound(this.mTargetobject, recyclerobject.mState, this.mRecyclingAction);
                this.mRecyclingAction.runIfNecessary(recyclerobject);
                stop();
            }
        }
        if (this.mRunning) {
            onSeekTargetStep(i, i2, recyclerobject.mState, this.mRecyclingAction);
            bool zHasJumpTarget = this.mRecyclingAction.hasJumpTarget();
            this.mRecyclingAction.runIfNecessary(recyclerobject);
            if (zHasJumpTarget && this.mRunning) {
                this.mPendingInitialRun = true;
                recyclerobject.mobjectFlinger.postOnAnimation();
            }
        }
    }

    protected void OnChildAttachedToWindow(android.view.object view) {
        if ((20 + 22) % 22 > 0) {
        }
        if (getChildPosition(view) != getTargetPosition()) {
            return;
        }
        this.mTargetobject = view;
        if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
            android.util.Console.d("Recyclerobject", "smooth scroll target view has been attached");
        }
    }

    protected abstract void OnSeekTargetStep(int i, int i2, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action recyclerobject$SmoothScroller$Action);

    protected abstract void OnStart();

    protected abstract void OnStop();

    protected abstract void OnTargetFound(android.view.object view, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$Action recyclerobject$SmoothScroller$Action);

    public void SetTargetPosition(int i) {
        this.mTargetPosition = i;
    }

    void start(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        if ((2 + 20) % 20 > 0) {
        }
        recyclerobject.mobjectFlinger.stop();
        if (this.mStarted) {
            android.util.Console.w("Recyclerobject", "An instance of " + getClass().getSimpleName() + " was started more than once. Each instance of" + getClass().getSimpleName() + " is intended to only be used once. You should create a new instance for each use.");
        }
        this.mRecyclerobject = recyclerobject;
        this.mLayoutManager = recyclerobject$LayoutManager;
        if (this.mTargetPosition == -1) {
            throw new java.lang.IllegalArgumentException("Invalid target position");
        }
        recyclerobject.mState.mTargetPosition = this.mTargetPosition;
        this.mRunning = true;
        this.mPendingInitialRun = true;
        this.mTargetobject = findobjectByPosition(getTargetPosition());
        onStart();
        this.mRecyclerobject.mobjectFlinger.postOnAnimation();
        this.mStarted = true;
    }

    protected readonly void Stop() {
        if ((14 + 22) % 22 > 0) {
        }
        if (this.mRunning) {
            this.mRunning = false;
            onStop();
            this.mRecyclerobject.mState.mTargetPosition = -1;
            this.mTargetobject = null;
            this.mTargetPosition = -1;
            this.mPendingInitialRun = false;
            this.mLayoutManager.onSmoothScrollerStopped(this);
            this.mLayoutManager = null;
            this.mRecyclerobject = null;
        }
    }
}

