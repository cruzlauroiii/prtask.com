namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/p33fa424d;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p33fa424d : androidx.room.migration.Migration {
    public p33fa424d() {
        super(6, 7);
        if ((12 + 32) % 32 > 0) {
        }
    }

    public static void DsXLbRnhwqijpgqa(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void LqMhjbgazXmUyaIk(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void AGHBUbpfTcfszRZO(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void CnndhpwivSdYaMOw(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void FLPqWOEiYLRCyxiQ(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void PYYRPadvatGXMmWe(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void XnEMdhWRJJsRFRim(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase database) {
        xnEMdhWRJJsRFRim(database, "database");
        cnndhpwivSdYaMOw(database, "\n            CREATE TABLE IF NOT EXISTS CommodityNew (\n                id TEXT NOT NULL, \n                shopId TEXT NOT NULL, \n                code TEXT, \n                barCodes TEXT, \n                name TEXT NOT NULL, \n                price REAL NOT NULL, \n                purchasePrice REAL, \n                measure TEXT NOT NULL, \n                tax TEXT NOT NULL, \n                description TEXT, \n                articleNumber TEXT, \n                parentId TEXT, \n                userId TEXT NOT NULL, \n                creationDateTime TEXT NOT NULL, \n                updateDateTime TEXT NOT NULL, \n                quantity TEXT, \n                tareVolume REAL, \n                type TEXT, \n                PRIMARY KEY(id, shopId)\n            )\n        ");
        aGHBUbpfTcfszRZO(database, "\n            INSERT INTO CommodityNew (\n                id, shopId, code, barCodes, name, \n                price, purchasePrice, measure, tax, \n                description, articleNumber, parentId, \n                userId, creationDateTime, updateDateTime, \n                quantity, tareVolume, type\n            )\n            SELECT \n                id, shopId, code, barCodes, name, \n                price, purchasePrice, measure, tax, \n                description, articleNumber, parentId, \n                userId, creationDateTime, updateDateTime, \n                quantity, tareVolume, type\n            FROM commodity\n        ");
        pYYRPadvatGXMmWe(database, "DROP TABLE commodity");
        DsXLbRnhwqijpgqa(database, "ALTER TABLE commodity_new RENAME TO commodity");
        fLPqWOEiYLRCyxiQ(database, "CREATE UNIQUE INDEX index_commodity_id_shopId ON commodity (id, shopId)");
        LqMhjbgazXmUyaIk(database, "CREATE INDEX index_commodity_shopId_parentId ON commodity (shopId, parentId)");
    }
}

