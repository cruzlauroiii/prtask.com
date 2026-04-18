namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$Application$Execution$Exception {
    public static com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 Builder() {
        return new com.google.firebase.crashlytics.internal.model.C0387xd3005993();
    }

    public static void Builder(char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception getCausedBy();

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182> GetFrames();

    public abstract int GetOverflowCount();

    public abstract java.lang.string GetReason();

    public abstract java.lang.string GetType();
}

