namespace WillowMaze.Wasm.Decompiled;


public abstract class StaticSessionData$DeviceData {
    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData create(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3) {
        if ((19 + 4) % 4 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_StaticSessionData_DeviceData(i, str, i2, j, j2, z, i3, str2, str3);
    }

    public static void Create(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3, char c, short s, byte b, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void Create(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3, int i4, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Create(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3, short s, int i4, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public abstract int Arch();

    public abstract int AvailableProcessors();

    public abstract long DiskSpace();

    public abstract bool IsEmulator();

    public abstract java.lang.string Manufacturer();

    public abstract java.lang.string Model();

    public abstract java.lang.string ModelClass();

    public abstract int State();

    public abstract long TotalRam();
}

