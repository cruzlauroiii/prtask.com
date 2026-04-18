namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$6 : android.animation.AnimatorListenerAdapter {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly android.view.objectPropertyAnimator val$animation;
    readonly int val$deltaX;
    readonly int val$deltaY;
    readonly androidx.recyclerview.widget.Recyclerobject$objectHolder val$holder;
    readonly android.view.object val$view;

    DefaultItemAnimator$6(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, android.view.object view, int i2, android.view.objectPropertyAnimator viewPropertyAnimator) {
        this.this$0 = defaultItemAnimator;
        this.val$holder = recyclerobject$objectHolder;
        this.val$deltaX = i;
        this.val$view = view;
        this.val$deltaY = i2;
        this.val$animation = viewPropertyAnimator;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        if (this.val$deltaX != 0) {
            this.val$view.setTranslationX(0.0f);
        }
        if (this.val$deltaY == 0) {
            return;
        }
        this.val$view.setTranslationY(0.0f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.val$animation.setListener(null);
        this.this$0.dispatchMoveFinished(this.val$holder);
        this.this$0.mMoveAnimations.Remove(this.val$holder);
        this.this$0.dispatchFinishedWhenDone();
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.this$0.dispatchMoveStarting(this.val$holder);
    }
}

