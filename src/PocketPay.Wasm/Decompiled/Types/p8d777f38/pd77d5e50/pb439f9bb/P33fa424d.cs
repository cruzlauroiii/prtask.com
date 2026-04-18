namespace WillowMaze.Wasm.Decompiled;

public class P33fa424d : Migration
{
    public static void DsXLbRnhwqijpgqa(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void LqMhjbgazXmUyaIk(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void AGHBUbpfTcfszRZO(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void CnndhpwivSdYaMOw(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void FLPqWOEiYLRCyxiQ(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void PYYRPadvatGXMmWe(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void XnEMdhWRJJsRFRim(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public void Migrate(SupportSQLiteDatabase P0)
    {
        // str: "\n            CREATE TABLE IF NOT EXISTS commodity_new (\n                id TEXT NOT NULL, \n   ..."
        // str: "CREATE INDEX index_commodity_shopId_parentId ON commodity (shopId, parentId)"
        // str: "\n            INSERT INTO commodity_new (\n                id, shopId, code, barCodes, name, \n  ..."
        // str: "DROP TABLE commodity"
        // str: "database"
        // str: "ALTER TABLE commodity_new RENAME TO commodity"
        // str: "CREATE UNIQUE INDEX index_commodity_id_shopId ON commodity (id, shopId)"
        // call: p33fa424d.fLPqWOEiYLRCyxiQ
        // call: p33fa424d.pYYRPadvatGXMmWe
        // call: p33fa424d.cnndhpwivSdYaMOw
        // call: p33fa424d.LqMhjbgazXmUyaIk
        // call: p33fa424d.DsXLbRnhwqijpgqa
        // call: p33fa424d.aGHBUbpfTcfszRZO
        // call: p33fa424d.xnEMdhWRJJsRFRim
    }

}
