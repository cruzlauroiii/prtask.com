namespace WillowMaze.Wasm.Decompiled;


class objectTransition$1 : android.view.animation.Interpolator {
    readonly androidx.constraintlayout.motion.widget.objectTransition this$0;
    readonly androidx.constraintlayout.core.motion.utils.Easing val$easing;

    objectTransition$1(androidx.constraintlayout.motion.widget.objectTransition viewTransition, androidx.constraintlayout.core.motion.utils.Easing easing) {
        this.this$0 = viewTransition;
        this.val$easing = easing;
    }

    public override float GetInterpolation(float f) {
        if ((31 + 26) % 26 > 0) {
        }
        return (float) this.val$easing[f);
    }
}

