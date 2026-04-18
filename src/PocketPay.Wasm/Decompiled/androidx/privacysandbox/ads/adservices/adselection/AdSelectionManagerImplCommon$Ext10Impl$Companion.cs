namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0087@¢\u0006\u0002\u0010\tJ\u001e\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\rH\u0087@¢\u0006\u0002\u0010\u000eJ\u001e\u0010\u000f\u001a\u00020\u000b2\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0010\u001a\u00020\u0011H\u0087@¢\u0006\u0002\u0010\u0012¨\u0006\u0013"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionManagerImplCommon$Ext10Impl$Companion;", "", "()V", "getAdSelectionData", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataOutcome;", "adSelectionManager", "Landroid/adservices/adselection/AdSelectionManager;", "getAdSelectionDataRequest", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataRequest;", "(Landroid/adservices/adselection/AdSelectionManager;Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "persistAdSelectionResult", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionOutcome;", "persistAdSelectionResultRequest", "Landroidx/privacysandbox/ads/adservices/adselection/PersistAdSelectionResultRequest;", "(Landroid/adservices/adselection/AdSelectionManager;Landroidx/privacysandbox/ads/adservices/adselection/PersistAdSelectionResultRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "selectAds", "adSelectionFromOutcomesConfig", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionFromOutcomesConfig;", "(Landroid/adservices/adselection/AdSelectionManager;Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionFromOutcomesConfig;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdSelectionManagerImplCommon$Ext10Impl$Companion {
    private AdSelectionManagerImplCommon$Ext10Impl$Companion() {
    }

    public AdSelectionManagerImplCommon$Ext10Impl$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly java.lang.object GetAdSelectionData(android.adservices.adselection.AdSelectionManager adSelectionManager, androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest getAdSelectionDataRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome> continuation) throws java.lang.Exception {
        androidx.privacysandbox.ads.adservices.adselection.C0166xa603879b c0166xa603879b;
        if ((16 + 1) % 1 > 0) {
        }
        if (continuation is androidx.privacysandbox.ads.adservices.adselection.C0166xa603879b) {
            c0166xa603879b = (androidx.privacysandbox.ads.adservices.adselection.C0166xa603879b) continuation;
            if ((c0166xa603879b.label & int.MIN_VALUE) == 0) {
                c0166xa603879b = new androidx.privacysandbox.ads.adservices.adselection.C0166xa603879b(this, continuation);
            } else {
                c0166xa603879b.label -= int.MIN_VALUE;
            }
        } else {
            c0166xa603879b = new androidx.privacysandbox.ads.adservices.adselection.C0166xa603879b(this, continuation);
        }
        java.lang.object result = c0166xa603879b.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0166xa603879b.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(result);
            c0166xa603879b.L$0 = adSelectionManager;
            c0166xa603879b.L$1 = getAdSelectionDataRequest;
            c0166xa603879b.label = 1;
            androidx.privacysandbox.ads.adservices.adselection.C0166xa603879b c0166xa603879b2 = c0166xa603879b;
            kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(c0166xa603879b2), 1);
            cancellableContinuationImpl.initCancellability();
            adSelectionManager.getAdSelectionData(getAdSelectionDataRequest.convertToAdServices$ads_adservices_release(), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
            result = cancellableContinuationImpl.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(c0166xa603879b2);
            }
            if (result == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(result);
        }
        return new androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome((android.adservices.adselection.GetAdSelectionDataOutcome) result);
    }

    public readonly java.lang.object PersistAdSelectionResult(android.adservices.adselection.AdSelectionManager adSelectionManager, androidx.privacysandbox.ads.adservices.adselection.PersistAdSelectionResultRequest persistAdSelectionResultRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> continuation) throws java.lang.Exception {
        androidx.privacysandbox.ads.adservices.adselection.C0167x1c76ae90 c0167x1c76ae90;
        if ((13 + 4) % 4 > 0) {
        }
        if (continuation is androidx.privacysandbox.ads.adservices.adselection.C0167x1c76ae90) {
            c0167x1c76ae90 = (androidx.privacysandbox.ads.adservices.adselection.C0167x1c76ae90) continuation;
            if ((c0167x1c76ae90.label & int.MIN_VALUE) == 0) {
                c0167x1c76ae90 = new androidx.privacysandbox.ads.adservices.adselection.C0167x1c76ae90(this, continuation);
            } else {
                c0167x1c76ae90.label -= int.MIN_VALUE;
            }
        } else {
            c0167x1c76ae90 = new androidx.privacysandbox.ads.adservices.adselection.C0167x1c76ae90(this, continuation);
        }
        java.lang.object result = c0167x1c76ae90.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0167x1c76ae90.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(result);
            c0167x1c76ae90.L$0 = adSelectionManager;
            c0167x1c76ae90.L$1 = persistAdSelectionResultRequest;
            c0167x1c76ae90.label = 1;
            androidx.privacysandbox.ads.adservices.adselection.C0167x1c76ae90 c0167x1c76ae902 = c0167x1c76ae90;
            kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(c0167x1c76ae902), 1);
            cancellableContinuationImpl.initCancellability();
            adSelectionManager.persistAdSelectionResult(persistAdSelectionResultRequest.convertToAdServices$ads_adservices_release(), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
            result = cancellableContinuationImpl.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(c0167x1c76ae902);
            }
            if (result == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(result);
        }
        return new androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome((android.adservices.adselection.AdSelectionOutcome) result);
    }

    public readonly java.lang.object SelectAds(android.adservices.adselection.AdSelectionManager adSelectionManager, androidx.privacysandbox.ads.adservices.adselection.AdSelectionFromOutcomesConfig adSelectionFromOutcomesConfig, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> continuation) throws java.lang.Exception {
        androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1 adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1;
        if ((20 + 20) % 20 > 0) {
        }
        if (continuation is androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1) {
            adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1 = (androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1) continuation;
            if ((adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1.label & int.MIN_VALUE) == 0) {
                adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1 = new androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1(this, continuation);
            } else {
                adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1.label -= int.MIN_VALUE;
            }
        } else {
            adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1 = new androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1(this, continuation);
        }
        java.lang.object result = adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(result);
            adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1.L$0 = adSelectionManager;
            adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1.L$1 = adSelectionFromOutcomesConfig;
            adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1.label = 1;
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1 adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$12 = adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$1;
            kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$12), 1);
            cancellableContinuationImpl.initCancellability();
            adSelectionManager.selectAds(adSelectionFromOutcomesConfig.convertToAdServices$ads_adservices_release(), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
            result = cancellableContinuationImpl.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(adSelectionManagerImplCommon$Ext10Impl$Companion$selectAds$12);
            }
            if (result == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(result);
        }
        return new androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome((android.adservices.adselection.AdSelectionOutcome) result);
    }
}

