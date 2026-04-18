namespace WillowMaze.Wasm.Decompiled;

public class P20e4401d_1 : EntityInsertionAdapter
{
    private readonly p20e4401d This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p20e4401d$1.bind
    }

    private void Bind(SupportSQLiteStatement P0, pb1f8808e P1)
    {
        // call: SupportSQLiteStatement.bindDouble
        // call: pb1f8808e.getPurchasePrice
        // call: p20e4401d.mf23e8626
        // call: pb1f8808e.getUuid
        // call: SupportSQLiteStatement.bindString
        // call: SupportSQLiteStatement.bindNull
        // call: p35667ee1.bigDecimalToDouble
        // call: pb1f8808e.getQuantity
        // call: double.doubleValue
        // call: pb1f8808e.getTax
        // call: pb1f8808e.getPriceWithDiscount
        // call: pb1f8808e.getCommodityId
        // call: pb1f8808e.getInitialQuantity
        // call: SupportSQLiteStatement.bindLong
        // call: pb1f8808e.getType
        // call: pb1f8808e.getPrecision
        // call: pb1f8808e.getName
        // call: pb1f8808e.getTareVolume
        // call: pb1f8808e.getReceiptUuid
        // call: pb1f8808e.getPrice
        // field: p4670093c.pf0719ea8.p20e4401d$1.this$0
    }

    private string CreateQuery()
    {
        // str: "INSERT OR REPLACE INTO `current_payback_position` (`uuid`,`receiptUuid`,`price`,`purchasePrice`,`..."
        return string.Empty;
    }

}
