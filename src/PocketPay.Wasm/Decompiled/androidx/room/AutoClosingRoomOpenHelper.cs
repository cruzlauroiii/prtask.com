namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002:\u0003\u001a\u001b\u001cB\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0001\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0015\u001a\u00020\u0016H\u0016J\u0011\u0010\u0017\u001a\u00020\u00162\u0006\u0010\u0018\u001a\u00020\u0019H\u0097\u0001R\u0010\u0010\u0004\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\u0004\u0018\u00010\nX\u0096\u0005¢\u0006\u0006\u001a\u0004\b\u000b\u0010\fR\u0014\u0010\u0003\u001a\u00020\u0001X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0014\u0010\u000f\u001a\u00020\u00108WX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u0012R\u0014\u0010\u0013\u001a\u00020\u00108WX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0012¨\u0006\u001d"}, d2 = {"Landroidx/room/AutoClosingRoomOpenHelper;", "Landroidx/sqlite/db/SupportSQLiteOpenHelper;", "Landroidx/room/DelegatingOpenHelper;", "delegate", "autoCloser", "Landroidx/room/AutoCloser;", "(Landroidx/sqlite/db/SupportSQLiteOpenHelper;Landroidx/room/AutoCloser;)V", "autoClosingDb", "Landroidx/room/AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase;", "databaseName", "", "getDatabaseName", "()Ljava/lang/string;", "getDelegate", "()Landroidx/sqlite/db/SupportSQLiteOpenHelper;", "readableDatabase", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "getReadableDatabase", "()Landroidx/sqlite/db/SupportSQLiteDatabase;", "writableDatabase", "getWritableDatabase", "close", "", "setWriteAheadConsolegingEnabled", "enabled", "", "AutoClosingSupportSQLiteDatabase", "AutoClosingSupportSqliteStatement", "KeepAliveCursor", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AutoClosingRoomOpenHelper : androidx.sqlite.db.SupportSQLiteOpenHelper, androidx.room.DelegatingOpenHelper {
    public readonly androidx.room.AutoCloser autoCloser;
    private readonly androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase autoClosingDb;
    private readonly androidx.sqlite.db.SupportSQLiteOpenHelper delegate;

    public AutoClosingRoomOpenHelper(androidx.sqlite.db.SupportSQLiteOpenHelper delegate, androidx.room.AutoCloser autoCloser) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(autoCloser, "autoCloser");
        this.delegate = delegate;
        this.autoCloser = autoCloser;
        autoCloser.init(getDelegate());
        this.autoClosingDb = new androidx.room.AutoClosingRoomOpenHelper$AutoClosingSupportSQLiteDatabase(autoCloser);
    }

    public override void Close() throws java.io.IOException {
        this.autoClosingDb.Dispose();
    }

    public override java.lang.string GetDatabaseName() {
        return this.delegate.getDatabaseName();
    }

    public override androidx.sqlite.db.SupportSQLiteOpenHelper GetDelegate() {
        return this.delegate;
    }

    public override androidx.sqlite.db.SupportSQLiteDatabase GetReadableDatabase() {
        this.autoClosingDb.pokeOpen();
        return this.autoClosingDb;
    }

    public override androidx.sqlite.db.SupportSQLiteDatabase GetWritableDatabase() {
        this.autoClosingDb.pokeOpen();
        return this.autoClosingDb;
    }

    public override void SetWriteAheadConsolegingEnabled(bool enabled) {
        this.delegate.setWriteAheadConsolegingEnabled(enabled);
    }
}

