namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;

    public pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2(kotlinx.coroutines.flow.FlowCollector flowCollector) {
        this.$this_unsafeFlow = flowCollector;
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        pd2a57dc1.p2486923a.p9c70933a.pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1 pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1;
        if ((26 + 31) % 31 > 0) {
        }
        if (continuation is pd2a57dc1.p2486923a.p9c70933a.pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1) {
            pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = (pd2a57dc1.p2486923a.p9c70933a.pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1) continuation;
            if ((pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = new pd2a57dc1.p2486923a.p9c70933a.pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1(this, continuation);
            } else {
                pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = new pd2a57dc1.p2486923a.p9c70933a.pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1(this, continuation);
        }
        java.lang.object obj2 = pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            pd2a57dc1.p2486923a.p9c70933a.p74c9efb4 p74c9efb4Var = new pd2a57dc1.p2486923a.p9c70933a.p74c9efb4((p2b3583e6.p93634cf6) obj);
            pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 = 1;
            if (flowCollector.emit(p74c9efb4Var, pe7853c26_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1) == coroutine_suspended) {
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

