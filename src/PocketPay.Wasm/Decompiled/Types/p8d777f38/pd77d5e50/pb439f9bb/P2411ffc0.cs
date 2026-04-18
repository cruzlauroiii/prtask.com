namespace WillowMaze.Wasm.Decompiled;

public class P2411ffc0 : Migration
{
    public static void NPHpzyrbgBNYLzjU(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void BETguhbSikertXFN(SupportSQLiteDatabase P0, string P1)
    {
        // call: SupportSQLiteDatabase.execSQL
    }

    public void Migrate(SupportSQLiteDatabase P0)
    {
        // str: "database"
        // str: "ALTER TABLE measure ADD COLUMN frName TEXT NOT NULL DEFAULT ''"
        // call: p2411ffc0.bETguhbSikertXFN
        // call: p2411ffc0.NPHpzyrbgBNYLzjU
    }

}
