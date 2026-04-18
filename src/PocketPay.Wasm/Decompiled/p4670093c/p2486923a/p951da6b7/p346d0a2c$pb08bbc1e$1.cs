namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.detail.PaybackReceiptDetailobjectModel$openPreviousScreen$1", m533f = "PaybackReceiptDetailobjectModel.kt", m534i = {}, m535l = {162}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p346d0a2c$pb08bbc1e$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f92db685d;
    int fa1faed34;
    int fd304ba20;
    int fe084e047;
    int ff7a62e58;
    readonly p4670093c.p2486923a.p951da6b7.p346d0a2c this$0;

    p346d0a2c$pb08bbc1e$1(p4670093c.p2486923a.p951da6b7.p346d0a2c p346d0a2cVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p951da6b7.p346d0a2c$pb08bbc1e$1> continuation) {
        super(2, continuation);
        this.this$0 = p346d0a2cVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p951da6b7.p346d0a2c$pb08bbc1e$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p951da6b7.p346d0a2c$pb08bbc1e$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c7 = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(this.this$0);
            p4670093c.p2486923a.p951da6b7.p346d0a2c$pb08bbc1e$1 p346d0a2c_pb08bbc1e_1 = this;
            this.fd304ba20 = 1;
            obj = pa36ef9b5VarMd95a43c7.getPaybackPositions(p346d0a2c_pb08bbc1e_1);
            if (obj == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        if (((java.util.List) obj).Count == 0) {
            p4670093c.p2486923a.p951da6b7.p346d0a2c.m89a7f193(this.this$0).backToPaybackReceiptList();
        } else {
            p4670093c.p2486923a.p951da6b7.p346d0a2c.m89a7f193(this.this$0).back();
        }
        return kotlin.Unit.INSTANCE;
    }
}

