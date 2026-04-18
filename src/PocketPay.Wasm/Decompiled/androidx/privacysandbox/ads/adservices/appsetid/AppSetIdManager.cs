namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \u00062\u00020\u0001:\u0001\u0006B\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\u0005¨\u0006\u0007"}, d2 = {"Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetIdManager;", "", "()V", "getAppHashSetId", "Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetId;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class AppHashSetIdManager {
    public static readonly androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManager$Companion Companion;

    static {
        if ((26 + 26) % 26 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManager$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManager Obtain(android.content.object context) {
        return Companion.obtain(context);
    }

    public abstract java.lang.object GetAppHashSetId(kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId> continuation);
}

