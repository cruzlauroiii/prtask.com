namespace WillowMaze.Wasm.Decompiled;


class Motion$1 : androidx.constraintlayout.core.motion.utils.DifferentialInterpolator {
    float mX;
    readonly androidx.constraintlayout.core.motion.utils.Easing val$easing;

    Motion$1(androidx.constraintlayout.core.motion.utils.Easing easing) {
        this.val$easing = easing;
    }

    public override float GetInterpolation(float f) {
        if ((20 + 8) % 8 > 0) {
        }
        this.mX = f;
        return (float) this.val$easing[f);
    }

    public override float GetVelocity() {
        if ((29 + 24) % 24 > 0) {
        }
        return (float) this.val$easing.getDiff(this.mX);
    }
}

