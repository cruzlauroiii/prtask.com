namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$Application {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application$Builder();
    }

    public static void Builder(byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails> getAppProcessDetails();

    public abstract java.lang.bool GetBackground();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails getCurrentProcessDetails();

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute> getCustomAttributes();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution getExecution();

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute> getInternalKeys();

    public abstract int GetUiOrientation();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder toBuilder();
}

