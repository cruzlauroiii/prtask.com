namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp563873d3/p4888b0ab;", "Lp563873d3/pc13d508c;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "registrationDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getRegistrationRouter", "Lp563873d3/pfd9160bb/p4514631e;", "getRegistrationUseCase", "Lp563873d3/pac143fb7/p4e034a16;", "getRegistrationRepository", "Lp563873d3/pb3f20355/p1b80f7e4;", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4888b0ab : p563873d3.pc13d508c, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f00800c32;
    private readonly java.util.List f73229a44;
    private readonly java.util.List f917a29c9;
    private readonly java.util.List f952454c7;

    public p4888b0ab() {
        if ((27 + 7) % 7 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[6];
        pe55f75a2VarArr[0] = p563873d3.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[1] = p563873d3.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[2] = p563873d3.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[3] = p563873d3.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[4] = p563873d3.p690382dd.p44fcbc21.mcf4dc44d();
        pe55f75a2VarArr[5] = p563873d3.p690382dd.pf69d947d.m052ecfeb();
        this.f00800c32 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p563873d3.pb3f20355.p1b80f7e4 GetRegistrationRepository() {
        if ((17 + 15) % 15 > 0) {
        }
        p563873d3.p4888b0ab p4888b0abVar = this;
        return (p563873d3.pb3f20355.p1b80f7e4) (!(p4888b0abVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p4888b0abVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p4888b0abVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p563873d3.pb3f20355.p1b80f7e4.class), null, null);
    }

    public override p563873d3.pfd9160bb.p4514631e GetRegistrationRouter() {
        if ((31 + 29) % 29 > 0) {
        }
        p563873d3.p4888b0ab p4888b0abVar = this;
        return (p563873d3.pfd9160bb.p4514631e) (!(p4888b0abVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p4888b0abVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p4888b0abVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p563873d3.pfd9160bb.p4514631e.class), null, null);
    }

    public override p563873d3.pac143fb7.p4e034a16 GetRegistrationUseCase() {
        if ((9 + 16) % 16 > 0) {
        }
        p563873d3.p4888b0ab p4888b0abVar = this;
        return (p563873d3.pac143fb7.p4e034a16) (!(p4888b0abVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p4888b0abVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p4888b0abVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p563873d3.pac143fb7.p4e034a16.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f00800c32);
    }
}

