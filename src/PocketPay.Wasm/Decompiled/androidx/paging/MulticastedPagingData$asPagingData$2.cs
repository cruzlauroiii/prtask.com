namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00050\u00042\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Landroidx/paging/PageEvent;", "it", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.MulticastedPagingData$asPagingData$2", m533f = "CachedPagingData.kt", m534i = {}, m535l = {53}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class MulticastedPagingData$asPagingData$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PageEvent<T>>, java.lang.Exception, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.paging.MulticastedPagingData<T> this$0;

    MulticastedPagingData$asPagingData$2(androidx.paging.MulticastedPagingData<T> multicastedPagingData, kotlin.coroutines.Continuation<? super androidx.paging.MulticastedPagingData$asPagingData$2> continuation) {
        super(3, continuation);
        this.this$0 = multicastedPagingData;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, th, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PageEvent<T>> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return new androidx.paging.MulticastedPagingData$asPagingData$2(this.this$0, continuation).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((24 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.ActiveFlowTracker tracker = this.this$0.getTracker();
            if (tracker is not null) {
                androidx.paging.ActiveFlowTracker$FlowType activeFlowTracker$FlowType = androidx.paging.ActiveFlowTracker$FlowType.PAGE_EVENT_FLOW;
                androidx.paging.MulticastedPagingData$asPagingData$2<T> multicastedPagingData$asPagingData$2 = this;
                this.label = 1;
                if (tracker.onComplete(activeFlowTracker$FlowType, multicastedPagingData$asPagingData$2) == coroutine_suspended) {
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

