namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "kotlinx/coroutines/flow/FlowKt__MergeKt$flatDictionaryLatest$1"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.ReceiptStatusesobjectModel$special$$inlined$flatDictionaryLatest$1", m533f = "ReceiptStatusesobjectModel.kt", m534i = {}, m535l = {193}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class p5fadb5d4$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>>, p1e11b989.p9acb4454.p07214c67.pc77da2af, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    java.lang.object L$1;
    int f0fd81346;
    int f393a8192;
    int f49d0d4b2;
    int f4e805ce5;
    int fd304ba20;
    readonly p1e11b989.p9acb4454.p2486923a.p5fadb5d4 this$0;

    public p5fadb5d4$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1(kotlin.coroutines.Continuation continuation, p1e11b989.p9acb4454.p2486923a.p5fadb5d4 p5fadb5d4Var) {
        super(3, continuation);
        this.this$0 = p5fadb5d4Var;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>> flowCollector, p1e11b989.p9acb4454.p07214c67.pc77da2af pc77da2afVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(flowCollector, pc77da2afVar, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>> flowCollector, p1e11b989.p9acb4454.p07214c67.pc77da2af pc77da2afVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        p1e11b989.p9acb4454.p2486923a.p5fadb5d4$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 p5fadb5d4_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1 = new p1e11b989.p9acb4454.p2486923a.p5fadb5d4$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1(continuation, this.this$0);
        p5fadb5d4_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.L$0 = flowCollector;
        p5fadb5d4_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.L$1 = pc77da2afVar;
        return p5fadb5d4_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            p1e11b989.p9acb4454.p2486923a.p5fadb5d4$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 p5fadb5d4_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1 = this;
            kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>> pagedReceipts = p1e11b989.p9acb4454.p2486923a.p5fadb5d4.m34b8edf3(this.this$0).getPagedReceipts((p1e11b989.p9acb4454.p07214c67.pc77da2af) this.L$1);
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.flow.FlowKt.emitAll(flowCollector, pagedReceipts, p5fadb5d4_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1) == coroutine_suspended) {
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

