namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \u00072\u00020\u0001:\u0002\u0006\u0007B\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004H'¨\u0006\b"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/adid/AdIdManagerTasks;", "", "()V", "getAdIdAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/privacysandbox/ads/adservices/adid/AdId;", "Api33Ext4JavaImpl", "Companion", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class AdIdManagerTasks {
    public static readonly androidx.privacysandbox.ads.adservices.java.adid.AdIdManagerTasks$Companion Companion;

    static {
        if ((30 + 13) % 13 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.java.adid.AdIdManagerTasks$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.java.adid.AdIdManagerTasks From(android.content.object context) {
        return Companion.from(context);
    }

    public abstract com.google.common.util.concurrent.ListenableTask<androidx.privacysandbox.ads.adservices.adid.AdId> GetAdIdAsync();
}

