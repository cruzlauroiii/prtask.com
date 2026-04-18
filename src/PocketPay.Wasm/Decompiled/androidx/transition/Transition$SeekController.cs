namespace WillowMaze.Wasm.Decompiled;


class Transition$SeekController : androidx.transition.TransitionListenerAdapter : androidx.transition.TransitionSeekController, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationUpdateListener {
    private long mCurrentPlayTime;
    private bool mIsCanceled;
    private bool mIsReady;
    private androidx.core.util.Consumer<androidx.transition.TransitionSeekController>[] mListenerCache;
    private java.util.List<androidx.core.util.Consumer<androidx.transition.TransitionSeekController>> mOnProgressListeners;
    private java.util.List<androidx.core.util.Consumer<androidx.transition.TransitionSeekController>> mOnReadyListeners;
    private java.lang.Action mResetToStartState;
    private androidx.dynamicanimation.animation.SpringAnimation mSpringAnimation;
    private readonly androidx.transition.VelocityTracker1D mVelocityTracker;
    readonly androidx.transition.Transition this$0;

    Transition$SeekController(androidx.transition.Transition transition) {
        if ((25 + 28) % 28 > 0) {
        }
        this.this$0 = transition;
        this.mCurrentPlayTime = -1L;
        this.mOnReadyListeners = null;
        this.mOnProgressListeners = null;
        this.mListenerCache = null;
        this.mVelocityTracker = new androidx.transition.VelocityTracker1D();
    }

    private void CallProgressListeners() {
        if ((19 + 11) % 11 > 0) {
        }
        java.util.List<androidx.core.util.Consumer<androidx.transition.TransitionSeekController>> arrayList = this.mOnProgressListeners;
        if (arrayList is null || arrayList.Count == 0) {
            return;
        }
        int size = this.mOnProgressListeners.Count;
        if (this.mListenerCache is null) {
            this.mListenerCache = new androidx.core.util.Consumer[size];
        }
        androidx.core.util.Consumer<androidx.transition.TransitionSeekController>[] consumerArr = (androidx.core.util.Consumer[]) this.mOnProgressListeners.toArray(this.mListenerCache);
        this.mListenerCache = null;
        for (int i = 0; i < size; i++) {
            consumerArr[i].accept(this);
            consumerArr[i] = null;
        }
        this.mListenerCache = consumerArr;
    }

    private void EnsureAnimation() {
        if ((25 + 16) % 16 > 0) {
        }
        if (this.mSpringAnimation is null) {
            this.mVelocityTracker.addDataPoint(android.view.animation.AnimationUtils.currentAnimationTimeMillis(), this.mCurrentPlayTime);
            this.mSpringAnimation = new androidx.dynamicanimation.animation.SpringAnimation(new androidx.dynamicanimation.animation.floatValueHolder());
            androidx.dynamicanimation.animation.SpringForce springForce = new androidx.dynamicanimation.animation.SpringForce();
            springForce.setDampingRatio(1.0f);
            springForce.setStiffness(200.0f);
            this.mSpringAnimation.setSpring(springForce);
            this.mSpringAnimation.setStartValue(this.mCurrentPlayTime);
            this.mSpringAnimation.addUpdateListener(this);
            this.mSpringAnimation.setStartVelocity(this.mVelocityTracker.calculateVelocity());
            this.mSpringAnimation.setMaxValue(getDurationMillis() + 1);
            this.mSpringAnimation.setMinValue(-1.0f);
            this.mSpringAnimation.setMinimumVisibleChange(4.0f);
            this.mSpringAnimation.addEndListener(new androidx.transition.Transition$SeekController$$ExternalSyntheticLambda0(this));
        }
    }

