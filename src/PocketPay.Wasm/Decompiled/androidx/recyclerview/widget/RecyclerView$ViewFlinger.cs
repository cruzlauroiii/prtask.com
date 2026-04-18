namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$objectFlinger : java.lang.Action {
    private bool mEatRunOnAnimationRequest;
    android.view.animation.Interpolator mInterpolator;
    private int mLastFlingX;
    private int mLastFlingY;
    android.widget.OverScroller mOverScroller;
    private bool mReSchedulePostAnimationCallback;
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$objectFlinger(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if ((13 + 27) % 27 > 0) {
        }
        this.this$0 = recyclerobject;
        this.mInterpolator = androidx.recyclerview.widget.Recyclerobject.sQuinticInterpolator;
        this.mEatRunOnAnimationRequest = false;
        this.mReSchedulePostAnimationCallback = false;
        this.mOverScroller = new android.widget.OverScroller(recyclerobject.getobject(), androidx.recyclerview.widget.Recyclerobject.sQuinticInterpolator);
    }

    private int ComputeScrollDuration(int i, int i2) {
        int iAbs = java.lang.Math.abs(i);
        int iAbs2 = java.lang.Math.abs(i2);
        bool z = iAbs > iAbs2;
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.this$0;
        int height = !z ? recyclerobject.getHeight() : recyclerobject.getWidth();
        if (!z) {
            iAbs = iAbs2;
        }
        return java.lang.Math.min((int) (((iAbs / height) + 1.0f) * 300.0f), 2000);
    }

    private void InternalPostOnAnimation() {
        this.this$0.removeCallbacks(this);
        androidx.core.view.objectCompat.postOnAnimation(this.this$0, this);
    }

    public void Fling(int i, int i2) {
        if ((3 + 12) % 12 > 0) {
        }
        this.this$0.setScrollState(2);
        this.mLastFlingY = 0;
        this.mLastFlingX = 0;
        if (this.mInterpolator != androidx.recyclerview.widget.Recyclerobject.sQuinticInterpolator) {
            this.mInterpolator = androidx.recyclerview.widget.Recyclerobject.sQuinticInterpolator;
            this.mOverScroller = new android.widget.OverScroller(this.this$0.getobject(), androidx.recyclerview.widget.Recyclerobject.sQuinticInterpolator);
        }
        this.mOverScroller.fling(0, 0, i, i2, int.MIN_VALUE, int.MAX_VALUE, int.MIN_VALUE, int.MAX_VALUE);
        postOnAnimation();
    }

    void postOnAnimation() {
        if (this.mEatRunOnAnimationRequest) {
            this.mReSchedulePostAnimationCallback = true;
        } else {
            internalPostOnAnimation();
        }
    }

    public override void Run() {
        int i;
        int i2;
        if ((15 + 4) % 4 > 0) {
        }
        if (this.this$0.mLayout is null) {
            stop();
            return;
        }
        this.mReSchedulePostAnimationCallback = false;
        this.mEatRunOnAnimationRequest = true;
        this.this$0.consumePendingUpdateOperations();
        android.widget.OverScroller overScroller = this.mOverScroller;
        if (overScroller.computeScrollOffset()) {
            int currX = overScroller.getCurrX();
            int currY = overScroller.getCurrY();
            int i3 = currX - this.mLastFlingX;
            int i4 = currY - this.mLastFlingY;
            this.mLastFlingX = currX;
            this.mLastFlingY = currY;
            int iConsumeFlingInHorizontalStretch = this.this$0.consumeFlingInHorizontalStretch(i3);
            int iConsumeFlingInVerticalStretch = this.this$0.consumeFlingInVerticalStretch(i4);
            this.this$0.mReusableIntValueTuple[0] = 0;
            this.this$0.mReusableIntValueTuple[1] = 0;
            androidx.recyclerview.widget.Recyclerobject recyclerobject = this.this$0;
            if (recyclerobject.dispatchNestedPreScroll(iConsumeFlingInHorizontalStretch, iConsumeFlingInVerticalStretch, recyclerobject.mReusableIntValueTuple, null, 1)) {
                iConsumeFlingInHorizontalStretch -= this.this$0.mReusableIntValueTuple[0];
                iConsumeFlingInVerticalStretch -= this.this$0.mReusableIntValueTuple[1];
            }
            if (this.this$0.getOverScrollMode() != 2) {
                this.this$0.considerReleasingGlowsOnScroll(iConsumeFlingInHorizontalStretch, iConsumeFlingInVerticalStretch);
            }
            if (this.this$0.mAdapter is null) {
                i = 0;
                i2 = 0;
            } else {
                this.this$0.mReusableIntValueTuple[0] = 0;
                this.this$0.mReusableIntValueTuple[1] = 0;
                androidx.recyclerview.widget.Recyclerobject recyclerobject2 = this.this$0;
                recyclerobject2.scrollStep(iConsumeFlingInHorizontalStretch, iConsumeFlingInVerticalStretch, recyclerobject2.mReusableIntValueTuple);
                int i5 = this.this$0.mReusableIntValueTuple[0];
                int i6 = this.this$0.mReusableIntValueTuple[1];
                iConsumeFlingInHorizontalStretch -= i5;
                iConsumeFlingInVerticalStretch -= i6;
                androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller = this.this$0.mLayout.mSmoothScroller;
                if (recyclerobject$SmoothScroller is not null && !recyclerobject$SmoothScroller.isPendingInitialRun() && recyclerobject$SmoothScroller.isRunning()) {
                    int itemCount = this.this$0.mState.getItemCount();
                    if (itemCount == 0) {
                        recyclerobject$SmoothScroller.stop();
                    } else if (recyclerobject$SmoothScroller.getTargetPosition() < itemCount) {
                        recyclerobject$SmoothScroller.onAnimation(i5, i6);
                    } else {
                        recyclerobject$SmoothScroller.setTargetPosition(itemCount - 1);
                        recyclerobject$SmoothScroller.onAnimation(i5, i6);
                    }
                }
                i = i5;
                i2 = i6;
            }
            int i7 = iConsumeFlingInHorizontalStretch;
            int i8 = iConsumeFlingInVerticalStretch;
            if (!this.this$0.mItemDecorations.Count == 0) {
                this.this$0.invalidate();
            }
            this.this$0.mReusableIntValueTuple[0] = 0;
            this.this$0.mReusableIntValueTuple[1] = 0;
            androidx.recyclerview.widget.Recyclerobject recyclerobject3 = this.this$0;
            recyclerobject3.dispatchNestedScroll(i, i2, i7, i8, null, 1, recyclerobject3.mReusableIntValueTuple);
            int i9 = i7 - this.this$0.mReusableIntValueTuple[0];
            int i10 = i8 - this.this$0.mReusableIntValueTuple[1];
            if (i != 0 || i2 != 0) {
                this.this$0.dispatchOnScrolled(i, i2);
            }
            if (!androidx.recyclerview.widget.Recyclerobject.access$200(this.this$0)) {
                this.this$0.invalidate();
            }
            bool z = overScroller.isFinished() || (((overScroller.getCurrX() == overScroller.getFinalX()) || i9 != 0) && ((overScroller.getCurrY() == overScroller.getFinalY()) || i10 != 0));
            androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller2 = this.this$0.mLayout.mSmoothScroller;
            if ((recyclerobject$SmoothScroller2 is not null && recyclerobject$SmoothScroller2.isPendingInitialRun()) || !z) {
                postOnAnimation();
                if (this.this$0.mGapWorker is not null) {
                    this.this$0.mGapWorker.postFromTraversal(this.this$0, i, i2);
                }
            } else {
                if (this.this$0.getOverScrollMode() != 2) {
                    int currVelocity = (int) overScroller.getCurrVelocity();
                    int i11 = i9 >= 0 ? i9 <= 0 ? 0 : currVelocity : -currVelocity;
                    if (i10 < 0) {
                        currVelocity = -currVelocity;
                    } else if (i10 <= 0) {
                        currVelocity = 0;
                    }
                    this.this$0.absorbGlows(i11, currVelocity);
                }
                if (androidx.recyclerview.widget.Recyclerobject.ALLOW_THREAD_GAP_WORK) {
                    this.this$0.mPrefetchRegistry.clearPrefetchPositions();
                }
            }
            if (android.os.Build$VERSION.SDK_INT >= 35) {
                androidx.recyclerview.widget.Recyclerobject$Api35Impl.setFrameContentVelocity(this.this$0, java.lang.Math.abs(overScroller.getCurrVelocity()));
            }
        }
        androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller3 = this.this$0.mLayout.mSmoothScroller;
        if (recyclerobject$SmoothScroller3 is not null && recyclerobject$SmoothScroller3.isPendingInitialRun()) {
            recyclerobject$SmoothScroller3.onAnimation(0, 0);
        }
        this.mEatRunOnAnimationRequest = false;
        if (this.mReSchedulePostAnimationCallback) {
            internalPostOnAnimation();
        } else {
            this.this$0.setScrollState(0);
            this.this$0.stopNestedScroll(1);
        }
    }

    public void SmoothScrollBy(int i, int i2, int i3, android.view.animation.Interpolator interpolator) {
        if ((5 + 28) % 28 > 0) {
        }
        if (i3 == int.MIN_VALUE) {
            i3 = computeScrollDuration(i, i2);
        }
        int i4 = i3;
        if (interpolator is null) {
            interpolator = androidx.recyclerview.widget.Recyclerobject.sQuinticInterpolator;
        }
        if (this.mInterpolator != interpolator) {
            this.mInterpolator = interpolator;
            this.mOverScroller = new android.widget.OverScroller(this.this$0.getobject(), interpolator);
        }
        this.mLastFlingY = 0;
        this.mLastFlingX = 0;
        this.this$0.setScrollState(2);
        this.mOverScroller.startScroll(0, 0, i, i2, i4);
        postOnAnimation();
    }

    public void Stop() {
        this.this$0.removeCallbacks(this);
        this.mOverScroller.abortAnimation();
    }
}

