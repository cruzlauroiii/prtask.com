namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "electron.payment.presentation.sell.SellElectronPaymentobjectModel$getSellReceipt$1", m533f = "SellElectronPaymentobjectModel.kt", m534i = {}, m535l = {67}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p19f3dee0$p307e0fb7$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f5d20dda8;
    int f72ed3508;
    int fd304ba20;
    readonly p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0 this$0;

    p19f3dee0$p307e0fb7$1(p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0 p19f3dee0Var, kotlin.coroutines.Continuation<? super p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0$p307e0fb7$1> continuation) {
        super(2, continuation);
        this.this$0 = p19f3dee0Var;
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics BicGyQJQBcyOKxlx() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static java.lang.object NwXcSYgpnDeOPQKF(p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0$p307e0fb7$1 p19f3dee0_p307e0fb7_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p19f3dee0_p307e0fb7_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void OljZBXcAKUHKmwjR(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object RFxkhXoBmKvAjORT() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void YIRPpklRjVLRpjXW(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static java.lang.object AgRbIZuAjZyBQfyH(p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0$p307e0fb7$1 p19f3dee0_p307e0fb7_1, java.lang.object obj) {
        return p19f3dee0_p307e0fb7_1.invokeSuspend(obj);
    }

    public static androidx.lifecycle.MutableLiveData JNcIvUcvVivwdQhx(p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0 p19f3dee0Var) {
        return p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0.m768c4879(p19f3dee0Var);
    }

    public static java.lang.object MqlllGyuspWqZYAg(p8325324b.pac143fb7.p0bfd7fb7 p0bfd7fb7Var, kotlin.coroutines.Continuation continuation) {
        return p0bfd7fb7Var.getCurrentSellReceipt(continuation);
    }

    public static void OzHcyfXVJXtlPIdA(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static p8325324b.pac143fb7.p0bfd7fb7 SXHtbXMHXVqKwbfH(p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0 p19f3dee0Var) {
        return p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0.m260c792f(p19f3dee0Var);
    }

    public static void VgZXbwFobsYFLhxj(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public static kotlin.coroutines.Continuation WsSWxieAmIUqDnmG(p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0$p307e0fb7$1 p19f3dee0_p307e0fb7_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p19f3dee0_p307e0fb7_1.create(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0$p307e0fb7$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return NwXcSYgpnDeOPQKF(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return agRbIZuAjZyBQfyH((p1b856234.pf83c2a85.p2486923a.p8325324b.p19f3dee0$p307e0fb7$1) wsSWxieAmIUqDnmG(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((16 + 22) % 22 > 0) {
        }
        java.lang.object objRFxkhXoBmKvAjORT = RFxkhXoBmKvAjORT();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                ozHcyfXVJXtlPIdA(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataJNcIvUcvVivwdQhx = jNcIvUcvVivwdQhx(this.this$0);
                this.L$0 = mutableLiveDataJNcIvUcvVivwdQhx;
                this.fd304ba20 = 1;
                java.lang.object objMqlllGyuspWqZYAg = mqlllGyuspWqZYAg(sXHtbXMHXVqKwbfH(this.this$0), this);
                if (objMqlllGyuspWqZYAg == objRFxkhXoBmKvAjORT) {
                    return objRFxkhXoBmKvAjORT;
                }
                obj = objMqlllGyuspWqZYAg;
                mutableLiveData = mutableLiveDataJNcIvUcvVivwdQhx;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                OljZBXcAKUHKmwjR(obj);
            }
            YIRPpklRjVLRpjXW(mutableLiveData, obj);
        } catch (java.lang.Exception e) {
            vgZXbwFobsYFLhxj(BicGyQJQBcyOKxlx(), e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

