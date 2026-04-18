namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp1e11b989/p438fa616/p406f1653;", "Lp1e11b989/p438fa616/p33267781;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "receiptIntermediateDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getReceiptIntermediateRouter", "Lp1e11b989/p438fa616/pfd9160bb/p0fce535b;", "feature-receipt-intermediate-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p406f1653 : p1e11b989.p438fa616.p33267781, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f10c708d6;
    private readonly java.util.List f68f80372;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> fdce0d647;

    public p406f1653() {
        if ((27 + 15) % 15 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[3];
        pe55f75a2VarArr[0] = p1e11b989.p438fa616.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[1] = p1e11b989.p438fa616.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[2] = p1e11b989.p438fa616.p690382dd.pf69d947d.m052ecfeb();
        this.fdce0d647 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p1e11b989.p438fa616.pfd9160bb.p0fce535b GetReceiptIntermediateRouter() {
        if ((22 + 10) % 10 > 0) {
        }
        p1e11b989.p438fa616.p406f1653 p406f1653Var = this;
        return (p1e11b989.p438fa616.pfd9160bb.p0fce535b) (!(p406f1653Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p406f1653Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p406f1653Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p1e11b989.p438fa616.pfd9160bb.p0fce535b.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.fdce0d647);
    }
}

