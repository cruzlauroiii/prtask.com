namespace WillowMaze.Wasm.Decompiled;


class p9785642f$18 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;
    readonly java.util.List val$positions;

    p9785642f$18(p8325324b.pf0719ea8.p9785642f p9785642fVar, java.util.List list) {
        this.this$0 = p9785642fVar;
        this.val$positions = list;
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return call2();
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((22 + 30) % 30 > 0) {
        }
        p8325324b.pf0719ea8.p9785642f.m89082e03(this.this$0).beginTransaction();
        try {
            p8325324b.pf0719ea8.p9785642f.m13fe7af4(this.this$0).insert((java.lang.IEnumerable) this.val$positions);
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

