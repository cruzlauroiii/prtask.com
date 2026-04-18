namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b¨\u0006\t"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$OpenHelper$Companion;", "", "()V", "getWrappedDb", "Landroidx/sqlite/db/framework/FrameworkSQLiteDatabase;", "refHolder", "Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$DBRefHolder;", "sqLiteDatabase", "Landroid/database/sqlite/SQLiteDatabase;", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FrameworkSQLiteOpenHelper$OpenHelper$Companion {
    private FrameworkSQLiteOpenHelper$OpenHelper$Companion() {
    }

    public FrameworkSQLiteOpenHelper$OpenHelper$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly androidx.sqlite.db.framework.FrameworkSQLiteDatabase GetWrappedDb(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder refHolder, android.database.sqlite.SQLiteDatabase sqLiteDatabase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(refHolder, "refHolder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sqLiteDatabase, "sqLiteDatabase");
        androidx.sqlite.db.framework.FrameworkSQLiteDatabase db = refHolder.getDb();
        if (db is not null && db.isDelegate(sqLiteDatabase)) {
            return db;
        }
        androidx.sqlite.db.framework.FrameworkSQLiteDatabase frameworkSQLiteDatabase = new androidx.sqlite.db.framework.FrameworkSQLiteDatabase(sqLiteDatabase);
        refHolder.setDb(frameworkSQLiteDatabase);
        return frameworkSQLiteDatabase;
    }
}

