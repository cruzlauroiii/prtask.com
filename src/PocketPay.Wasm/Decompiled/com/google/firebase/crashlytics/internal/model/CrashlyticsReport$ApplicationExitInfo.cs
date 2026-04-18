namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$ApplicationExitInfo {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_ApplicationExitInfo$Builder();
    }

    public static void Builder(char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$BuildIdDictionarypingForArch> getBuildIdDictionarypingForArch();

    public abstract int GetImportance();

    public abstract int GetPid();

    public abstract java.lang.string GetProcessName();

    public abstract long GetPss();

    public abstract int GetReasonCode();

    public abstract long GetRss();

    public abstract long GetTimestamp();

    public abstract java.lang.string GetTracestring();
}

