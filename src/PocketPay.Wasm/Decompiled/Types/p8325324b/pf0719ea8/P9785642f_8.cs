namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_8 : EntityDeletionOrUpdateAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$8.bind
    }

    private void Bind(SupportSQLiteStatement P0, p32a285cf P1)
    {
        // call: SupportSQLiteStatement.bindString
        // call: p32a285cf.getReceiptUuid
        // call: p32a285cf.getUuid
    }

    private string CreateQuery()
    {
        // str: "DELETE FROM `current_sell_payment` WHERE `uuid` = ? AND `receiptUuid` = ?"
        return string.Empty;
    }

}
