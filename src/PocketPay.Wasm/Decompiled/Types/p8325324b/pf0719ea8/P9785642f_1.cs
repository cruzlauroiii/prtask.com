namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_1 : EntityInsertionAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$1.bind
    }

    private void Bind(SupportSQLiteStatement P0, pf79cee86 P1)
    {
        // call: SupportSQLiteStatement.bindNull
        // call: p35667ee1.bigDecimalToDouble
        // call: SupportSQLiteStatement.bindString
        // call: SupportSQLiteStatement.bindLong
        // call: pf79cee86.getEmployeeId
        // call: SupportSQLiteStatement.bindDouble
        // call: pf79cee86.getTapOnPhoneRefId
        // call: pf79cee86.getReceiptDiscount
        // call: pf79cee86.getNote
        // call: pf79cee86.getEditable
        // call: pf79cee86.getPaymentAddress
        // call: pf79cee86.getReceiptType
        // call: pf79cee86.getClientPhone
        // call: pf79cee86.getUuid
        // call: p9785642f.m5ec06fdf
        // call: pf79cee86.getDeviceId
        // call: pf79cee86.getQrPayInfo
        // call: pf79cee86.getOperationType
        // call: p9785642f.m337ceba5
        // call: pf79cee86.getClientEmail
        // field: p8325324b.pf0719ea8.p9785642f$1.this$0
    }

    private string CreateQuery()
    {
        // str: "INSERT OR REPLACE INTO `current_sell_receipt` (`uuid`,`deviceId`,`receiptType`,`employeeId`,`clie..."
        return string.Empty;
    }

}
