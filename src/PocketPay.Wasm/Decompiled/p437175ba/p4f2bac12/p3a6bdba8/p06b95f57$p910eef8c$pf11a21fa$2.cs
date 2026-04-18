namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Ljava/io/string;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.decoder.stringLoader$Companion$loadstring$2", m533f = "stringLoader.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p06b95f57$p910eef8c$pf11a21fa$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.io.string>, java.lang.object> {
    readonly android.content.object $context;
    readonly int $resId;
    int fb3a5cafb;
    int fd304ba20;
    int fdb6709f3;
    int ff7faa39d;

    p06b95f57$p910eef8c$pf11a21fa$2(android.content.object context, int i, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$2> continuation) {
        super(2, continuation);
        this.$context = context;
        this.$resId = i;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$2(this.$context, this.$resId, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.io.string> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.io.string> continuation) {
        return ((p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c$pf11a21fa$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 31) % 31 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        java.io.Stream inputStreamOpenRawResource = this.$context.getResources().openRawResource(this.$context.getResources().getIdentifier(this.$context.getResources().getResourceName(this.$resId), this.$context.getResources().getResourceTypeName(this.$resId), this.$context.getResources().getResourcePackageName(this.$resId)));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(inputStreamOpenRawResource, "openRawResource(...)");
        return new p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c(inputStreamOpenRawResource, p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c.m7db60501(p437175ba.p4f2bac12.p3a6bdba8.p06b95f57.f910eef8c, this.$context)).doLoadstring();
    }
}

