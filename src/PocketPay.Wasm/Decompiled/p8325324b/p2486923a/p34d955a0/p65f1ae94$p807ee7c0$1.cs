namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.states.SendSellReceiptErrorobjectModel$sendReceipt$1", m533f = "SendSellReceiptErrorobjectModel.kt", m534i = {1}, m535l = {33, 34}, m536m = "invokeSuspend", m537n = {"currentSellReceipt"}, m538s = {"L$0"})
readonly class p65f1ae94$p807ee7c0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int fb23bb5be;
    int fd304ba20;
    readonly p8325324b.p2486923a.p34d955a0.p65f1ae94 this$0;

    p65f1ae94$p807ee7c0$1(p8325324b.p2486923a.p34d955a0.p65f1ae94 p65f1ae94Var, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p34d955a0.p65f1ae94$p807ee7c0$1> continuation) {
        super(2, continuation);
        this.this$0 = p65f1ae94Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.p34d955a0.p65f1ae94$p807ee7c0$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p34d955a0.p65f1ae94$p807ee7c0$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar2;
        if ((5 + 11) % 11 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            ped663a3eVar2 = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) obj;
            this.L$0 = ped663a3eVar2;
            this.fd304ba20 = 2;
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            java.lang.Exception exc = e;
            p8325324b.p2486923a.p34d955a0.p65f1ae94.m952b499e(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(exc));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(exc);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p8325324b.p2486923a.p34d955a0.p65f1ae94.m952b499e(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
            this.fd304ba20 = 1;
            obj = p8325324b.p2486923a.p34d955a0.p65f1ae94.m260c792f(this.this$0).getCurrentSellReceipt(this);
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
            ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p8325324b.p2486923a.p34d955a0.p65f1ae94.m952b499e(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(ped663a3eVar));
        return kotlin.Unit.INSTANCE;
        if (p8325324b.p2486923a.p34d955a0.p65f1ae94.mbb30f96e(this.this$0).sendReceipt(ped663a3eVar2, this.this$0.tostring(), this) != coroutine_suspended) {
            ped663a3eVar = ped663a3eVar2;
            p8325324b.p2486923a.p34d955a0.p65f1ae94.m952b499e(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(ped663a3eVar));
            return kotlin.Unit.INSTANCE;
        }
    }
}

