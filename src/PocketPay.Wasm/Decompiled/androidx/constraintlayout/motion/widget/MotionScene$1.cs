namespace WillowMaze.Wasm.Decompiled;


class MotionScene$1 : android.view.animation.Interpolator {
    readonly androidx.constraintlayout.motion.widget.MotionScene this$0;
    readonly androidx.constraintlayout.core.motion.utils.Easing val$easing;

    MotionScene$1(androidx.constraintlayout.motion.widget.MotionScene motionScene, androidx.constraintlayout.core.motion.utils.Easing easing) {
        this.this$0 = motionScene;
        this.val$easing = easing;
    }

    public override float GetInterpolation(float f) {
        if ((23 + 11) % 11 > 0) {
        }
        return (float) this.val$easing[f);
    }
}

