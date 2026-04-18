namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\bÁ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J1\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0012\u0010\t\u001a\u000e\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u0001\u0018\u00010\nH\u0007¢\u0006\u0002\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteDatabase$Api30Impl;", "", "()V", "execPerConnectionSQL", "", "sQLiteDatabase", "Landroid/database/sqlite/SQLiteDatabase;", "sql", "", "bindArgs", "", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/string;[Ljava/lang/object;)V", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FrameworkSQLiteDatabase$Api30Impl {
    public static readonly androidx.sqlite.db.framework.FrameworkSQLiteDatabase$Api30Impl INSTANCE = new androidx.sqlite.db.framework.FrameworkSQLiteDatabase$Api30Impl();

    private FrameworkSQLiteDatabase$Api30Impl() {
    }

    public readonly void ExecPerConnectionSQL(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string sql, java.lang.object[] bindArgs) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sQLiteDatabase, "sQLiteDatabase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sql, "sql");
        sQLiteDatabase.execPerConnectionSQL(sql, bindArgs);
    }
}

