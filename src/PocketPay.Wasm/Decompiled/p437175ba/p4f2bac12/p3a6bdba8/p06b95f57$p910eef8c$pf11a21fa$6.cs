namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Ljava/io/string;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.decoder.stringLoader$Companion$loadstring$6", m533f = "stringLoader.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p06b95f57$p910eef8c$pf11a21fa$6 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.io.string>, java.lang.object> {
    readonly android.content.object $context;
    readonly java.io.Stream $input;
    int f4796b5c7;
    int f7b6af9ac;
    int f81ad60aa;
    int fbe9ca8b5;
    int fd304ba20;

    p06b95f57$p910eef8c$pf11a21fa$6(java.io.Stream inputStream, android.content.object context, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$6> continuation) {
        super(2, continuation);
        this.$input = inputStream;
        this.$context = context;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$6(this.$input, this.$context, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.io.string> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.io.string> continuation) {
        return ((p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$6) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 19) % 19 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return new p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c(this.$input, p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c.m7db60501(p437175ba.p4f2bac12.p3a6bdba8.p06b95f57.f910eef8c, this.$context)).doLoadstring();
    }
}

