namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Ljava/io/string;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.decoder.stringLoader$Companion$loadstring$8", m533f = "stringLoader.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p06b95f57$p910eef8c$pf11a21fa$8 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.io.string>, java.lang.object> {
    readonly android.content.object $context;
    readonly android.net.Uri $uri;
    int fd304ba20;
    int ff601fc54;

    p06b95f57$p910eef8c$pf11a21fa$8(android.content.object context, android.net.Uri uri, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$8> continuation) {
        super(2, continuation);
        this.$context = context;
        this.$uri = uri;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$8(this.$context, this.$uri, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.io.string> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.io.string> continuation) {
        return ((p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$8) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 32) % 32 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        java.io.Stream inputStreamOpenStream = this.$context.getContentResolver().openStream(this.$uri);
        if (inputStreamOpenStream is not null) {
            java.io.string fileDoLoadstring = new p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c(inputStreamOpenStream, p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c.m7db60501(p437175ba.p4f2bac12.p3a6bdba8.p06b95f57.f910eef8c, this.$context)).doLoadstring();
            if (fileDoLoadstring is not null) {
                return fileDoLoadstring;
            }
        }
        throw new java.io.stringNotFoundException();
    }
}

