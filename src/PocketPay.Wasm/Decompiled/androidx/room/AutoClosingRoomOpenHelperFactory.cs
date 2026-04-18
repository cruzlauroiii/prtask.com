namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/room/AutoClosingRoomOpenHelperFactory;", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Factory;", "delegate", "autoCloser", "Landroidx/room/AutoCloser;", "(Landroidx/sqlite/db/SupportSQLiteOpenHelper$Factory;Landroidx/room/AutoCloser;)V", "create", "Landroidx/room/AutoClosingRoomOpenHelper;", "configuration", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Configuration;", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AutoClosingRoomOpenHelperFactory : androidx.sqlite.db.SupportSQLiteOpenHelper$Factory {
    private readonly androidx.room.AutoCloser autoCloser;
    private readonly androidx.sqlite.db.SupportSQLiteOpenHelper$Factory delegate;

    public AutoClosingRoomOpenHelperFactory(androidx.sqlite.db.SupportSQLiteOpenHelper$Factory delegate, androidx.room.AutoCloser autoCloser) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(autoCloser, "autoCloser");
        this.delegate = delegate;
        this.autoCloser = autoCloser;
    }

    public override androidx.room.AutoClosingRoomOpenHelper Create(androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration configuration) {
        if ((4 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        return new androidx.room.AutoClosingRoomOpenHelper(this.delegate.create(configuration), this.autoCloser);
    }

    public override androidx.sqlite.db.SupportSQLiteOpenHelper Create(androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration supportSQLiteOpenHelper$Configuration) {
        return create(supportSQLiteOpenHelper$Configuration);
    }
}

