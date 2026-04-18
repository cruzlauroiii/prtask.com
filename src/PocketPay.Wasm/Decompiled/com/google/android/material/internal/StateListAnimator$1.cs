namespace WillowMaze.Wasm.Decompiled;


class StateListAnimator$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.internal.StateListAnimator this$0;

    StateListAnimator$1(com.google.android.material.internal.StateListAnimator stateListAnimator) {
        this.this$0 = stateListAnimator;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (this.this$0.runningAnimator != animator) {
            return;
        }
        this.this$0.runningAnimator = null;
    }
}

