namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "launcher.presentation.review_app.ReviewAppobjectModel$sendFeedback$1", m533f = "ReviewAppobjectModel.kt", m534i = {}, m535l = {27}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pd5481c88$pe925c10c$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $feedback;
    int f4f925ed7;
    int fd304ba20;
    int fd4fb188b;
    readonly pf3e08b51.p2486923a.pd16378b7.pd5481c88 this$0;

    pd5481c88$pe925c10c$1(pf3e08b51.p2486923a.pd16378b7.pd5481c88 pd5481c88Var, java.lang.string str, kotlin.coroutines.Continuation<? super pf3e08b51.p2486923a.pd16378b7.pd5481c88$pe925c10c$1> continuation) {
        super(2, continuation);
        this.this$0 = pd5481c88Var;
        this.$feedback = str;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf3e08b51.p2486923a.pd16378b7.pd5481c88$pe925c10c$1(this.this$0, this.$feedback, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pf3e08b51.p2486923a.pd16378b7.pd5481c88$pe925c10c$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((27 + 16) % 16 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                pf3e08b51.p2486923a.pd16378b7.pd5481c88.m6596a6a0(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                this.fd304ba20 = 1;
                if (pf3e08b51.p2486923a.pd16378b7.pd5481c88.mf0b9bfcd(this.this$0).sendFeedback(this.$feedback, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            pf3e08b51.p2486923a.pd16378b7.pd5481c88.m6596a6a0(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c.m02f94ccf(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, null, 1, null));
            pf3e08b51.p2486923a.pd16378b7.pd5481c88.m66d381fb(this.this$0);
        } catch (java.lang.Exception e) {
            pf3e08b51.p2486923a.pd16378b7.pd5481c88.m6596a6a0(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

