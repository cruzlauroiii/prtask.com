namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.ReceiptStatusesobjectModel$receiptClickHandler$1", m533f = "ReceiptStatusesobjectModel.kt", m534i = {}, m535l = {52}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p5fadb5d4$p7ee5b274$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.p9ded6185 $receipt;
    int f89fa63bd;
    int fc0834d6b;
    int fd1dd0505;
    int fd304ba20;
    int febc4001f;
    readonly p1e11b989.p9acb4454.p2486923a.p5fadb5d4 this$0;

    p5fadb5d4$p7ee5b274$1(p1e11b989.p9acb4454.p2486923a.p5fadb5d4 p5fadb5d4Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.p2486923a.p5fadb5d4$p7ee5b274$1> continuation) {
        super(2, continuation);
        this.this$0 = p5fadb5d4Var;
        this.$receipt = p9ded6185Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p9acb4454.p2486923a.p5fadb5d4$p7ee5b274$1(this.this$0, this.$receipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p9acb4454.p2486923a.p5fadb5d4$p7ee5b274$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 26) % 26 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p1e11b989.p9acb4454.p2486923a.p5fadb5d4.m0b1aca54(this.this$0, this.$receipt, this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p1e11b989.p9acb4454.p2486923a.p5fadb5d4.m74e3994c(this.this$0).openReceiptStatusDetails(((pad5f82e8.p07214c67.p1e11b989.p9ded6185) obj).getUuid());
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

