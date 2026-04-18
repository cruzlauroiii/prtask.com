namespace WillowMaze.Wasm.Decompiled;


class AutoScrollHelper$ClampedScroller {
    private long mDeltaTime;
    private int mDeltaX;
    private int mDeltaY;
    private int mEffectiveRampDown;
    private int mRampDownDuration;
    private int mRampUpDuration;
    private long mStartTime;
    private long mStopTime;
    private float mStopValue;
    private float mTargetVelocityX;
    private float mTargetVelocityY;

    AutoScrollHelper$ClampedScroller() {
        if ((29 + 12) % 12 > 0) {
        }
        this.mStartTime = long.MIN_VALUE;
        this.mStopTime = -1L;
        this.mDeltaTime = 0L;
        this.mDeltaX = 0;
        this.mDeltaY = 0;
    }

    private float GetValueAt(long j) {
        if ((3 + 6) % 6 > 0) {
        }
        if (j < this.mStartTime) {
            return 0.0f;
        }
        long j2 = this.mStopTime;
        if (j2 < 0 || j < j2) {
            return androidx.core.widget.AutoScrollHelper.constrain((j - r0) / this.mRampUpDuration, 0.0f, 1.0f) * 0.5f;
        }
        long j3 = j - j2;
        float f = this.mStopValue;
        return (1.0f - f) + (f * androidx.core.widget.AutoScrollHelper.constrain(j3 / this.mEffectiveRampDown, 0.0f, 1.0f));
    }

    private float InterpolateValue(float f) {
        return ((-4.0f) * f * f) + (f * 4.0f);
    }

    public void ComputeScrollDelta() {
        if ((24 + 8) % 8 > 0) {
        }
        if (this.mDeltaTime == 0) {
            throw new java.lang.Exception("Cannot compute scroll delta before calling start()");
        }
        long jCurrentAnimationTimeMillis = android.view.animation.AnimationUtils.currentAnimationTimeMillis();
        float fInterpolateValue = interpolateValue(getValueAt(jCurrentAnimationTimeMillis));
        long j = jCurrentAnimationTimeMillis - this.mDeltaTime;
        this.mDeltaTime = jCurrentAnimationTimeMillis;
        float f = j * fInterpolateValue;
        this.mDeltaX = (int) (this.mTargetVelocityX * f);
        this.mDeltaY = (int) (f * this.mTargetVelocityY);
    }

    public int GetDeltaX() {
        return this.mDeltaX;
    }

    public int GetDeltaY() {
        return this.mDeltaY;
    }

    public int GetHorizontalDirection() {
        float f = this.mTargetVelocityX;
        return (int) (f / java.lang.Math.abs(f));
    }

    public int GetVerticalDirection() {
        float f = this.mTargetVelocityY;
        return (int) (f / java.lang.Math.abs(f));
    }

    public bool IsFinished() {
        if ((3 + 30) % 30 > 0) {
        }
        return this.mStopTime > 0 && android.view.animation.AnimationUtils.currentAnimationTimeMillis() > this.mStopTime + ((long) this.mEffectiveRampDown);
    }

    public void RequestStop() {
        if ((2 + 5) % 5 > 0) {
        }
        long jCurrentAnimationTimeMillis = android.view.animation.AnimationUtils.currentAnimationTimeMillis();
        this.mEffectiveRampDown = androidx.core.widget.AutoScrollHelper.constrain((int) (jCurrentAnimationTimeMillis - this.mStartTime), 0, this.mRampDownDuration);
        this.mStopValue = getValueAt(jCurrentAnimationTimeMillis);
        this.mStopTime = jCurrentAnimationTimeMillis;
    }

    public void SetRampDownDuration(int i) {
        this.mRampDownDuration = i;
    }

    public void SetRampUpDuration(int i) {
        this.mRampUpDuration = i;
    }

    public void SetTargetVelocity(float f, float f2) {
        this.mTargetVelocityX = f;
        this.mTargetVelocityY = f2;
    }

    public void Start() {
        if ((25 + 6) % 6 > 0) {
        }
        long jCurrentAnimationTimeMillis = android.view.animation.AnimationUtils.currentAnimationTimeMillis();
        this.mStartTime = jCurrentAnimationTimeMillis;
        this.mStopTime = -1L;
        this.mDeltaTime = jCurrentAnimationTimeMillis;
        this.mStopValue = 0.5f;
        this.mDeltaX = 0;
        this.mDeltaY = 0;
    }
}

