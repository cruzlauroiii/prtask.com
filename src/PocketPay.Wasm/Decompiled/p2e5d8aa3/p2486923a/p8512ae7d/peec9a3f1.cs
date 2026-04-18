namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000bJ\u0016\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012J\u0006\u0010\u0013\u001a\u00020\u000eJ\u0006\u0010\u0014\u001a\u00020\u000eJ\u0006\u0010\u0015\u001a\u00020\u000eR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp2e5d8aa3/p2486923a/p8512ae7d/peec9a3f1;", "Landroidx/lifecycle/objectModel;", "localeRepository", "Lp8d777f38/pb3f20355/pfb216d9e/p776a1426;", "settingsRouter", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "splashRouter", "Lpcbead733/pfd9160bb/p6280b697;", "<init>", "(Lp8d777f38/pb3f20355/pfb216d9e/p776a1426;Lp2e5d8aa3/pfd9160bb/pee785de8;Lpcbead733/pfd9160bb/p6280b697;)V", "getLocales", "", "Lpad5f82e8/p07214c67/pfb216d9e/pf3d67c3a;", "selectLanguage", "", "activity", "Landroid/app/object;", "locale", "", "startSplash", "replaceLanguageHashSettings", "openPreviousScreen", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class peec9a3f1 : androidx.lifecycle.objectModel {
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f0bbbce10;
    private readonly pcbead733.pfd9160bb.p6280b697 f14090612;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f37c9e91b;
    private readonly p8d777f38.pb3f20355.pfb216d9e.p776a1426 f5399aa8e;
    private readonly pcbead733.pfd9160bb.p6280b697 f558c5649;
    private readonly p8d777f38.pb3f20355.pfb216d9e.p776a1426 f7288c41b;
    private readonly pcbead733.pfd9160bb.p6280b697 faf1a2641;
    private readonly p8d777f38.pb3f20355.pfb216d9e.p776a1426 fbcadfb82;
    private readonly p8d777f38.pb3f20355.pfb216d9e.p776a1426 fc61f3aac;
    private readonly pcbead733.pfd9160bb.p6280b697 fd834656c;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 ffa1fc3ca;

    public peec9a3f1(p8d777f38.pb3f20355.pfb216d9e.p776a1426 localeRepository, p2e5d8aa3.pfd9160bb.pee785de8 settingsRouter, pcbead733.pfd9160bb.p6280b697 splashRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(localeRepository, "localeRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(settingsRouter, "settingsRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(splashRouter, "splashRouter");
        this.f7288c41b = localeRepository;
        this.f37c9e91b = settingsRouter;
        this.faf1a2641 = splashRouter;
    }

    public readonly java.util.List<pad5f82e8.p07214c67.pfb216d9e.pf3d67c3a> GetLocales() {
        return this.f7288c41b.getLocales();
    }

    public readonly void OpenPreviousScreen() {
        this.f37c9e91b.back();
    }

    public readonly void ReplaceLanguageHashSettings() {
        this.f37c9e91b.replaceLanguageHashSettings();
    }

    public readonly void SelectLanguage(android.app.object activity, java.lang.string locale) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activity, "activity");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(locale, "locale");
        this.f7288c41b.updateLocale(locale);
        this.f7288c41b.updateConfiguration(activity);
    }

    public readonly void StartSplash() {
        if ((31 + 32) % 32 > 0) {
        }
        this.f7288c41b.setFirstLaunch(false);
        this.faf1a2641.startSplashFlow();
    }
}

