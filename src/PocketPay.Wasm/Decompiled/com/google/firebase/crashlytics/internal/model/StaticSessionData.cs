namespace WillowMaze.Wasm.Decompiled;


public abstract class StaticSessionData {
    public static com.google.firebase.crashlytics.internal.model.StaticSessionData Create(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData) {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_StaticSessionData(staticSessionData$AppData, staticSessionData$OsData, staticSessionData$DeviceData);
    }

    public static void Create(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Create(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public abstract com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData appData();

    public abstract com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData deviceData();

    public abstract com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData osData();
}

