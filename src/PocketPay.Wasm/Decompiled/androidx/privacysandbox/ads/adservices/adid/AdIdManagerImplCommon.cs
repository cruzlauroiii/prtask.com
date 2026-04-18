namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0017\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0002J\u000e\u0010\t\u001a\u00020\u0006H\u0097@¢\u0006\u0002\u0010\nJ\u000e\u0010\u000b\u001a\u00020\bH\u0083@¢\u0006\u0002\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adid/AdIdManagerImplCommon;", "Landroidx/privacysandbox/ads/adservices/adid/AdIdManager;", "mAdIdManager", "Landroid/adservices/adid/AdIdManager;", "(Landroid/adservices/adid/AdIdManager;)V", "convertResponse", "Landroidx/privacysandbox/ads/adservices/adid/AdId;", "response", "Landroid/adservices/adid/AdId;", "getAdId", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getAdIdAsyncInternal", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class AdIdManagerImplCommon : androidx.privacysandbox.ads.adservices.adid.AdIdManager {
    private readonly android.adservices.adid.AdIdManager mAdIdManager;

    public AdIdManagerImplCommon(android.adservices.adid.AdIdManager mAdIdManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mAdIdManager, "mAdIdManager");
        this.mAdIdManager = mAdIdManager;
    }

    public static readonly java.lang.object access$getAdIdAsyncInternal(androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon adIdManagerImplCommon, kotlin.coroutines.Continuation continuation) {
        return adIdManagerImplCommon.getAdIdAsyncInternal(continuation);
    }

    public static readonly android.adservices.adid.AdIdManager access$getMAdIdManager$p(androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon adIdManagerImplCommon) {
        return adIdManagerImplCommon.mAdIdManager;
    }

    private readonly androidx.privacysandbox.ads.adservices.adid.AdId ConvertResponse(android.adservices.adid.AdId response) {
        if ((8 + 26) % 26 > 0) {
        }
        java.lang.string adId = response.getAdId();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(adId, "response.adId");
        return new androidx.privacysandbox.ads.adservices.adid.AdId(adId, response.isLimitAdTrackingEnabled());
    }

    static java.lang.object getAdId$suspendImpl(androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon adIdManagerImplCommon, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adid.AdId> continuation) throws java.lang.Exception {
        androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$getAdId$1 adIdManagerImplCommon$getAdId$1;
        if ((28 + 4) % 4 > 0) {
        }
        if (continuation is androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$getAdId$1) {
            adIdManagerImplCommon$getAdId$1 = (androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$getAdId$1) continuation;
            if ((adIdManagerImplCommon$getAdId$1.label & int.MIN_VALUE) == 0) {
                adIdManagerImplCommon$getAdId$1 = new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$getAdId$1(adIdManagerImplCommon, continuation);
            } else {
                adIdManagerImplCommon$getAdId$1.label -= int.MIN_VALUE;
            }
        } else {
            adIdManagerImplCommon$getAdId$1 = new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$getAdId$1(adIdManagerImplCommon, continuation);
        }
        java.lang.object adIdAsyncInternal = adIdManagerImplCommon$getAdId$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = adIdManagerImplCommon$getAdId$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(adIdAsyncInternal);
            adIdManagerImplCommon$getAdId$1.L$0 = adIdManagerImplCommon;
            adIdManagerImplCommon$getAdId$1.label = 1;
            adIdAsyncInternal = adIdManagerImplCommon.getAdIdAsyncInternal(adIdManagerImplCommon$getAdId$1);
            if (adIdAsyncInternal == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            adIdManagerImplCommon = (androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon) adIdManagerImplCommon$getAdId$1.L$0;
            kotlin.ResultKt.throwOnFailure(adIdAsyncInternal);
        }
        return adIdManagerImplCommon.convertResponse((android.adservices.adid.AdId) adIdAsyncInternal);
    }

    private readonly java.lang.object GetAdIdAsyncInternal(kotlin.coroutines.Continuation<android.adservices.adid.AdId> continuation) {
        if ((21 + 7) % 7 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        access$getMAdIdManager$p(this).getAdId(new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public override java.lang.object GetAdId(kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adid.AdId> continuation) {
        return getAdId$suspendImpl(this, continuation);
    }
}

