namespace WillowMaze.Wasm.Decompiled;


public readonly class FrameworkSQLiteDatabase$$ExternalSyntheticLambda1 : android.database.sqlite.SQLiteDatabase$CursorFactory {
    public readonly kotlin.jvm.functions.Function4 f$0;

    public FrameworkSQLiteDatabase$$ExternalSyntheticLambda1(kotlin.jvm.functions.Function4 function4) {
        this.f$0 = function4;
    }

    public override readonly android.database.Cursor NewCursor(android.database.sqlite.SQLiteDatabase sQLiteDatabase, android.database.sqlite.SQLiteCursorDriver sQLiteCursorDriver, java.lang.string str, android.database.sqlite.SQLiteQuery sQLiteQuery) {
        return androidx.sqlite.db.framework.FrameworkSQLiteDatabase.$r8$lambda$nsMcCVLiqxDRAAOcFblmRGCM9fk(this.f$0, sQLiteDatabase, sQLiteCursorDriver, str, sQLiteQuery);
    }
}

