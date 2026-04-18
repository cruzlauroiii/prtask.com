namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.error.SendPaybackReceiptErrorobjectModel$sendPaybackReceipt$1", m533f = "SendPaybackReceiptErrorobjectModel.kt", m534i = {1}, m535l = {32, 33}, m536m = "invokeSuspend", m537n = {"receipt"}, m538s = {"L$0"})
readonly class p4ca91289$p4b22777b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int fb4c72f1e;
    int fd304ba20;
    readonly p4670093c.p2486923a.pcb5e100e.p4ca91289 this$0;

    p4ca91289$p4b22777b$1(p4670093c.p2486923a.pcb5e100e.p4ca91289 p4ca91289Var, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.pcb5e100e.p4ca91289$p4b22777b$1> continuation) {
        super(2, continuation);
        this.this$0 = p4ca91289Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.pcb5e100e.p4ca91289$p4b22777b$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.pcb5e100e.p4ca91289$p4b22777b$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var;
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var2;
        if ((28 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            p18cf5223Var2 = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) obj;
            this.L$0 = p18cf5223Var2;
            this.fd304ba20 = 2;
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            java.lang.Exception exc = e;
            p4670093c.p2486923a.pcb5e100e.p4ca91289.m952b499e(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(exc));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(exc);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p4670093c.p2486923a.pcb5e100e.p4ca91289.m952b499e(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
            this.fd304ba20 = 1;
            obj = p4670093c.p2486923a.pcb5e100e.p4ca91289.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p18cf5223Var = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p4670093c.p2486923a.pcb5e100e.p4ca91289.m0d622a60(this.this$0, p18cf5223Var);
        return kotlin.Unit.INSTANCE;
        if (p4670093c.p2486923a.pcb5e100e.p4ca91289.mbb30f96e(this.this$0).sendReceipt(p18cf5223Var2, this.this$0.tostring(), this) != coroutine_suspended) {
            p18cf5223Var = p18cf5223Var2;
            p4670093c.p2486923a.pcb5e100e.p4ca91289.m0d622a60(this.this$0, p18cf5223Var);
            return kotlin.Unit.INSTANCE;
        }
    }
}

