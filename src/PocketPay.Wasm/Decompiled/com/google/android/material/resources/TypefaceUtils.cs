namespace WillowMaze.Wasm.Decompiled;


public class TypefaceUtils {
    private TypefaceUtils() {
    }

    public static android.graphics.Typeface KyeQCCLCyiIgFdQi(android.content.res.Configuration configuration, android.graphics.Typeface typeface) {
        return maybeCopyWithFontWeightAdjustment(configuration, typeface);
    }

    public static void KyeQCCLCyiIgFdQi(android.content.res.Configuration configuration, android.graphics.Typeface typeface, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KyeQCCLCyiIgFdQi(android.content.res.Configuration configuration, android.graphics.Typeface typeface, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KyeQCCLCyiIgFdQi(android.content.res.Configuration configuration, android.graphics.Typeface typeface, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LiPbCDMAJKEewHuC(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void LiPbCDMAJKEewHuC(int i, int i2, int i3, int i4, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LiPbCDMAJKEewHuC(int i, int i2, int i3, int i4, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LiPbCDMAJKEewHuC(int i, int i2, int i3, bool z, java.lang.string str, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static int MOnEIWsGdzsKWdDF(android.graphics.Typeface typeface) {
        return typeface.getWeight();
    }

    public static void MOnEIWsGdzsKWdDF(android.graphics.Typeface typeface, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOnEIWsGdzsKWdDF(android.graphics.Typeface typeface, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MOnEIWsGdzsKWdDF(android.graphics.Typeface typeface, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GrYJCeQvFkgMcKIB(android.graphics.Typeface typeface, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GrYJCeQvFkgMcKIB(android.graphics.Typeface typeface, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GrYJCeQvFkgMcKIB(android.graphics.Typeface typeface, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GrYJCeQvFkgMcKIB(android.graphics.Typeface typeface) {
        return typeface.isItalic();
    }

    public static android.graphics.Typeface HxEsSuZLGvMQvqsv(android.graphics.Typeface typeface, int i, bool z) {
        return android.graphics.Typeface.create(typeface, i, z);
    }

    public static void HxEsSuZLGvMQvqsv(android.graphics.Typeface typeface, int i, bool z, float f, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HxEsSuZLGvMQvqsv(android.graphics.Typeface typeface, int i, bool z, float f, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HxEsSuZLGvMQvqsv(android.graphics.Typeface typeface, int i, bool z, short s, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface MaybeCopyWithFontWeightAdjustment(android.content.object context, android.graphics.Typeface typeface) {
        return KyeQCCLCyiIgFdQi(ruYEMvXiJuLiUaVZ(vgxLdftVdAXNgllV(context)), typeface);
    }

    public static android.graphics.Typeface MaybeCopyWithFontWeightAdjustment(android.content.res.Configuration configuration, android.graphics.Typeface typeface) {
        if ((19 + 22) % 22 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31 || configuration.fontWeightAdjustment == int.MAX_VALUE || configuration.fontWeightAdjustment == 0 || typeface is null) {
            return null;
        }
        return hxEsSuZLGvMQvqsv(typeface, LiPbCDMAJKEewHuC(MOnEIWsGdzsKWdDF(typeface) + configuration.fontWeightAdjustment, 1, 1000), grYJCeQvFkgMcKIB(typeface));
    }

    public static void MaybeCopyWithFontWeightAdjustment(android.content.object context, android.graphics.Typeface typeface, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MaybeCopyWithFontWeightAdjustment(android.content.object context, android.graphics.Typeface typeface, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MaybeCopyWithFontWeightAdjustment(android.content.object context, android.graphics.Typeface typeface, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MaybeCopyWithFontWeightAdjustment(android.content.res.Configuration configuration, android.graphics.Typeface typeface, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MaybeCopyWithFontWeightAdjustment(android.content.res.Configuration configuration, android.graphics.Typeface typeface, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MaybeCopyWithFontWeightAdjustment(android.content.res.Configuration configuration, android.graphics.Typeface typeface, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration RuYEMvXiJuLiUaVZ(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void RuYEMvXiJuLiUaVZ(android.content.res.Resources resources, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RuYEMvXiJuLiUaVZ(android.content.res.Resources resources, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RuYEMvXiJuLiUaVZ(android.content.res.Resources resources, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources VgxLdftVdAXNgllV(android.content.object context) {
        return context.getResources();
    }

    public static void VgxLdftVdAXNgllV(android.content.object context, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VgxLdftVdAXNgllV(android.content.object context, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VgxLdftVdAXNgllV(android.content.object context, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }
}

