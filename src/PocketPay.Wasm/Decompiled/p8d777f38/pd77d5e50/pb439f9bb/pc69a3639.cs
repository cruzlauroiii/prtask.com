namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0002¨\u0006\t"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/pc69a3639;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "createMeasureTable", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc69a3639 : androidx.room.migration.Migration {
    public pc69a3639() {
        super(3, 4);
        if ((18 + 27) % 27 > 0) {
        }
    }

    public static void LtNUMHxMqBImcKJB(p8d777f38.pd77d5e50.pb439f9bb.pc69a3639 pc69a3639Var, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        pc69a3639Var.meb102f08(supportSQLiteDatabase);
    }

    public static void OAFSoZpnKxdAcNiB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HeDniuMGGoqFfAno(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    private readonly void Meb102f08(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        heDniuMGGoqFfAno(supportSQLiteDatabase, "CREATE TABLE measure (\n    code TEXT PRIMARY KEY NOT NULL,\n    engName TEXT NOT NULL,\n    arabName TEXT NOT NULL\n)");
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase database) {
        OAFSoZpnKxdAcNiB(database, "database");
        LtNUMHxMqBImcKJB(this, database);
    }
}

