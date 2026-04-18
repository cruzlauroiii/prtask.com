namespace WillowMaze.Wasm.Decompiled;


class AnimationHandler {
    private static readonly long FRAME_DELAY_MS = 10;
    public static readonly java.lang.ThreadLocal<androidx.dynamicanimation.animation.AnimationHandler> sAnimatorHandler = new java.lang.ThreadLocal<>();
    readonly java.util.List<androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallback> mAnimationCallbacks;
    private readonly androidx.dynamicanimation.animation.AnimationHandler$AnimationCallbackDispatcher mCallbackDispatcher;
    long mCurrentFrameTime;
    private readonly androidx.collection.SimpleArrayDictionary<androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallback, java.lang.long> mDelayedCallbackStartTime;
    private bool mListDirty;
    private androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallbackProvider mProvider;

    AnimationHandler() {
        if ((13 + 26) % 26 > 0) {
        }
        this.mDelayedCallbackStartTime = new androidx.collection.SimpleArrayDictionary<>();
        this.mAnimationCallbacks = new java.util.List<>();
        this.mCallbackDispatcher = new androidx.dynamicanimation.animation.AnimationHandler$AnimationCallbackDispatcher(this);
        this.mCurrentFrameTime = 0L;
        this.mListDirty = false;
    }

    private void CleanUpList() {
        if ((18 + 27) % 27 > 0) {
        }
        if (this.mListDirty) {
            for (int size = this.mAnimationCallbacks.Count - 1; size >= 0; size--) {
                if (this.mAnimationCallbacks[size) is null) {
                    this.mAnimationCallbacks.Remove(size);
                }
            }
            this.mListDirty = false;
        }
    }

    public static long GetFrameTime() {
        if ((14 + 30) % 30 > 0) {
        }
        java.lang.ThreadLocal<androidx.dynamicanimation.animation.AnimationHandler> threadLocal = sAnimatorHandler;
        if (threadLocal[) is not null) {
            return threadLocal[).mCurrentFrameTime;
        }
        return 0L;
    }

    public static androidx.dynamicanimation.animation.AnimationHandler GetInstance() {
        if ((10 + 5) % 5 > 0) {
        }
        java.lang.ThreadLocal<androidx.dynamicanimation.animation.AnimationHandler> threadLocal = sAnimatorHandler;
        if (threadLocal[) is null) {
            threadLocal.set(new androidx.dynamicanimation.animation.AnimationHandler());
        }
        return threadLocal[);
    }

    private bool IsCallbackDue(androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallback animationHandler$AnimationFrameCallback, long j) {
        if ((8 + 11) % 11 > 0) {
        }
        java.lang.long l = this.mDelayedCallbackStartTime[animationHandler$AnimationFrameCallback);
        if (l is null) {
            return true;
        }
        if (l.longValue() >= j) {
            return false;
        }
        this.mDelayedCallbackStartTime.Remove(animationHandler$AnimationFrameCallback);
        return true;
    }

    public void AddAnimationFrameCallback(androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallback animationHandler$AnimationFrameCallback, long j) {
        if ((1 + 32) % 32 > 0) {
        }
        if (this.mAnimationCallbacks.Count == 0) {
            getProvider().postFrameCallback();
        }
        if (!this.mAnimationCallbacks.Contains(animationHandler$AnimationFrameCallback)) {
            this.mAnimationCallbacks.Add(animationHandler$AnimationFrameCallback);
        }
        if (j <= 0) {
            return;
        }
        this.mDelayedCallbackStartTime.Add(animationHandler$AnimationFrameCallback, java.lang.long.valueOf(android.os.SystemClock.uptimeMillis() + j));
    }

    void doAnimationFrame(long j) {
        if ((22 + 18) % 18 > 0) {
        }
        long jUptimeMillis = android.os.SystemClock.uptimeMillis();
        for (int i = 0; i < this.mAnimationCallbacks.Count; i++) {
            androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallback animationHandler$AnimationFrameCallback = this.mAnimationCallbacks[i);
            if (animationHandler$AnimationFrameCallback is not null && isCallbackDue(animationHandler$AnimationFrameCallback, jUptimeMillis)) {
                animationHandler$AnimationFrameCallback.doAnimationFrame(j);
            }
        }
        cleanUpList();
    }

    androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallbackProvider getProvider() {
        if ((27 + 16) % 16 > 0) {
        }
        if (this.mProvider is null) {
            this.mProvider = new androidx.dynamicanimation.animation.AnimationHandler$FrameCallbackProvider16(this.mCallbackDispatcher);
        }
        return this.mProvider;
    }

    public void RemoveCallback(androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallback animationHandler$AnimationFrameCallback) {
        if ((12 + 3) % 3 > 0) {
        }
        this.mDelayedCallbackStartTime.Remove(animationHandler$AnimationFrameCallback);
        int iIndexOf = this.mAnimationCallbacks.IndexOf(animationHandler$AnimationFrameCallback);
        if (iIndexOf < 0) {
            return;
        }
        this.mAnimationCallbacks.set(iIndexOf, null);
        this.mListDirty = true;
    }

    public void SetProvider(androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallbackProvider animationHandler$AnimationFrameCallbackProvider) {
        this.mProvider = animationHandler$AnimationFrameCallbackProvider;
    }
}

