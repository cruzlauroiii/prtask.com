namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lpf3e08b51/pa1523c42;", "Lpf3e08b51/p6f0f63ac;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "launcherDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getLauncherRouter", "Lpf3e08b51/pfd9160bb/p02eb2260;", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa1523c42 : pf3e08b51.p6f0f63ac, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f38678653;
    private readonly java.util.List f8f8b20b5;
    private readonly java.util.List fad265b45;
    private readonly java.util.List fc2ec1116;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> fd36092c3;

    public pa1523c42() {
        if ((11 + 32) % 32 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[3];
        pe55f75a2VarArr[0] = pf3e08b51.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[1] = pf3e08b51.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[2] = pf3e08b51.p690382dd.pf69d947d.m052ecfeb();
        this.fd36092c3 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override pf3e08b51.pfd9160bb.p02eb2260 GetLauncherRouter() {
        if ((15 + 28) % 28 > 0) {
        }
        pf3e08b51.pa1523c42 pa1523c42Var = this;
        return (pf3e08b51.pfd9160bb.p02eb2260) (!(pa1523c42Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pa1523c42Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pa1523c42Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(pf3e08b51.pfd9160bb.p02eb2260.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.fd36092c3);
    }
}

