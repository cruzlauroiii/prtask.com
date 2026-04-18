namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "androidx/paging/FlowExtKt$simpleDictionaryLatest$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {105}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class PageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1<Key, Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<Value>>, androidx.paging.PageFetcher$GenerationInfo<Key, Value>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.RemoteMediatorAccessor $remoteMediatorAccessor$inlined;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;
    readonly androidx.paging.PageFetcher this$0;

    public PageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1(kotlin.coroutines.Continuation continuation, androidx.paging.PageFetcher pageFetcher, androidx.paging.RemoteMediatorAccessor remoteMediatorAccessor) {
        super(3, continuation);
        this.this$0 = pageFetcher;
        this.$remoteMediatorAccessor$inlined = remoteMediatorAccessor;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, obj2, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<Value>> flowCollector, androidx.paging.PageFetcher$GenerationInfo<Key, Value> pageFetcher$GenerationInfo, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((28 + 21) % 21 > 0) {
        }
        androidx.paging.PageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1 pageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1 = new androidx.paging.PageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1(continuation, this.this$0, this.$remoteMediatorAccessor$inlined);
        pageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1.L$0 = flowCollector;
        pageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1.L$1 = pageFetcher$GenerationInfo;
        return pageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((5 + 4) % 4 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            androidx.paging.PageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1<Key, Value> pageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1 = this;
            androidx.paging.PageFetcher$GenerationInfo pageFetcher$GenerationInfo = (androidx.paging.PageFetcher$GenerationInfo) this.L$1;
            kotlinx.coroutines.flow.Flow flowOnEach = kotlinx.coroutines.flow.FlowKt.onEach(androidx.paging.PageFetcher.access$injectRemoteEvents(this.this$0, pageFetcher$GenerationInfo.getSnapshot(), pageFetcher$GenerationInfo.getJob(), this.$remoteMediatorAccessor$inlined), new androidx.paging.PageFetcher$flow$1$3$downstreamFlow$1(null));
            androidx.paging.PageFetcher pageFetcher = this.this$0;
            androidx.paging.PagingData pagingData = new androidx.paging.PagingData(flowOnEach, new androidx.paging.PageFetcher$PagerUiReceiver(pageFetcher, androidx.paging.PageFetcher.access$getRetryEvents$p(pageFetcher)), new androidx.paging.PageFetcher$PagerHintReceiver(this.this$0, pageFetcher$GenerationInfo.getSnapshot()), null, 8, null);
            this.label = 1;
            if (flowCollector.emit(pagingData, pageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1) == coroutine_suspended) {
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

