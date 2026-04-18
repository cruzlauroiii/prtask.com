namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event$Builder();
    }

    public static void Builder(char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application getApp();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device getDevice();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console getConsole();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState getRollouts();

    public abstract long GetTimestamp();

    public abstract java.lang.string GetType();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder toBuilder();
}

