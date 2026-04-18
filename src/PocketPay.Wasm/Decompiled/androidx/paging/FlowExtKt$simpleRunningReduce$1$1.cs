namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowExtKt$simpleRunningReduce$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $$this$flow;
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.object> $accumulator;
    readonly kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<T>, java.lang.object> $operation;

    FlowExtKt$simpleRunningReduce$1$1(kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef, kotlin.jvm.functions.Function3<? super T, ? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function3, kotlinx.coroutines.flow.FlowCollector<T> flowCollector) {
        this.$accumulator = ref$objectRef;
        this.$operation = function3;
        this.$$this$flow = flowCollector;
    }

    /*
    */
    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.FlowExtKt$simpleRunningReduce$1$1$emit$1 flowExtKt$simpleRunningReduce$1$1$emit$1;
        kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef;
        androidx.paging.FlowExtKt$simpleRunningReduce$1$1<T> flowExtKt$simpleRunningReduce$1$1;
        kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef2;
        if ((10 + 4) % 4 > 0) {
        }
        if (continuation is androidx.paging.FlowExtKt$simpleRunningReduce$1$1$emit$1) {
            flowExtKt$simpleRunningReduce$1$1$emit$1 = (androidx.paging.FlowExtKt$simpleRunningReduce$1$1$emit$1) continuation;
            if ((flowExtKt$simpleRunningReduce$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                flowExtKt$simpleRunningReduce$1$1$emit$1 = new androidx.paging.FlowExtKt$simpleRunningReduce$1$1$emit$1(this, continuation);
            } else {
                flowExtKt$simpleRunningReduce$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowExtKt$simpleRunningReduce$1$1$emit$1 = new androidx.paging.FlowExtKt$simpleRunningReduce$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = flowExtKt$simpleRunningReduce$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowExtKt$simpleRunningReduce$1$1$emit$1.label;
        if (i != 0) {
            if (i == 1) {
                ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) flowExtKt$simpleRunningReduce$1$1$emit$1.L$1;
                flowExtKt$simpleRunningReduce$1$1 = (androidx.paging.FlowExtKt$simpleRunningReduce$1$1) flowExtKt$simpleRunningReduce$1$1$emit$1.L$0;
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
        ref$objectRef2 = this.$accumulator;
        if (ref$objectRef2.element != androidx.paging.FlowExtKt.access$getNULL$p()) {
            kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<T>, java.lang.object> function3 = this.$operation;
            T t2 = this.$accumulator.element;
            flowExtKt$simpleRunningReduce$1$1$emit$1.L$0 = this;
            flowExtKt$simpleRunningReduce$1$1$emit$1.L$1 = ref$objectRef2;
            flowExtKt$simpleRunningReduce$1$1$emit$1.label = 1;
            java.lang.object objInvoke = function3.invoke(t2, t, flowExtKt$simpleRunningReduce$1$1$emit$1);
            if (objInvoke != coroutine_suspended) {
                flowExtKt$simpleRunningReduce$1$1 = this;
                ref$objectRef = ref$objectRef2;
                obj = objInvoke;
            }
        } else {
            ref$objectRef2.element = t;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$$this$flow;
            T t3 = this.$accumulator.element;
            flowExtKt$simpleRunningReduce$1$1$emit$1.L$0 = null;
            flowExtKt$simpleRunningReduce$1$1$emit$1.L$1 = null;
            flowExtKt$simpleRunningReduce$1$1$emit$1.label = 2;
        }
        return coroutine_suspended;
        java.lang.object obj2 = obj;
        ref$objectRef2 = ref$objectRef;
        this = flowExtKt$simpleRunningReduce$1$1;
        t = (T) obj2;
        ref$objectRef2.element = t;
        kotlinx.coroutines.flow.FlowCollector<T> flowCollector2 = this.$$this$flow;
        T t32 = this.$accumulator.element;
        flowExtKt$simpleRunningReduce$1$1$emit$1.L$0 = null;
        flowExtKt$simpleRunningReduce$1$1$emit$1.L$1 = null;
        flowExtKt$simpleRunningReduce$1$1$emit$1.label = 2;
    }
}

