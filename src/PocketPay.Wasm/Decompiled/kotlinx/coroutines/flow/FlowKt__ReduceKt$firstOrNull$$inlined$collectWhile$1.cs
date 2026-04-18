namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0019\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0005\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0006¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/FlowKt__LimitKt$collectWhile$collector$1", "Lkotlinx/coroutines/flow/FlowCollector;", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__ReduceKt$firstOrNull$$inlined$collectWhile$1<T> : kotlinx.coroutines.flow.FlowCollector<T> {
    readonly kotlin.jvm.internal.Ref$objectRef $result$inlined;

    public FlowKt__ReduceKt$firstOrNull$$inlined$collectWhile$1(kotlin.jvm.internal.Ref$objectRef ref$objectRef) {
        this.$result$inlined = ref$objectRef;
    }

    public override java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.$result$inlined.element = t;
        throw new kotlinx.coroutines.flow.internal.AbortFlowException(this);
    }
}

