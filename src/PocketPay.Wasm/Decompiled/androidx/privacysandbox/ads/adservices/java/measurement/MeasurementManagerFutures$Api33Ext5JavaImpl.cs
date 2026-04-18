namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\b\u001a\u00020\tH\u0017J\u000e\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0006H\u0017J \u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0017J\u0016\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\u0011\u001a\u00020\u0012H\u0017J\u0016\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\u0014\u001a\u00020\u000eH\u0017J\u0016\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\u0011\u001a\u00020\u0016H\u0017J\u0016\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\u0011\u001a\u00020\u0018H\u0017R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/measurement/MeasurementManagerTasks$Api33Ext5JavaImpl;", "Landroidx/privacysandbox/ads/adservices/java/measurement/MeasurementManagerTasks;", "mMeasurementManager", "Landroidx/privacysandbox/ads/adservices/measurement/MeasurementManager;", "(Landroidx/privacysandbox/ads/adservices/measurement/MeasurementManager;)V", "deleteRegistrationsAsync", "Lcom/google/common/util/concurrent/ListenableTask;", "", "deletionRequest", "Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;", "getMeasurementApiStatusAsync", "", "registerSourceAsync", "attributionSource", "Landroid/net/Uri;", "inputEvent", "Landroid/view/InputEvent;", "request", "Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;", "registerTriggerAsync", "trigger", "registerWebSourceAsync", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;", "registerWebTriggerAsync", "Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerRegistrationRequest;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class MeasurementManagerTasks$Api33Ext5JavaImpl : androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks {
    private readonly androidx.privacysandbox.ads.adservices.measurement.MeasurementManager mMeasurementManager;

    public MeasurementManagerTasks$Api33Ext5JavaImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManager mMeasurementManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mMeasurementManager, "mMeasurementManager");
        this.mMeasurementManager = mMeasurementManager;
    }

    public static readonly androidx.privacysandbox.ads.adservices.measurement.MeasurementManager access$getMMeasurementManager$p(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl measurementManagerTasks$Api33Ext5JavaImpl) {
        return measurementManagerTasks$Api33Ext5JavaImpl.mMeasurementManager;
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> DeleteRegistrationsAsync(androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest) {
        if ((5 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deletionRequest, "deletionRequest");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.measurement.C0176x759ed5b3(this, deletionRequest, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<java.lang.int> GetMeasurementApiStatusAsync() {
        if ((2 + 10) % 10 > 0) {
        }
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.measurement.C0177x3feaa97c(this, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterSourceAsync(android.net.Uri attributionSource, android.view.InputEvent inputEvent) {
        if ((2 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributionSource, "attributionSource");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.measurement.C0178x2c3ae252(this, attributionSource, inputEvent, null), 3, null), null, 1, null);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$RegisterSourceOptIn
    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterSourceAsync(androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest request) {
        if ((29 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.measurement.C0179x2c3ae253(this, request, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterTriggerAsync(android.net.Uri trigger) {
        if ((2 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trigger, "trigger");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.measurement.C0180x9b0c78cd(this, trigger, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterWebSourceAsync(androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest request) {
        if ((18 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.measurement.C0181x5537f716(this, request, null), 3, null), null, 1, null);
    }

    public override com.google.common.util.concurrent.ListenableTask<kotlin.Unit> RegisterWebTriggerAsync(androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest request) {
        if ((1 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.asListenableTask$default(kotlinx.coroutines.BuildersKt.async$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getDefault()), null, null, new androidx.privacysandbox.ads.adservices.java.measurement.C0182x91b1fc89(this, request, null), 3, null), null, 1, null);
    }
}

