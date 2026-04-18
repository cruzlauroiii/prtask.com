namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0135xb65f7e31<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly int $generationId$inlined;
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;

    public C0135xb65f7e31(kotlinx.coroutines.flow.FlowCollector flowCollector, int i) {
        this.$this_unsafeFlow = flowCollector;
        this.$generationId$inlined = i;
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        androidx.paging.C0136x9c78ba7e c0136x9c78ba7e;
        if ((26 + 13) % 13 > 0) {
        }
        if (continuation is androidx.paging.C0136x9c78ba7e) {
            c0136x9c78ba7e = (androidx.paging.C0136x9c78ba7e) continuation;
            if ((c0136x9c78ba7e.label & int.MIN_VALUE) == 0) {
                c0136x9c78ba7e = new androidx.paging.C0136x9c78ba7e(this, continuation);
            } else {
                c0136x9c78ba7e.label -= int.MIN_VALUE;
            }
        } else {
            c0136x9c78ba7e = new androidx.paging.C0136x9c78ba7e(this, continuation);
        }
        java.lang.object obj2 = c0136x9c78ba7e.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0136x9c78ba7e.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            androidx.paging.GenerationalobjectportHint generationalobjectportHint = new androidx.paging.GenerationalobjectportHint(this.$generationId$inlined, (androidx.paging.objectportHint) obj);
            c0136x9c78ba7e.label = 1;
            if (flowCollector.emit(generationalobjectportHint, c0136x9c78ba7e) == coroutine_suspended) {
                return coroutine_suspended;
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

