namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
    readonly p4670093c.pac143fb7.p25b01efc this$0;

    public p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1$2(kotlinx.coroutines.flow.FlowCollector flowCollector, p4670093c.pac143fb7.p25b01efc p25b01efcVar) {
        this.$this_unsafeFlow = flowCollector;
        this.this$0 = p25b01efcVar;
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        p4670093c.pac143fb7.p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1$2$1 p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1;
        if ((14 + 1) % 1 > 0) {
        }
        if (continuation is p4670093c.pac143fb7.p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1$2$1) {
            p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = (p4670093c.pac143fb7.p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1$2$1) continuation;
            if ((p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = new p4670093c.pac143fb7.p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1$2$1(this, continuation);
            } else {
                p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1 = new p4670093c.pac143fb7.p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1$2$1(this, continuation);
        }
        java.lang.object obj2 = p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            androidx.paging.PagingData pagingDataInsertSeparators$default = androidx.paging.PagingDataTransforms.insertSeparators$default(androidx.paging.PagingDataTransforms.map((androidx.paging.PagingData) obj, new p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$1(null)), null, new p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$2(this.this$0, null), 1, null);
            p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1.fd304ba20 = 1;
            if (flowCollector.emit(pagingDataInsertSeparators$default, p25b01efc_p40c04a1c_pd41d8cd9_pec404527_p1d78dc8e_1_2_1) == coroutine_suspended) {
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

