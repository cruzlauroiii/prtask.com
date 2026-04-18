namespace WillowMaze.Wasm.Decompiled;

public class P20e4401d_3 : EntityInsertionAdapter
{
    private readonly p20e4401d This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p20e4401d$3.bind
    }

    private void Bind(SupportSQLiteStatement P0, p0fc46d65 P1)
    {
        // call: SupportSQLiteStatement.bindDouble
        // call: SupportSQLiteStatement.bindString
        // call: SupportSQLiteStatement.bindNull
        // call: p35667ee1.bigDecimalToDouble
        // call: p20e4401d.m5ec06fdf
        // call: p85cc901a.getTopRefUuid
        // call: p0fc46d65.getPaymentType
        // call: p0fc46d65.getAmount
        // call: double.doubleValue
        // call: p0fc46d65.getTransaction
        // call: p85cc901a.getRrn
        // call: p85cc901a.getTerminalId
        // call: p85cc901a.getStan
        // call: p0fc46d65.getTapOnPhoneRefId
        // call: p20e4401d.mf23e8626
        // call: p85cc901a.getResponseCode
        // call: p0fc46d65.getReceiptUuid
        // call: p0fc46d65.getUuid
        // call: p85cc901a.getMerchantId
        // call: p85cc901a.getAuthCode
        // field: p4670093c.pf0719ea8.p20e4401d$3.this$0
    }

    private string CreateQuery()
    {
        // str: "INSERT OR ABORT INTO `current_payback_payment` (`uuid`,`receiptUuid`,`paymentType`,`amount`,`tapO..."
        return string.Empty;
    }

}
