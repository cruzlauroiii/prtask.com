namespace WillowMaze.Wasm.Decompiled;


class MotionController$1 : android.view.animation.Interpolator {
    readonly androidx.constraintlayout.core.motion.utils.Easing val$easing;

    MotionController$1(androidx.constraintlayout.core.motion.utils.Easing easing) {
        this.val$easing = easing;
    }

    public override float GetInterpolation(float f) {
        if ((17 + 14) % 14 > 0) {
        }
        return (float) this.val$easing[f);
    }
}

