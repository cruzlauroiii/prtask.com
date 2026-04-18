namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bJ\u0006\u0010\f\u001a\u00020\rJ\u0006\u0010\u000e\u001a\u00020\rR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p2486923a/pf5d7e253/pcbb935b6;", "Landroidx/lifecycle/objectModel;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "router", "Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;", "splashRouter", "Lpcbead733/pfd9160bb/p6280b697;", "<init>", "(Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;Lpcbead733/pfd9160bb/p6280b697;)V", "getUserPhone", "", "next", "", "back", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pcbb935b6 : androidx.lifecycle.objectModel {
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f037d7605;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f1c10fc92;
    private readonly pcbead733.pfd9160bb.p6280b697 f21f56fa3;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f4fd5ece2;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f8670f782;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f87b90a03;
    private readonly pcbead733.pfd9160bb.p6280b697 fa8f8cab0;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fa973c658;
    private readonly pcbead733.pfd9160bb.p6280b697 faf1a2641;
    private readonly pcbead733.pfd9160bb.p6280b697 fd7c5c152;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe6ec20fd;
    private readonly pcbead733.pfd9160bb.p6280b697 fee4134ef;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 ff3395cd5;

    public pcbb935b6(pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 userInfoUseCase, pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 router, pcbead733.pfd9160bb.p6280b697 splashRouter) {
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

    public readonly java.lang.string GetUserPhone() {
        if ((26 + 7) % 7 > 0) {
        }
        return com.decryptstringmanager.Decryptstring.decryptstring("8cc965021901cded698b41e6d46aac5cbe5ee3db333716559f50dbe680") + this.fe639d08f.getPhoneNumber();
    }

    public readonly void Next() {
        this.faf1a2641.startSplashFlow();
    }
}

