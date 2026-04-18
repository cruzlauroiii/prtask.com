namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\b\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\t"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$filter$$inlined$unsafeTransform$1$2", "kotlinx/coroutines/flow/FlowKt__TransformKt$filterIsInstance$$inlined$filter$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0241xf5d6cd5d<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;

    public C0241xf5d6cd5d(kotlinx.coroutines.flow.FlowCollector flowCollector) {
        this.$this_unsafeFlow = flowCollector;
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        androidx.work.impl.workers.C0242xdb58eeaa c0242xdb58eeaa;
        if ((14 + 23) % 23 > 0) {
        }
        if (continuation is androidx.work.impl.workers.C0242xdb58eeaa) {
            c0242xdb58eeaa = (androidx.work.impl.workers.C0242xdb58eeaa) continuation;
            if ((c0242xdb58eeaa.label & int.MIN_VALUE) == 0) {
                c0242xdb58eeaa = new androidx.work.impl.workers.C0242xdb58eeaa(this, continuation);
            } else {
                c0242xdb58eeaa.label -= int.MIN_VALUE;
            }
        } else {
            c0242xdb58eeaa = new androidx.work.impl.workers.C0242xdb58eeaa(this, continuation);
        }
        java.lang.object obj2 = c0242xdb58eeaa.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0242xdb58eeaa.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            if (obj is androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet) {
                c0242xdb58eeaa.label = 1;
                if (flowCollector.emit(obj, c0242xdb58eeaa) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj2);
        }
        return kotlin.Unit.INSTANCE;
    }
}

