namespace WillowMaze.Wasm.Decompiled;


class p9785642f$5 : androidx.room.EntityInsertionAdapter<p8325324b.p07214c67.pd77d5e50.p32a285cf> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$5(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p32a285cf p32a285cfVar) {
        bind2(supportSQLiteStatement, p32a285cfVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p32a285cf p32a285cfVar) {
        if ((6 + 16) % 16 > 0) {
        }
        supportSQLiteStatement.bindstring(1, p32a285cfVar.getUuid());
        supportSQLiteStatement.bindstring(2, p32a285cfVar.getReceiptUuid());
        supportSQLiteStatement.bindstring(3, p8325324b.pf0719ea8.p9785642f.mf8f67da7(this.this$0, p32a285cfVar.getPaymentType()));
        java.lang.double ddecimalTodouble = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(p32a285cfVar.getAmount());
        if (ddecimalTodouble is not null) {
            supportSQLiteStatement.binddouble(4, ddecimalTodouble.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(4);
        }
        if (p32a285cfVar.getTapOnPhoneRefId() is not null) {
            supportSQLiteStatement.bindstring(5, p32a285cfVar.getTapOnPhoneRefId());
        } else {
            supportSQLiteStatement.bindNull(5);
        }
        pad5f82e8.p07214c67.p1e11b989.p85cc901a transaction = p32a285cfVar.getTransaction();
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
        return "INSERT OR ABORT INTO `current_sell_payment` (`uuid`,`receiptUuid`,`paymentType`,`amount`,`tapOnPhoneRefId`,`transaction_rrn`,`transaction_stan`,`transaction_authCode`,`transaction_responseCode`,`transaction_topRefUuid`,`transaction_terminalId`,`transaction_merchantId`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?)";
    }
}

