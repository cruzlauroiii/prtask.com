namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.edit.EditSellReceiptobjectModel$getReceiptPositions$1", m533f = "EditSellReceiptobjectModel.kt", m534i = {}, m535l = {52}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2589267a$paf36a87b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f4265592d;
    int f44a1a641;
    int fd304ba20;
    int fee6e4583;
    readonly p8325324b.p2486923a.pde95b43b.p2589267a this$0;

    p2589267a$paf36a87b$1(p8325324b.p2486923a.pde95b43b.p2589267a p2589267aVar, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.pde95b43b.p2589267a$paf36a87b$1> continuation) {
        super(2, continuation);
        this.this$0 = p2589267aVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.pde95b43b.p2589267a$paf36a87b$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.pde95b43b.p2589267a$paf36a87b$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((27 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p8325324b.p2486923a.pde95b43b.p2589267a.m73680614(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                this.fd304ba20 = 1;
                if (p8325324b.p2486923a.pde95b43b.p2589267a.m025bedbb(this.this$0, this) == coroutine_suspended) {
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

