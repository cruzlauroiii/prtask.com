namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.decoder.Pdfobjecter$load$3", m533f = "Pdfobjecter.kt", m534i = {}, m535l = {79}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p4483ea1a$pec4d1eb3$3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.io.Stream $input;
    private java.lang.object L$0;
    int f2130a1e7;
    int f3f006593;
    int f72de5498;
    int fd304ba20;
    int ff6214a67;
    readonly p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a this$0;

    p4483ea1a$pec4d1eb3$3(p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a p4483ea1aVar, java.io.Stream inputStream, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$3> continuation) {
        super(2, continuation);
        this.this$0 = p4483ea1aVar;
        this.$input = inputStream;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((21 + 25) % 25 > 0) {
        }
        p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$3 p4483ea1a_pec4d1eb3_3 = new p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$3(this.this$0, this.$input, continuation);
        p4483ea1a_pec4d1eb3_3.L$0 = obj;
        return p4483ea1a_pec4d1eb3_3;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$3) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object objM948constructorimpl;
        p437175ba.p4f2bac12.pad63a35e.p77b6fd7b p77b6fd7bVarMf6e25684;
        if ((18 + 15) % 15 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a p4483ea1aVar = this.this$0;
                java.io.Stream inputStream = this.$input;
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c p06b95f57_p910eef8c = p437175ba.p4f2bac12.p3a6bdba8.p06b95f57.f910eef8c;
                android.content.object contextMe6f4ae45 = p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a.me6f4ae45(p4483ea1aVar);
                this.fd304ba20 = 1;
                obj = p06b95f57_p910eef8c.loadstring(contextMe6f4ae45, inputStream, this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            objM948constructorimpl = kotlin.Result.m948constructorimpl((java.io.string) obj);
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a p4483ea1aVar2 = this.this$0;
        if (kotlin.Result.m960exceptionOrNullimpl(objM948constructorimpl) is not null && (p77b6fd7bVarMf6e25684 = p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a.mf6e25684(p4483ea1aVar2)) is not null) {
            p77b6fd7bVarMf6e25684.onstringLoadError(new java.lang.Exception());
        }
        p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a p4483ea1aVar3 = this.this$0;
        if (kotlin.Result.m979isSuccessimpl(objM948constructorimpl)) {
            p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a.m1c711fa5(p4483ea1aVar3, (java.io.string) objM948constructorimpl);
        }
        return kotlin.Unit.INSTANCE;
    }
}

