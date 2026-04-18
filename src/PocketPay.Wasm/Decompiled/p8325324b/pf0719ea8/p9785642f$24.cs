namespace WillowMaze.Wasm.Decompiled;


class p9785642f$24 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly java.util.List val$positions;

    p9785642f$24(p8325324b.pf0719ea8.p9785642f p9785642fVar, java.util.List list) {
        this.this$0 = p9785642fVar;
        this.val$positions = list;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((23 + 15) % 15 > 0) {
        }
        p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
        try {
            p8325324b.pf0719ea8.p9785642f.m83fd488e(this.this$0).handleMultiple(this.val$positions);
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

