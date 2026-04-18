namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.detail.PaybackReceiptDetailobjectModel$getPaybackReceipt$1", m533f = "PaybackReceiptDetailobjectModel.kt", m534i = {0, 1}, m535l = {60, 61}, m536m = "invokeSuspend", m537n = {"positionsForPaybackJob", "paybackReceipt"}, m538s = {"L$0", "L$0"})
readonly class p346d0a2c$p9b63e6e8$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    int f19e6982a;
    int f6f01e96b;
    int fd304ba20;
    readonly p4670093c.p2486923a.p951da6b7.p346d0a2c this$0;

    p346d0a2c$p9b63e6e8$1(p4670093c.p2486923a.p951da6b7.p346d0a2c p346d0a2cVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1> continuation) {
        super(2, continuation);
        this.this$0 = p346d0a2cVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1 p346d0a2c_p9b63e6e8_1 = new p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1(this.this$0, continuation);
        p346d0a2c_p9b63e6e8_1.L$0 = obj;
        return p346d0a2c_p9b63e6e8_1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.Deferred deferredAsync$default;
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var;
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var2;
        java.lang.object objAwait;
        if ((17 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            p18cf5223Var2 = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) obj;
            this.L$0 = p18cf5223Var2;
            this.fd304ba20 = 2;
            objAwait = deferredAsync$default.await(this);
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            android.util.Console.e(this.this$0.tostring(), java.lang.string.valueOf(e.getMessage()));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlinx.coroutines.Deferred deferredAsync$default2 = kotlinx.coroutines.BuildersKt.async$default(coroutineScope, null, null, new p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1$p497af732$1(this.this$0, null), 3, null);
            deferredAsync$default = kotlinx.coroutines.BuildersKt.async$default(coroutineScope, null, null, new p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1$pcaf6925e$1(this.this$0, null), 3, null);
            this.L$0 = deferredAsync$default;
            this.fd304ba20 = 1;
            obj = deferredAsync$default2.await(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            deferredAsync$default = (kotlinx.coroutines.Deferred) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p18cf5223Var = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        java.util.List list = (java.util.List) obj;
        p4670093c.p2486923a.p951da6b7.p346d0a2c.m3757dd67(this.this$0, p18cf5223Var);
        p4670093c.p2486923a.p951da6b7.p346d0a2c.m5c8be80f(this.this$0, list);
        p4670093c.p2486923a.p951da6b7.p346d0a2c.mf38c1956(this.this$0, p18cf5223Var);
        p4670093c.p2486923a.p951da6b7.p346d0a2c.m4bdbb9af(this.this$0, p18cf5223Var.getCreationDateTime());
        p4670093c.p2486923a.p951da6b7.p346d0a2c.mc7a36015(this.this$0, list);
        return kotlin.Unit.INSTANCE;
        if (objAwait != coroutine_suspended) {
            p18cf5223Var = p18cf5223Var2;
            obj = objAwait;
            java.util.List list2 = (java.util.List) obj;
            p4670093c.p2486923a.p951da6b7.p346d0a2c.m3757dd67(this.this$0, p18cf5223Var);
            p4670093c.p2486923a.p951da6b7.p346d0a2c.m5c8be80f(this.this$0, list2);
            p4670093c.p2486923a.p951da6b7.p346d0a2c.mf38c1956(this.this$0, p18cf5223Var);
            p4670093c.p2486923a.p951da6b7.p346d0a2c.m4bdbb9af(this.this$0, p18cf5223Var.getCreationDateTime());
            p4670093c.p2486923a.p951da6b7.p346d0a2c.mc7a36015(this.this$0, list2);
            return kotlin.Unit.INSTANCE;
        }
    }
}

