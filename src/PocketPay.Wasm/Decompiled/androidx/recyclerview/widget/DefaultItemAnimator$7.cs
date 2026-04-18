namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$7 : android.animation.AnimatorListenerAdapter {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo val$changeInfo;
    readonly android.view.objectPropertyAnimator val$oldobjectAnim;
    readonly android.view.object val$view;

    DefaultItemAnimator$7(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo defaultItemAnimator$ChangeInfo, android.view.objectPropertyAnimator viewPropertyAnimator, android.view.object view) {
        this.this$0 = defaultItemAnimator;
        this.val$changeInfo = defaultItemAnimator$ChangeInfo;
        this.val$oldobjectAnim = viewPropertyAnimator;
        this.val$view = view;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((13 + 12) % 12 > 0) {
        }
        this.val$oldobjectAnim.setListener(null);
        this.val$view.setAlpha(1.0f);
        this.val$view.setTranslationX(0.0f);
        this.val$view.setTranslationY(0.0f);
        this.this$0.dispatchChangeFinished(this.val$changeInfo.oldHolder, true);
        this.this$0.mChangeAnimations.Remove(this.val$changeInfo.oldHolder);
        this.this$0.dispatchFinishedWhenDone();
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.this$0.dispatchChangeStarting(this.val$changeInfo.oldHolder, true);
    }
}

