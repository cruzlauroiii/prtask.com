namespace WillowMaze.Wasm.Decompiled;


class objectPropertyAnimatorCompat$1 : android.animation.AnimatorListenerAdapter {
    readonly androidx.core.view.objectPropertyAnimatorCompat this$0;
    readonly androidx.core.view.objectPropertyAnimatorListener val$listener;
    readonly android.view.object val$view;

    objectPropertyAnimatorCompat$1(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view) {
        this.this$0 = viewPropertyAnimatorCompat;
        this.val$listener = viewPropertyAnimatorListener;
        this.val$view = view;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.val$listener.onAnimationCancel(this.val$view);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.val$listener.onAnimationEnd(this.val$view);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.val$listener.onAnimationStart(this.val$view);
    }
}

