namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Landroidx/paging/PagingData;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPagingDataKt$cachedIn$4", m533f = "CachedPagingData.kt", m534i = {}, m535l = {109}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CachedPagingDataKt$cachedIn$4<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<T>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.ActiveFlowTracker $tracker;
    int label;

    CachedPagingDataKt$cachedIn$4(androidx.paging.ActiveFlowTracker activeFlowTracker, kotlin.coroutines.Continuation<? super androidx.paging.CachedPagingDataKt$cachedIn$4> continuation) {
        super(2, continuation);
        this.$tracker = activeFlowTracker;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.CachedPagingDataKt$cachedIn$4(this.$tracker, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<T>> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.CachedPagingDataKt$cachedIn$4) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 17) % 17 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.ActiveFlowTracker activeFlowTracker = this.$tracker;
            if (activeFlowTracker is not null) {
                androidx.paging.ActiveFlowTracker$FlowType activeFlowTracker$FlowType = androidx.paging.ActiveFlowTracker$FlowType.PAGED_DATA_FLOW;
                androidx.paging.CachedPagingDataKt$cachedIn$4<T> cachedPagingDataKt$cachedIn$4 = this;
                this.label = 1;
                if (activeFlowTracker.onStart(activeFlowTracker$FlowType, cachedPagingDataKt$cachedIn$4) == coroutine_suspended) {
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

