namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00040\u00060\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Landroidx/paging/SimpleProducerScope;", "Landroidx/paging/PagingData;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$flow$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {136}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PageFetcher$flow$1<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<androidx.paging.PagingData<Value>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.RemoteMediator<Key, Value> $remoteMediator;
    private java.lang.object L$0;
    int label;
    readonly androidx.paging.PageFetcher<Key, Value> this$0;

    PageFetcher$flow$1(androidx.paging.RemoteMediator<Key, Value> remoteMediator, androidx.paging.PageFetcher<Key, Value> pageFetcher, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$flow$1> continuation) {
        super(2, continuation);
        this.$remoteMediator = remoteMediator;
        this.this$0 = pageFetcher;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((14 + 12) % 12 > 0) {
        }
        androidx.paging.PageFetcher$flow$1 pageFetcher$flow$1 = new androidx.paging.PageFetcher$flow$1(this.$remoteMediator, this.this$0, continuation);
        pageFetcher$flow$1.L$0 = obj;
        return pageFetcher$flow$1;
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<androidx.paging.PagingData<Value>> simpleProducerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcher$flow$1) create(simpleProducerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.SimpleProducerScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 11) % 11 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SimpleProducerScope simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
            androidx.paging.RemoteMediator<Key, Value> remoteMediator = this.$remoteMediator;
            androidx.paging.RemoteMediatorAccessor RemoteMediatorAccessor = remoteMediator == 0 ? null : androidx.paging.RemoteMediatorAccessorKt.RemoteMediatorAccessor(simpleProducerScope, remoteMediator);
            kotlinx.coroutines.flow.Flow flowSimpleTransformLatest = androidx.paging.FlowExtKt.simpleTransformLatest(kotlinx.coroutines.flow.FlowKt.filterNotNull(androidx.paging.FlowExtKt.simpleScan(kotlinx.coroutines.flow.FlowKt.onStart(androidx.paging.PageFetcher.access$getRefreshEvents$p(this.this$0).getFlow(), new androidx.paging.PageFetcher$flow$1$1(RemoteMediatorAccessor, null)), null, new androidx.paging.PageFetcher$flow$1$2(RemoteMediatorAccessor, this.this$0, null))), new androidx.paging.PageFetcher$flow$1$invokeSuspend$$inlined$simpleDictionaryLatest$1(null, this.this$0, RemoteMediatorAccessor));
            androidx.paging.PageFetcher$flow$1$4 pageFetcher$flow$1$4 = new androidx.paging.PageFetcher$flow$1$4(simpleProducerScope);
            androidx.paging.PageFetcher$flow$1<Value> pageFetcher$flow$1 = this;
            this.label = 1;
            if (flowSimpleTransformLatest.collect(pageFetcher$flow$1$4, pageFetcher$flow$1) == coroutine_suspended) {
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

