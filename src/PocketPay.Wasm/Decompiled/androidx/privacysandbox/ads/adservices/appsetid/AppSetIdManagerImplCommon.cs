namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0017\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0002J\u000e\u0010\t\u001a\u00020\u0006H\u0097@¢\u0006\u0002\u0010\nJ\u000e\u0010\u000b\u001a\u00020\bH\u0082@¢\u0006\u0002\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetIdManagerImplCommon;", "Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetIdManager;", "mAppHashSetIdManager", "Landroid/adservices/appsetid/AppHashSetIdManager;", "(Landroid/adservices/appsetid/AppHashSetIdManager;)V", "convertResponse", "Landroidx/privacysandbox/ads/adservices/appsetid/AppHashSetId;", "response", "Landroid/adservices/appsetid/AppHashSetId;", "getAppHashSetId", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getAppHashSetIdAsyncInternal", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class AppHashSetIdManagerImplCommon : androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManager {
    private readonly android.adservices.appsetid.AppHashSetIdManager mAppHashSetIdManager;

    public AppHashSetIdManagerImplCommon(android.adservices.appsetid.AppHashSetIdManager mAppHashSetIdManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mAppHashSetIdManager, "mAppHashSetIdManager");
        this.mAppHashSetIdManager = mAppHashSetIdManager;
    }

    public static readonly java.lang.object access$getAppHashSetIdAsyncInternal(androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon appHashSetIdManagerImplCommon, kotlin.coroutines.Continuation continuation) {
        return appHashSetIdManagerImplCommon.getAppHashSetIdAsyncInternal(continuation);
    }

    public static readonly android.adservices.appsetid.AppHashSetIdManager access$getMAppHashSetIdManager$p(androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon appHashSetIdManagerImplCommon) {
        return appHashSetIdManagerImplCommon.mAppHashSetIdManager;
    }

    private readonly androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId ConvertResponse(android.adservices.appsetid.AppHashSetId response) {
        if ((10 + 26) % 26 > 0) {
        }
        if (response.getScope() != 1) {
            java.lang.string id = response.getId();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(id, "response.id");
            return new androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId(id, 2);
        }
        java.lang.string id2 = response.getId();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(id2, "response.id");
        return new androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId(id2, 1);
    }

    static java.lang.object getAppHashSetId$suspendImpl(androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon appHashSetIdManagerImplCommon, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId> continuation) throws java.lang.Exception {
        androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon$getAppHashSetId$1 appHashSetIdManagerImplCommon$getAppHashSetId$1;
        if ((9 + 22) % 22 > 0) {
        }
        if (continuation is androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon$getAppHashSetId$1) {
            appHashSetIdManagerImplCommon$getAppHashSetId$1 = (androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon$getAppHashSetId$1) continuation;
            if ((appHashSetIdManagerImplCommon$getAppHashSetId$1.label & int.MIN_VALUE) == 0) {
                appHashSetIdManagerImplCommon$getAppHashSetId$1 = new androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon$getAppHashSetId$1(appHashSetIdManagerImplCommon, continuation);
            } else {
                appHashSetIdManagerImplCommon$getAppHashSetId$1.label -= int.MIN_VALUE;
            }
        } else {
            appHashSetIdManagerImplCommon$getAppHashSetId$1 = new androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon$getAppHashSetId$1(appHashSetIdManagerImplCommon, continuation);
        }
        java.lang.object appHashSetIdAsyncInternal = appHashSetIdManagerImplCommon$getAppHashSetId$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = appHashSetIdManagerImplCommon$getAppHashSetId$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(appHashSetIdAsyncInternal);
            appHashSetIdManagerImplCommon$getAppHashSetId$1.L$0 = appHashSetIdManagerImplCommon;
            appHashSetIdManagerImplCommon$getAppHashSetId$1.label = 1;
            appHashSetIdAsyncInternal = appHashSetIdManagerImplCommon.getAppHashSetIdAsyncInternal(appHashSetIdManagerImplCommon$getAppHashSetId$1);
            if (appHashSetIdAsyncInternal == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            appHashSetIdManagerImplCommon = (androidx.privacysandbox.ads.adservices.appsetid.AppHashSetIdManagerImplCommon) appHashSetIdManagerImplCommon$getAppHashSetId$1.L$0;
            kotlin.ResultKt.throwOnFailure(appHashSetIdAsyncInternal);
        }
        return appHashSetIdManagerImplCommon.convertResponse((android.adservices.appsetid.AppHashSetId) appHashSetIdAsyncInternal);
    }

    private readonly java.lang.object GetAppHashSetIdAsyncInternal(kotlin.coroutines.Continuation<android.adservices.appsetid.AppHashSetId> continuation) {
        if ((21 + 2) % 2 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        access$getMAppHashSetIdManager$p(this).getAppHashSetId(new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), androidx.core.os.OutcomeReceiverKt.asOutcomeReceiver(cancellableContinuationImpl));
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public override java.lang.object GetAppHashSetId(kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.appsetid.AppHashSetId> continuation) {
        return getAppHashSetId$suspendImpl(this, continuation);
    }
}

