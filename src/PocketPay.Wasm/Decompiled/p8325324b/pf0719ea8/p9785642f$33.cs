namespace WillowMaze.Wasm.Decompiled;


class p9785642f$33 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$33(p8325324b.pf0719ea8.p9785642f p9785642fVar) {
        this.this$0 = p9785642fVar;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((21 + 22) % 22 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = p8325324b.pf0719ea8.p9785642f.m74faefcd(this.this$0).acquire();
        try {
            p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).setTransactionSuccessful();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                p8325324b.pf0719ea8.p9785642f.m74faefcd(this.this$0).release(supportSQLiteStatementAcquire);
                return unit;
            } catch (java.lang.Exception th) {
                p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            p8325324b.pf0719ea8.p9785642f.m74faefcd(this.this$0).release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }
}

