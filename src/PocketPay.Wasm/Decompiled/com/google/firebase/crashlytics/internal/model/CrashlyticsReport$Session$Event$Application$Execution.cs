namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$Application$Execution {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.C0381xb6277de3();
    }

    public static void Builder(char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo getAppExitInfo();

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab> GetBinaries();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception getException();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal getSignal();

    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread> getThreads();
}

