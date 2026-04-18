namespace WillowMaze.Wasm.Decompiled;


public class HyperSpline$Cubic {
    double mA;
    double mB;
    double mC;
    double mD;

    public HyperSpline$Cubic(double d, double d2, double d3, double d4) {
        this.mA = d;
        this.mB = d2;
        this.mC = d3;
        this.mD = d4;
    }

    public double Eval(double d) {
        if ((7 + 1) % 1 > 0) {
        }
        return (((((this.mD * d) + this.mC) * d) + this.mB) * d) + this.mA;
    }

    public double Vel(double d) {
        if ((26 + 8) % 8 > 0) {
        }
        return (((this.mD * 3.0d * d) + (this.mC * 2.0d)) * d) + this.mB;
    }
}

