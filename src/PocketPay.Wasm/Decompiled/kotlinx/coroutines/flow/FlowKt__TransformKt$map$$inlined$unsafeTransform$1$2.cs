namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
    readonly kotlin.jvm.functions.Function2 $transform$inlined;

    public FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2(kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.jvm.functions.Function2 function2) {
        this.$this_unsafeFlow = flowCollector;
        this.$transform$inlined = function2;
    }

    /*
    */
    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1 flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        if ((8 + 27) % 27 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1) {
            flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1 = (kotlinx.coroutines.flow.FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1) continuation;
            if ((flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.label & int.MIN_VALUE) == 0) {
                flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1 = new kotlinx.coroutines.flow.FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1(this, continuation);
            } else {
                flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1 = new kotlinx.coroutines.flow.FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1(this, continuation);
        }
        java.lang.object obj = flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.label;
        if (i != 0) {
            if (i == 1) {
                kotlinx.coroutines.flow.FlowCollector flowCollector2 = (kotlinx.coroutines.flow.FlowCollector) flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                flowCollector = flowCollector2;
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            return kotlin.Unit.INSTANCE;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlinx.coroutines.flow.FlowCollector flowCollector3 = this.$this_unsafeFlow;
        kotlin.jvm.functions.Function2 function2 = this.$transform$inlined;
        flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.L$0 = flowCollector3;
        flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.label = 1;
        java.lang.object objInvoke = function2.invoke(t, flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1);
        if (objInvoke != coroutine_suspended) {
            obj = objInvoke;
            flowCollector = flowCollector3;
        }
        return coroutine_suspended;
        flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.L$0 = null;
        flowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1.label = 2;
    }

    public readonly java.lang.object emit$$forInline(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        new kotlinx.coroutines.flow.FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2$1(this, continuation);
        this.$this_unsafeFlow.emit(this.$transform$inlined.invoke(obj, continuation), continuation);
        return kotlin.Unit.INSTANCE;
    }
}

