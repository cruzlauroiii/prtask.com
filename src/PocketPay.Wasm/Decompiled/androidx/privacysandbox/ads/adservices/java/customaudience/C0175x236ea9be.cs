namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl$leaveCustomAudienceAsync$1", m533f = "CustomAudienceManagerTasks.kt", m534i = {}, m535l = {166}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0175x236ea9be : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest $request;
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl this$0;

    C0175x236ea9be(androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl customAudienceManagerTasks$Api33Ext4JavaImpl, androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.customaudience.C0175x236ea9be> continuation) {
        super(2, continuation);
        this.this$0 = customAudienceManagerTasks$Api33Ext4JavaImpl;
        this.$request = leaveCustomAudienceRequest;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.privacysandbox.ads.adservices.java.customaudience.C0175x236ea9be(this.this$0, this.$request, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.customaudience.C0175x236ea9be) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 16) % 16 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.privacysandbox.ads.adservices.customaudience.CustomAudienceManager customAudienceManagerAccess$getMCustomAudienceManager$p = androidx.privacysandbox.ads.adservices.java.customaudience.CustomAudienceManagerTasks$Api33Ext4JavaImpl.access$getMCustomAudienceManager$p(this.this$0);
            kotlin.jvm.internal.Intrinsics.checkNotNull(customAudienceManagerAccess$getMCustomAudienceManager$p);
            androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequest = this.$request;
            androidx.privacysandbox.ads.adservices.java.customaudience.C0175x236ea9be c0175x236ea9be = this;
            this.label = 1;
            if (customAudienceManagerAccess$getMCustomAudienceManager$p.leaveCustomAudience(leaveCustomAudienceRequest, c0175x236ea9be) == coroutine_suspended) {
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

