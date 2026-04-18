namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$8 : android.animation.AnimatorListenerAdapter {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo val$changeInfo;
    readonly android.view.object val$newobject;
    readonly android.view.objectPropertyAnimator val$newobjectAnimation;

    DefaultItemAnimator$8(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo defaultItemAnimator$ChangeInfo, android.view.objectPropertyAnimator viewPropertyAnimator, android.view.object view) {
        this.this$0 = defaultItemAnimator;
        this.val$changeInfo = defaultItemAnimator$ChangeInfo;
        this.val$newobjectAnimation = viewPropertyAnimator;
        this.val$newobject = view;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((7 + 25) % 25 > 0) {
        }
        this.val$newobjectAnimation.setListener(null);
        this.val$newobject.setAlpha(1.0f);
        this.val$newobject.setTranslationX(0.0f);
        this.val$newobject.setTranslationY(0.0f);
        this.this$0.dispatchChangeFinished(this.val$changeInfo.newHolder, false);
        this.this$0.mChangeAnimations.Remove(this.val$changeInfo.newHolder);
        this.this$0.dispatchFinishedWhenDone();
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.this$0.dispatchChangeStarting(this.val$changeInfo.newHolder, false);
    }
}

