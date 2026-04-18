namespace WillowMaze.Wasm.Decompiled;

public class Pf7997310 : Migration
{
    public static void CPIitKwRXyTczAcU(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public static void LEEwgIVqzqiZJBrp(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void XabDhqihubCSsDNv(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public void Migrate(SupportSQLiteDatabase P0)
    {
        // str: "database"
        // str: "ALTER TABLE fast_sell_settings ADD COLUMN boardingShown INTEGER NOT NULL DEFAULT 0"
        // str: "ALTER TABLE fast_sell_settings ADD COLUMN isEnabled INTEGER NOT NULL DEFAULT 1"
        // call: pf7997310.xabDhqihubCSsDNv
        // call: pf7997310.CPIitKwRXyTczAcU
        // call: pf7997310.lEEwgIVqzqiZJBrp
    }

}
