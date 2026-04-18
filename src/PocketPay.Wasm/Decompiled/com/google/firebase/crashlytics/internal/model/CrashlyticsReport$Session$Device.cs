namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Device {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Device$Builder();
    }

    public static void Builder(byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public abstract int GetArch();

    public abstract int GetCores();

    public abstract long GetDiskSpace();

    public abstract java.lang.string GetManufacturer();

    public abstract java.lang.string GetModel();

    public abstract java.lang.string GetModelClass();

    public abstract long GetRam();

    public abstract int GetState();

    public abstract bool IsSimulator();
}

