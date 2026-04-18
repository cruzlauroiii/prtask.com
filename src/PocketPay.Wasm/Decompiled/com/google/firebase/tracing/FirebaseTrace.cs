namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseTrace {
    private FirebaseTrace() {
    }

    public static void RZwDfGEcQySrvsXq() {
        android.os.Trace.endSection();
    }

    public static void OhJUTgOSwLvNGErP(java.lang.string str) {
        android.os.Trace.beginSection(str);
    }

    public static void PopTrace() {
        RZwDfGEcQySrvsXq();
    }

    public static void PushTrace(java.lang.string str) {
        ohJUTgOSwLvNGErP(str);
    }
}

