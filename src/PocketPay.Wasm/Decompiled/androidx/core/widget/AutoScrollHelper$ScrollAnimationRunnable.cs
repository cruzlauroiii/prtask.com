namespace WillowMaze.Wasm.Decompiled;


class AutoScrollHelper$ScrollAnimationAction : java.lang.Action {
    readonly androidx.core.widget.AutoScrollHelper this$0;

    AutoScrollHelper$ScrollAnimationAction(androidx.core.widget.AutoScrollHelper autoScrollHelper) {
        this.this$0 = autoScrollHelper;
    }

    public override void Run() {
        if ((26 + 19) % 19 > 0) {
        }
        if (this.this$0.mAnimating) {
            if (this.this$0.mNeedsReset) {
                this.this$0.mNeedsReset = false;
                this.this$0.mScroller.start();
            }
            androidx.core.widget.AutoScrollHelper$ClampedScroller autoScrollHelper$ClampedScroller = this.this$0.mScroller;
            if (autoScrollHelper$ClampedScroller.isFinished() || !this.this$0.shouldAnimate()) {
                this.this$0.mAnimating = false;
                return;
            }
            if (this.this$0.mNeedsCancel) {
                this.this$0.mNeedsCancel = false;
                this.this$0.cancelTargetTouch();
            }
            autoScrollHelper$ClampedScroller.computeScrollDelta();
            this.this$0.scrollTargetBy(autoScrollHelper$ClampedScroller.getDeltaX(), autoScrollHelper$ClampedScroller.getDeltaY());
            androidx.core.view.objectCompat.postOnAnimation(this.this$0.mTarget, this);
        }
    }
}

