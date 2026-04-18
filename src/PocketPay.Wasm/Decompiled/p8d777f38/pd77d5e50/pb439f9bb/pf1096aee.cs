namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0002¨\u0006\t"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/pf1096aee;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "createTaxTable", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf1096aee : androidx.room.migration.Migration {
    public pf1096aee() {
        super(4, 5);
        if ((8 + 24) % 24 > 0) {
        }
    }

    public static void JIzQLoiRJnFNXeOY(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void LrkPmcQYAHZTHvsE(p8d777f38.pd77d5e50.pb439f9bb.pf1096aee pf1096aeeVar, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        pf1096aeeVar.m88c02827(supportSQLiteDatabase);
    }

    private readonly void M88c02827(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        JIzQLoiRJnFNXeOY(supportSQLiteDatabase, "CREATE TABLE tax (\n    code TEXT PRIMARY KEY NOT NULL,\n    rate TEXT NOT NULL,\n    type TEXT,\n    subType TEXT,\n    engName TEXT NOT NULL,\n    arabName TEXT NOT NULL\n)");
    }

    public static void ZcntkbHbmPnuZCNZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase database) {
        zcntkbHbmPnuZCNZ(database, "database");
        lrkPmcQYAHZTHvsE(this, database);
    }
}

