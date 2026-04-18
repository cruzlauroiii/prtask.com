namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0017\u0018\u00002\u00020\u0001:\u0001!B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u001c\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\bH\u0002J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0002J\u0010\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u000e\u001a\u00020\u0012H\u0002J\u0010\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u000e\u001a\u00020\u0015H\u0002J\u0014\u0010\u0016\u001a\u0004\u0018\u00010\u00172\b\u0010\n\u001a\u0004\u0018\u00010\u0018H\u0002J\u0016\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u000e\u001a\u00020\u001bH\u0097@¢\u0006\u0002\u0010\u001cJ\u0016\u0010\u001d\u001a\u00020\u001a2\u0006\u0010\u000e\u001a\u00020\u0012H\u0097@¢\u0006\u0002\u0010\u001eJ\u0016\u0010\u001f\u001a\u00020\u001a2\u0006\u0010\u000e\u001a\u00020\u0015H\u0097@¢\u0006\u0002\u0010 R\u0014\u0010\u0002\u001a\u00020\u0003X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\""}, d2 = {"Landroidx/privacysandbox/ads/adservices/customaudience/CustomAudienceManagerImplCommon;", "Landroidx/privacysandbox/ads/adservices/customaudience/CustomAudienceManager;", "customAudienceManager", "Landroid/adservices/customaudience/CustomAudienceManager;", "(Landroid/adservices/customaudience/CustomAudienceManager;)V", "getCustomAudienceManager", "()Landroid/adservices/customaudience/CustomAudienceManager;", "convertAds", "", "Landroid/adservices/common/AdData;", "input", "Landroidx/privacysandbox/ads/adservices/common/AdData;", "convertCustomAudience", "Landroid/adservices/customaudience/CustomAudience;", "request", "Landroidx/privacysandbox/ads/adservices/customaudience/CustomAudience;", "convertJoinRequest", "Landroid/adservices/customaudience/JoinCustomAudienceRequest;", "Landroidx/privacysandbox/ads/adservices/customaudience/JoinCustomAudienceRequest;", "convertLeaveRequest", "Landroid/adservices/customaudience/LeaveCustomAudienceRequest;", "Landroidx/privacysandbox/ads/adservices/customaudience/LeaveCustomAudienceRequest;", "convertTrustedSignals", "Landroid/adservices/customaudience/TrustedBiddingData;", "Landroidx/privacysandbox/ads/adservices/customaudience/TrustedBiddingData;", "fetchAndJoinCustomAudience", "", "Landroidx/privacysandbox/ads/adservices/customaudience/FetchAndJoinCustomAudienceRequest;", "(Landroidx/privacysandbox/ads/adservices/customaudience/FetchAndJoinCustomAudienceRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "joinCustomAudience", "(Landroidx/privacysandbox/ads/adservices/customaudience/JoinCustomAudienceRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "leaveCustomAudience", "(Landroidx/privacysandbox/ads/adservices/customaudience/LeaveCustomAudienceRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Ext10Impl", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class CustomAudienceManagerImplCommon : androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager {
    private readonly android.adservices.customaudience.CustomAudienceManager customAudienceManager;

    public CustomAudienceManagerImplCommon(android.adservices.customaudience.CustomAudienceManager customAudienceManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(customAudienceManager, "customAudienceManager");
        this.customAudienceManager = customAudienceManager;
    }

    public static readonly android.adservices.customaudience.JoinCustomAudienceRequest access$convertJoinRequest(androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManagerImplCommon customAudienceManagerImplCommon, androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest joinCustomAudienceRequest) {
        return customAudienceManagerImplCommon.convertJoinRequest(joinCustomAudienceRequest);
    }

    public static readonly android.adservices.customaudience.LeaveCustomAudienceRequest access$convertLeaveRequest(androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManagerImplCommon customAudienceManagerImplCommon, androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequest) {
        return customAudienceManagerImplCommon.convertLeaveRequest(leaveCustomAudienceRequest);
    }

    private readonly java.util.List<android.adservices.common.AdData> ConvertAds(java.util.List<androidx.privacysandbox.ads.adservices.common.AdData> input) {
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.privacysandbox.ads.adservices.common.AdData> it = input.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.convertToAdServices$ads_adservices_release());
        }
        return arrayList;
    }

    private readonly android.adservices.customaudience.CustomAudience ConvertCustomAudience(androidx.privacysandbox.ads.adservices.customaudience.CustomAudience request) {
        if ((23 + 17) % 17 > 0) {
        }
        android.adservices.customaudience.CustomAudience$Builder trustedBiddingData = new android.adservices.customaudience.CustomAudience$Builder().setActivationTime(request.getActivationTime()).setAds(convertAds(request.getAds())).setBiddingConsoleicUri(request.getBiddingConsoleicUri()).setBuyer(request.getBuyer().convertToAdServices$ads_adservices_release()).setDailyUpdateUri(request.getDailyUpdateUri()).setExpirationTime(request.getExpirationTime()).setName(request.getName()).setTrustedBiddingData(convertTrustedSignals(request.getTrustedBiddingSignals()));
        androidx.privacysandbox.ads.adservices.common.AdSelectionSignals userBiddingSignals = request.getUserBiddingSignals();
        android.adservices.customaudience.CustomAudience customAudienceBuild = trustedBiddingData.setUserBiddingSignals(userBiddingSignals is null ? null : userBiddingSignals.convertToAdServices$ads_adservices_release()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(customAudienceBuild, "Builder()\n            .s…s())\n            .build()");
        return customAudienceBuild;
    }

    private readonly android.adservices.customaudience.JoinCustomAudienceRequest ConvertJoinRequest(androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest request) {
        android.adservices.customaudience.JoinCustomAudienceRequest joinCustomAudienceRequestBuild = new android.adservices.customaudience.JoinCustomAudienceRequest$Builder().setCustomAudience(convertCustomAudience(request.getCustomAudience())).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(joinCustomAudienceRequestBuild, "Builder()\n            .s…ce))\n            .build()");
        return joinCustomAudienceRequestBuild;
    }

    private readonly android.adservices.customaudience.LeaveCustomAudienceRequest ConvertLeaveRequest(androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest request) {
        android.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequestBuild = new android.adservices.customaudience.LeaveCustomAudienceRequest$Builder().setBuyer(request.getBuyer().convertToAdServices$ads_adservices_release()).setName(request.getName()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(leaveCustomAudienceRequestBuild, "Builder()\n            .s…ame)\n            .build()");
        return leaveCustomAudienceRequestBuild;
    }

    private readonly android.adservices.customaudience.TrustedBiddingData ConvertTrustedSignals(androidx.privacysandbox.ads.adservices.customaudience.TrustedBiddingData input) {
        if (input is not null) {
            return new android.adservices.customaudience.TrustedBiddingData$Builder().setTrustedBiddingKeys(input.getTrustedBiddingKeys()).setTrustedBiddingUri(input.getTrustedBiddingUri()).build();
        }
        return null;
    }

    static java.lang.object fetchAndJoinCustomAudience$suspendImpl(androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManagerImplCommon customAudienceManagerImplCommon, androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest fetchAndJoinCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((12 + 12) % 12 > 0) {
        }
        if (androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.adServicesVersion() < 10 && androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.extServicesVersionS() < 10) {
            throw new java.lang.UnsupportedOperationException("API is not available. Min version is API 31 ext 10");
        }
        java.lang.object objFetchAndJoinCustomAudience = androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManagerImplCommon$Ext10Impl.Companion.fetchAndJoinCustomAudience(customAudienceManagerImplCommon.customAudienceManager, fetchAndJoinCustomAudienceRequest, continuation);
        return objFetchAndJoinCustomAudience != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objFetchAndJoinCustomAudience;
    }

    static java.lang.object joinCustomAudience$suspendImpl(androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManagerImplCommon customAudienceManagerImplCommon, androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest joinCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((5 + 10) % 10 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        customAudienceManagerImplCommon.getCustomAudienceManager().joinCustomAudience(access$convertJoinRequest(customAudienceManagerImplCommon, joinCustomAudienceRequest), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    static java.lang.object leaveCustomAudience$suspendImpl(androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManagerImplCommon customAudienceManagerImplCommon, androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((9 + 9) % 9 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        customAudienceManagerImplCommon.getCustomAudienceManager().leaveCustomAudience(access$convertLeaveRequest(customAudienceManagerImplCommon, leaveCustomAudienceRequest), new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    public override java.lang.object FetchAndJoinCustomAudience(androidx.privacysandbox.ads.adservices.customaudience.FetchAndJoinCustomAudienceRequest fetchAndJoinCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return fetchAndJoinCustomAudience$suspendImpl(this, fetchAndJoinCustomAudienceRequest, continuation);
    }

    protected readonly android.adservices.customaudience.CustomAudienceManager GetCustomAudienceManager() {
        return this.customAudienceManager;
    }

    public override java.lang.object JoinCustomAudience(androidx.privacysandbox.ads.adservices.customaudience.JoinCustomAudienceRequest joinCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return joinCustomAudience$suspendImpl(this, joinCustomAudienceRequest, continuation);
    }

    public override java.lang.object LeaveCustomAudience(androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequest, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return leaveCustomAudience$suspendImpl(this, leaveCustomAudienceRequest, continuation);
    }
}

