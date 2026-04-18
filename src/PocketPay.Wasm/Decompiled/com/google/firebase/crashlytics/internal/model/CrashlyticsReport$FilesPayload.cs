namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$stringsPayload {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_stringsPayload$Builder();
    }

    public static void Builder(int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$string> getstrings();

    public abstract java.lang.string GetOrgId();

    abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder toBuilder();
}

