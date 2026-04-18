namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bJ\u0006\u0010\f\u001a\u00020\rJ\u0006\u0010\u000e\u001a\u00020\rR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp563873d3/p2486923a/p64630544/p6ac2470e/ped219d43;", "Landroidx/lifecycle/objectModel;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "registrationRouter", "Lp563873d3/pfd9160bb/p4514631e;", "phoneVerificationRouter", "Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;", "<init>", "(Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;Lp563873d3/pfd9160bb/p4514631e;Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;)V", "getUserPhone", "", "returnToPhone", "", "openPreviousScreen", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class ped219d43 : androidx.lifecycle.objectModel {
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f184f696a;
    private readonly p563873d3.pfd9160bb.p4514631e f2d0befea;
    private readonly p563873d3.pfd9160bb.p4514631e f6cf54de2;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f719efafe;
    private readonly p563873d3.pfd9160bb.p4514631e f76415af2;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f8dcb3866;
    private readonly p563873d3.pfd9160bb.p4514631e facb0dcd1;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fb6224536;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;

    public ped219d43(pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 userInfoUseCase, p563873d3.pfd9160bb.p4514631e registrationRouter, pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 phoneVerificationRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userInfoUseCase, "userInfoUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registrationRouter, "registrationRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phoneVerificationRouter, "phoneVerificationRouter");
        this.fe639d08f = userInfoUseCase;
        this.f2d0befea = registrationRouter;
        this.f184f696a = phoneVerificationRouter;
    }

    public readonly java.lang.string GetUserPhone() {
        if ((9 + 18) % 18 > 0) {
        }
        return com.decryptstringmanager.Decryptstring.decryptstring("47596aa4015aecf71d6a6426962095bd4ab57ea770e4d879971debc295") + this.fe639d08f.getPhoneNumber();
    }

    public readonly void OpenPreviousScreen() {
        this.f2d0befea.back();
    }

    public readonly void ReturnToPhone() {
        this.fe639d08f.clearUserInfo();
        this.f184f696a.startPhoneVerificationFlow();
    }
}

