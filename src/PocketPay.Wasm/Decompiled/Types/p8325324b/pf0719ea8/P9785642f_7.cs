namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_7 : EntityDeletionOrUpdateAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$7.bind
    }

    private void Bind(SupportSQLiteStatement P0, p0160554c P1)
    {
        // call: p0160554c.getReceiptUuid
        // call: p0160554c.getUuid
        // call: SupportSQLiteStatement.bindString
    }

    private string CreateQuery()
    {
        // str: "DELETE FROM `current_sell_position` WHERE `uuid` = ? AND `receiptUuid` = ?"
        return string.Empty;
    }

}
