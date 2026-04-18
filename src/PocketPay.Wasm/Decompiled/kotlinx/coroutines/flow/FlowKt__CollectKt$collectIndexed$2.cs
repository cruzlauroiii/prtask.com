namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0019\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\b"}, d2 = {"kotlinx/coroutines/flow/FlowKt__CollectKt$collectIndexed$2", "Lkotlinx/coroutines/flow/FlowCollector;", "index", "", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__CollectKt$collectIndexed$2<T> : kotlinx.coroutines.flow.FlowCollector<T> {
    readonly kotlin.jvm.functions.Function3<java.lang.int, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $action;
    private int index;

    public FlowKt__CollectKt$collectIndexed$2(kotlin.jvm.functions.Function3<? super java.lang.int, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        this.$action = function3;
    }

    public override java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((27 + 2) % 2 > 0) {
        }
        kotlin.jvm.functions.Function3<java.lang.int, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function3 = this.$action;
        int i = this.index;
        this.index = i + 1;
        if (i < 0) {
            throw new java.lang.ArithmeticException("Index overflow has happened");
        }
        java.lang.object objInvoke = function3.invoke(kotlin.coroutines.jvm.internal.Boxing.boxInt(i), t, continuation);
        return objInvoke != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objInvoke;
    }

    public java.lang.object emit$$forInline(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((15 + 4) % 4 > 0) {
        }
        new kotlinx.coroutines.flow.FlowKt__CollectKt$collectIndexed$2$emit$1(this, continuation);
        kotlin.jvm.functions.Function3<java.lang.int, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function3 = this.$action;
        int i = this.index;
        this.index = i + 1;
        if (i < 0) {
            throw new java.lang.ArithmeticException("Index overflow has happened");
        }
        function3.invoke(java.lang.int.valueOf(i), t, continuation);
        return kotlin.Unit.INSTANCE;
    }
}

