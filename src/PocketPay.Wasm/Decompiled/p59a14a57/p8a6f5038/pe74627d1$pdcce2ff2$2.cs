namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "views.pin.PinPadobject$onError$2", m533f = "PinPadobject.kt", m534i = {}, m535l = {161}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pe74627d1$pdcce2ff2$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f0a3c3ffa;
    int f22195205;
    int fa01a3085;
    int fc3fd0194;
    int fd304ba20;
    readonly p59a14a57.p8a6f5038.pe74627d1 this$0;

    pe74627d1$pdcce2ff2$2(p59a14a57.p8a6f5038.pe74627d1 pe74627d1Var, kotlin.coroutines.Continuation<? super p59a14a57.p8a6f5038.pe74627d1$pdcce2ff2$2> continuation) {
        super(2, continuation);
        this.this$0 = pe74627d1Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p59a14a57.p8a6f5038.pe74627d1$pdcce2ff2$2(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p59a14a57.p8a6f5038.pe74627d1$pdcce2ff2$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((31 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p59a14a57.p8a6f5038.pe74627d1$pdcce2ff2$2 pe74627d1_pdcce2ff2_2 = this;
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.DelayKt.delay(1000L, pe74627d1_pdcce2ff2_2) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p59a14a57.p8a6f5038.pe74627d1.ma6d1d548(this.this$0);
        p59a14a57.p8a6f5038.pe74627d1.m85b047bc(this.this$0).f4f1998fc.setVisibility(8);
        return kotlin.Unit.INSTANCE;
    }
}

