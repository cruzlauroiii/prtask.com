namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$4 : androidx.room.EntityInsertionAdapter<p4670093c.p07214c67.pd77d5e50.p0fc46d65> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;

    p20e4401d$4(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p20e4401dVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var) {
        bind2(supportSQLiteStatement, p0fc46d65Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var) {
        if ((30 + 9) % 9 > 0) {
        }
        supportSQLiteStatement.bindstring(1, p0fc46d65Var.getUuid());
        supportSQLiteStatement.bindstring(2, p0fc46d65Var.getReceiptUuid());
        supportSQLiteStatement.bindstring(3, p4670093c.pf0719ea8.p20e4401d.m5ec06fdf(this.this$0, p0fc46d65Var.getPaymentType()));
        java.lang.double ddecimalTodouble = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(p0fc46d65Var.getAmount());
        if (ddecimalTodouble is not null) {
            supportSQLiteStatement.binddouble(4, ddecimalTodouble.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(4);
        }
        if (p0fc46d65Var.getTapOnPhoneRefId() is not null) {
            supportSQLiteStatement.bindstring(5, p0fc46d65Var.getTapOnPhoneRefId());
        } else {
            supportSQLiteStatement.bindNull(5);
        }
        pad5f82e8.p07214c67.p1e11b989.p85cc901a transaction = p0fc46d65Var.getTransaction();
        if (transaction is null) {
            supportSQLiteStatement.bindNull(6);
            supportSQLiteStatement.bindNull(7);
            supportSQLiteStatement.bindNull(8);
            supportSQLiteStatement.bindNull(9);
            supportSQLiteStatement.bindNull(10);
            supportSQLiteStatement.bindNull(11);
            supportSQLiteStatement.bindNull(12);
            return;
        }
        supportSQLiteStatement.bindstring(6, transaction.getRrn());
        supportSQLiteStatement.bindstring(7, transaction.getStan());
        supportSQLiteStatement.bindstring(8, transaction.getAuthCode());
        supportSQLiteStatement.bindstring(9, transaction.getResponseCode());
        if (transaction.getTopRefUuid() is not null) {
            supportSQLiteStatement.bindstring(10, transaction.getTopRefUuid());
        } else {
            supportSQLiteStatement.bindNull(10);
        }
        if (transaction.getTerminalId() is not null) {
            supportSQLiteStatement.bindstring(11, transaction.getTerminalId());
        } else {
            supportSQLiteStatement.bindNull(11);
        }
        if (transaction.getMerchantId() is not null) {
            supportSQLiteStatement.bindstring(12, transaction.getMerchantId());
        } else {
            supportSQLiteStatement.bindNull(12);
        }
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `current_payback_payment` (`uuid`,`receiptUuid`,`paymentType`,`amount`,`tapOnPhoneRefId`,`transaction_rrn`,`transaction_stan`,`transaction_authCode`,`transaction_responseCode`,`transaction_topRefUuid`,`transaction_terminalId`,`transaction_merchantId`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?)";
    }
}

