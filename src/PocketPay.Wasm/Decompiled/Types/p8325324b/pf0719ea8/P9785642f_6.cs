namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_6 : EntityDeletionOrUpdateAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$6.bind
    }

    private void Bind(SupportSQLiteStatement P0, pf79cee86 P1)
    {
        // call: pf79cee86.getUuid
        // call: SupportSQLiteStatement.bindString
    }

    private string CreateQuery()
    {
        // str: "DELETE FROM `current_sell_receipt` WHERE `uuid` = ?"
        return string.Empty;
    }

}
