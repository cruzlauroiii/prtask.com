namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl$reportImpressionAsync$1", m533f = "AdSelectionManagerTasks.kt", m534i = {}, m535l = {327}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0171x3453cbdf : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest $reportImpressionRequest;
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl this$0;

    C0171x3453cbdf(androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl adSelectionManagerTasks$Api33Ext4JavaImpl, androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest reportImpressionRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.adselection.C0171x3453cbdf> continuation) {
        super(2, continuation);
        this.this$0 = adSelectionManagerTasks$Api33Ext4JavaImpl;
        this.$reportImpressionRequest = reportImpressionRequest;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.privacysandbox.ads.adservices.java.adselection.C0171x3453cbdf(this.this$0, this.$reportImpressionRequest, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.adselection.C0171x3453cbdf) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 13) % 13 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager adSelectionManagerAccess$getMAdSelectionManager$p = androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl.access$getMAdSelectionManager$p(this.this$0);
            kotlin.jvm.internal.Intrinsics.checkNotNull(adSelectionManagerAccess$getMAdSelectionManager$p);
            androidx.privacysandbox.ads.adservices.adselection.ReportImpressionRequest reportImpressionRequest = this.$reportImpressionRequest;
            androidx.privacysandbox.ads.adservices.java.adselection.C0171x3453cbdf c0171x3453cbdf = this;
            this.label = 1;
            if (adSelectionManagerAccess$getMAdSelectionManager$p.reportImpression(reportImpressionRequest, c0171x3453cbdf) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

