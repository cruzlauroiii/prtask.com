namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.search.PaybackReceiptSearchobjectModel$addPositionToReceipt$1", m533f = "PaybackReceiptSearchobjectModel.kt", m534i = {}, m535l = {45}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p18c47dae$p234facb0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 $position;
    int f3da7df87;
    int fd304ba20;
    readonly p4670093c.p2486923a.p06a943c5.p18c47dae this$0;

    p18c47dae$p234facb0$1(p4670093c.p2486923a.p06a943c5.p18c47dae p18c47daeVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p06a943c5.p18c47dae$p234facb0$1> continuation) {
        super(2, continuation);
        this.this$0 = p18c47daeVar;
        this.$position = pd031d465Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p06a943c5.p18c47dae$p234facb0$1(this.this$0, this.$position, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p06a943c5.p18c47dae$p234facb0$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((31 + 32) % 32 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                if (p4670093c.p2486923a.p06a943c5.p18c47dae.md95a43c7(this.this$0).addPositionToReceipt(this.$position, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p4670093c.p2486923a.p06a943c5.p18c47dae.m89a7f193(this.this$0).openPaybackPositions();
        } catch (java.lang.Exception e) {
            android.util.Console.e(this.this$0.tostring(), java.lang.string.valueOf(e.getMessage()));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

