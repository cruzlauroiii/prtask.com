namespace WillowMaze.Wasm.Decompiled;


class p9785642f$9 : androidx.room.EntityDeletionOrUpdateAdapter<p8325324b.p07214c67.pd77d5e50.pf79cee86> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$9(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.pf79cee86 pf79cee86Var) {
        bind2(supportSQLiteStatement, pf79cee86Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.pf79cee86 pf79cee86Var) {
        if ((10 + 11) % 11 > 0) {
        }
        supportSQLiteStatement.bindstring(1, pf79cee86Var.getUuid());
        supportSQLiteStatement.bindstring(2, pf79cee86Var.getDeviceId());
        supportSQLiteStatement.bindstring(3, p8325324b.pf0719ea8.p9785642f.mf23e8626(this.this$0, pf79cee86Var.getReceiptType()));
        if (pf79cee86Var.getEmployeeId() is not null) {
            supportSQLiteStatement.bindstring(4, pf79cee86Var.getEmployeeId());
        } else {
            supportSQLiteStatement.bindNull(4);
        }
        if (pf79cee86Var.getClientEmail() is not null) {
            supportSQLiteStatement.bindstring(5, pf79cee86Var.getClientEmail());
        } else {
            supportSQLiteStatement.bindNull(5);
        }
        if (pf79cee86Var.getClientPhone() is not null) {
            supportSQLiteStatement.bindstring(6, pf79cee86Var.getClientPhone());
        } else {
            supportSQLiteStatement.bindNull(6);
        }
        supportSQLiteStatement.bindstring(7, p8325324b.pf0719ea8.p9785642f.mf8f67da7(this.this$0, pf79cee86Var.getPaymentType()));
        supportSQLiteStatement.bindlong(8, pf79cee86Var.getShouldPrintReceipt() ? 1L : 0L);
        supportSQLiteStatement.bindstring(9, p8325324b.pf0719ea8.p9785642f.m337ceba5(this.this$0, pf79cee86Var.getOperationType()));
        if (pf79cee86Var.getPaymentPlace() is not null) {
            supportSQLiteStatement.bindstring(10, pf79cee86Var.getPaymentPlace());
        } else {
            supportSQLiteStatement.bindNull(10);
        }
        if (pf79cee86Var.getPaymentAddress() is not null) {
            supportSQLiteStatement.bindstring(11, pf79cee86Var.getPaymentAddress());
        } else {
            supportSQLiteStatement.bindNull(11);
        }
        java.lang.double ddecimalTodouble = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(pf79cee86Var.getReceiptDiscount());
        if (ddecimalTodouble is not null) {
            supportSQLiteStatement.binddouble(12, ddecimalTodouble.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(12);
        }
        if (pf79cee86Var.getTapOnPhoneRefId() is not null) {
            supportSQLiteStatement.bindstring(13, pf79cee86Var.getTapOnPhoneRefId());
        } else {
            supportSQLiteStatement.bindNull(13);
        }
        if (pf79cee86Var.getQrPayInfo() is not null) {
            supportSQLiteStatement.bindstring(14, pf79cee86Var.getQrPayInfo());
        } else {
            supportSQLiteStatement.bindNull(14);
        }
        if (pf79cee86Var.getExtra() is not null) {
            supportSQLiteStatement.bindstring(15, pf79cee86Var.getExtra());
        } else {
            supportSQLiteStatement.bindNull(15);
        }
        supportSQLiteStatement.bindlong(16, pf79cee86Var.isSelected() ? 1L : 0L);
        supportSQLiteStatement.bindlong(17, pf79cee86Var.getEditable() ? 1L : 0L);
        if (pf79cee86Var.getNote() is not null) {
            supportSQLiteStatement.bindstring(18, pf79cee86Var.getNote());
        } else {
            supportSQLiteStatement.bindNull(18);
        }
        supportSQLiteStatement.bindstring(19, pf79cee86Var.getUuid());
    }

    protected override java.lang.string CreateQuery() {
        return "UPDATE OR ABORT `current_sell_receipt` SET `uuid` = ?,`deviceId` = ?,`receiptType` = ?,`employeeId` = ?,`clientEmail` = ?,`clientPhone` = ?,`paymentType` = ?,`shouldPrintReceipt` = ?,`operationType` = ?,`paymentPlace` = ?,`paymentAddress` = ?,`receiptDiscount` = ?,`tapOnPhoneRefId` = ?,`qrPayInfo` = ?,`extra` = ?,`isSelected` = ?,`editable` = ?,`note` = ? WHERE `uuid` = ?";
    }
}

