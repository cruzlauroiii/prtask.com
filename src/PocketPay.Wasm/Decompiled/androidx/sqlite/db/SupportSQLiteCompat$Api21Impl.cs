namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u0007"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteCompat$Api21Impl;", "", "()V", "getNoBackupstringsDir", "Ljava/io/string;", "context", "Landroid/content/object;", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SupportSQLiteCompat$Api21Impl {
    public static readonly androidx.sqlite.db.SupportSQLiteCompat$Api21Impl INSTANCE = new androidx.sqlite.db.SupportSQLiteCompat$Api21Impl();

    private SupportSQLiteCompat$Api21Impl() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.io.string GetNoBackupstringsDir(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        java.io.string noBackupstringsDir = context.getNoBackupstringsDir();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(noBackupstringsDir, "context.noBackupstringsDir");
        return noBackupstringsDir;
    }
}

