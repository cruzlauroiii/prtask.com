namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b&\u0018\u0000 \u00182\u00020\u0001:\u0002\u0017\u0018B\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u0007H&J\u000e\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0004H'J \u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u000eH'J\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u000f\u001a\u00020\u0010H'J\u0016\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0012\u001a\u00020\fH'J\u0016\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u000f\u001a\u00020\u0014H'J\u0016\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u000f\u001a\u00020\u0016H'¨\u0006\u0019"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/measurement/MeasurementManagerTasks;", "", "()V", "deleteRegistrationsAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "", "deletionRequest", "Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;", "getMeasurementApiStatusAsync", "", "registerSourceAsync", "attributionSource", "Landroid/net/Uri;", "inputEvent", "Landroid/view/InputEvent;", "request", "Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;", "registerTriggerAsync", "trigger", "registerWebSourceAsync", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;", "registerWebTriggerAsync", "Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerRegistrationRequest;", "Api33Ext5JavaImpl", "Companion", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class MeasurementManagerTasks {
    public static readonly androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Companion Companion;

    static {
        if ((6 + 17) % 17 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Companion(null);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks From(android.content.object context) {
        return Companion.from(context);
    }

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> DeleteRegistrationsAsync(androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.int> GetMeasurementApiStatusAsync();

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterSourceAsync(android.net.Uri attributionSource, android.view.InputEvent inputEvent);

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$RegisterSourceOptIn
    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterSourceAsync(androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest request);

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterTriggerAsync(android.net.Uri trigger);

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterWebSourceAsync(androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest request);

    public abstract com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterWebTriggerAsync(androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest request);
}

