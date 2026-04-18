namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \b2\u00020\u0001:\u0001\bB\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H§@¢\u0006\u0002\u0010\u0007¨\u0006\t"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/TopicsManager;", "", "()V", "getTopics", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "request", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "(Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class TopicsManager {
    public static readonly androidx.privacysandbox.ads.adservices.topics.TopicsManager$Companion Companion;

    static {
        if ((15 + 15) % 15 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.topics.TopicsManager$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.topics.TopicsManager Obtain(android.content.object context) {
        return Companion.obtain(context);
    }

    public abstract java.lang.object GetTopics(androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest getTopicsRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse> continuation);
}

