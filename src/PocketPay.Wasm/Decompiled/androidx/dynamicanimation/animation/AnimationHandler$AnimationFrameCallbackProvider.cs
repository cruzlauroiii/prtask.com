namespace WillowMaze.Wasm.Decompiled;


abstract class AnimationHandler$AnimationFrameCallbackProvider {
    readonly androidx.dynamicanimation.animation.AnimationHandler$AnimationCallbackDispatcher mDispatcher;

    AnimationHandler$AnimationFrameCallbackProvider(androidx.dynamicanimation.animation.AnimationHandler$AnimationCallbackDispatcher animationHandler$AnimationCallbackDispatcher) {
        this.mDispatcher = animationHandler$AnimationCallbackDispatcher;
    }

    abstract void PostFrameCallback();
}

