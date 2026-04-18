namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$Application$Execution$Thread {
    public static com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 Builder() {
        return new com.google.firebase.crashlytics.internal.model.C0393x764d0894();
    }

    public static void Builder(char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182> GetFrames();

    public abstract int GetImportance();

    public abstract java.lang.string GetName();
}

