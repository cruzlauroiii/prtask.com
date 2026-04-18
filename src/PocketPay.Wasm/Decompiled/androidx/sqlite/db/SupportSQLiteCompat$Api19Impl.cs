namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0007¨\u0006\u000b"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteCompat$Api19Impl;", "", "()V", "getNotificationUri", "Landroid/net/Uri;", "cursor", "Landroid/database/Cursor;", "isLowRamDevice", "", "activityManager", "Landroid/app/objectManager;", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SupportSQLiteCompat$Api19Impl {
    public static readonly androidx.sqlite.db.SupportSQLiteCompat$Api19Impl INSTANCE = new androidx.sqlite.db.SupportSQLiteCompat$Api19Impl();

    private SupportSQLiteCompat$Api19Impl() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly android.net.Uri GetNotificationUri(android.database.Cursor cursor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cursor, "cursor");
        android.net.Uri notificationUri = cursor.getNotificationUri();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(notificationUri, "cursor.notificationUri");
        return notificationUri;
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool IsLowRamDevice(android.app.objectManager activityManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activityManager, "activityManager");
        return activityManager.isLowRamDevice();
    }
}

