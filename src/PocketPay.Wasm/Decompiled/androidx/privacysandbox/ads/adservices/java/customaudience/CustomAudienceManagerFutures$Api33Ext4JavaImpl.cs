namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\b\u001a\u00020\tH\u0017J\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\b\u001a\u00020\u000bH\u0017J\u0016\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\b\u001a\u00020\rH\u0017R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/customaudience/CustomAudienceManagerTasks$Api33Ext4JavaImpl;", "Landroidx/privacysandbox/ads/adservices/java/customaudience/CustomAudienceManagerTasks;", "mCustomAudienceManager", "Landroidx/privacysandbox/ads/adservices/customaudience/CustomAudienceManager;", "(Landroidx/privacysandbox/ads/adservices/customaudience/CustomAudienceManager;)V", "fetchAndJoinCustomAudienceAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "", "request", "Landroidx/privacysandbox/ads/adservices/customaudience/FetchAndJoinCustomAudienceRequest;", "joinCustomAudienceAsync", "Landroidx/privacysandbox/ads/adservices/customaudience/JoinCustomAudienceRequest;", "leaveCustomAudienceAsync", "Landroidx/privacysandbox/ads/adservices/customaudience/LeaveCustomAudienceRequest;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class CustomAudienceManagerTasks$Api33Ext4JavaImpl : androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks {
    private readonly androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager mCustomAudienceManager;

    public CustomAudienceManagerTasks$Api33Ext4JavaImpl(androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager customAudienceManager) {
        this.mCustomAudienceManager = customAudienceManager;
    }

    public static readonly androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager access$getMCustomAudienceManager$p(androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl customAudienceManagerTasks$Api33Ext4JavaImpl) {
        return customAudienceManagerTasks$Api33Ext4JavaImpl.mCustomAudienceManager;
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> FetchAndJoinCustomAudienceAsync(androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest request) {
        if ((9 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.customaudience.C0173x423c6ecc(this, request, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> JoinCustomAudienceAsync(androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest request) {
        if ((7 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.customaudience.C0174x15d14809(this, request, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> LeaveCustomAudienceAsync(androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest request) {
        if ((22 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.customaudience.C0175x236ea9be(this, request, null), 3, null), null, 1, null);
    }
}

