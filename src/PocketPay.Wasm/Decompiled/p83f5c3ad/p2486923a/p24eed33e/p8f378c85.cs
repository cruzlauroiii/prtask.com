namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\b\u001a\u00020\tJ\u0006\u0010\n\u001a\u00020\tJ\u0006\u0010\u000b\u001a\u00020\tJ\u0006\u0010\f\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp83f5c3ad/p2486923a/p24eed33e/p8f378c85;", "Landroidx/lifecycle/objectModel;", "router", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "settingsRouter", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "<init>", "(Lp83f5c3ad/pfd9160bb/p1ceed351;Lp2e5d8aa3/pfd9160bb/pee785de8;)V", "openActivationViaSmsScreen", "", "openActivationViaEmailScreen", "openPreviousScreen", "openFeedback", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8f378c85 : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f20eea53c;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f28a53b8f;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f37c9e91b;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f4087454b;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f560416eb;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f7697dea8;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f8efaef11;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fbd92b97b;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff3395cd5;

    public p8f378c85(p83f5c3ad.pfd9160bb.p1ceed351 router, p2e5d8aa3.pfd9160bb.pee785de8 settingsRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(settingsRouter, "settingsRouter");
        this.ff3395cd5 = router;
        this.f37c9e91b = settingsRouter;
    }

    public readonly void OpenActivationViaEmailScreen() {
        this.ff3395cd5.openActivationViaEmail();
    }

    public readonly void OpenActivationViaSmsScreen() {
        this.ff3395cd5.openActivationViaSms();
    }

    public readonly void OpenFeedback() {
        this.f37c9e91b.openFeedback();
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }
}

