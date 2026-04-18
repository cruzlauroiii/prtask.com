namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\b\u0012\u0004\u0012\u00020\u00060\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/flow/FlowCollector;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshotState$consumeAppendGenerationIdAsFlow$1", m533f = "PageFetcherSnapshotState.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PageFetcherSnapshotState$consumeAppendGenerationIdAsFlow$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<java.lang.int>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.paging.PageFetcherSnapshotState<Key, Value> this$0;

    PageFetcherSnapshotState$consumeAppendGenerationIdAsFlow$1(androidx.paging.PageFetcherSnapshotState<Key, Value> pageFetcherSnapshotState, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcherSnapshotState$consumeAppendGenerationIdAsFlow$1> continuation) {
        super(2, continuation);
        this.this$0 = pageFetcherSnapshotState;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.PageFetcherSnapshotState$consumeAppendGenerationIdAsFlow$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<java.lang.int> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(flowCollector, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<java.lang.int> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcherSnapshotState$consumeAppendGenerationIdAsFlow$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.PageFetcherSnapshotState.access$getAppendGenerationIdCh$p(this.this$0).mo708trySendJP2dKIU(kotlin.coroutines.jvm.internal.Boxing.boxInt(androidx.paging.PageFetcherSnapshotState.access$getAppendGenerationId$p(this.this$0)));
        return kotlin.Unit.INSTANCE;
    }
}

