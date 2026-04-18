namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.presentation.list.InventoryListobjectModel$addPositionToPaybackReceipt$1", m533f = "InventoryListobjectModel.kt", m534i = {}, m535l = {191}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pfef1f419$padd02e98$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 $position;
    int f04639397;
    int f469d41cc;
    int fd304ba20;
    readonly p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419 this$0;

    pfef1f419$padd02e98$1(p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419 pfef1f419Var, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<? super p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419$padd02e98$1> continuation) {
        super(2, continuation);
        this.this$0 = pfef1f419Var;
        this.$position = pd031d465Var;
    }

    public static void DvFMtrJWwNwJnNju(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static p4670093c.pfd9160bb.p1b3a5bf0 JHVYvSQJTOJLNngY(p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419 pfef1f419Var) {
        return p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419.m89a7f193(pfef1f419Var);
    }

    public static java.lang.object LaHbSjFJYAWTBbjO() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void MHwAcJEHXJkdxDue(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public static java.lang.object SCTDVxQNYPSRIHUs(p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5Var, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return pa36ef9b5Var.addPositionToReceipt(pd031d465Var, continuation);
    }

    public static kotlin.coroutines.Continuation UKqPzPQilTfSBSJt(p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419$padd02e98$1 pfef1f419_padd02e98_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return pfef1f419_padd02e98_1.create(obj, continuation);
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics UlpBRGaKwolVXMqn() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static void YhbFHEOojYxSKsOH(p4670093c.pfd9160bb.p1b3a5bf0 p1b3a5bf0Var) {
        p1b3a5bf0Var.backToPaybackPositions();
    }

    public static p4670093c.pac143fb7.pa36ef9b5 GhibbieIyfORDcoy(p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419 pfef1f419Var) {
        return p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419.md95a43c7(pfef1f419Var);
    }

    public static java.lang.object IAMQhfWhbbVzbVhD(p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419$padd02e98$1 pfef1f419_padd02e98_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return pfef1f419_padd02e98_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void TLIXCwLhkHqnakZF(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object YlDkbtenUOuSGXDd(p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419$padd02e98$1 pfef1f419_padd02e98_1, java.lang.object obj) {
        return pfef1f419_padd02e98_1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419$padd02e98$1(this.this$0, this.$position, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return iAMQhfWhbbVzbVhD(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ylDkbtenUOuSGXDd((p7a1eabc3.p2486923a.p10ae9fc7.pfef1f419$padd02e98$1) UKqPzPQilTfSBSJt(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 15) % 15 > 0) {
        }
        java.lang.object objLaHbSjFJYAWTBbjO = LaHbSjFJYAWTBbjO();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                DvFMtrJWwNwJnNju(obj);
                this.fd304ba20 = 1;
                if (SCTDVxQNYPSRIHUs(ghibbieIyfORDcoy(this.this$0), this.$position, this) == objLaHbSjFJYAWTBbjO) {
                    return objLaHbSjFJYAWTBbjO;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                tLIXCwLhkHqnakZF(obj);
            }
            YhbFHEOojYxSKsOH(JHVYvSQJTOJLNngY(this.this$0));
        } catch (java.lang.Exception e) {
            MHwAcJEHXJkdxDue(UlpBRGaKwolVXMqn(), e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

