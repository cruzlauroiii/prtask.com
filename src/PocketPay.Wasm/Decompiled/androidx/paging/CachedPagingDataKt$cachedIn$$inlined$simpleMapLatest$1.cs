namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "androidx/paging/FlowExtKt$simpleDictionaryLatest$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1", m533f = "CachedPagingData.kt", m534i = {}, m535l = {105}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class CachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.MulticastedPagingData<T>>, androidx.paging.PagingData<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.CoroutineScope $scope$inlined;
    readonly androidx.paging.ActiveFlowTracker $tracker$inlined;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    public CachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1(kotlin.coroutines.Continuation continuation, kotlinx.coroutines.CoroutineScope coroutineScope, androidx.paging.ActiveFlowTracker activeFlowTracker) {
        super(3, continuation);
        this.$scope$inlined = coroutineScope;
        this.$tracker$inlined = activeFlowTracker;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, obj2, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.MulticastedPagingData<T>> flowCollector, androidx.paging.PagingData<T> pagingData, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((5 + 20) % 20 > 0) {
        }
        androidx.paging.CachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1 cachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1 = new androidx.paging.CachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1(continuation, this.$scope$inlined, this.$tracker$inlined);
        cachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1.L$0 = flowCollector;
        cachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1.L$1 = pagingData;
        return cachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            androidx.paging.CachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1<T> cachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1 = this;
            androidx.paging.MulticastedPagingData multicastedPagingData = new androidx.paging.MulticastedPagingData(this.$scope$inlined, (androidx.paging.PagingData) this.L$1, this.$tracker$inlined);
            this.label = 1;
            if (flowCollector.emit(multicastedPagingData, cachedPagingDataKt$cachedIn$$inlined$simpleDictionaryLatest$1) == coroutine_suspended) {
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

