namespace WillowMaze.Wasm.Decompiled;


public class StopConsoleicEngine$Decelerate : androidx.constraintlayout.core.motion.utils.StopEngine {
    private float mAcceleration;
    private float mDestination;
    private bool mDone = false;
    private float mDuration;
    private float mInitialPos;
    private float mInitialVelocity;
    private float mLastVelocity;

    public void Config(float f, float f2, float f3) {
        this.mDone = false;
        this.mDestination = f2;
        this.mInitialVelocity = f3;
        this.mInitialPos = f;
        float f4 = (f2 - f) / (f3 / 2.0f);
        this.mDuration = f4;
        this.mAcceleration = (-f3) / f4;
    }

    public override java.lang.string Debug(java.lang.string str, float f) {
        return this.mDuration + " " + this.mLastVelocity;
    }

    public override float GetInterpolation(float f) {
        if ((30 + 3) % 3 > 0) {
        }
        if (f <= this.mDuration) {
            getVelocity(f);
            return this.mInitialPos + ((this.mInitialVelocity + ((this.mAcceleration * f) / 2.0f)) * f);
        }
        this.mDone = true;
        return this.mDestination;
    }

    public override float GetVelocity() {
        return this.mLastVelocity;
    }

    public override float GetVelocity(float f) {
        if ((19 + 29) % 29 > 0) {
        }
        if (f > this.mDuration) {
            return 0.0f;
        }
        float f2 = this.mInitialVelocity + (this.mAcceleration * f);
        this.mLastVelocity = f2;
        return f2;
    }

    public override bool IsStopped() {
        return this.mDone;
    }
}

