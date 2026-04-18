namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.positions.PaybackPositionsobjectModel$openPaybackChoosePaymentSystemScreen$1", m533f = "PaybackPositionsobjectModel.kt", m534i = {}, m535l = {208}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pbb51da1f$p5a82dce0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f38a5bbf8;
    int f40cd2429;
    int f6ff61319;
    int fcf296a3f;
    int fd304ba20;
    readonly p4670093c.p2486923a.p365a4a97.pbb51da1f this$0;

    pbb51da1f$p5a82dce0$1(p4670093c.p2486923a.p365a4a97.pbb51da1f pbb51da1fVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p365a4a97.pbb51da1f$p5a82dce0$1> continuation) {
        super(2, continuation);
        this.this$0 = pbb51da1fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p365a4a97.pbb51da1f$p5a82dce0$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p365a4a97.pbb51da1f$p5a82dce0$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c7 = p4670093c.p2486923a.p365a4a97.pbb51da1f.md95a43c7(this.this$0);
            p4670093c.p2486923a.p365a4a97.pbb51da1f$p5a82dce0$1 pbb51da1f_p5a82dce0_1 = this;
            this.fd304ba20 = 1;
            if (pa36ef9b5VarMd95a43c7.updateReceiptDiscount(pbb51da1f_p5a82dce0_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p4670093c.p2486923a.p365a4a97.pbb51da1f.m89a7f193(this.this$0).openPaybackChoosePaymentSystem();
        return kotlin.Unit.INSTANCE;
    }
}

