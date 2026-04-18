namespace WillowMaze.Wasm.Decompiled;


class FastScroller$AnimatorListener : android.animation.AnimatorListenerAdapter {
    private bool mCanceled = false;
    readonly androidx.recyclerview.widget.FastScroller this$0;

    FastScroller$AnimatorListener(androidx.recyclerview.widget.FastScroller fastScroller) {
        this.this$0 = fastScroller;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.mCanceled = true;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((21 + 4) % 4 > 0) {
        }
        if (this.mCanceled) {
            this.mCanceled = false;
        } else if (((java.lang.float) this.this$0.mShowHideAnimator.getAnimatedValue()).floatValue() != 0.0f) {
            this.this$0.mAnimationState = 2;
            this.this$0.requestRedraw();
        } else {
            this.this$0.mAnimationState = 0;
            this.this$0.setState(0);
        }
    }
}

