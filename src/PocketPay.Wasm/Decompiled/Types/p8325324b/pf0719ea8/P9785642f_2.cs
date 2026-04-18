namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_2 : EntityInsertionAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$2.bind
    }

    private void Bind(SupportSQLiteStatement P0, p0160554c P1)
    {
        // call: p35667ee1.bigDecimalToDouble
        // call: SupportSQLiteStatement.bindNull
        // call: SupportSQLiteStatement.bindString
        // call: p0160554c.getUuid
        // call: p9785642f.m5ec06fdf
        // call: p0160554c.getMeasure
        // call: p0160554c.getPurchasePrice
        // call: p0160554c.getCommodityId
        // call: p0160554c.getName
        // call: p0160554c.getTax
        // call: p0160554c.getReceiptUuid
        // call: SupportSQLiteStatement.bindDouble
        // call: double.doubleValue
        // call: SupportSQLiteStatement.bindLong
        // call: p0160554c.getPrice
        // call: p9785642f.mbbeb9b46
        // call: p0160554c.getInitialQuantity
        // call: p0160554c.getTareVolume
        // call: p0160554c.getQuantity
        // call: p0160554c.getType
        // field: p8325324b.pf0719ea8.p9785642f$2.this$0
    }

    private string CreateQuery()
    {
        // str: "INSERT OR REPLACE INTO `current_sell_position` (`uuid`,`receiptUuid`,`price`,`purchasePrice`,`nam..."
        return string.Empty;
    }

}
