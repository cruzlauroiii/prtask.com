namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.paymentsettings.PaymentHashSettingsobjectModel$getDevicePaymentHashSettings$1", m533f = "PaymentHashSettingsobjectModel.kt", m534i = {}, m535l = {53}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2a983b65$pb4efbb09$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f43c0e479;
    int f6594240d;
    int fa7ca7e1f;
    int fd304ba20;
    int fe621e800;
    readonly p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 this$0;

    p2a983b65$pb4efbb09$1(p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65 p2a983b65Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$pb4efbb09$1> continuation) {
        super(2, continuation);
        this.this$0 = p2a983b65Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$pb4efbb09$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65$pb4efbb09$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((26 + 3) % 3 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.mb272891c(this.this$0).getDevicePaymentHashSettings(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.ma6dd2715(this.this$0).setValue((java.util.List) obj);
            p2e5d8aa3.p2486923a.pfa0e56f0.p2a983b65.m18ed79b5(this.this$0);
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

