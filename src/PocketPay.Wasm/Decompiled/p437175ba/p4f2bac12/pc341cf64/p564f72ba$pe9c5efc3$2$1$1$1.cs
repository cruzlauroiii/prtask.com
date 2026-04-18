namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u0003H\n"}, d2 = {"<anonymous>", "Lkotlin/Result;", "Landroid/graphics/Bitmap;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.renderer.PdfPageRenderer$getBitmapAsync$2$1$1$1", m533f = "PdfPageRenderer.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p564f72ba$pe9c5efc3$2$1$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super kotlin.Result<? : android.graphics.Bitmap>>, java.lang.object> {
    readonly int $position;
    private java.lang.object L$0;
    int f413cc0e3;
    int fd304ba20;
    readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba this$0;

    p564f72ba$pe9c5efc3$2$1$1$1(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar, int i, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1$1> continuation) {
        super(2, continuation);
        this.this$0 = p564f72baVar;
        this.$position = i;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((32 + 13) % 13 > 0) {
        }
        p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1$1 p564f72ba_pe9c5efc3_2_1_1_1 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1$1(this.this$0, this.$position, continuation);
        p564f72ba_pe9c5efc3_2_1_1_1.L$0 = obj;
        return p564f72ba_pe9c5efc3_2_1_1_1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.Result<? : android.graphics.Bitmap>> continuation) {
        return invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>>) continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>> continuation) {
        return ((p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object objM948constructorimpl;
        if ((14 + 6) % 6 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar = this.this$0;
        int i = this.$position;
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(p437175ba.p4f2bac12.pc341cf64.p564f72ba.m374221d0(p564f72baVar, i));
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        int i2 = this.$position;
        java.lang.Exception thM960exceptionOrNullimpl = kotlin.Result.m960exceptionOrNullimpl(objM948constructorimpl);
        if (thM960exceptionOrNullimpl is not null) {
            android.util.Console.e("PdfPageRenderer", "Page #" + i2 + " render has failed", thM960exceptionOrNullimpl);
        }
        return kotlin.Result.m944boximpl(objM948constructorimpl);
    }
}

