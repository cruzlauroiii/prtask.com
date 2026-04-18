namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.intermediate.presentation.payback.IntermediatePaybackReceiptobjectModel$sendReceipt$1", m533f = "IntermediatePaybackReceiptobjectModel.kt", m534i = {}, m535l = {60}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pf164c75c$p807ee7c0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 $paybackReceipt;
    int f0653b557;
    int f0cdd781c;
    int f8732a20d;
    int fd304ba20;
    int fe0c918e1;
    readonly p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c this$0;

    pf164c75c$p807ee7c0$1(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation<? super p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p807ee7c0$1> continuation) {
        super(2, continuation);
        this.this$0 = pf164c75cVar;
        this.$paybackReceipt = p18cf5223Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p807ee7c0$1(this.this$0, this.$paybackReceipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p807ee7c0$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.m57354353(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                this.fd304ba20 = 1;
                if (p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.mbb30f96e(this.this$0).sendReceipt(this.$paybackReceipt, this.this$0.tostring(), this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.mc6e55e0c(this.this$0, this.$paybackReceipt);
        } catch (java.lang.Exception e) {
            if (e is p2b3583e6.p19ad2780.p4717d53e.p92dddbe2) {
                this.this$0.saveQueueReceiptToDb();
            } else if (e is p2b3583e6.p19ad2780.p1e11b989.p7f59467d) {
                p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.m57354353(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
            } else {
                p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.m160cb365(this.this$0);
            }
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

