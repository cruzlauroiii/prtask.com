namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$2 : androidx.room.EntityInsertionAdapter<p4670093c.p07214c67.pd77d5e50.pe39a6d57> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;

    p20e4401d$2(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p20e4401dVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var) {
        bind2(supportSQLiteStatement, pe39a6d57Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var) {
        if ((25 + 28) % 28 > 0) {
        }
        supportSQLiteStatement.bindstring(1, pe39a6d57Var.getUuid());
        supportSQLiteStatement.bindstring(2, pe39a6d57Var.getDeviceId());
        supportSQLiteStatement.bindstring(3, p4670093c.pf0719ea8.p20e4401d.m337ceba5(this.this$0, pe39a6d57Var.getReceiptType()));
        if (pe39a6d57Var.getEmployeeId() is not null) {
            supportSQLiteStatement.bindstring(4, pe39a6d57Var.getEmployeeId());
        } else {
            supportSQLiteStatement.bindNull(4);
        }
        if (pe39a6d57Var.getClientEmail() is not null) {
            supportSQLiteStatement.bindstring(5, pe39a6d57Var.getClientEmail());
        } else {
            supportSQLiteStatement.bindNull(5);
        }
        if (pe39a6d57Var.getClientPhone() is not null) {
            supportSQLiteStatement.bindstring(6, pe39a6d57Var.getClientPhone());
        } else {
            supportSQLiteStatement.bindNull(6);
        }
        supportSQLiteStatement.bindstring(7, p4670093c.pf0719ea8.p20e4401d.m5ec06fdf(this.this$0, pe39a6d57Var.getPaymentType()));
        supportSQLiteStatement.bindlong(8, pe39a6d57Var.getShouldPrintReceipt() ? 1L : 0L);
        supportSQLiteStatement.bindstring(9, p4670093c.pf0719ea8.p20e4401d.mbbeb9b46(this.this$0, pe39a6d57Var.getOperationType()));
        if (pe39a6d57Var.getPaymentPlace() is not null) {
            supportSQLiteStatement.bindstring(10, pe39a6d57Var.getPaymentPlace());
        } else {
            supportSQLiteStatement.bindNull(10);
        }
        if (pe39a6d57Var.getPaymentAddress() is not null) {
            supportSQLiteStatement.bindstring(11, pe39a6d57Var.getPaymentAddress());
        } else {
            supportSQLiteStatement.bindNull(11);
        }
        java.lang.double ddecimalTodouble = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(pe39a6d57Var.getReceiptDiscount());
        if (ddecimalTodouble is not null) {
            supportSQLiteStatement.binddouble(12, ddecimalTodouble.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(12);
        }
        if (pe39a6d57Var.getTapOnPhoneRefId() is not null) {
            supportSQLiteStatement.bindstring(13, pe39a6d57Var.getTapOnPhoneRefId());
        } else {
            supportSQLiteStatement.bindNull(13);
        }
        if (pe39a6d57Var.getQrPayInfo() is not null) {
            supportSQLiteStatement.bindstring(14, pe39a6d57Var.getQrPayInfo());
        } else {
            supportSQLiteStatement.bindNull(14);
        }
        if (pe39a6d57Var.getExtra() is not null) {
            supportSQLiteStatement.bindstring(15, pe39a6d57Var.getExtra());
        } else {
            supportSQLiteStatement.bindNull(15);
        }
        java.lang.long lDateTimeToTimestamp = p4670093c.pf0719ea8.p20e4401d.m89082e03(this.this$0).dateToTimestamp(pe39a6d57Var.getCreationDateTime());
        if (lDateTimeToTimestamp is not null) {
            supportSQLiteStatement.bindlong(16, lDateTimeToTimestamp.longValue());
        } else {
            supportSQLiteStatement.bindNull(16);
        }
        supportSQLiteStatement.bindlong(17, pe39a6d57Var.isSelected() ? 1L : 0L);
        if (pe39a6d57Var.getReceiptNumber() is not null) {
            supportSQLiteStatement.bindlong(18, pe39a6d57Var.getReceiptNumber().intValue());
        } else {
            supportSQLiteStatement.bindNull(18);
        }
        if (pe39a6d57Var.getSellReceiptUuid() is not null) {
            supportSQLiteStatement.bindstring(19, pe39a6d57Var.getSellReceiptUuid());
        } else {
            supportSQLiteStatement.bindNull(19);
        }
        if (pe39a6d57Var.getNote() is not null) {
            supportSQLiteStatement.bindstring(20, pe39a6d57Var.getNote());
        } else {
            supportSQLiteStatement.bindNull(20);
        }
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `current_payback_receipt` (`uuid`,`deviceId`,`receiptType`,`employeeId`,`clientEmail`,`clientPhone`,`paymentType`,`shouldPrintReceipt`,`operationType`,`paymentPlace`,`paymentAddress`,`receiptDiscount`,`tapOnPhoneRefId`,`qrPayInfo`,`extra`,`creationDateTime`,`isSelected`,`receiptNumber`,`sellReceiptUuid`,`note`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
    }
}

