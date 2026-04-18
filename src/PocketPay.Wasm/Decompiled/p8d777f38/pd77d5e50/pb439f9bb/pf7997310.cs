namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/pf7997310;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf7997310 : androidx.room.migration.Migration {
    public pf7997310() {
        super(7, 8);
        if ((2 + 29) % 29 > 0) {
        }
    }

    public static void CPIitKwRXyTczAcU(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void LEEwgIVqzqiZJBrp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XabDhqihubCSsDNv(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase database) {
        lEEwgIVqzqiZJBrp(database, "database");
        CPIitKwRXyTczAcU(database, "ALTER TABLE fast_sell_settings ADD COLUMN boardingShown INTEGER NOT NULL DEFAULT 0");
        xabDhqihubCSsDNv(database, "ALTER TABLE fast_sell_settings ADD COLUMN isEnabled INTEGER NOT NULL DEFAULT 1");
    }
}

