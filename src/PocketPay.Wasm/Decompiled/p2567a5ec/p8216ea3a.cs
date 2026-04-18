namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp2567a5ec/p8216ea3a;", "Lp2567a5ec/p5957a509;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "webDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getWebRouter", "Lp2567a5ec/pfd9160bb/pc1bedd57;", "getLKTokenUseCase", "Lp2567a5ec/pac143fb7/p0f66185f;", "feature-web-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8216ea3a : p2567a5ec.p5957a509, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f0b5ec798;
    private readonly java.util.List f3f41f448;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> fcbb1c0ca;
    private readonly java.util.List fcd23d7f7;

    public p8216ea3a() {
        if ((15 + 3) % 3 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[5];
        pe55f75a2VarArr[0] = p2567a5ec.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[1] = p2567a5ec.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[2] = p2567a5ec.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[3] = p2567a5ec.p690382dd.p44fcbc21.mcf4dc44d();
        pe55f75a2VarArr[4] = p2567a5ec.p690382dd.paa4fad31.m55f2a0a8();
        this.fcbb1c0ca = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p2567a5ec.pac143fb7.p0f66185f GetLKTokenUseCase() {
        if ((31 + 7) % 7 > 0) {
        }
        p2567a5ec.p8216ea3a p8216ea3aVar = this;
        return (p2567a5ec.pac143fb7.p0f66185f) (!(p8216ea3aVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p8216ea3aVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p8216ea3aVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2567a5ec.pac143fb7.p0f66185f.class), null, null);
    }

    public override p2567a5ec.pfd9160bb.pc1bedd57 GetWebRouter() {
        if ((3 + 24) % 24 > 0) {
        }
        p2567a5ec.p8216ea3a p8216ea3aVar = this;
        return (p2567a5ec.pfd9160bb.pc1bedd57) (!(p8216ea3aVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p8216ea3aVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p8216ea3aVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2567a5ec.pfd9160bb.pc1bedd57.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.fcbb1c0ca);
    }
}

