namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lpd2a57dc1/pfd9160bb/p1ab0ab04;", "Lpd2a57dc1/pfd9160bb/p536bd7bd;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "<init>", "(Lpd2a57dc1/pfd9160bb/p11c216e8;)V", "startRootFlowMaintenanceMode", "", "getUpdateFlow", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1ab0ab04 : pd2a57dc1.pfd9160bb.p536bd7bd {
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f0957f224;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f566045a4;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f8bd8b95d;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 fab997e05;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;

    public p1ab0ab04(pd2a57dc1.pfd9160bb.p11c216e8 flowRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        this.feefeb260 = flowRouter;
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetUpdateFlow() {
        return pd2a57dc1.pfd9160bb.p60659310.f76425f17.AppUpdateScreen();
    }

    public override void StartRootFlowMaintenanceMode() {
        this.feefeb260.startRootFlow(pd2a57dc1.pfd9160bb.p60659310.f76425f17.MaintenanceModeScreen());
    }
}

