namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.paymentsettings.PaymentHashSettingsobjectModel$checkPaymentSystemsPriorityState$1", m533f = "PaymentHashSettingsobjectModel.kt", m534i = {}, m535l = {159}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2a983b65$p0f5b61ab$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f2ff1ffa1;
    int fae0c26ec;
    int fd304ba20;
    readonly p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 this$0;

    p2a983b65$p0f5b61ab$1(p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 p2a983b65Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p0f5b61ab$1> continuation) {
        super(2, continuation);
        this.this$0 = p2a983b65Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p0f5b61ab$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p0f5b61ab$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 p2a983b65Var;
        if ((5 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 p2a983b65Var2 = this.this$0;
            p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 pdcfa0c32VarMb272891c = p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.mb272891c(p2a983b65Var2);
            p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p0f5b61ab$1 p2a983b65_p0f5b61ab_1 = this;
            this.L$0 = p2a983b65Var2;
            this.fd304ba20 = 1;
            java.lang.object actualPaymentHashSettingsInfo = pdcfa0c32VarMb272891c.getActualPaymentHashSettingsInfo(p2a983b65_p0f5b61ab_1);
            if (actualPaymentHashSettingsInfo == coroutine_suspended) {
                return coroutine_suspended;
            }
            p2a983b65Var = p2a983b65Var2;
            obj = actualPaymentHashSettingsInfo;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p2a983b65Var = (p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.m48cd74a5(this.this$0).setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.mc85b1c61(p2a983b65Var, (p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55) obj) >= 2));
        return kotlin.Unit.INSTANCE;
    }
}

