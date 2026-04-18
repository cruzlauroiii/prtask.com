namespace WillowMaze.Wasm.Decompiled;

public class P20e4401d_7 : EntityDeletionOrUpdateAdapter
{
    private readonly p20e4401d This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p20e4401d$7.bind
    }

    private void Bind(SupportSQLiteStatement P0, pe39a6d57 P1)
    {
        // call: pe39a6d57.getClientEmail
        // call: SupportSQLiteStatement.bindString
        // call: pe39a6d57.getCreationDate
        // call: double.doubleValue
        // call: SupportSQLiteStatement.bindNull
        // call: pe39a6d57.getShouldPrintReceipt
        // call: pe39a6d57.getPaymentPlace
        // call: pe39a6d57.getTapOnPhoneRefId
        // call: pe39a6d57.getQrPayInfo
        // call: pe39a6d57.getPaymentAddress
        // call: pe39a6d57.getUuid
        // call: pe39a6d57.getReceiptNumber
        // call: p20e4401d.m89082e03
        // call: pe39a6d57.getNote
        // call: pe39a6d57.getSellReceiptUuid
        // call: SupportSQLiteStatement.bindLong
        // call: p35667ee1.bigDecimalToDouble
        // call: p297c1c27.dateToTimestamp
        // call: pe39a6d57.getExtra
        // call: pe39a6d57.isSelected
        // field: p4670093c.pf0719ea8.p20e4401d$7.this$0
    }

    private string CreateQuery()
    {
        // str: "UPDATE OR ABORT `current_payback_receipt` SET `uuid` = ?,`deviceId` = ?,`receiptType` = ?,`employ..."
        return string.Empty;
    }

}
