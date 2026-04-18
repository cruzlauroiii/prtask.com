namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000V\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0017H\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016J\b\u0010\u001a\u001a\u00020\u001bH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Lp2e5d8aa3/p098ee430;", "Lp2e5d8aa3/p2e50c88b;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "settingsDependencies", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "initKoinModules", "", "getHashSettingsRouter", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "getPaymentHashSettingsUseCase", "Lp2e5d8aa3/pf83c2a85/pac143fb7/pdcfa0c32;", "getLocalHashSettingsRepository", "Lp2e5d8aa3/pe0212e54/pb3f20355/p2d884c28;", "getPaymentHashSettingsRepository", "Lp2e5d8aa3/pf83c2a85/pb3f20355/pc60ad0d1;", "getLocationUseCase", "Lp2e5d8aa3/pd5189de0/pae610a30;", "getReceiptSendingUseCase", "Lp2e5d8aa3/p1e11b989/pac143fb7/p0a4fdf59;", "getUserHashSettingsUseCase", "Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;", "getFeedbackUseCase", "Lp2e5d8aa3/p39652074/p1d2e04a5;", "getConsoleoutUseCase", "Lp2e5d8aa3/p4236a440/p433c926b;", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p098ee430 : p2e5d8aa3.p2e50c88b, p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    private readonly java.util.List f4b74d910;
    private readonly java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> f61d1e432;
    private readonly java.util.List f7b91ead9;
    private readonly java.util.List f900adfda;

    public p098ee430() {
        if ((20 + 31) % 31 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[] pe55f75a2VarArr = new p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2[6];
        pe55f75a2VarArr[0] = p2e5d8aa3.p690382dd.p482966a1.mca3248a9();
        pe55f75a2VarArr[1] = p2e5d8aa3.p690382dd.p27bbceb2.m7a221047();
        pe55f75a2VarArr[2] = p2e5d8aa3.p690382dd.paa4fad31.m55f2a0a8();
        pe55f75a2VarArr[3] = p2e5d8aa3.p690382dd.pe592d54f.m69bdac01();
        pe55f75a2VarArr[4] = p2e5d8aa3.p690382dd.p44fcbc21.mcf4dc44d();
        pe55f75a2VarArr[5] = p2e5d8aa3.p690382dd.pf69d947d.m052ecfeb();
        this.f61d1e432 = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) pe55f75a2VarArr);
    }

    public override p2e5d8aa3.p39652074.p1d2e04a5 GetFeedbackUseCase() {
        if ((16 + 21) % 21 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.p39652074.p1d2e04a5) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.p39652074.p1d2e04a5.class), null, null);
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(this);
    }

    public override p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 GetLocalHashSettingsRepository() {
        if ((7 + 6) % 6 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28.class), null, null);
    }

    public override p2e5d8aa3.pd5189de0.pae610a30 GetLocationUseCase() {
        if ((8 + 1) % 1 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.pd5189de0.pae610a30) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.pd5189de0.pae610a30.class), null, null);
    }

    public override p2e5d8aa3.p4236a440.p433c926b GetConsoleoutUseCase() {
        if ((26 + 5) % 5 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.p4236a440.p433c926b) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.p4236a440.p433c926b.class), null, null);
    }

    public override p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1 GetPaymentHashSettingsRepository() {
        if ((17 + 3) % 3 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1.class), null, null);
    }

    public override p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 GetPaymentHashSettingsUseCase() {
        if ((15 + 4) % 4 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32.class), null, null);
    }

    public override p2e5d8aa3.p1e11b989.pac143fb7.p0a4fdf59 GetReceiptSendingUseCase() {
        if ((21 + 17) % 17 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.p1e11b989.pac143fb7.p0a4fdf59) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.p1e11b989.pac143fb7.p0a4fdf59.class), null, null);
    }

    public override p2e5d8aa3.pfd9160bb.pee785de8 GetHashSettingsRouter() {
        if ((30 + 31) % 31 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.pfd9160bb.pee785de8) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.pfd9160bb.pee785de8.class), null, null);
    }

    public override p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 GetUserHashSettingsUseCase() {
        if ((25 + 32) % 32 > 0) {
        }
        p2e5d8aa3.p098ee430 p098ee430Var = this;
        return (p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31) (!(p098ee430Var is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? p098ee430Var.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) p098ee430Var).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31.class), null, null);
    }

    public override void InitKoinModules() {
        p5a445d71.p514e2d7a.pa74ad8df.p5c18ef72.pfb034f50.mefe5710d(this.f61d1e432);
    }
}

