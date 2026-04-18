namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class C0486xe5a1b294<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;

    public C0486xe5a1b294(kotlinx.coroutines.flow.FlowCollector flowCollector) {
        this.$this_unsafeFlow = flowCollector;
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.C0487x3ff6221 c0487x3ff6221;
        if ((6 + 17) % 17 > 0) {
        }
        if (continuation is p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.C0487x3ff6221) {
            c0487x3ff6221 = (p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.C0487x3ff6221) continuation;
            if ((c0487x3ff6221.fd304ba20 & int.MIN_VALUE) == 0) {
                c0487x3ff6221 = new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.C0487x3ff6221(this, continuation);
            } else {
                c0487x3ff6221.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            c0487x3ff6221 = new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.C0487x3ff6221(this, continuation);
        }
        java.lang.object obj2 = c0487x3ff6221.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0487x3ff6221.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31 pf5c8ce31Var = new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31((java.util.List) obj);
            c0487x3ff6221.fd304ba20 = 1;
            if (flowCollector.emit(pf5c8ce31Var, c0487x3ff6221) == coroutine_suspended) {
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

