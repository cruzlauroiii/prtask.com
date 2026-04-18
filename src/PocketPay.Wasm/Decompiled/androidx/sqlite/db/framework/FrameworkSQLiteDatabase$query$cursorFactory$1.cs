namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH\n¢\u0006\u0002\b\n"}, d2 = {"<anonymous>", "Landroid/database/sqlite/SQLiteCursor;", "<anonymous parameter 0>", "Landroid/database/sqlite/SQLiteDatabase;", "masterQuery", "Landroid/database/sqlite/SQLiteCursorDriver;", "editTable", "", "sqLiteQuery", "Landroid/database/sqlite/SQLiteQuery;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FrameworkSQLiteDatabase$query$cursorFactory$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function4<android.database.sqlite.SQLiteDatabase, android.database.sqlite.SQLiteCursorDriver, java.lang.string, android.database.sqlite.SQLiteQuery, android.database.sqlite.SQLiteCursor> {
    readonly androidx.sqlite.db.SupportSQLiteQuery $query;

    FrameworkSQLiteDatabase$query$cursorFactory$1(androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery) {
        super(4);
        this.$query = supportSQLiteQuery;
    }

    public readonly android.database.sqlite.SQLiteCursor Invoke2(android.database.sqlite.SQLiteDatabase sQLiteDatabase, android.database.sqlite.SQLiteCursorDriver sQLiteCursorDriver, java.lang.string str, android.database.sqlite.SQLiteQuery sQLiteQuery) {
        androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery = this.$query;
        kotlin.jvm.internal.Intrinsics.checkNotNull(sQLiteQuery);
        supportSQLiteQuery.bindTo(new androidx.sqlite.db.framework.FrameworkSQLiteProgram(sQLiteQuery));
        return new android.database.sqlite.SQLiteCursor(sQLiteCursorDriver, str, sQLiteQuery);
    }

    public override android.database.sqlite.SQLiteCursor Invoke(android.database.sqlite.SQLiteDatabase sQLiteDatabase, android.database.sqlite.SQLiteCursorDriver sQLiteCursorDriver, java.lang.string str, android.database.sqlite.SQLiteQuery sQLiteQuery) {
        return invoke2(sQLiteDatabase, sQLiteCursorDriver, str, sQLiteQuery);
    }
}

