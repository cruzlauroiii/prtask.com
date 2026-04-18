namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.sell.payment.TophPaymentSellobjectModel$sendReceipt$1", m533f = "TophPaymentSellobjectModel.kt", m534i = {1}, m535l = {413, 415}, m536m = "invokeSuspend", m537n = {"receipt"}, m538s = {"L$0"})
readonly class pa1c74cff$p807ee7c0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f4036aedf;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff this$0;

    pa1c74cff$p807ee7c0$1(p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff pa1c74cffVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$p807ee7c0$1> continuation) {
        super(2, continuation);
        this.this$0 = pa1c74cffVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$p807ee7c0$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$p807ee7c0$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar2;
        if ((3 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) obj;
            if (p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m90edaec8(this.this$0, ped663a3eVar)) {
                this.L$0 = ped663a3eVar;
                this.fd304ba20 = 2;
                if (p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mbb30f96e(this.this$0).sendReceipt(ped663a3eVar, this.this$0.tostring(), this) != coroutine_suspended) {
                    ped663a3eVar2 = ped663a3eVar;
                    ped663a3eVar = ped663a3eVar2;
                }
                return coroutine_suspended;
            }
            p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mdc7bed18(this.this$0).startPaymentSellSuccessFlow(ped663a3eVar, p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m251776c4(this.this$0));
        } catch (java.lang.Exception th) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
            p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m13c0e72b(this.this$0);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            this.fd304ba20 = 1;
            obj = p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m260c792f(this.this$0).getCurrentSellReceipt(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ped663a3eVar2 = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        ped663a3eVar = ped663a3eVar2;
        p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mdc7bed18(this.this$0).startPaymentSellSuccessFlow(ped663a3eVar, p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m251776c4(this.this$0));
        return kotlin.Unit.INSTANCE;
        return kotlin.Unit.INSTANCE;
    }
}

