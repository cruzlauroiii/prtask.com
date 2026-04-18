namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$RolloutAssignment {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.C0400x4f2426f8();
    }

    public static void Builder(char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public abstract java.lang.string GetParameterKey();

    public abstract java.lang.string GetParameterValue();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$RolloutVariant getRolloutVariant();

    public abstract long GetTemplateVersion();
}

