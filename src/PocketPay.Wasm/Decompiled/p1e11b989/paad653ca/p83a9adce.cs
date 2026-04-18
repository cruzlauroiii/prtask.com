namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp1e11b989/paad653ca/p83a9adce;", "Lp1e11b989/paad653ca/pa9d1b66f;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "noteDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getNoteReceiptPrefRepository", "Lp1e11b989/paad653ca/pb3f20355/pd027b535;", "getNoteReceiptRouter", "Lp1e11b989/paad653ca/pfd9160bb/p542529df;", "feature-receipt-note-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p83a9adce : p1e11b989.paad653ca.pa9d1b66f, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f5396ac35;
    private readonly java.util.List fa7c8ad8a;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> fc268a86e;
    private readonly java.util.List fc6c30052;

    public p83a9adce() {
        if ((23 + 1) % 1 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[3];
        pe55f75a2VarArr[0] = p1e11b989.paad653ca.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[1] = p1e11b989.paad653ca.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[2] = p1e11b989.paad653ca.p690382dd.p482966a1.mca3248a9();
        this.fc268a86e = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p1e11b989.paad653ca.pb3f20355.pd027b535 GetNoteReceiptPrefRepository() {
        if ((25 + 2) % 2 > 0) {
        }
        p1e11b989.paad653ca.p83a9adce p83a9adceVar = this;
        return (p1e11b989.paad653ca.pb3f20355.pd027b535) (!(p83a9adceVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p83a9adceVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p83a9adceVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p1e11b989.paad653ca.pb3f20355.pd027b535.class), null, null);
    }

    public override p1e11b989.paad653ca.pfd9160bb.p542529df GetNoteReceiptRouter() {
        if ((23 + 3) % 3 > 0) {
        }
        p1e11b989.paad653ca.p83a9adce p83a9adceVar = this;
        return (p1e11b989.paad653ca.pfd9160bb.p542529df) (!(p83a9adceVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p83a9adceVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p83a9adceVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p1e11b989.paad653ca.pfd9160bb.p542529df.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.fc268a86e);
    }
}

