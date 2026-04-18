namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "electron.payment.presentation.payback.PaybackElectronPaymentobjectModel$getPaybackReceipt$1", m533f = "PaybackElectronPaymentobjectModel.kt", m534i = {}, m535l = {67}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2f0a867d$p9b63e6e8$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f27f07ac0;
    int fb3fcdbd7;
    int fba63d14f;
    int fd304ba20;
    int fe4c7ca47;
    readonly p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d this$0;

    p2f0a867d$p9b63e6e8$1(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar, kotlin.coroutines.Continuation<? super p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p9b63e6e8$1> continuation) {
        super(2, continuation);
        this.this$0 = p2f0a867dVar;
    }

    public static androidx.lifecycle.MutableLiveData BZjlVqMaIxkFGkme(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d.m41e2481f(p2f0a867dVar);
    }

    public static java.lang.object HsIHauleOjOwOVHa(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p9b63e6e8$1 p2f0a867d_p9b63e6e8_1, java.lang.object obj) {
        return p2f0a867d_p9b63e6e8_1.invokeSuspend(obj);
    }

    public static p4670093c.pac143fb7.pa36ef9b5 NhVXaZKSaEJSBFvv(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d.md95a43c7(p2f0a867dVar);
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics AxoGiFwhGFfvKaZs() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static void DEfhEGslBFczHqPj(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public static void EqtxTYwgxbQrDVkF(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static void HwBYwWvTSjFfxfLc(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object LDfpbEwVoVVoZTfe(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p9b63e6e8$1 p2f0a867d_p9b63e6e8_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p2f0a867d_p9b63e6e8_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static kotlin.coroutines.Continuation PGPPnrpoIRPiMQiX(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p9b63e6e8$1 p2f0a867d_p9b63e6e8_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p2f0a867d_p9b63e6e8_1.create(obj, continuation);
    }

    public static java.lang.object PKmGVjEglFIUAxQO() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void VhsjELQuPbUmrNVw(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object ZMPOdxHnzOWqjiVT(p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5Var, kotlin.coroutines.Continuation continuation) {
        return pa36ef9b5Var.getCurrentPaybackReceipt(continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p9b63e6e8$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return lDfpbEwVoVVoZTfe(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return HsIHauleOjOwOVHa((p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p9b63e6e8$1) pGPPnrpoIRPiMQiX(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((24 + 17) % 17 > 0) {
        }
        java.lang.object objPKmGVjEglFIUAxQO = pKmGVjEglFIUAxQO();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                vhsjELQuPbUmrNVw(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataBZjlVqMaIxkFGkme = BZjlVqMaIxkFGkme(this.this$0);
                this.L$0 = mutableLiveDataBZjlVqMaIxkFGkme;
                this.fd304ba20 = 1;
                java.lang.object objZMPOdxHnzOWqjiVT = zMPOdxHnzOWqjiVT(NhVXaZKSaEJSBFvv(this.this$0), this);
                if (objZMPOdxHnzOWqjiVT == objPKmGVjEglFIUAxQO) {
                    return objPKmGVjEglFIUAxQO;
                }
                obj = objZMPOdxHnzOWqjiVT;
                mutableLiveData = mutableLiveDataBZjlVqMaIxkFGkme;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                hwBYwWvTSjFfxfLc(obj);
            }
            eqtxTYwgxbQrDVkF(mutableLiveData, obj);
        } catch (java.lang.Exception e) {
            dEfhEGslBFczHqPj(axoGiFwhGFfvKaZs(), e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

