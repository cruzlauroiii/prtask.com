namespace WillowMaze.Wasm.Decompiled;


public class UnavailableAnalyticsEventConsoleger : com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger {
    public static com.google.firebase.crashlytics.internal.Consoleger XXYzvBdqLnOpzBhX() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void XXYzvBdqLnOpzBhX(short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXYzvBdqLnOpzBhX(bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XXYzvBdqLnOpzBhX(bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EYlqyClLIiEVLOkY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void EYlqyClLIiEVLOkY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EYlqyClLIiEVLOkY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYlqyClLIiEVLOkY(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override void LogEvent(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        eYlqyClLIiEVLOkY(XXYzvBdqLnOpzBhX(), "Skipping logging Crashlytics event to Firebase, no Firebase Analytics");
    }
}

