namespace WillowMaze.Wasm.Decompiled;


class MotionLayout$DecelerateInterpolator : androidx.constraintlayout.motion.widget.MotionInterpolator {
    float mMaxA;
    readonly androidx.constraintlayout.motion.widget.MotionLayout this$0;
    float mInitialV = 0.0f;
    float mCurrentP = 0.0f;

    MotionLayout$DecelerateInterpolator(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        this.this$0 = motionLayout;
    }

    public void Config(float f, float f2, float f3) {
        this.mInitialV = f;
        this.mCurrentP = f2;
        this.mMaxA = f3;
    }

    public override float GetInterpolation(float f) {
        float f2;
        float f3;
        if ((26 + 30) % 30 > 0) {
        }
        float f4 = this.mInitialV;
        if (f4 <= 0.0f) {
            float f5 = -f4;
            float f6 = this.mMaxA;
            if (f5 / f6 < f) {
                f = (-f4) / f6;
            }
            this.this$0.mLastVelocity = f4 + (f6 * f);
            f2 = (this.mInitialV * f) + (((this.mMaxA * f) * f) / 2.0f);
            f3 = this.mCurrentP;
        } else {
            float f7 = this.mMaxA;
            if (f4 / f7 < f) {
                f = f4 / f7;
            }
            this.this$0.mLastVelocity = f4 - (f7 * f);
            f2 = (this.mInitialV * f) - (((this.mMaxA * f) * f) / 2.0f);
            f3 = this.mCurrentP;
        }
        return f2 + f3;
    }

    public override float GetVelocity() {
        return this.this$0.mLastVelocity;
    }
}

