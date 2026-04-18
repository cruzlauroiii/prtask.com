namespace WillowMaze.Wasm.Decompiled;


class p9785642f$32 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly java.lang.string val$authCode;
    readonly java.lang.string val$merchantId;
    readonly java.lang.string val$paymentUuid;
    readonly java.lang.string val$responseCode;
    readonly java.lang.string val$rrn;
    readonly java.lang.string val$stan;
    readonly java.lang.string val$terminalId;
    readonly java.lang.string val$topRefUuid;

    p9785642f$32(p8325324b.pf0719ea8.p9785642f p9785642fVar, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string str7, java.lang.string str8) {
        this.this$0 = p9785642fVar;
        this.val$rrn = str;
        this.val$stan = str2;
        this.val$authCode = str3;
        this.val$responseCode = str4;
        this.val$topRefUuid = str5;
        this.val$terminalId = str6;
        this.val$merchantId = str7;
        this.val$paymentUuid = str8;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((31 + 3) % 3 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = p8325324b.pf0719ea8.p9785642f.m59c413ba(this.this$0).acquire();
        supportSQLiteStatementAcquire.bindstring(1, this.val$rrn);
        supportSQLiteStatementAcquire.bindstring(2, this.val$stan);
        supportSQLiteStatementAcquire.bindstring(3, this.val$authCode);
        supportSQLiteStatementAcquire.bindstring(4, this.val$responseCode);
        supportSQLiteStatementAcquire.bindstring(5, this.val$topRefUuid);
        supportSQLiteStatementAcquire.bindstring(6, this.val$terminalId);
        supportSQLiteStatementAcquire.bindstring(7, this.val$merchantId);
        supportSQLiteStatementAcquire.bindstring(8, this.val$paymentUuid);
        try {
            p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).setTransactionSuccessful();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                p8325324b.pf0719ea8.p9785642f.m59c413ba(this.this$0).release(supportSQLiteStatementAcquire);
                return unit;
            } catch (java.lang.Exception th) {
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            p8325324b.pf0719ea8.p9785642f.m59c413ba(this.this$0).release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }
}

