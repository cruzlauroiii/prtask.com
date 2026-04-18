namespace WillowMaze.Wasm.Decompiled;


public class ReversableAnimatedValueInterpolator : android.animation.TimeInterpolator {
    private readonly android.animation.TimeInterpolator sourceInterpolator;

    public ReversableAnimatedValueInterpolator(android.animation.TimeInterpolator timeInterpolator) {
        this.sourceInterpolator = timeInterpolator;
    }

    public static float CEQoTePJlZBEpWxU(android.animation.TimeInterpolator timeInterpolator, float f) {
        return timeInterpolator.getInterpolation(f);
    }

    public static void CEQoTePJlZBEpWxU(android.animation.TimeInterpolator timeInterpolator, float f, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CEQoTePJlZBEpWxU(android.animation.TimeInterpolator timeInterpolator, float f, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CEQoTePJlZBEpWxU(android.animation.TimeInterpolator timeInterpolator, float f, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator Of(bool z, android.animation.TimeInterpolator timeInterpolator) {
        return !z ? new com.google.android.material.internal.ReversableAnimatedValueInterpolator(timeInterpolator) : timeInterpolator;
    }

    public static void Of(bool z, android.animation.TimeInterpolator timeInterpolator, byte b, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void Of(bool z, android.animation.TimeInterpolator timeInterpolator, byte b, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Of(bool z, android.animation.TimeInterpolator timeInterpolator, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override float GetInterpolation(float f) {
        return 1.0f - cEQoTePJlZBEpWxU(this.sourceInterpolator, f);
    }
}

