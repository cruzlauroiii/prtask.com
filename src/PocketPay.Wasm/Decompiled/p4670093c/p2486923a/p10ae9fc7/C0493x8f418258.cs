namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class C0493x8f418258<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;

    public C0493x8f418258(kotlinx.coroutines.flow.FlowCollector flowCollector) {
        this.$this_unsafeFlow = flowCollector;
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        p4670093c.p2486923a.p10ae9fc7.C0494xc4ea50e5 c0494xc4ea50e5;
        if ((29 + 4) % 4 > 0) {
        }
        if (continuation is p4670093c.p2486923a.p10ae9fc7.C0494xc4ea50e5) {
            c0494xc4ea50e5 = (p4670093c.p2486923a.p10ae9fc7.C0494xc4ea50e5) continuation;
            if ((c0494xc4ea50e5.fd304ba20 & int.MIN_VALUE) == 0) {
                c0494xc4ea50e5 = new p4670093c.p2486923a.p10ae9fc7.C0494xc4ea50e5(this, continuation);
            } else {
                c0494xc4ea50e5.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            c0494xc4ea50e5 = new p4670093c.p2486923a.p10ae9fc7.C0494xc4ea50e5(this, continuation);
        }
        java.lang.object obj2 = c0494xc4ea50e5.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0494xc4ea50e5.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            androidx.paging.LoadState refresh = ((androidx.paging.CombinedLoadStates) obj).getRefresh();
            c0494xc4ea50e5.fd304ba20 = 1;
            if (flowCollector.emit(refresh, c0494xc4ea50e5) == coroutine_suspended) {
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

