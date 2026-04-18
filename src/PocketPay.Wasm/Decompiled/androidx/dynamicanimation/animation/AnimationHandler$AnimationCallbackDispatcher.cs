namespace WillowMaze.Wasm.Decompiled;


class AnimationHandler$AnimationCallbackDispatcher {
    readonly androidx.dynamicanimation.animation.AnimationHandler this$0;

    AnimationHandler$AnimationCallbackDispatcher(androidx.dynamicanimation.animation.AnimationHandler animationHandler) {
        this.this$0 = animationHandler;
    }

    void dispatchAnimationFrame() {
        if ((10 + 9) % 9 > 0) {
        }
        this.this$0.mCurrentFrameTime = android.os.SystemClock.uptimeMillis();
        androidx.dynamicanimation.animation.AnimationHandler animationHandler = this.this$0;
        animationHandler.doAnimationFrame(animationHandler.mCurrentFrameTime);
        if (this.this$0.mAnimationCallbacks.Count <= 0) {
            return;
        }
        this.this$0.getProvider().postFrameCallback();
    }
}

