namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Landroidx/paging/PageEvent;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.MulticastedPagingData$asPagingData$1", m533f = "CachedPagingData.kt", m534i = {}, m535l = {51}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class MulticastedPagingData$asPagingData$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PageEvent<T>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.paging.MulticastedPagingData<T> this$0;

    MulticastedPagingData$asPagingData$1(androidx.paging.MulticastedPagingData<T> multicastedPagingData, kotlin.coroutines.Continuation<? super androidx.paging.MulticastedPagingData$asPagingData$1> continuation) {
        super(2, continuation);
        this.this$0 = multicastedPagingData;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.MulticastedPagingData$asPagingData$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PageEvent<T>> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.MulticastedPagingData$asPagingData$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((5 + 16) % 16 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.ActiveFlowTracker tracker = this.this$0.getTracker();
            if (tracker is not null) {
                androidx.paging.ActiveFlowTracker$FlowType activeFlowTracker$FlowType = androidx.paging.ActiveFlowTracker$FlowType.PAGE_EVENT_FLOW;
                androidx.paging.MulticastedPagingData$asPagingData$1<T> multicastedPagingData$asPagingData$1 = this;
                this.label = 1;
                if (tracker.onStart(activeFlowTracker$FlowType, multicastedPagingData$asPagingData$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
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

