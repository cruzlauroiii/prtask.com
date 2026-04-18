namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1<T> : kotlinx.coroutines.flow.Flow<T> {
    readonly kotlin.jvm.functions.Function3 $action$inlined;
    readonly kotlinx.coroutines.flow.Flow $this_onCompletion$inlined;

    public FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1(kotlinx.coroutines.flow.Flow flow, kotlin.jvm.functions.Function3 function3) {
        this.$this_onCompletion$inlined = flow;
        this.$action$inlined = function3;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1 flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1;
        java.lang.Exception th;
        kotlinx.coroutines.flow.internal.SafeCollector safeCollector;
        kotlinx.coroutines.flow.internal.SafeCollector safeCollector2;
        if ((16 + 29) % 29 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1) {
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1 = (kotlinx.coroutines.flow.FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1) continuation;
            if ((flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.label & int.MIN_VALUE) == 0) {
                flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1 = new kotlinx.coroutines.flow.FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1(this, continuation);
            } else {
                flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1 = new kotlinx.coroutines.flow.FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1(this, continuation);
        }
        java.lang.object obj = flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.label;
        try {
            safeCollector2 = new kotlinx.coroutines.flow.internal.SafeCollector(flowCollector, flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.getobject());
        } catch (java.lang.Exception th2) {
            kotlinx.coroutines.flow.FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1<T> flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1 = this;
            kotlinx.coroutines.flow.ThrowingCollector throwingCollector = new kotlinx.coroutines.flow.ThrowingCollector(th2);
            kotlin.jvm.functions.Function3 function3 = flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1.$action$inlined;
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$0 = th2;
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$1 = null;
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.label = 2;
            if (kotlinx.coroutines.flow.FlowKt__EmittersKt.access$invokeSafely$FlowKt__EmittersKt(throwingCollector, function3, th2, flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1) != coroutine_suspended) {
                throw th2;
            }
        }
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlinx.coroutines.flow.Flow flow = this.$this_onCompletion$inlined;
                flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$0 = this;
                flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$1 = flowCollector;
                flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.label = 1;
                if (flow.collect(flowCollector, flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1) != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            if (i != 1) {
                if (i == 2) {
                    java.lang.Exception th3 = (java.lang.Exception) flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$0;
                    kotlin.ResultKt.throwOnFailure(obj);
                    throw th3;
                }
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                safeCollector = (kotlinx.coroutines.flow.internal.SafeCollector) flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$0;
                try {
                    kotlin.ResultKt.throwOnFailure(obj);
                    safeCollector.releaseIntercepted();
                    return kotlin.Unit.INSTANCE;
                } catch (java.lang.Exception th4) {
                    th = th4;
                    safeCollector.releaseIntercepted();
                    throw th;
                }
            }
            flowCollector = (kotlinx.coroutines.flow.FlowCollector) flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$1;
            this = (kotlinx.coroutines.flow.FlowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1) flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.jvm.functions.Function3 function32 = this.$action$inlined;
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$0 = safeCollector2;
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.L$1 = null;
            flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1.label = 3;
            if (function32.invoke(safeCollector2, null, flowKt__EmittersKt$onCompletion$$inlined$unsafeFlow$1$1) != coroutine_suspended) {
                safeCollector = safeCollector2;
                safeCollector.releaseIntercepted();
                return kotlin.Unit.INSTANCE;
            }
            return coroutine_suspended;
        } catch (java.lang.Exception th5) {
            th = th5;
            safeCollector = safeCollector2;
            safeCollector.releaseIntercepted();
            throw th;
        }
    }
}

