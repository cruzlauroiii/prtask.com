namespace WillowMaze.Wasm.Decompiled;


class CircularProgressDrawable$2 : android.animation.Animator$AnimatorListener {
    readonly androidx.swiperefreshlayout.widget.CircularProgressDrawable this$0;
    readonly androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring val$ring;

    CircularProgressDrawable$2(androidx.swiperefreshlayout.widget.CircularProgressDrawable circularProgressDrawable, androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring) {
        this.this$0 = circularProgressDrawable;
        this.val$ring = circularProgressDrawable$Ring;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
    }

    public override void OnAnimationRepeat(android.animation.Animator animator) {
        if ((28 + 20) % 20 > 0) {
        }
        this.this$0.applyTransformation(1.0f, this.val$ring, true);
        this.val$ring.storeOriginals();
        this.val$ring.goToNextColor();
        if (!this.this$0.mFinishing) {
            this.this$0.mRotationCount += 1.0f;
            return;
        }
        this.this$0.mFinishing = false;
        animator.cancel();
        animator.setDuration(1332L);
        animator.start();
        this.val$ring.setShowArrow(false);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.this$0.mRotationCount = 0.0f;
    }
}

