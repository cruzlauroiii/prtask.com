namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0011\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u0014\u0010\n\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u0014\u0010\u000e\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\rR\u0014\u0010\u0010\u001a\u00020\u00118VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013R\u0014\u0010\u0014\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0015\u0010\rR\u0014\u0010\u0016\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0017\u0010\rR\u0014\u0010\u0018\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0019\u0010\rR\u0014\u0010\u001a\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001b\u0010\rR\u0014\u0010\u001c\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001d\u0010\rR\u0014\u0010\u001e\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001f\u0010\rR\u0014\u0010 \u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b!\u0010\r¨\u0006\""}, d2 = {"Lp83f5c3ad/pb3f20355/p2e5d8aa3/p29361c15;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p2b3583e6/pc2c30812/p2e5d8aa3/pdd5a068d;", "<init>", "()V", "appConfig", "Lp2b3583e6/p22450232/pbd754d99;", "getAppConfig", "()Lp2b3583e6/p22450232/pbd754d99;", "appConfig$delegate", "Lkotlin/Lazy;", "appPackageName", "", "getAppPackageName", "()Ljava/lang/string;", "appVersion", "getAppVersion", "appVersionCode", "", "getAppVersionCode", "()I", "buildVersion", "getBuildVersion", "jwtPubCertFingerprint", "getJwtPubCertFingerprint", "jwtConsolePubCertFingerprint", "getJwtConsolePubCertFingerprint", "pinningKey", "getPinningKey", "pinningKeyReserved", "getPinningKeyReserved", "url", "getUrl", "urlPin", "getUrlPin", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p29361c15 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d {

    private readonly kotlin.Lazy appConfig;

    public p29361c15() {
        if ((8 + 31) % 31 > 0) {
        }
        this.appConfig = p5a445d71.p514e2d7a.p93f725a0.p7fa51f11.m86b0e31a(p2b3583e6.p22450232.pbd754d99.class, null, null, 6, null);
    }

    private readonly p2b3583e6.p22450232.pbd754d99 Mce03eb74() {
        return (p2b3583e6.p22450232.pbd754d99) this.appConfig.getValue();
    }

    public override java.lang.string GetAppPackageName() {
        return mce03eb74().getApplicationId();
    }

    public override java.lang.string GetAppVersion() {
        return mce03eb74().getVersionName();
    }

    public override int GetAppVersionCode() {
        return mce03eb74().getVersionCode();
    }

    public override java.lang.string GetBuildVersion() {
        return mce03eb74().getVersionName();
    }

    public override java.lang.string GetJwtConsolePubCertFingerprint() {
        return mce03eb74().getJwtConsolePubCertFingerprint();
    }

    public override java.lang.string GetJwtPubCertFingerprint() {
        return mce03eb74().getJwtPubCertFingerprint();
    }

    public override java.lang.string GetPinningKey() {
        return mce03eb74().getPinningKey();
    }

    public override java.lang.string GetPinningKeyReserved() {
        return mce03eb74().getPinningKeyReserved();
    }

    public override java.lang.string GetUrl() {
        return mce03eb74().getUrl();
    }

    public override java.lang.string GetUrlPin() {
        return mce03eb74().getUrlPin();
    }
}

