namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n"}, d2 = {"<anonymous>", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305$p5d3072af;", "it", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.usecase.ReceiptStatusUseCaseImpl$getPagedReceipts$1$1", m533f = "ReceiptStatusUseCaseImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p50496a4d$p942a6cb4$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<pad5f82e8.p07214c67.p1e11b989.p9ded6185, kotlin.coroutines.Continuation<? super pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af>, java.lang.object> {
    java.lang.object L$0;
    int f12d653a0;
    int f40e4a9bc;
    int f52460fb3;
    int f587f0c28;
    int fd304ba20;

    p50496a4d$p942a6cb4$1$1(kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.pac143fb7.p50496a4d$p942a6cb4$1$1> continuation) {
        super(2, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p1e11b989.p9acb4454.pac143fb7.p50496a4d$p942a6cb4$1$1 p50496a4d_p942a6cb4_1_1 = new p1e11b989.p9acb4454.pac143fb7.p50496a4d$p942a6cb4$1$1(continuation);
        p50496a4d_p942a6cb4_1_1.L$0 = obj;
        return p50496a4d_p942a6cb4_1_1;
    }

    public override java.lang.object Invoke(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation<? super pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af> continuation) {
        return invoke2(p9ded6185Var, continuation);
    }

    public readonly java.lang.object Invoke2(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation<? super pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af> continuation) {
        return ((p1e11b989.p9acb4454.pac143fb7.p50496a4d$p942a6cb4$1$1) create(p9ded6185Var, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return new pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af((pad5f82e8.p07214c67.p1e11b989.p9ded6185) this.L$0);
    }
}

