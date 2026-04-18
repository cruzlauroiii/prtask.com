namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "combo.payment.presentation.sell.cash.SellComboCashobjectModel$getCurrentSellReceipt$1", m533f = "SellComboCashobjectModel.kt", m534i = {}, m535l = {43}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pc314e9a0$p661f6c0a$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int fa573c180;
    int fc9d1324f;
    int fd304ba20;
    readonly pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0 this$0;

    pc314e9a0$p661f6c0a$1(pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0 pc314e9a0Var, kotlin.coroutines.Continuation<? super pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0$p661f6c0a$1> continuation) {
        super(2, continuation);
        this.this$0 = pc314e9a0Var;
    }

    public static androidx.lifecycle.MutableLiveData CCEuKLsnOyZQPxDX(pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0 pc314e9a0Var) {
        return pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0.mc5961be3(pc314e9a0Var);
    }

    public static java.lang.object JNIsufVanbJUmDJz() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics MZBVzSfxHNDlWpeR() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static pc69c522d.pf83c2a85.pac143fb7.pab691ef3 CdPwAWxmtCbMQKds(pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0 pc314e9a0Var) {
        return pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0.m1d7af725(pc314e9a0Var);
    }

    public static void DDmkUnCDAgsyzvgY(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void KvDFuTLloQbxOJoJ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object ObiaqJkqVpfiCDGc(pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0$p661f6c0a$1 pc314e9a0_p661f6c0a_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return pc314e9a0_p661f6c0a_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object QoRZmFdgAVFFmumx(pc69c522d.pf83c2a85.pac143fb7.pab691ef3 pab691ef3Var, kotlin.coroutines.Continuation continuation) {
        return pab691ef3Var.getCurrentSellReceipt(continuation);
    }

    public static void TRvOoMJqagzofaZS(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public static void TxWpprBrsIrWbdga(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static kotlin.coroutines.Continuation UUcAoFXVUkTmWbOt(pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0$p661f6c0a$1 pc314e9a0_p661f6c0a_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return pc314e9a0_p661f6c0a_1.create(obj, continuation);
    }

    public static java.lang.object ZUqItNKQcGjoukND(pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0$p661f6c0a$1 pc314e9a0_p661f6c0a_1, java.lang.object obj) {
        return pc314e9a0_p661f6c0a_1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0$p661f6c0a$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return obiaqJkqVpfiCDGc(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return zUqItNKQcGjoukND((pc69c522d.pf83c2a85.p2486923a.p8325324b.p93585797.pc314e9a0$p661f6c0a$1) uUcAoFXVUkTmWbOt(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((2 + 21) % 21 > 0) {
        }
        java.lang.object objJNIsufVanbJUmDJz = JNIsufVanbJUmDJz();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kvDFuTLloQbxOJoJ(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataCCEuKLsnOyZQPxDX = CCEuKLsnOyZQPxDX(this.this$0);
                this.L$0 = mutableLiveDataCCEuKLsnOyZQPxDX;
                this.fd304ba20 = 1;
                java.lang.object objQoRZmFdgAVFFmumx = qoRZmFdgAVFFmumx(cdPwAWxmtCbMQKds(this.this$0), this);
                if (objQoRZmFdgAVFFmumx == objJNIsufVanbJUmDJz) {
                    return objJNIsufVanbJUmDJz;
                }
                obj = objQoRZmFdgAVFFmumx;
                mutableLiveData = mutableLiveDataCCEuKLsnOyZQPxDX;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                dDmkUnCDAgsyzvgY(obj);
            }
            txWpprBrsIrWbdga(mutableLiveData, obj);
        } catch (java.lang.Exception e) {
            tRvOoMJqagzofaZS(MZBVzSfxHNDlWpeR(), e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

