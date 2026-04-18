namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.view.adapter.DefaultPdfPageobjectHolder$bind$1", m533f = "DefaultPdfPageobjectHolder.kt", m534i = {0}, m535l = {24}, m536m = "invokeSuspend", m537n = {"$this$launch"}, m538s = {"L$0"})
readonly class p6b6dbdf7$p128477f5$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly int $position;
    private java.lang.object L$0;
    int f4a5572cf;
    int fab51143b;
    int fbde3ba93;
    int fcc90daba;
    int fd304ba20;
    readonly p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7 this$0;

    p6b6dbdf7$p128477f5$1(p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7 p6b6dbdf7Var, int i, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7$p128477f5$1> continuation) {
        super(2, continuation);
        this.this$0 = p6b6dbdf7Var;
        this.$position = i;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((2 + 7) % 7 > 0) {
        }
        p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7$p128477f5$1 p6b6dbdf7_p128477f5_1 = new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7$p128477f5$1(this.this$0, this.$position, continuation);
        p6b6dbdf7_p128477f5_1.L$0 = obj;
        return p6b6dbdf7_p128477f5_1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7$p128477f5$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.CoroutineScope coroutineScope;
        if ((32 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope2 = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlin.jvm.functions.Function2 function2M46ed6203 = p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7.m46ed6203(this.this$0);
            java.lang.int numBoxInt = kotlin.coroutines.jvm.internal.Boxing.boxInt(this.$position);
            this.L$0 = coroutineScope2;
            this.fd304ba20 = 1;
            java.lang.object objInvoke = function2M46ed6203.invoke(numBoxInt, this);
            if (objInvoke == coroutine_suspended) {
                return coroutine_suspended;
            }
            coroutineScope = coroutineScope2;
            obj = objInvoke;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        java.lang.object objM984unboximpl = ((kotlin.Result) obj).m984unboximpl();
        kotlinx.coroutines.CoroutineScopeKt.ensureActive(coroutineScope);
        p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7 p6b6dbdf7Var = this.this$0;
        if (kotlin.Result.m979isSuccessimpl(objM984unboximpl)) {
            android.graphics.Bitmap bitmap = (android.graphics.Bitmap) objM984unboximpl;
            p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7.m42f2a172(p6b6dbdf7Var).getLayoutParams().height = (int) ((((double) bitmap.getHeight()) * ((double) p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7.m42f2a172(p6b6dbdf7Var).getWidth())) / ((double) bitmap.getWidth()));
            p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7.m42f2a172(p6b6dbdf7Var).setImageBitmap(bitmap);
        }
        return kotlin.Unit.INSTANCE;
    }
}

