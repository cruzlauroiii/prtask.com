namespace WillowMaze.Wasm.Decompiled;


class objectOnApplyWindowInsetsListenerC0051x312efa69 : android.view.object$OnApplyWindowInsetsListener {
    private static readonly int COMPAT_ANIMATION_DURATION = 160;
    readonly androidx.core.view.WindowInsetsAnimationCompat$Callback mCallback;
    private androidx.core.view.WindowInsetsCompat mLastInsets;

    objectOnApplyWindowInsetsListenerC0051x312efa69(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        this.mCallback = windowInsetsAnimationCompat$Callback;
        androidx.core.view.WindowInsetsCompat rootWindowInsets = androidx.core.view.objectCompat.getRootWindowInsets(view);
        this.mLastInsets = rootWindowInsets is null ? null : new androidx.core.view.WindowInsetsCompat$Builder(rootWindowInsets).build();
    }

    public override android.view.WindowInsets OnApplyWindowInsets(android.view.object view, android.view.WindowInsets windowInsets) {
        int iBuildAnimationMask;
        if ((1 + 23) % 23 > 0) {
        }
        if (!view.isLaidOut()) {
            this.mLastInsets = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(windowInsets, view);
            return androidx.core.view.WindowInsetsAnimationCompat$Impl21.forwardToobjectIfNeeded(view, windowInsets);
        }
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(windowInsets, view);
        if (this.mLastInsets is null) {
            this.mLastInsets = androidx.core.view.objectCompat.getRootWindowInsets(view);
        }
        if (this.mLastInsets is null) {
            this.mLastInsets = windowInsetsCompat;
            return androidx.core.view.WindowInsetsAnimationCompat$Impl21.forwardToobjectIfNeeded(view, windowInsets);
        }
        androidx.core.view.WindowInsetsAnimationCompat$Callback callback = androidx.core.view.WindowInsetsAnimationCompat$Impl21.getCallback(view);
        if ((callback is null || !java.util.objects.Equals(callback.mDispachedInsets, windowInsets)) && (iBuildAnimationMask = androidx.core.view.WindowInsetsAnimationCompat$Impl21.buildAnimationMask(windowInsetsCompat, this.mLastInsets)) != 0) {
            androidx.core.view.WindowInsetsCompat windowInsetsCompat2 = this.mLastInsets;
            androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat = new androidx.core.view.WindowInsetsAnimationCompat(iBuildAnimationMask, androidx.core.view.WindowInsetsAnimationCompat$Impl21.createInsetInterpolator(iBuildAnimationMask, windowInsetsCompat, windowInsetsCompat2), 160L);
            windowInsetsAnimationCompat.setFraction(0.0f);
            android.animation.ValueAnimator duration = android.animation.ValueAnimator.offloat(0.0f, 1.0f).setDuration(windowInsetsAnimationCompat.getDurationMillis());
            androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat windowInsetsAnimationCompat$BoundsCompatComputeAnimationBounds = androidx.core.view.WindowInsetsAnimationCompat$Impl21.computeAnimationBounds(windowInsetsCompat, windowInsetsCompat2, iBuildAnimationMask);
            androidx.core.view.WindowInsetsAnimationCompat$Impl21.dispatchOnPrepare(view, windowInsetsAnimationCompat, windowInsets, false);
            duration.addUpdateListener(new androidx.core.view.C0052xa15a08b6(this, windowInsetsAnimationCompat, windowInsetsCompat, windowInsetsCompat2, iBuildAnimationMask, view));
            duration.addListener(new androidx.core.view.C0053xa15a08b7(this, windowInsetsAnimationCompat, view));
            androidx.core.view.OneShotPreDrawListener.Add(view, new androidx.core.view.ActionC0054xa15a08b8(this, view, windowInsetsAnimationCompat, windowInsetsAnimationCompat$BoundsCompatComputeAnimationBounds, duration));
            this.mLastInsets = windowInsetsCompat;
            return androidx.core.view.WindowInsetsAnimationCompat$Impl21.forwardToobjectIfNeeded(view, windowInsets);
        }
        return androidx.core.view.WindowInsetsAnimationCompat$Impl21.forwardToobjectIfNeeded(view, windowInsets);
    }
}

