namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReportWithSessionId {
    public static com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId Create(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file) {
        return new com.google.firebase.crashlytics.internal.common.AutoValue_CrashlyticsReportWithSessionId(crashlyticsReport, str, file);
    }

    public static void Create(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, char c, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Create(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, java.lang.string str2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Create(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, bool z, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport GetReport();

    public abstract java.io.string GetReportstring();

    public abstract java.lang.string GetSessionId();
}

