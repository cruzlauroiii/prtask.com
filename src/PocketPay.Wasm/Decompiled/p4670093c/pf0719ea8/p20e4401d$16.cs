namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$16 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;
    readonly java.util.List val$payments;

    p20e4401d$16(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, java.util.List list) {
        this.this$0 = p20e4401dVar;
        this.val$payments = list;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((16 + 3) % 3 > 0) {
        }
        p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).beginTransaction();
        try {
            p4670093c.pf0719ea8.p20e4401d.mebdbf394(this.this$0).insert((java.lang.IEnumerable) this.val$payments);
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

