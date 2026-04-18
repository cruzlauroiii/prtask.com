namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.sell.payment.TophPaymentSellobjectModel$saveQueueReceiptToDb$1", m533f = "TophPaymentSellobjectModel.kt", m534i = {1, 2, 3}, m535l = {432, 433, 434, 441}, m536m = "invokeSuspend", m537n = {"receipt", "receipt", "exception"}, m538s = {"L$0", "L$0", "L$0"})
readonly class pa1c74cff$p812699ae$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f45954ab4;
    int f86e674ee;
    int faed663a0;
    int fd304ba20;
    int fe0be3477;
    readonly p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff this$0;

    pa1c74cff$p812699ae$1(p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff pa1c74cffVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$p812699ae$1> continuation) {
        super(2, continuation);
        this.this$0 = pa1c74cffVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$p812699ae$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$p812699ae$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.Exception th;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar2;
        java.lang.object selectedDevice;
        if ((4 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            ped663a3eVar2 = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) obj;
            this.L$0 = ped663a3eVar2;
            this.fd304ba20 = 2;
            selectedDevice = p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m701d8e58(this.this$0).getSelectedDevice(this);
        } catch (java.lang.Exception th2) {
            kotlinx.coroutines.flow.MutableSharedFlow mutableSharedFlowMad452160 = p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mad452160(this.this$0);
            p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff$p812699ae$1 pa1c74cff_p812699ae_1 = this;
            this.L$0 = th2;
            this.fd304ba20 = 4;
            if (mutableSharedFlowMad452160.emit(th2, pa1c74cff_p812699ae_1) != coroutine_suspended) {
                th = th2;
                com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
            }
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
        } else if (i == 2) {
            ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            this.L$0 = ped663a3eVar;
            this.fd304ba20 = 3;
            if (p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mbb30f96e(this.this$0).saveQueueReceiptToDb(ped663a3eVar, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 3) {
                if (i != 4) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                th = (java.lang.Exception) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
                return kotlin.Unit.INSTANCE;
            }
            ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mdc7bed18(this.this$0).startPaymentSellSuccessFlow(ped663a3eVar, p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m251776c4(this.this$0));
        return kotlin.Unit.INSTANCE;
        if (selectedDevice != coroutine_suspended) {
            ped663a3eVar = ped663a3eVar2;
            obj = selectedDevice;
            this.L$0 = ped663a3eVar;
            this.fd304ba20 = 3;
            if (p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mbb30f96e(this.this$0).saveQueueReceiptToDb(ped663a3eVar, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) == coroutine_suspended) {
            }
            p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.mdc7bed18(this.this$0).startPaymentSellSuccessFlow(ped663a3eVar, p83f5c3ad.p2486923a.p8325324b.pf83c2a85.pa1c74cff.m251776c4(this.this$0));
            return kotlin.Unit.INSTANCE;
        }
        return coroutine_suspended;
    }
}

