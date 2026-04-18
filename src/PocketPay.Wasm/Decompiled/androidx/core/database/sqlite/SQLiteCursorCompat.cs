namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteCursorCompat {
    private SQLiteCursorCompat() {
    }

    public static void SetFillWindowForwardOnly(android.database.sqlite.SQLiteCursor sQLiteCursor, bool z) {
        androidx.core.database.sqlite.SQLiteCursorCompat$Api28Impl.setFillWindowForwardOnly(sQLiteCursor, z);
    }
}

