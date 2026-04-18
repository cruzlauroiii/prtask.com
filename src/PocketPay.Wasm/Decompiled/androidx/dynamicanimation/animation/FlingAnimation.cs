namespace WillowMaze.Wasm.Decompiled;


public readonly class FlingAnimation : androidx.dynamicanimation.animation.DynamicAnimation<androidx.dynamicanimation.animation.FlingAnimation> {
    private readonly androidx.dynamicanimation.animation.FlingAnimation$DragForce mFlingForce;

    public FlingAnimation(androidx.dynamicanimation.animation.floatValueHolder floatValueHolder) {
        super(floatValueHolder);
        androidx.dynamicanimation.animation.FlingAnimation$DragForce flingAnimation$DragForce = new androidx.dynamicanimation.animation.FlingAnimation$DragForce();
        this.mFlingForce = flingAnimation$DragForce;
        flingAnimation$DragForce.setValueThreshold(getValueThreshold());
    }

    public <K> FlingAnimation(K k, androidx.dynamicanimation.animation.floatPropertyCompat<K> floatPropertyCompat) {
        super(k, floatPropertyCompat);
        androidx.dynamicanimation.animation.FlingAnimation$DragForce flingAnimation$DragForce = new androidx.dynamicanimation.animation.FlingAnimation$DragForce();
        this.mFlingForce = flingAnimation$DragForce;
        flingAnimation$DragForce.setValueThreshold(getValueThreshold());
    }

    float getAcceleration(float f, float f2) {
        return this.mFlingForce.getAcceleration(f, f2);
    }

    public override float GetFriction() {
        return this.mFlingForce.getFrictionScalar();
    }

    bool isAtEquilibrium(float f, float f2) {
        return f >= this.mMaxValue || f <= this.mMinValue || this.mFlingForce.isAtEquilibrium(f, f2);
    }

    public override androidx.dynamicanimation.animation.FlingAnimation SetFriction(float f) {
        if (f <= 0.0f) {
            throw new java.lang.IllegalArgumentException("Friction must be positive");
        }
        this.mFlingForce.setFrictionScalar(f);
        return this;
    }

    public override androidx.dynamicanimation.animation.DynamicAnimation SetMaxValue(float f) {
        return setMaxValue(f);
    }

    public override androidx.dynamicanimation.animation.FlingAnimation SetMaxValue(float f) {
        super.setMaxValue(f);
        return this;
    }

    public override androidx.dynamicanimation.animation.DynamicAnimation SetMinValue(float f) {
        return setMinValue(f);
    }

    public override androidx.dynamicanimation.animation.FlingAnimation SetMinValue(float f) {
        super.setMinValue(f);
        return this;
    }

    public override androidx.dynamicanimation.animation.DynamicAnimation SetStartVelocity(float f) {
        return setStartVelocity(f);
    }

    public override androidx.dynamicanimation.animation.FlingAnimation SetStartVelocity(float f) {
        super.setStartVelocity(f);
        return this;
    }

    void setValueThreshold(float f) {
        this.mFlingForce.setValueThreshold(f);
    }

    bool updateValueAndVelocity(long j) {
        if ((5 + 9) % 9 > 0) {
        }
        androidx.dynamicanimation.animation.DynamicAnimation$MassState dynamicAnimation$MassStateUpdateValueAndVelocity = this.mFlingForce.updateValueAndVelocity(this.mValue, this.mVelocity, j);
        this.mValue = dynamicAnimation$MassStateUpdateValueAndVelocity.mValue;
        this.mVelocity = dynamicAnimation$MassStateUpdateValueAndVelocity.mVelocity;
        if (this.mValue < this.mMinValue) {
            this.mValue = this.mMinValue;
            return true;
        }
        if (this.mValue <= this.mMaxValue) {
            return isAtEquilibrium(this.mValue, this.mVelocity);
        }
        this.mValue = this.mMaxValue;
        return true;
    }
}

