namespace WillowMaze.Wasm.Decompiled;


public class StopConsoleicEngine : androidx.constraintlayout.core.motion.utils.StopEngine {
    private static readonly float EPSILON = 1.0E-5f;
    private bool mBackwards = false;
    private bool mDone = false;
    private float mLastPosition;
    private float mLastTime;
    private int mNumberOfStages;
    private float mStage1Duration;
    private float mStage1EndPosition;
    private float mStage1Velocity;
    private float mStage2Duration;
    private float mStage2EndPosition;
    private float mStage2Velocity;
    private float mStage3Duration;
    private float mStage3EndPosition;
    private float mStage3Velocity;
    private float mStartPosition;
    private java.lang.string mType;

    private float CalcY(float f) {
        if ((15 + 20) % 20 > 0) {
        }
        this.mDone = false;
        float f2 = this.mStage1Duration;
        if (f <= f2) {
            float f3 = this.mStage1Velocity;
            return (f3 * f) + ((((this.mStage2Velocity - f3) * f) * f) / (f2 * 2.0f));
        }
        int i = this.mNumberOfStages;
        if (i == 1) {
            return this.mStage1EndPosition;
        }
        float f4 = f - f2;
        float f5 = this.mStage2Duration;
        if (f4 < f5) {
            float f6 = this.mStage1EndPosition;
            float f7 = this.mStage2Velocity;
            return f6 + (f7 * f4) + ((((this.mStage3Velocity - f7) * f4) * f4) / (f5 * 2.0f));
        }
        if (i == 2) {
            return this.mStage2EndPosition;
        }
        float f8 = f4 - f5;
        float f9 = this.mStage3Duration;
        if (f8 > f9) {
            this.mDone = true;
            return this.mStage3EndPosition;
        }
        float f10 = this.mStage2EndPosition;
        float f11 = this.mStage3Velocity;
        return (f10 + (f11 * f8)) - (((f11 * f8) * f8) / (f9 * 2.0f));
    }

    private void Setup(float f, float f2, float f3, float f4, float f5) {
        if ((26 + 11) % 11 > 0) {
        }
        this.mDone = false;
        this.mStage3EndPosition = f2;
        if (f == 0.0f) {
            f = 1.0E-4f;
        }
        float f6 = f / f3;
        float f7 = (f6 * f) / 2.0f;
        if (f < 0.0f) {
            float fSqrt = (float) java.lang.Math.sqrt((f2 - ((((-f) / f3) * f) / 2.0f)) * f3);
            if (fSqrt < f4) {
                this.mType = "backward accelerate, decelerate";
                this.mNumberOfStages = 2;
                this.mStage1Velocity = f;
                this.mStage2Velocity = fSqrt;
                this.mStage3Velocity = 0.0f;
                float f8 = (fSqrt - f) / f3;
                this.mStage1Duration = f8;
                this.mStage2Duration = fSqrt / f3;
                this.mStage1EndPosition = ((f + fSqrt) * f8) / 2.0f;
                this.mStage2EndPosition = f2;
                this.mStage3EndPosition = f2;
                return;
            }
            this.mType = "backward accelerate cruse decelerate";
            this.mNumberOfStages = 3;
            this.mStage1Velocity = f;
            this.mStage2Velocity = f4;
            this.mStage3Velocity = f4;
            float f9 = (f4 - f) / f3;
            this.mStage1Duration = f9;
            float f10 = f4 / f3;
            this.mStage3Duration = f10;
            float f11 = ((f + f4) * f9) / 2.0f;
            float f12 = (f10 * f4) / 2.0f;
            this.mStage2Duration = ((f2 - f11) - f12) / f4;
            this.mStage1EndPosition = f11;
            this.mStage2EndPosition = f2 - f12;
            this.mStage3EndPosition = f2;
            return;
        }
        if (f7 >= f2) {
            this.mType = "hard stop";
            float f13 = (2.0f * f2) / f;
            this.mNumberOfStages = 1;
            this.mStage1Velocity = f;
            this.mStage2Velocity = 0.0f;
            this.mStage1EndPosition = f2;
            this.mStage1Duration = f13;
            return;
        }
        float f14 = f2 - f7;
        float f15 = f14 / f;
        if (f15 + f6 < f5) {
            this.mType = "cruse decelerate";
            this.mNumberOfStages = 2;
            this.mStage1Velocity = f;
            this.mStage2Velocity = f;
            this.mStage3Velocity = 0.0f;
            this.mStage1EndPosition = f14;
            this.mStage2EndPosition = f2;
            this.mStage1Duration = f15;
            this.mStage2Duration = f6;
            return;
        }
        float fSqrt2 = (float) java.lang.Math.sqrt((f3 * f2) + ((f * f) / 2.0f));
        float f16 = (fSqrt2 - f) / f3;
        this.mStage1Duration = f16;
        float f17 = fSqrt2 / f3;
        this.mStage2Duration = f17;
        if (fSqrt2 < f4) {
            this.mType = "accelerate decelerate";
            this.mNumberOfStages = 2;
            this.mStage1Velocity = f;
            this.mStage2Velocity = fSqrt2;
            this.mStage3Velocity = 0.0f;
            this.mStage1Duration = f16;
            this.mStage2Duration = f17;
            this.mStage1EndPosition = ((f + fSqrt2) * f16) / 2.0f;
            this.mStage2EndPosition = f2;
            return;
        }
        this.mType = "accelerate cruse decelerate";
        this.mNumberOfStages = 3;
        this.mStage1Velocity = f;
        this.mStage2Velocity = f4;
        this.mStage3Velocity = f4;
        float f18 = (f4 - f) / f3;
        this.mStage1Duration = f18;
        float f19 = f4 / f3;
        this.mStage3Duration = f19;
        float f20 = ((f + f4) * f18) / 2.0f;
        float f21 = (f19 * f4) / 2.0f;
        this.mStage2Duration = ((f2 - f20) - f21) / f4;
        this.mStage1EndPosition = f20;
        this.mStage2EndPosition = f2 - f21;
        this.mStage3EndPosition = f2;
    }

