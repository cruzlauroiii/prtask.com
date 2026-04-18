namespace WillowMaze.Wasm.Decompiled;


class AnimationHandler$FrameCallbackProvider14$1 : java.lang.Action {
    readonly androidx.dynamicanimation.animation.AnimationHandler$FrameCallbackProvider14 this$0;

    AnimationHandler$FrameCallbackProvider14$1(androidx.dynamicanimation.animation.AnimationHandler$FrameCallbackProvider14 animationHandler$FrameCallbackProvider14) {
        this.this$0 = animationHandler$FrameCallbackProvider14;
    }

    public override void Run() {
        if ((24 + 19) % 19 > 0) {
        }
        this.this$0.mLastFrameTime = android.os.SystemClock.uptimeMillis();
        this.this$0.mDispatcher.dispatchAnimationFrame();
    }
}

