namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "electron.payment.presentation.payback.PaybackElectronPaymentobjectModel$sendReceipt$1", m533f = "PaybackElectronPaymentobjectModel.kt", m534i = {}, m535l = {43}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2f0a867d$p807ee7c0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 $paybackReceipt;
    int fd304ba20;
    int fd49603d1;
    readonly p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d this$0;

    p2f0a867d$p807ee7c0$1(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation<? super p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p807ee7c0$1> continuation) {
        super(2, continuation);
        this.this$0 = p2f0a867dVar;
        this.$paybackReceipt = p18cf5223Var;
    }

    public static java.lang.object DYjKAsFBKWIMQBxG(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p807ee7c0$1 p2f0a867d_p807ee7c0_1, java.lang.object obj) {
        return p2f0a867d_p807ee7c0_1.invokeSuspend(obj);
    }

    public static void EkWFsGTpVXlWtfBj(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static java.lang.object JxlplehLMeUiohnb(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p807ee7c0$1 p2f0a867d_p807ee7c0_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p2f0a867d_p807ee7c0_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static pad5f82e8.p07214c67.pa4ecfc70 LjBwnlheUaYMngtF(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c) {
        return pa4ecfc70_p910eef8c.loading();
    }

    public static void LolLlatYRQUlGMYz(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d.m160cb365(p2f0a867dVar);
    }

    public static pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 OIbfrSpbFUIKQrvd(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d.mbb30f96e(p2f0a867dVar);
    }

    public static java.lang.object SHjwhHlVVgZeIoSI() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics SRRBfCcDRiIRlEcy() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static void THuyERLsCFkKKhGg(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static androidx.lifecycle.MutableLiveData TgTbRhwhACFQZqLj(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d.m57354353(p2f0a867dVar);
    }

    public static java.lang.object ZyOVfDBGnDdLiuku(pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 pf21d5ed1Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pf21d5ed1Var.sendReceipt(p9ded6185Var, str, continuation);
    }

    public static void DWlzrekKaJNHEnBk(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static pad5f82e8.p07214c67.pa4ecfc70 IgofvxaREsiLebjg(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c, java.lang.Exception th) {
        return pa4ecfc70_p910eef8c.error(th);
    }

    public static void MUAuuheQdxtZbaQc(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string SBIgveyIupQpwGQb(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p2f0a867dVar.tostring();
    }

    public static void UIcUzSvNarAMTEjO(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public static kotlin.coroutines.Continuation VHuvCYsYvFNsUvTr(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p807ee7c0$1 p2f0a867d_p807ee7c0_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p2f0a867d_p807ee7c0_1.create(obj, continuation);
    }

    public static void VYgsvFzXnavpAWvd(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        p2f0a867dVar.saveQueueReceiptToDb();
    }

    public static void VpTOtNtgjGGUnAcZ(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d.m0d622a60(p2f0a867dVar, p18cf5223Var);
    }

    public static androidx.lifecycle.MutableLiveData ZmDQlKnlHoAYkCXo(p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d p2f0a867dVar) {
        return p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d.m57354353(p2f0a867dVar);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p807ee7c0$1(this.this$0, this.$paybackReceipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return JxlplehLMeUiohnb(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return DYjKAsFBKWIMQBxG((p1b856234.pf83c2a85.p2486923a.p4670093c.p2f0a867d$p807ee7c0$1) vHuvCYsYvFNsUvTr(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((27 + 28) % 28 > 0) {
        }
        java.lang.object objSHjwhHlVVgZeIoSI = SHjwhHlVVgZeIoSI();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                dWlzrekKaJNHEnBk(obj);
                EkWFsGTpVXlWtfBj(zmDQlKnlHoAYkCXo(this.this$0), LjBwnlheUaYMngtF(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c));
                this.fd304ba20 = 1;
                if (ZyOVfDBGnDdLiuku(OIbfrSpbFUIKQrvd(this.this$0), this.$paybackReceipt, sBIgveyIupQpwGQb(this.this$0), this) == objSHjwhHlVVgZeIoSI) {
                    return objSHjwhHlVVgZeIoSI;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mUAuuheQdxtZbaQc(obj);
            }
            vpTOtNtgjGGUnAcZ(this.this$0, this.$paybackReceipt);
        } catch (java.lang.Exception e) {
            if (e is p2b3583e6.p19ad2780.p4717d53e.p92dddbe2) {
                vYgsvFzXnavpAWvd(this.this$0);
            } else if (e is p2b3583e6.p19ad2780.p1e11b989.p7f59467d) {
                THuyERLsCFkKKhGg(TgTbRhwhACFQZqLj(this.this$0), igofvxaREsiLebjg(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, e));
            } else {
                LolLlatYRQUlGMYz(this.this$0);
            }
            uIcUzSvNarAMTEjO(SRRBfCcDRiIRlEcy(), e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

