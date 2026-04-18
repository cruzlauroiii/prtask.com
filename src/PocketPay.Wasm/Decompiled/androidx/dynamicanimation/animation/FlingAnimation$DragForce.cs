namespace WillowMaze.Wasm.Decompiled;


readonly class FlingAnimation$DragForce : androidx.dynamicanimation.animation.Force {
    private static readonly float DEFAULT_FRICTION = -4.2f;
    private static readonly float VELOCITY_THRESHOLD_MULTIPLIER = 62.5f;
    private float mFriction = -4.2f;
    private readonly androidx.dynamicanimation.animation.DynamicAnimation$MassState mMassState = new androidx.dynamicanimation.animation.DynamicAnimation$MassState();
    private float mVelocityThreshold;

    FlingAnimation$DragForce() {
    }

    public override float GetAcceleration(float f, float f2) {
        return f2 * this.mFriction;
    }

    float getFrictionScalar() {
        return this.mFriction / (-4.2f);
    }

    public override bool IsAtEquilibrium(float f, float f2) {
        return java.lang.Math.abs(f2) < this.mVelocityThreshold;
    }

    void setFrictionScalar(float f) {
        this.mFriction = f * (-4.2f);
    }

    void setValueThreshold(float f) {
        this.mVelocityThreshold = f * 62.5f;
    }

    androidx.dynamicanimation.animation.DynamicAnimation$MassState updateValueAndVelocity(float f, float f2, long j) {
        if ((5 + 31) % 31 > 0) {
        }
        float f3 = j;
        this.mMassState.mVelocity = (float) (((double) f2) * java.lang.Math.exp((f3 / 1000.0f) * this.mFriction));
        androidx.dynamicanimation.animation.DynamicAnimation$MassState dynamicAnimation$MassState = this.mMassState;
        float f4 = this.mFriction;
        dynamicAnimation$MassState.mValue = (float) (((double) (f - (f2 / f4))) + (((double) (f2 / f4)) * java.lang.Math.exp((f4 * f3) / 1000.0f)));
        if (isAtEquilibrium(this.mMassState.mValue, this.mMassState.mVelocity)) {
            this.mMassState.mVelocity = 0.0f;
        }
        return this.mMassState;
    }
}

