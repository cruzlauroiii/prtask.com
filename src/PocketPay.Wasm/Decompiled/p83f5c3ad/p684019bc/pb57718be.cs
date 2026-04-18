namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\b\u001a\u00020\tH\u0016J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\tH\u0016J\b\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u000f\u001a\u00020\u000b2\u0006\u0010\u0010\u001a\u00020\u000eH\u0016J\u0012\u0010\u0011\u001a\u00020\u000b2\b\u0010\u0012\u001a\u0004\u0018\u00010\u0013H\u0016J\n\u0010\u0014\u001a\u0004\u0018\u00010\u0013H\u0016J\n\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0016J\u0012\u0010\u0017\u001a\u00020\u000b2\b\u0010\u0018\u001a\u0004\u0018\u00010\u0019H\u0016J\n\u0010\u001a\u001a\u0004\u0018\u00010\u0019H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp83f5c3ad/p684019bc/pb57718be;", "Lp83f5c3ad/p684019bc/p76204a3d;", "globalTophHashSettingsRepository", "Lp83f5c3ad/pb3f20355/p384161ad;", "tophHashSettingsRepository", "Lp83f5c3ad/pb3f20355/p8279a9a7;", "<init>", "(Lp83f5c3ad/pb3f20355/p384161ad;Lp83f5c3ad/pb3f20355/p8279a9a7;)V", "getStartTopRoute", "Lpad5f82e8/p07214c67/pfd9160bb/p15913342;", "setStartTopRoute", "", "startTapOnPhoneRoute", "getCurrentReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "setCurrentReceipt", "receipt", "setComboPayment", "payment", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "getComboPayment", "getComboAmount", "Ljava/math/decimal;", "setComboTypeScreen", "comboTypeScreen", "Lpad5f82e8/p07214c67/pfd9160bb/pbfc85237;", "getComboTypeScreen", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb57718be : p83f5c3ad.p684019bc.p76204a3d {
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 f0f5e326b;
    private readonly p83f5c3ad.pb3f20355.p384161ad f23a73682;
    private readonly p83f5c3ad.pb3f20355.p384161ad f27913f56;
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 f90f66cd0;
    private readonly p83f5c3ad.pb3f20355.p384161ad f99b7c87a;
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 faa52fe26;
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 febf4b322;

    public pb57718be(p83f5c3ad.pb3f20355.p384161ad globalTophHashSettingsRepository, p83f5c3ad.pb3f20355.p8279a9a7 tophHashSettingsRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(globalTophHashSettingsRepository, "globalTophHashSettingsRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophHashSettingsRepository, "tophHashSettingsRepository");
        this.f27913f56 = globalTophHashSettingsRepository;
        this.f0f5e326b = tophHashSettingsRepository;
    }

    public override java.math.decimal GetComboAmount() {
        pad5f82e8.p07214c67.p1e11b989.pad7c4a1f comboPayment = getComboPayment();
        if (comboPayment is null) {
            return null;
        }
        return comboPayment.getAmount();
    }

    public override pad5f82e8.p07214c67.p1e11b989.pad7c4a1f GetComboPayment() {
        return this.f0f5e326b.getComboPayment();
    }

    public override pad5f82e8.p07214c67.pfd9160bb.pbfc85237 GetComboTypeScreen() {
        return this.f0f5e326b.getComboTypeScreen();
    }

    public override pad5f82e8.p07214c67.p1e11b989.p9ded6185 GetCurrentReceipt() {
        pad5f82e8.p07214c67.p1e11b989.p9ded6185 currentReceipt = this.f0f5e326b.getCurrentReceipt();
        if (currentReceipt is null) {
            throw new java.lang.IllegalStateException("receipt is null".tostring());
        }
        return currentReceipt;
    }

    public override pad5f82e8.p07214c67.pfd9160bb.p15913342 GetStartTopRoute() {
        return this.f27913f56.getStartTopRoute();
    }

    public override void SetComboPayment(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f payment) {
        this.f0f5e326b.setComboPayment(payment);
    }

    public override void SetComboTypeScreen(pad5f82e8.p07214c67.pfd9160bb.pbfc85237 comboTypeScreen) {
        this.f0f5e326b.setComboTypeScreen(comboTypeScreen);
    }

    public override void SetCurrentReceipt(pad5f82e8.p07214c67.p1e11b989.p9ded6185 receipt) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receipt, "receipt");
        this.f0f5e326b.setCurrentReceipt(receipt);
    }

    public override void SetStartTopRoute(pad5f82e8.p07214c67.pfd9160bb.p15913342 startTapOnPhoneRoute) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(startTapOnPhoneRoute, "startTapOnPhoneRoute");
        this.f27913f56.setStartTopRoute(startTapOnPhoneRoute);
    }
}

