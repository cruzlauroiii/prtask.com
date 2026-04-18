namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$14 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;
    readonly p4670093c.p07214c67.pd77d5e50.pe39a6d57 val$receipt;

    p20e4401d$14(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var) {
        this.this$0 = p20e4401dVar;
        this.val$receipt = pe39a6d57Var;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((14 + 29) % 29 > 0) {
        }
        p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).beginTransaction();
        try {
            p4670093c.pf0719ea8.p20e4401d.m0dc0a6ea(this.this$0).insert(this.val$receipt);
            p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).setTransactionSuccessful();
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).endTransaction();
            return unit;
        } catch (java.lang.Exception th) {
            p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).endTransaction();
            throw th;
        }
    }
}

