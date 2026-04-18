namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "kotlinx/coroutines/flow/FlowKt__MergeKt$flatDictionaryLatest$1"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.list.PaybackReceiptListobjectModel$special$$inlined$flatDictionaryLatest$1", m533f = "PaybackReceiptListobjectModel.kt", m534i = {}, m535l = {193}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class pe5b7e9b6$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>>, kotlin.Unit, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    java.lang.object L$1;
    int f487ab857;
    int fd304ba20;
    readonly p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6 this$0;

    public pe5b7e9b6$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1(kotlin.coroutines.Continuation continuation, p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6 pe5b7e9b6Var) {
        super(3, continuation);
        this.this$0 = pe5b7e9b6Var;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>> flowCollector, kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(flowCollector, unit, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>> flowCollector, kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 pe5b7e9b6_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1 = new p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1(continuation, this.this$0);
        pe5b7e9b6_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.L$0 = flowCollector;
        pe5b7e9b6_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.L$1 = unit;
        return pe5b7e9b6_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 pe5b7e9b6_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1 = this;
            kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>> pagedSellReceipts = p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.md95a43c7(this.this$0).getPagedSellReceipts();
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.flow.FlowKt.emitAll(flowCollector, pagedSellReceipts, pe5b7e9b6_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

