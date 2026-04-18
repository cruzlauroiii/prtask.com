namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tJ,\u0010\n\u001a\u00020\u000b2\u0006\u0010\b\u001a\u00020\t2\b\u0010\f\u001a\u0004\u0018\u00010\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp83f5c3ad/p2486923a/pcff54971/p42bac7dd;", "Landroidx/lifecycle/objectModel;", "tophHashSettingsUseCase", "Lp83f5c3ad/p684019bc/p76204a3d;", "<init>", "(Lp83f5c3ad/p684019bc/p76204a3d;)V", "getLaunchScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "startTapOnPhoneRoute", "Lpad5f82e8/p07214c67/pfd9160bb/p15913342;", "saveTophHashSettings", "", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "payment", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "comboTypeScreen", "Lpad5f82e8/p07214c67/pfd9160bb/pbfc85237;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p42bac7dd : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.p684019bc.p76204a3d f053d1b76;
    private readonly p83f5c3ad.p684019bc.p76204a3d f85272c98;
    private readonly p83f5c3ad.p684019bc.p76204a3d fc776bb19;

    public p42bac7dd(p83f5c3ad.p684019bc.p76204a3d tophHashSettingsUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophHashSettingsUseCase, "tophHashSettingsUseCase");
        this.f053d1b76 = tophHashSettingsUseCase;
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetLaunchScreen(pad5f82e8.p07214c67.pfd9160bb.p15913342 startTapOnPhoneRoute) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(startTapOnPhoneRoute, "startTapOnPhoneRoute");
        return p83f5c3ad.p2486923a.pcff54971.p42bac7dd$p12c674ac.$EnumSwitchDictionaryping$0[startTapOnPhoneRoute.ordinal()] != 1 ? p83f5c3ad.pfd9160bb.pf0d70128.f76425f17.AutoActivationScreen() : p83f5c3ad.pfd9160bb.pf0d70128.f76425f17.ConsoleoutScreen();
    }

    public readonly void SaveTophHashSettings(pad5f82e8.p07214c67.pfd9160bb.p15913342 startTapOnPhoneRoute, pad5f82e8.p07214c67.p1e11b989.p9ded6185 receipt, pad5f82e8.p07214c67.p1e11b989.pad7c4a1f payment, pad5f82e8.p07214c67.pfd9160bb.pbfc85237 comboTypeScreen) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(startTapOnPhoneRoute, "startTapOnPhoneRoute");
        this.f053d1b76.setStartTopRoute(startTapOnPhoneRoute);
        if (receipt is not null) {
            this.f053d1b76.setCurrentReceipt(receipt);
        }
        this.f053d1b76.setComboPayment(payment);
        this.f053d1b76.setComboTypeScreen(comboTypeScreen);
    }
}

