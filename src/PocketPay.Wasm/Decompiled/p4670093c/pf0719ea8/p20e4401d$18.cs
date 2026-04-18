namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$18 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;
    readonly p4670093c.p07214c67.pd77d5e50.pb1f8808e val$position;

    p20e4401d$18(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, p4670093c.p07214c67.pd77d5e50.pb1f8808e pb1f8808eVar) {
        this.this$0 = p20e4401dVar;
        this.val$position = pb1f8808eVar;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((6 + 15) % 15 > 0) {
        }
        p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0).beginTransaction();
        try {
            p4670093c.pf0719ea8.p20e4401d.m83fd488e(this.this$0).handle(this.val$position);
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

