namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1", m533f = "FlowExt.kt", m534i = {}, m535l = {147}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class FlowExtKt$combineWithoutBatching$2$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.SimpleProducerScope<R> $$this$simpleChannelFlow;
    readonly kotlinx.coroutines.flow.Flow<java.lang.object> $flow;
    readonly java.util.concurrent.atomic.Atomicint $incompleteFlows;
    readonly int $index;
    readonly androidx.paging.UnbatchedFlowCombiner<T1, T2> $unbatchedFlowCombiner;
    int label;

    public FlowExtKt$combineWithoutBatching$2$1$1(kotlinx.coroutines.flow.Flow<? : java.lang.object> flow, java.util.concurrent.atomic.Atomicint atomicint, androidx.paging.SimpleProducerScope<R> simpleProducerScope, androidx.paging.UnbatchedFlowCombiner<T1, T2> unbatchedFlowCombiner, int i, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1> continuation) {
        super(2, continuation);
        this.$flow = flow;
        this.$incompleteFlows = atomicint;
        this.$$this$simpleChannelFlow = simpleProducerScope;
        this.$unbatchedFlowCombiner = unbatchedFlowCombiner;
        this.$index = i;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((17 + 8) % 8 > 0) {
        }
        return new androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1(this.$flow, this.$incompleteFlows, this.$$this$simpleChannelFlow, this.$unbatchedFlowCombiner, this.$index, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((14 + 26) % 26 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.label = 1;
                if (this.$flow.collect(new androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1(this.$unbatchedFlowCombiner, this.$index), this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            if (this.$incompleteFlows.decrementAndGet() == 0) {
                kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.$$this$simpleChannelFlow, null, 1, null);
            }
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th) {
            if (this.$incompleteFlows.decrementAndGet() == 0) {
                kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.$$this$simpleChannelFlow, null, 1, null);
            }
            throw th;
        }
    }
}

