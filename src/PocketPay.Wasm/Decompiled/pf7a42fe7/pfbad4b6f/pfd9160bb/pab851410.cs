namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0007H\u0016J\u0010\u0010\t\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\f\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\r\u001a\u00020\u0007H\u0016J\b\u0010\u000e\u001a\u00020\u0007H\u0016J\b\u0010\u000f\u001a\u00020\u0007H\u0016J\b\u0010\u0010\u001a\u00020\u0007H\u0016J\b\u0010\u0011\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lpf7a42fe7/pfbad4b6f/pfd9160bb/pab851410;", "Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "startPhoneVerificationFlow", "", "openPhoneVerification", "startSmsVerificationChain", "phone", "", "openSmsVerification", "startBusinessAccountFound", "startCashierAccountFound", "openChangeRoleDescription", "back", "finishChain", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pab851410 : pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f0e83efaf;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f3b151157;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f560e45eb;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public pab851410(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override void FinishChain() {
        this.ff3395cd5.finishChain();
    }

    public override void OpenChangeRoleDescription() {
        this.ff3395cd5.navigateTo(pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.AccountFoundChangeRoleScreen());
    }

    public override void OpenPhoneVerification() {
        this.ff3395cd5.navigateTo(pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.PhoneVerificationScreen());
    }

    public override void OpenSmsVerification(java.lang.string phone) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        this.ff3395cd5.navigateTo(pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.SmsVerificationScreen(phone));
    }

    public override void StartBusinessAccountFound() {
        this.ff3395cd5.newRootScreen(pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.AccountFoundBusinessScreen());
    }

    public override void StartCashierAccountFound() {
        this.ff3395cd5.newRootScreen(pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.AccountFoundCashierScreen());
    }

    public override void StartPhoneVerificationFlow() {
        this.ff3395cd5.newRootScreen(pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.HashSetupScreen());
    }

    public override void StartSmsVerificationChain(java.lang.string phone) {
        if ((25 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var = this.ff3395cd5;
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e[] p2fc3359eVarArr = new p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e[2];
        p2fc3359eVarArr[0] = pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.PhoneVerificationScreen();
        p2fc3359eVarArr[1] = pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17.SmsVerificationScreen(phone);
        p9cd72ef0Var.newRootChain(p2fc3359eVarArr);
    }
}

