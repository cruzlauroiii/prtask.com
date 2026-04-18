namespace WillowMaze.Wasm.Decompiled;

public class P9785642f_9 : EntityDeletionOrUpdateAdapter
{
    private readonly p9785642f This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p9785642f$9.bind
    }

    private void Bind(SupportSQLiteStatement P0, pf79cee86 P1)
    {
        // call: pf79cee86.getPaymentPlace
        // call: pf79cee86.getNote
        // call: pf79cee86.getReceiptType
        // call: pf79cee86.getQrPayInfo
        // call: pf79cee86.getUuid
        // call: pf79cee86.getExtra
        // call: p9785642f.m5ec06fdf
        // call: pf79cee86.getPaymentAddress
        // call: SupportSQLiteStatement.bindString
        // call: pf79cee86.getOperationType
        // call: SupportSQLiteStatement.bindLong
        // call: SupportSQLiteStatement.bindNull
        // call: p9785642f.m337ceba5
        // call: pf79cee86.isSelected
        // call: pf79cee86.getShouldPrintReceipt
        // call: pf79cee86.getClientEmail
        // call: pf79cee86.getReceiptDiscount
        // call: pf79cee86.getDeviceId
        // call: pf79cee86.getTapOnPhoneRefId
        // call: pf79cee86.getEditable
        // field: p8325324b.pf0719ea8.p9785642f$9.this$0
    }

    private string CreateQuery()
    {
        // str: "UPDATE OR ABORT `current_sell_receipt` SET `uuid` = ?,`deviceId` = ?,`receiptType` = ?,`employeeI..."
        return string.Empty;
    }

}
