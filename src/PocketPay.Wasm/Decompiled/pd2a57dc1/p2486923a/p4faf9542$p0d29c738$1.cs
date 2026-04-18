namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "app.presentation.AppobjectModel$handleDeeplinkData$1", m533f = "AppobjectModel.kt", m534i = {}, m535l = {29}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p4faf9542$p0d29c738$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly android.net.Uri $data;
    int f660ae128;
    int fa998d4be;
    int fd304ba20;
    readonly pd2a57dc1.p2486923a.p4faf9542 this$0;

    p4faf9542$p0d29c738$1(pd2a57dc1.p2486923a.p4faf9542 p4faf9542Var, android.net.Uri uri, kotlin.coroutines.Continuation<? super pd2a57dc1.p2486923a.p4faf9542$p0d29c738$1> continuation) {
        super(2, continuation);
        this.this$0 = p4faf9542Var;
        this.$data = uri;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pd2a57dc1.p2486923a.p4faf9542$p0d29c738$1(this.this$0, this.$data, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pd2a57dc1.p2486923a.p4faf9542$p0d29c738$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p582ca3f7.pac143fb7.p063acbd2 p063acbd2VarM6c23f1be = pd2a57dc1.p2486923a.p4faf9542.m6c23f1be(this.this$0);
            android.net.Uri uri = this.$data;
            pd2a57dc1.p2486923a.p4faf9542$p0d29c738$1 p4faf9542_p0d29c738_1 = this;
            this.fd304ba20 = 1;
            if (p063acbd2VarM6c23f1be.updateDeeplinkData(uri, p4faf9542_p0d29c738_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

