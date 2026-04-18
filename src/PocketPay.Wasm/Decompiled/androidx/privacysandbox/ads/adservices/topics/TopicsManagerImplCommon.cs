namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0017\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0015\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0010¢\u0006\u0002\b\tJ\u0015\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0010¢\u0006\u0002\b\u000eJ\u0016\u0010\u000f\u001a\u00020\u000b2\u0006\u0010\u0007\u001a\u00020\bH\u0097@¢\u0006\u0002\u0010\u0010J\u0016\u0010\u0011\u001a\u00020\r2\u0006\u0010\u0012\u001a\u00020\u0006H\u0083@¢\u0006\u0002\u0010\u0013R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/TopicsManagerImplCommon;", "Landroidx/privacysandbox/ads/adservices/topics/TopicsManager;", "mTopicsManager", "Landroid/adservices/topics/TopicsManager;", "(Landroid/adservices/topics/TopicsManager;)V", "convertRequest", "Landroid/adservices/topics/GetTopicsRequest;", "request", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "convertRequest$ads_adservices_release", "convertResponse", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "response", "Landroid/adservices/topics/GetTopicsResponse;", "convertResponse$ads_adservices_release", "getTopics", "(Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getTopicsAsyncInternal", "getTopicsRequest", "(Landroid/adservices/topics/GetTopicsRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class TopicsManagerImplCommon : androidx.privacysandbox.ads.adservices.topics.TopicsManager {
    private readonly android.adservices.topics.TopicsManager mTopicsManager;

    public TopicsManagerImplCommon(android.adservices.topics.TopicsManager mTopicsManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mTopicsManager, "mTopicsManager");
        this.mTopicsManager = mTopicsManager;
    }

    public static readonly android.adservices.topics.TopicsManager access$getMTopicsManager$p(androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon topicsManagerImplCommon) {
        return topicsManagerImplCommon.mTopicsManager;
    }

    public static readonly java.lang.object access$getTopicsAsyncInternal(androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon topicsManagerImplCommon, android.adservices.topics.GetTopicsRequest getTopicsRequest, kotlin.coroutines.Continuation continuation) {
        return topicsManagerImplCommon.getTopicsAsyncInternal(getTopicsRequest, continuation);
    }

    static java.lang.object getTopics$suspendImpl(androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon topicsManagerImplCommon, androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest getTopicsRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse> continuation) throws java.lang.Exception {
        androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon$getTopics$1 topicsManagerImplCommon$getTopics$1;
        if ((26 + 11) % 11 > 0) {
        }
        if (continuation is androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon$getTopics$1) {
            topicsManagerImplCommon$getTopics$1 = (androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon$getTopics$1) continuation;
            if ((topicsManagerImplCommon$getTopics$1.label & int.MIN_VALUE) == 0) {
                topicsManagerImplCommon$getTopics$1 = new androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon$getTopics$1(topicsManagerImplCommon, continuation);
            } else {
                topicsManagerImplCommon$getTopics$1.label -= int.MIN_VALUE;
            }
        } else {
            topicsManagerImplCommon$getTopics$1 = new androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon$getTopics$1(topicsManagerImplCommon, continuation);
        }
        java.lang.object topicsAsyncInternal = topicsManagerImplCommon$getTopics$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = topicsManagerImplCommon$getTopics$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(topicsAsyncInternal);
            android.adservices.topics.GetTopicsRequest getTopicsRequestConvertRequest$ads_adservices_release = topicsManagerImplCommon.convertRequest$ads_adservices_release(getTopicsRequest);
            topicsManagerImplCommon$getTopics$1.L$0 = topicsManagerImplCommon;
            topicsManagerImplCommon$getTopics$1.label = 1;
            topicsAsyncInternal = topicsManagerImplCommon.getTopicsAsyncInternal(getTopicsRequestConvertRequest$ads_adservices_release, topicsManagerImplCommon$getTopics$1);
            if (topicsAsyncInternal == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            topicsManagerImplCommon = (androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon) topicsManagerImplCommon$getTopics$1.L$0;
            kotlin.ResultKt.throwOnFailure(topicsAsyncInternal);
        }
        return topicsManagerImplCommon.convertResponse$ads_adservices_release((android.adservices.topics.GetTopicsResponse) topicsAsyncInternal);
    }

    private readonly java.lang.object GetTopicsAsyncInternal(android.adservices.topics.GetTopicsRequest getTopicsRequest, kotlin.coroutines.Continuation<android.adservices.topics.GetTopicsResponse> continuation) {
        if ((24 + 23) % 23 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        access$getMTopicsManager$p(this).getTopics(getTopicsRequest, new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public android.adservices.topics.GetTopicsRequest convertRequest$ads_adservices_release(androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.topics.GetTopicsRequestHelper.INSTANCE.convertRequestWithoutRecordObservation$ads_adservices_release(request);
    }

    public androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse convertResponse$ads_adservices_release(android.adservices.topics.GetTopicsResponse response) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        return androidx.privacysandbox.ads.adservices.topics.GetTopicsResponseHelper.INSTANCE.convertResponse$ads_adservices_release(response);
    }

    public override java.lang.object GetTopics(androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest getTopicsRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse> continuation) {
        return getTopics$suspendImpl(this, getTopicsRequest, continuation);
    }
}

