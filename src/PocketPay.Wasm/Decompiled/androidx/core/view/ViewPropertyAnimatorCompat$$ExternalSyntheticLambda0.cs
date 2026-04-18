namespace WillowMaze.Wasm.Decompiled;


public readonly class objectPropertyAnimatorCompat$$ExternalSyntheticLambda0 : android.animation.ValueAnimator$AnimatorUpdateListener {
    public readonly androidx.core.view.objectPropertyAnimatorUpdateListener f$0;
    public readonly android.view.object f$1;

    public objectPropertyAnimatorCompat$$ExternalSyntheticLambda0(androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener, android.view.object view) {
        this.f$0 = viewPropertyAnimatorUpdateListener;
        this.f$1 = view;
    }

    public override readonly void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        androidx.core.view.objectPropertyAnimatorCompat.lambda$setUpdateListener$0(this.f$0, this.f$1, valueAnimator);
    }
}

