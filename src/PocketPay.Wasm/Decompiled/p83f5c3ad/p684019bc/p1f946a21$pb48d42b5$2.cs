namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0006\n\u0000\n\u0002\u0010\u000b\u0010\u0000\u001a\u00020\u0001H\n"}, d2 = {"<anonymous>", ""}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.useCase.NfcTapOnPhoneUseCaseImpl$isNfcCalibrated$2", m533f = "NfcTapOnPhoneUseCaseImpl.kt", m534i = {}, m535l = {40}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p1f946a21$pb48d42b5$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    int f7e6c2540;
    int f8c471843;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p1f946a21 this$0;

    p1f946a21$pb48d42b5$2(p83f5c3ad.p684019bc.p1f946a21 p1f946a21Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p1f946a21$pb48d42b5$2> continuation) {
        super(1, continuation);
        this.this$0 = p1f946a21Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p684019bc.p1f946a21$pb48d42b5$2(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((p83f5c3ad.p684019bc.p1f946a21$pb48d42b5$2) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 4) % 4 > 0) {
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
        p83f5c3ad.p684019bc.p1f946a21$pb48d42b5$2 p1f946a21_pb48d42b5_2 = this;
        this.fd304ba20 = 1;
        java.lang.object objIsNfcCalibrated = pf2914733VarMa596edd8.isNfcCalibrated(p1f946a21_pb48d42b5_2);
        return objIsNfcCalibrated != coroutine_suspended ? objIsNfcCalibrated : coroutine_suspended;
    }
}

