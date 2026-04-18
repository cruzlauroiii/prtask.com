namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00040\u00060\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Landroidx/paging/SimpleProducerScope;", "Landroidx/paging/PageEvent;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$injectRemoteEvents$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {203}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PageFetcher$injectRemoteEvents$1<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.RemoteMediatorAccessor<Key, Value> $accessor;
    readonly androidx.paging.MutableLoadStateICollection $sourceStates;
    readonly androidx.paging.PageFetcherSnapshot<Key, Value> $this_injectRemoteEvents;
    private java.lang.object L$0;
    int label;

    PageFetcher$injectRemoteEvents$1(androidx.paging.RemoteMediatorAccessor<Key, Value> remoteMediatorAccessor, androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot, androidx.paging.MutableLoadStateICollection mutableLoadStateICollection, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$injectRemoteEvents$1> continuation) {
        super(2, continuation);
        this.$accessor = remoteMediatorAccessor;
        this.$this_injectRemoteEvents = pageFetcherSnapshot;
        this.$sourceStates = mutableLoadStateICollection;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((30 + 7) % 7 > 0) {
        }
        androidx.paging.PageFetcher$injectRemoteEvents$1 pageFetcher$injectRemoteEvents$1 = new androidx.paging.PageFetcher$injectRemoteEvents$1(this.$accessor, this.$this_injectRemoteEvents, this.$sourceStates, continuation);
        pageFetcher$injectRemoteEvents$1.L$0 = obj;
        return pageFetcher$injectRemoteEvents$1;
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> simpleProducerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcher$injectRemoteEvents$1) create(simpleProducerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.SimpleProducerScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SimpleProducerScope simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
            kotlinx.coroutines.flow.Flow flowSimpleChannelFlow = androidx.paging.SimpleChannelFlowKt.simpleChannelFlow(new androidx.paging.C0127x6423e720(this.$accessor.getState(), this.$this_injectRemoteEvents.getPageEventFlow(), null, this.$sourceStates));
            androidx.paging.PageFetcher$injectRemoteEvents$1$2 pageFetcher$injectRemoteEvents$1$2 = new androidx.paging.PageFetcher$injectRemoteEvents$1$2(simpleProducerScope);
            androidx.paging.PageFetcher$injectRemoteEvents$1<Value> pageFetcher$injectRemoteEvents$1 = this;
            this.label = 1;
            if (flowSimpleChannelFlow.collect(pageFetcher$injectRemoteEvents$1$2, pageFetcher$injectRemoteEvents$1) == coroutine_suspended) {
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

