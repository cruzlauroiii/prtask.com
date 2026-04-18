namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$Application$ProcessDetails {
    public static com.google.firebase.crashlytics.internal.model.AbstractC0412x9f440dcd Builder() {
        return new com.google.firebase.crashlytics.internal.model.C0399xcfe59936();
    }

    public static void Builder(java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public abstract int GetImportance();

    public abstract int GetPid();

    public abstract java.lang.string GetProcessName();

    public abstract bool IsDefaultProcess();
}

