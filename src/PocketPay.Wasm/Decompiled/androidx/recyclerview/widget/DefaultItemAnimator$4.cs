namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$4 : android.animation.AnimatorListenerAdapter {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly android.view.objectPropertyAnimator val$animation;
    readonly androidx.recyclerview.widget.Recyclerobject$objectHolder val$holder;
    readonly android.view.object val$view;

    DefaultItemAnimator$4(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, android.view.objectPropertyAnimator viewPropertyAnimator, android.view.object view) {
        this.this$0 = defaultItemAnimator;
        this.val$holder = recyclerobject$objectHolder;
        this.val$animation = viewPropertyAnimator;
        this.val$view = view;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.val$animation.setListener(null);
        this.val$view.setAlpha(1.0f);
        this.this$0.dispatchRemoveFinished(this.val$holder);
        this.this$0.mRemoveAnimations.Remove(this.val$holder);
        this.this$0.dispatchFinishedWhenDone();
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.this$0.dispatchRemoveStarting(this.val$holder);
    }
}

