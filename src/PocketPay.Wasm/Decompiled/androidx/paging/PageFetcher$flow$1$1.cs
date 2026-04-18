namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\b\u0012\u0004\u0012\u00020\u00060\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/flow/FlowCollector;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$flow$1$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {63, 63}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PageFetcher$flow$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<java.lang.bool>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.RemoteMediatorAccessor<Key, Value> $remoteMediatorAccessor;
    private java.lang.object L$0;
    int label;

    PageFetcher$flow$1$1(androidx.paging.RemoteMediatorAccessor<Key, Value> remoteMediatorAccessor, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$flow$1$1> continuation) {
        super(2, continuation);
        this.$remoteMediatorAccessor = remoteMediatorAccessor;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.PageFetcher$flow$1$1 pageFetcher$flow$1$1 = new androidx.paging.PageFetcher$flow$1$1(this.$remoteMediatorAccessor, continuation);
        pageFetcher$flow$1$1.L$0 = obj;
        return pageFetcher$flow$1$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<java.lang.bool> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(flowCollector, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<java.lang.bool> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcher$flow$1$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        androidx.paging.RemoteMediator$InitializeAction remoteMediator$InitializeAction;
        if ((1 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i == 1) {
                flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            return kotlin.Unit.INSTANCE;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
        androidx.paging.RemoteMediatorAccessor<Key, Value> remoteMediatorAccessor = this.$remoteMediatorAccessor;
        if (remoteMediatorAccessor == 0) {
            remoteMediator$InitializeAction = null;
            java.lang.bool boolBoxbool = kotlin.coroutines.jvm.internal.Boxing.boxbool(remoteMediator$InitializeAction == androidx.paging.RemoteMediator$InitializeAction.LAUNCH_INITIAL_REFRESH);
            androidx.paging.PageFetcher$flow$1$1 pageFetcher$flow$1$1 = this;
            this.L$0 = null;
            this.label = 2;
        } else {
            androidx.paging.PageFetcher$flow$1$1 pageFetcher$flow$1$12 = this;
            this.L$0 = flowCollector;
            this.label = 1;
            obj = remoteMediatorAccessor.initialize(pageFetcher$flow$1$12);
        }
        return coroutine_suspended;
        remoteMediator$InitializeAction = (androidx.paging.RemoteMediator$InitializeAction) obj;
        java.lang.bool boolBoxbool2 = kotlin.coroutines.jvm.internal.Boxing.boxbool(remoteMediator$InitializeAction == androidx.paging.RemoteMediator$InitializeAction.LAUNCH_INITIAL_REFRESH);
        androidx.paging.PageFetcher$flow$1$1 pageFetcher$flow$1$13 = this;
        this.L$0 = null;
        this.label = 2;
    }
}

