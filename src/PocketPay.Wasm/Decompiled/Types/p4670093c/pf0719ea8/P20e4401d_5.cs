namespace WillowMaze.Wasm.Decompiled;

public class P20e4401d_5 : EntityDeletionOrUpdateAdapter
{
    private readonly p20e4401d This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p20e4401d$5.bind
    }

    private void Bind(SupportSQLiteStatement P0, pe39a6d57 P1)
    {
        // call: pe39a6d57.getUuid
        // call: SupportSQLiteStatement.bindString
    }

    private string CreateQuery()
    {
        // str: "DELETE FROM `current_payback_receipt` WHERE `uuid` = ?"
        return string.Empty;
    }

}
