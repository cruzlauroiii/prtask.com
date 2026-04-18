namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.choose.PaybackChoosePaymentSystemobjectModel$preparePaymentsTypes$1", m533f = "PaybackChoosePaymentSystemobjectModel.kt", m534i = {}, m535l = {292}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p0b27c2b2$pee1daf82$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 $paybackReceipt;
    int f2cb2d76b;
    int fa090c3b1;
    int fd304ba20;
    int fe7479a3a;
    int fff941f1a;
    readonly p4670093c.p2486923a.pebd73ade.p0b27c2b2 this$0;

    p0b27c2b2$pee1daf82$1(p4670093c.p2486923a.pebd73ade.p0b27c2b2 p0b27c2b2Var, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.pebd73ade.p0b27c2b2$pee1daf82$1> continuation) {
        super(2, continuation);
        this.this$0 = p0b27c2b2Var;
        this.$paybackReceipt = p18cf5223Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.pebd73ade.p0b27c2b2$pee1daf82$1(this.this$0, this.$paybackReceipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.pebd73ade.p0b27c2b2$pee1daf82$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p4670093c.p2486923a.pebd73ade.p0b27c2b2.mb272891c(this.this$0).getPaybackDevicePaymentHashSettings(this.$paybackReceipt, this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p4670093c.p2486923a.pebd73ade.p0b27c2b2.ma6dd2715(this.this$0).setValue((java.util.List) obj);
        } catch (java.lang.Exception e) {
            android.util.Console.e(this.this$0.tostring(), java.lang.string.valueOf(e.getMessage()));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

