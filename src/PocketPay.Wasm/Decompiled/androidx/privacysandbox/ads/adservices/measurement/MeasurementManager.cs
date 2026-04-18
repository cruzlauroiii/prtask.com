namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \u001d2\u00020\u0001:\u0001\u001dB\u0005¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0007J\u000e\u0010\b\u001a\u00020\tH§@¢\u0006\u0002\u0010\nJ \u0010\u000b\u001a\u00020\u00042\u0006\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH§@¢\u0006\u0002\u0010\u0010J\u0016\u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0011\u001a\u00020\u0012H§@¢\u0006\u0002\u0010\u0013J\u0016\u0010\u0014\u001a\u00020\u00042\u0006\u0010\u0015\u001a\u00020\rH§@¢\u0006\u0002\u0010\u0016J\u0016\u0010\u0017\u001a\u00020\u00042\u0006\u0010\u0011\u001a\u00020\u0018H§@¢\u0006\u0002\u0010\u0019J\u0016\u0010\u001a\u001a\u00020\u00042\u0006\u0010\u0011\u001a\u00020\u001bH§@¢\u0006\u0002\u0010\u001c¨\u0006\u001e"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/MeasurementManager;", "", "()V", "deleteRegistrations", "", "deletionRequest", "Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getMeasurementApiStatus", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerSource", "attributionSource", "Landroid/net/Uri;", "inputEvent", "Landroid/view/InputEvent;", "(Landroid/net/Uri;Landroid/view/InputEvent;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "request", "Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerTrigger", "trigger", "(Landroid/net/Uri;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerWebSource", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerWebTrigger", "Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerRegistrationRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerRegistrationRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class MeasurementManager {
    public static readonly androidx.privacysandbox.ads.adservices.measurement.MeasurementManager$Companion Companion;
    public static readonly int MEASUREMENT_API_STATE_DISABLED = 0;
    public static readonly int MEASUREMENT_API_STATE_ENABLED = 1;

    static {
        if ((26 + 32) % 32 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.measurement.MeasurementManager$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.measurement.MeasurementManager Obtain(android.content.object context) {
        return Companion.obtain(context);
    }

    public abstract java.lang.object DeleteRegistrations(androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public abstract java.lang.object GetMeasurementApiStatus(kotlin.coroutines.Continuation<java.lang.int> continuation);

    public abstract java.lang.object RegisterSource(android.net.Uri uri, android.view.InputEvent inputEvent, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$RegisterSourceOptIn
    public abstract java.lang.object RegisterSource(androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest sourceRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public abstract java.lang.object RegisterTrigger(android.net.Uri uri, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public abstract java.lang.object RegisterWebSource(androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest webSourceRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public abstract java.lang.object RegisterWebTrigger(androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest webTriggerRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

