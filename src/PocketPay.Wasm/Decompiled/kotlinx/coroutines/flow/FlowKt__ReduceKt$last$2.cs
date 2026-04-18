namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "it", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__ReduceKt$last$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.object> $result;

    FlowKt__ReduceKt$last$2(kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef) {
        this.$result = ref$objectRef;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.$result.element = t;
        return kotlin.Unit.INSTANCE;
    }
}