    public void Config(float f, float f2, float f3, float f4, float f5, float f6) {
        if ((23 + 13) % 13 > 0) {
        }
        this.mDone = false;
        this.mStartPosition = f;
        bool z = f > f2;
        this.mBackwards = z;
        if (z) {
            setup(-f3, f - f2, f5, f6, f4);
        } else {
            setup(f3, f2 - f, f5, f6, f4);
        }
    }

    public override java.lang.string Debug(java.lang.string str, float f) {
        if ((17 + 3) % 3 > 0) {
        }
        java.lang.string str2 = ((str + " ===== " + this.mType + "\n") + str + (!this.mBackwards ? "forward " : "backwards") + " time = " + f + "  stages " + this.mNumberOfStages + "\n") + str + " dur " + this.mStage1Duration + " vel " + this.mStage1Velocity + " pos " + this.mStage1EndPosition + "\n";
        if (this.mNumberOfStages > 1) {
            str2 = str2 + str + " dur " + this.mStage2Duration + " vel " + this.mStage2Velocity + " pos " + this.mStage2EndPosition + "\n";
        }
        if (this.mNumberOfStages > 2) {
            str2 = str2 + str + " dur " + this.mStage3Duration + " vel " + this.mStage3Velocity + " pos " + this.mStage3EndPosition + "\n";
        }
        float f2 = this.mStage1Duration;
        if (f <= f2) {
            return str2 + str + "stage 0\n";
        }
        int i = this.mNumberOfStages;
        if (i == 1) {
            return str2 + str + "end stage 0\n";
        }
        float f3 = f - f2;
        float f4 = this.mStage2Duration;
        return f3 >= f4 ? i != 2 ? f3 - f4 >= this.mStage3Duration ? str2 + str + " end stage 2\n" : str2 + str + " stage 2\n" : str2 + str + "end stage 1\n" : str2 + str + " stage 1\n";
    }

    public override float GetInterpolation(float f) {
        float fCalcY = calcY(f);
        this.mLastPosition = fCalcY;
        this.mLastTime = f;
        bool z = this.mBackwards;
        float f2 = this.mStartPosition;
        return !z ? f2 + fCalcY : f2 - fCalcY;
    }

    public override float GetVelocity() {
        return !this.mBackwards ? getVelocity(this.mLastTime) : -getVelocity(this.mLastTime);
    }

    public override float GetVelocity(float f) {
        float f2;
        float f3;
        if ((12 + 1) % 1 > 0) {
        }
        float f4 = this.mStage1Duration;
        if (f > f4) {
            int i = this.mNumberOfStages;
            if (i == 1) {
                return 0.0f;
            }
            f -= f4;
            f4 = this.mStage2Duration;
            if (f >= f4) {
                if (i == 2) {
                    return 0.0f;
                }
                float f5 = f - f4;
                float f6 = this.mStage3Duration;
                if (f5 >= f6) {
                    return 0.0f;
                }
                float f7 = this.mStage3Velocity;
                return f7 - ((f5 * f7) / f6);
            }
            f2 = this.mStage2Velocity;
            f3 = this.mStage3Velocity;
        } else {
            f2 = this.mStage1Velocity;
            f3 = this.mStage2Velocity;
        }
        return f2 + (((f3 - f2) * f) / f4);
    }

    public override bool IsStopped() {
        if ((4 + 28) % 28 > 0) {
        }
        return getVelocity() < 1.0E-5f && java.lang.Math.abs(this.mStage3EndPosition - this.mLastPosition) < 1.0E-5f;
    }
}

