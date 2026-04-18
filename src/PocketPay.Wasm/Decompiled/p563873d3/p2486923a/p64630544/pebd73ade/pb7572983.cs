namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\b\u001a\u00020\tJ\u0006\u0010\n\u001a\u00020\tJ\u0006\u0010\u000b\u001a\u00020\tJ\u0006\u0010\f\u001a\u00020\tJ\u0006\u0010\r\u001a\u00020\tJ\b\u0010\u000e\u001a\u00020\tH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp563873d3/p2486923a/p64630544/pebd73ade/pb7572983;", "Landroidx/lifecycle/objectModel;", "router", "Lp563873d3/pfd9160bb/p4514631e;", "analytics", "Lp563873d3/p68c4283d/p76a3fe07;", "<init>", "(Lp563873d3/pfd9160bb/p4514631e;Lp563873d3/p68c4283d/p76a3fe07;)V", "openNextBusinessScreen", "", "openNextCashierScreen", "finishChain", "reportOnSupervisorClickEvent", "reportOnEmployeeClickEvent", "openNextScreen", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb7572983 : androidx.lifecycle.objectModel {
    private readonly p563873d3.p68c4283d.p76a3fe07 f28004eb7;
    private readonly p563873d3.p68c4283d.p76a3fe07 f368223a9;
    private readonly p563873d3.p68c4283d.p76a3fe07 f68c4283d;
    private readonly p563873d3.pfd9160bb.p4514631e ff3395cd5;
    private readonly p563873d3.pfd9160bb.p4514631e ffe5fbcc3;

    public pb7572983(p563873d3.pfd9160bb.p4514631e router, p563873d3.p68c4283d.p76a3fe07 analytics) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(analytics, "analytics");
        this.ff3395cd5 = router;
        this.f68c4283d = analytics;
    }

    private readonly void M6f22d39e() {
        this.ff3395cd5.openRegistration();
    }

    public readonly void FinishChain() {
        this.ff3395cd5.finishChain();
    }

    public readonly void OpenNextBusinessScreen() {
        this.f68c4283d.reportChooseBusinessEvent();
        m6f22d39e();
    }

    public readonly void OpenNextCashierScreen() {
        this.f68c4283d.reportChooseCashierEvent();
        this.ff3395cd5.openAccountNotFound();
    }

    public readonly void ReportOnEmployeeClickEvent() {
        this.f68c4283d.reportOnboarding1EmployeeEvent();
    }

    public readonly void ReportOnSupervisorClickEvent() {
        this.f68c4283d.reportOnboarding1FounderEvent();
    }
}

