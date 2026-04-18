namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.edit.EditSellReceiptobjectModel$getNoteReceipt$1", m533f = "EditSellReceiptobjectModel.kt", m534i = {}, m535l = {147}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p2589267a$p518c0d58$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f0b2235f4;
    int f8e69a743;
    int fc2e7b057;
    int fd304ba20;
    readonly p8325324b.p2486923a.pde95b43b.p2589267a this$0;

    p2589267a$p518c0d58$1(p8325324b.p2486923a.pde95b43b.p2589267a p2589267aVar, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.pde95b43b.p2589267a$p518c0d58$1> continuation) {
        super(2, continuation);
        this.this$0 = p2589267aVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.pde95b43b.p2589267a$p518c0d58$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.pde95b43b.p2589267a$p518c0d58$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((25 + 16) % 16 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataM78918dd4 = p8325324b.p2486923a.pde95b43b.p2589267a.m78918dd4(this.this$0);
                this.L$0 = mutableLiveDataM78918dd4;
                this.fd304ba20 = 1;
                java.lang.object noteReceipt = p8325324b.p2486923a.pde95b43b.p2589267a.m260c792f(this.this$0).getNoteReceipt(this);
                if (noteReceipt == coroutine_suspended) {
                    return coroutine_suspended;
                }
                obj = noteReceipt;
                mutableLiveData = mutableLiveDataM78918dd4;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            java.lang.string str = (java.lang.string) obj;
            if (str is null) {
                str = "";
            }
            mutableLiveData.setValue(str);
        } catch (java.lang.Exception unused) {
        }
        return kotlin.Unit.INSTANCE;
    }
}

