namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0006\n\u0000\n\u0002\u0010\u0002\u0010\u0000\u001a\u00020\u0001H\n"}, d2 = {"<anonymous>", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.useCase.TophBatchUseCaseImpl$closeBatch$2", m533f = "TophBatchUseCaseImpl.kt", m534i = {}, m535l = {26}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pb5716981$pda667ba6$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f34493aa8;
    int f73313aa9;
    int f83c44474;
    int fd304ba20;
    int fed3f222e;
    readonly p83f5c3ad.p684019bc.pb5716981 this$0;

    pb5716981$pda667ba6$2(p83f5c3ad.p684019bc.pb5716981 pb5716981Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pb5716981$pda667ba6$2> continuation) {
        super(1, continuation);
        this.this$0 = pb5716981Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p684019bc.pb5716981$pda667ba6$2(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p684019bc.pb5716981$pda667ba6$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((11 + 4) % 4 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.pb3f20355.pf92d207c pf92d207cVarMb90a0220 = p83f5c3ad.p684019bc.pb5716981.mb90a0220(this.this$0);
            p83f5c3ad.p684019bc.pb5716981$pda667ba6$2 pb5716981_pda667ba6_2 = this;
            this.fd304ba20 = 1;
            if (pf92d207cVarMb90a0220.closeBatch(pb5716981_pda667ba6_2) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        this.this$0.setBatchCloseDateTime(java.util.DateTime.getInstance().getTimeInMillis());
        return kotlin.Unit.INSTANCE;
    }
}

