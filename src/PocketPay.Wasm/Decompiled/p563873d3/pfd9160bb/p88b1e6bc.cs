namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0007H\u0016J\b\u0010\t\u001a\u00020\u0007H\u0016J\u0010\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\fH\u0016J\b\u0010\r\u001a\u00020\u0007H\u0016J\b\u0010\u000e\u001a\u00020\u0007H\u0016J\b\u0010\u000f\u001a\u00020\u0007H\u0016J\b\u0010\u0010\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp563873d3/pfd9160bb/p88b1e6bc;", "Lp563873d3/pfd9160bb/p4514631e;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "startRegistrationFlow", "", "openRegistration", "openRegistrationInfo", "openRegistrationSuccess", "email", "", "openCheckRegisteredAccountError", "openAccountNotFound", "back", "finishChain", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p88b1e6bc : p563873d3.pfd9160bb.p4514631e {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f192771ce;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f6e5f759b;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f97760498;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public p88b1e6bc(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override void FinishChain() {
        this.ff3395cd5.finishChain();
    }

    public override void OpenAccountNotFound() {
        this.ff3395cd5.navigateTo(p563873d3.pfd9160bb.p1e1e789b.f76425f17.AccountNotFoundScreen());
    }

    public override void OpenCheckRegisteredAccountError() {
        this.ff3395cd5.replaceScreen(p563873d3.pfd9160bb.p1e1e789b.f76425f17.CheckRegisteredAccountErrorScreen());
    }

    public override void OpenRegistration() {
        this.ff3395cd5.navigateTo(p563873d3.pfd9160bb.p1e1e789b.f76425f17.RegistrationScreen());
    }

    public override void OpenRegistrationInfo() {
        this.ff3395cd5.navigateTo(p563873d3.pfd9160bb.p1e1e789b.f76425f17.RegistrationInfoScreen());
    }

    public override void OpenRegistrationSuccess(java.lang.string email) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(email, "email");
        this.ff3395cd5.replaceScreen(p563873d3.pfd9160bb.p1e1e789b.f76425f17.RegistrationSuccessScreen(email));
    }

    public override void StartRegistrationFlow() {
        this.ff3395cd5.newRootScreen(p563873d3.pfd9160bb.p1e1e789b.f76425f17.ChooseUserRoleScreen());
    }
}

