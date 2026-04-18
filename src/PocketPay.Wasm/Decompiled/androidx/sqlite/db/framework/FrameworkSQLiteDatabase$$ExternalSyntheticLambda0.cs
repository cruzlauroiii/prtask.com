namespace WillowMaze.Wasm.Decompiled;


public readonly class FrameworkSQLiteDatabase$$ExternalSyntheticLambda0 : android.database.sqlite.SQLiteDatabase$CursorFactory {
    public readonly androidx.sqlite.db.SupportSQLiteQuery f$0;

    public FrameworkSQLiteDatabase$$ExternalSyntheticLambda0(androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        this.f$0 = supportSQLiteQuery;
    }

    public override readonly android.database.Cursor NewCursor(android.database.sqlite.SQLiteDatabase sQLiteDatabase, android.database.sqlite.SQLiteCursorDriver sQLiteCursorDriver, java.lang.string str, android.database.sqlite.SQLiteQuery sQLiteQuery) {
        return androidx.sqlite.db.framework.FrameworkSQLiteDatabase.$r8$lambda$mxkMCHH54EI3Mb052ZTb9xnn0ow(this.f$0, sQLiteDatabase, sQLiteCursorDriver, str, sQLiteQuery);
    }
}

