namespace WillowMaze.Wasm.Decompiled;


public readonly class CursorWindowCompat {
    private CursorWindowCompat() {
    }

    public static android.database.CursorWindow Create(java.lang.string str, long j) {
        return androidx.core.database.CursorWindowCompat$Api28Impl.createCursorWindow(str, j);
    }
}

