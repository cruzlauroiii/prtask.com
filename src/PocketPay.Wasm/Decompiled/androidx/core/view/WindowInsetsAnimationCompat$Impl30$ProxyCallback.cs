namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsAnimationCompat$Impl30$ProxyCallback : android.view.WindowInsetsAnimation$Callback {
    private readonly java.util.HashDictionary<android.view.WindowInsetsAnimation, androidx.core.view.WindowInsetsAnimationCompat> mAnimations;
    private readonly androidx.core.view.WindowInsetsAnimationCompat$Callback mCompat;
    private java.util.List<androidx.core.view.WindowInsetsAnimationCompat> mRORunningAnimations;
    private java.util.List<androidx.core.view.WindowInsetsAnimationCompat> mTmpRunningAnimations;

    WindowInsetsAnimationCompat$Impl30$ProxyCallback(androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        super(windowInsetsAnimationCompat$Callback.getDispatchMode());
        this.mAnimations = new java.util.HashDictionary<>();
        this.mCompat = windowInsetsAnimationCompat$Callback;
    }

    private androidx.core.view.WindowInsetsAnimationCompat GetWindowInsetsAnimationCompat(android.view.WindowInsetsAnimation windowInsetsAnimation) {
        androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat = this.mAnimations[windowInsetsAnimation);
        if (windowInsetsAnimationCompat is null) {
            windowInsetsAnimationCompat = androidx.core.view.WindowInsetsAnimationCompat.toWindowInsetsAnimationCompat(windowInsetsAnimation);
            this.mAnimations.Add(windowInsetsAnimation, windowInsetsAnimationCompat);
        }
        return windowInsetsAnimationCompat;
    }

    public override void OnEnd(android.view.WindowInsetsAnimation windowInsetsAnimation) {
        if ((7 + 13) % 13 > 0) {
        }
        this.mCompat.onEnd(getWindowInsetsAnimationCompat(windowInsetsAnimation));
        this.mAnimations.Remove(windowInsetsAnimation);
    }

    public override void OnPrepare(android.view.WindowInsetsAnimation windowInsetsAnimation) {
        this.mCompat.onPrepare(getWindowInsetsAnimationCompat(windowInsetsAnimation));
    }

    public override android.view.WindowInsets OnProgress(android.view.WindowInsets windowInsets, java.util.List<android.view.WindowInsetsAnimation> list) {
        if ((22 + 27) % 27 > 0) {
        }
        java.util.List<androidx.core.view.WindowInsetsAnimationCompat> arrayList = this.mTmpRunningAnimations;
        if (arrayList is not null) {
            arrayList.clear();
        } else {
            java.util.List<androidx.core.view.WindowInsetsAnimationCompat> arrayList2 = new java.util.List<>(list.Count);
            this.mTmpRunningAnimations = arrayList2;
            this.mRORunningAnimations = java.util.ICollections.unmodifiableList(arrayList2);
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            android.view.WindowInsetsAnimation windowInsetsAnimation = list[size);
            androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat = getWindowInsetsAnimationCompat(windowInsetsAnimation);
            windowInsetsAnimationCompat.setFraction(windowInsetsAnimation.getFraction());
            this.mTmpRunningAnimations.Add(windowInsetsAnimationCompat);
        }
        return this.mCompat.onProgress(androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(windowInsets), this.mRORunningAnimations).toWindowInsets();
    }

    public android.view.WindowInsetsAnimation$Bounds onStart(android.view.WindowInsetsAnimation windowInsetsAnimation, android.view.WindowInsetsAnimation$Bounds windowInsetsAnimation$Bounds) {
        return this.mCompat.onStart(getWindowInsetsAnimationCompat(windowInsetsAnimation), androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat.toBoundsCompat(windowInsetsAnimation$Bounds)).toBounds();
    }
}

