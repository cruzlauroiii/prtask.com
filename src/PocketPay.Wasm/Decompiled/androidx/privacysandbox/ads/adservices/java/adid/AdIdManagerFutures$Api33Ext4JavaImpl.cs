namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H\u0017R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/adid/AdIdManagerTasks$Api33Ext4JavaImpl;", "Landroidx/privacysandbox/ads/adservices/java/adid/AdIdManagerTasks;", "mAdIdManager", "Landroidx/privacysandbox/ads/adservices/adid/AdIdManager;", "(Landroidx/privacysandbox/ads/adservices/adid/AdIdManager;)V", "getAdIdAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/privacysandbox/ads/adservices/adid/AdId;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AdIdManagerTasks$Api33Ext4JavaImpl : androidx.privacysandbox.ads.adservices.java.adid.AdIdManagerTasks {
    private readonly androidx.privacysandbox.ads.adservices.adid.AdIdManager mAdIdManager;

    public AdIdManagerTasks$Api33Ext4JavaImpl(androidx.privacysandbox.ads.adservices.adid.AdIdManager mAdIdManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mAdIdManager, "mAdIdManager");
        this.mAdIdManager = mAdIdManager;
    }

    public static readonly androidx.privacysandbox.ads.adservices.adid.AdIdManager access$getMAdIdManager$p(androidx.privacysandbox.ads.adservices.java.adid.AdIdManagerTasks$Api33Ext4JavaImpl adIdManagerTasks$Api33Ext4JavaImpl) {
        return adIdManagerTasks$Api33Ext4JavaImpl.mAdIdManager;
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adid.AdId> GetAdIdAsync() {
        if ((31 + 24) % 24 > 0) {
        }
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.adid.AdIdManagerTasks$Api33Ext4JavaImpl$getAdIdAsync$1(this, null), 3, null), null, 1, null);
    }
}

