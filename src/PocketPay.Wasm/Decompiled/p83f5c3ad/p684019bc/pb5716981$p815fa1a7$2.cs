namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0006\n\u0000\n\u0002\u0010\u0002\u0010\u0000\u001a\u00020\u0001H\n"}, d2 = {"<anonymous>", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.useCase.TophBatchUseCaseImpl$sendReportToEmail$2", m533f = "TophBatchUseCaseImpl.kt", m534i = {}, m535l = {34}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pb5716981$p815fa1a7$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 $dateEnd;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 $dateStart;
    readonly java.lang.string $email;
    int f4ceb933d;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.pb5716981 this$0;

    pb5716981$p815fa1a7$2(p83f5c3ad.p684019bc.pb5716981 pb5716981Var, java.lang.string str, p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var, p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var2, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pb5716981$p815fa1a7$2> continuation) {
        super(1, continuation);
        this.this$0 = pb5716981Var;
        this.$email = str;
        this.$dateStart = p8cf10d23Var;
        this.$dateEnd = p8cf10d23Var2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((3 + 27) % 27 > 0) {
        }
        return new p83f5c3ad.p684019bc.pb5716981$p815fa1a7$2(this.this$0, this.$email, this.$dateStart, this.$dateEnd, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p684019bc.pb5716981$p815fa1a7$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 5) % 5 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.pb3f20355.pf92d207c pf92d207cVarMb90a0220 = p83f5c3ad.p684019bc.pb5716981.mb90a0220(this.this$0);
            java.lang.string str = this.$email;
            p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.$dateStart;
            p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var2 = this.$dateEnd;
            p83f5c3ad.p684019bc.pb5716981$p815fa1a7$2 pb5716981_p815fa1a7_2 = this;
            this.fd304ba20 = 1;
            if (pf92d207cVarMb90a0220.sendReportToEmail(str, p8cf10d23Var, p8cf10d23Var2, pb5716981_p815fa1a7_2) == coroutine_suspended) {
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

