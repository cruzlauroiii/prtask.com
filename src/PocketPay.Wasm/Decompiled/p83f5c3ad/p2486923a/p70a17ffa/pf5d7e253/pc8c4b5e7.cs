namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\b\u001a\u00020\tJ\u0006\u0010\n\u001a\u00020\tJ\u0006\u0010\u000b\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp83f5c3ad/p2486923a/p70a17ffa/pf5d7e253/pc8c4b5e7;", "Landroidx/lifecycle/objectModel;", "tapOnPhoneRouter", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "analytics", "Lp83f5c3ad/p68c4283d/pe8cda3fc;", "<init>", "(Lp83f5c3ad/pfd9160bb/p1ceed351;Lp83f5c3ad/p68c4283d/pe8cda3fc;)V", "openCreateOrderScreen", "", "openTophActivationScreen", "openPreviousScreen", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc8c4b5e7 : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.p68c4283d.pe8cda3fc f04106dc9;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f26c8685f;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f3e2f1781;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f62520fad;
    private readonly p83f5c3ad.p68c4283d.pe8cda3fc f68c4283d;
    private readonly p83f5c3ad.p68c4283d.pe8cda3fc f82a38fe5;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fc575ff71;
    private readonly p83f5c3ad.p68c4283d.pe8cda3fc fcf8264fe;
    private readonly p83f5c3ad.p68c4283d.pe8cda3fc ffa958ac4;

    public pc8c4b5e7(p83f5c3ad.pfd9160bb.p1ceed351 tapOnPhoneRouter, p83f5c3ad.p68c4283d.pe8cda3fc analytics) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tapOnPhoneRouter, "tapOnPhoneRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(analytics, "analytics");
        this.f62520fad = tapOnPhoneRouter;
        this.f68c4283d = analytics;
    }

    public readonly void OpenCreateOrderScreen() {
        this.f68c4283d.reportRequestEvent();
        this.f62520fad.openCreateOrder();
    }

    public readonly void OpenPreviousScreen() {
        this.f62520fad.back();
    }

    public readonly void OpenTophActivationScreen() {
        this.f62520fad.openActivation();
    }
}

