namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "Landroidx/privacysandbox/ads/adservices/adselection/AdSelectionOutcome;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2", m533f = "AdSelectionManagerTasks.kt", m534i = {}, m535l = {317}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome>, java.lang.object> {
    readonly androidx.privacysandbox.ads.adservices.adselection.AdSelectionFromOutcomesConfig $adSelectionFromOutcomesConfig;
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl this$0;

    AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2(androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl adSelectionManagerTasks$Api33Ext4JavaImpl, androidx.privacysandbox.ads.adservices.adselection.AdSelectionFromOutcomesConfig adSelectionFromOutcomesConfig, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2> continuation) {
        super(2, continuation);
        this.this$0 = adSelectionManagerTasks$Api33Ext4JavaImpl;
        this.$adSelectionFromOutcomesConfig = adSelectionFromOutcomesConfig;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2(this.this$0, this.$adSelectionFromOutcomesConfig, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.adselection.AdSelectionOutcome> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 13) % 13 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager adSelectionManagerAccess$getMAdSelectionManager$p = androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl.access$getMAdSelectionManager$p(this.this$0);
        kotlin.jvm.internal.Intrinsics.checkNotNull(adSelectionManagerAccess$getMAdSelectionManager$p);
        androidx.privacysandbox.ads.adservices.adselection.AdSelectionFromOutcomesConfig adSelectionFromOutcomesConfig = this.$adSelectionFromOutcomesConfig;
        androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2 adSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2 = this;
        this.label = 1;
        java.lang.object objSelectAds = adSelectionManagerAccess$getMAdSelectionManager$p.selectAds(adSelectionFromOutcomesConfig, adSelectionManagerTasks$Api33Ext4JavaImpl$selectAdsAsync$2);
        return objSelectAds != coroutine_suspended ? objSelectAds : coroutine_suspended;
    }
}

