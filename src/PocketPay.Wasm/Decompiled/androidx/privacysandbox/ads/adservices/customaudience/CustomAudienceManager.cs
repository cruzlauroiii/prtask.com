namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \u000e2\u00020\u0001:\u0001\u000eB\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H§@¢\u0006\u0002\u0010\u0007J\u0016\u0010\b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\tH§@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\fH§@¢\u0006\u0002\u0010\r¨\u0006\u000f"}, d2 = {"Landroidx/privacysandbox/ads/adservices/customaudience/CustomAudienceManager;", "", "()V", "fetchAndJoinCustomAudience", "", "request", "Landroidx/privacysandbox/ads/adservices/customaudience/FetchAndJoinCustomAudienceRequest;", "(Landroidx/privacysandbox/ads/adservices/customaudience/FetchAndJoinCustomAudienceRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "joinCustomAudience", "Landroidx/privacysandbox/ads/adservices/customaudience/JoinCustomAudienceRequest;", "(Landroidx/privacysandbox/ads/adservices/customaudience/JoinCustomAudienceRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "leaveCustomAudience", "Landroidx/privacysandbox/ads/adservices/customaudience/LeaveCustomAudienceRequest;", "(Landroidx/privacysandbox/ads/adservices/customaudience/LeaveCustomAudienceRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class CustomAudienceManager {
    public static readonly androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager$Companion Companion;

    static {
        if ((13 + 10) % 10 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager Obtain(android.content.object context) {
        return Companion.obtain(context);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public abstract java.lang.object FetchAndJoinCustomAudience(androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest fetchAndJoinCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public abstract java.lang.object JoinCustomAudience(androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest joinCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public abstract java.lang.object LeaveCustomAudience(androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

