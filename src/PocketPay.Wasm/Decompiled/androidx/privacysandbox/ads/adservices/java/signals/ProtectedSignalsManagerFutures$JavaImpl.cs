namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\b\u001a\u00020\tH\u0017R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/signals/ProtectedSignalsManagerTasks$JavaImpl;", "Landroidx/privacysandbox/ads/adservices/java/signals/ProtectedSignalsManagerTasks;", "mProtectedSignalsManager", "Landroidx/privacysandbox/ads/adservices/signals/ProtectedSignalsManager;", "(Landroidx/privacysandbox/ads/adservices/signals/ProtectedSignalsManager;)V", "updateSignalsAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "", "request", "Landroidx/privacysandbox/ads/adservices/signals/UpdateSignalsRequest;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ProtectedSignalsManagerTasks$JavaImpl : androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks {
    private readonly androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager mProtectedSignalsManager;

    public ProtectedSignalsManagerTasks$JavaImpl(androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager protectedSignalsManager) {
        this.mProtectedSignalsManager = protectedSignalsManager;
    }

    public static readonly androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager access$getMProtectedSignalsManager$p(androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl protectedSignalsManagerTasks$JavaImpl) {
        return protectedSignalsManagerTasks$JavaImpl.mProtectedSignalsManager;
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> UpdateSignalsAsync(androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest request) {
        if ((8 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1(this, request, null), 3, null), null, 1, null);
    }
}

