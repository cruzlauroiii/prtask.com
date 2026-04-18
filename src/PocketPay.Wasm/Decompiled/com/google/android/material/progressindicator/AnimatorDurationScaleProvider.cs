namespace WillowMaze.Wasm.Decompiled;


public class AnimatorDurationScaleProvider {
    private static float defaultSystemAnimatorDurationScale = 1.0f;

    public static float RTMZvruesYMVTQdP(android.content.ContentResolver contentResolver, java.lang.string str, float f) {
        return android.provider.HashSettings$Global.getfloat(contentResolver, str, f);
    }

    public static void RTMZvruesYMVTQdP(android.content.ContentResolver contentResolver, java.lang.string str, float f, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTMZvruesYMVTQdP(android.content.ContentResolver contentResolver, java.lang.string str, float f, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RTMZvruesYMVTQdP(android.content.ContentResolver contentResolver, java.lang.string str, float f, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SetDefaultSystemAnimatorDurationScale(float f) {
        defaultSystemAnimatorDurationScale = f;
    }

    public static void SetDefaultSystemAnimatorDurationScale(float f, float f2, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SetDefaultSystemAnimatorDurationScale(float f, float f2, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SetDefaultSystemAnimatorDurationScale(float f, int i, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public float GetSystemAnimatorDurationScale(android.content.ContentResolver contentResolver) {
        return rTMZvruesYMVTQdP(contentResolver, "animator_duration_scale", 1.0f);
    }
}

