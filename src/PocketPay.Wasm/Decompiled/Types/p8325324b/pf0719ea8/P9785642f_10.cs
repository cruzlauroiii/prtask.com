namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_10 : EntityDeletionOrUpdateAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$10.bind
    }

    private void Bind(SupportSQLiteStatement P0, p0160554c P1)
    {
        // call: double.doubleValue
        // call: SupportSQLiteStatement.bindDouble
        // call: SupportSQLiteStatement.bindLong
        // call: p9785642f.m5ec06fdf
        // call: p0160554c.getReceiptUuid
        // call: p35667ee1.bigDecimalToDouble
        // call: SupportSQLiteStatement.bindString
        // call: p0160554c.getQuantity
        // call: SupportSQLiteStatement.bindNull
        // call: p0160554c.getName
        // call: p0160554c.getCommodityId
        // call: p0160554c.getPriceWithDiscount
        // call: p0160554c.getTareVolume
        // call: p0160554c.getInitialQuantity
        // call: p0160554c.getPrice
        // call: p0160554c.getType
        // call: p0160554c.getMeasure
        // call: p0160554c.getUuid
        // call: p0160554c.getPurchasePrice
        // call: p0160554c.getTax
        // field: p8325324b.pf0719ea8.p9785642f$10.this$0
    }

    private string CreateQuery()
    {
        // str: "UPDATE OR ABORT `current_sell_position` SET `uuid` = ?,`receiptUuid` = ?,`price` = ?,`purchasePri..."
        return string.Empty;
    }

}
