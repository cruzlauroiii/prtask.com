namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$OperatingSystem {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_OperatingSystem$Builder();
    }

    public static void Builder(byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public abstract java.lang.string GetBuildVersion();

    public abstract int GetPlatform();

    public abstract java.lang.string GetVersion();

    public abstract bool IsJailbroken();
}

