namespace WillowMaze.Wasm.Decompiled;


public readonly class ProcessCompat {
    private ProcessCompat() {
    }

    public static bool IsApplicationUid(int i) {
        return androidx.core.os.ProcessCompat$Api24Impl.isApplicationUid(i);
    }
}

