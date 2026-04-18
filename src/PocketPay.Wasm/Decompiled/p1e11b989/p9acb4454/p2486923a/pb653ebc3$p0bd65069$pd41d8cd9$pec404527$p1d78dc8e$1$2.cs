namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
    readonly p1e11b989.p9acb4454.p2486923a.pb653ebc3 this$0;

    public pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2(kotlinx.coroutines.flow.FlowCollector flowCollector, p1e11b989.p9acb4454.p2486923a.pb653ebc3 pb653ebc3Var) {
        this.$this_unsafeFlow = flowCollector;
        this.this$0 = pb653ebc3Var;
    }

    /*
    */
    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        p1e11b989.p9acb4454.p2486923a.pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1 pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        if ((20 + 19) % 19 > 0) {
        }
        if (continuation is p1e11b989.p9acb4454.p2486923a.pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1) {
            pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = (p1e11b989.p9acb4454.p2486923a.pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1) continuation;
            if ((pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1(this, continuation);
            } else {
                pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = new p1e11b989.p9acb4454.p2486923a.pb653ebc3$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1$2$1(this, continuation);
        }
        java.lang.object obj2 = pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20;
        if (i != 0) {
            if (i == 1) {
                kotlinx.coroutines.flow.FlowCollector flowCollector2 = (kotlinx.coroutines.flow.FlowCollector) pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.L$0;
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
        pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var = (pad5f82e8.p07214c67.p1e11b989.p9ded6185) obj;
        p1e11b989.p9acb4454.p2486923a.pb653ebc3 pb653ebc3Var = this.this$0;
        pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.L$0 = flowCollector3;
        pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 = 1;
        java.lang.object objMf8456d9c = p1e11b989.p9acb4454.p2486923a.pb653ebc3.mf8456d9c(pb653ebc3Var, p9ded6185Var, pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1);
        if (objMf8456d9c != coroutine_suspended) {
            obj2 = objMf8456d9c;
            flowCollector = flowCollector3;
        }
        return coroutine_suspended;
        pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.L$0 = null;
        pb653ebc3_p0bd65069_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 = 2;
    }
}

