namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\bÀ\u0002\u0018\u00002\u00020\u0001:\u0002\u0006\u0007B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0006\u0010\u0003\u001a\u00020\u0004J\u0006\u0010\u0005\u001a\u00020\u0004¨\u0006\b"}, d2 = {"Landroidx/privacysandbox/ads/adservices/internal/AdServicesInfo;", "", "()V", "adServicesVersion", "", "extServicesVersionS", "Extensions30ExtImpl", "Extensions30Impl", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdServicesInfo {
    public static readonly androidx.privacysandbox.ads.adservices.internal.AdServicesInfo INSTANCE = new androidx.privacysandbox.ads.adservices.internal.AdServicesInfo();

    private AdServicesInfo() {
    }

    public readonly int AdServicesVersion() {
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return 0;
        }
        return androidx.privacysandbox.ads.adservices.internal.AdServicesInfo$Extensions30Impl.INSTANCE.getAdServicesVersion();
    }

    public readonly int ExtServicesVersionS() {
        if (android.os.Build$VERSION.SDK_INT == 31 || android.os.Build$VERSION.SDK_INT == 32) {
            return androidx.privacysandbox.ads.adservices.internal.AdServicesInfo$Extensions30ExtImpl.INSTANCE.getAdExtServicesVersionS();
        }
        return 0;
    }
}

