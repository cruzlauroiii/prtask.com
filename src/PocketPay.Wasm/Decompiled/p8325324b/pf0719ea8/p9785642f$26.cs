namespace WillowMaze.Wasm.Decompiled;


class p9785642f$26 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly java.util.List val$payments;

    p9785642f$26(p8325324b.pf0719ea8.p9785642f p9785642fVar, java.util.List list) {
        this.this$0 = p9785642fVar;
        this.val$payments = list;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((10 + 21) % 21 > 0) {
        }
        p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
        try {
            p8325324b.pf0719ea8.p9785642f.m5e49d338(this.this$0).handleMultiple(this.val$payments);
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

