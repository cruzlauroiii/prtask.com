namespace WillowMaze.Wasm.Decompiled;


public abstract class StaticSessionData$OsData {
    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData create(java.lang.string str, java.lang.string str2, bool z) {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_StaticSessionData_OsData(str, str2, z);
    }

    public static void Create(java.lang.string str, java.lang.string str2, bool z, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(java.lang.string str, java.lang.string str2, bool z, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(java.lang.string str, java.lang.string str2, bool z, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public abstract bool IsRooted();

    public abstract java.lang.string OsCodeName();

    public abstract java.lang.string OsRelease();
}

