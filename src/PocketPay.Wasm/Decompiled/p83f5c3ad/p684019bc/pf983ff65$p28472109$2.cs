namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0006\n\u0000\n\u0002\u0010\u0002\u0010\u0000\u001a\u00020\u0001H\n"}, d2 = {"<anonymous>", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.useCase.InitTapOnPhoneUseCaseImpl$initTapOnPhone$2", m533f = "InitTapOnPhoneUseCaseImpl.kt", m534i = {}, m535l = {16}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pf983ff65$p28472109$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f1d8c252b;
    int fd304ba20;
    int fe1350913;
    int feb61f885;
    readonly p83f5c3ad.p684019bc.pf983ff65 this$0;

    pf983ff65$p28472109$2(p83f5c3ad.p684019bc.pf983ff65 pf983ff65Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pf983ff65$p28472109$2> continuation) {
        super(1, continuation);
        this.this$0 = pf983ff65Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p684019bc.pf983ff65$p28472109$2(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p684019bc.pf983ff65$p28472109$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 15) % 15 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.pf983ff65 pf983ff65Var = this.this$0;
            p83f5c3ad.p684019bc.pf983ff65$p28472109$2 pf983ff65_p28472109_2 = this;
            this.fd304ba20 = 1;
            if (p83f5c3ad.p684019bc.pf983ff65.m07c3cae2(pf983ff65Var, pf983ff65_p28472109_2) == coroutine_suspended) {
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

