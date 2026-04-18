namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Landroidx/paging/PageEvent;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPageEventFlow$downstreamFlow$1", m533f = "CachedPageEventFlow.kt", m534i = {}, m535l = {102}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CachedPageEventFlow$downstreamFlow$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PageEvent<T>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    int label;
    readonly androidx.paging.CachedPageEventFlow<T> this$0;

    CachedPageEventFlow$downstreamFlow$1(androidx.paging.CachedPageEventFlow<T> cachedPageEventFlow, kotlin.coroutines.Continuation<? super androidx.paging.CachedPageEventFlow$downstreamFlow$1> continuation) {
        super(2, continuation);
        this.this$0 = cachedPageEventFlow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.CachedPageEventFlow$downstreamFlow$1 cachedPageEventFlow$downstreamFlow$1 = new androidx.paging.CachedPageEventFlow$downstreamFlow$1(this.this$0, continuation);
        cachedPageEventFlow$downstreamFlow$1.L$0 = obj;
        return cachedPageEventFlow$downstreamFlow$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PageEvent<T>> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.CachedPageEventFlow$downstreamFlow$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((17 + 17) % 17 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlin.jvm.internal.Ref$IntRef ref$IntRef = new kotlin.jvm.internal.Ref$IntRef();
            ref$IntRef.element = int.MIN_VALUE;
            kotlinx.coroutines.flow.Flow flowTakeWhile = kotlinx.coroutines.flow.FlowKt.takeWhile(androidx.paging.CachedPageEventFlow.access$getSharedForDownstream$p(this.this$0), new androidx.paging.CachedPageEventFlow$downstreamFlow$1$1(null));
            androidx.paging.CachedPageEventFlow$downstreamFlow$1$2 cachedPageEventFlow$downstreamFlow$1$2 = new androidx.paging.CachedPageEventFlow$downstreamFlow$1$2(ref$IntRef, flowCollector);
            androidx.paging.CachedPageEventFlow$downstreamFlow$1<T> cachedPageEventFlow$downstreamFlow$1 = this;
            this.label = 1;
            if (flowTakeWhile.collect(cachedPageEventFlow$downstreamFlow$1$2, cachedPageEventFlow$downstreamFlow$1) == coroutine_suspended) {
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

