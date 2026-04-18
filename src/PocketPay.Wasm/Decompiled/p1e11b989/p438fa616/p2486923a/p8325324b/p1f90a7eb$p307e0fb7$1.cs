namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.intermediate.presentation.sell.IntermediateSellReceiptobjectModel$getSellReceipt$1", m533f = "IntermediateSellReceiptobjectModel.kt", m534i = {}, m535l = {41}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p1f90a7eb$p307e0fb7$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.math.decimal $customerChange;
    int f2e999cf7;
    int fd304ba20;
    int ff02656c2;
    readonly p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb this$0;

    p1f90a7eb$p307e0fb7$1(p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb p1f90a7ebVar, java.math.decimal bigDecimal, kotlin.coroutines.Continuation<? super p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p307e0fb7$1> continuation) {
        super(2, continuation);
        this.this$0 = p1f90a7ebVar;
        this.$customerChange = bigDecimal;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p307e0fb7$1(this.this$0, this.$customerChange, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p307e0fb7$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object currentSellReceipt;
        if ((14 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                currentSellReceipt = p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.m260c792f(this.this$0).getCurrentSellReceipt(this);
                if (currentSellReceipt == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                currentSellReceipt = obj;
            }
            p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.m8a0a68c2(this.this$0).setValue(pad5f82e8.p07214c67.p1e11b989.ped663a3e.m1c1e012b((pad5f82e8.p07214c67.p1e11b989.ped663a3e) currentSellReceipt, null, null, null, null, null, null, null, null, null, false, null, null, null, null, null, null, null, null, null, null, this.$customerChange, null, null, false, null, null, 66060287, null));
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

