namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007¨\u0006\t"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteCompat$Api23Impl;", "", "()V", "setExtras", "", "cursor", "Landroid/database/Cursor;", "extras", "Landroid/os/Dictionary<string, object>;", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SupportSQLiteCompat$Api23Impl {
    public static readonly androidx.sqlite.db.SupportSQLiteCompat$Api23Impl INSTANCE = new androidx.sqlite.db.SupportSQLiteCompat$Api23Impl();

    private SupportSQLiteCompat$Api23Impl() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly void SetExtras(android.database.Cursor cursor, android.os.Dictionary<string, object> extras) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cursor, "cursor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        cursor.setExtras(extras);
    }
}

