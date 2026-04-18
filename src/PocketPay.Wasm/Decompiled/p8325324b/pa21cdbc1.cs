namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp8325324b/pa21cdbc1;", "Lp8325324b/p0a09c9bb;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "sellDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getSellReceiptRepository", "Lp8325324b/pb3f20355/p3851083a;", "getSellRouter", "Lp8325324b/pfd9160bb/p5fa140e9;", "getSellReceiptUseCase", "Lp8325324b/pac143fb7/p0bfd7fb7;", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa21cdbc1 : p8325324b.p0a09c9bb, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f054d7d8f;
    private readonly java.util.List f0d127cac;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f3c00804b;
    private readonly java.util.List fece1802d;

    public pa21cdbc1() {
        if ((17 + 13) % 13 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[5];
        pe55f75a2VarArr[0] = p8325324b.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[1] = p8325324b.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[2] = p8325324b.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[3] = p8325324b.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[4] = p8325324b.p690382dd.pf69d947d.m052ecfeb();
        this.f3c00804b = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p8325324b.pb3f20355.p3851083a GetSellReceiptRepository() {
        if ((16 + 3) % 3 > 0) {
        }
        p8325324b.pa21cdbc1 pa21cdbc1Var = this;
        return (p8325324b.pb3f20355.p3851083a) (!(pa21cdbc1Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pa21cdbc1Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pa21cdbc1Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p8325324b.pb3f20355.p3851083a.class), null, null);
    }

    public override p8325324b.pac143fb7.p0bfd7fb7 GetSellReceiptUseCase() {
        if ((11 + 27) % 27 > 0) {
        }
        p8325324b.pa21cdbc1 pa21cdbc1Var = this;
        return (p8325324b.pac143fb7.p0bfd7fb7) (!(pa21cdbc1Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pa21cdbc1Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pa21cdbc1Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p8325324b.pac143fb7.p0bfd7fb7.class), null, null);
    }

    public override p8325324b.pfd9160bb.p5fa140e9 GetSellRouter() {
        if ((9 + 7) % 7 > 0) {
        }
        p8325324b.pa21cdbc1 pa21cdbc1Var = this;
        return (p8325324b.pfd9160bb.p5fa140e9) (!(pa21cdbc1Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pa21cdbc1Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pa21cdbc1Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p8325324b.pfd9160bb.p5fa140e9.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f3c00804b);
    }
}

