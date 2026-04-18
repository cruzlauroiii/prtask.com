namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.paymentsettings.PaymentHashSettingsobjectModel$setTapOnPhonePaymentsEnabled$1", m533f = "PaymentHashSettingsobjectModel.kt", m534i = {}, m535l = {132}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2a983b65$p2989f2f6$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly bool $tapOnPhonePaymentsEnabled;
    int fd304ba20;
    int fdf1935c1;
    readonly p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 this$0;

    p2a983b65$p2989f2f6$1(p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 p2a983b65Var, bool z, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p2989f2f6$1> continuation) {
        super(2, continuation);
        this.this$0 = p2a983b65Var;
        this.$tapOnPhonePaymentsEnabled = z;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p2989f2f6$1(this.this$0, this.$tapOnPhonePaymentsEnabled, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p2989f2f6$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 pdcfa0c32VarMb272891c = p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.mb272891c(this.this$0);
            bool z = this.$tapOnPhonePaymentsEnabled;
            p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$p2989f2f6$1 p2a983b65_p2989f2f6_1 = this;
            this.fd304ba20 = 1;
            if (pdcfa0c32VarMb272891c.setTapOnPhonePaymentsEnabled(z, p2a983b65_p2989f2f6_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.m18ed79b5(this.this$0);
        return kotlin.Unit.INSTANCE;
    }
}

