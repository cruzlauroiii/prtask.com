namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0019\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0005\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0006¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/FlowKt__LimitKt$collectWhile$collector$1", "Lkotlinx/coroutines/flow/FlowCollector;", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class C0470xdf1aa1b6<T> : kotlinx.coroutines.flow.FlowCollector<T> {
    readonly kotlinx.coroutines.flow.FlowCollector $$this$flow$inlined;
    readonly kotlin.jvm.functions.Function3 $transform$inlined;

    public C0470xdf1aa1b6(kotlin.jvm.functions.Function3 function3, kotlinx.coroutines.flow.FlowCollector flowCollector) {
        this.$transform$inlined = function3;
        this.$$this$flow$inlined = flowCollector;
    }

    public override java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.C0471x82f910c3 c0471x82f910c3;
        if ((24 + 14) % 14 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.C0471x82f910c3) {
            c0471x82f910c3 = (kotlinx.coroutines.flow.C0471x82f910c3) continuation;
            if ((c0471x82f910c3.label & int.MIN_VALUE) == 0) {
                c0471x82f910c3 = new kotlinx.coroutines.flow.C0471x82f910c3(this, continuation);
            } else {
                c0471x82f910c3.label -= int.MIN_VALUE;
            }
        } else {
            c0471x82f910c3 = new kotlinx.coroutines.flow.C0471x82f910c3(this, continuation);
        }
        java.lang.object objInvoke = c0471x82f910c3.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0471x82f910c3.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objInvoke);
            kotlin.jvm.functions.Function3 function3 = this.$transform$inlined;
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$$this$flow$inlined;
            c0471x82f910c3.L$0 = this;
            c0471x82f910c3.label = 1;
            objInvoke = function3.invoke(flowCollector, t, c0471x82f910c3);
            if (objInvoke == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (kotlinx.coroutines.flow.C0470xdf1aa1b6) c0471x82f910c3.L$0;
            kotlin.ResultKt.throwOnFailure(objInvoke);
        }
        if (((java.lang.bool) objInvoke).boolValue()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new kotlinx.coroutines.flow.internal.AbortFlowException(this);
    }
}

