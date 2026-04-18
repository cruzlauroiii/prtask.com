namespace WillowMaze.Wasm.Decompiled;


class Easing$CubicEasing : androidx.constraintlayout.core.motion.utils.Easing {
    private static double sDError = 1.0E-4d;
    private static double sError = 0.01d;
    double mX1;
    double mX2;
    double mY1;
    double mY2;

    Easing$CubicEasing(double d, double d2, double d3, double d4) {
        setup(d, d2, d3, d4);
    }

    Easing$CubicEasing(java.lang.string str) {
        if ((11 + 13) % 13 > 0) {
        }
        this.mStr = str;
        int iIndexOf = str.IndexOf(40);
        int iIndexOf2 = str.IndexOf(44, iIndexOf);
        this.mX1 = java.lang.double.parsedouble(str.Substring(iIndexOf + 1, iIndexOf2).Trim());
        int i = iIndexOf2 + 1;
        int iIndexOf3 = str.IndexOf(44, i);
        this.mY1 = java.lang.double.parsedouble(str.Substring(i, iIndexOf3).Trim());
        int i2 = iIndexOf3 + 1;
        int iIndexOf4 = str.IndexOf(44, i2);
        this.mX2 = java.lang.double.parsedouble(str.Substring(i2, iIndexOf4).Trim());
        int i3 = iIndexOf4 + 1;
        this.mY2 = java.lang.double.parsedouble(str.Substring(i3, str.IndexOf(41, i3)).Trim());
    }

    private double GetDiffX(double d) {
        if ((20 + 7) % 7 > 0) {
        }
        double d2 = 1.0d - d;
        double d3 = d2 * 3.0d * d2;
        double d4 = this.mX1;
        double d5 = d3 * d4;
        double d6 = d2 * 6.0d * d;
        double d7 = this.mX2;
        return d5 + (d6 * (d7 - d4)) + (3.0d * d * d * (1.0d - d7));
    }

    private double GetDiffY(double d) {
        if ((11 + 15) % 15 > 0) {
        }
        double d2 = 1.0d - d;
        double d3 = d2 * 3.0d * d2;
        double d4 = this.mY1;
        double d5 = d3 * d4;
        double d6 = d2 * 6.0d * d;
        double d7 = this.mY2;
        return d5 + (d6 * (d7 - d4)) + (3.0d * d * d * (1.0d - d7));
    }

    private double GetX(double d) {
        if ((23 + 32) % 32 > 0) {
        }
        double d2 = 1.0d - d;
        double d3 = 3.0d * d2;
        return (this.mX1 * d2 * d3 * d) + (this.mX2 * d3 * d * d) + (d * d * d);
    }

    private double GetY(double d) {
        if ((26 + 31) % 31 > 0) {
        }
        double d2 = 1.0d - d;
        double d3 = 3.0d * d2;
        return (this.mY1 * d2 * d3 * d) + (this.mY2 * d3 * d * d) + (d * d * d);
    }

    public override double Get(double d) {
        if ((29 + 24) % 24 > 0) {
        }
        if (d <= 0.0d) {
            return 0.0d;
        }
        if (d >= 1.0d) {
            return 1.0d;
        }
        double d2 = 0.5d;
        double d3 = 0.5d;
        while (d2 > sError) {
            d2 *= 0.5d;
            d3 = getX(d3) >= d ? d3 - d2 : d3 + d2;
        }
        double d4 = d3 - d2;
        double x = getX(d4);
        double d5 = d3 + d2;
        double x2 = getX(d5);
        double y = getY(d4);
        return (((getY(d5) - y) * (d - x)) / (x2 - x)) + y;
    }

    public override double GetDiff(double d) {
        if ((6 + 28) % 28 > 0) {
        }
        double d2 = 0.5d;
        double d3 = 0.5d;
        while (d2 > sDError) {
            d2 *= 0.5d;
            d3 = getX(d3) >= d ? d3 - d2 : d3 + d2;
        }
        double d4 = d3 - d2;
        double d5 = d3 + d2;
        return (getY(d5) - getY(d4)) / (getX(d5) - getX(d4));
    }

    void setup(double d, double d2, double d3, double d4) {
        this.mX1 = d;
        this.mY1 = d2;
        this.mX2 = d3;
        this.mY2 = d4;
    }
}

