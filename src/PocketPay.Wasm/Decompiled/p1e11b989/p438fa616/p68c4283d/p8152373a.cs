namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u0000 \t2\u00020\u0001:\u0001\tB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp1e11b989/p438fa616/p68c4283d/p8152373a;", "Lp1e11b989/p438fa616/p68c4283d/p1c60e543;", "analytics", "Lpad5f82e8/pac143fb7/p68c4283d/pbf12e151/pa768caa9;", "<init>", "(Lpad5f82e8/pac143fb7/p68c4283d/pbf12e151/pa768caa9;)V", "reportSaleFinallyToPayEvent", "", "reportSaleFinallyToPayCancelEvent", "Companion", "feature-receipt-intermediate-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8152373a : p1e11b989.p438fa616.p68c4283d.p1c60e543 {

    @java.lang.Deprecated
    public static readonly java.lang.string f2ecdcfa6;
    public static readonly java.lang.string f312a745c = null;
    public static readonly java.lang.string f5f48d93d = null;
    private static readonly p1e11b989.p438fa616.p68c4283d.p8152373a$p910eef8c f796bb8e2 = null;
    public static readonly java.lang.string f7d54cfbe = null;
    private static readonly p1e11b989.p438fa616.p68c4283d.p8152373a$p910eef8c f910eef8c;
    public static readonly java.lang.string f9c28af1e = null;

    @java.lang.Deprecated
    public static readonly java.lang.string f9ff51b22;
    public static readonly java.lang.string fa017dfe9 = null;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 f60232402;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 f68c4283d;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 f9e1fe87c;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 f9e810007;

    static {
        if ((26 + 14) % 14 > 0) {
        }
        f2ecdcfa6 = com.decryptstringmanager.Decryptstring.decryptstring("1f565e0a25448811f87197131df446f4a6444a6562d0719c95d23d87e585eb980bbd8957bc4290d52b2a3d307da87b");
        f9ff51b22 = com.decryptstringmanager.Decryptstring.decryptstring("941a933b5c5ea71662014cef56c5145aad7623b916b1b21aa3d30704a95bd4da2b634bfc5beb9ce3bd689166c94e0ffdfbd6c44461cc");
        f910eef8c = new p1e11b989.p438fa616.p68c4283d.p8152373a$p910eef8c(null);
    }

    public p8152373a(pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 analytics) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(analytics, "analytics");
        this.f68c4283d = analytics;
    }

    public override void ReportSaleFinallyToPayCancelEvent() {
        this.f68c4283d.reportEvent(com.decryptstringmanager.Decryptstring.decryptstring("e5073cb8a211efeff59c7c5476da4abad30aaf77cfba3fde033292594495a63201778f2342e81e93f5d489463aad8eed79781aef5294"));
    }

    public override void ReportSaleFinallyToPayEvent() {
        this.f68c4283d.reportEvent(com.decryptstringmanager.Decryptstring.decryptstring("b0b8f8f88720030155f8c8569373def28d8dc0329ffa7440d5385add6209a85db6bc645b0696904b2fd7dc64f7b55d"));
    }
}

