namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p242fd675;", "Lpf7a42fe7/pfbad4b6f/p5ba2a5a0;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "phoneVerificationDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getPhoneVerificationRouter", "Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p242fd675 : pf7a42fe7.pfbad4b6f.p5ba2a5a0, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f4d2a64c9;
    private readonly java.util.List f719a2681;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> fcc751440;

    public p242fd675() {
        if ((9 + 15) % 15 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[5];
        pe55f75a2VarArr[0] = pf7a42fe7.pfbad4b6f.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[1] = pf7a42fe7.pfbad4b6f.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[2] = pf7a42fe7.pfbad4b6f.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[3] = pf7a42fe7.pfbad4b6f.p690382dd.pe3d52d6b.m7a221047();
        pe55f75a2VarArr[4] = pf7a42fe7.pfbad4b6f.p690382dd.p44fcbc21.mcf4dc44d();
        this.fcc751440 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 GetPhoneVerificationRouter() {
        if ((19 + 26) % 26 > 0) {
        }
        pf7a42fe7.pfbad4b6f.p242fd675 p242fd675Var = this;
        return (pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85) (!(p242fd675Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p242fd675Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p242fd675Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.fcc751440);
    }
}

