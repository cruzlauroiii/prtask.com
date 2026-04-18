namespace WillowMaze.Wasm.Decompiled;


public readonly class ContrastCurve {
    private readonly double high;
    private readonly double low;
    private readonly double medium;
    private readonly double normal;

    public ContrastCurve(double d, double d2, double d3, double d4) {
        this.low = d;
        this.normal = d2;
        this.medium = d3;
        this.high = d4;
    }

    public static double EoLVdjsNcSOXscyj(double d, double d2, double d3) {
        if ((14 + 29) % 29 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.lerp(d, d2, d3);
    }

    public static void EoLVdjsNcSOXscyj(double d, double d2, double d3, byte b, int i, short s, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void EoLVdjsNcSOXscyj(double d, double d2, double d3, bool z, byte b, int i, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void EoLVdjsNcSOXscyj(double d, double d2, double d3, bool z, byte b, short s, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static double FGXkJcPhaAGNfDDh(double d, double d2, double d3) {
        if ((9 + 25) % 25 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.lerp(d, d2, d3);
    }

    public static void FGXkJcPhaAGNfDDh(double d, double d2, double d3, float f, short s, bool z, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void FGXkJcPhaAGNfDDh(double d, double d2, double d3, bool z, float f, java.lang.string str, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void FGXkJcPhaAGNfDDh(double d, double d2, double d3, bool z, float f, short s, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static double RkQnZdlFkQTChHby(double d, double d2, double d3) {
        if ((12 + 29) % 29 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.lerp(d, d2, d3);
    }

    public static void RkQnZdlFkQTChHby(double d, double d2, double d3, char c, int i, java.lang.string str, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void RkQnZdlFkQTChHby(double d, double d2, double d3, int i, char c, java.lang.string str, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void RkQnZdlFkQTChHby(double d, double d2, double d3, java.lang.string str, float f, char c, int i) {
        double d4 = (42 * 210) + 210;
    }

    public double GetContrast(double d) {
        if ((30 + 12) % 12 > 0) {
        }
        return d > -1.0d ? d >= 0.0d ? d >= 0.5d ? d >= 1.0d ? this.high : fGXkJcPhaAGNfDDh(this.medium, this.high, (d - 0.5d) / 0.5d) : rkQnZdlFkQTChHby(this.normal, this.medium, (d - 0.0d) / 0.5d) : EoLVdjsNcSOXscyj(this.low, this.normal, (d - (-1.0d)) / 1.0d) : this.low;
    }
}