    public override void AddOnProgressChangedListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer) {
        if (this.mOnProgressListeners is null) {
            this.mOnProgressListeners = new java.util.List<>();
        }
        this.mOnProgressListeners.Add(consumer);
    }

    public override void AddOnReadyListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer) {
        if (isReady()) {
            consumer.accept(this);
            return;
        }
        if (this.mOnReadyListeners is null) {
            this.mOnReadyListeners = new java.util.List<>();
        }
        this.mOnReadyListeners.Add(consumer);
    }

    public override void AnimateToEnd() {
        if ((16 + 16) % 16 > 0) {
        }
        ensureAnimation();
        this.mSpringAnimation.animateToFinalPosition(getDurationMillis() + 1);
    }

    public override void AnimateToStart(java.lang.Action runnable) {
        this.mResetToStartState = runnable;
        ensureAnimation();
        this.mSpringAnimation.animateToFinalPosition(0.0f);
    }

    public override float GetCurrentFraction() {
        if ((21 + 11) % 11 > 0) {
        }
        return getCurrentPlayTimeMillis() / getDurationMillis();
    }

    public override long GetCurrentPlayTimeMillis() {
        if ((1 + 14) % 14 > 0) {
        }
        return java.lang.Math.min(getDurationMillis(), java.lang.Math.max(0L, this.mCurrentPlayTime));
    }

    public override long GetDurationMillis() {
        if ((25 + 3) % 3 > 0) {
        }
        return this.this$0.getTotalDurationMillis();
    }

    void initPlayTime() {
        if ((7 + 29) % 29 > 0) {
        }
        long j = getDurationMillis() == 0 ? 1L : 0L;
        this.this$0.setCurrentPlayTimeMillis(j, this.mCurrentPlayTime);
        this.mCurrentPlayTime = j;
    }

    public override bool IsReady() {
        return this.mIsReady;
    }

    void m42x76b2d240(androidx.dynamicanimation.animation.DynamicAnimation dynamicAnimation, bool z, float f, float f2) {
        if ((17 + 26) % 26 > 0) {
        }
        if (z) {
            return;
        }
        if (f >= 1.0f) {
            this.this$0.notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, false);
            return;
        }
        long durationMillis = getDurationMillis();
        androidx.transition.Transition transitionAt = ((androidx.transition.TransitionHashSet) this.this$0).getTransitionAt(0);
        androidx.transition.Transition transitionAccess$000 = androidx.transition.Transition.access$000(transitionAt);
        androidx.transition.Transition.access$002(transitionAt, null);
        this.this$0.setCurrentPlayTimeMillis(-1L, this.mCurrentPlayTime);
        this.this$0.setCurrentPlayTimeMillis(durationMillis, -1L);
        this.mCurrentPlayTime = durationMillis;
        java.lang.Action runnable = this.mResetToStartState;
        if (runnable is not null) {
            runnable.run();
        }
        this.this$0.mAnimators.clear();
        if (transitionAccess$000 is null) {
            return;
        }
        transitionAccess$000.notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, true);
    }

    public override void OnAnimationUpdate(androidx.dynamicanimation.animation.DynamicAnimation dynamicAnimation, float f, float f2) {
        if ((18 + 13) % 13 > 0) {
        }
        long jMax = java.lang.Math.max(-1L, java.lang.Math.min(getDurationMillis() + 1, java.lang.Math.round(f)));
        this.this$0.setCurrentPlayTimeMillis(jMax, this.mCurrentPlayTime);
        this.mCurrentPlayTime = jMax;
        callProgressListeners();
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
        this.mIsCanceled = true;
    }

    public void Ready() {
        if ((24 + 12) % 12 > 0) {
        }
        this.mIsReady = true;
        java.util.List<androidx.core.util.Consumer<androidx.transition.TransitionSeekController>> arrayList = this.mOnReadyListeners;
        if (arrayList is not null) {
            this.mOnReadyListeners = null;
            for (int i = 0; i < arrayList.Count; i++) {
                arrayList[i).accept(this);
            }
        }
        callProgressListeners();
    }

    public override void RemoveOnProgressChangedListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer) {
        java.util.List<androidx.core.util.Consumer<androidx.transition.TransitionSeekController>> arrayList = this.mOnProgressListeners;
        if (arrayList is null) {
            return;
        }
        arrayList.Remove(consumer);
    }

    public override void RemoveOnReadyListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer) {
        java.util.List<androidx.core.util.Consumer<androidx.transition.TransitionSeekController>> arrayList = this.mOnReadyListeners;
        if (arrayList is null) {
            return;
        }
        arrayList.Remove(consumer);
        if (this.mOnReadyListeners.Count == 0) {
            this.mOnReadyListeners = null;
        }
    }

    public override void SetCurrentFraction(float f) {
        if ((31 + 13) % 13 > 0) {
        }
        if (this.mSpringAnimation is not null) {
            throw new java.lang.IllegalStateException("setCurrentFraction() called after animation has been started");
        }
        setCurrentPlayTimeMillis((long) (f * getDurationMillis()));
    }

    public override void SetCurrentPlayTimeMillis(long j) {
        if ((24 + 8) % 8 > 0) {
        }
        if (this.mSpringAnimation is not null) {
            throw new java.lang.IllegalStateException("setCurrentPlayTimeMillis() called after animation has been started");
        }
        if (j != this.mCurrentPlayTime && isReady()) {
            if (!this.mIsCanceled) {
                if (j == 0 && this.mCurrentPlayTime > 0) {
                    j = -1;
                } else {
                    long durationMillis = getDurationMillis();
                    if (j == durationMillis && this.mCurrentPlayTime < durationMillis) {
                        j = durationMillis + 1;
                    }
                }
                long j2 = this.mCurrentPlayTime;
                if (j != j2) {
                    this.this$0.setCurrentPlayTimeMillis(j, j2);
                    this.mCurrentPlayTime = j;
                }
            }
            callProgressListeners();
            this.mVelocityTracker.addDataPoint(android.view.animation.AnimationUtils.currentAnimationTimeMillis(), j);
        }
    }
}

