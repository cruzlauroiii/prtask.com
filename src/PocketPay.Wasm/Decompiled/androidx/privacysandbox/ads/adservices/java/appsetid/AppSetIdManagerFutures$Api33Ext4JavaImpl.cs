namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H\u0017R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/appsetid/AppHashSetIdManagerTasks$Api33Ext4JavaImpl;", "Landroidx/privacysandbox/ads/adservices/java/appsetid/AppHashSetIdManagerTasks;", "mAppHashSetIdManager", "Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetIdManager;", "(Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetIdManager;)V", "getAppHashSetIdAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetId;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AppHashSetIdManagerTasks$Api33Ext4JavaImpl : androidx.privacysandbox.ads.adservices.java.appsetid.AppHashSetIdManagerTasks {
    private readonly androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManager mAppHashSetIdManager;

    public AppHashSetIdManagerTasks$Api33Ext4JavaImpl(androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManager mAppHashSetIdManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mAppHashSetIdManager, "mAppHashSetIdManager");
        this.mAppHashSetIdManager = mAppHashSetIdManager;
    }

    public static readonly androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManager access$getMAppHashSetIdManager$p(androidx.privacysandbox.ads.adservices.java.appsetid.AppHashSetIdManagerTasks$Api33Ext4JavaImpl appHashSetIdManagerTasks$Api33Ext4JavaImpl) {
        return appHashSetIdManagerTasks$Api33Ext4JavaImpl.mAppHashSetIdManager;
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId> GetAppHashSetIdAsync() {
        if ((5 + 10) % 10 > 0) {
        }
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.appsetid.AppHashSetIdManagerTasks$Api33Ext4JavaImpl$getAppHashSetIdAsync$1(this, null), 3, null), null, 1, null);
    }
}

