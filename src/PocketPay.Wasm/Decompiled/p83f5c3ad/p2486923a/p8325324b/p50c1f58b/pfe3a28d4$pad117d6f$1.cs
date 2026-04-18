namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.sell.gone.TophPaymentSellGoneobjectModel$getReceiptTotal$1", m533f = "TophPaymentSellGoneobjectModel.kt", m534i = {}, m535l = {30}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pfe3a28d4$pad117d6f$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f8e8d3cee;
    int fbd69f50d;
    int fd304ba20;
    int fdb481777;
    readonly p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4 this$0;

    pfe3a28d4$pad117d6f$1(p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4 pfe3a28d4Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4$pad117d6f$1> continuation) {
        super(2, continuation);
        this.this$0 = pfe3a28d4Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4$pad117d6f$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4$pad117d6f$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4.m260c792f(this.this$0).getCurrentSellReceipt(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) obj;
            java.math.decimal comboAmount = p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4.mc4f4919e(this.this$0).getComboAmount();
            kotlinx.coroutines.flow.MutableStateFlow mutableStateFlowMabc9dd11 = p83f5c3ad.p2486923a.p8325324b.p50c1f58b.pfe3a28d4.mabc9dd11(this.this$0);
            if (comboAmount is null) {
                comboAmount = p2b3583e6.p263e3cef.p517b902b.m29a3256d(ped663a3eVar);
            }
            mutableStateFlowMabc9dd11.setValue(comboAmount);
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

