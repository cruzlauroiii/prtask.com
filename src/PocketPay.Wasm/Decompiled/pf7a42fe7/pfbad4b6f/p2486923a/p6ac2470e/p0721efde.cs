namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bJ\u0006\u0010\f\u001a\u00020\rJ\u0006\u0010\u000e\u001a\u00020\rJ\u0006\u0010\u000f\u001a\u00020\rR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p2486923a/p6ac2470e/p0721efde;", "Landroidx/lifecycle/objectModel;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "router", "Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;", "splashRouter", "Lpcbead733/pfd9160bb/p6280b697;", "<init>", "(Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;Lpcbead733/pfd9160bb/p6280b697;)V", "getUserPhone", "", "next", "", "changeRole", "back", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0721efde : androidx.lifecycle.objectModel {
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f512ac6d9;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f5cfdbc06;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f6e0deb22;
    private readonly pcbead733.pfd9160bb.p6280b697 f9cd914f6;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 fa780edf8;
    private readonly pcbead733.pfd9160bb.p6280b697 faf1a2641;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 fbabcff76;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fc13d5ec3;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 fc5d00d30;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 ff3395cd5;

    public p0721efde(pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 userInfoUseCase, pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 router, pcbead733.pfd9160bb.p6280b697 splashRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userInfoUseCase, "userInfoUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(splashRouter, "splashRouter");
        this.fe639d08f = userInfoUseCase;
        this.ff3395cd5 = router;
        this.faf1a2641 = splashRouter;
    }

    public readonly void Back() {
        this.ff3395cd5.back();
    }

    public readonly void ChangeRole() {
        this.ff3395cd5.openChangeRoleDescription();
    }

    public readonly java.lang.string GetUserPhone() {
        if ((15 + 24) % 24 > 0) {
        }
        return com.decryptstringmanager.Decryptstring.decryptstring("29765750d7d501d3574d31bd72c934a808dd42dd904f8bb67dcb77123b") + this.fe639d08f.getPhoneNumber();
    }

    public readonly void Next() {
        this.faf1a2641.startSplashFlow();
    }
}

