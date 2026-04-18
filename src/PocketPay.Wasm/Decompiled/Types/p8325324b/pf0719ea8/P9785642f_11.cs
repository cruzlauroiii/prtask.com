namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_11 : EntityDeletionOrUpdateAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$11.bind
    }

    private void Bind(SupportSQLiteStatement P0, p32a285cf P1)
    {
        // call: double.doubleValue
        // call: SupportSQLiteStatement.bindNull
        // call: p32a285cf.getTapOnPhoneRefId
        // call: p85cc901a.getTerminalId
        // call: SupportSQLiteStatement.bindString
        // call: p85cc901a.getTopRefUuid
        // call: p32a285cf.getUuid
        // call: p32a285cf.getReceiptUuid
        // call: p9785642f.mf8f67da7
        // call: p9785642f.m5ec06fdf
        // call: p85cc901a.getRrn
        // call: p85cc901a.getMerchantId
        // call: p85cc901a.getResponseCode
        // call: p85cc901a.getStan
        // call: p32a285cf.getPaymentType
        // call: p32a285cf.getTransaction
        // call: SupportSQLiteStatement.bindDouble
        // call: p35667ee1.bigDecimalToDouble
        // call: p32a285cf.getAmount
        // call: p85cc901a.getAuthCode
        // field: p8325324b.pf0719ea8.p9785642f$11.this$0
    }

    private string CreateQuery()
    {
        // str: "UPDATE OR ABORT `current_sell_payment` SET `uuid` = ?,`receiptUuid` = ?,`paymentType` = ?,`amount..."
        return string.Empty;
    }

}
