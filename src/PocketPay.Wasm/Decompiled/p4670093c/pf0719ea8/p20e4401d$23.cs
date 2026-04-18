namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$23 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;
    readonly java.lang.string val$uuid;

    p20e4401d$23(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, java.lang.string str) {
        this.this$0 = p20e4401dVar;
        this.val$uuid = str;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((26 + 16) % 16 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementAcquire = p4670093c.pf0719ea8.p20e4401d.m1740fbc7(this.this$0).acquire();
        supportSQLiteStatementAcquire.bindstring(1, this.val$uuid);
        try {
            p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).beginTransaction();
            try {
                supportSQLiteStatementAcquire.executeUpdateDelete();
                p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).setTransactionSuccessful();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).endTransaction();
                p4670093c.pf0719ea8.p20e4401d.m1740fbc7(this.this$0).release(supportSQLiteStatementAcquire);
                return unit;
            } catch (java.lang.Exception th) {
                p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).endTransaction();
                throw th;
            }
        } catch (java.lang.Exception th2) {
            p4670093c.pf0719ea8.p20e4401d.m1740fbc7(this.this$0).release(supportSQLiteStatementAcquire);
            throw th2;
        }
    }
}

