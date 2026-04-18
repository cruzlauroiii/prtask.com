namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "combo.payment.presentation.sell.electron.SellComboElectronobjectModel$getCurrentSellReceipt$1", m533f = "SellComboElectronobjectModel.kt", m534i = {}, m535l = {42}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p361989ec$p661f6c0a$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f7e07bd39;
    int fd304ba20;
    readonly pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec this$0;

    p361989ec$p661f6c0a$1(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar, kotlin.coroutines.Continuation<? super pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p661f6c0a$1> continuation) {
        super(2, continuation);
        this.this$0 = p361989ecVar;
    }

    public static void BdLEKcUmwTTxwvaz(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void JfyqhFlCWAJxlxja(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static androidx.lifecycle.MutableLiveData LnthlFIoReHAtJsw(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar) {
        return pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec.mc5961be3(p361989ecVar);
    }

    public static java.lang.object MVsAwRQYbLFheDmf(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p661f6c0a$1 p361989ec_p661f6c0a_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p361989ec_p661f6c0a_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static kotlin.coroutines.Continuation SbORMPhEQtQJlsqU(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p661f6c0a$1 p361989ec_p661f6c0a_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p361989ec_p661f6c0a_1.create(obj, continuation);
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics EWsUOoHOlOCUYTaN() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static java.lang.object JVcOSylFPChZtymb(pc69c522d.pf83c2a85.pac143fb7.pab691ef3 pab691ef3Var, kotlin.coroutines.Continuation continuation) {
        return pab691ef3Var.getCurrentSellReceipt(continuation);
    }

    public static void NpxtoknnrYLueFUN(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public static pc69c522d.pf83c2a85.pac143fb7.pab691ef3 PjSPPNbUYKOIkGWY(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec p361989ecVar) {
        return pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec.m1d7af725(p361989ecVar);
    }

    public static void RMHNofTUVIgyydIK(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static java.lang.object UQvUJywoErHWJgeh(pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p661f6c0a$1 p361989ec_p661f6c0a_1, java.lang.object obj) {
        return p361989ec_p661f6c0a_1.invokeSuspend(obj);
    }

    public static java.lang.object YhtFilNrtKgIThFq() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p661f6c0a$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return MVsAwRQYbLFheDmf(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return uQvUJywoErHWJgeh((pc69c522d.pf83c2a85.p2486923a.p8325324b.p1b856234.p361989ec$p661f6c0a$1) SbORMPhEQtQJlsqU(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((24 + 24) % 24 > 0) {
        }
        java.lang.object objYhtFilNrtKgIThFq = yhtFilNrtKgIThFq();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                BdLEKcUmwTTxwvaz(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataLnthlFIoReHAtJsw = LnthlFIoReHAtJsw(this.this$0);
                this.L$0 = mutableLiveDataLnthlFIoReHAtJsw;
                this.fd304ba20 = 1;
                java.lang.object objJVcOSylFPChZtymb = jVcOSylFPChZtymb(pjSPPNbUYKOIkGWY(this.this$0), this);
                if (objJVcOSylFPChZtymb == objYhtFilNrtKgIThFq) {
                    return objYhtFilNrtKgIThFq;
                }
                obj = objJVcOSylFPChZtymb;
                mutableLiveData = mutableLiveDataLnthlFIoReHAtJsw;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                JfyqhFlCWAJxlxja(obj);
            }
            rMHNofTUVIgyydIK(mutableLiveData, obj);
        } catch (java.lang.Exception e) {
            npxtoknnrYLueFUN(eWsUOoHOlOCUYTaN(), e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

