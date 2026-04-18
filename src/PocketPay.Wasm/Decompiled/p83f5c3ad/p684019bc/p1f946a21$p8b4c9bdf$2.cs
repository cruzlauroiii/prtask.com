namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0006\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001H\n"}, d2 = {"<anonymous>", "Lp83f5c3ad/p07214c67/pe6ff918f;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.useCase.NfcTapOnPhoneUseCaseImpl$calibrateNfc$2", m533f = "NfcTapOnPhoneUseCaseImpl.kt", m534i = {}, m535l = {33}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p1f946a21$p8b4c9bdf$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.pe6ff918f>, java.lang.object> {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 $terminal;
    int f3a96b720;
    int fd304ba20;
    int fd8cfa784;
    readonly p83f5c3ad.p684019bc.p1f946a21 this$0;

    p1f946a21$p8b4c9bdf$2(p83f5c3ad.p684019bc.p1f946a21 p1f946a21Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p1f946a21$p8b4c9bdf$2> continuation) {
        super(1, continuation);
        this.this$0 = p1f946a21Var;
        this.$terminal = pd0910e67Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((2 + 11) % 11 > 0) {
        }
        return new p83f5c3ad.p684019bc.p1f946a21$p8b4c9bdf$2(this.this$0, this.$terminal, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.pe6ff918f> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.pe6ff918f> continuation) {
        return ((p83f5c3ad.p684019bc.p1f946a21$p8b4c9bdf$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((27 + 24) % 24 > 0) {
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
        p83f5c3ad.pb3f20355.pf2914733 pf2914733VarMa596edd8 = p83f5c3ad.p684019bc.p1f946a21.ma596edd8(this.this$0);
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var = this.$terminal;
        p83f5c3ad.p684019bc.p1f946a21$p8b4c9bdf$2 p1f946a21_p8b4c9bdf_2 = this;
        this.fd304ba20 = 1;
        java.lang.object objCalibrateNfc = pf2914733VarMa596edd8.calibrateNfc(pd0910e67Var, p1f946a21_p8b4c9bdf_2);
        return objCalibrateNfc != coroutine_suspended ? objCalibrateNfc : coroutine_suspended;
    }
}

