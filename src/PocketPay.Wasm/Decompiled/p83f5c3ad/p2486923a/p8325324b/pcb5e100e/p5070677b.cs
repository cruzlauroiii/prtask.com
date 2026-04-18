namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B7\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b\u0012\u0006\u0010\f\u001a\u00020\r¢\u0006\u0004\b\u000e\u0010\u000fJ\u0006\u0010\u0010\u001a\u00020\u0011J\u0006\u0010\u0012\u001a\u00020\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp83f5c3ad/p2486923a/p8325324b/pcb5e100e/p5070677b;", "Landroidx/lifecycle/objectModel;", "tophHashSettingsUseCase", "Lp83f5c3ad/p684019bc/p76204a3d;", "userHashSettingsUseCase", "Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;", "sellReceiptUseCase", "Lp8325324b/pac143fb7/p0bfd7fb7;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "tapOnPhoneRouter", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "sellRouter", "Lp8325324b/pfd9160bb/p5fa140e9;", "<init>", "(Lp83f5c3ad/p684019bc/p76204a3d;Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;Lp8325324b/pac143fb7/p0bfd7fb7;Lpd2a57dc1/pfd9160bb/p11c216e8;Lp83f5c3ad/pfd9160bb/p1ceed351;Lp8325324b/pfd9160bb/p5fa140e9;)V", "openTophPaymentSellFlow", "", "back", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5070677b : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.p684019bc.p76204a3d f053d1b76;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f0df26b80;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f24d60b19;
    private readonly p83f5c3ad.p684019bc.p76204a3d f36debe1d;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f37b6a15b;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f4197e082;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f46638f82;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f58e04bbe;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f62520fad;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f656c88ab;
    private readonly p83f5c3ad.p684019bc.p76204a3d f73ba1a5c;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 f7b6f60f3;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f9817bc27;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 fb88ae75b;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fb90a9ba3;
    private readonly p8325324b.pfd9160bb.p5fa140e9 fd336c709;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 fe5f159b0;
    private readonly p83f5c3ad.p684019bc.p76204a3d fe7eb3602;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 ff25aa718;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff4b471d1;
    private readonly p8325324b.pac143fb7.p0bfd7fb7 ff6a4f2a4;

    public p5070677b(p83f5c3ad.p684019bc.p76204a3d tophHashSettingsUseCase, p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 userHashSettingsUseCase, p8325324b.pac143fb7.p0bfd7fb7 sellReceiptUseCase, pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, p83f5c3ad.pfd9160bb.p1ceed351 tapOnPhoneRouter, p8325324b.pfd9160bb.p5fa140e9 sellRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophHashSettingsUseCase, "tophHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userHashSettingsUseCase, "userHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellReceiptUseCase, "sellReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tapOnPhoneRouter, "tapOnPhoneRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellRouter, "sellRouter");
        this.f053d1b76 = tophHashSettingsUseCase;
        this.f37b6a15b = userHashSettingsUseCase;
        this.f656c88ab = sellReceiptUseCase;
        this.feefeb260 = flowRouter;
        this.f62520fad = tapOnPhoneRouter;
        this.f9817bc27 = sellRouter;
    }

    public static readonly p8325324b.pfd9160bb.p5fa140e9 M399a97c0(p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b p5070677bVar) {
        return p5070677bVar.f9817bc27;
    }

    public static readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 Ma82a18e4(p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b p5070677bVar) {
        return p5070677bVar.f37b6a15b;
    }

    public static readonly p83f5c3ad.p684019bc.p76204a3d Mc4f4919e(p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b p5070677bVar) {
        return p5070677bVar.f053d1b76;
    }

    public static readonly p83f5c3ad.pfd9160bb.p1ceed351 Mdc7bed18(p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b p5070677bVar) {
        return p5070677bVar.f62520fad;
    }

    public static readonly pd2a57dc1.pfd9160bb.p11c216e8 Mf78acd11(p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b p5070677bVar) {
        return p5070677bVar.feefeb260;
    }

    public readonly void Back() {
        if ((31 + 14) % 14 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.p8325324b.pcb5e100e.p5070677b$p469bba0a$1(this, null), 3, null);
    }

    public readonly void OpenTophPaymentSellFlow() {
        this.f62520fad.startTophPaymentSellFlow();
    }
}

