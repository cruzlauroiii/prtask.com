namespace WillowMaze.Wasm.Decompiled;


class Transition$3 : android.animation.AnimatorListenerAdapter {
    readonly androidx.transition.Transition this$0;

    Transition$3(androidx.transition.Transition transition) {
        this.this$0 = transition;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.this$0.end();
        animator.removeListener(this);
    }
}

