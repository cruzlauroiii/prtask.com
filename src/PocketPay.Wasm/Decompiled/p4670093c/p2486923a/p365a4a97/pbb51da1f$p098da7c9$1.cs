namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.positions.PaybackPositionsobjectModel$resetNoteReceiptWithMessage$1", m533f = "PaybackPositionsobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pbb51da1f$p098da7c9$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f1f6c3723;
    int f3ebb6e11;
    int f7dadc5ce;
    int fcc00fe04;
    int fd304ba20;
    readonly p4670093c.p2486923a.p365a4a97.pbb51da1f this$0;

    pbb51da1f$p098da7c9$1(p4670093c.p2486923a.p365a4a97.pbb51da1f pbb51da1fVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p365a4a97.pbb51da1f$p098da7c9$1> continuation) {
        super(2, continuation);
        this.this$0 = pbb51da1fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p365a4a97.pbb51da1f$p098da7c9$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p365a4a97.pbb51da1f$p098da7c9$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 23) % 23 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        this.this$0.resetNoteReceipt();
        p4670093c.p2486923a.p365a4a97.pbb51da1f.me4058cef(this.this$0, new pad5f82e8.p07214c67.pe907423b.p37f460dd(p4670093c.p2486923a.p365a4a97.pbb51da1f.m5fb81a65(this.this$0).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p4670093c.p8a5da52e.R$string.note_receipt_delete_message)));
        return kotlin.Unit.INSTANCE;
    }
}

