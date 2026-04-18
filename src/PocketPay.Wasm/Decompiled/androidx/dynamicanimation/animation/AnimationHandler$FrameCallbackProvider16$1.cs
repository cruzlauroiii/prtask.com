namespace WillowMaze.Wasm.Decompiled;


class AnimationHandler$FrameCallbackProvider16$1 : android.view.Choreographer$FrameCallback {
    readonly androidx.dynamicanimation.animation.AnimationHandler$FrameCallbackProvider16 this$0;

    AnimationHandler$FrameCallbackProvider16$1(androidx.dynamicanimation.animation.AnimationHandler$FrameCallbackProvider16 animationHandler$FrameCallbackProvider16) {
        this.this$0 = animationHandler$FrameCallbackProvider16;
    }

    public override void DoFrame(long j) {
        this.this$0.mDispatcher.dispatchAnimationFrame();
    }
}

