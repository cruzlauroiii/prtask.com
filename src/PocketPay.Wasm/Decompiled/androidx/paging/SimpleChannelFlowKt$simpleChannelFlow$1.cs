namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1", m533f = "SimpleChannelFlow.kt", m534i = {}, m535l = {49}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SimpleChannelFlowKt$simpleChannelFlow$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    private java.lang.object L$0;
    int label;

    SimpleChannelFlowKt$simpleChannelFlow$1(kotlin.jvm.functions.Function2<? super androidx.paging.SimpleProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1> continuation) {
        super(2, continuation);
        this.$block = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1 simpleChannelFlowKt$simpleChannelFlow$1 = new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1(this.$block, continuation);
        simpleChannelFlowKt$simpleChannelFlow$1.L$0 = obj;
        return simpleChannelFlowKt$simpleChannelFlow$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((20 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1 simpleChannelFlowKt$simpleChannelFlow$1$1 = new androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1$1((kotlinx.coroutines.flow.FlowCollector) this.L$0, this.$block, null);
            androidx.paging.SimpleChannelFlowKt$simpleChannelFlow$1<T> simpleChannelFlowKt$simpleChannelFlow$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.CoroutineScopeKt.coroutineScope(simpleChannelFlowKt$simpleChannelFlow$1$1, simpleChannelFlowKt$simpleChannelFlow$1) == coroutine_suspended) {
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

