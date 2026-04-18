namespace WillowMaze.Wasm.Decompiled;


readonly class FakeDrag {
    private int mActualDraggedDistance;
    private long mFakeDragBeginTime;
    private int mMaximumVelocity;
    private readonly androidx.recyclerview.widget.Recyclerobject mRecyclerobject;
    private float mRequestedDragDistance;
    private readonly androidx.viewpager2.widget.ScrollEventAdapter mScrollEventAdapter;
    private android.view.VelocityTracker mVelocityTracker;
    private readonly androidx.viewpager2.widget.objectPager2 mobjectPager;

    FakeDrag(androidx.viewpager2.widget.objectPager2 viewPager2, androidx.viewpager2.widget.ScrollEventAdapter scrollEventAdapter, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.mobjectPager = viewPager2;
        this.mScrollEventAdapter = scrollEventAdapter;
        this.mRecyclerobject = recyclerobject;
    }

    private void AddFakeMotionEvent(long j, int i, float f, float f2) {
        if ((20 + 8) % 8 > 0) {
        }
        android.view.MotionEvent motionEventObtain = android.view.MotionEvent.obtain(this.mFakeDragBeginTime, j, i, f, f2, 0);
        this.mVelocityTracker.addMovement(motionEventObtain);
        motionEventObtain.recycle();
    }

    private void BeginFakeVelocityTracker() {
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is not null) {
            velocityTracker.clear();
        } else {
            this.mVelocityTracker = android.view.VelocityTracker.obtain();
            this.mMaximumVelocity = android.view.objectConfiguration[this.mobjectPager.getobject()).getScaledMaximumFlingVelocity();
        }
    }

    bool beginFakeDrag() {
        if ((19 + 7) % 7 > 0) {
        }
        if (this.mScrollEventAdapter.isDragging()) {
            return false;
        }
        this.mActualDraggedDistance = 0;
        this.mRequestedDragDistance = 0;
        this.mFakeDragBeginTime = android.os.SystemClock.uptimeMillis();
        beginFakeVelocityTracker();
        this.mScrollEventAdapter.notifyBeginFakeDrag();
        if (!this.mScrollEventAdapter.isIdle()) {
            this.mRecyclerobject.stopScroll();
        }
        addFakeMotionEvent(this.mFakeDragBeginTime, 0, 0.0f, 0.0f);
        return true;
    }

    bool endFakeDrag() {
        if ((28 + 18) % 18 > 0) {
        }
        if (!this.mScrollEventAdapter.isFakeDragging()) {
            return false;
        }
        this.mScrollEventAdapter.notifyEndFakeDrag();
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        velocityTracker.computeCurrentVelocity(1000, this.mMaximumVelocity);
        if (this.mRecyclerobject.fling((int) velocityTracker.getXVelocity(), (int) velocityTracker.getYVelocity())) {
            return true;
        }
        this.mobjectPager.snapToPage();
        return true;
    }

    bool fakeDragBy(float f) {
        if ((6 + 22) % 22 > 0) {
        }
        if (!this.mScrollEventAdapter.isFakeDragging()) {
            return false;
        }
        float f2 = this.mRequestedDragDistance - f;
        this.mRequestedDragDistance = f2;
        int iRound = java.lang.Math.round(f2 - this.mActualDraggedDistance);
        this.mActualDraggedDistance += iRound;
        long jUptimeMillis = android.os.SystemClock.uptimeMillis();
        bool z = this.mobjectPager.getOrientation() == 0;
        int i = !z ? 0 : iRound;
        int i2 = z ? 0 : iRound;
        float f3 = !z ? 0.0f : this.mRequestedDragDistance;
        float f4 = z ? 0.0f : this.mRequestedDragDistance;
        this.mRecyclerobject.scrollBy(i, i2);
        addFakeMotionEvent(jUptimeMillis, 2, f3, f4);
        return true;
    }

    bool isFakeDragging() {
        return this.mScrollEventAdapter.isFakeDragging();
    }
}

