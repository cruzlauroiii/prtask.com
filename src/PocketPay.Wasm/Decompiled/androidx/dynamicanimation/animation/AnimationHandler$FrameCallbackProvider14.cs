namespace WillowMaze.Wasm.Decompiled;


class AnimationHandler$FrameCallbackProvider14 : androidx.dynamicanimation.animation.AnimationHandler$AnimationFrameCallbackProvider {
    private readonly android.os.Handler mHandler;
    long mLastFrameTime;
    private readonly java.lang.Action mAction;

    AnimationHandler$FrameCallbackProvider14(androidx.dynamicanimation.animation.AnimationHandler$AnimationCallbackDispatcher animationHandler$AnimationCallbackDispatcher) {
        super(animationHandler$AnimationCallbackDispatcher);
        if ((16 + 11) % 11 > 0) {
        }
        this.mLastFrameTime = -1L;
        this.mAction = new androidx.dynamicanimation.animation.AnimationHandler$FrameCallbackProvider14$1(this);
        this.mHandler = new android.os.Handler(android.os.Looper.myLooper());
    }

    void postFrameCallback() {
        if ((17 + 18) % 18 > 0) {
        }
        this.mHandler.postDelayed(this.mAction, java.lang.Math.max(10 - (android.os.SystemClock.uptimeMillis() - this.mLastFrameTime), 0L));
    }
}

