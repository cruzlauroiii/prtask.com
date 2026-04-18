namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.domain.usecase.logout.ConsoleoutUseCaseImpl$logout$2", m533f = "ConsoleoutUseCaseImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p1256ed63$p4236a440$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f74e64fee;
    int fc2b67870;
    int fd304ba20;
    int fd500077e;
    int ffa9413d5;
    readonly p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63 this$0;

    p1256ed63$p4236a440$2(p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63 p1256ed63Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63$p4236a440$2> continuation) {
        super(2, continuation);
        this.this$0 = p1256ed63Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63$p4236a440$2(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63$p4236a440$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p2e5d8aa3.pad5f82e8.pac143fb7.p4236a440.p1256ed63.mf2d1c811(this.this$0).clearAllTables();
        return kotlin.Unit.INSTANCE;
    }
}

