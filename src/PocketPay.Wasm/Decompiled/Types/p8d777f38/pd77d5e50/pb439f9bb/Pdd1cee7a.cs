namespace WillowMaze.Wasm.Decompiled;

public class Pdd1cee7a : Migration
{
    public static void KsxZtuBQXBIvIHdK(pdd1cee7a P0, SupportSQLiteDatabase P1)
    {
        // call: pdd1cee7a.m296ce56c
    }

    public static void SmzxVQoUUnKmbJKb(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void ANuadKrbYWRFoRLD(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    private void M296ce56c(SupportSQLiteDatabase P0)
    {
        // str: "CREATE TABLE receipt_total_count (\n    receiptTotalCountType TEXT PRIMARY KEY NOT NULL,\n    tot..."
        // call: pdd1cee7a.SmzxVQoUUnKmbJKb
    }

    private void Md647747f(SupportSQLiteDatabase P0)
    {
        // str: "CREATE VIEW `receipt_view` AS SELECT * FROM (\n    SELECT\n        SR.uuid,\n        NULL as sell..."
        // call: pdd1cee7a.aNuadKrbYWRFoRLD
    }

    public static void UkTjfDUwYbPSvTrd(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void YIKDAkUSEnKkybFG(pdd1cee7a P0, SupportSQLiteDatabase P1)
    {
        // call: pdd1cee7a.md647747f
    }

    public void Migrate(SupportSQLiteDatabase P0)
    {
        // str: "database"
        // call: pdd1cee7a.KsxZtuBQXBIvIHdK
        // call: pdd1cee7a.ukTjfDUwYbPSvTrd
        // call: pdd1cee7a.yIKDAkUSEnKkybFG
    }

}
