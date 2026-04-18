namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.detail.PaybackReceiptDetailobjectModel$getPaybackReceipt$1$paybackReceiptJob$1", m533f = "PaybackReceiptDetailobjectModel.kt", m534i = {}, m535l = {57}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p346d0a2c$p9b63e6e8$1$p497af732$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p18cf5223>, java.lang.object> {
    int f2a395538;
    int f5c3e7f1a;
    int f8423e833;
    int fc3ce4e3f;
    int fd304ba20;
    readonly p4670093c.p2486923a.p951da6b7.p346d0a2c this$0;

    p346d0a2c$p9b63e6e8$1$p497af732$1(p4670093c.p2486923a.p951da6b7.p346d0a2c p346d0a2cVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1$p497af732$1> continuation) {
        super(2, continuation);
        this.this$0 = p346d0a2cVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1$p497af732$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p18cf5223> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p18cf5223> continuation) {
        return ((p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1$p497af732$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 5) % 5 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c7 = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(this.this$0);
        p4670093c.p2486923a.p951da6b7.p346d0a2c$p9b63e6e8$1$p497af732$1 p346d0a2c_p9b63e6e8_1_p497af732_1 = this;
        this.fd304ba20 = 1;
        java.lang.object currentPaybackReceipt = pa36ef9b5VarMd95a43c7.getCurrentPaybackReceipt(p346d0a2c_p9b63e6e8_1_p497af732_1);
        return currentPaybackReceipt != coroutine_suspended ? currentPaybackReceipt : coroutine_suspended;
    }
}

