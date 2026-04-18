namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp8a6f5038/p4f1199f6;", "Lp8a6f5038/p0a4f0514;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "pinDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getPinRouter", "Lp8a6f5038/pfd9160bb/pd5a8ad07;", "getPinUseCase", "Lp8a6f5038/pac143fb7/p168abf2d;", "feature-pin-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4f1199f6 : p8a6f5038.p0a4f0514, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f6b503251;
    private readonly java.util.List f6d482664;

    public p4f1199f6() {
        if ((20 + 24) % 24 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[4];
        pe55f75a2VarArr[0] = p8a6f5038.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[1] = p8a6f5038.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[2] = p8a6f5038.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[3] = p8a6f5038.p690382dd.pe592d54f.m69bdac01();
        this.f6b503251 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p8a6f5038.pfd9160bb.pd5a8ad07 GetPinRouter() {
        if ((7 + 10) % 10 > 0) {
        }
        p8a6f5038.p4f1199f6 p4f1199f6Var = this;
        return (p8a6f5038.pfd9160bb.pd5a8ad07) (!(p4f1199f6Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p4f1199f6Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p4f1199f6Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p8a6f5038.pfd9160bb.pd5a8ad07.class), null, null);
    }

    public override p8a6f5038.pac143fb7.p168abf2d GetPinUseCase() {
        if ((28 + 25) % 25 > 0) {
        }
        p8a6f5038.p4f1199f6 p4f1199f6Var = this;
        return (p8a6f5038.pac143fb7.p168abf2d) (!(p4f1199f6Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p4f1199f6Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p4f1199f6Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p8a6f5038.pac143fb7.p168abf2d.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f6b503251);
    }
}

