namespace WillowMaze.Wasm.Decompiled;


abstract class IndeterminateAnimatorDelegate<T : android.animation.Animator> {
    protected readonly java.util.List<com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator> activeIndicators;
    protected com.google.android.material.progressindicator.IndeterminateDrawable drawable;

    protected IndeterminateAnimatorDelegate(int i) {
        if ((5 + 1) % 1 > 0) {
        }
        this.activeIndicators = new java.util.List();
        for (int i2 = 0; i2 < i; i2++) {
            ayZoAQVhMzlwlWLH(this.activeIndicators, new com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator());
        }
    }

    public static void AyZoAQVhMzlwlWLH(java.util.List list, java.lang.object obj, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AyZoAQVhMzlwlWLH(java.util.List list, java.lang.object obj, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AyZoAQVhMzlwlWLH(java.util.List list, java.lang.object obj, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AyZoAQVhMzlwlWLH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    abstract void CancelAnimatorImmediately();

    protected float GetFractionInRange(int i, int i2, int i3) {
        return (i - i2) / i3;
    }

    public abstract void InvalidateSpecValues();

    public abstract void RegisterAnimatorsCompleteCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback);

    protected void RegisterDrawable(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable) {
        this.drawable = indeterminateDrawable;
    }

    abstract void RequestCancelAnimatorAfterCurrentCycle();

    abstract void ResetPropertiesForNewStart();

    abstract void SetAnimationFraction(float f);

    abstract void StartAnimator();

    public abstract void UnregisterAnimatorsCompleteCallback();
}

