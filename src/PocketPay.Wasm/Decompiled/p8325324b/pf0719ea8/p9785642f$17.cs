namespace WillowMaze.Wasm.Decompiled;


class p9785642f$17 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly p8325324b.p07214c67.pd77d5e50.pf79cee86 val$receipt;

    p9785642f$17(p8325324b.pf0719ea8.p9785642f p9785642fVar, p8325324b.p07214c67.pd77d5e50.pf79cee86 pf79cee86Var) {
        this.this$0 = p9785642fVar;
        this.val$receipt = pf79cee86Var;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((10 + 16) % 16 > 0) {
        }
        p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
        try {
            p8325324b.pf0719ea8.p9785642f.m429f062d(this.this$0).insert(this.val$receipt);
            p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).setTransactionSuccessful();
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
            return unit;
        } catch (java.lang.Exception th) {
            p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).endTransaction();
            throw th;
        }
    }
}

