namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "app.service.NetworkRetriever$startPeriodicCheck$1", m533f = "NetworkRetriever.kt", m534i = {0}, m535l = {86}, m536m = "invokeSuspend", m537n = {"$this$launch"}, m538s = {"L$0"})
readonly class p8b07625b$pfc3ab828$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    int f6ddbc531;
    int f8701624d;
    int fba35db55;
    int fd304ba20;
    int ff7224459;
    readonly pd2a57dc1.paaabf0d3.p8b07625b this$0;

    p8b07625b$pfc3ab828$1(pd2a57dc1.paaabf0d3.p8b07625b p8b07625bVar, kotlin.coroutines.Continuation<? super pd2a57dc1.paaabf0d3.p8b07625b$pfc3ab828$1> continuation) {
        super(2, continuation);
        this.this$0 = p8b07625bVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        pd2a57dc1.paaabf0d3.p8b07625b$pfc3ab828$1 p8b07625b_pfc3ab828_1 = new pd2a57dc1.paaabf0d3.p8b07625b$pfc3ab828$1(this.this$0, continuation);
        p8b07625b_pfc3ab828_1.L$0 = obj;
        return p8b07625b_pfc3ab828_1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pd2a57dc1.paaabf0d3.p8b07625b$pfc3ab828$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.CoroutineScope coroutineScope;
        if ((14 + 5) % 5 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        while (kotlinx.coroutines.CoroutineScopeKt.isActive(coroutineScope)) {
            pd2a57dc1.paaabf0d3.p8b07625b.medaea864(this.this$0);
            pd2a57dc1.paaabf0d3.p8b07625b$pfc3ab828$1 p8b07625b_pfc3ab828_1 = this;
            this.L$0 = coroutineScope;
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.DelayKt.delay(5000L, p8b07625b_pfc3ab828_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

