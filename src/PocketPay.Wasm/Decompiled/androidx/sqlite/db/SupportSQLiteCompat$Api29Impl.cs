namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u0007H\u0007J(\u0010\b\u001a\u00020\t2\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000b2\u000e\u0010\f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00050\u0004H\u0007¨\u0006\r"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteCompat$Api29Impl;", "", "()V", "getNotificationUris", "", "Landroid/net/Uri;", "cursor", "Landroid/database/Cursor;", "setNotificationUris", "", "cr", "Landroid/content/ContentResolver;", "uris", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SupportSQLiteCompat$Api29Impl {
    public static readonly androidx.sqlite.db.SupportSQLiteCompat$Api29Impl INSTANCE = new androidx.sqlite.db.SupportSQLiteCompat$Api29Impl();

    private SupportSQLiteCompat$Api29Impl() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.util.List<android.net.Uri> GetNotificationUris(android.database.Cursor cursor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cursor, "cursor");
        java.util.List<android.net.Uri> notificationUris = cursor.getNotificationUris();
        kotlin.jvm.internal.Intrinsics.checkNotNull(notificationUris);
        return notificationUris;
    }

    @kotlin.jvm.JvmStatic
    public static readonly void SetNotificationUris(android.database.Cursor cursor, android.content.ContentResolver cr, java.util.List<? : android.net.Uri> uris) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cursor, "cursor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cr, "cr");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uris, "uris");
        cursor.setNotificationUris(cr, uris);
    }
}

