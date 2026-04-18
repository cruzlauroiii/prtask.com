namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lpa912a94d/p8dc635f2;", "Lpa912a94d/p47cbfbf5;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "statisticsDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getStatisticsRouter", "Lpa912a94d/pfd9160bb/p6e2fd5a9;", "feature-statistics-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8dc635f2 : pa912a94d.p47cbfbf5, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f61c47e3a;
    private readonly java.util.List f798e8d36;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f85843197;

    public p8dc635f2() {
        if ((12 + 27) % 27 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[5];
        pe55f75a2VarArr[0] = pa912a94d.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[1] = pa912a94d.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[2] = pa912a94d.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[3] = pa912a94d.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[4] = pa912a94d.p690382dd.pf69d947d.m052ecfeb();
        this.f85843197 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override pa912a94d.pfd9160bb.p6e2fd5a9 GetStatisticsRouter() {
        if ((22 + 20) % 20 > 0) {
        }
        pa912a94d.p8dc635f2 p8dc635f2Var = this;
        return (pa912a94d.pfd9160bb.p6e2fd5a9) (!(p8dc635f2Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p8dc635f2Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p8dc635f2Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(pa912a94d.pfd9160bb.p6e2fd5a9.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f85843197);
    }
}

