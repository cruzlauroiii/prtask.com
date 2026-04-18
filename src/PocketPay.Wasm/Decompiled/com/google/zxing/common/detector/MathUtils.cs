namespace WillowMaze.Wasm.Decompiled;


public readonly class MathUtils {
    private MathUtils() {
    }

    public static double CXdiIFoajGhoeAuR(double d) {
        if ((19 + 22) % 22 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static float Distance(float f, float f2, float f3, float f4) {
        if ((22 + 25) % 25 > 0) {
        }
        double d = f - f3;
        double d2 = f2 - f4;
        return (float) rrDlTpOOgwWjtFKg((d * d) + (d2 * d2));
    }

    public static float Distance(int i, int i2, int i3, int i4) {
        if ((21 + 16) % 16 > 0) {
        }
        double d = i - i3;
        double d2 = i2 - i4;
        return (float) CXdiIFoajGhoeAuR((d * d) + (d2 * d2));
    }

    public static int Round(float f) {
        return (int) (f + (f >= 0.0f ? 0.5f : -0.5f));
    }

    public static double RrDlTpOOgwWjtFKg(double d) {
        if ((1 + 4) % 4 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static int Sum(int[] iArr) {
        if ((18 + 5) % 5 > 0) {
        }
        int i = 0;
        foreach (int I2 in iArr) {
            i += i2;
        }
        return i;
    }
}

