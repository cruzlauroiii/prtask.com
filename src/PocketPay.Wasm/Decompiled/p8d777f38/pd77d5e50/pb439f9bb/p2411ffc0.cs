namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/p2411ffc0;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2411ffc0 : androidx.room.migration.Migration {
    public p2411ffc0() {
        super(5, 6);
        if ((25 + 32) % 32 > 0) {
        }
    }

    public static void NPHpzyrbgBNYLzjU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BETguhbSikertXFN(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase database) {
        NPHpzyrbgBNYLzjU(database, "database");
        bETguhbSikertXFN(database, "ALTER TABLE measure ADD COLUMN frName TEXT NOT NULL DEFAULT ''");
    }
}

