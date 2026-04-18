namespace WillowMaze.Wasm.Decompiled;

public class P20e4401d_6 : EntityDeletionOrUpdateAdapter
{
    private readonly p20e4401d This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p20e4401d$6.bind
    }

    private void Bind(SupportSQLiteStatement P0, pb1f8808e P1)
    {
        // call: double.doubleValue
        // call: SupportSQLiteStatement.bindString
        // call: pb1f8808e.getUuid
        // call: p35667ee1.bigDecimalToDouble
        // call: pb1f8808e.getReceiptUuid
        // call: p20e4401d.mf23e8626
        // call: pb1f8808e.getQuantity
        // call: SupportSQLiteStatement.bindNull
        // call: pb1f8808e.getPrice
        // call: pb1f8808e.getCommodityId
        // call: SupportSQLiteStatement.bindLong
        // call: pb1f8808e.getInitialQuantity
        // call: pb1f8808e.getMeasure
        // call: SupportSQLiteStatement.bindDouble
        // call: pb1f8808e.getPrecision
        // call: pb1f8808e.getTareVolume
        // call: pb1f8808e.getTax
        // call: pb1f8808e.getPriceWithDiscount
        // call: pb1f8808e.getName
        // call: pb1f8808e.getType
        // field: p4670093c.pf0719ea8.p20e4401d$6.this$0
    }

    private string CreateQuery()
    {
        // str: "UPDATE OR ABORT `current_payback_position` SET `uuid` = ?,`receiptUuid` = ?,`price` = ?,`purchase..."
        return string.Empty;
    }

}
