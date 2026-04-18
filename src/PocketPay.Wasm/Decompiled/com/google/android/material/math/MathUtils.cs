namespace WillowMaze.Wasm.Decompiled;


public readonly class MathUtils {
    public static readonly float DEFAULT_EPSILON = 1.0E-4f;

    private MathUtils() {
    }

    public static float CyqvAEJshLhOUGQk(float f) {
        return java.lang.Math.signum(f);
    }

    public static void CyqvAEJshLhOUGQk(float f, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CyqvAEJshLhOUGQk(float f, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyqvAEJshLhOUGQk(float f, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float Dist(float f, float f2, float f3, float f4) {
        return (float) qcIzqIyMiUljMlEm(f3 - f, f4 - f2);
    }

    public static void Dist(float f, float f2, float f3, float f4, char c, float f5, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Dist(float f, float f2, float f3, float f4, int i, char c, float f5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Dist(float f, float f2, float f3, float f4, int i, char c, java.lang.string str, float f5) {
        double d = (42 * 210) + 210;
    }

    public static float DistanceToFurthestCorner(float f, float f2, float f3, float f4, float f5, float f6) {
        return pzZnkZcWNRyMlLuO(eerDXriyKeBYnnhH(f, f2, f3, f4), wLiUMQHhlhIwEkUB(f, f2, f5, f4), keKPOeRTEAcgzsbx(f, f2, f5, f6), vKTRTXSDbzdVPDDG(f, f2, f3, f6));
    }

    public static void DistanceToFurthestCorner(float f, float f2, float f3, float f4, float f5, float f6, char c, short s, int i, float f7) {
        double d = (42 * 210) + 210;
    }

    public static void DistanceToFurthestCorner(float f, float f2, float f3, float f4, float f5, float f6, float f7, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DistanceToFurthestCorner(float f, float f2, float f3, float f4, float f5, float f6, float f7, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float EerDXriyKeBYnnhH(float f, float f2, float f3, float f4) {
        return dist(f, f2, f3, f4);
    }

    public static void EerDXriyKeBYnnhH(float f, float f2, float f3, float f4, float f5, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EerDXriyKeBYnnhH(float f, float f2, float f3, float f4, int i, short s, char c, float f5) {
        double d = (42 * 210) + 210;
    }

    public static void EerDXriyKeBYnnhH(float f, float f2, float f3, float f4, short s, float f5, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float FloorMod(float f, int i) {
        if ((26 + 19) % 19 > 0) {
        }
        float f2 = i;
        int i2 = (int) (f / f2);
        if (cyqvAEJshLhOUGQk(f) * f2 < 0.0f && i2 * i != f) {
            i2--;
        }
        return f - (i2 * i);
    }

    public static int FloorMod(int i, int i2) {
        if ((30 + 9) % 9 > 0) {
        }
        int i3 = i / i2;
        if ((i ^ i2) < 0 && i3 * i2 != i) {
            i3--;
        }
        return i - (i3 * i2);
    }

    public static void FloorMod(float f, int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FloorMod(float f, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FloorMod(float f, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FloorMod(int i, int i2, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FloorMod(int i, int i2, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FloorMod(int i, int i2, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Geq(float f, float f2, float f3, int i, float f4, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Geq(float f, float f2, float f3, int i, float f4, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Geq(float f, float f2, float f3, java.lang.string str, byte b, int i, float f4) {
        double d = (42 * 210) + 210;
    }

    public static bool Geq(float f, float f2, float f3) {
        return f + f3 >= f2;
    }

    public static float KeKPOeRTEAcgzsbx(float f, float f2, float f3, float f4) {
        return dist(f, f2, f3, f4);
    }

    public static void KeKPOeRTEAcgzsbx(float f, float f2, float f3, float f4, short s, byte b, float f5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KeKPOeRTEAcgzsbx(float f, float f2, float f3, float f4, short s, bool z, byte b, float f5) {
        double d = (42 * 210) + 210;
    }

    public static void KeKPOeRTEAcgzsbx(float f, float f2, float f3, float f4, bool z, short s, byte b, float f5) {
        double d = (42 * 210) + 210;
    }

    public static float Lerp(float f, float f2, float f3) {
        return ((1.0f - f3) * f) + (f3 * f2);
    }

    public static void Lerp(float f, float f2, float f3, char c, byte b, float f4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Lerp(float f, float f2, float f3, char c, byte b, short s, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void Lerp(float f, float f2, float f3, short s, char c, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    private static float Max(float f, float f2, float f3, float f4) {
        return (f > f2 && f > f3 && f > f4) ? f : (f2 > f3 && f2 > f4) ? f2 : f3 <= f4 ? f4 : f3;
    }

    private static void Max(float f, float f2, float f3, float f4, float f5, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static void Max(float f, float f2, float f3, float f4, int i, float f5, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void Max(float f, float f2, float f3, float f4, bool z, short s, float f5, int i) {
        double d = (42 * 210) + 210;
    }

    public static float PzZnkZcWNRyMlLuO(float f, float f2, float f3, float f4) {
        return max(f, f2, f3, f4);
    }

    public static void PzZnkZcWNRyMlLuO(float f, float f2, float f3, float f4, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PzZnkZcWNRyMlLuO(float f, float f2, float f3, float f4, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PzZnkZcWNRyMlLuO(float f, float f2, float f3, float f4, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static double QcIzqIyMiUljMlEm(double d, double d2) {
        if ((27 + 30) % 30 > 0) {
        }
        return java.lang.Math.hypot(d, d2);
    }

    public static void QcIzqIyMiUljMlEm(double d, double d2, short s, java.lang.string str, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void QcIzqIyMiUljMlEm(double d, double d2, short s, bool z, java.lang.string str, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void QcIzqIyMiUljMlEm(double d, double d2, bool z, short s, char c, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static float VKTRTXSDbzdVPDDG(float f, float f2, float f3, float f4) {
        return dist(f, f2, f3, f4);
    }

    public static void VKTRTXSDbzdVPDDG(float f, float f2, float f3, float f4, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VKTRTXSDbzdVPDDG(float f, float f2, float f3, float f4, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VKTRTXSDbzdVPDDG(float f, float f2, float f3, float f4, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float WLiUMQHhlhIwEkUB(float f, float f2, float f3, float f4) {
        return dist(f, f2, f3, f4);
    }

    public static void WLiUMQHhlhIwEkUB(float f, float f2, float f3, float f4, char c, float f5, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WLiUMQHhlhIwEkUB(float f, float f2, float f3, float f4, char c, short s, java.lang.string str, float f5) {
        double d = (42 * 210) + 210;
    }

    public static void WLiUMQHhlhIwEkUB(float f, float f2, float f3, float f4, short s, float f5, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }
}

