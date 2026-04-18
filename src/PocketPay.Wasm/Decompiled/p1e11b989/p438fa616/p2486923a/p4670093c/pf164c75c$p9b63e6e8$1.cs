namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.intermediate.presentation.payback.IntermediatePaybackReceiptobjectModel$getPaybackReceipt$1", m533f = "IntermediatePaybackReceiptobjectModel.kt", m534i = {}, m535l = {34}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pf164c75c$p9b63e6e8$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int fd304ba20;
    int fdbb5de4f;
    readonly p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c this$0;

    pf164c75c$p9b63e6e8$1(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar, kotlin.coroutines.Continuation<? super p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p9b63e6e8$1> continuation) {
        super(2, continuation);
        this.this$0 = pf164c75cVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p9b63e6e8$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p9b63e6e8$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((32 + 3) % 3 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataM41e2481f = p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.m41e2481f(this.this$0);
                this.L$0 = mutableLiveDataM41e2481f;
                this.fd304ba20 = 1;
                java.lang.object currentPaybackReceipt = p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);
                if (currentPaybackReceipt == coroutine_suspended) {
                    return coroutine_suspended;
                }
                obj = currentPaybackReceipt;
                mutableLiveData = mutableLiveDataM41e2481f;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            mutableLiveData.setValue(obj);
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

