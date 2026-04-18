namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "kotlinx/coroutines/flow/FlowKt__MergeKt$flatDictionaryLatest$1"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.positions.search.ReceiptStatusDetailsPositionsSearchobjectModel$special$$inlined$flatDictionaryLatest$1", m533f = "ReceiptStatusDetailsPositionsSearchobjectModel.kt", m534i = {}, m535l = {193}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class p0b6b7bb9$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31>, java.lang.string, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    java.lang.object L$1;
    int f24b36a47;
    int fd304ba20;
    readonly p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9 this$0;

    public p0b6b7bb9$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1(kotlin.coroutines.Continuation continuation, p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9 p0b6b7bb9Var) {
        super(3, continuation);
        this.this$0 = p0b6b7bb9Var;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31> flowCollector, java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(flowCollector, str, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31> flowCollector, java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 p0b6b7bb9_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1 = new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1(continuation, this.this$0);
        p0b6b7bb9_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.L$0 = flowCollector;
        p0b6b7bb9_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.L$1 = str;
        return p0b6b7bb9_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 23) % 23 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1 p0b6b7bb9_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1 = this;
            p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p38570d4f$p945f3fc4$1$pd41d8cd9$pec404527$p1d78dc8e$1 p0b6b7bb9_p38570d4f_p945f3fc4_1_pd41d8cd9_pec404527_p1d78dc8e_1 = new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p38570d4f$p945f3fc4$1$pd41d8cd9$pec404527$p1d78dc8e$1(p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9.m34b8edf3(this.this$0).getReceiptPositionsByQuery(p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9.m316b9c6e(this.this$0), (java.lang.string) this.L$1));
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.flow.FlowKt.emitAll(flowCollector, p0b6b7bb9_p38570d4f_p945f3fc4_1_pd41d8cd9_pec404527_p1d78dc8e_1, p0b6b7bb9_p0bd65069_pd41d8cd9_pec404527_pce7a7660_1) == coroutine_suspended) {
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

