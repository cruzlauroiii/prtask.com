namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp1e11b989/p9acb4454/p87bcfd4e;", "Lp1e11b989/p9acb4454/p175ca795;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "receiptStatusDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getReceiptStatusRouter", "Lp1e11b989/p9acb4454/pfd9160bb/pc556a05a;", "getReceiptStatusUseCase", "Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;", "getReceiptStatusServerRepository", "Lp1e11b989/p9acb4454/pb3f20355/p5926f3a5;", "getReceiptStatusRepository", "Lp1e11b989/p9acb4454/pb3f20355/p4802a698;", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p87bcfd4e : p1e11b989.p9acb4454.p175ca795, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f02775bdb;
    private readonly java.util.List f8d9c132a;

    public p87bcfd4e() {
        if ((7 + 9) % 9 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[6];
        pe55f75a2VarArr[0] = p1e11b989.p9acb4454.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[1] = p1e11b989.p9acb4454.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[2] = p1e11b989.p9acb4454.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[3] = p1e11b989.p9acb4454.p690382dd.p44fcbc21.mcf4dc44d();
        pe55f75a2VarArr[4] = p1e11b989.p9acb4454.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[5] = p1e11b989.p9acb4454.p690382dd.pf69d947d.m052ecfeb();
        this.f02775bdb = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p1e11b989.p9acb4454.pb3f20355.p4802a698 GetReceiptStatusRepository() {
        if ((22 + 16) % 16 > 0) {
        }
        p1e11b989.p9acb4454.p87bcfd4e p87bcfd4eVar = this;
        return (p1e11b989.p9acb4454.pb3f20355.p4802a698) (!(p87bcfd4eVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p87bcfd4eVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p87bcfd4eVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p1e11b989.p9acb4454.pb3f20355.p4802a698.class), null, null);
    }

    public override p1e11b989.p9acb4454.pfd9160bb.pc556a05a GetReceiptStatusRouter() {
        if ((27 + 32) % 32 > 0) {
        }
        p1e11b989.p9acb4454.p87bcfd4e p87bcfd4eVar = this;
        return (p1e11b989.p9acb4454.pfd9160bb.pc556a05a) (!(p87bcfd4eVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p87bcfd4eVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p87bcfd4eVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p1e11b989.p9acb4454.pfd9160bb.pc556a05a.class), null, null);
    }

    public override p1e11b989.p9acb4454.pb3f20355.p5926f3a5 GetReceiptStatusServerRepository() {
        if ((16 + 6) % 6 > 0) {
        }
        p1e11b989.p9acb4454.p87bcfd4e p87bcfd4eVar = this;
        return (p1e11b989.p9acb4454.pb3f20355.p5926f3a5) (!(p87bcfd4eVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p87bcfd4eVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p87bcfd4eVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p1e11b989.p9acb4454.pb3f20355.p5926f3a5.class), null, null);
    }

    public override p1e11b989.p9acb4454.pac143fb7.p883b57c7 GetReceiptStatusUseCase() {
        if ((17 + 15) % 15 > 0) {
        }
        p1e11b989.p9acb4454.p87bcfd4e p87bcfd4eVar = this;
        return (p1e11b989.p9acb4454.pac143fb7.p883b57c7) (!(p87bcfd4eVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p87bcfd4eVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p87bcfd4eVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p1e11b989.p9acb4454.pac143fb7.p883b57c7.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f02775bdb);
    }
}

