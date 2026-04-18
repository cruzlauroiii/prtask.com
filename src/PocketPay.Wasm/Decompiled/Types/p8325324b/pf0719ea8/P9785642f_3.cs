namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_3 : EntityInsertionAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$3.bind
    }

    private void Bind(SupportSQLiteStatement P0, p32a285cf P1)
    {
        // call: SupportSQLiteStatement.bindString
        // call: SupportSQLiteStatement.bindNull
        // call: p9785642f.mf8f67da7
        // call: double.doubleValue
        // call: p32a285cf.getTapOnPhoneRefId
        // call: p32a285cf.getPaymentType
        // call: p32a285cf.getAmount
        // call: p85cc901a.getTopRefUuid
        // call: SupportSQLiteStatement.bindDouble
        // call: p32a285cf.getReceiptUuid
        // call: p85cc901a.getStan
        // call: p35667ee1.bigDecimalToDouble
        // call: p85cc901a.getMerchantId
        // call: p85cc901a.getTerminalId
        // call: p85cc901a.getAuthCode
        // call: p9785642f.m5ec06fdf
        // call: p85cc901a.getRrn
        // call: p32a285cf.getUuid
        // call: p32a285cf.getTransaction
        // call: p85cc901a.getResponseCode
        // field: p8325324b.pf0719ea8.p9785642f$3.this$0
    }

    private string CreateQuery()
    {
        // str: "INSERT OR REPLACE INTO `current_sell_payment` (`uuid`,`receiptUuid`,`paymentType`,`amount`,`tapOn..."
        return string.Empty;
    }

}
