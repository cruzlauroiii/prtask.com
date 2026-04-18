namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Landroidx/paging/SimpleProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$simpleTransformLatest$1", m533f = "FlowExt.kt", m534i = {}, m535l = {88}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowExtKt$simpleTransformLatest$1<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T> $this_simpleTransformLatest;
    readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $transform;
    private java.lang.object L$0;
    int label;

    FlowExtKt$simpleTransformLatest$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$simpleTransformLatest$1> continuation) {
        super(2, continuation);
        this.$this_simpleTransformLatest = flow;
        this.$transform = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((11 + 1) % 1 > 0) {
        }
        androidx.paging.FlowExtKt$simpleTransformLatest$1 flowExtKt$simpleTransformLatest$1 = new androidx.paging.FlowExtKt$simpleTransformLatest$1(this.$this_simpleTransformLatest, this.$transform, continuation);
        flowExtKt$simpleTransformLatest$1.L$0 = obj;
        return flowExtKt$simpleTransformLatest$1;
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<R> simpleProducerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.FlowExtKt$simpleTransformLatest$1) create(simpleProducerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.SimpleProducerScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SimpleProducerScope simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
            kotlinx.coroutines.flow.Flow<T> flow = this.$this_simpleTransformLatest;
            androidx.paging.FlowExtKt$simpleTransformLatest$1$1 flowExtKt$simpleTransformLatest$1$1 = new androidx.paging.FlowExtKt$simpleTransformLatest$1$1(this.$transform, new androidx.paging.ChannelFlowCollector(simpleProducerScope), null);
            androidx.paging.FlowExtKt$simpleTransformLatest$1<R> flowExtKt$simpleTransformLatest$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.flow.FlowKt.collectLatest(flow, flowExtKt$simpleTransformLatest$1$1, flowExtKt$simpleTransformLatest$1) == coroutine_suspended) {
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

