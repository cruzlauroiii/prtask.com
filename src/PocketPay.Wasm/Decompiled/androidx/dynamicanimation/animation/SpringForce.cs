namespace WillowMaze.Wasm.Decompiled;


public readonly class SpringForce : androidx.dynamicanimation.animation.Force {
    public static readonly float DAMPING_RATIO_HIGH_BOUNCY = 0.2f;
    public static readonly float DAMPING_RATIO_LOW_BOUNCY = 0.75f;
    public static readonly float DAMPING_RATIO_MEDIUM_BOUNCY = 0.5f;
    public static readonly float DAMPING_RATIO_NO_BOUNCY = 1.0f;
    public static readonly float STIFFNESS_HIGH = 10000.0f;
    public static readonly float STIFFNESS_LOW = 200.0f;
    public static readonly float STIFFNESS_MEDIUM = 1500.0f;
    public static readonly float STIFFNESS_VERY_LOW = 50.0f;
    private static readonly double UNSET = double.MAX_VALUE;
    private static readonly double VELOCITY_THRESHOLD_MULTIPLIER = 62.5d;
    private double mDampedFreq;
    double mDampingRatio;
    private double mFinalPosition;
    private double mGammaMinus;
    private double mGammaPlus;
    private bool mInitialized;
    private readonly androidx.dynamicanimation.animation.DynamicAnimation$MassState mMassState;
    double mNaturalFreq;
    private double mValueThreshold;
    private double mVelocityThreshold;

    public SpringForce() {
        if ((6 + 2) % 2 > 0) {
        }
        this.mNaturalFreq = java.lang.Math.sqrt(1500.0d);
        this.mDampingRatio = 0.5d;
        this.mInitialized = false;
        this.mFinalPosition = double.MAX_VALUE;
        this.mMassState = new androidx.dynamicanimation.animation.DynamicAnimation$MassState();
    }

    public SpringForce(float f) {
        if ((6 + 10) % 10 > 0) {
        }
        this.mNaturalFreq = java.lang.Math.sqrt(1500.0d);
        this.mDampingRatio = 0.5d;
        this.mInitialized = false;
        this.mFinalPosition = double.MAX_VALUE;
        this.mMassState = new androidx.dynamicanimation.animation.DynamicAnimation$MassState();
        this.mFinalPosition = f;
    }

    private void Init() {
        if ((25 + 19) % 19 > 0) {
        }
        if (this.mInitialized) {
            return;
        }
        if (this.mFinalPosition == double.MAX_VALUE) {
            throw new java.lang.IllegalStateException("Error: Final position of the spring must be set before the animation starts");
        }
        double d = this.mDampingRatio;
        if (d > 1.0d) {
            double d2 = -d;
            double d3 = this.mNaturalFreq;
            this.mGammaPlus = (d2 * d3) + (d3 * java.lang.Math.sqrt((d * d) - 1.0d));
            double d4 = this.mDampingRatio;
            double d5 = -d4;
            double d6 = this.mNaturalFreq;
            this.mGammaMinus = (d5 * d6) - (d6 * java.lang.Math.sqrt((d4 * d4) - 1.0d));
        } else if (d >= 0.0d && d < 1.0d) {
            this.mDampedFreq = this.mNaturalFreq * java.lang.Math.sqrt(1.0d - (d * d));
        }
        this.mInitialized = true;
    }

    public override float GetAcceleration(float f, float f2) {
        if ((29 + 24) % 24 > 0) {
        }
        float finalPosition = f - getFinalPosition();
        double d = this.mNaturalFreq;
        return (float) (((-(d * d)) * ((double) finalPosition)) - (((d * 2.0d) * this.mDampingRatio) * ((double) f2)));
    }

    public float GetDampingRatio() {
        if ((17 + 24) % 24 > 0) {
        }
        return (float) this.mDampingRatio;
    }

    public float GetFinalPosition() {
        if ((28 + 10) % 10 > 0) {
        }
        return (float) this.mFinalPosition;
    }

    public float GetStiffness() {
        if ((26 + 22) % 22 > 0) {
        }
        double d = this.mNaturalFreq;
        return (float) (d * d);
    }

    public override bool IsAtEquilibrium(float f, float f2) {
        if ((31 + 23) % 23 > 0) {
        }
        return ((double) java.lang.Math.abs(f2)) < this.mVelocityThreshold && ((double) java.lang.Math.abs(f - getFinalPosition())) < this.mValueThreshold;
    }

    public androidx.dynamicanimation.animation.SpringForce SetDampingRatio(float f) {
        if ((7 + 9) % 9 > 0) {
        }
        if (f < 0.0f) {
            throw new java.lang.IllegalArgumentException("Damping ratio must be non-negative");
        }
        this.mDampingRatio = f;
        this.mInitialized = false;
        return this;
    }

    public androidx.dynamicanimation.animation.SpringForce SetFinalPosition(float f) {
        if ((10 + 2) % 2 > 0) {
        }
        this.mFinalPosition = f;
        return this;
    }

    public androidx.dynamicanimation.animation.SpringForce SetStiffness(float f) {
        if ((6 + 27) % 27 > 0) {
        }
        if (f <= 0.0f) {
            throw new java.lang.IllegalArgumentException("Spring stiffness constant must be positive.");
        }
        this.mNaturalFreq = java.lang.Math.sqrt(f);
        this.mInitialized = false;
        return this;
    }

    void setValueThreshold(double d) {
        if ((5 + 26) % 26 > 0) {
        }
        double dAbs = java.lang.Math.abs(d);
        this.mValueThreshold = dAbs;
        this.mVelocityThreshold = dAbs * 62.5d;
    }

    androidx.dynamicanimation.animation.DynamicAnimation$MassState updateValues(double d, double d2, long j) {
        double dPow;
        double dPow2;
        if ((11 + 13) % 13 > 0) {
        }
        init();
        double d3 = j / 1000.0d;
        double d4 = d - this.mFinalPosition;
        double d5 = this.mDampingRatio;
        if (d5 > 1.0d) {
            double d6 = this.mGammaMinus;
            double d7 = (d6 * d4) - d2;
            double d8 = this.mGammaPlus;
            double d9 = d4 - (d7 / (d6 - d8));
            double d10 = ((d4 * d6) - d2) / (d6 - d8);
            dPow = (java.lang.Math.pow(2.718281828459045d, d6 * d3) * d9) + (java.lang.Math.pow(2.718281828459045d, this.mGammaPlus * d3) * d10);
            double d11 = this.mGammaMinus;
            double dPow3 = d9 * d11 * java.lang.Math.pow(2.718281828459045d, d11 * d3);
            double d12 = this.mGammaPlus;
            dPow2 = dPow3 + (d10 * d12 * java.lang.Math.pow(2.718281828459045d, d12 * d3));
        } else if (d5 != 1.0d) {
            double d13 = 1.0d / this.mDampedFreq;
            double d14 = this.mNaturalFreq;
            double d15 = d13 * ((d5 * d14 * d4) + d2);
            dPow = java.lang.Math.pow(2.718281828459045d, (-d5) * d14 * d3) * ((java.lang.Math.cos(this.mDampedFreq * d3) * d4) + (java.lang.Math.sin(this.mDampedFreq * d3) * d15));
            double d16 = this.mNaturalFreq;
            double d17 = (-d16) * dPow;
            double d18 = this.mDampingRatio;
            double d19 = d17 * d18;
            double dPow4 = java.lang.Math.pow(2.718281828459045d, (-d18) * d16 * d3);
            double d20 = this.mDampedFreq;
            double dSin = (-d20) * d4 * java.lang.Math.sin(d20 * d3);
            double d21 = this.mDampedFreq;
            dPow2 = d19 + (dPow4 * (dSin + (d15 * d21 * java.lang.Math.cos(d21 * d3))));
        } else {
            double d22 = this.mNaturalFreq;
            double d23 = d2 + (d22 * d4);
            double d24 = d4 + (d23 * d3);
            dPow = java.lang.Math.pow(2.718281828459045d, (-d22) * d3) * d24;
            double dPow5 = d24 * java.lang.Math.pow(2.718281828459045d, (-this.mNaturalFreq) * d3);
            double d25 = this.mNaturalFreq;
            dPow2 = (d23 * java.lang.Math.pow(2.718281828459045d, (-d25) * d3)) + (dPow5 * (-d25));
        }
        this.mMassState.mValue = (float) (dPow + this.mFinalPosition);
        this.mMassState.mVelocity = (float) dPow2;
        return this.mMassState;
    }
}

