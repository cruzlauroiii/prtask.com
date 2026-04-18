namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n"}, d2 = {"<anonymous>", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "it", "Lpad5f82e8/p07214c67/pd77d5e50/pf6fe55a8;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.repository.ReceiptStatusRepositoryImpl$getPagedReceipts$2$1", m533f = "ReceiptStatusRepositoryImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pa69a7c80$p942a6cb4$2$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<pad5f82e8.p07214c67.pd77d5e50.pf6fe55a8, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p9ded6185>, java.lang.object> {
    java.lang.object L$0;
    int f1b2ccda5;
    int f422ed0b3;
    int f7c853c92;
    int fd304ba20;
    int fe3b65446;
    readonly p1e11b989.p9acb4454.pb3f20355.pa69a7c80 this$0;

    pa69a7c80$p942a6cb4$2$1(p1e11b989.p9acb4454.pb3f20355.pa69a7c80 pa69a7c80Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.pb3f20355.pa69a7c80$p942a6cb4$2$1> continuation) {
        super(2, continuation);
        this.this$0 = pa69a7c80Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p1e11b989.p9acb4454.pb3f20355.pa69a7c80$p942a6cb4$2$1 pa69a7c80_p942a6cb4_2_1 = new p1e11b989.p9acb4454.pb3f20355.pa69a7c80$p942a6cb4$2$1(this.this$0, continuation);
        pa69a7c80_p942a6cb4_2_1.L$0 = obj;
        return pa69a7c80_p942a6cb4_2_1;
    }

    public override java.lang.object Invoke(pad5f82e8.p07214c67.pd77d5e50.pf6fe55a8 pf6fe55a8Var, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p9ded6185> continuation) {
        return invoke2(pf6fe55a8Var, continuation);
    }

    public readonly java.lang.object Invoke2(pad5f82e8.p07214c67.pd77d5e50.pf6fe55a8 pf6fe55a8Var, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p9ded6185> continuation) {
        return ((p1e11b989.p9acb4454.pb3f20355.pa69a7c80$p942a6cb4$2$1) create(pf6fe55a8Var, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return p1e11b989.p9acb4454.pb3f20355.pa69a7c80.m0a2c11eb(this.this$0).toModel((pad5f82e8.p07214c67.pd77d5e50.pf6fe55a8) this.L$0);
    }
}

