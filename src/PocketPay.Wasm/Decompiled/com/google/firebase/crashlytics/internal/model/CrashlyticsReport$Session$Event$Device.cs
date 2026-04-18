namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$Device {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Device$Builder();
    }

    public static void Builder(byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public abstract java.lang.double GetBatteryLevel();

    public abstract int GetBatteryVelocity();

    public abstract long GetDiskUsed();

    public abstract int GetOrientation();

    public abstract long GetRamUsed();

    public abstract bool IsProximityOn();
}

