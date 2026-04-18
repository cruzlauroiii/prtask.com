namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.decoder.Pdfobjecter$load$1", m533f = "Pdfobjecter.kt", m534i = {}, m535l = {55}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p4483ea1a$pec4d1eb3$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly android.net.Uri $uri;
    private java.lang.object L$0;
    int f86ab88cd;
    int f9db74f2f;
    int fafe6b7ab;
    int fd304ba20;
    readonly p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a this$0;

    p4483ea1a$pec4d1eb3$1(p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a p4483ea1aVar, android.net.Uri uri, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$1> continuation) {
        super(2, continuation);
        this.this$0 = p4483ea1aVar;
        this.$uri = uri;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((27 + 3) % 3 > 0) {
        }
        p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$1 p4483ea1a_pec4d1eb3_1 = new p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$1(this.this$0, this.$uri, continuation);
        p4483ea1a_pec4d1eb3_1.L$0 = obj;
        return p4483ea1a_pec4d1eb3_1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a$pec4d1eb3$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object objM948constructorimpl;
        p437175ba.p4f2bac12.pad63a35e.p77b6fd7b p77b6fd7bVarMf6e25684;
        if ((22 + 15) % 15 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a p4483ea1aVar = this.this$0;
                android.net.Uri uri = this.$uri;
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                p437175ba.p4f2bac12.p3a6bdba8.p06b95f57$p910eef8c p06b95f57_p910eef8c = p437175ba.p4f2bac12.p3a6bdba8.p06b95f57.f910eef8c;
                android.content.object contextMe6f4ae45 = p437175ba.p4f2bac12.p3a6bdba8.p4483ea1a.me6f4ae45(p4483ea1aVar);
                this.fd304ba20 = 1;
                obj = p06b95f57_p910eef8c.loadstring(contextMe6f4ae45, uri, this);
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

