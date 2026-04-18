namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.choose.SellReceiptChoosePaySystemobjectModel$setShouldPrintReceipt$1", m533f = "SellReceiptChoosePaySystemobjectModel.kt", m534i = {}, m535l = {119}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p65e903ab$p581e088e$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly bool $shouldPrintReceipt;
    int f49da6dd0;
    int f617868e2;
    int fcd2e63f8;
    int fd304ba20;
    int feaf42e91;
    readonly p8325324b.p2486923a.pebd73ade.p65e903ab this$0;

    p65e903ab$p581e088e$1(p8325324b.p2486923a.pebd73ade.p65e903ab p65e903abVar, bool z, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.pebd73ade.p65e903ab$p581e088e$1> continuation) {
        super(2, continuation);
        this.this$0 = p65e903abVar;
        this.$shouldPrintReceipt = z;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.pebd73ade.p65e903ab$p581e088e$1(this.this$0, this.$shouldPrintReceipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.pebd73ade.p65e903ab$p581e088e$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                if (p8325324b.p2486923a.pebd73ade.p65e903ab.m260c792f(this.this$0).setShouldPrintReceipt(this.$shouldPrintReceipt, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

