namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0006\n\u0000\n\u0002\u0010\u000e\u0010\u0000\u001a\u00020\u0001H\n"}, d2 = {"<anonymous>", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.useCase.TophReceiptUseCaseImpl$getReceiptLink$2", m533f = "TophReceiptUseCaseImpl.kt", m534i = {}, m535l = {30}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p22516072$pca754add$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<java.lang.string>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.p9ded6185 $receipt;
    readonly java.lang.string $rrn;
    int f61c55f4a;
    int fd304ba20;
    int fd99a78ec;
    readonly p83f5c3ad.p684019bc.p22516072 this$0;

    p22516072$pca754add$2(p83f5c3ad.p684019bc.p22516072 p22516072Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p22516072$pca754add$2> continuation) {
        super(1, continuation);
        this.this$0 = p22516072Var;
        this.$receipt = p9ded6185Var;
        this.$rrn = str;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((7 + 13) % 13 > 0) {
        }
        return new p83f5c3ad.p684019bc.p22516072$pca754add$2(this.this$0, this.$receipt, this.$rrn, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<java.lang.string> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<java.lang.string> continuation) {
        return ((p83f5c3ad.p684019bc.p22516072$pca754add$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 24) % 24 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p83f5c3ad.pb3f20355.p5701b2ff p5701b2ffVarM459df111 = p83f5c3ad.p684019bc.p22516072.m459df111(this.this$0);
        pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var = this.$receipt;
        java.lang.string str = this.$rrn;
        p83f5c3ad.p684019bc.p22516072$pca754add$2 p22516072_pca754add_2 = this;
        this.fd304ba20 = 1;
        java.lang.object receiptLink = p5701b2ffVarM459df111.getReceiptLink(p9ded6185Var, str, p22516072_pca754add_2);
        return receiptLink != coroutine_suspended ? receiptLink : coroutine_suspended;
    }
}

