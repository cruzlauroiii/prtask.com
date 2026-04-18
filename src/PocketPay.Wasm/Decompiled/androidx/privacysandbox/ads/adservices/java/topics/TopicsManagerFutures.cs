namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \t2\u00020\u0001:\u0002\b\tB\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u0007H'¨\u0006\n"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/topics/TopicsManagerTasks;", "", "()V", "getTopicsAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "request", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "CommonApiJavaImpl", "Companion", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class TopicsManagerTasks {
    public static readonly androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$Companion Companion;

    static {
        if ((28 + 28) % 28 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.java.topics.TopicsManagerTasks From(android.content.object context) {
        return Companion.from(context);
    }

    public abstract com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse> GetTopicsAsync(androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest request);
}

