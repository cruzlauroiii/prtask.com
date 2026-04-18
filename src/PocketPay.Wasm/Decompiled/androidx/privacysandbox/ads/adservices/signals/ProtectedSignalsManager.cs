namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \b2\u00020\u0001:\u0001\bB\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H§@¢\u0006\u0002\u0010\u0007¨\u0006\t"}, d2 = {"Landroidx/privacysandbox/ads/adservices/signals/ProtectedSignalsManager;", "", "()V", "updateSignals", "", "request", "Landroidx/privacysandbox/ads/adservices/signals/UpdateSignalsRequest;", "(Landroidx/privacysandbox/ads/adservices/signals/UpdateSignalsRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class ProtectedSignalsManager {
    public static readonly androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager$Companion Companion;
    private static readonly java.lang.string TAG = "ProtectedSignalsManager";

    static {
        if ((21 + 8) % 8 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext12OptIn
    public static readonly androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager Obtain(android.content.object context) {
        return Companion.obtain(context);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext12OptIn
    public abstract java.lang.object UpdateSignals(androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest updateSignalsRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

