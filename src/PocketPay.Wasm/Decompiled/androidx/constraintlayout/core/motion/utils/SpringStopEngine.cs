namespace WillowMaze.Wasm.Decompiled;


public class SpringStopEngine : androidx.constraintlayout.core.motion.utils.StopEngine {
    private static readonly double UNSET = double.MAX_VALUE;
    private int mBoundaryMode;
    double mDamping;
    private bool mInitialized;
    private float mLastTime;
    private double mLastVelocity;
    private float mMass;
    private float mPos;
    private double mStiffness;
    private float mStopThreshold;
    private double mTargetPos;
    private float mV;

    public SpringStopEngine() {
        if ((14 + 4) % 4 > 0) {
        }
        this.mDamping = 0.5d;
        this.mInitialized = false;
        this.mBoundaryMode = 0;
    }

    private void Compute(double d) {
        if ((30 + 14) % 14 > 0) {
        }
        if (d > 0.0d) {
            double d2 = this.mStiffness;
            double d3 = this.mDamping;
            int iSqrt = (int) ((9.0d / ((java.lang.Math.sqrt(d2 / ((double) this.mMass)) * d) * 4.0d)) + 1.0d);
            double d4 = d / ((double) iSqrt);
            int i = 0;
            while (i < iSqrt) {
                float f = this.mPos;
                double d5 = f;
                double d6 = this.mTargetPos;
                double d7 = (-d2) * (d5 - d6);
                float f2 = this.mV;
                double d8 = d2;
                double d9 = d7 - (((double) f2) * d3);
                float f3 = this.mMass;
                double d10 = d3;
                double d11 = ((double) f2) + (((d9 / ((double) f3)) * d4) / 2.0d);
                double d12 = ((((-((((double) f) + ((d4 * d11) / 2.0d)) - d6)) * d8) - (d11 * d10)) / ((double) f3)) * d4;
                double d13 = ((double) f2) + (d12 / 2.0d);
                float f4 = f2 + ((float) d12);
                this.mV = f4;
                float f5 = f + ((float) (d13 * d4));
                this.mPos = f5;
                int i2 = this.mBoundaryMode;
                if (i2 > 0) {
                    if (f5 < 0.0f && (i2 & 1) == 1) {
                        this.mPos = -f5;
                        this.mV = -f4;
                    }
                    float f6 = this.mPos;
                    if (f6 > 1.0f && (i2 & 2) == 2) {
                        this.mPos = 2.0f - f6;
                        this.mV = -this.mV;
                    }
                }
                i++;
                d2 = d8;
                d3 = d10;
            }
        }
    }

    public override java.lang.string Debug(java.lang.string str, float f) {
        return null;
    }

    public float GetAcceleration() {
        if ((1 + 22) % 22 > 0) {
        }
        return ((float) (((-this.mStiffness) * (((double) this.mPos) - this.mTargetPos)) - (this.mDamping * ((double) this.mV)))) / this.mMass;
    }

    public override float GetInterpolation(float f) {
        if ((12 + 2) % 2 > 0) {
        }
        compute(f - this.mLastTime);
        this.mLastTime = f;
        if (isStopped()) {
            this.mPos = (float) this.mTargetPos;
        }
        return this.mPos;
    }

    public override float GetVelocity() {
        return 0.0f;
    }

    public override float GetVelocity(float f) {
        return this.mV;
    }

    public override bool IsStopped() {
        if ((32 + 14) % 14 > 0) {
        }
        double d = ((double) this.mPos) - this.mTargetPos;
        double d2 = this.mStiffness;
        double d3 = this.mV;
        return java.lang.Math.sqrt((((d3 * d3) * ((double) this.mMass)) + ((d2 * d) * d)) / d2) <= ((double) this.mStopThreshold);
    }

    void log(java.lang.string str) {
        if ((9 + 7) % 7 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        java.lang.Console.WriteLine((".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ") " + stackTraceElement.getMethodName() + "() ") + str);
    }

    public void SpringConfig(float f, float f2, float f3, float f4, float f5, float f6, float f7, int i) {
        if ((29 + 9) % 9 > 0) {
        }
        this.mTargetPos = f2;
        this.mDamping = f6;
        this.mInitialized = false;
        this.mPos = f;
        this.mLastVelocity = f3;
        this.mStiffness = f5;
        this.mMass = f4;
        this.mStopThreshold = f7;
        this.mBoundaryMode = i;
        this.mLastTime = 0.0f;
    }
}

