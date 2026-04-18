namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n"}, d2 = {"<anonymous>", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305$p5d3072af;", "it", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.usecase.PaybackReceiptUseCaseImpl$getPagedSellReceipts$1$1", m533f = "PaybackReceiptUseCaseImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p25b01efc$p40c04a1c$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<pad5f82e8.p07214c67.p1e11b989.ped663a3e, kotlin.coroutines.Continuation<? super pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af>, java.lang.object> {
    java.lang.object L$0;
    int f691bc9f9;
    int f6e0e80b2;
    int f9422a6af;
    int fafcc308a;
    int fd304ba20;

    p25b01efc$p40c04a1c$1$1(kotlin.coroutines.Continuation<? super p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$1> continuation) {
        super(2, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$1 p25b01efc_p40c04a1c_1_1 = new p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$1(continuation);
        p25b01efc_p40c04a1c_1_1.L$0 = obj;
        return p25b01efc_p40c04a1c_1_1;
    }

    public override java.lang.object Invoke(pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, kotlin.coroutines.Continuation<? super pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af> continuation) {
        return invoke2(ped663a3eVar, continuation);
    }

    public readonly java.lang.object Invoke2(pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, kotlin.coroutines.Continuation<? super pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af> continuation) {
        return ((p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$1) create(ped663a3eVar, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return new pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af((pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$0);
    }
}

