namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001*\u00020\u0004H\n"}, d2 = {"<anonymous>", "Lkotlinx/coroutines/Deferred;", "Lkotlin/Result;", "Landroid/graphics/Bitmap;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.renderer.PdfPageRenderer$getBitmapAsync$2$1$1", m533f = "PdfPageRenderer.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p564f72ba$pe9c5efc3$2$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super kotlinx.coroutines.Deferred<? : kotlin.Result<? : android.graphics.Bitmap>>>, java.lang.object> {
    readonly int $position;
    private java.lang.object L$0;
    int fad22ec9b;
    int fd304ba20;
    readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba this$0;

    p564f72ba$pe9c5efc3$2$1$1(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar, int i, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1> continuation) {
        super(2, continuation);
        this.this$0 = p564f72baVar;
        this.$position = i;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((22 + 16) % 16 > 0) {
        }
        p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1 p564f72ba_pe9c5efc3_2_1_1 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1(this.this$0, this.$position, continuation);
        p564f72ba_pe9c5efc3_2_1_1.L$0 = obj;
        return p564f72ba_pe9c5efc3_2_1_1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlinx.coroutines.Deferred<? : kotlin.Result<? : android.graphics.Bitmap>>> continuation) {
        return invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>>>) continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>>> continuation) {
        return ((p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 16) % 16 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return kotlinx.coroutines.BuildersKt.async$default((kotlinx.coroutines.CoroutineScope) this.L$0, null, null, new p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1$1(this.this$0, this.$position, null), 3, null);
    }
}

