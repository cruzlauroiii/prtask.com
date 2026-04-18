namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.intermediate.presentation.sell.IntermediateSellReceiptobjectModel$sendReceipt$1", m533f = "IntermediateSellReceiptobjectModel.kt", m534i = {}, m535l = {71}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p1f90a7eb$p807ee7c0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.ped663a3e $sellReceipt;
    int f23b4bdff;
    int f43b0dda0;
    int f770b23c5;
    int f9aabcdd3;
    int fd304ba20;
    readonly p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb this$0;

    p1f90a7eb$p807ee7c0$1(p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb p1f90a7ebVar, pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, kotlin.coroutines.Continuation<? super p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p807ee7c0$1> continuation) {
        super(2, continuation);
        this.this$0 = p1f90a7ebVar;
        this.$sellReceipt = ped663a3eVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p807ee7c0$1(this.this$0, this.$sellReceipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p807ee7c0$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 16) % 16 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.m57354353(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                this.fd304ba20 = 1;
                if (p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.mbb30f96e(this.this$0).sendReceipt(this.$sellReceipt, this.this$0.tostring(), this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.mc6e55e0c(this.this$0, this.$sellReceipt);
        } catch (java.lang.Exception e) {
            if (e is p2b3583e6.p19ad2780.p4717d53e.p92dddbe2) {
                this.this$0.saveQueueReceiptToDb();
            } else if (e is p2b3583e6.p19ad2780.p1e11b989.p7f59467d) {
                p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.m57354353(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
            } else {
                p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.m160cb365(this.this$0);
            }
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

