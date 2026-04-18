namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPageEventFlow$job$1", m533f = "CachedPageEventFlow.kt", m534i = {}, m535l = {76}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CachedPageEventFlow$job$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<T>> $src;
    int label;
    readonly androidx.paging.CachedPageEventFlow<T> this$0;

    CachedPageEventFlow$job$1(kotlinx.coroutines.flow.Flow<? : androidx.paging.PageEvent<T>> flow, androidx.paging.CachedPageEventFlow<T> cachedPageEventFlow, kotlin.coroutines.Continuation<? super androidx.paging.CachedPageEventFlow$job$1> continuation) {
        super(2, continuation);
        this.$src = flow;
        this.this$0 = cachedPageEventFlow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.CachedPageEventFlow$job$1(this.$src, this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.CachedPageEventFlow$job$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 26) % 26 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow flowWithIndex = kotlinx.coroutines.flow.FlowKt.withIndex(this.$src);
            androidx.paging.CachedPageEventFlow$job$1$1 cachedPageEventFlow$job$1$1 = new androidx.paging.CachedPageEventFlow$job$1$1(this.this$0);
            androidx.paging.CachedPageEventFlow$job$1 cachedPageEventFlow$job$1 = this;
            this.label = 1;
            if (flowWithIndex.collect(cachedPageEventFlow$job$1$1, cachedPageEventFlow$job$1) == coroutine_suspended) {
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

