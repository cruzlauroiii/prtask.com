namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lpcbead733/p7226884e;", "Lpcbead733/pf39e510d;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "splashDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getSplashRouter", "Lpcbead733/pfd9160bb/p6280b697;", "feature-splash-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7226884e : pcbead733.pf39e510d, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f1874e33b;
    private readonly java.util.List f63f06533;

    public p7226884e() {
        if ((1 + 5) % 5 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[2];
        pe55f75a2VarArr[0] = pcbead733.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[1] = pcbead733.p690382dd.p482966a1.mca3248a9();
        this.f1874e33b = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override pcbead733.pfd9160bb.p6280b697 GetSplashRouter() {
        if ((22 + 20) % 20 > 0) {
        }
        pcbead733.p7226884e p7226884eVar = this;
        return (pcbead733.pfd9160bb.p6280b697) (!(p7226884eVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p7226884eVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p7226884eVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(pcbead733.pfd9160bb.p6280b697.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f1874e33b);
    }
}

