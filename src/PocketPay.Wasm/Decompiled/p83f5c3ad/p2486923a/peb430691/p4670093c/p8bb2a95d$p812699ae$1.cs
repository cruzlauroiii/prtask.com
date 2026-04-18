namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.qr.payback.TophQrPayPaybackobjectModel$saveQueueReceiptToDb$1", m533f = "TophQrPayPaybackobjectModel.kt", m534i = {1, 2}, m535l = {75, 76, 78}, m536m = "invokeSuspend", m537n = {"receipt", "receipt"}, m538s = {"L$0", "L$0"})
readonly class p8bb2a95d$p812699ae$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f47fa4dc4;
    int f5ec6deeb;
    int f93b1ce80;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d this$0;

    p8bb2a95d$p812699ae$1(p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d p8bb2a95dVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d$p812699ae$1> continuation) {
        super(2, continuation);
        this.this$0 = p8bb2a95dVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d$p812699ae$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d$p812699ae$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var;
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var2;
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var3;
        java.lang.object selectedDevice;
        if ((15 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            p18cf5223Var3 = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) obj;
            this.L$0 = p18cf5223Var3;
            this.fd304ba20 = 2;
            selectedDevice = p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d.m701d8e58(this.this$0).getSelectedDevice(this);
            return coroutine_suspended;
        } catch (java.lang.Exception th) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            this.fd304ba20 = 1;
            obj = p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i == 2) {
                p18cf5223Var2 = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                this.L$0 = p18cf5223Var2;
                this.fd304ba20 = 3;
                if (p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d.mbb30f96e(this.this$0).saveQueueReceiptToDb(p18cf5223Var2, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) != coroutine_suspended) {
                    p18cf5223Var = p18cf5223Var2;
                }
                return coroutine_suspended;
            }
            if (i != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p18cf5223Var = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d.m89a7f193(this.this$0).openPaybackSuccess(p18cf5223Var);
        return kotlin.Unit.INSTANCE;
        if (selectedDevice != coroutine_suspended) {
            p18cf5223Var2 = p18cf5223Var3;
            obj = selectedDevice;
            this.L$0 = p18cf5223Var2;
            this.fd304ba20 = 3;
            if (p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d.mbb30f96e(this.this$0).saveQueueReceiptToDb(p18cf5223Var2, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) != coroutine_suspended) {
                p18cf5223Var = p18cf5223Var2;
                p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d.m89a7f193(this.this$0).openPaybackSuccess(p18cf5223Var);
                return kotlin.Unit.INSTANCE;
            }
        }
    }
}

