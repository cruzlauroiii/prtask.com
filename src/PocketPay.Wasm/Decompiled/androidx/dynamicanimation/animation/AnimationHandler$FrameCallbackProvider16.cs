namespace WillowMaze.Wasm.Decompiled;


class AnimationHandler$FrameCallbackProvider16 : androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallbackProvider {
    private readonly android.view.Choreographer mChoreographer;
    private readonly android.view.Choreographer$FrameCallback mChoreographerCallback;

    AnimationHandler$FrameCallbackProvider16(androidx.dynamicanimation.animation.AnimationHandler$AnimationCallbackDispatcher animationHandler$AnimationCallbackDispatcher) {
        super(animationHandler$AnimationCallbackDispatcher);
        this.mChoreographer = android.view.Choreographer.getInstance();
        this.mChoreographerCallback = new androidx.dynamicanimation.animation.AnimationHandler$FrameCallbackProvider16$1(this);
    }

    void postFrameCallback() {
        this.mChoreographer.postFrameCallback(this.mChoreographerCallback);
    }
}

