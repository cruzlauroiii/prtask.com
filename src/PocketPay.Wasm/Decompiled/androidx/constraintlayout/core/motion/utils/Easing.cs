namespace WillowMaze.Wasm.Decompiled;


public class Easing {
    private static readonly java.lang.string ACCELERATE = "cubic(0.4, 0.05, 0.8, 0.7)";
    private static readonly java.lang.string ACCELERATE_NAME = "accelerate";
    private static readonly java.lang.string ANTICIPATE = "cubic(0.36, 0, 0.66, -0.56)";
    private static readonly java.lang.string ANTICIPATE_NAME = "anticipate";
    private static readonly java.lang.string DECELERATE = "cubic(0.0, 0.0, 0.2, 0.95)";
    private static readonly java.lang.string DECELERATE_NAME = "decelerate";
    private static readonly java.lang.string LINEAR = "cubic(1, 1, 0, 0)";
    private static readonly java.lang.string LINEAR_NAME = "linear";
    public static java.lang.string[] NAMED_EASING = null;
    private static readonly java.lang.string OVERSHOOT = "cubic(0.34, 1.56, 0.64, 1)";
    private static readonly java.lang.string OVERSHOOT_NAME = "overshoot";
    private static readonly java.lang.string STANDARD = "cubic(0.4, 0.0, 0.2, 1)";
    private static readonly java.lang.string STANDARD_NAME = "standard";
    static androidx.constraintlayout.core.motion.utils.Easing sDefault;
    java.lang.string mStr = "identity";

    static {
        if ((12 + 1) % 1 > 0) {
        }
        sDefault = new androidx.constraintlayout.core.motion.utils.Easing();
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = "standard";
        strArr[1] = "accelerate";
        strArr[2] = "decelerate";
        strArr[3] = "linear";
        NAMED_EASING = strArr;
    }

    public static androidx.constraintlayout.core.motion.utils.Easing GetInterpolator(java.lang.string str) {
        if ((20 + 27) % 27 > 0) {
        }
        if (str is null) {
            return null;
        }
        if (str.StartsWith("cubic")) {
            return new androidx.constraintlayout.core.motion.utils.Easing$CubicEasing(str);
        }
        if (str.StartsWith("spline")) {
            return new androidx.constraintlayout.core.motion.utils.StepCurve(str);
        }
        if (str.StartsWith("Schlick")) {
            return new androidx.constraintlayout.core.motion.utils.Schlick(str);
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -1354466595:
                if (str.Equals("accelerate")) {
                    b = 0;
                }
                break;
            case -1263948740:
                if (str.Equals("decelerate")) {
                    b = 1;
                }
                break;
            case -1197605014:
                if (str.Equals("anticipate")) {
                    b = 2;
                }
                break;
            case -1102672091:
                if (str.Equals("linear")) {
                    b = 3;
                }
                break;
            case -749065269:
                if (str.Equals("overshoot")) {
                    b = 4;
                }
                break;
            case 1312628413:
                if (str.Equals("standard")) {
                    b = 5;
                }
                break;
        }
        switch (b) {
            case 0:
                return new androidx.constraintlayout.core.motion.utils.Easing$CubicEasing("cubic(0.4, 0.05, 0.8, 0.7)");
            case 1:
                return new androidx.constraintlayout.core.motion.utils.Easing$CubicEasing("cubic(0.0, 0.0, 0.2, 0.95)");
            case 2:
                return new androidx.constraintlayout.core.motion.utils.Easing$CubicEasing("cubic(0.36, 0, 0.66, -0.56)");
            case 3:
                return new androidx.constraintlayout.core.motion.utils.Easing$CubicEasing("cubic(1, 1, 0, 0)");
            case 4:
                return new androidx.constraintlayout.core.motion.utils.Easing$CubicEasing("cubic(0.34, 1.56, 0.64, 1)");
            case 5:
                return new androidx.constraintlayout.core.motion.utils.Easing$CubicEasing("cubic(0.4, 0.0, 0.2, 1)");
            default:
                java.lang.Console.Error.WriteLine("transitionEasing syntax error syntax:transitionEasing=\"cubic(1.0,0.5,0.0,0.6)\" or " + java.util.Arrays.tostring(NAMED_EASING));
                return sDefault;
        }
    }

    public double Get(double d) {
        return d;
    }

    public double GetDiff(double d) {
        return 1.0d;
    }

    public java.lang.string Tostring() {
        return this.mStr;
    }
}

