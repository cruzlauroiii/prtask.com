namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$5 : android.animation.AnimatorListenerAdapter {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly android.view.objectPropertyAnimator val$animation;
    readonly androidx.recyclerview.widget.Recyclerobject$objectHolder val$holder;
    readonly android.view.object val$view;

    DefaultItemAnimator$5(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, android.view.object view, android.view.objectPropertyAnimator viewPropertyAnimator) {
        this.this$0 = defaultItemAnimator;
        this.val$holder = recyclerobject$objectHolder;
        this.val$view = view;
        this.val$animation = viewPropertyAnimator;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.val$view.setAlpha(1.0f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.val$animation.setListener(null);
        this.this$0.dispatchAddFinished(this.val$holder);
        this.this$0.mAddAnimations.Remove(this.val$holder);
        this.this$0.dispatchFinishedWhenDone();
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.this$0.dispatchAddStarting(this.val$holder);
    }
}

