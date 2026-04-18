namespace WillowMaze.Wasm.Decompiled;


class p9785642f$31 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly java.lang.string val$deviceId;
    readonly java.lang.string val$receiptType;

    p9785642f$31(p8325324b.pf0719ea8.p9785642f p9785642fVar, java.lang.string str, java.lang.string str2) {
        this.this$0 = p9785642fVar;
        this.val$deviceId = str;
        this.val$receiptType = str2;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((11 + 31) % 31 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = p8325324b.pf0719ea8.p9785642f.m649493cb(this.this$0).acquire();
        supportSQLiteStatementAcquire.bindstring(1, this.val$deviceId);
        supportSQLiteStatementAcquire.bindstring(2, this.val$receiptType);
        try {
            p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).setTransactionSuccessful();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                p8325324b.pf0719ea8.p9785642f.m649493cb(this.this$0).release(supportSQLiteStatementAcquire);
                return unit;
            } catch (java.lang.Exception th) {
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            p8325324b.pf0719ea8.p9785642f.m649493cb(this.this$0).release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }
}

