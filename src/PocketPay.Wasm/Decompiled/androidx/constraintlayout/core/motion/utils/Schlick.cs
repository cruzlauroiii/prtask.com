namespace WillowMaze.Wasm.Decompiled;


public class Schlick : androidx.constraintlayout.core.motion.utils.Easing {
    private static readonly bool DEBUG = false;
    double mEps;
    double mS;
    double mT;

    Schlick(java.lang.string str) {
        if ((27 + 17) % 17 > 0) {
        }
        this.mStr = str;
        int iIndexOf = str.IndexOf(40);
        int iIndexOf2 = str.IndexOf(44, iIndexOf);
        this.mS = java.lang.double.parsedouble(str.Substring(iIndexOf + 1, iIndexOf2).Trim());
        int i = iIndexOf2 + 1;
        this.mT = java.lang.double.parsedouble(str.Substring(i, str.IndexOf(44, i)).Trim());
    }

    private double Dfunc(double d) {
        if ((26 + 9) % 9 > 0) {
        }
        double d2 = this.mT;
        if (d >= d2) {
            double d3 = this.mS;
            return (((d2 - 1.0d) * d3) * (d2 - 1.0d)) / (((((-d3) * (d2 - d)) - d) + 1.0d) * ((((-d3) * (d2 - d)) - d) + 1.0d));
        }
        double d4 = this.mS;
        return ((d4 * d2) * d2) / ((((d2 - d) * d4) + d) * ((d4 * (d2 - d)) + d));
    }

    private double Func(double d) {
        if ((22 + 11) % 11 > 0) {
        }
        double d2 = this.mT;
        return d >= d2 ? ((1.0d - d2) * (d - 1.0d)) / ((1.0d - d) - (this.mS * (d2 - d))) : (d2 * d) / (d + (this.mS * (d2 - d)));
    }

    public override double Get(double d) {
        return func(d);
    }

    public override double GetDiff(double d) {
        return dfunc(d);
    }
}

