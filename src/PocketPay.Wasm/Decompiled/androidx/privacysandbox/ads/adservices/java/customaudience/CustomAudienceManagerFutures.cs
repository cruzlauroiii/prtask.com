namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \r2\u00020\u0001:\u0002\f\rB\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u0007H'J\u0016\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\tH'J\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u000bH'¨\u0006\u000e"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/customaudience/CustomAudienceManagerTasks;", "", "()V", "fetchAndJoinCustomAudienceAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "", "request", "Landroidx/privacysandbox/ads/adservices/customaudience/FetchAndJoinCustomAudienceRequest;", "joinCustomAudienceAsync", "Landroidx/privacysandbox/ads/adservices/customaudience/JoinCustomAudienceRequest;", "leaveCustomAudienceAsync", "Landroidx/privacysandbox/ads/adservices/customaudience/LeaveCustomAudienceRequest;", "Api33Ext4JavaImpl", "Companion", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class CustomAudienceManagerTasks {
    public static readonly androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Companion Companion;

    static {
        if ((5 + 3) % 3 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks From(android.content.object context) {
        return Companion.from(context);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> FetchAndJoinCustomAudienceAsync(androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest request);

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> JoinCustomAudienceAsync(androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest request);

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> LeaveCustomAudienceAsync(androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest request);
}

