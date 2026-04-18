namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0017\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0097@¢\u0006\u0002\u0010\u000bJ\u000e\u0010\f\u001a\u00020\rH\u0097@¢\u0006\u0002\u0010\u000eJ \u0010\u000f\u001a\u00020\b2\u0006\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0013H\u0097@¢\u0006\u0002\u0010\u0014J\u0016\u0010\u000f\u001a\u00020\b2\u0006\u0010\u0015\u001a\u00020\u0016H\u0097@¢\u0006\u0002\u0010\u0017J\u0016\u0010\u0018\u001a\u00020\b2\u0006\u0010\u0019\u001a\u00020\u0011H\u0097@¢\u0006\u0002\u0010\u001aJ\u0016\u0010\u001b\u001a\u00020\b2\u0006\u0010\u0015\u001a\u00020\u001cH\u0097@¢\u0006\u0002\u0010\u001dJ\u0016\u0010\u001e\u001a\u00020\b2\u0006\u0010\u0015\u001a\u00020\u001fH\u0097@¢\u0006\u0002\u0010 R\u0014\u0010\u0002\u001a\u00020\u0003X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006!"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/MeasurementManagerImplCommon;", "Landroidx/privacysandbox/ads/adservices/measurement/MeasurementManager;", "mMeasurementManager", "Landroid/adservices/measurement/MeasurementManager;", "(Landroid/adservices/measurement/MeasurementManager;)V", "getMMeasurementManager", "()Landroid/adservices/measurement/MeasurementManager;", "deleteRegistrations", "", "deletionRequest", "Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getMeasurementApiStatus", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerSource", "attributionSource", "Landroid/net/Uri;", "inputEvent", "Landroid/view/InputEvent;", "(Landroid/net/Uri;Landroid/view/InputEvent;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "request", "Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerTrigger", "trigger", "(Landroid/net/Uri;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerWebSource", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerWebTrigger", "Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerRegistrationRequest;", "(Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerRegistrationRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class MeasurementManagerImplCommon : androidx.privacysandbox.ads.adservices.measurement.MeasurementManager {
    private readonly android.adservices.measurement.MeasurementManager mMeasurementManager;

    public MeasurementManagerImplCommon(android.adservices.measurement.MeasurementManager mMeasurementManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mMeasurementManager, "mMeasurementManager");
        this.mMeasurementManager = mMeasurementManager;
    }

    static java.lang.object deleteRegistrations$suspendImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((29 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        measurementManagerImplCommon.getMMeasurementManager().deleteRegistrations(deletionRequest.convertToAdServices$ads_adservices_release(), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    static java.lang.object getMeasurementApiStatus$suspendImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        if ((1 + 24) % 24 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        measurementManagerImplCommon.getMMeasurementManager().getMeasurementApiStatus(new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    static java.lang.object registerSource$suspendImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, android.net.Uri uri, android.view.InputEvent inputEvent, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((21 + 25) % 25 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        measurementManagerImplCommon.getMMeasurementManager().registerSource(uri, inputEvent, new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$RegisterSourceOptIn
    static java.lang.object registerSource$suspendImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest sourceRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        if ((27 + 23) % 23 > 0) {
        }
        java.lang.object objCoroutineScope = kotlinx.coroutines.CoroutineScopeKt.coroutineScope(new androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon$registerSource$4(sourceRegistrationRequest, measurementManagerImplCommon, null), continuation);
        return objCoroutineScope != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCoroutineScope;
    }

    static java.lang.object registerTrigger$suspendImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, android.net.Uri uri, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((32 + 7) % 7 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        measurementManagerImplCommon.getMMeasurementManager().registerTrigger(uri, new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    static java.lang.object registerWebSource$suspendImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest webSourceRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((18 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        measurementManagerImplCommon.getMMeasurementManager().registerWebSource(webSourceRegistrationRequest.convertToAdServices$ads_adservices_release(), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    static java.lang.object registerWebTrigger$suspendImpl(androidx.privacysandbox.ads.adservices.measurement.MeasurementManagerImplCommon measurementManagerImplCommon, androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest webTriggerRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((8 + 12) % 12 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        measurementManagerImplCommon.getMMeasurementManager().registerWebTrigger(webTriggerRegistrationRequest.convertToAdServices$ads_adservices_release(), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    public override java.lang.object DeleteRegistrations(androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return deleteRegistrations$suspendImpl(this, deletionRequest, continuation);
    }

    protected readonly android.adservices.measurement.MeasurementManager GetMMeasurementManager() {
        return this.mMeasurementManager;
    }

    public override java.lang.object GetMeasurementApiStatus(kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return getMeasurementApiStatus$suspendImpl(this, continuation);
    }

    public override java.lang.object RegisterSource(android.net.Uri uri, android.view.InputEvent inputEvent, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return registerSource$suspendImpl(this, uri, inputEvent, continuation);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$RegisterSourceOptIn
    public override java.lang.object RegisterSource(androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest sourceRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return registerSource$suspendImpl(this, sourceRegistrationRequest, continuation);
    }

    public override java.lang.object RegisterTrigger(android.net.Uri uri, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return registerTrigger$suspendImpl(this, uri, continuation);
    }

    public override java.lang.object RegisterWebSource(androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest webSourceRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return registerWebSource$suspendImpl(this, webSourceRegistrationRequest, continuation);
    }

    public override java.lang.object RegisterWebTrigger(androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest webTriggerRegistrationRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return registerWebTrigger$suspendImpl(this, webTriggerRegistrationRequest, continuation);
    }
}

