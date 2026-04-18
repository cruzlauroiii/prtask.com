namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class C0148x894934f3<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
    readonly kotlin.jvm.functions.Function2 $transform$inlined$1;

    public C0148x894934f3(kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.jvm.functions.Function2 function2) {
        this.$this_unsafeFlow = flowCollector;
        this.$transform$inlined$1 = function2;
    }

    /*
    */
    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        androidx.paging.C0149x5bcfc8c0 c0149x5bcfc8c0;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        if ((21 + 22) % 22 > 0) {
        }
        if (continuation is androidx.paging.C0149x5bcfc8c0) {
            c0149x5bcfc8c0 = (androidx.paging.C0149x5bcfc8c0) continuation;
            if ((c0149x5bcfc8c0.label & int.MIN_VALUE) == 0) {
                c0149x5bcfc8c0 = new androidx.paging.C0149x5bcfc8c0(this, continuation);
            } else {
                c0149x5bcfc8c0.label -= int.MIN_VALUE;
            }
        } else {
            c0149x5bcfc8c0 = new androidx.paging.C0149x5bcfc8c0(this, continuation);
        }
        java.lang.object obj2 = c0149x5bcfc8c0.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0149x5bcfc8c0.label;
        if (i != 0) {
            if (i == 1) {
                kotlinx.coroutines.flow.FlowCollector flowCollector2 = (kotlinx.coroutines.flow.FlowCollector) c0149x5bcfc8c0.L$0;
                kotlin.ResultKt.throwOnFailure(obj2);
                flowCollector = flowCollector2;
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj2);
            }
            return kotlin.Unit.INSTANCE;
        }
        kotlin.ResultKt.throwOnFailure(obj2);
        kotlinx.coroutines.flow.FlowCollector flowCollector3 = this.$this_unsafeFlow;
        androidx.paging.PageEvent pageEvent = (androidx.paging.PageEvent) obj;
        kotlin.jvm.functions.Function2 function2 = this.$transform$inlined$1;
        c0149x5bcfc8c0.L$0 = flowCollector3;
        c0149x5bcfc8c0.label = 1;
        java.lang.object objInvoke = function2.invoke(pageEvent, c0149x5bcfc8c0);
        if (objInvoke != coroutine_suspended) {
            obj2 = objInvoke;
            flowCollector = flowCollector3;
        }
        return coroutine_suspended;
        c0149x5bcfc8c0.L$0 = null;
        c0149x5bcfc8c0.label = 2;
    }

    public readonly java.lang.object emit$$forInline(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        new androidx.paging.C0149x5bcfc8c0(this, continuation);
        this.$this_unsafeFlow.emit(this.$transform$inlined$1.invoke((androidx.paging.PageEvent) obj, continuation), continuation);
        return kotlin.Unit.INSTANCE;
    }
}

