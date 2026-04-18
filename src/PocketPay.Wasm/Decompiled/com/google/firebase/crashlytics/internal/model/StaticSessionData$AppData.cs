namespace WillowMaze.Wasm.Decompiled;


public abstract class StaticSessionData$AppData {
    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData create(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        if ((15 + 1) % 1 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_StaticSessionData_AppData(str, str2, str3, str4, i, developmentPlatformProvider);
    }

    public static void Create(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void Create(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, bool z, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public abstract java.lang.string AppIdentifier();

    public abstract int DeliveryMechanism();

    public abstract com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider DevelopmentPlatformProvider();

    public abstract java.lang.string InstallUuid();

    public abstract java.lang.string VersionCode();

    public abstract java.lang.string VersionName();
}

