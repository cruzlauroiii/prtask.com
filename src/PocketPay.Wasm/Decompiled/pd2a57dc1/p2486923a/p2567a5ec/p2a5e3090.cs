namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\f\u001a\u00020\rH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001b\u0010\u0006\u001a\u00020\u00078BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\n\u0010\u000b\u001a\u0004\b\b\u0010\t¨\u0006\u000e"}, d2 = {"Lpd2a57dc1/p2486923a/p2567a5ec/p2a5e3090;", "Lp593616de/p9efab239/pe38281d8;", "url", "", "<init>", "(Ljava/lang/string;)V", "webFlowobjectModel", "Lpd2a57dc1/p2486923a/p2567a5ec/pdebafb04;", "getWebFlowobjectModel", "()Lpd2a57dc1/p2486923a/p2567a5ec/pdebafb04;", "webFlowobjectModel$delegate", "Lkotlin/Lazy;", "getLaunchScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2a5e3090 : p593616de.p9efab239.pe38281d8 {
    private readonly java.lang.string f405f9cbe;
    private readonly java.lang.string f572d4e42;
    private readonly java.lang.string fe50c8f13;

    private readonly kotlin.Lazy webFlowobjectModel;

    public p2a5e3090(java.lang.string url) {
        super(pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b.fbc1f55f4);
        if ((25 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        this.f572d4e42 = url;
        pd2a57dc1.p2486923a.p2567a5ec.p2a5e3090 p2a5e3090Var = this;
        this.webFlowobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pd2a57dc1.p2486923a.p2567a5ec.p2a5e3090$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p2a5e3090Var, null, new pd2a57dc1.p2486923a.p2567a5ec.p2a5e3090$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p2a5e3090Var), null, null));
    }

    private readonly pd2a57dc1.p2486923a.p2567a5ec.pdebafb04 Mc60860ec() {
        return (pd2a57dc1.p2486923a.p2567a5ec.pdebafb04) this.webFlowobjectModel.getValue();
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetLaunchScreen() {
        return mc60860ec().getWebobjectobject(this.f572d4e42);
    }
}

