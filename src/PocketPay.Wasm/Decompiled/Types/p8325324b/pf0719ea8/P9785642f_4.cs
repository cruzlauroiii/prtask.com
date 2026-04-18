namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_4 : EntityInsertionAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$4.bind
    }

    private void Bind(SupportSQLiteStatement P0, p0160554c P1)
    {
        // call: p35667ee1.bigDecimalToDouble
        // call: p0160554c.getPriceWithDiscount
        // call: SupportSQLiteStatement.bindDouble
        // call: p0160554c.getInitialQuantity
        // call: double.doubleValue
        // call: SupportSQLiteStatement.bindString
        // call: p0160554c.getTax
        // call: p0160554c.getType
        // call: SupportSQLiteStatement.bindNull
        // call: p0160554c.getPrice
        // call: p9785642f.m5ec06fdf
        // call: p0160554c.getUuid
        // call: p0160554c.getPrecision
        // call: p0160554c.getCommodityId
        // call: p0160554c.getMeasure
        // call: p0160554c.getPurchasePrice
        // call: p0160554c.getQuantity
        // call: p0160554c.getName
        // call: p0160554c.getTareVolume
        // call: p0160554c.getReceiptUuid
        // field: p8325324b.pf0719ea8.p9785642f$4.this$0
    }

    private string CreateQuery()
    {
        // str: "INSERT OR ABORT INTO `current_sell_position` (`uuid`,`receiptUuid`,`price`,`purchasePrice`,`name`..."
        return string.Empty;
    }

}
