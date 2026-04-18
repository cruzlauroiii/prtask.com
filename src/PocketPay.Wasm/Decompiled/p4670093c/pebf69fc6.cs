namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp4670093c/pebf69fc6;", "Lp4670093c/p698d0c69;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "paybackDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getPaybackReceiptRepository", "Lp4670093c/pb3f20355/p24ddebba;", "getPaybackReceiptUseCase", "Lp4670093c/pac143fb7/pa36ef9b5;", "getPaybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pebf69fc6 : p4670093c.p698d0c69, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f27f891e7;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f8165a845;

    public pebf69fc6() {
        if ((26 + 4) % 4 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[4];
        pe55f75a2VarArr[0] = p4670093c.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[1] = p4670093c.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[2] = p4670093c.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[3] = p4670093c.p690382dd.p482966a1.mca3248a9();
        this.f8165a845 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p4670093c.pb3f20355.p24ddebba GetPaybackReceiptRepository() {
        if ((4 + 6) % 6 > 0) {
        }
        p4670093c.pebf69fc6 pebf69fc6Var = this;
        return (p4670093c.pb3f20355.p24ddebba) (!(pebf69fc6Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pebf69fc6Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pebf69fc6Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p4670093c.pb3f20355.p24ddebba.class), null, null);
    }

    public override p4670093c.pac143fb7.pa36ef9b5 GetPaybackReceiptUseCase() {
        if ((30 + 5) % 5 > 0) {
        }
        p4670093c.pebf69fc6 pebf69fc6Var = this;
        return (p4670093c.pac143fb7.pa36ef9b5) (!(pebf69fc6Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pebf69fc6Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pebf69fc6Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p4670093c.pac143fb7.pa36ef9b5.class), null, null);
    }

    public override p4670093c.pfd9160bb.p1b3a5bf0 GetPaybackRouter() {
        if ((10 + 31) % 31 > 0) {
        }
        p4670093c.pebf69fc6 pebf69fc6Var = this;
        return (p4670093c.pfd9160bb.p1b3a5bf0) (!(pebf69fc6Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pebf69fc6Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pebf69fc6Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p4670093c.pfd9160bb.p1b3a5bf0.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f8165a845);
    }
}

