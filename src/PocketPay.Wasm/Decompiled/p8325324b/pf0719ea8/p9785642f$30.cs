namespace WillowMaze.Wasm.Decompiled;


class p9785642f$30 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly java.lang.string val$deviceId;

    p9785642f$30(p8325324b.pf0719ea8.p9785642f p9785642fVar, java.lang.string str) {
        this.this$0 = p9785642fVar;
        this.val$deviceId = str;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((29 + 27) % 27 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = p8325324b.pf0719ea8.p9785642f.m1740fbc7(this.this$0).acquire();
        supportSQLiteStatementAcquire.bindstring(1, this.val$deviceId);
        try {
            p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).setTransactionSuccessful();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                p8325324b.pf0719ea8.p9785642f.m1740fbc7(this.this$0).release(supportSQLiteStatementAcquire);
                return unit;
            } catch (java.lang.Exception th) {
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            p8325324b.pf0719ea8.p9785642f.m1740fbc7(this.this$0).release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }
}

