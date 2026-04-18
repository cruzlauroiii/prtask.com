namespace WillowMaze.Wasm.Decompiled;

public class P20e4401d_2 : EntityInsertionAdapter
{
    private readonly p20e4401d This$0;

    private void Bind(SupportSQLiteStatement P0, object P1)
    {
        // call: p20e4401d$2.bind
    }

    private void Bind(SupportSQLiteStatement P0, pe39a6d57 P1)
    {
        // call: pe39a6d57.getEmployeeId
        // call: pe39a6d57.getExtra
        // call: pe39a6d57.getReceiptType
        // call: SupportSQLiteStatement.bindLong
        // call: p20e4401d.m337ceba5
        // call: pe39a6d57.getTapOnPhoneRefId
        // call: pe39a6d57.getPaymentPlace
        // call: long.longValue
        // call: SupportSQLiteStatement.bindString
        // call: p297c1c27.dateToTimestamp
        // call: pe39a6d57.getDeviceId
        // call: pe39a6d57.getPaymentAddress
        // call: SupportSQLiteStatement.bindNull
        // call: p35667ee1.bigDecimalToDouble
        // call: pe39a6d57.getSellReceiptUuid
        // call: pe39a6d57.getReceiptDiscount
        // call: pe39a6d57.getNote
        // call: pe39a6d57.isSelected
        // call: pe39a6d57.getOperationType
        // call: p20e4401d.m89082e03
        // field: p4670093c.pf0719ea8.p20e4401d$2.this$0
    }

    private string CreateQuery()
    {
        // str: "INSERT OR REPLACE INTO `current_payback_receipt` (`uuid`,`deviceId`,`receiptType`,`employeeId`,`c..."
        return string.Empty;
    }

}
