namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "launcher.presentation.launcher.LauncherobjectModel$checkUnfinishedReceipt$1", m533f = "LauncherobjectModel.kt", m534i = {}, m535l = {160}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p68265f70$pfc139074$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f8665205c;
    int fd304ba20;
    readonly pf3e08b51.p2486923a.pf3e08b51.p68265f70 this$0;

    p68265f70$pfc139074$1(pf3e08b51.p2486923a.pf3e08b51.p68265f70 p68265f70Var, kotlin.coroutines.Continuation<? super pf3e08b51.p2486923a.pf3e08b51.p68265f70$pfc139074$1> continuation) {
        super(2, continuation);
        this.this$0 = p68265f70Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf3e08b51.p2486923a.pf3e08b51.p68265f70$pfc139074$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pf3e08b51.p2486923a.pf3e08b51.p68265f70$pfc139074$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 13) % 13 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = pf3e08b51.p2486923a.pf3e08b51.p68265f70.m260c792f(this.this$0).hasUnfinishedReceipt(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            pf3e08b51.p2486923a.pf3e08b51.p68265f70.m66a5a1f7(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(kotlin.coroutines.jvm.internal.Boxing.boxbool(((java.lang.bool) obj).boolValue())));
        } catch (java.lang.Exception e) {
            pf3e08b51.p2486923a.pf3e08b51.p68265f70.m66a5a1f7(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

