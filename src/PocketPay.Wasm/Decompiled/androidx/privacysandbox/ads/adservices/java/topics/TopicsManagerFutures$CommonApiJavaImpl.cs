namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\b\u001a\u00020\tH\u0017R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/topics/TopicsManagerTasks$CommonApiJavaImpl;", "Landroidx/privacysandbox/ads/adservices/java/topics/TopicsManagerTasks;", "mTopicsManager", "Landroidx/privacysandbox/ads/adservices/topics/TopicsManager;", "(Landroidx/privacysandbox/ads/adservices/topics/TopicsManager;)V", "getTopicsAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "request", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class TopicsManagerTasks$CommonApiJavaImpl : androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks {
    private readonly androidx.privacysandbox.ads.adservices.topics.TopicsManager mTopicsManager;

    public TopicsManagerTasks$CommonApiJavaImpl(androidx.privacysandbox.ads.adservices.topics.TopicsManager mTopicsManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mTopicsManager, "mTopicsManager");
        this.mTopicsManager = mTopicsManager;
    }

    public static readonly androidx.privacysandbox.ads.adservices.topics.TopicsManager access$getMTopicsManager$p(androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl topicsManagerTasks$CommonApiJavaImpl) {
        return topicsManagerTasks$CommonApiJavaImpl.mTopicsManager;
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse> GetTopicsAsync(androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest request) {
        if ((2 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getMain()), null, null, new androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$CommonApiJavaImpl$getTopicsAsync$1(this, request, null), 3, null), null, 1, null);
    }
}

