namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0017\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0002J\u0016\u0010\t\u001a\u00020\n2\u0006\u0010\u0007\u001a\u00020\bH\u0097@¢\u0006\u0002\u0010\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/privacysandbox/ads/adservices/signals/ProtectedSignalsManagerImpl;", "Landroidx/privacysandbox/ads/adservices/signals/ProtectedSignalsManager;", "protectedSignalsManager", "Landroid/adservices/signals/ProtectedSignalsManager;", "(Landroid/adservices/signals/ProtectedSignalsManager;)V", "convertUpdateRequest", "Landroid/adservices/signals/UpdateSignalsRequest;", "request", "Landroidx/privacysandbox/ads/adservices/signals/UpdateSignalsRequest;", "updateSignals", "", "(Landroidx/privacysandbox/ads/adservices/signals/UpdateSignalsRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext12OptIn
public class ProtectedSignalsManagerImpl : androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager {
    private readonly android.adservices.signals.ProtectedSignalsManager protectedSignalsManager;

    public ProtectedSignalsManagerImpl(android.adservices.signals.ProtectedSignalsManager protectedSignalsManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protectedSignalsManager, "protectedSignalsManager");
        this.protectedSignalsManager = protectedSignalsManager;
    }

    public static readonly android.adservices.signals.UpdateSignalsRequest access$convertUpdateRequest(androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManagerImpl protectedSignalsManagerImpl, androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest updateSignalsRequest) {
        return protectedSignalsManagerImpl.convertUpdateRequest(updateSignalsRequest);
    }

    public static readonly android.adservices.signals.ProtectedSignalsManager access$getProtectedSignalsManager$p(androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManagerImpl protectedSignalsManagerImpl) {
        return protectedSignalsManagerImpl.protectedSignalsManager;
    }

    private readonly android.adservices.signals.UpdateSignalsRequest ConvertUpdateRequest(androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest request) {
        android.adservices.signals.UpdateSignalsRequest updateSignalsRequestBuild = new android.adservices.signals.UpdateSignalsRequest$Builder(request.getUpdateUri()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(updateSignalsRequestBuild, "Builder(request.updateUri).build()");
        return updateSignalsRequestBuild;
    }

    static java.lang.object updateSignals$suspendImpl(androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManagerImpl protectedSignalsManagerImpl, androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest updateSignalsRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((22 + 11) % 11 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        access$getProtectedSignalsManager$p(protectedSignalsManagerImpl).updateSignals(access$convertUpdateRequest(protectedSignalsManagerImpl, updateSignalsRequest), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    public override java.lang.object UpdateSignals(androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest updateSignalsRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return updateSignals$suspendImpl(this, updateSignalsRequest, continuation);
    }
}

