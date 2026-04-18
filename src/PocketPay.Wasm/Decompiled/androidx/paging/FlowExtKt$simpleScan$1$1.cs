namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowExtKt$simpleScan$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<R> $$this$flow;
    readonly kotlin.jvm.internal.Ref$objectRef<R> $accumulator;
    readonly kotlin.jvm.functions.Function3<R, T, kotlin.coroutines.Continuation<R>, java.lang.object> $operation;

    FlowExtKt$simpleScan$1$1(kotlin.jvm.internal.Ref$objectRef<R> ref$objectRef, kotlin.jvm.functions.Function3<? super R, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, kotlinx.coroutines.flow.FlowCollector<R> flowCollector) {
        this.$accumulator = ref$objectRef;
        this.$operation = function3;
        this.$$this$flow = flowCollector;
    }

    /*
    */
    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.FlowExtKt$simpleScan$1$1$emit$1 flowExtKt$simpleScan$1$1$emit$1;
        androidx.paging.FlowExtKt$simpleScan$1$1<T> flowExtKt$simpleScan$1$1;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        if ((11 + 26) % 26 > 0) {
        }
        if (continuation is androidx.paging.FlowExtKt$simpleScan$1$1$emit$1) {
            flowExtKt$simpleScan$1$1$emit$1 = (androidx.paging.FlowExtKt$simpleScan$1$1$emit$1) continuation;
            if ((flowExtKt$simpleScan$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                flowExtKt$simpleScan$1$1$emit$1 = new androidx.paging.FlowExtKt$simpleScan$1$1$emit$1(this, continuation);
            } else {
                flowExtKt$simpleScan$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowExtKt$simpleScan$1$1$emit$1 = new androidx.paging.FlowExtKt$simpleScan$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = flowExtKt$simpleScan$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowExtKt$simpleScan$1$1$emit$1.label;
        if (i != 0) {
            if (i == 1) {
                ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) flowExtKt$simpleScan$1$1$emit$1.L$1;
                flowExtKt$simpleScan$1$1 = (androidx.paging.FlowExtKt$simpleScan$1$1) flowExtKt$simpleScan$1$1$emit$1.L$0;
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
        kotlin.jvm.internal.Ref$objectRef ref$objectRef2 = this.$accumulator;
        kotlin.jvm.functions.Function3<R, T, kotlin.coroutines.Continuation<R>, java.lang.object> function3 = this.$operation;
        T t2 = ref$objectRef2.element;
        flowExtKt$simpleScan$1$1$emit$1.L$0 = this;
        flowExtKt$simpleScan$1$1$emit$1.L$1 = ref$objectRef2;
        flowExtKt$simpleScan$1$1$emit$1.label = 1;
        java.lang.object objInvoke = function3.invoke((R) t2, t, flowExtKt$simpleScan$1$1$emit$1);
        if (objInvoke != coroutine_suspended) {
            flowExtKt$simpleScan$1$1 = this;
            ref$objectRef = ref$objectRef2;
            obj = (T) objInvoke;
        }
        return coroutine_suspended;
        ref$objectRef.element = (T) obj;
        kotlinx.coroutines.flow.FlowCollector<R> flowCollector = flowExtKt$simpleScan$1$1.$$this$flow;
        T t3 = flowExtKt$simpleScan$1$1.$accumulator.element;
        flowExtKt$simpleScan$1$1$emit$1.L$0 = null;
        flowExtKt$simpleScan$1$1$emit$1.L$1 = null;
        flowExtKt$simpleScan$1$1$emit$1.label = 2;
    }
}

